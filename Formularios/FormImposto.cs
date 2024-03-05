using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.Formularios
{
    public partial class FormImposto : Form
    {
        ClasseImposto imposto = new ClasseImposto();

        public FormImposto()
        {
            InitializeComponent();
            //Size = new Size(497, 290);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Contribuicao();
            if (txtValor.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }
            else
            {
                if (check13parc1.Checked == true)
                {
                    Calculo13Parc1();
                }
                else if (check13parc1.Checked == false)
                {
                    CalculoNormal();
                }
            }

        }

        public void Calculo13Parc1()
        {
            if (txtMeses.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }
            double valor = Convert.ToDouble(txtValor.Text);
            double meses = Convert.ToDouble(txtMeses.Text);
            double calculoMesesTrabalhados = (valor / 12) * meses;
            double valorDividido2 = calculoMesesTrabalhados / 2;
            double valorSomado = valor + (valorDividido2 / 2);
            //MessageBox.Show(valorSomado.ToString());
            txt13parc1.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorDividido2);
            double contribuicao = valor * 8 / 100;
            double segurodv = valorDividido2 * (0.8 / 100); // Fazendo a função correta
            double seguro = segurodv * 2;
            double FGTS = valorSomado * 8 / 100;
            double Multa = valorSomado * (3.2 / 100); // Fazendo a função correta

            /*Teste*/
            if (valor >= 0 && valor <= 1100.00)
            {
                double valorfinal = valor * (7.5 / 100);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
            }
            else if (valor >= 1100.01 && valor <= 2203.48)
            {
                double calculo = valor - 1100.01;
                double previdencia = calculo * 0.09;
                double valorfinal = previdencia + 82.50;
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                //lblvalor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 2203.49 && valor <= 3305.22)
            {
                double calculo = valor - 2203.49;
                double previdencia = calculo * 12 / 100;
                var valorfinal = previdencia + 82.50 + 99.31;
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                //lblvalor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 3305.23 && valor <= 6433.57)
            {
                double calculo = valor - 3305.23;
                double previdencia = calculo * 14 / 100;
                var valorfinal = previdencia + 82.50 + 99.31 + 132.21;
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
            }
            else if (valor >= 6433.58)
            {
                double calculo = 751.98;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else
            {
                MessageBox.Show("Soma de calculo inexistente na tabela !!");
                return;
            }
            /*-------------*/

            txtContribuicao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", contribuicao);
            txtSeguro.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", seguro);
            txtFGTS.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTS);
            txtIndenizacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Multa);
        }

        public void CalculoNormal()
        {
            double valor = Convert.ToDouble(txtValor.Text);
            double contribuicao = valor * 8 / 100;
            double seguro = valor * (0.8 / 100); // Fazendo a função correta
            double FGTS = valor * 8 / 100;
            double Multa = valor * (3.2 / 100); // Fazendo a função correta

            /*Teste*/
            if (valor >= 0 && valor <= 1100.00)
            {
                double valorfinal = valor * (7.5 / 100);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
            }
            else if (valor >= 1100.01 && valor <= 2203.48)
            {
                double calculo = ((valor - 1100.01) * 0.09) + 82.50;
                //double previdencia = calculo * 0.09;
                //double valorfinal = previdencia + 82.50;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //lblvalor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 2203.49 && valor <= 3305.22)
            {
                double calculo = (((valor - 2203.49) * 0.12) + 82.50 + 99.31);
                //double previdencia = calculo * 12 / 100;
                //var valorfinal = previdencia + 82.50 + 99.31;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //lblvalor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 3305.23 && valor <= 6433.57)
            {
                double calculo = (((valor - 3305.23) * 0.14) + 82.50 + 99.31 + 132.21);
                //double previdencia = calculo * 14 / 100;
                //var valorfinal = previdencia + 82.50 + 99.31 + 132.21;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else if (valor >= 6433.58)
            {
                double calculo = 751.98;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else
            {
                MessageBox.Show("Soma de calculo inexistente na tabela !!");
                return;
            }
            /*-------------*/

            txtContribuicao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", contribuicao);
            txtSeguro.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", seguro);
            txtFGTS.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTS);
            txtIndenizacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Multa);
        }

        public void Contribuicao()//linha abaixo não é mais utilizada
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (valor > 0 && valor <= 1.045)
            {
                double previdencia = valor * (7.5 / 100);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", previdencia);
            }
            else if (valor >= 1045.01 && valor <= 2089.60)
            {
                    double calculo = valor - 1045.01;
                    double previdencia = calculo * 9/100;
                    double valorfinal = previdencia + 78.38;
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                //lblValor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 2089.61 && valor <= 3134.40)
            {
                double calculo = valor - 2089.01;
                double previdencia = calculo * 12 / 100;
                var valorfinal = previdencia + 78.38 + 94.01;
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                //lblValor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 3134.41 && valor <= 6101.06)
            {
                double calculo = valor - 3134.41;
                double previdencia = valor * (14 / 100);
                var valorfinal = previdencia + 78.38 + 94.01 + 125.37;
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
            }
            
        }

        private void FormImposto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = Regex.Replace(txtValor.Text, "[^0-9,.]", "");
        }

        private void check13parc1_CheckedChanged(object sender, EventArgs e)
        {
            FormImposto imposto = new FormImposto();

            if (check13parc1.Checked == true)
            {
                //-----------------------------------------------------------------------------------------------
                //-------------- REDIMENCIONAMENTO DOS OBJETOS --------------------------------------------------
                //-----------------------------------------------------------------------------------------------

                //13
                lbl13parc1.Visible = true;
                txt13parc1.Visible = true;

                lblMes.Visible = true;
                txtMeses.Visible = true;

                //Contribuicao
                txtContribuicao.Location = new Point(199, 127);
                lblContribuicao.Location = new Point(18, 128);

                //Previdencia
                txtPrevidencia.Location = new Point(199, 153);
                lblPrevidencia.Location = new Point(31, 156);

                //GILRAT
                txtSeguro.Location = new Point(199, 178);
                lblSeguro.Location = new Point(121, 181);

                //FGTS
                txtFGTS.Location = new Point(199, 204);
                lblFGTS.Location = new Point(132, 207);

                //Multa FGTS
                txtIndenizacao.Location = new Point(199, 230);
                lblIndenizacao.Location = new Point(103, 233);

                //Final
                txtFinal.Location = new Point(199, 256);
                lblFinal.Location = new Point(140, 259);

                Size = new Size(404, 336);
                panel1.Size = new Size(350, 68);
                check13parc1.Location = new Point(12, 86);

                //-----------------------------------------------------------------------------------------------
                //--------------- FIM DO REDIMENCIONAMENTO ------------------------------------------------------
                //-----------------------------------------------------------------------------------------------
            }
            else if (check13parc1.Checked == false)
            {
                //-----------------------------------------------------------------------------------------------
                //-------------- REDIMENCIONAMENTO DOS OBJETOS --------------------------------------------------
                //-----------------------------------------------------------------------------------------------

                //13
                lbl13parc1.Visible = false;
                txt13parc1.Visible = false;

                lblMes.Visible = false;
                txtMeses.Visible = false;

                //Contribuicao
                txtContribuicao.Location = new Point(199, 101);
                lblContribuicao.Location = new Point(19, 104);

                //Previdencia
                txtPrevidencia.Location = new Point(199, 127);
                lblPrevidencia.Location = new Point(32, 128);

                //GILRAT
                txtSeguro.Location = new Point(199, 153);
                lblSeguro.Location = new Point(122, 156);

                //FGTS
                txtFGTS.Location = new Point(199, 178);
                lblFGTS.Location = new Point(133, 181);

                //Multa FGTS
                txtIndenizacao.Location = new Point(199, 204);
                lblIndenizacao.Location = new Point(104, 207);

                //Final
                txtFinal.Location = new Point(199, 230);
                lblFinal.Location = new Point(138, 233);

                Size = new Size(404, 320);
                panel1.Size = new Size(350, 41);
                check13parc1.Location = new Point(12, 60);

                //-----------------------------------------------------------------------------------------------
                //--------------- FIM DO REDIMENCIONAMENTO ------------------------------------------------------
                //-----------------------------------------------------------------------------------------------

            }
        }

        private void FormImposto_Load(object sender, EventArgs e)
        {
            Size = new Size(404, 320);
            panel1.Size = new Size(350, 41);
            check13parc1.Location = new Point(12, 60);

            //13
            lbl13parc1.Visible = false;
            txt13parc1.Visible = false;

            lblMes.Visible = false;
            txtMeses.Visible = false;

            //Contribuicao
            txtContribuicao.Location = new Point(199, 101);
            lblContribuicao.Location = new Point(19, 104);

            //Previdencia
            txtPrevidencia.Location = new Point(199, 127);
            lblPrevidencia.Location = new Point(32, 128);

            //GILRAT
            txtSeguro.Location = new Point(199, 153);
            lblSeguro.Location = new Point(122, 156);

            //FGTS
            txtFGTS.Location = new Point(199, 178);
            lblFGTS.Location = new Point(133, 181);

            //Multa FGTS
            txtIndenizacao.Location = new Point(199, 204);
            lblIndenizacao.Location = new Point(104, 207);

            //Final
            txtFinal.Location = new Point(199, 230);
            lblFinal.Location = new Point(138, 233);

            txtMeses.Text = "1";
            txtMeses.Items.Add("1");
            txtMeses.Items.Add("2");
            txtMeses.Items.Add("3");
            txtMeses.Items.Add("4");
            txtMeses.Items.Add("5");
            txtMeses.Items.Add("6");
            txtMeses.Items.Add("7");
            txtMeses.Items.Add("8");
            txtMeses.Items.Add("9");
            txtMeses.Items.Add("10");
            txtMeses.Items.Add("11");
            txtMeses.Items.Add("12");

        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            txtMeses.Text = Regex.Replace(txtMeses.Text, "[^0-9,.]", "");
        }
    }
}
