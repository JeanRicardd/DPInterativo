using DPInterativo.Classes;
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
    public partial class FormCNPJ : Form
    {
        public FormCNPJ()
        {
            InitializeComponent();
        }
        void CNPJ()
        {
            string cnpj = txtCNPJ.Text.Replace("/", "").Replace(".", "").Replace("-", "");

            CNPJ usuario = CNPJ_Servico.BuscaCNPJ(cnpj);

            if (cnpj != null)
            {
                double capSocial = Convert.ToDouble(usuario.Capital_Social);
                txtNomeEmpresa.Text = usuario.Nome;
                txtDtdAbertura.Text = usuario.Abertura;
                txtFantasia.Text = usuario.Fantasia;
                txtPorte.Text = usuario.Porte;
                txtNaturezaJuridica.Text = usuario.Natureza_Juridica;
                txtCapitalSocial.Text = capSocial.ToString();
                txtSituacao.Text = usuario.Situacao;
                txtAtualizacao.Text = usuario.data_situacao;
            }
            else if (txtDtdAbertura.Text == "")
            {
                MessageBox.Show("CNPJ não encontrado");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CNPJ();           
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CNPJ();
        }
    }
}
