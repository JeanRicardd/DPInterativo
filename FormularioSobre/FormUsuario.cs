using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.FormularioSobre
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            if (cbTema.Text == "")
            {
                cbTema.Text = "Padrão";
            }
            cbTema.Items.Add("Padrão");
            cbTema.Items.Add("Branco");
        }
    }
}
