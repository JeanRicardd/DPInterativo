using DPInterativo.Classes;
using DPInterativo.Formularios;
using DPInterativo.NovoFormPrincipal.FormulariosRemaster;
using Microsoft.Win32;
using SharpUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DPInterativo.NovoFormPrincipal
{
    public partial class FormPrincipalRemaster : Form
    {
        private MyIni MyIni;
        public Valores Valores;
        private SharpUpdater updater;
        string vAtual, vNova;
        FormContribuicaoPrevidenciaria formContribuicao = new FormContribuicaoPrevidenciaria() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        NovoFormPrincipal.FormulariosRemaster.FormIRRF formIRRF = new NovoFormPrincipal.FormulariosRemaster.FormIRRF() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormDAE formDAE = new FormDAE() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormCalculoDeDias formCalculoDeDias = new FormCalculoDeDias() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormDistanciaDias formDistanciaDias = new FormDistanciaDias() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormGPSIrregularidade gps = new FormGPSIrregularidade() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormWeb web = new FormWeb();
        //int corTema;

        public FormPrincipalRemaster()
        {
            InitializeComponent();
            Funcoes_do_Sistema();
            //Listar();
            //corTema = 1;
            updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://limes-servers-dataloads.000webhostapp.com/dpbasic/update.xml"));
            updater.DoUpdate();
        }

        void ColorDark()
        {
            //menuStrip1.BackColor = Color.FromArgb(31, 27, 36);
        }

        private void Listar()
        {
            DirectoryInfo Dir = new DirectoryInfo("./Scripts/Python");
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                scriptsPythonToolStripMenuItem.DropDownItems.Add(File.Name);
            }

        }

        public class MemoryManagement
        {
            [DllImport("kernel32.dll")]
            private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

            public MemoryManagement()
            {
            }

            public void FlushMemory()
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        public void VerificarChave()
        {
            RegistryKey key;

            key = Registry.CurrentUser.OpenSubKey(@"Software\InteratCalc\Config");
            key.GetValue("Nome");
            string nome = key.GetValue("Nome").ToString();
            lblNome.Text = nome;
            Valores.Nome = nome;
            
        }

        void VerificarVersao()
        {
            // Define a URL do arquivo XML de atualização
            string updateUrl = "http://localhost/atualizacoes/update_DP.xml";

            // Define a versão atual da aplicação
            string currentVersion = Application.ProductVersion.ToString();

            string newVersion = string.Empty;

            // Cria um objeto WebClient para fazer a solicitação HTTP para o arquivo XML
            using (WebClient client = new WebClient())
            {
                // Faz a solicitação HTTP para o arquivo XML
                string xmlString = client.DownloadString(updateUrl);

                // Cria um objeto XmlReader para ler o arquivo XML
                using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(xmlString)))
                {
                    // Faz a leitura dos dados do arquivo XML
                    reader.ReadToFollowing("Version");
                    newVersion = reader.ReadElementContentAsString();
                }
            }
            //MessageBox.Show(newVersion);
            vAtual = currentVersion;
            vNova = newVersion;

            if (currentVersion != newVersion)
            {
                lkClick.Text = "Nova versão disponivel: " + newVersion;
            }


        }
        public void Funcoes_do_Sistema()
        {
            //Instanciamos la clase MyIni
            this.MyIni = new MyIni("./Config/Config.ini");
            INIFile ini = new INIFile(MyIni.FileName);


            Valores.version = MyIni.GetString("Configuracao", "Version", string.Empty);
            //Calculo Aliquota
            Valores.PorcentagemContribuicao1 = MyIni.GetString("CalculoAliquota", "PorcentagemContribuicao1", string.Empty);
            Valores.PorcentagemContribuicao2 = MyIni.GetString("CalculoAliquota", "PorcentagemContribuicao2", string.Empty);
            Valores.PorcentagemContribuicao3 = MyIni.GetString("CalculoAliquota", "PorcentagemContribuicao3", string.Empty);
            Valores.PorcentagemContribuicao4 = MyIni.GetString("CalculoAliquota", "PorcentagemContribuicao4", string.Empty);
            //
            Valores.ValorContribuicao1 = MyIni.GetString("ValorPrevidenciaria", "ValorContribuicao1", string.Empty);
            Valores.ValorContribuicao2 = MyIni.GetString("ValorPrevidenciaria", "ValorContribuicao2", string.Empty);
            Valores.ValorContribuicao3 = MyIni.GetString("ValorPrevidenciaria", "ValorContribuicao3", string.Empty);
            Valores.ValorContribuicaoFixo = MyIni.GetString("ValorPrevidenciaria", "ValorContribuicaoFixo", string.Empty);
            //
            Valores.PValor = MyIni.GetString("ConfigPrevidenciaria", "PValor", string.Empty);
            Valores.SValor = MyIni.GetString("ConfigPrevidenciaria", "SValor", string.Empty);
            Valores.TValor = MyIni.GetString("ConfigPrevidenciaria", "TValor", string.Empty);
            Valores.QValor = MyIni.GetString("ConfigPrevidenciaria", "QValor", string.Empty);
            Valores.QuValor = MyIni.GetString("ConfigPrevidenciaria", "QuValor", string.Empty);
            Valores.SexValor = MyIni.GetString("ConfigPrevidenciaria", "SexValor", string.Empty);
            Valores.SetValor = MyIni.GetString("ConfigPrevidenciaria", "SetValor", string.Empty);
            Valores.OValor = MyIni.GetString("ConfigPrevidenciaria", "OValor", string.Empty);
            //
            Valores.PorcentagemIRRF0 = MyIni.GetString("CalculoAliquotaIRRF", "PorcentagemIRRF0", string.Empty);
            Valores.PorcentagemIRRF1 = MyIni.GetString("CalculoAliquotaIRRF", "PorcentagemIRRF1", string.Empty);
            Valores.PorcentagemIRRF2 = MyIni.GetString("CalculoAliquotaIRRF", "PorcentagemIRRF2", string.Empty);
            Valores.PorcentagemIRRF3 = MyIni.GetString("CalculoAliquotaIRRF", "PorcentagemIRRF3", string.Empty);
            Valores.PorcentagemIRRF4 = MyIni.GetString("CalculoAliquotaIRRF", "PorcentagemIRRF4", string.Empty);
            //
            Valores.ValorIRRFDeduzir1 = MyIni.GetString("ValorIRRF", "ValorIRRFDeduzir1", string.Empty);
            Valores.ValorIRRFDeduzir2 = MyIni.GetString("ValorIRRF", "ValorIRRFDeduzir2", string.Empty);
            Valores.ValorIRRFDeduzir3 = MyIni.GetString("ValorIRRF", "ValorIRRFDeduzir3", string.Empty);
            Valores.ValorIRRFDeduzir4 = MyIni.GetString("ValorIRRF", "ValorIRRFDeduzir4", string.Empty);
            Valores.ValorIRRFDeduzir5 = MyIni.GetString("ValorIRRF", "ValorIRRFDeduzir5", string.Empty);
            Valores.Dependente = MyIni.GetString("ValorIRRF", "Dependente", string.Empty);
            //
            Valores.ValorIRRF1 = MyIni.GetString("ConfigIRRF", "ValorIRRF1", string.Empty);
            Valores.ValorIRRF2 = MyIni.GetString("ConfigIRRF", "ValorIRRF2", string.Empty);
            Valores.ValorIRRF3 = MyIni.GetString("ConfigIRRF", "ValorIRRF3", string.Empty);
            Valores.ValorIRRF4 = MyIni.GetString("ConfigIRRF", "ValorIRRF4", string.Empty);
            Valores.ValorIRRF5 = MyIni.GetString("ConfigIRRF", "ValorIRRF5", string.Empty);
            Valores.ValorIRRF6 = MyIni.GetString("ConfigIRRF", "ValorIRRF6", string.Empty);
            Valores.ValorIRRF7 = MyIni.GetString("ConfigIRRF", "ValorIRRF7", string.Empty);
            Valores.ValorIRRF8 = MyIni.GetString("ConfigIRRF", "ValorIRRF8", string.Empty);
            //Data
            Valores.PeriodoAquisitivo = MyIni.GetString("DiasMenu", "PeriodoAquisitivo", string.Empty);
            Valores.PeriodoConcessivo = MyIni.GetString("DiasMenu", "PeriodoConcessivo", string.Empty);
            //Salario Familia
            Valores.AteSalarioFamilia = MyIni.GetString("Salario-Familia", "AteSalarioFamilia", string.Empty);
            Valores.AcimaSalarioFamilia = MyIni.GetString("Salario-Familia", "AcimaSalarioFamilia", string.Empty);
            Valores.ValorSalarioFamilia = MyIni.GetString("Salario-Familia", "SalarioFamilia", string.Empty);
            //
            Valores.SalarioMinimo = MyIni.GetString("Salario", "Salario-Minimo", string.Empty);
            //
            Valores.valorMinimoGPS = MyIni.GetString("GPS-INSS", "ValorMinimoGPS", string.Empty);
            Valores.valorMinimoINSS = MyIni.GetString("GPS-INSS", "ValorMinimoINSS", string.Empty);
            //
        }
        private void btnContribuicao_Click(object sender, EventArgs e)
        {
            panelSistema.Controls.Add(formContribuicao);
            formContribuicao.Show();
            formIRRF.Hide();
            formDAE.Hide();
            formDistanciaDias.Hide();
            formCalculoDeDias.Hide();
            gps.Hide();
            lblFrase2.Visible = false;
        }

        private void FormPrincipalRemaster_Load(object sender, EventArgs e)
        {
            ColorDark();
            VerificarChave();
            lkClick.Text = "Versão: " + ProductVersion;
            //VerificarVersao();
            /*
            if (corTema == 1)
            {
                BackColor = Color.FromArgb(55, 0, 179);
                menuStrip1.BackColor = Color.FromArgb(55, 50, 179);
                btnContribuicao.BackColor = Color.FromArgb(100, 88, 255);
                btnImposto.BackColor = Color.FromArgb(100, 88, 255);
                btnDAE.BackColor = Color.FromArgb(100, 88, 255);
                btnCustoFuncionario.BackColor = Color.FromArgb(100, 88, 255);
                btnDistanciasDia.BackColor = Color.FromArgb(100, 88, 255);
                btnDataAquisicao.BackColor = Color.FromArgb(100, 88, 255);
                panelSistema.BackColor = Color.FromArgb(55, 0, 179);
            }
            if (corTema == 2)
            {
                BackColor = Color.Red;
                menuStrip1.BackColor = Color.Maroon;
                btnContribuicao.BaseColor = Color.IndianRed;
                btnImposto.BaseColor = Color.IndianRed;
                btnDAE.BaseColor = Color.IndianRed;
                btnCustoFuncionario.BaseColor = Color.IndianRed;
                btnDistanciasDia.BaseColor = Color.IndianRed;
                btnDataAquisicao.BaseColor = Color.IndianRed;
                //Passar mouse encima
                btnContribuicao.OnHoverBaseColor = Color.FromArgb(255, 128, 0);
                btnImposto.OnHoverBaseColor = Color.FromArgb(255, 128, 0);
                btnDAE.OnHoverBaseColor = Color.FromArgb(255, 128, 0);
                btnCustoFuncionario.OnHoverBaseColor = Color.FromArgb(255, 128, 0);
                btnDistanciasDia.OnHoverBaseColor = Color.FromArgb(255, 128, 0);
                btnDataAquisicao.OnHoverBaseColor = Color.FromArgb(255, 128, 0);
                panelSistema.BackColor = Color.Red;
            }*/



            //utilitariosWEBToolStripMenuItem.DropDownItems.Add("Novo Link");
        }

        private void btnImposto_Click(object sender, EventArgs e)
        {
            panelSistema.Controls.Add(formIRRF);
            formIRRF.Show();
            formContribuicao.Hide();
            formDAE.Hide();
            formDistanciaDias.Hide();
            formCalculoDeDias.Hide();
            gps.Hide();
            lblFrase2.Visible = false;
        }

        private void btnDAE_Click(object sender, EventArgs e)
        {
            panelSistema.Controls.Add(formDAE);
            formDAE.Show();
            formContribuicao.Hide();
            formIRRF.Hide();
            formDistanciaDias.Hide();
            formCalculoDeDias.Hide();
            gps.Hide();
            lblFrase2.Visible = false;
        }

        private void btnCustoFuncionario_Click(object sender, EventArgs e)
        {
            formContribuicao.Hide();
            formIRRF.Hide();
            formDAE.Hide();
            formDistanciaDias.Hide();
            formCalculoDeDias.Hide();
            gps.Hide();
            lblFrase2.Visible = true;
            FormCustoFuncionario form = new FormCustoFuncionario();
            form.Show();
        }

        private void btnDistanciasDia_Click(object sender, EventArgs e)
        {
            panelSistema.Controls.Add(formDistanciaDias);
            formDistanciaDias.Show();
            formContribuicao.Hide();
            formIRRF.Hide();
            formDAE.Hide();
            formCalculoDeDias.Hide();
            gps.Hide();
            lblFrase2.Visible = false;
        }

        private void btnDataAquisicao_Click(object sender, EventArgs e)
        {
            panelSistema.Controls.Add(formCalculoDeDias);
            formCalculoDeDias.Show();
            formDistanciaDias.Hide();
            formContribuicao.Hide();
            formIRRF.Hide();
            formDAE.Hide();
            gps.Hide();
            lblFrase2.Visible = false;
        }

        private void verificaçãoDeIrregularidadeGPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSistema.Controls.Add(gps);
            gps.Show();
            formDistanciaDias.Hide();
            formContribuicao.Hide();
            formIRRF.Hide();
            formDAE.Hide();
            lblFrase2.Visible = false;

        }


        public void consultarCNPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCNPJ cnpj = new FormCNPJ();
            cnpj.Show();
        }

        private void timerMemoriaRAM_Tick(object sender, EventArgs e)
        {
            MemoryManagement obj = new MemoryManagement();
            obj.FlushMemory();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormConfiguration formConfiguration = new FormConfiguration();
            formConfiguration.Show();
        }

        private void lkClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (vAtual != vNova)
            {
                string message = "Deseja aplicar a nova atualização?";
                string title = "Atualizar aplicação?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Aplicando atualização");
                }
                else
                {
                    return; 
                }
            }
            else
            {
                string url = "http://changelog.ajaguna.com.br/changelog_dpbasic.html";
                string browserPath = @"C:\Program Files\Internet Explorer\iexplore.exe";
                ProcessStartInfo startInfo = new ProcessStartInfo(browserPath, url);
                Process.Start(startInfo);
                /*FormChangelog formChangelog = new FormChangelog();
                formChangelog.Show();*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com";
            string browserPath = @"C:\Program Files\Internet Explorer\iexplore.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo(browserPath, url);
            Process.Start(startInfo);
        }

        private void consultaSimplesNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Valores.Url = "https://consopt.www8.receita.fazenda.gov.br/consultaoptantes";
            web.Show();
        }

    }
}
