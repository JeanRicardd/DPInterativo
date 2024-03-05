using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPInterativo.Classes;

namespace DPInterativo.NovoFormPrincipal
{
    public partial class FormDeduzindoINSS : Form
    {
        public FormDeduzindoINSS()
        {
            InitializeComponent();
        }

        private void btnConfirmarINSS_Click(object sender, EventArgs e)
        {
            Valores.DeduzindoINSS = txtDeduzirINSS.Text;
            Close();
        }

        private void txtDeduzirINSS_TextChanged(object sender, EventArgs e)
        {
            txtDeduzirINSS.Text = Regex.Replace(txtDeduzirINSS.Text, "[^0-9,.]", "");
        }

        private void txtDeduzirINSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConfirmarINSS_Click(sender, e);
            }
        }
    }
}
