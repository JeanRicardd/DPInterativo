using DPInterativo.Classes;
using DPInterativo.Formularios;
using DPInterativo.NovoFormPrincipal;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Valores.Funcoes_do_Sistema();
            RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey(@"Software\InteratCalc\Config");
            //verificandoChaveTema = Registry.CurrentUser.OpenSubKey(@"Software\InteratCalc\Config\Tema");
            //Application.Run(new FormInsiraNome());
            /*

             if (key == null)
             {
                if (key == null)
                 {
                     Application.Run(new FormInsiraNome());
                 }
                 key = Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\Config");
                 key.SetValue("Tema", 0, RegistryValueKind.String);
                 key.Close();
             }
             else
             {
                Application.Run(new FormPrincipalRemaster());              
             } */


            
            void Criar_Registro()
            {              
                key = Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\");
            }

            if (key == null)
            {
                Criar_Registro();
                Application.Run(new FormInsiraNome());
            }
            else
            {
                Application.Run(new FormPrincipalRemaster());
            }

            /*
            key = Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\Config");
            key.SetValue("Tema", 0, RegistryValueKind.String);
            key.Close();*/

            /*if (key.GetValue("Tema") == null)
            {
                key = Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\");
                key.CreateSubKey("Tema");
                key.SetValue("Tema", 0, RegistryValueKind.String);
                key.Close();
            }*/
            /*if (key == null | key.GetValue("Tema") == null)
            {
               if (key == null)
                {
                    Application.Run(new FormInsiraNome());
                }
                key = Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\Config");
                key.SetValue("Tema", 0, RegistryValueKind.String);
                key.Close();
            }
            else
            {
                if (Valores.TemaVersao == "0")
                {
                    Application.Run(new FormPrincipalNew());
                }
                else if (Valores.TemaVersao == "1")
                {
                    Application.Run(new FormPrincipalRemaster());

                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar a interface, verifique nas configurações","Configuração",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }                 
            }   */
        }
    }
}
