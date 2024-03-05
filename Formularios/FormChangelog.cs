using DPInterativo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DPInterativo.Formularios
{
    public partial class FormChangelog : Form
    {
        public FormChangelog()
        {
            InitializeComponent();
        }

        private void FormChangelog_Load(object sender, EventArgs e)
        {
               webBrowser.Navigate("https://limes-servers-dataloads.000webhostapp.com/dpbasic/Changelog.html");

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Seleciona todos os elementos com a classe "example" dentro de uma div com o ID "container"


        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.Scheme == "https")
            {
                // Ignorar erros de segurança para HTTPS.
                e.Cancel = true;
                webBrowser.Navigate(e.Url.ToString(), null, null, "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36 Edge/16.16299");
            }
        }
    }
}
