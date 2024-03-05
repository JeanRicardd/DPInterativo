using Microsoft.Win32;
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
    public partial class FormInsiraNome : Form
    {
        RegistryKey key;
        FormPrincipalRemaster form = new FormPrincipalRemaster();

        public FormInsiraNome()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            key = Registry.CurrentUser.CreateSubKey(@"Software\InteratCalc\Config");
            key.CreateSubKey("Nome");
            key.SetValue("Nome", nome, RegistryValueKind.String);
            key.Close();
            MessageBox.Show("Nome registrado, Seja Bem-vindo "+ nome);
            form.Show();
            Hide();
        }
    }
}
