using Microsoft.SqlServer.Server;
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
    public partial class FormContribuicao : Form
    {
        public FormContribuicao()
        {
            InitializeComponent();
            txtResultado.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            ContribuicaoAssalariado();

        }
        public void ContribuicaoAssalariado()
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }

            double valor = Convert.ToDouble(txtValor.Text);

            if (valor >= 0 && valor <= 1100.00)
            {
                double valorfinal = valor * (7.5 / 100);
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                //txtResultado.Text = valorfinal.ToString();
            }
            else if (valor >= 1100.01 && valor <= 2203.48)
            {
                double calculo = ((valor - 1100.01) * 0.09) + 82.50;
                //double previdencia = calculo * 0.09;
                //double valorfinal = previdencia + 82.50;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //txtResultado.Text = valorfinal.ToString();
            }
            else if (valor >= 2203.49 && valor <= 3305.22)
            {
                double calculo = (((valor - 2203.49) * 0.12)+ 82.50 + 99.31);
                //double previdencia = calculo * 12 / 100;
                //var valorfinal = previdencia + 82.50 + 99.31;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //txtResultado.Text = valorfinal.ToString();
            }
            else if (valor >= 3305.23 && valor <= 6433.57)
            {
                double calculo = (((valor - 3305.23) * 0.14) + 82.50 + 99.31 + 132.21);
                //double previdencia = calculo * 14 / 100;
                //var valorfinal = previdencia + 82.50 + 99.31 + 132.21;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
                //txtResultado.Text = valorfinal.ToString();
            }
            else if (valor >= 6433.58)
            {
                double calculo = 751.97;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else
            {
                MessageBox.Show("Soma de calculo inexistente na tabela !!");
                return;
            }

            //txtResultado.Text = Convert.ToString(valorfinal);
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
    }
}
