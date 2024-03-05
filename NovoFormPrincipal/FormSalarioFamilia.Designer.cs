
namespace DPInterativo.NovoFormPrincipal
{
    partial class FormSalarioFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalarioFamilia));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new Guna.UI.WinForms.GunaButton();
            this.txtDeducao = new Guna.UI.WinForms.GunaNumeric();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade de Dependentes:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AnimationHoverSpeed = 0.07F;
            this.btnAdicionar.AnimationSpeed = 0.03F;
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdicionar.BorderColor = System.Drawing.Color.White;
            this.btnAdicionar.BorderSize = 1;
            this.btnAdicionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdicionar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = null;
            this.btnAdicionar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdicionar.Location = new System.Drawing.Point(255, 31);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdicionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdicionar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdicionar.OnHoverImage = null;
            this.btnAdicionar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdicionar.Radius = 10;
            this.btnAdicionar.Size = new System.Drawing.Size(73, 20);
            this.btnAdicionar.TabIndex = 55;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtDeducao
            // 
            this.txtDeducao.BackColor = System.Drawing.Color.Transparent;
            this.txtDeducao.BaseColor = System.Drawing.Color.White;
            this.txtDeducao.BorderColor = System.Drawing.Color.Silver;
            this.txtDeducao.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDeducao.ButtonForeColor = System.Drawing.Color.White;
            this.txtDeducao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeducao.ForeColor = System.Drawing.Color.Black;
            this.txtDeducao.Location = new System.Drawing.Point(198, 24);
            this.txtDeducao.Maximum = ((long)(99));
            this.txtDeducao.Minimum = ((long)(0));
            this.txtDeducao.Name = "txtDeducao";
            this.txtDeducao.Radius = 10;
            this.txtDeducao.Size = new System.Drawing.Size(50, 30);
            this.txtDeducao.TabIndex = 72;
            this.txtDeducao.Value = ((long)(0));
            // 
            // FormSalarioFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(368, 73);
            this.Controls.Add(this.txtDeducao);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSalarioFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteractCalc - Adicionar dependente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAdicionar;
        private Guna.UI.WinForms.GunaNumeric txtDeducao;
    }
}