using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPInterativo.Classes
{
    public class Valores
    {
        //Classes locais
        private static MyIni MyIni = new MyIni("./Config/Config.ini");
        public static string impostoRRF { get; set; }

        //Calculo de Aliquotas
        public static string version { get; set; }
        public static string TemaVersao { get; set; }
        public static string PorcentagemContribuicao1 { get; set; }
        public static string PorcentagemContribuicao2 { get; set; }
        public static string PorcentagemContribuicao3 { get; set; }
        public static string PorcentagemContribuicao4 { get; set; }

        //Valor de subtração previdenciaria
        public static string ValorContribuicao1 { get; set; }
        public static string ValorContribuicao2 { get; set; }
        public static string ValorContribuicao3 { get; set; }
        public static string ValorContribuicaoFixo { get; set; }

        //Configuração Previdenciaria
        public static string PValor { get; set; }
        public static string SValor { get; set; }
        public static string TValor { get; set; }
        public static string QValor { get; set; }
        public static string QuValor { get; set; }
        public static string SexValor { get; set; }
        public static string SetValor { get; set; }
        public static string OValor { get; set; }

        //Calculo de Aliquota IRRF
        public static string PorcentagemIRRF0 { get; set; }
        public static string PorcentagemIRRF1 { get; set; }
        public static string PorcentagemIRRF2 { get; set; }
        public static string PorcentagemIRRF3 { get; set; }
        public static string PorcentagemIRRF4 { get; set; }

        //Valor IRRF
        public static string ValorIRRFDeduzir1 { get; set; }
        public static string ValorIRRFDeduzir2 { get; set; }
        public static string ValorIRRFDeduzir3 { get; set; }
        public static string ValorIRRFDeduzir4 { get; set; }
        public static string ValorIRRFDeduzir5 { get; set; }
        public static string Dependente { get; set; }


        //Configuração IRRF
        public static string ValorIRRF1 { get; set; }
        public static string ValorIRRF2 { get; set; }
        public static string ValorIRRF3 { get; set; }
        public static string ValorIRRF4 { get; set; }
        public static string ValorIRRF5 { get; set; }
        public static string ValorIRRF6 { get; set; }
        public static string ValorIRRF7 { get; set; }
        public static string ValorIRRF8 { get; set; }
        public static string PeriodoAquisitivo { get; set; }
        public static string PeriodoConcessivo { get; set; }
        public static string DeduzindoINSS { get; set; }
        // Calculo de datas
        public static string Mais1Dias { get; set; }
        //Salario Familia
        public static string AteSalarioFamilia { get; set; }
        public static string ValorSalarioFamilia {get;set;}
        public static string SomaSalarioFamilia { get; set; }
        public static string AcimaSalarioFamilia { get; set; }
        public static string SSF { get; set; }
        
        //Salario Minimo
        public static string SalarioMinimo { get; set; }
        //GPS e INSS
        public static string valorMinimoGPS { get; set; }
        public static string valorMinimoINSS { get; set; }

        //Variavel que trará os valores do Registro Win32
        public static string Nome { get; set; }

        //Variavel para carregar valores para abrir o FormWeb
        public static string Url { get; set; }
        public static string UrlCNPJ { get; set; }

        public static void Funcoes_do_Sistema()
        {
            //Instanciamos la clase MyIni
            MyIni = new MyIni("./Config/Config.ini");
            INIFile ini = new INIFile(MyIni.FileName);


            Valores.version = MyIni.GetString("Configuracao", "Version", string.Empty);
            Valores.TemaVersao = MyIni.GetString("Configuracao", "TemaVersao", string.Empty);
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

        // ----- Funções do Layout Configuration ----- \\

        public static string versao_Guna { get; set; }
        public static string versao_MD { get; set; }


    }

    public class Cores
    {
        public string Vermelho { get; set; }

    }
}
