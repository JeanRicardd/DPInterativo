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
    public partial class FormIRRF : Form
    {
        string formulaIRRF;

        public FormIRRF()
        {
            InitializeComponent();
            txtDeducao.Text = "0";
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


            if (txtValorIRRF.Text == string.Empty || txtDeducao.Text == string.Empty)
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
                    formulaIRRF = "R$ " + valor + " - " + "R$ " + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
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
                    formulaIRRF = "R$ " + valor + " - " + "R$ " + deducao + "(" + valorDeducao + ")" + " = R$ " + irrfDeducao + "\n"
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


            if (txtValorIRRF.Text == string.Empty || txtDeducao.Text == string.Empty)
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
        public void LimparCampos()
        {
            txtValorIRRF.Clear();
            txtValorTotalIRRF.Clear();
            txtDeducao.Value = 0;
            Valores.DeduzindoINSS = "0";
        }
        private void checkDeduzir_Click(object sender, EventArgs e)
        {
            if (checkDeduzir.Checked == true)
            {
                btnCalcularIRRFDeduzir.Location = new Point(131, 149);
                btnCalcularIRRFDeduzir.Visible = true;
                btnCalcularIRRF.Visible = false;
                LimparCampos();
                FormDeduzindoINSS form = new FormDeduzindoINSS();
                form.Show();

            }
            else if (checkDeduzir.Checked == false)
            {
                btnCalcularIRRF.Visible = true;
                btnCalcularIRRFDeduzir.Visible = false;
                LimparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnFormulaIRRF.Enabled = false;
        }

        private void btnFormulaIRRF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veja como é feito o calculo: \n" + formulaIRRF, "Formula matemática");
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

        private void btnCalcularIRRFDeduzir_Click(object sender, EventArgs e)
        {
            CalculoIRRFDeduzir();
        }

        private void btnCalcularIRRF_Click(object sender, EventArgs e)
        {
            CalculoIRRFNovo();
            btnFormulaIRRF.Enabled = true;
        }

        private void txtValorIRRF_TextChanged(object sender, EventArgs e)
        {
            txtValorIRRF.Text = Regex.Replace(txtValorIRRF.Text, "[^0-9,.]", "");
        }
    }
}
