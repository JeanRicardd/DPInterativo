using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPInterativo.Classes;
using Microsoft.Win32;

namespace DPInterativo.NovoFormPrincipal
{
    public partial class FormConfiguration : Form
    {
        private MyIni MyIni;
        FormPrincipalRemaster principalNew = new FormPrincipalRemaster();
        public FormConfiguration()
        {
            InitializeComponent();
            CarregarValores();
            CheckBox();
            radioDefault.Checked = true;
        }

        void CheckBox()
        {
            txtNomeWEB1.Enabled = false;
            txtNomeWEB2.Enabled = false;
            txtNomeWEB3.Enabled = false;
            txtNomeWEB4.Enabled = false;
            txtNomeWEB5.Enabled = false;

            txtLinkWEB1.Enabled = false;
            txtLinkWEB2.Enabled = false;
            txtLinkWEB3.Enabled = false;
            txtLinkWEB4.Enabled = false;
            txtLinkWEB5.Enabled = false;

            checkWEB1.Enabled = false;
            checkWEB2.Enabled = false;
            checkWEB3.Enabled = false;
            checkWEB4.Enabled = false;
            checkWEB5.Enabled = false;
        }

        void AtualizarNome()
        {
            var Nome = txtNome.Text;
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\Config");
            key.CreateSubKey("Nome");
            key.SetValue("Nome", Nome, RegistryValueKind.String);
            key.Close();
        }

        public void CarregarValores()
        {
            txtNome.Text = Valores.Nome;
            txtSalarioMinimo.Text = Valores.SalarioMinimo;
            txtAte1.Text = Valores.SValor;
            txtAte2.Text = Valores.QValor;
            txtAte3.Text = Valores.SexValor;
            txtAte4.Text = Valores.OValor;
            txtDe1.Text = Valores.PValor;
            txtDe2.Text = (double.Parse(Valores.SValor) + 0.01).ToString();
            txtDe3.Text = (double.Parse(Valores.QValor) + 0.01).ToString();
            txtDe4.Text = (double.Parse(Valores.SexValor) + 0.01).ToString();
            txtAliquota1.Text = Valores.PorcentagemContribuicao1;
            txtAliquota2.Text = Valores.PorcentagemContribuicao2;
            txtAliquota3.Text = Valores.PorcentagemContribuicao3;
            txtAliquota4.Text = Valores.PorcentagemContribuicao4;
            txtIRRF1.Text = Valores.ValorIRRF1;
            txtIRRF2.Text = Valores.ValorIRRF2;
            txtIRRF3.Text = Valores.ValorIRRF4;
            txtIRRF4.Text = Valores.ValorIRRF6;
            txtIRRF5.Text = Valores.ValorIRRF8;
            txtAliquotaIRRF1.Text = Valores.PorcentagemIRRF0;
            txtAliquotaIRRF2.Text = Valores.PorcentagemIRRF1;
            txtAliquotaIRRF3.Text = Valores.PorcentagemIRRF2;
            txtAliquotaIRRF4.Text = Valores.PorcentagemIRRF3;
            txtAliquotaIRRF5.Text = Valores.PorcentagemIRRF4;
            txtDeduzir1.Text = Valores.ValorIRRFDeduzir1;
            txtDeduzir2.Text = Valores.ValorIRRFDeduzir2;
            txtDeduzir3.Text = Valores.ValorIRRFDeduzir3;
            txtDeduzir4.Text = Valores.ValorIRRFDeduzir4;
            txtDeduzir5.Text = Valores.ValorIRRFDeduzir5;
            txtDependente.Text = Valores.Dependente;
            txtSalarioFamilia.Text = Valores.ValorSalarioFamilia;
            txtAteLimite.Text = Valores.AteSalarioFamilia;
            txtAcimaLimite.Text = Valores.AcimaSalarioFamilia;
            txtMinimoGPS.Text = Valores.valorMinimoGPS;
            txtMinimoINSS.Text = Valores.valorMinimoINSS;
        }

        public void GravarValores()
        {
            MyIni = new MyIni("./Config/Config.ini");
            Valores.SalarioMinimo = txtSalarioMinimo.Text;
            Valores.SValor = txtAte1.Text;
            Valores.QValor = txtAte2.Text;
            Valores.SexValor = txtAte3.Text;
            Valores.OValor = txtAte4.Text;
            Valores.PValor = txtDe1.Text;
            Valores.TValor = txtDe2.Text;
            Valores.QuValor = txtDe3.Text;
            Valores.SetValor = txtDe4.Text;
            Valores.PorcentagemContribuicao1 = txtAliquota1.Text;
            Valores.PorcentagemContribuicao2 = txtAliquota2.Text;
            Valores.PorcentagemContribuicao3 = txtAliquota3.Text;
            Valores.PorcentagemContribuicao4 = txtAliquota4.Text;
            Valores.ValorIRRF1 = txtIRRF1.Text;
            Valores.ValorIRRF2 = txtIRRF2.Text;
            Valores.ValorIRRF3 = (double.Parse(txtIRRF3.Text)- 0.01).ToString();
            Valores.ValorIRRF4 = txtIRRF3.Text;
            Valores.ValorIRRF5 = (double.Parse(txtIRRF4.Text) - 0.01).ToString();
            Valores.ValorIRRF6 = txtIRRF4.Text;
            Valores.ValorIRRF7 = (double.Parse(txtIRRF5.Text) - 0.01).ToString();
            Valores.ValorIRRF8 = txtIRRF5.Text;
            Valores.PorcentagemIRRF0 = txtAliquotaIRRF1.Text;
            Valores.PorcentagemIRRF1 = txtAliquotaIRRF2.Text;
            Valores.PorcentagemIRRF2 = txtAliquotaIRRF3.Text;
            Valores.PorcentagemIRRF3 = txtAliquotaIRRF4.Text;
            Valores.PorcentagemIRRF4 = txtAliquotaIRRF5.Text;
            Valores.ValorIRRFDeduzir1 = txtDeduzir1.Text;
            Valores.ValorIRRFDeduzir2 = txtDeduzir2.Text;
            Valores.ValorIRRFDeduzir3 = txtDeduzir3.Text;
            Valores.ValorIRRFDeduzir4 = txtDeduzir4.Text;
            Valores.ValorIRRFDeduzir5 = txtDeduzir5.Text;
            Valores.Dependente = txtDependente.Text;
            Valores.ValorSalarioFamilia = txtSalarioFamilia.Text;
            Valores.AteSalarioFamilia = txtAteLimite.Text;
            Valores.AcimaSalarioFamilia = txtAcimaLimite.Text;
            Valores.valorMinimoGPS = txtMinimoGPS.Text;
            Valores.valorMinimoINSS = txtMinimoINSS.Text;


            MyIni.WriteString("CalculoAliquota", "PorcentagemContribuicao1", " " + Valores.PorcentagemContribuicao1);
            MyIni.WriteString("CalculoAliquota", "PorcentagemContribuicao2", " " + Valores.PorcentagemContribuicao2);
            MyIni.WriteString("CalculoAliquota", "PorcentagemContribuicao3", " " + Valores.PorcentagemContribuicao3);
            MyIni.WriteString("CalculoAliquota", "PorcentagemContribuicao4", " " + Valores.PorcentagemContribuicao4);
            //
            MyIni.WriteString("ConfigPrevidenciaria", "PValor", " " + Valores.PValor);
            MyIni.WriteString("ConfigPrevidenciaria", "SValor", " " + Valores.SValor);
            MyIni.WriteString("ConfigPrevidenciaria", "TValor", " " + Valores.TValor);
            MyIni.WriteString("ConfigPrevidenciaria", "QValor", " " + Valores.QValor);
            MyIni.WriteString("ConfigPrevidenciaria", "QuValor", " " + Valores.QuValor);
            MyIni.WriteString("ConfigPrevidenciaria", "SexValor", " " + Valores.SexValor);
            MyIni.WriteString("ConfigPrevidenciaria", "SetValor", " " + Valores.SetValor);
            MyIni.WriteString("ConfigPrevidenciaria", "OValor", " " + Valores.OValor);
            //
            MyIni.WriteString("CalculoAliquotaIRRF", "PorcentagemIRRF0", " " + Valores.PorcentagemIRRF0);
            MyIni.WriteString("CalculoAliquotaIRRF", "PorcentagemIRRF1", " " + Valores.PorcentagemIRRF1);
            MyIni.WriteString("CalculoAliquotaIRRF", "PorcentagemIRRF2", " " + Valores.PorcentagemIRRF2);
            MyIni.WriteString("CalculoAliquotaIRRF", "PorcentagemIRRF3", " " + Valores.PorcentagemIRRF3);
            MyIni.WriteString("CalculoAliquotaIRRF", "PorcentagemIRRF4", " " + Valores.PorcentagemIRRF4);
            //
            MyIni.WriteString("ValorIRRF", "ValorIRRFDeduzir1", " " + Valores.ValorIRRFDeduzir1);
            MyIni.WriteString("ValorIRRF", "ValorIRRFDeduzir2", " " + Valores.ValorIRRFDeduzir2);
            MyIni.WriteString("ValorIRRF", "ValorIRRFDeduzir3", " " + Valores.ValorIRRFDeduzir3);
            MyIni.WriteString("ValorIRRF", "ValorIRRFDeduzir4", " " + Valores.ValorIRRFDeduzir4);
            MyIni.WriteString("ValorIRRF", "ValorIRRFDeduzir5", " " + Valores.ValorIRRFDeduzir5);
            MyIni.WriteString("ValorIRRF", "Dependente", " " + Valores.Dependente);
            //
            MyIni.WriteString("ConfigIRRF", "ValorIRRF1", " " + Valores.ValorIRRF1);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF2", " " + Valores.ValorIRRF2);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF3", " " + Valores.ValorIRRF3);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF4", " " + Valores.ValorIRRF4);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF5", " " + Valores.ValorIRRF5);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF6", " " + Valores.ValorIRRF6);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF7", " " + Valores.ValorIRRF7);
            MyIni.WriteString("ConfigIRRF", "ValorIRRF8", " " + Valores.ValorIRRF8);
            //Data
            //MyIni.WriteString("DiasMenu", "PeriodoAquisitivo", " " + Valores.PeriodoAquisitivo);
            //MyIni.WriteString("DiasMenu", "PeriodoConcessivo", " " + Valores.PeriodoConcessivo);
            //Salario Familia
            MyIni.WriteString("Salario-Familia", "AteSalarioFamilia", " " + Valores.AteSalarioFamilia);
            MyIni.WriteString("Salario-Familia", "AcimaSalarioFamilia", " " + Valores.AcimaSalarioFamilia);
            MyIni.WriteString("Salario-Familia", "SalarioFamilia", " " + Valores.ValorSalarioFamilia);
            //
            MyIni.WriteString("Salario", "Salario-Minimo", " " + Valores.SalarioMinimo);
            //
            MyIni.WriteString("GPS-INSS", "ValorMinimoGPS", " " + Valores.valorMinimoGPS);
            MyIni.WriteString("GPS-INSS", "ValorMinimoINSS", " " + Valores.valorMinimoINSS);
            principalNew.Funcoes_do_Sistema();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GravarValores();
            AtualizarNome();
            DialogResult result1 = MessageBox.Show("Configuração Salva !",
                "Informação",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }

        private void FormConfiguration_FormClosed(object sender, FormClosedEventArgs e)
        {
            principalNew.VerificarChave();
        }

        private void checkUtilitarioWEB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUtilitarioWEB.Checked == false)
            {
                txtNomeWEB1.Enabled = false;
                txtNomeWEB2.Enabled = false;
                txtNomeWEB3.Enabled = false;
                txtNomeWEB4.Enabled = false;
                txtNomeWEB5.Enabled = false;

                txtLinkWEB1.Enabled = false;
                txtLinkWEB2.Enabled = false;
                txtLinkWEB3.Enabled = false;
                txtLinkWEB4.Enabled = false;
                txtLinkWEB5.Enabled = false;

            }
        }
    }
}
