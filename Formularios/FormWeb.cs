using DPInterativo.Classes;
using DPInterativo.NovoFormPrincipal;
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
    public partial class FormWeb : Form
    {
        public FormWeb()
        {
            InitializeComponent();
        }

        private void FormWeb_Load(object sender, EventArgs e)
        {
            if (Valores.Url != string.Empty)
            {
                txtURL.Text = Valores.Url;
                webBrowser.Navigate(Valores.Url);
            }
            else
            {
                
            }
        }
    }
}
