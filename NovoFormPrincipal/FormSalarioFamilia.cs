using DPInterativo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPInterativo.NovoFormPrincipal
{
    public partial class FormSalarioFamilia : Form
    {
        public FormSalarioFamilia()
        {
            InitializeComponent();
        }



        public void calculandoDependente()
        {
            double salarioFamilia = double.Parse(Valores.AteSalarioFamilia);
            double valorFinal = double.Parse(txtDeducao.Text) * salarioFamilia;
            Valores.SSF = valorFinal.ToString();
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            calculandoDependente();
        }
    }
}
