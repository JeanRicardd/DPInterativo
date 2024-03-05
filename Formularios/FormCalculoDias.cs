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

namespace DPInterativo.Formularios
{
    public partial class FormCalculoDias : Form
    {
        private MyIni MyIni;
        public Valores Valores;
        public FormCalculoDias()
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

        private void button1_Click(object sender, EventArgs e)
        {
            CalculoDias();
        }

        private void FormCalculoDias_Load(object sender, EventArgs e)
        {

        }

        private void dataSelecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
