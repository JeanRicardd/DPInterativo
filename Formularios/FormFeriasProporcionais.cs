using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.Formularios
{
    public partial class FormFeriasProporcionais : Form
    {
        public FormFeriasProporcionais()
        {
            InitializeComponent();
            //ebBrowser1. = System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }
    }
}
