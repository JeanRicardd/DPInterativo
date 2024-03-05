
namespace DPInterativo.Formularios
{
    partial class FormCNPJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCNPJ));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDtdAbertura = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtividadePrincipal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPesquisar = new Guna.UI.WinForms.GunaButton();
            this.txtNomeEmpresa = new Guna.UI.WinForms.GunaTextBox();
            this.txtFantasia = new Guna.UI.WinForms.GunaTextBox();
            this.txtNaturezaJuridica = new Guna.UI.WinForms.GunaTextBox();
            this.txtAtualizacao = new Guna.UI.WinForms.GunaTextBox();
            this.txtSituacao = new Guna.UI.WinForms.GunaTextBox();
            this.txtCapitalSocial = new Guna.UI.WinForms.GunaTextBox();
            this.txtPorte = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(345, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de abertura:";
            // 
            // txtDtdAbertura
            // 
            this.txtDtdAbertura.Enabled = false;
            this.txtDtdAbertura.Location = new System.Drawing.Point(441, 13);
            this.txtDtdAbertura.Mask = "00/00/0000";
            this.txtDtdAbertura.Name = "txtDtdAbertura";
            this.txtDtdAbertura.Size = new System.Drawing.Size(87, 20);
            this.txtDtdAbertura.TabIndex = 7;
            this.txtDtdAbertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDtdAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(405, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Porte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Natureza Juridica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome Fantasia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(405, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Capital Social:";
            // 
            // txtAtividadePrincipal
            // 
            this.txtAtividadePrincipal.Enabled = false;
            this.txtAtividadePrincipal.Location = new System.Drawing.Point(114, 341);
            this.txtAtividadePrincipal.Name = "txtAtividadePrincipal";
            this.txtAtividadePrincipal.Size = new System.Drawing.Size(366, 20);
            this.txtAtividadePrincipal.TabIndex = 17;
            this.txtAtividadePrincipal.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "CÓDIGO E DESCRIÇÃO DA ATIVIDADE ECONÔMICA PRINCIPAL:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(21, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Buscar por CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(118, 12);
            this.txtCNPJ.Mask = "99,999,999/9999-99";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(132, 20);
            this.txtCNPJ.TabIndex = 19;
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(21, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Situação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(405, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Data Situação:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AnimationHoverSpeed = 0.07F;
            this.btnPesquisar.AnimationSpeed = 0.03F;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPesquisar.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.BorderSize = 1;
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPesquisar.FocusedColor = System.Drawing.Color.Empty;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = null;
            this.btnPesquisar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPesquisar.Location = new System.Drawing.Point(256, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPesquisar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPesquisar.OnHoverImage = null;
            this.btnPesquisar.OnPressedColor = System.Drawing.Color.Black;
            this.btnPesquisar.Radius = 10;
            this.btnPesquisar.Size = new System.Drawing.Size(74, 25);
            this.btnPesquisar.TabIndex = 55;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeEmpresa.BaseColor = System.Drawing.Color.White;
            this.txtNomeEmpresa.BorderColor = System.Drawing.Color.Silver;
            this.txtNomeEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeEmpresa.Enabled = false;
            this.txtNomeEmpresa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomeEmpresa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNomeEmpresa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomeEmpresa.Location = new System.Drawing.Point(21, 62);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.PasswordChar = '\0';
            this.txtNomeEmpresa.Radius = 10;
            this.txtNomeEmpresa.SelectedText = "";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(366, 26);
            this.txtNomeEmpresa.TabIndex = 70;
            this.txtNomeEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFantasia
            // 
            this.txtFantasia.BackColor = System.Drawing.Color.Transparent;
            this.txtFantasia.BaseColor = System.Drawing.Color.White;
            this.txtFantasia.BorderColor = System.Drawing.Color.Silver;
            this.txtFantasia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFantasia.Enabled = false;
            this.txtFantasia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFantasia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFantasia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFantasia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFantasia.Location = new System.Drawing.Point(21, 105);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.PasswordChar = '\0';
            this.txtFantasia.Radius = 10;
            this.txtFantasia.SelectedText = "";
            this.txtFantasia.Size = new System.Drawing.Size(366, 26);
            this.txtFantasia.TabIndex = 71;
            this.txtFantasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNaturezaJuridica
            // 
            this.txtNaturezaJuridica.BackColor = System.Drawing.Color.Transparent;
            this.txtNaturezaJuridica.BaseColor = System.Drawing.Color.White;
            this.txtNaturezaJuridica.BorderColor = System.Drawing.Color.Silver;
            this.txtNaturezaJuridica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNaturezaJuridica.Enabled = false;
            this.txtNaturezaJuridica.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNaturezaJuridica.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNaturezaJuridica.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNaturezaJuridica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNaturezaJuridica.Location = new System.Drawing.Point(21, 147);
            this.txtNaturezaJuridica.Name = "txtNaturezaJuridica";
            this.txtNaturezaJuridica.PasswordChar = '\0';
            this.txtNaturezaJuridica.Radius = 10;
            this.txtNaturezaJuridica.SelectedText = "";
            this.txtNaturezaJuridica.Size = new System.Drawing.Size(366, 26);
            this.txtNaturezaJuridica.TabIndex = 72;
            this.txtNaturezaJuridica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtualizacao
            // 
            this.txtAtualizacao.BackColor = System.Drawing.Color.Transparent;
            this.txtAtualizacao.BaseColor = System.Drawing.Color.White;
            this.txtAtualizacao.BorderColor = System.Drawing.Color.Silver;
            this.txtAtualizacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAtualizacao.Enabled = false;
            this.txtAtualizacao.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAtualizacao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAtualizacao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAtualizacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAtualizacao.Location = new System.Drawing.Point(408, 149);
            this.txtAtualizacao.Name = "txtAtualizacao";
            this.txtAtualizacao.PasswordChar = '\0';
            this.txtAtualizacao.Radius = 10;
            this.txtAtualizacao.SelectedText = "";
            this.txtAtualizacao.Size = new System.Drawing.Size(120, 26);
            this.txtAtualizacao.TabIndex = 73;
            this.txtAtualizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.Color.Transparent;
            this.txtSituacao.BaseColor = System.Drawing.Color.White;
            this.txtSituacao.BorderColor = System.Drawing.Color.Silver;
            this.txtSituacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSituacao.Enabled = false;
            this.txtSituacao.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSituacao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSituacao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSituacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSituacao.Location = new System.Drawing.Point(24, 188);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.PasswordChar = '\0';
            this.txtSituacao.Radius = 10;
            this.txtSituacao.SelectedText = "";
            this.txtSituacao.Size = new System.Drawing.Size(120, 26);
            this.txtSituacao.TabIndex = 74;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCapitalSocial
            // 
            this.txtCapitalSocial.BackColor = System.Drawing.Color.Transparent;
            this.txtCapitalSocial.BaseColor = System.Drawing.Color.White;
            this.txtCapitalSocial.BorderColor = System.Drawing.Color.Silver;
            this.txtCapitalSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapitalSocial.Enabled = false;
            this.txtCapitalSocial.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCapitalSocial.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCapitalSocial.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCapitalSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCapitalSocial.Location = new System.Drawing.Point(408, 104);
            this.txtCapitalSocial.Name = "txtCapitalSocial";
            this.txtCapitalSocial.PasswordChar = '\0';
            this.txtCapitalSocial.Radius = 10;
            this.txtCapitalSocial.SelectedText = "";
            this.txtCapitalSocial.Size = new System.Drawing.Size(120, 26);
            this.txtCapitalSocial.TabIndex = 75;
            this.txtCapitalSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPorte
            // 
            this.txtPorte.BackColor = System.Drawing.Color.Transparent;
            this.txtPorte.BaseColor = System.Drawing.Color.White;
            this.txtPorte.BorderColor = System.Drawing.Color.Silver;
            this.txtPorte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPorte.Enabled = false;
            this.txtPorte.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPorte.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPorte.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPorte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPorte.Location = new System.Drawing.Point(408, 62);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.PasswordChar = '\0';
            this.txtPorte.Radius = 10;
            this.txtPorte.SelectedText = "";
            this.txtPorte.Size = new System.Drawing.Size(120, 26);
            this.txtPorte.TabIndex = 76;
            this.txtPorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormCNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(556, 226);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(this.txtCapitalSocial);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtAtualizacao);
            this.Controls.Add(this.txtNaturezaJuridica);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAtividadePrincipal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDtdAbertura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de CNPJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDtdAbertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAtividadePrincipal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton btnPesquisar;
        private Guna.UI.WinForms.GunaTextBox txtNomeEmpresa;
        private Guna.UI.WinForms.GunaTextBox txtFantasia;
        private Guna.UI.WinForms.GunaTextBox txtNaturezaJuridica;
        private Guna.UI.WinForms.GunaTextBox txtAtualizacao;
        private Guna.UI.WinForms.GunaTextBox txtSituacao;
        private Guna.UI.WinForms.GunaTextBox txtCapitalSocial;
        private Guna.UI.WinForms.GunaTextBox txtPorte;
    }
}