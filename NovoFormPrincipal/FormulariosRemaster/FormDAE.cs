using DPInterativo.Classes;
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

namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    public partial class FormDAE : Form
    {
        string formulaDAE;
        double valorFora;
        public FormDAE()
        {
            InitializeComponent();
            Valores.SSF = "0";
        }

        private void CalculoDAENormal()
        {
            if (txtValorDAE.Text == "")
            {
                MessageBox.Show("Não deixe os campos vazios !!!");
                return;
            }

            double valor = Convert.ToDouble(txtValorDAE.Text);
            double contribuicao = valor * 8 / 100;
            double seguro = valor * (0.8 / 100); // Fazendo a função correta
            double FGTS = valor * 8 / 100;
            double Multa = valor * (3.2 / 100); // Fazendo a função correta
            double salarioFamilia = double.Parse(Valores.SSF);
            valorFora = salarioFamilia;

            /*Teste*/
            if (valor >= 0 && valor <= 1100.00)
            {
                double valorfinal = valor * (7.5 / 100);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                double valorCompleto = valorTotal - salarioFamilia;
                if (salarioFamilia > 0)
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + valorfinal + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Salario-Familia - R$ " + salarioFamilia + "\n" +
                                 "Total - R$ " + valorfinal + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " - R$ " + salarioFamilia + " = R$ " + valorCompleto;
                }
                else
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + valorfinal + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Total - R$ " + valorfinal + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " = R$ " + valorCompleto;
                }

                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorCompleto);
            }
            else if (valor >= 1100.01 && valor <= 2203.48)
            {
                double calculo = ((valor - 1100.01) * 0.09) + 82.50;
                //double previdencia = calculo * 0.09;
                //double valorfinal = previdencia + 82.50;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                double valorCompleto = valorTotal - salarioFamilia;
                if (salarioFamilia > 0)
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Salario-Familia - R$ " + salarioFamilia + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " - R$ " + salarioFamilia + " = R$ " + valorCompleto;
                }
                else
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " = R$ " + valorCompleto;
                }
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorCompleto);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //lblvalor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 2203.49 && valor <= 3305.22)
            {
                double calculo = (((valor - 2203.49) * 0.12) + 82.50 + 99.31);
                //double previdencia = calculo * 12 / 100;
                //var valorfinal = previdencia + 82.50 + 99.31;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                double valorCompleto = valorTotal - salarioFamilia;
                if (salarioFamilia > 0)
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Salario-Familia - R$ " + salarioFamilia + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " - R$ " + salarioFamilia + " = R$ " + valorCompleto;
                }
                else
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " = R$ " + valorCompleto;
                }
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorCompleto);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //lblvalor.Text = Convert.ToDouble(previdencia).ToString();
            }
            else if (valor >= 3305.23 && valor <= 6433.57)
            {
                double calculo = (((valor - 3305.23) * 0.14) + 82.50 + 99.31 + 132.21);
                //double previdencia = calculo * 14 / 100;
                //var valorfinal = previdencia + 82.50 + 99.31 + 132.21;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                double valorCompleto = valorTotal - salarioFamilia;
                if (salarioFamilia > 0)
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Salario-Familia - R$ " + salarioFamilia + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " - R$ " + salarioFamilia + " = R$ " + valorCompleto;
                }
                else
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " = R$ " + valorCompleto;
                }
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorCompleto);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else if (valor >= 6433.58)
            {
                double calculo = 751.98;
                var valorTotal = calculo + contribuicao + seguro + FGTS + Multa;
                double valorCompleto = valorTotal - salarioFamilia;
                if (salarioFamilia > 0)
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Salario-Familia - R$ " + salarioFamilia + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " - R$ " + salarioFamilia + " = R$ " + valorCompleto;
                }
                else
                {
                    formulaDAE = "Contribuição Patronal Previdenciária - R$ " + valor + " * 8% = R$ " + contribuicao + "\n" +
                                 "Contribuição Previdenciária - R$ " + valor + " * 0,8% = R$ " + calculo + "\n" +
                                 "GILRAT - R$ " + valor + " * 0,8% = R$ " + seguro + "\n" +
                                 "FGTS - R$ " + valor + " * 8% = R$ " + FGTS + "\n" +
                                 "Multa FGTS - R$ " + valor + " * 0,8% = R$ " + Multa + "\n" +
                                 "Total - R$ " + calculo + " + R$ " + contribuicao + " + R$ " + seguro + " + R$ " + FGTS + " + R$" + Multa + " = R$ " + valorCompleto;
                }
                txtFinal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorCompleto);
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

        private void txtValorDAE_TextChanged(object sender, EventArgs e)
        {
            txtValorDAE.Text = Regex.Replace(txtValorDAE.Text, "[^0-9,.]", "");
        }

        private void checkSF_Click(object sender, EventArgs e)
        {
            if (checkSF.Checked == true)
            {
                FormSalarioFamilia formSalarioFamilia = new FormSalarioFamilia();
                formSalarioFamilia.Show();
            }
            else if (checkSF.Checked == false)
            {
                Valores.SSF = "0";
            }
        }

        private void btnFormulaDAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veja como é feito o calculo: \n" + formulaDAE, "Formula matemática");
        }

        private void btnCalcularDAE_Click(object sender, EventArgs e)
        {
            CalculoDAENormal();
            btnFormulaDAE.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtValorDAE.Clear();
            txtContribuicao.Clear();
            txtPrevidencia.Clear();
            txtSeguro.Clear();
            txtFGTS.Clear();
            txtIndenizacao.Clear();
            txtFinal.Clear();

            if (checkSF.Checked == true)
            {
                checkSF.Checked = false;
            }
            Valores.SSF = 0.ToString();
        }

        private void txtValorDAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcularDAE_Click(sender, e);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnFormulaDAE.Enabled = false;
        }
    }
}
