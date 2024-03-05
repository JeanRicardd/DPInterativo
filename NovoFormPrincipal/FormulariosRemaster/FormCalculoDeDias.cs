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

namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    public partial class FormCalculoDeDias : Form
    {
        public Valores Valores;
        public FormCalculoDeDias()
        {
            InitializeComponent();
        }

        public void CalculoDias()
        {
            int anoAquisitivoX = int.Parse(Valores.PeriodoAquisitivo);
            int anoAquisitivoY = int.Parse(Valores.PeriodoConcessivo);
            int anoConcessivo = anoAquisitivoX + anoAquisitivoY;
            DateTime Data = new DateTime(dataSelecao.Value.Year, dataSelecao.Value.Month, dataSelecao.Value.Day);
            //DateTime dias = Data.AddDays(Convert.ToInt32(txtDias.Text));
            DateTime diasA = Data.AddDays(anoAquisitivoX);
            DateTime diasC = Data.AddDays(anoConcessivo);
            dateX.Value = diasA;
            dateY.Value = diasC;
            //MessageBox.Show(dias.ToString());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoDias();
        }

        private void dataSelecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void dataSelecao_TextChanged(object sender, EventArgs e)
        {
            CalculoDias();

        }
    }
}
