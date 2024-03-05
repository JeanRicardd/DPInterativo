using DPInterativo.Classes;
using DPInterativo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    public partial class FormGPSIrregularidade : Form
    {
        FormWeb web = new FormWeb();
        public FormGPSIrregularidade()
        {
            InitializeComponent();
        }

        void CadastrarSenha()
        {
            var cnpj = txtCNPJ.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            Valores.Url = "http://cobaut.receita.fazenda.gov.br/pls/pradar/PKG_BAIXA_EMPR_SENHA.pr_testa_perguntaX?PROXCOD=296224354&cnpjbd=" + cnpj + "&tipoMat=1&wOndeVeio=3&nome_ret=FIORDE%20PARTICIPACOES%20LTDA&end_ret=R%20FREI%20CANECA%20739%20ANDAR%205&resp1=2062&resp2=122015&resp3=515";
            web.Show();
            //Process.Start("Chrome.exe", "http://cobaut.receita.fazenda.gov.br/pls/pradar/PKG_BAIXA_EMPR_SENHA.pr_testa_perguntaX?PROXCOD=296224354&cnpjbd=" + cnpj + "&tipoMat=1&wOndeVeio=3&nome_ret=FIORDE%20PARTICIPACOES%20LTDA&end_ret=R%20FREI%20CANECA%20739%20ANDAR%205&resp1=2062&resp2=122015&resp3=515");
            //Process.Start(, "http://cobaut.receita.fazenda.gov.br/pls/pradar/PKG_BAIXA_EMPR_SENHA.pr_testa_perguntaX?PROXCOD=296224354&cnpjbd=" + cnpj + "&tipoMat=1&wOndeVeio=3&nome_ret=FIORDE%20PARTICIPACOES%20LTDA&end_ret=R%20FREI%20CANECA%20739%20ANDAR%205&resp1=2062&resp2=122015&resp3=515");
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

        private void timerCarregarInformacao_Tick(object sender, EventArgs e)
        {
            CadastrarSenha();
            timerCarregarInformacao.Stop();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            CNPJ();
            timerCarregarInformacao.Start();
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnExecutar_Click(sender, e);
            }
        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormGPSIrregularidade_TextChanged(object sender, EventArgs e)
        {
            txtCNPJ.Text = Regex.Replace(txtCNPJ.Text, "[^0-9,.]", "");
        }
    }
}
