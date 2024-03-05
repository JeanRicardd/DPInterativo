using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DPInterativo.Classes
{
    public class CNPJ_Servico
    {
        private static string EnderecoUrl = "https://receitaws.com.br/v1/cnpj/";

        public static CNPJ BuscaCNPJ(string cnpj)
        {
            //Criando a variavel para receber a url com o cep
            string enderecoBusca = string.Format(EnderecoUrl + cnpj);

            //Criando o WebClient para acessar o WebService
            WebClient webClient = new WebClient();

            //Baixando os dados da consulta e armazenando na variavel resultado
            string resultado = webClient.DownloadString(enderecoBusca);

            // <> : representa Paramêtros
            //Realizando a passagen de valores para a classe e tratando os valores em formato Json.
            CNPJ usuario = JsonConvert.DeserializeObject<CNPJ>(resultado);

            return usuario;

        }
    }
}
