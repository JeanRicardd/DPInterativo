using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPInterativo.Classes;

namespace DPInterativo.Formularios
{
    public partial class FormDecimoTerceiro : Form
    {
        Valores valores = new Valores();
        public FormDecimoTerceiro()
        {
            InitializeComponent();
            dataAutomatica.Checked = true;
            txtData.Enabled = false;
            txt1Parcela.Enabled = false;
            txt2Parcela.Enabled = false;
            txtUnica.Enabled = false;
            txtINSS.Enabled = false;
            txtIRRF.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDeducao.Text == "")
            {
                txtDeducao.Text = 0.ToString();
            }
            Calcular();
        }

        private void dataManual_CheckedChanged(object sender, EventArgs e)
        {
            txtData.Enabled = true;
            txtData.Text = "";
        }

        private void dataAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            txtData.Enabled = false;
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FormDecimoTerceiro_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Area do calculo de 13º Salário está em desenvolvimento !", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Calcular()
        {           
            if (txtValor.Text == "" || txtMes.Text == "")
             {
                 MessageBox.Show("Não é possível fazer o calculo com campos de soma vazios !!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }
             double valor = Convert.ToDouble(txtValor.Text);
             double meses = Convert.ToDouble(txtMes.Text);
             double valorDeducao = 0 + Convert.ToDouble(txtDeducao.Text);

            if (valor > 0 && valor <= 1045.00)
            {
                double valorINSS = valor - 0;
                double valorAliquota = valorINSS * 7.5 / 100;
                double soma = valorAliquota;
                //MessageBox.Show(soma.ToString());
                lblINSS.Text = soma.ToString();
            }
            else if (valor >= 1045.01 && valor <= 2089.60)
            {
                double novoValor = ((valor / 12) * meses);
                double valorINSS = novoValor - 1045.01;
                double valorAliquota = valorINSS * 9 / 100;
                double soma = valorAliquota + 78.38;
                //MessageBox.Show(soma.ToString());
                lblINSS.Text = soma.ToString();
            }
            else if (valor >= 2089.61 && valor <= 3134.40)
            {
                double novoValor = (valor / 12) * meses;
                double valorINSS = novoValor - 2089.61;
                double valorAliquota = valorINSS * 12 / 100;
                double soma = valorAliquota + 78.38 + 94.01;
                //MessageBox.Show(soma.ToString());
                lblINSS.Text = soma.ToString();
            }
            else if (valor >= 3134.41 && valor <= 6101.06)
            {
                double novoValor = (valor / 12) * meses;
                double valorINSS = novoValor - 3134.41;
                double valorAliquota = valorINSS * 14/100;
                double soma = valorAliquota + 78.38 + 94.01 + 125.37;
                //MessageBox.Show(soma.ToString());
                lblINSS.Text = soma.ToString();
            }
            else if (valor >= 6101.07)
            {
                double novoValor = (valor / 12) * meses;
                double valorINSS = novoValor - 3134.41;
                double valorAliquota = 713.09;
                lblINSS.Text = valorAliquota.ToString();
            }
            else
            {
                MessageBox.Show("Soma de calculo inexistente na tabela !!");
                return;
            }

            /*Imposto de Renda Retido na Fonte*/

            double INSS = Convert.ToDouble(lblINSS.Text);
            double deducao = 189.59;
            //MessageBox.Show(INSS.ToString());

            var valordecisao = valor - INSS;

            if (valorDeducao <= 0)
            {
                if (valordecisao < 1903.98)
                {
                    double conclusao = 0.0;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00", conclusao);
                }
                if (valordecisao >= 1903.99 && valordecisao <= 2826.65)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 7.5 / 100;
                    double conclusao = AliquotaIRRF - 142.80;
                    //MessageBox.Show(conclusao.ToString());
                    lblVar.Text = conclusao.ToString();
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= 2826.66 && valordecisao <= 3751.05)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 15 / 100;
                    double conclusao = AliquotaIRRF - 354.80;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
                else if (valordecisao >= 3751.05 && valordecisao <= 4664.67)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 22.5 / 100;
                    double conclusao = AliquotaIRRF - 636.13;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
                else if (valordecisao > 4664.68)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 27.5 / 100;
                    double conclusao = AliquotaIRRF - 869.36;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
            }
            else if (valorDeducao >= 1)
            {
                if (valordecisao < 1903.98)
                {
                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                    //lblVar.Text = 0.ToString();
                }
                else if (valordecisao >= 1903.99 && valordecisao <= 2826.65)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 7.5 / 100;
                    double conclusao = AliquotaIRRF - 142.80;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
                else if (valordecisao >= 2826.66 && valordecisao <= 3751.05)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 15 / 100;
                    double conclusao = AliquotaIRRF - 354.80;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
                else if (valordecisao >= 3751.05 && valordecisao <= 4664.67)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 22.5 / 100;
                    double conclusao = AliquotaIRRF - 636.13;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
                else if (valordecisao >= 4664.68)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 27.5 / 100;
                    double conclusao = AliquotaIRRF - 869.36;
                    txtIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    lblVar.Text = conclusao.ToString();
                }
            }

            /*--------------------------------*/
            /*
            if (lblVar.Text != null)
            {
                double IRRFVar = 0;
                valores.impostoRRF = IRRFVar;
            }
            else
            {
                double IRRFVar = Convert.ToDouble(lblVar.Text);
                valores.impostoRRF = IRRFVar;
            }*/

            double novoINSS = Convert.ToDouble(lblINSS.Text); 
            double Calculo = (valor / 12) * meses;
            //MessageBox.Show(Calculo.ToString());
            double primeiraParcela = Calculo / 2;
            //double INSS = (primeiraParcela * 8 / 100) * 2;
            //double INSSeIRRF = novoINSS + valores.impostoRRF;
            //double segundaParcela = primeiraParcela - INSSeIRRF;
            //double Unico = primeiraParcela + segundaParcela;





            /////
            txt1Parcela.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", primeiraParcela);
            //txt2Parcela.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", segundaParcela);
           // txtUnica.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Unico);
            txtINSS.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", INSS);


        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtDeducao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }
    }
}
