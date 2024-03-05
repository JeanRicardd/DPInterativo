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
    public partial class FormDistanciaDias : Form
    {
        public FormDistanciaDias()
        {
            InitializeComponent();
            checkDias.Checked = false;
            Valores.Mais1Dias = "0";
        }

        private void checkMais1_Click(object sender, EventArgs e)
        {
            if (checkMais1.Checked == true)
            {
                Valores.Mais1Dias = "1";
            }
            else if (checkMais1.Checked == false)
            {
                Valores.Mais1Dias = "0";
            }
        }

        public int Distacia_de_Dias()
        {
            painelResultado.Visible = true;

            DateTime dataInicial = new DateTime(dataX.Value.Year, dataX.Value.Month, dataX.Value.Day);

            DateTime dataFinal = new DateTime(dataY.Value.Year, dataY.Value.Month, dataY.Value.Day);

            string dataxc = dataInicial.ToString();
            string dataxx = dataFinal.ToString();

            int Dias = (DateTime.Parse(dataxx).Subtract(DateTime.Parse(dataxc))).Days;
            int totalDias = Dias + int.Parse(Valores.Mais1Dias);
            //MessageBox.Show("A distancia das datas em dias é " + totalDias.ToString() + " dias");
            lblResultado.Text = "A distancia entre as datas em dias é " + totalDias.ToString() + " dias";
            return totalDias;
        }

        public int DiasValor()
        {
            int anoAquisitivo;
            anoAquisitivo = Convert.ToInt32(txtdias.Text);
            DateTime Data = new DateTime(dataX.Value.Year, dataX.Value.Month, dataX.Value.Day);
            DateTime dias = Data.AddDays(anoAquisitivo - int.Parse(Valores.Mais1Dias));
            MessageBox.Show(dias.ToString("Dia: " + "dd/MM/yyyy"));
            return anoAquisitivo;
        }

        private void checkDias_Click(object sender, EventArgs e)
        {
            if (checkDias.Checked == true)
            {
                dataY.Visible = false;
                btnCalcular.Visible = false;
                txtdias.Location = new Point(103, 118);
                btnCalcularDias.Location = new Point(127, 154);
                txtdias.Visible = true;
                btnCalcularDias.Visible = true;
                dataX.Value = DateTime.Today;
            }
            else if (checkDias.Checked == false)
            {
                dataY.Visible = true;
                btnCalcular.Visible = true;
                txtdias.Visible = false;
                btnCalcularDias.Visible = false;
            }
        }

        private void txtdias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcularDias_Click(sender, e);
            }
        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            DiasValor();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Distacia_de_Dias();
        }
    }
}
