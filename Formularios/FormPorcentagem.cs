using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.Formularios
{
    public partial class FormPorcentagem : Form
    {
        public FormPorcentagem()
        {
            InitializeComponent();
        }


        public void CalcularPorcentagem()
        {
            if (txtPorcentagem.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Por favor, não deixe espaços em branco !!");
                return;
            }

            double valor = Convert.ToDouble(txtValor.Text);
            double porcentagem = Convert.ToDouble(txtPorcentagem.Text);

            double resultado = valor / (100/porcentagem);

            MessageBox.Show("Valor da porcentagem: R$"+ resultado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPorcentagem();
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            CalcularPorcentagem();
        }

    }
}
