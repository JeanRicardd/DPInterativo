using DPInterativo.Classes;
using DPInterativo.Formularios;
using DPInterativo.FormularioSobre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo
{
    public partial class Form1 : Form
    {

        //Classes locais
        private MyIni MyIni;
        public Valores Valores;

        public Form1()
        {
            InitializeComponent();
            contmaticToolStripMenuItem.Visible = false;
            sObreToolStripMenuItem.Visible = false;
            contmaticToolStripMenuItem.Enabled = false;
            sObreToolStripMenuItem.Enabled = false;
            //btn13.Enabled = false;
            Form form = new Form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormContribuicao formContribuicao = new FormContribuicao();
            formContribuicao.Show();
        }

        private void btnImposto_Click(object sender, EventArgs e)
        {
            FormImposto formImposto = new FormImposto();
            formImposto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormIRRF formIRRF = new FormIRRF();
            formIRRF.Show();
        }

        private void btnCustoFuncionario_Click(object sender, EventArgs e)
        {
            FormCustoFuncionario formCusto = new FormCustoFuncionario();
            formCusto.Show();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            FormDecimoTerceiro formDecimo = new FormDecimoTerceiro();
            formDecimo.Show();
        }

        private void sObreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFeriasProporcionais formFeriasProporcionais = new FormFeriasProporcionais();
            formFeriasProporcionais.Show();
        }

        private void btnDescontoSocioFixo_Click(object sender, EventArgs e)
        {
            FormDescontoSocioFixo socioFixo = new FormDescontoSocioFixo();
            socioFixo.Show();
        }

        private void buscarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("IdeaProject.exe");
            p.WaitForInputIdle(); // Tempo de espera para que a janela do aplicativo "apareça"
            //SetParent(p.MainWindowHandle, panel1.Handle); // Aqui está a jogada, colocando o panel "pai"
        }

        private void btnContribuicaoPrevidenciaria_Click(object sender, EventArgs e)
        {

        }

        private void buscarAgendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process p = Process.Start("IdeaProject.exe");
            p.WaitForInputIdle(); // Tempo de espera para que a janela do aplicativo "apareça"
        }

        private void lkClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangelog formChangelog = new FormChangelog();
            formChangelog.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioPadrao.Checked = true;
            string frase = File.ReadAllText("Config\\Version.ajw");
            lkClick.Text = frase;

            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy").Replace('-', '/');


            //teste de config.ini 1#
            //----------------------------------------------------------
            //Classes Responsaveis por desativar os programas

            //Instanciamos la clase MyIni
            this.MyIni = new MyIni("./Config/Config.ini");
            /*
            this.TesteValue = MyIni.GetString("Opcoes", "BuscarAgenda", string.Empty);
            this.passatempo = MyIni.GetString("Opcoes", "Passatempo", string.Empty);
            this.contribuicaoprevidenciaria = MyIni.GetString("Opcoes", "ContribuicaoPrevidenciaria", string.Empty);
            this.impostodae = MyIni.GetString("Opcoes", "ImpostoDAE", string.Empty);
            this.custofuncionario = MyIni.GetString("Opcoes", "CustoFuncionario", string.Empty);
            this.irrf = MyIni.GetString("Opcoes", "IRRF", string.Empty);
            this.calculo13 = MyIni.GetString("Opcoes", "Calculo13", string.Empty);
            this.sociofixo = MyIni.GetString("Opcoes", "SocioFixo", string.Empty);
            this.datadia = MyIni.GetString("Opcoes", "Data", string.Empty);
            this.porcentagem = MyIni.GetString("Opcoes", "Porcentagem", string.Empty);

            if (this.TesteValue == "1")
            {
                buscarAgendaToolStripMenuItem.Enabled = true;
                buscarAgendaToolStripMenuItem.Visible = true;
            }
            else if (this.TesteValue == "0")
            {
                buscarAgendaToolStripMenuItem.Enabled = false;
                buscarAgendaToolStripMenuItem.Visible = false;
            }

            if (this.passatempo == "1")
            {
                passatempoToolStripMenuItem.Enabled = true;
                passatempoToolStripMenuItem.Visible = true;
            }
            else if (this.passatempo == "0")
            {
                passatempoToolStripMenuItem.Enabled = false;
                passatempoToolStripMenuItem.Visible = false;
            }

            if (this.impostodae == "1")
            {
                materialRaisedButton3.Enabled = true;
                materialRaisedButton3.Visible = true;
            }
            else if (this.impostodae == "0")
            {
                materialRaisedButton3.Enabled = false;
                materialRaisedButton3.Visible = false;
            }

            if (this.custofuncionario == "1")
            {
                materialRaisedButton5.Enabled = true;
                materialRaisedButton5.Visible = true;
            }
            else if (this.custofuncionario == "0")
            {
                materialRaisedButton5.Enabled = false;
                materialRaisedButton5.Visible = false;
            }

            if (this.irrf == "1")
            {
                materialRaisedButton2.Enabled = true;
                materialRaisedButton2.Visible = true;
            }
            else if (this.irrf == "0")
            {
                materialRaisedButton2.Enabled = false;
                materialRaisedButton2.Visible = false;
            }

            if (this.calculo13 == "1")
            {
                materialRaisedButton4.Enabled = true;
                materialRaisedButton4.Visible = true;
            }
            else if (this.calculo13 == "0")
            {
                materialRaisedButton4.Enabled = false;
                materialRaisedButton4.Visible = false;
            }

            if (this.sociofixo == "1")
            {
                materialRaisedButton6.Enabled = true;
                materialRaisedButton6.Visible = true;
            }
            else if (this.sociofixo == "0")
            {
                materialRaisedButton6.Enabled = false;
                materialRaisedButton6.Visible = false;
            }

            if (this.contribuicaoprevidenciaria == "1")
            {
                materialRaisedButton1.Enabled = true;
                materialRaisedButton1.Visible = true;
            }
            else if (this.contribuicaoprevidenciaria == "0")
            {
                materialRaisedButton1.Enabled = false;
                materialRaisedButton1.Visible = false;
            }

            if (this.porcentagem == "1")
            {
                calculoDePorcentagemToolStripMenuItem.Enabled = true;
                calculoDePorcentagemToolStripMenuItem.Visible = true;
            }
            else if (this.porcentagem == "0")
            {
                calculoDePorcentagemToolStripMenuItem.Enabled = false;
                calculoDePorcentagemToolStripMenuItem.Visible = false;
            }*/
            /*
            if (this.datadia == "1")
            {
                lblData.Visible = true;
            }
            else if (this.datadia == "0")
            {
                lblData.Visible = false;
            }*/

        }

        private void Funcoes_do_Sistema()
        {
            //Instanciamos la clase MyIni
            this.MyIni = new MyIni("./Config/Config.ini");

            Valores.version = MyIni.GetString("Configuracao", "Version", string.Empty);
            /*this.passatempo = MyIni.GetString("Opcoes", "Passatempo", string.Empty);
            this.contribuicaoprevidenciaria = MyIni.GetString("Opcoes", "ContribuicaoPrevidenciaria", string.Empty);
            this.impostodae = MyIni.GetString("Opcoes", "ImpostoDAE", string.Empty);
            this.custofuncionario = MyIni.GetString("Opcoes", "CustoFuncionario", string.Empty);
            this.irrf = MyIni.GetString("Opcoes", "IRRF", string.Empty);
            this.calculo13 = MyIni.GetString("Opcoes", "Calculo13", string.Empty);
            this.sociofixo = MyIni.GetString("Opcoes", "SocioFixo", string.Empty);
            this.datadia = MyIni.GetString("Opcoes", "Data", string.Empty);
            this.porcentagem = MyIni.GetString("Opcoes", "Porcentagem", string.Empty);*/
        }


        private void passatempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void marioBrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("MicrosoftEdge.exe", "https://web.ajagunaweb.com.br/MarioBros/index.html");
        }

        private void sobreOComputadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobreMaquina form = new FormSobreMaquina();
            form.Show();
        }

        private void radioBranco_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBranco.Checked == true)
            {
                BackColor = Color.White;
                menuStrip1.BackColor = Color.Gray;
                menuStrip1.ForeColor = Color.Black;
                passatempoToolStripMenuItem.BackColor = Color.Gray;
                marioBrosToolStripMenuItem.BackColor = Color.Gray;
                lkClick.LinkColor = Color.Black;
                radioBranco.ForeColor = Color.Black;
                radioPadrao.ForeColor = Color.Black;
            }
            else
            {
                radioPadrao.Checked = true;
            }
        }

        private void radioPadrao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPadrao.Checked == true)
            {
                BackColor = Color.FromArgb(34, 44, 49);
                menuStrip1.BackColor = Color.FromArgb(55, 71, 79);
                menuStrip1.ForeColor = Color.White;
                passatempoToolStripMenuItem.BackColor = Color.FromArgb(55, 71, 79);
                lkClick.LinkColor = Color.Silver;
                radioBranco.ForeColor = Color.White;
                radioPadrao.ForeColor = Color.White;
            }
            else
            {
                radioBranco.Checked = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                FormUsuario usuario = new FormUsuario();
                usuario.Show();
            }
        }

        private void calculoDePorcentagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPorcentagem porcentagem = new FormPorcentagem();
            porcentagem.Show();
        }

        private void consultarCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "https://servicos.receita.fazenda.gov.br/servicos/cpf/consultasituacao/consultapublica.asp");
        }

        private void eSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "https://login.esocial.gov.br/login.aspx");
        }

        private void extratoDeContribuiçõesINSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://gps.receita.fazenda.gov.br/");

        }

        private void sindiBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://sindibrasil.com.br/");
        }

        private void consultaSimplesNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://www8.receita.fazenda.gov.br/SIMPLESNACIONAL/aplicacoes.aspx?id=22");
        }

        private void consultarNISNITPISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://consultacadastral.inss.gov.br/Esocial/pages/qualificacao/qualificar.xhtml");
        }

        private void conectividadeSocialICPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://www.caixa.gov.br/empresa/conectividade-social/Paginas/default.aspx");
        }

        private void sistemaDeAcréscimosLegaisSALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://sal.receita.fazenda.gov.br/PortalSalInternet/faces/pages/index.xhtml");
        }

        private void eCacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "https://sso.acesso.gov.br/login?client_id=cav.receita.fazenda.gov.br&authorization_id=1762464fee7");
        }

        private void consultarRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "https://www.policiacivil.sp.gov.br/portal/faces/pages_home/servicos/consultaSituacaoRG?_afrLoop=1988008199440380&_afrWindowMode=0&_afrWindowId=null#!%40%40%3F_afrWindowId%3Dnull%26_afrLoop%3D1988008199440380%26_afrWindowMode%3D0%26_adf.ctrl-state%3Daw21rdb0c_4");
        }

        private void consultarTituloDeEleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "https://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome");
        }

        private void pegarNISNITPISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "https://cnisnet.inss.gov.br/cnisinternet/faces/pages/perfil.xhtml");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Refresh();
        }
    }
}
