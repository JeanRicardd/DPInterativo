
namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    partial class FormContribuicaoPrevidenciaria
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new Guna.UI.WinForms.GunaButton();
            this.btnFormula = new Guna.UI.WinForms.GunaButton();
            this.btnLimpar = new Guna.UI.WinForms.GunaButton();
            this.txtValor = new Guna.UI.WinForms.GunaTextBox();
            this.txtResultado = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(90, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Valor a calcular:";
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
            this.btnCalcular.Location = new System.Drawing.Point(193, 151);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCalcular.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalcular.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalcular.OnHoverImage = null;
            this.btnCalcular.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalcular.Radius = 10;
            this.btnCalcular.Size = new System.Drawing.Size(100, 37);
            this.btnCalcular.TabIndex = 49;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFormula
            // 
            this.btnFormula.AnimationHoverSpeed = 0.07F;
            this.btnFormula.AnimationSpeed = 0.03F;
            this.btnFormula.BackColor = System.Drawing.Color.Transparent;
            this.btnFormula.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnFormula.BorderColor = System.Drawing.Color.White;
            this.btnFormula.BorderSize = 1;
            this.btnFormula.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFormula.Enabled = false;
            this.btnFormula.FocusedColor = System.Drawing.Color.Empty;
            this.btnFormula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFormula.ForeColor = System.Drawing.Color.White;
            this.btnFormula.Image = null;
            this.btnFormula.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFormula.Location = new System.Drawing.Point(176, 260);
            this.btnFormula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFormula.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFormula.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFormula.OnHoverImage = null;
            this.btnFormula.OnPressedColor = System.Drawing.Color.Black;
            this.btnFormula.Radius = 10;
            this.btnFormula.Size = new System.Drawing.Size(133, 34);
            this.btnFormula.TabIndex = 50;
            this.btnFormula.Text = "Mostrar formula";
            this.btnFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AnimationHoverSpeed = 0.07F;
            this.btnLimpar.AnimationSpeed = 0.03F;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLimpar.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.BorderSize = 1;
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpar.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Image = null;
            this.btnLimpar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpar.Location = new System.Drawing.Point(317, 63);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLimpar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpar.OnHoverForeColor = System.Drawing.Color.DarkRed;
            this.btnLimpar.OnHoverImage = null;
            this.btnLimpar.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpar.Radius = 10;
            this.btnLimpar.Size = new System.Drawing.Size(45, 37);
            this.btnLimpar.TabIndex = 51;
            this.btnLimpar.Text = "X";
            this.btnLimpar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.BaseColor = System.Drawing.Color.White;
            this.txtValor.BorderColor = System.Drawing.Color.Silver;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtValor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.Location = new System.Drawing.Point(176, 63);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.Radius = 10;
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(133, 37);
            this.txtValor.TabIndex = 52;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Transparent;
            this.txtResultado.BaseColor = System.Drawing.Color.White;
            this.txtResultado.BorderColor = System.Drawing.Color.Silver;
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultado.Enabled = false;
            this.txtResultado.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResultado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtResultado.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultado.Location = new System.Drawing.Point(176, 106);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.PasswordChar = '\0';
            this.txtResultado.Radius = 10;
            this.txtResultado.SelectedText = "";
            this.txtResultado.Size = new System.Drawing.Size(133, 37);
            this.txtResultado.TabIndex = 53;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormContribuicaoPrevidenciaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(473, 318);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFormula);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormContribuicaoPrevidenciaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContribuicaoPrevidenciaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnCalcular;
        private Guna.UI.WinForms.GunaButton btnFormula;
        private Guna.UI.WinForms.GunaButton btnLimpar;
        private Guna.UI.WinForms.GunaTextBox txtValor;
        private Guna.UI.WinForms.GunaTextBox txtResultado;
    }
}