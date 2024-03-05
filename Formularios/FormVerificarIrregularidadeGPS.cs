using DPInterativo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.Formularios
{
    public partial class FormVerificarIrregularidadeGPS : Form
    {
        public FormVerificarIrregularidadeGPS()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            CNPJ();
            timer1.Start();
        }

        void CadastrarSenha()
        {
            var cnpj = txtCNPJ.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            Process.Start("Chrome.exe", "http://cobaut.receita.fazenda.gov.br/pls/pradar/PKG_BAIXA_EMPR_SENHA.pr_testa_perguntaX?PROXCOD=296224354&cnpjbd=" + cnpj + "&tipoMat=1&wOndeVeio=3&nome_ret=FIORDE%20PARTICIPACOES%20LTDA&end_ret=R%20FREI%20CANECA%20739%20ANDAR%205&resp1=2062&resp2=122015&resp3=515");
        }

        void CNPJ()
        {
            string cnpj = txtCNPJ.Text.Replace("/", "").Replace(".", "").Replace("-", "");

            CNPJ usuario = CNPJ_Servico.BuscaCNPJ(cnpj);

            if (cnpj != null)
            {
                lblEmpresa.Text = usuario.Nome;
            }
            else 
            {
                MessageBox.Show("CNPJ não encontrado");
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnExecutar_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CadastrarSenha();
            timer1.Stop();
        }
    }
}
