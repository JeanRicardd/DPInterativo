
namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    partial class FormDistanciaDias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new Guna.UI.WinForms.GunaButton();
            this.checkMais1 = new Guna.UI.WinForms.GunaCheckBox();
            this.checkDias = new Guna.UI.WinForms.GunaCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataX = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dataY = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnCalcularDias = new Guna.UI.WinForms.GunaButton();
            this.txtdias = new Guna.UI.WinForms.GunaTextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.painelResultado = new System.Windows.Forms.Panel();
            this.painelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.AnimationHoverSpeed = 0.07F;
            this.btnCalcular.AnimationSpeed = 0.03F;
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCalcular.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.BorderSize = 1;
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalcular.FocusedColor = System.Drawing.Color.Empty;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = null;
            this.btnCalcular.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCalcular.Location = new System.Drawing.Point(165, 161);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCalcular.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalcular.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalcular.OnHoverImage = null;
            this.btnCalcular.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalcular.Radius = 10;
            this.btnCalcular.Size = new System.Drawing.Size(100, 37);
            this.btnCalcular.TabIndex = 72;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // checkMais1
            // 
            this.checkMais1.BaseColor = System.Drawing.Color.White;
            this.checkMais1.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkMais1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkMais1.FillColor = System.Drawing.Color.White;
            this.checkMais1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkMais1.Location = new System.Drawing.Point(303, 123);
            this.checkMais1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMais1.Name = "checkMais1";
            this.checkMais1.Radius = 3;
            this.checkMais1.Size = new System.Drawing.Size(115, 20);
            this.checkMais1.TabIndex = 71;
            this.checkMais1.Text = "Contar c/inicio";
            this.checkMais1.Click += new System.EventHandler(this.checkMais1_Click);
            // 
            // checkDias
            // 
            this.checkDias.BaseColor = System.Drawing.Color.White;
            this.checkDias.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDias.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkDias.FillColor = System.Drawing.Color.White;
            this.checkDias.ForeColor = System.Drawing.SystemColors.Control;
            this.checkDias.Location = new System.Drawing.Point(303, 80);
            this.checkDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDias.Name = "checkDias";
            this.checkDias.Radius = 3;
            this.checkDias.Size = new System.Drawing.Size(102, 20);
            this.checkDias.TabIndex = 70;
            this.checkDias.Text = "Daqui * dias";
            this.checkDias.Click += new System.EventHandler(this.checkDias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Data Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Data Inicio:";
            // 
            // dataX
            // 
            this.dataX.BackColor = System.Drawing.Color.Transparent;
            this.dataX.BaseColor = System.Drawing.Color.White;
            this.dataX.BorderColor = System.Drawing.Color.Silver;
            this.dataX.CustomFormat = null;
            this.dataX.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataX.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataX.ForeColor = System.Drawing.Color.Black;
            this.dataX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataX.Location = new System.Drawing.Point(133, 73);
            this.dataX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataX.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataX.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataX.Name = "dataX";
            this.dataX.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataX.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataX.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataX.OnPressedColor = System.Drawing.Color.Black;
            this.dataX.Radius = 10;
            this.dataX.Size = new System.Drawing.Size(161, 37);
            this.dataX.TabIndex = 76;
            this.dataX.Text = "01/01/2021";
            this.dataX.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dataY
            // 
            this.dataY.BackColor = System.Drawing.Color.Transparent;
            this.dataY.BaseColor = System.Drawing.Color.White;
            this.dataY.BorderColor = System.Drawing.Color.Silver;
            this.dataY.CustomFormat = null;
            this.dataY.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataY.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataY.ForeColor = System.Drawing.Color.Black;
            this.dataY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataY.Location = new System.Drawing.Point(133, 117);
            this.dataY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataY.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataY.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataY.Name = "dataY";
            this.dataY.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataY.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataY.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataY.OnPressedColor = System.Drawing.Color.Black;
            this.dataY.Radius = 10;
            this.dataY.Size = new System.Drawing.Size(161, 37);
            this.dataY.TabIndex = 77;
            this.dataY.Text = "01/01/2021";
            this.dataY.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btnCalcularDias
            // 
            this.btnCalcularDias.AnimationHoverSpeed = 0.07F;
            this.btnCalcularDias.AnimationSpeed = 0.03F;
            this.btnCalcularDias.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCalcularDias.BorderColor = System.Drawing.Color.Black;
            this.btnCalcularDias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalcularDias.FocusedColor = System.Drawing.Color.Empty;
            this.btnCalcularDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcularDias.ForeColor = System.Drawing.Color.White;
            this.btnCalcularDias.Image = null;
            this.btnCalcularDias.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCalcularDias.Location = new System.Drawing.Point(307, 519);
            this.btnCalcularDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularDias.Name = "btnCalcularDias";
            this.btnCalcularDias.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCalcularDias.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalcularDias.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalcularDias.OnHoverImage = null;
            this.btnCalcularDias.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalcularDias.Size = new System.Drawing.Size(100, 28);
            this.btnCalcularDias.TabIndex = 78;
            this.btnCalcularDias.Text = "Calcular";
            this.btnCalcularDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalcularDias.Click += new System.EventHandler(this.btnCalcularDias_Click);
            // 
            // txtdias
            // 
            this.txtdias.BaseColor = System.Drawing.Color.White;
            this.txtdias.BorderColor = System.Drawing.Color.Silver;
            this.txtdias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdias.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdias.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdias.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdias.Location = new System.Drawing.Point(137, 516);
            this.txtdias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdias.Name = "txtdias";
            this.txtdias.PasswordChar = '\0';
            this.txtdias.SelectedText = "";
            this.txtdias.Size = new System.Drawing.Size(161, 37);
            this.txtdias.TabIndex = 79;
            this.txtdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdias_KeyPress);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(13, 15);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(39, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "%d%";
            // 
            // painelResultado
            // 
            this.painelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.painelResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelResultado.Controls.Add(this.lblResultado);
            this.painelResultado.Location = new System.Drawing.Point(73, 215);
            this.painelResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.painelResultado.Name = "painelResultado";
            this.painelResultado.Size = new System.Drawing.Size(325, 49);
            this.painelResultado.TabIndex = 81;
            this.painelResultado.Visible = false;
            // 
            // FormDistanciaDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(444, 378);
            this.Controls.Add(this.painelResultado);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.btnCalcularDias);
            this.Controls.Add(this.dataY);
            this.Controls.Add(this.dataX);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.checkMais1);
            this.Controls.Add(this.checkDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDistanciaDias";
            this.Text = "FormDistanciaDias";
            this.painelResultado.ResumeLayout(false);
            this.painelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnCalcular;
        private Guna.UI.WinForms.GunaCheckBox checkMais1;
        private Guna.UI.WinForms.GunaCheckBox checkDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dataX;
        private Guna.UI.WinForms.GunaDateTimePicker dataY;
        private Guna.UI.WinForms.GunaButton btnCalcularDias;
        private Guna.UI.WinForms.GunaTextBox txtdias;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel painelResultado;
    }
}