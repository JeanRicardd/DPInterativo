
namespace DPInterativo.NovoFormPrincipal.FormulariosRemaster
{
    partial class FormGPSIrregularidade
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnExecutar = new Guna.UI.WinForms.GunaButton();
            this.timerCarregarInformacao = new System.Windows.Forms.Timer(this.components);
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastrar Acesso para Verificação de Regularidade";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(85, 162);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCNPJ.Mask = "99,999,999/9999-99";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(175, 22);
            this.txtCNPJ.TabIndex = 4;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCNPJ_MaskInputRejected);
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Yellow;
            this.lblEmpresa.Location = new System.Drawing.Point(20, 6);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(0, 17);
            this.lblEmpresa.TabIndex = 6;
            // 
            // btnExecutar
            // 
            this.btnExecutar.AnimationHoverSpeed = 0.07F;
            this.btnExecutar.AnimationSpeed = 0.03F;
            this.btnExecutar.BackColor = System.Drawing.Color.Transparent;
            this.btnExecutar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnExecutar.BorderColor = System.Drawing.Color.White;
            this.btnExecutar.BorderSize = 1;
            this.btnExecutar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExecutar.FocusedColor = System.Drawing.Color.Empty;
            this.btnExecutar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExecutar.ForeColor = System.Drawing.Color.White;
            this.btnExecutar.Image = null;
            this.btnExecutar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExecutar.Location = new System.Drawing.Point(268, 158);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExecutar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExecutar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExecutar.OnHoverImage = null;
            this.btnExecutar.OnPressedColor = System.Drawing.Color.Black;
            this.btnExecutar.Radius = 10;
            this.btnExecutar.Size = new System.Drawing.Size(100, 30);
            this.btnExecutar.TabIndex = 65;
            this.btnExecutar.Text = "Cadastrar";
            this.btnExecutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // timerCarregarInformacao
            // 
            this.timerCarregarInformacao.Interval = 3000;
            this.timerCarregarInformacao.Tick += new System.EventHandler(this.timerCarregarInformacao_Tick);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.lblEmpresa);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(16, 121);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(428, 30);
            this.gunaShadowPanel1.TabIndex = 66;
            // 
            // FormGPSIrregularidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(573, 223);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNPJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGPSIrregularidade";
            this.Text = "FormGPSIrregularidade";
            this.TextChanged += new System.EventHandler(this.FormGPSIrregularidade_TextChanged);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lblEmpresa;
        private Guna.UI.WinForms.GunaButton btnExecutar;
        private System.Windows.Forms.Timer timerCarregarInformacao;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}