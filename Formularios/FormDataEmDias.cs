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
    public partial class FormDataEmDias : Form
    {
        public FormDataEmDias()
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

            string diaInicio, mesInicio, anoInicio, diaFim, mesFim, anoFim;
            //Dias de Inicio
            diaInicio = txtdias.Text;
            mesInicio = txtMesInicio.Text;
            anoInicio = txtAnoInicio.Text;
            //Dias de Fim
            diaFim = txtDiaFim.Text;
            mesFim = txtMesFim.Text;
            anoFim = txtAnoFim.Text;


            DateTime dataInicial = new DateTime(dataX.Value.Year, dataX.Value.Month, dataX.Value.Day); 

            DateTime dataFinal = new DateTime(dataY.Value.Year, dataY.Value.Month, dataY.Value.Day);

            string dataxc = dataInicial.ToString();
            string dataxx = dataFinal.ToString();

            int Dias = (DateTime.Parse(dataxx).Subtract(DateTime.Parse(dataxc))).Days;
            int totalDias = Dias + int.Parse(Valores.Mais1Dias);
            MessageBox.Show("A distancia das datas em dias é "+ totalDias.ToString() + " dias");
            return totalDias;
        }

        public int DiasValor()
        {
            int anoAquisitivo;
            anoAquisitivo = Convert.ToInt32(txtdias.Text);
            DateTime Data = new DateTime(dataX.Value.Year, dataX.Value.Month, dataX.Value.Day);
            DateTime dias = Data.AddDays(anoAquisitivo-int.Parse(Valores.Mais1Dias));
            MessageBox.Show(dias.ToString("DIA:"+"dd/MM/yyyy"));
            return anoAquisitivo;
        }
        /*
        public int Distacia_de_Dias()
        {
            string diaInicio, mesInicio, anoInicio, diaFim, mesFim, anoFim;
            //Dias de Inicio
            diaInicio = txtDiaInicio.Text;
            mesInicio = txtMesInicio.Text;
            anoInicio = txtAnoInicio.Text;
            //Dias de Fim
            diaFim = txtDiaFim.Text;
            mesFim = txtMesFim.Text;
            anoFim = txtAnoFim.Text;


            string dataInicial = diaInicio + "/" + mesInicio + "/" + anoInicio;

            string dataFinal = diaFim + "/" + mesFim + "/" + anoFim;

            int totalDias = (DateTime.Parse(dataFinal).Subtract(DateTime.Parse(dataInicial))).Days;
            MessageBox.Show(totalDias.ToString());
            return totalDias;
        }*/

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Distacia_de_Dias();
        }

        private void FormDataEmDias_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            DiasValor();
        }

        private void checkDias_Click(object sender, EventArgs e)
        {
            if (checkDias.Checked == true)
            {
                dataY.Visible = false;
                btnCalcular.Visible = false;
                txtdias.Location = new Point(80, 54);
                btnCalcularDias.Location = new Point(139, 82);
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

        private void checkDias_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtdias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcularDias_Click(sender, e);
            }
        }
    }
}
