using DPInterativo.Classes;
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

namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    public partial class FormContribuicaoPrevidenciaria : Form
    {
        string formula;
        private MyIni MyIni;
        public Valores Valores;

        public FormContribuicaoPrevidenciaria()
        {
            InitializeComponent();
            Funcoes_do_Sistema();
        }
        public void LimparCampos()
        {
            txtValor.Clear();
            txtResultado.Clear();
            Valores.DeduzindoINSS = "0";
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
                    txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ 0,00", valorfinal);

                }
                else
                {
                    txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorfinal);
                }
            }
            else if (valor >= TValor && valor <= QValor)
            {
                double calculo = (valor * (PorcentagemContribuicao2 / 100)) - ValorContribuicao1;
                double valorPorcentagem = valor * (PorcentagemContribuicao2 / 100);
                formula = "R$ " + valor + " * " + PorcentagemContribuicao2 + "% = " + "R$ " + valorPorcentagem + "\n" + "R$ " + valorPorcentagem + " - " + "R$ " + ValorContribuicao1 + " = " + "R$ " + calculo;
                txtResultado.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", calculo);
            }
            else if (valor >= QuValor && valor <= SexValor)
            {
                double calculo = (valor * (PorcentagemContribuicao3 / 100)) - ValorContribuicao2;
                double valorPorcentagem = valor * (PorcentagemContribuicao3 / 100);
                formula = "R$ " + valor + " * " + PorcentagemContribuicao3 + "% = " + "R$ " + valorPorcentagem + "\n" + "R$ " + valorPorcentagem + " - " + "R$ " + ValorContribuicao2 + " = " + "R$ " + calculo;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContribuicaoAssalariado();
            btnFormula.Enabled = true;
        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veja como é feito o calculo: \n" + formula, "Formula matemática");
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = Regex.Replace(txtValor.Text, "[^0-9,.]", "");
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnFormula.Enabled = false;
        }
    }
}
