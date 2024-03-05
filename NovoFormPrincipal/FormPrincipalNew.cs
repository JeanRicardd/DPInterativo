using DPInterativo.Classes;
using DPInterativo.Formularios;
using DPInterativo.FormularioSobre;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.NovoFormPrincipal
{
    public partial class FormPrincipalNew : Form
    {
        //Classes locais
        private MyIni MyIni;
        private MyIni LayoutConfig;
        public Valores Valores;
        string formula;
        string formulaIRRF;
        string formulaDAE;

        public FormPrincipalNew()
        {
            InitializeComponent();
            Funcoes_do_Sistema();
            Valores.SSF = "0";
            //formP.Location = new Point(375, 159);
        }

        //Liberar memoria ram
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

        public void Funcoes_do_Sistema()
        {
            //Instanciamos la clase MyIni
            this.MyIni = new MyIni("./Config/Config.ini");
            this.LayoutConfig = new MyIni("./Config/Layout_Config.ini");
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

            //Configuração dos Layouts abaixo
            Valores.versao_MD = LayoutConfig.GetString("Layout_MaterialDesign", "Version", string.Empty);
            Valores.versao_Guna = LayoutConfig.GetString("Layout_GunaUI", "Version", string.Empty);
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
         
        public void ContribuicaoAssalariado()
        {
            //Variaveis
            double PorcentagemContribuicao1 = double.Parse(Valores.PorcentagemContribuicao1);
            double PorcentagemContribuicao2 = double.Parse(Valores.PorcentagemContribuicao2);
            double PorcentagemContribuicao3 = double.Parse(Valores.PorcentagemContribuicao3);
            double PorcentagemContribuicao4 = double.Parse(Valores.PorcentagemContribuicao4);
            double ValorContribuicao1 = double.Parse(Valores.ValorContribuicao1);
            double ValorContribuicao2 = double.Parse(Valores.ValorContribuicao2);
            double ValorContribuicao3 = double.Parse(Valores.ValorContribuicao3);
            double ValorContribuicaoFixo = double.Parse(Valores.ValorContribuicaoFixo);
            double PValor = double.Parse(Valores.PValor);
            double SValor = double.Parse(Valores.SValor);
            double TValor = double.Parse(Valores.TValor);
            double QValor = double.Parse(Valores.QValor);
            double QuValor = double.Parse(Valores.QuValor);
            double SexValor = double.Parse(Valores.SexValor);
            double SetValor = double.Parse(Valores.SetValor);
            double OValor = double.Parse(Valores.OValor);

            if (txtValor.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }
            
            double valor = Convert.ToDouble(txtValor.Text);

            if (valor >= PValor && valor <= SValor)
            {
                double valorfinal = valor * (PorcentagemContribuicao1 / 100);
                formula = "R$ " + valor + " * " + PorcentagemContribuicao1 + "% = " + "R$ " + valorfinal;

                if (valorfinal <= 0)
                {
                    txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00",valorfinal);

                }
                else
                {
                    txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                }
            }
            else if (valor >= TValor && valor <= QValor)
            {
                double calculo = (valor * (PorcentagemContribuicao2/100)) - ValorContribuicao1;
                double valorPorcentagem = valor * (PorcentagemContribuicao2 / 100);
                formula = "R$ " + valor + " * " + PorcentagemContribuicao2 + "% = " + "R$ " + valorPorcentagem + "\n" + "R$ " + valorPorcentagem + " - " + "R$ " + ValorContribuicao1 + " = " + "R$ " + calculo;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else if (valor >= QuValor && valor <= SexValor)
            {
                double calculo = (valor * (PorcentagemContribuicao3 / 100)) - ValorContribuicao2;
                double valorPorcentagem = valor * (PorcentagemContribuicao3 / 100);
                formula = "R$ " + valor + " * " + PorcentagemContribuicao3 + "% = " + "R$ " + valorPorcentagem +"\n" + "R$ " + valorPorcentagem + " - " + "R$ " + ValorContribuicao2 + " = " + "R$ " + calculo;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else if (valor >= SetValor && valor <= OValor)
            {
                double calculo = (valor * (PorcentagemContribuicao4 / 100)) - ValorContribuicao3;
                double valorPorcentagem = valor * (PorcentagemContribuicao4 / 100);
                formula = "R$ " + valor + " * " + PorcentagemContribuicao4 + "% = " + "R$ " + valorPorcentagem + "\n" + "R$ " + valorPorcentagem + " - " + "R$ " + ValorContribuicao3 + " = " + "R$ " + calculo;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else if (valor > OValor)
            {
                double calculo = ValorContribuicaoFixo;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else
            {
                MessageBox.Show("Soma de calculo inexistente na tabela !!");
                return;
            }

            //txtResultado.Text = Convert.ToString(valorfinal);
        }

        private void CalculoIRRF()
        {
            //Variaveis a serem utilizadas na Contribuição Previdenciaria
            double PorcentagemContribuicao1 = double.Parse(Valores.PorcentagemContribuicao1);
            double PorcentagemContribuicao2 = double.Parse(Valores.PorcentagemContribuicao2);
            double PorcentagemContribuicao3 = double.Parse(Valores.PorcentagemContribuicao3);
            double PorcentagemContribuicao4 = double.Parse(Valores.PorcentagemContribuicao4);
            double ValorContribuicao1 = double.Parse(Valores.ValorContribuicao1);
            double ValorContribuicao2 = double.Parse(Valores.ValorContribuicao2);
            double ValorContribuicao3 = double.Parse(Valores.ValorContribuicao3);
            double ValorContribuicaoFixo = double.Parse(Valores.ValorContribuicaoFixo);
            double PValor = double.Parse(Valores.PValor);
            double SValor = double.Parse(Valores.SValor);
            double TValor = double.Parse(Valores.TValor);
            double QValor = double.Parse(Valores.QValor);
            double QuValor = double.Parse(Valores.QuValor);
            double SexValor = double.Parse(Valores.SexValor);
            double SetValor = double.Parse(Valores.SetValor);
            double OValor = double.Parse(Valores.OValor);

            //Variaveis a serem utilizadas em IRRF
            double PorcentagemIRRF1 = double.Parse(Valores.PorcentagemIRRF1);
            double PorcentagemIRRF2 = double.Parse(Valores.PorcentagemIRRF2);
            double PorcentagemIRRF3 = double.Parse(Valores.PorcentagemIRRF3);
            double PorcentagemIRRF4 = double.Parse(Valores.PorcentagemIRRF4);
            double ValorIRRFDeduzir1 = double.Parse(Valores.ValorIRRFDeduzir1);
            double ValorIRRFDeduzir2 = double.Parse(Valores.ValorIRRFDeduzir2);
            double ValorIRRFDeduzir3 = double.Parse(Valores.ValorIRRFDeduzir3);
            double ValorIRRFDeduzir4 = double.Parse(Valores.ValorIRRFDeduzir4);
            double ValorIRRFDeduzir5 = double.Parse(Valores.ValorIRRFDeduzir5);
            double Dependente = double.Parse(Valores.Dependente);
            double ValorIRRF1 = double.Parse(Valores.ValorIRRF1);
            double ValorIRRF2 = double.Parse(Valores.ValorIRRF2);
            double ValorIRRF3 = double.Parse(Valores.ValorIRRF3);
            double ValorIRRF4 = double.Parse(Valores.ValorIRRF4);
            double ValorIRRF5 = double.Parse(Valores.ValorIRRF5);
            double ValorIRRF6 = double.Parse(Valores.ValorIRRF6);
            double ValorIRRF7 = double.Parse(Valores.ValorIRRF7);
            double ValorIRRF8 = double.Parse(Valores.ValorIRRF8);



            if (txtValorIRRF.Text == "" || txtDeducao.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }

            double valor = Convert.ToDouble(txtValorIRRF.Text);
            double valorDeducao = 0 + Convert.ToDouble(txtDeducao.Text);

            if (valor > PValor && valor <= SValor)
            {
                double valorfinal = valor * (PorcentagemContribuicao1 / 100);
                lblINSSTeste.Text = valorfinal.ToString();
            }
            else if (valor >= TValor && valor <= QValor)
            {
                double calculo = (valor * (PorcentagemContribuicao2 / 100)) - ValorContribuicao1;
                lblINSSTeste.Text = calculo.ToString();
            }
            else if (valor >= QuValor && valor <= SexValor)
            {
                double calculo = (valor * (PorcentagemContribuicao3 / 100)) - ValorContribuicao2;
                lblINSSTeste.Text = calculo.ToString();
            }
            else if (valor >= SetValor && valor <= OValor)
            {
                double calculo = (valor * (PorcentagemContribuicao4 / 100)) - ValorContribuicao3;
                lblINSSTeste.Text = calculo.ToString();
            }
            else if (valor > OValor)
            {
                var INSSNovo = ValorContribuicaoFixo;
                lblINSSTeste.Text = INSSNovo.ToString();
            }

            double INSS = Convert.ToDouble(lblINSSTeste.Text);
            double deducao = valorDeducao * Dependente;

            var valordecisao = valor - INSS;

            if (valorDeducao <= 0)
            {
                if (valordecisao < ValorIRRF1)
                {

                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valordecisao >= ValorIRRF2 && valordecisao <= ValorIRRF3)
                {
                    double conclusao = (((valor - INSS) * (PorcentagemIRRF1 / 100)) - ValorIRRFDeduzir2);
                    //double AliquotaIRRF = SubtracaoValor * (PorcentagemIRRF1 / 100);
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir2;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= ValorIRRF4 && valordecisao <= ValorIRRF5)
                {
                    double conclusao = (((valor - INSS) * (PorcentagemIRRF2 / 100)) - ValorIRRFDeduzir3);
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * PorcentagemIRRF2 / 100;
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir3;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao >= ValorIRRF6 && valordecisao <= ValorIRRF7)
                {
                    double conclusao = (((valor - INSS) * (PorcentagemIRRF3 / 100)) - ValorIRRFDeduzir4);
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * PorcentagemIRRF3 / 100;
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir4;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valordecisao > ValorIRRF8)
                {
                    double conclusao = (((valor - INSS) * (PorcentagemIRRF4 / 100)) - ValorIRRFDeduzir5);
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * (PorcentagemIRRF4 / 100);
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir5;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }

            }
            else if (valorDeducao >= 1)
            {

                if (valordecisao < ValorIRRF1)
                {
                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valordecisao >= ValorIRRF2 && valordecisao <= ValorIRRF3)
                {
                    double conclusao = (((valor - INSS - deducao) * (PorcentagemIRRF1 / 100)) - ValorIRRFDeduzir2);
                    if (conclusao <=0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valordecisao >= ValorIRRF4 && valordecisao <= ValorIRRF5)
                {
                    double conclusao = (((valor - INSS - deducao) * (PorcentagemIRRF2 / 100)) - ValorIRRFDeduzir3);

                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valordecisao >= ValorIRRF6 && valordecisao <= ValorIRRF7)
                {
                    double conclusao = (((valor - INSS - deducao) * (PorcentagemIRRF3 / 100)) - ValorIRRFDeduzir4);
                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valordecisao >= ValorIRRF8)
                {
                    double conclusao = (((valor - INSS - deducao) * (PorcentagemIRRF4 / 100)) - ValorIRRFDeduzir5);
                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
            }
        }

        private void CalculoIRRFDeduzir()
        {
            //Variaveis a serem utilizadas na Contribuição Previdenciaria
            double PorcentagemContribuicao1 = double.Parse(Valores.PorcentagemContribuicao1);
            double PorcentagemContribuicao2 = double.Parse(Valores.PorcentagemContribuicao2);
            double PorcentagemContribuicao3 = double.Parse(Valores.PorcentagemContribuicao3);
            double PorcentagemContribuicao4 = double.Parse(Valores.PorcentagemContribuicao4);
            double ValorContribuicao1 = double.Parse(Valores.ValorContribuicao1);
            double ValorContribuicao2 = double.Parse(Valores.ValorContribuicao2);
            double ValorContribuicao3 = double.Parse(Valores.ValorContribuicao3);
            double ValorContribuicaoFixo = double.Parse(Valores.ValorContribuicaoFixo);
            double PValor = double.Parse(Valores.PValor);
            double SValor = double.Parse(Valores.SValor);
            double TValor = double.Parse(Valores.TValor);
            double QValor = double.Parse(Valores.QValor);
            double QuValor = double.Parse(Valores.QuValor);
            double SexValor = double.Parse(Valores.SexValor);
            double SetValor = double.Parse(Valores.SetValor);
            double OValor = double.Parse(Valores.OValor);

            //Variaveis a serem utilizadas em IRRF
            double PorcentagemIRRF1 = double.Parse(Valores.PorcentagemIRRF1);
            double PorcentagemIRRF2 = double.Parse(Valores.PorcentagemIRRF2);
            double PorcentagemIRRF3 = double.Parse(Valores.PorcentagemIRRF3);
            double PorcentagemIRRF4 = double.Parse(Valores.PorcentagemIRRF4);
            double ValorIRRFDeduzir1 = double.Parse(Valores.ValorIRRFDeduzir1);
            double ValorIRRFDeduzir2 = double.Parse(Valores.ValorIRRFDeduzir2);
            double ValorIRRFDeduzir3 = double.Parse(Valores.ValorIRRFDeduzir3);
            double ValorIRRFDeduzir4 = double.Parse(Valores.ValorIRRFDeduzir4);
            double ValorIRRFDeduzir5 = double.Parse(Valores.ValorIRRFDeduzir5);
            double Dependente = double.Parse(Valores.Dependente);
            double ValorIRRF1 = double.Parse(Valores.ValorIRRF1);
            double ValorIRRF2 = double.Parse(Valores.ValorIRRF2);
            double ValorIRRF3 = double.Parse(Valores.ValorIRRF3);
            double ValorIRRF4 = double.Parse(Valores.ValorIRRF4);
            double ValorIRRF5 = double.Parse(Valores.ValorIRRF5);
            double ValorIRRF6 = double.Parse(Valores.ValorIRRF6);
            double ValorIRRF7 = double.Parse(Valores.ValorIRRF7);
            double ValorIRRF8 = double.Parse(Valores.ValorIRRF8);

            double deduzirINSS = double.Parse(Valores.DeduzindoINSS);


            if (txtValorIRRF.Text == "" || txtDeducao.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }

            double valorx = Convert.ToDouble(txtValorIRRF.Text);
            double valorDeducao = 0 + Convert.ToDouble(txtDeducao.Text);
            double valor = valorx - deduzirINSS;

            double deducao = valorDeducao * Dependente;

            if (valorDeducao <= 0)
            {

                if (valor < ValorIRRF1)
                {

                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valor >= ValorIRRF2 && valor <= ValorIRRF3)
                {
                    double conclusao = ((valor * (PorcentagemIRRF1 / 100)) - ValorIRRFDeduzir2);
                    double irrfConclusao = valor * (PorcentagemIRRF1 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF1 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir2 + "= R$" + conclusao;
                    //double AliquotaIRRF = SubtracaoValor * (PorcentagemIRRF1 / 100);
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir2;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valor >= ValorIRRF4 && valor <= ValorIRRF5)
                {
                    double conclusao = ((valor * (PorcentagemIRRF2 / 100)) - ValorIRRFDeduzir3);
                    double irrfConclusao = valor * (PorcentagemIRRF2 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF2 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir3 + "= R$" + conclusao;
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * PorcentagemIRRF2 / 100;
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir3;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valor >= ValorIRRF6 && valor <= ValorIRRF7)
                {
                    double conclusao = ((valor * (PorcentagemIRRF3 / 100)) - ValorIRRFDeduzir4);
                    double irrfConclusao = valor * (PorcentagemIRRF3 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF3 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir4 + "= R$" + conclusao;
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * PorcentagemIRRF3 / 100;
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir4;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valor > ValorIRRF8)
                {
                    double conclusao = ((valor * (PorcentagemIRRF4 / 100)) - ValorIRRFDeduzir5);
                    double irrfConclusao = valor * (PorcentagemIRRF4 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF4 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir5 + "= R$" + conclusao;
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * (PorcentagemIRRF4 / 100);
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir5;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }

            }
            else if (valorDeducao >= 1)
            {

                if (valor < ValorIRRF1)
                {
                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valor >= ValorIRRF2 && valor <= ValorIRRF3)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF1 / 100)) - ValorIRRFDeduzir2);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF1 / 100);
                    formulaIRRF = "R$ " + valor + " - " + "R$" + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF1 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir2 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;

                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valor >= ValorIRRF4 && valor <= ValorIRRF5)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF2 / 100)) - ValorIRRFDeduzir3);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF2 / 100);
                    formulaIRRF = "R$ " + valor + " - " + "R$" + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF2 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir3 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;


                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valor >= ValorIRRF6 && valor <= ValorIRRF7)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF3 / 100)) - ValorIRRFDeduzir4);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF3 / 100);
                    formulaIRRF = "R$ " + valor + " - " + "R$" + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF3 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir4 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;

                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valor >= ValorIRRF8)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF4 / 100)) - ValorIRRFDeduzir5);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF4 / 100);
                    formulaIRRF = "R$ " + valor + " - " + "R$" + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF4 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir5 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;

                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
            }
        }

        private void CalculoIRRFNovo()
        {
            //Variaveis a serem utilizadas na Contribuição Previdenciaria
            double PorcentagemContribuicao1 = double.Parse(Valores.PorcentagemContribuicao1);
            double PorcentagemContribuicao2 = double.Parse(Valores.PorcentagemContribuicao2);
            double PorcentagemContribuicao3 = double.Parse(Valores.PorcentagemContribuicao3);
            double PorcentagemContribuicao4 = double.Parse(Valores.PorcentagemContribuicao4);
            double ValorContribuicao1 = double.Parse(Valores.ValorContribuicao1);
            double ValorContribuicao2 = double.Parse(Valores.ValorContribuicao2);
            double ValorContribuicao3 = double.Parse(Valores.ValorContribuicao3);
            double ValorContribuicaoFixo = double.Parse(Valores.ValorContribuicaoFixo);
            double PValor = double.Parse(Valores.PValor);
            double SValor = double.Parse(Valores.SValor);
            double TValor = double.Parse(Valores.TValor);
            double QValor = double.Parse(Valores.QValor);
            double QuValor = double.Parse(Valores.QuValor);
            double SexValor = double.Parse(Valores.SexValor);
            double SetValor = double.Parse(Valores.SetValor);
            double OValor = double.Parse(Valores.OValor);

            //Variaveis a serem utilizadas em IRRF
            double PorcentagemIRRF1 = double.Parse(Valores.PorcentagemIRRF1);
            double PorcentagemIRRF2 = double.Parse(Valores.PorcentagemIRRF2);
            double PorcentagemIRRF3 = double.Parse(Valores.PorcentagemIRRF3);
            double PorcentagemIRRF4 = double.Parse(Valores.PorcentagemIRRF4);
            double ValorIRRFDeduzir1 = double.Parse(Valores.ValorIRRFDeduzir1);
            double ValorIRRFDeduzir2 = double.Parse(Valores.ValorIRRFDeduzir2);
            double ValorIRRFDeduzir3 = double.Parse(Valores.ValorIRRFDeduzir3);
            double ValorIRRFDeduzir4 = double.Parse(Valores.ValorIRRFDeduzir4);
            double ValorIRRFDeduzir5 = double.Parse(Valores.ValorIRRFDeduzir5);
            double Dependente = double.Parse(Valores.Dependente);
            double ValorIRRF1 = double.Parse(Valores.ValorIRRF1);
            double ValorIRRF2 = double.Parse(Valores.ValorIRRF2);
            double ValorIRRF3 = double.Parse(Valores.ValorIRRF3);
            double ValorIRRF4 = double.Parse(Valores.ValorIRRF4);
            double ValorIRRF5 = double.Parse(Valores.ValorIRRF5);
            double ValorIRRF6 = double.Parse(Valores.ValorIRRF6);
            double ValorIRRF7 = double.Parse(Valores.ValorIRRF7);
            double ValorIRRF8 = double.Parse(Valores.ValorIRRF8);


            if (txtValorIRRF.Text == "" || txtDeducao.Text == "")
            {
                MessageBox.Show("Não deixe campos vazios!!!!");
                return;
            }

            double valorx = Convert.ToDouble(txtValorIRRF.Text);
            double valorDeducao = 0 + Convert.ToDouble(txtDeducao.Text);
            double valor = valorx - 0;

            double deducao = valorDeducao * Dependente;

            if (valorDeducao <= 0)
            {

                if (valor < ValorIRRF1)
                {

                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valor >= ValorIRRF2 && valor <= ValorIRRF3)
                {
                    double conclusao = ((valor * (PorcentagemIRRF1 / 100)) - ValorIRRFDeduzir2);
                    double irrfConclusao = valor * (PorcentagemIRRF1 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF1 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir2 + "= R$"+  conclusao;
                    //double AliquotaIRRF = SubtracaoValor * (PorcentagemIRRF1 / 100);
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir2;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valor >= ValorIRRF4 && valor <= ValorIRRF5)
                {
                    double conclusao = ((valor * (PorcentagemIRRF2 / 100)) - ValorIRRFDeduzir3);
                    double irrfConclusao = valor * (PorcentagemIRRF2 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF2 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir3 + "= R$" + conclusao;
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * PorcentagemIRRF2 / 100;
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir3;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valor >= ValorIRRF6 && valor <= ValorIRRF7)
                {
                    double conclusao = ((valor * (PorcentagemIRRF3 / 100)) - ValorIRRFDeduzir4);
                    double irrfConclusao = valor * (PorcentagemIRRF3 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF3 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir4 + "= R$" + conclusao;
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * PorcentagemIRRF3 / 100;
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir4;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }
                else if (valor > ValorIRRF8)
                {
                    double conclusao = ((valor * (PorcentagemIRRF4 / 100)) - ValorIRRFDeduzir5);
                    double irrfConclusao = valor * (PorcentagemIRRF4 / 100);
                    formulaIRRF = "R$" + valor + " * " + PorcentagemIRRF4 + "% = R$" + irrfConclusao + "\n" + "R$" + irrfConclusao + " - R$" + ValorIRRFDeduzir5 + "= R$" + conclusao;
                    //double SubtracaoValor = valor - INSS;
                    //double AliquotaIRRF = SubtracaoValor * (PorcentagemIRRF4 / 100);
                    //double conclusao = AliquotaIRRF - ValorIRRFDeduzir5;
                    txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                }

            }
            else if (valorDeducao >= 1)
            {

                if (valor < ValorIRRF1)
                {
                    MessageBox.Show("Valor não tem oque ser calculado !");
                    return;
                }
                else if (valor >= ValorIRRF2 && valor <= ValorIRRF3)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF1 / 100)) - ValorIRRFDeduzir2);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF1 / 100);
                    formulaIRRF = "R$ " + valor + " - " +  "R$" + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n" 
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF1 + "% = R$ " + irrfConclusao + "\n"+
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir2 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n"+ "Valor por dependente: R$ " + Dependente;

                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valor >= ValorIRRF4 && valor <= ValorIRRF5)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF2 / 100)) - ValorIRRFDeduzir3);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF2 / 100);
                    formulaIRRF = "R$ " + valor + " - " +  "R$ " + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF2 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir3 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;

                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valor >= ValorIRRF6 && valor <= ValorIRRF7)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF3 / 100)) - ValorIRRFDeduzir4);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF3 / 100);
                    formulaIRRF = "R$ " + valor + " - "  + "R$ " + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF3 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir4 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;
                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
                else if (valor >= ValorIRRF8)
                {
                    double conclusao = (((valor - deducao) * (PorcentagemIRRF4 / 100)) - ValorIRRFDeduzir5);
                    double irrfDeducao = valor - deducao;
                    double irrfConclusao = irrfDeducao * (PorcentagemIRRF4 / 100);
                    formulaIRRF = "R$ " + valor + " - " + "R$ " + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
                        + "R$ " + irrfDeducao + " * " + PorcentagemIRRF4 + "% = R$ " + irrfConclusao + "\n" +
                        "R$ " + irrfConclusao + " - " + "R$ " + ValorIRRFDeduzir5 + "= R$ " + conclusao + "\n\n" + "Valores entre parênteses é a quantidade de dependentes\n" + "Valor por dependente: R$ " + Dependente;
                    if (conclusao <= 0.00)
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00");
                    }
                    else
                    {
                        txtValorTotalIRRF.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", conclusao);
                    }
                }
            }
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

            /*Teste*/
            if (valor >= 0 && valor <= 1100.00)
            {
                double valorfinal = valor * (7.5 / 100);
                txtPrevidencia.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                var valorTotal = valorfinal + contribuicao + seguro + FGTS + Multa;
                double valorCompleto = valorTotal - salarioFamilia;
                if (salarioFamilia >0)
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void btnContribuicao_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = pageContribuicao;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContribuicaoAssalariado();
            btnFormula.Enabled = true;
        }


        private void FormPrincipalNew_Load(object sender, EventArgs e)
        {
            //string frase = File.ReadAllText("Config\\Version.ajw");
            //lkClick.Text = frase;
            lkClick.Text = "Versão:" + ProductVersion;
            VerificarChave();
            FormConfiguration config = new FormConfiguration();
        }

        private void lkClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangelog formChangelog = new FormChangelog();
            formChangelog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDataEmDias form = new FormDataEmDias();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCalculoDias form = new FormCalculoDias();
            form.Show();
        }

        private void btnCalcularIRRF_Click(object sender, EventArgs e)
        {
            if (checkDeduzir.Checked == true)
            {
                CalculoIRRFDeduzir();
                btnFormulaIRRF.Enabled = true;
            }
            else
            {
                CalculoIRRFNovo();
                btnFormulaIRRF.Enabled = true;
            }

        }

        private void txtValor_TextChanged_1(object sender, EventArgs e)
        {
            txtValor.Text = Regex.Replace(txtValor.Text, "[^0-9,.]", "");
        }

        private void txtValorIRRF_TextChanged(object sender, EventArgs e)
        {
            txtValorIRRF.Text = Regex.Replace(txtValorIRRF.Text, "[^0-9,.]", "");
        }

        private void btnIRRF_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = pageIRRF;
        }

        private void btnCalcularDAE_Click(object sender, EventArgs e)
        {
            CalculoDAENormal();
            btnFormulaDAE.Enabled = true;
        }

        private void tabDAE_Click(object sender, EventArgs e)
        {
            /*FormPrincipalNew formP = new FormPrincipalNew();
            tabPrincipal.Width = 383;
            tabPrincipal.Height = 262;
            formP.Width = 489;
            formP.Height = 399;
            lblBoasVindas.Location = new Point(36, 325);
            lblNome.Location = new Point(184, 325);
            lkClick.Location = new Point(372, 333);
            */
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            FormCustoFuncionario formCusto = new FormCustoFuncionario();
            formCusto.Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = tabDAE;

        }

        private void txtValorDAE_TextChanged(object sender, EventArgs e)
        {
            txtValorDAE.Text = Regex.Replace(txtValorDAE.Text, "[^0-9,.]", "");
        }

        private void txtValorDAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcularDAE_Click(sender, e);
            }
        }

        private void txtValorIRRF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkDeduzir.Checked == true)
            {
                if (e.KeyChar == 13)
                {
                    btnCalcularIRRFDeduzir_Click(sender, e);
                }

            }
            else if (checkDeduzir.Checked == false)
            {
                if (e.KeyChar == 13)
                {
                    btnCalcularIRRF_Click(sender, e);
                }
            }

        }

        public void LimparCampos()
        {
            txtValor.Clear();
            txtValorDAE.Clear();
            txtValorIRRF.Clear();
            txtValorTotalIRRF.Clear();
            txtResultado.Clear();
            txtDeducao.Value = 0;
            txtContribuicao.Clear();
            txtPrevidencia.Clear();
            txtSeguro.Clear();
            txtFGTS.Clear();
            txtIndenizacao.Clear();
            txtFinal.Clear();
            Valores.DeduzindoINSS = "0";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            checkDeduzir.Checked = false;
        }

        private void informaçõesSobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularIRRFDeduzir_Click(object sender, EventArgs e)
        {
            CalculoIRRFDeduzir();
        }

        private void checkDeduzir_Click(object sender, EventArgs e)
        {
            if (checkDeduzir.Checked == true)
            {
               /* btnCalcularIRRFDeduzir.Location = new Point(210, 220);
                btnCalcularIRRFDeduzir.Visible = true;
                btnCalcularIRRF.Visible = false;*/
                LimparCampos();
                FormDeduzindoINSS form = new FormDeduzindoINSS();
                form.Show();

            }
            else if (checkDeduzir.Checked == false)
            {
                /*btnCalcularIRRF.Visible = true;
                btnCalcularIRRFDeduzir.Visible = false;*/
                LimparCampos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSalarioFamilia form = new FormSalarioFamilia();
            form.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormConfiguration formConfiguration = new FormConfiguration();
            formConfiguration.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            FormDataEmDias form = new FormDataEmDias();
            form.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FormCalculoDias form = new FormCalculoDias();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculoIRRF();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormVerificarIrregularidadeGPS gps = new FormVerificarIrregularidadeGPS();
            gps.Show();
        }

        private void verificaçãoDeIrregularidadeGPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerificarIrregularidadeGPS gps = new FormVerificarIrregularidadeGPS();
            gps.Show();
        }

        private void timerMemory_Tick(object sender, EventArgs e)
        {
            MemoryManagement obj = new MemoryManagement();
            obj.FlushMemory();
        }

        private void consultarCNPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCNPJ form = new FormCNPJ();
            form.Show();
        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veja como é feito o calculo: \n" + formula,"Formula matemática");
        }

        private void btnFormulaIRRF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veja como é feito o calculo: \n" + formulaIRRF, "Formula matemática");

        }

        private void btnFormulaDAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veja como é feito o calculo: \n" + formulaDAE, "Formula matemática");
        }



        /*
         tabPrincipal.Width = 383;
         tabPrincipal.Height = 172;
         
         */
    }
}
