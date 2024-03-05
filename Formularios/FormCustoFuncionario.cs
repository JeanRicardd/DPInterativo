using DPInterativo.NovoFormPrincipal;
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
    public partial class FormCustoFuncionario : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormCustoFuncionario()
        {
            InitializeComponent();
            txtAlimentacao.Text = 0.ToString();
            txtRefeicao.Text = 0.ToString();
            txtSaude.Text = 0.ToString();
            txtOutros.Text = 0.ToString();
            txtSalarioBase.Text = 1000.ToString();
            Calcular();
        }


        public void Calcular()
        {
            if (txtSalarioBase.Text == "")
            {
                MessageBox.Show("Não é possivel calcular salário base sem valor :/", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtRefeicao.Text == "" || txtAlimentacao.Text == "" || txtSaude.Text == "" || txtOutros.Text == "")
            {
                txtRefeicao.Text = 0.ToString();
                txtAlimentacao.Text = 0.ToString();
                txtSaude.Text = 0.ToString();
                txtOutros.Text = 0.ToString();
            }



            double SalarioBase = Convert.ToDouble(txtSalarioBase.Text);
            double AuxilioRefeicao = Convert.ToDouble(txtRefeicao.Text);
            double AuxilioAlimentacao = Convert.ToDouble(txtAlimentacao.Text);
            double PlanoSaude = Convert.ToDouble(txtSaude.Text);
            double Outros = Convert.ToDouble(txtOutros.Text);

            double FGTSSalario = SalarioBase / 12.5;
            double Ferias1e12 = SalarioBase / 12;
            double a13Ferias1e12 = SalarioBase / 36;
            double a13salario1e12 = SalarioBase / 12;
            double FGTSFerias1e12 = SalarioBase / 150;
            double FGTS1e3Ferias1e12 = SalarioBase / 454.5;
            double FGTS13Salario1e12 = SalarioBase / 150;
            double AvisoPrevio1e12 = SalarioBase / 12;
            double FGTSAvisoPrevio = SalarioBase / 150;
            double MultaFGTS1e12 = (FGTSSalario+FGTSAvisoPrevio+FGTS13Salario1e12) * 40/100;
            //MessageBox.Show(MultaFGTS1e12.ToString());

            double Total = Outros+PlanoSaude+AuxilioAlimentacao+AuxilioRefeicao+FGTSSalario + Ferias1e12 + a13Ferias1e12 + a13salario1e12 + FGTSFerias1e12 + FGTS1e3Ferias1e12 + FGTS13Salario1e12 + AvisoPrevio1e12 + FGTSAvisoPrevio + MultaFGTS1e12;
            double MargemSeguranca = Total / 4;


            //Valores do primeiro painel



            txtFGTSSalario.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTSSalario);
            txtFerias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Ferias1e12);
            txt13ferias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", a13Ferias1e12);
            txt13salario112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", a13salario1e12);
            txtFGTSFerias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTSFerias1e12);
            txtFGTS13Ferias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTS1e3Ferias1e12);
            txtFGTS13Salario112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTS13Salario1e12);
            //txtAvisoPrevio.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", AvisoPrevio1e12);
            lblFGTSSalario.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTSSalario);
            lblFerias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Ferias1e12);
            lbl13ferias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", a13Ferias1e12);
            lbl13salario112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", a13salario1e12);
            lblFGTSFerias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTSFerias1e12);
            lblFGTS13Ferias112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTS1e3Ferias1e12);
            lblFGTS13Salario112.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTS13Salario1e12);
            lblAvisoPrevio.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", AvisoPrevio1e12);
            lblFGTSAvisoPrevio.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTSAvisoPrevio);
            lblMultaFGTS.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", MultaFGTS1e12);
            lblTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Total);
            //txtFGTSAvisoPrevio.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", FGTSAvisoPrevio);
            //txtMultaFGTS.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", MultaFGTS1e12);

            txtAlimentacao.Text = AuxilioAlimentacao.ToString();
            txtRefeicao.Text = AuxilioRefeicao.ToString();
            txtSaude.Text = PlanoSaude.ToString();
            txtOutros.Text = Outros.ToString();

            // Valores do segundo painel
            //txtTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", Total);
            //txtSeguranca.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", MargemSeguranca);
            lblSeguranca.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", MargemSeguranca);
            //MessageBox.Show(Total.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRefeicao.Text == "")
            {
                txtRefeicao.Text = 0.ToString();
            }
            if (txtAlimentacao.Text == "")
            {
                txtAlimentacao.Text = 0.ToString();
            }
            if (txtSaude.Text == "")
            {
                txtSaude.Text = 0.ToString();
            }
            if (txtOutros.Text == "")
            {
                txtOutros.Text = 0.ToString();
            }
            Calcular();
        }

        private void txtSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);

            }
        }

        private void txtRefeicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
            //Calcular();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtAlimentacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //btnCalcular_Click(sender, e);
                Calcular();
            }
        }

        private void txtSaude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //btnCalcular_Click(sender, e);
                Calcular();
            }
        }

        private void txtOutros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //btnCalcular_Click(sender, e);
                Calcular();
            }

        }
        private void txtSalarioBase_TextChanged(object sender, EventArgs e)
        {
            txtSalarioBase.Text = Regex.Replace(txtSalarioBase.Text, "[^0-9,.]", "");
        }

        private void txtRefeicao_TextChanged(object sender, EventArgs e)
        {
            txtRefeicao.Text = Regex.Replace(txtRefeicao.Text, "[^0-9,.]", "");
        }

        private void txtAlimentacao_TextChanged(object sender, EventArgs e)
        {
            txtAlimentacao.Text = Regex.Replace(txtAlimentacao.Text, "[^0-9,.]", "");
        }

        private void txtSaude_TextChanged(object sender, EventArgs e)
        {
            txtSaude.Text = Regex.Replace(txtSaude.Text, "[^0-9,.]", "");
        }

        private void txtOutros_TextChanged(object sender, EventArgs e)
        {
            txtOutros.Text = Regex.Replace(txtOutros.Text, "[^0-9,.]", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCustoFuncionario_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormCustoFuncionario_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormCustoFuncionario_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
