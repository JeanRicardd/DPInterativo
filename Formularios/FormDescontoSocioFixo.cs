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

namespace DPInterativo.Formularios
{
    public partial class FormDescontoSocioFixo : Form
    {
        public FormDescontoSocioFixo()
        {
            InitializeComponent();
            txtResultado11.Enabled = false;
            txtResultado20.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtvalor11.Text == "" || txtvalor20.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios !!!!");
                return;
            }

            double v11 = Convert.ToDouble(txtvalor11.Text);
            double v20 = Convert.ToDouble(txtvalor20.Text);

            double calculov11 = v11 * 11 / 100;
            double calculo20 = v20 * 20 / 100;

            txtResultado11.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculov11);
            txtResultado20.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo20);

        }

        private void txtvalor11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtvalor20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }
    }
}
