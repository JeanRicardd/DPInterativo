
namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    partial class FormCalculoDeDias
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new Guna.UI.WinForms.GunaButton();
            this.dataSelecao = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dateX = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dateY = new Guna.UI.WinForms.GunaDateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(44, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Período Concessivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Período Aquisitivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Inicio:";
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
            this.btnCalcular.Location = new System.Drawing.Point(227, 218);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCalcular.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalcular.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalcular.OnHoverImage = null;
            this.btnCalcular.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalcular.Radius = 5;
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 73;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataSelecao
            // 
            this.dataSelecao.BackColor = System.Drawing.Color.Transparent;
            this.dataSelecao.BaseColor = System.Drawing.Color.White;
            this.dataSelecao.BorderColor = System.Drawing.Color.Silver;
            this.dataSelecao.CustomFormat = null;
            this.dataSelecao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataSelecao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataSelecao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataSelecao.ForeColor = System.Drawing.Color.Black;
            this.dataSelecao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataSelecao.Location = new System.Drawing.Point(193, 85);
            this.dataSelecao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataSelecao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataSelecao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataSelecao.Name = "dataSelecao";
            this.dataSelecao.OnHoverBaseColor = System.Drawing.Color.White;
            this.dataSelecao.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataSelecao.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataSelecao.OnPressedColor = System.Drawing.Color.Black;
            this.dataSelecao.Radius = 10;
            this.dataSelecao.Size = new System.Drawing.Size(161, 37);
            this.dataSelecao.TabIndex = 74;
            this.dataSelecao.Text = "01/01/2021";
            this.dataSelecao.UseTransfarantBackground = true;
            this.dataSelecao.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dataSelecao.TextChanged += new System.EventHandler(this.dataSelecao_TextChanged);
            this.dataSelecao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataSelecao_KeyPress);
            // 
            // dateX
            // 
            this.dateX.BackColor = System.Drawing.Color.Transparent;
            this.dateX.BaseColor = System.Drawing.Color.White;
            this.dateX.BorderColor = System.Drawing.Color.Silver;
            this.dateX.CustomFormat = null;
            this.dateX.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateX.Enabled = false;
            this.dateX.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateX.ForeColor = System.Drawing.Color.Black;
            this.dateX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateX.Location = new System.Drawing.Point(193, 129);
            this.dateX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateX.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateX.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateX.Name = "dateX";
            this.dateX.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateX.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateX.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateX.OnPressedColor = System.Drawing.Color.Black;
            this.dateX.Radius = 10;
            this.dateX.Size = new System.Drawing.Size(161, 37);
            this.dateX.TabIndex = 75;
            this.dateX.Text = "01/01/2021";
            this.dateX.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dateY
            // 
            this.dateY.BackColor = System.Drawing.Color.Transparent;
            this.dateY.BaseColor = System.Drawing.Color.White;
            this.dateY.BorderColor = System.Drawing.Color.Silver;
            this.dateY.CustomFormat = null;
            this.dateY.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateY.Enabled = false;
            this.dateY.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateY.ForeColor = System.Drawing.Color.Black;
            this.dateY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateY.Location = new System.Drawing.Point(193, 174);
            this.dateY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateY.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateY.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateY.Name = "dateY";
            this.dateY.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateY.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateY.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateY.OnPressedColor = System.Drawing.Color.Black;
            this.dateY.Radius = 10;
            this.dateY.Size = new System.Drawing.Size(161, 37);
            this.dateY.TabIndex = 76;
            this.dateY.Text = "01/01/2021";
            this.dateY.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // FormCalculoDeDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(571, 364);
            this.Controls.Add(this.dateY);
            this.Controls.Add(this.dateX);
            this.Controls.Add(this.dataSelecao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCalculoDeDias";
            this.Text = "FormCalculoDeDias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnCalcular;
        private Guna.UI.WinForms.GunaDateTimePicker dataSelecao;
        private Guna.UI.WinForms.GunaDateTimePicker dateX;
        private Guna.UI.WinForms.GunaDateTimePicker dateY;
    }
}