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
    public partial class FormIRRF : Form
    {
        public FormIRRF()
        {
            InitializeComponent();
            txtValorTotal.Enabled = false;
            lblINSS.Visible = false;
            //txtDeducao.Enabled = false;
        }

        private void CalculoIRRF()
        {
            if (txtValor.Text == "" || txtDeducao.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }

            double valor = Convert.ToDouble(txtValor.Text);
            double valorDeducao = 0 + Convert.ToDouble(txtDeducao.Text);

            if (valor > 0 && valor <= 1100.00)
            {
                double valorfinal = valor * (7.5 / 100);
                lblINSS.Text = valorfinal.ToString();
            }
            else if (valor >= 1100.01 && valor <= 2203.48)
            {
                double calculo = ((valor - 1100.01) * 0.09) + 82.50;
                //double previdencia = calculo * 9 / 100;
                //double valorfinal = previdencia + 82.50;
                lblINSS.Text = calculo.ToString();
            }
            else if (valor >= 2203.49 && valor <= 3305.22)
            {
                double calculo = (((valor - 2203.49) * 0.12) + 82.50 + 99.31);
                double previdencia = calculo * 12 / 100;
                var valorfinal = previdencia + 82.50 + 99.31;
                lblINSS.Text = calculo.ToString();
            }
            else if (valor >= 3305.23 && valor <= 6433.57)
            {
                double calculo = (((valor - 3305.23) * 0.14) + 82.50 + 99.31 + 132.21);
                double previdencia = calculo * 14 / 100;
                var valorfinal = previdencia + 82.50 + 99.31 + 132.21;
                lblINSS.Text = calculo.ToString();
            }
            else if (valor >= 6433.58)
            {
                var INSSNovo = 751.97;
                lblINSS.Text = INSSNovo.ToString();
            }

            double INSS = Convert.ToDouble(lblINSS.Text);
            double deducao = 189.59;

            var valordecisao = valor - INSS;

            if (valorDeducao <= 0)
            {
                if (valordecisao < 1903.98)
                {

                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valordecisao >= 1903.99 && valordecisao <= 2826.65)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 7.5 / 100;
                    double conclusao = AliquotaIRRF - 142.80;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= 2826.66 && valordecisao <= 3751.05)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 15 / 100;
                    double conclusao = AliquotaIRRF - 354.80;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= 3751.06 && valordecisao <= 4664.67)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 22.5 / 100;
                    double conclusao = AliquotaIRRF - 636.13;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao > 4664.68)
                {
                    double SubtracaoValor = valor - INSS;
                    double AliquotaIRRF = SubtracaoValor * 27.5 / 100;
                    double conclusao = AliquotaIRRF - 869.36;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }

            }
            else if (valorDeducao >= 1)
            {
                if (valordecisao < 1903.98)
                {
                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valordecisao >= 1903.99 && valordecisao <= 2826.65)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 7.5 / 100;
                    double conclusao = AliquotaIRRF - 142.80;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= 2826.66 && valordecisao <= 3751.05)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 15 / 100;
                    double conclusao = AliquotaIRRF - 354.80;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= 3751.05 && valordecisao <= 4664.67)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 22.5 / 100;
                    double conclusao = AliquotaIRRF - 636.13;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= 4664.68)
                {
                    double deducaoCalculada = deducao * valorDeducao;
                    double SubtracaoValor = valor - INSS - deducaoCalculada;
                    double AliquotaIRRF = SubtracaoValor * 27.5 / 100;
                    double conclusao = AliquotaIRRF - 869.36;
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoIRRF();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtDeducao_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtDeducao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDeducao_TextChanged(object sender, EventArgs e)
        {
            txtDeducao.Text = Regex.Replace(txtDeducao.Text, "[^0-9,.]", "");
        }
    }
}
