namespace DPInterativo.Formularios
{
    partial class FormImposto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImposto));
            this.label1 = new System.Windows.Forms.Label();
            this.lblContribuicao = new System.Windows.Forms.Label();
            this.lblPrevidencia = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblFGTS = new System.Windows.Forms.Label();
            this.lblIndenizacao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtContribuicao = new System.Windows.Forms.TextBox();
            this.txtPrevidencia = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtFGTS = new System.Windows.Forms.TextBox();
            this.txtIndenizacao = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt13parc1 = new System.Windows.Forms.TextBox();
            this.lbl13parc1 = new System.Windows.Forms.Label();
            this.check13parc1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMeses = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor a calcular;";
            // 
            // lblContribuicao
            // 
            this.lblContribuicao.AutoSize = true;
            this.lblContribuicao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContribuicao.Location = new System.Drawing.Point(18, 128);
            this.lblContribuicao.Name = "lblContribuicao";
            this.lblContribuicao.Size = new System.Drawing.Size(178, 13);
            this.lblContribuicao.TabIndex = 8;
            this.lblContribuicao.Text = "8,0% Contribuição P. Previdenciária:";
            // 
            // lblPrevidencia
            // 
            this.lblPrevidencia.AutoSize = true;
            this.lblPrevidencia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrevidencia.Location = new System.Drawing.Point(31, 156);
            this.lblPrevidencia.Name = "lblPrevidencia";
            this.lblPrevidencia.Size = new System.Drawing.Size(165, 13);
            this.lblPrevidencia.TabIndex = 9;
            this.lblPrevidencia.Text = "7,5% Contribuição Previdenciária:";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeguro.Location = new System.Drawing.Point(121, 181);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(75, 13);
            this.lblSeguro.TabIndex = 10;
            this.lblSeguro.Text = "0,8% GILRAT:";
            // 
            // lblFGTS
            // 
            this.lblFGTS.AutoSize = true;
            this.lblFGTS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFGTS.Location = new System.Drawing.Point(132, 207);
            this.lblFGTS.Name = "lblFGTS";
            this.lblFGTS.Size = new System.Drawing.Size(64, 13);
            this.lblFGTS.TabIndex = 11;
            this.lblFGTS.Text = "8,0% FGTS:";
            // 
            // lblIndenizacao
            // 
            this.lblIndenizacao.AutoSize = true;
            this.lblIndenizacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIndenizacao.Location = new System.Drawing.Point(103, 233);
            this.lblIndenizacao.Name = "lblIndenizacao";
            this.lblIndenizacao.Size = new System.Drawing.Size(93, 13);
            this.lblIndenizacao.TabIndex = 12;
            this.lblIndenizacao.Text = "3,2% Multa FGTS:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 10);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFinal.Location = new System.Drawing.Point(140, 259);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(56, 13);
            this.lblFinal.TabIndex = 20;
            this.lblFinal.Text = "Valor final:";
            // 
            // txtContribuicao
            // 
            this.txtContribuicao.Enabled = false;
            this.txtContribuicao.Location = new System.Drawing.Point(199, 127);
            this.txtContribuicao.Name = "txtContribuicao";
            this.txtContribuicao.Size = new System.Drawing.Size(100, 20);
            this.txtContribuicao.TabIndex = 22;
            this.txtContribuicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrevidencia
            // 
            this.txtPrevidencia.Enabled = false;
            this.txtPrevidencia.Location = new System.Drawing.Point(199, 153);
            this.txtPrevidencia.Name = "txtPrevidencia";
            this.txtPrevidencia.Size = new System.Drawing.Size(100, 20);
            this.txtPrevidencia.TabIndex = 23;
            this.txtPrevidencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Enabled = false;
            this.txtSeguro.Location = new System.Drawing.Point(199, 178);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(100, 20);
            this.txtSeguro.TabIndex = 24;
            this.txtSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFGTS
            // 
            this.txtFGTS.Enabled = false;
            this.txtFGTS.Location = new System.Drawing.Point(199, 204);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.Size = new System.Drawing.Size(100, 20);
            this.txtFGTS.TabIndex = 25;
            this.txtFGTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIndenizacao
            // 
            this.txtIndenizacao.Enabled = false;
            this.txtIndenizacao.Location = new System.Drawing.Point(199, 230);
            this.txtIndenizacao.Name = "txtIndenizacao";
            this.txtIndenizacao.Size = new System.Drawing.Size(100, 20);
            this.txtIndenizacao.TabIndex = 26;
            this.txtIndenizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Location = new System.Drawing.Point(199, 256);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 27;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Location = new System.Drawing.Point(211, 10);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Primary = true;
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt13parc1
            // 
            this.txt13parc1.Enabled = false;
            this.txt13parc1.Location = new System.Drawing.Point(199, 101);
            this.txt13parc1.Name = "txt13parc1";
            this.txt13parc1.Size = new System.Drawing.Size(100, 20);
            this.txt13parc1.TabIndex = 30;
            this.txt13parc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl13parc1
            // 
            this.lbl13parc1.AutoSize = true;
            this.lbl13parc1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl13parc1.Location = new System.Drawing.Point(114, 104);
            this.lbl13parc1.Name = "lbl13parc1";
            this.lbl13parc1.Size = new System.Drawing.Size(82, 13);
            this.lbl13parc1.TabIndex = 29;
            this.lbl13parc1.Text = "13º Sal. 1ºParc:";
            // 
            // check13parc1
            // 
            this.check13parc1.AutoSize = true;
            this.check13parc1.ForeColor = System.Drawing.SystemColors.Control;
            this.check13parc1.Location = new System.Drawing.Point(12, 86);
            this.check13parc1.Name = "check13parc1";
            this.check13parc1.Size = new System.Drawing.Size(98, 17);
            this.check13parc1.TabIndex = 31;
            this.check13parc1.Text = "13º Sal. 1ºParc";
            this.check13parc1.UseVisualStyleBackColor = true;
            this.check13parc1.CheckedChanged += new System.EventHandler(this.check13parc1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMeses);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 68);
            this.panel1.TabIndex = 32;
            // 
            // txtMeses
            // 
            this.txtMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMeses.FormattingEnabled = true;
            this.txtMeses.Location = new System.Drawing.Point(104, 36);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 21);
            this.txtMeses.TabIndex = 34;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMes.Location = new System.Drawing.Point(63, 39);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(41, 13);
            this.lblMes.TabIndex = 32;
            this.lblMes.Text = "Meses:";
            // 
            // FormImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(388, 297);
            this.Controls.Add(this.txt13parc1);
            this.Controls.Add(this.lbl13parc1);
            this.Controls.Add(this.check13parc1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtIndenizacao);
            this.Controls.Add(this.txtFGTS);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtPrevidencia);
            this.Controls.Add(this.txtContribuicao);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblIndenizacao);
            this.Controls.Add(this.lblFGTS);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.lblPrevidencia);
            this.Controls.Add(this.lblContribuicao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormImposto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de DAE";
            this.Load += new System.EventHandler(this.FormImposto_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormImposto_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContribuicao;
        private System.Windows.Forms.Label lblPrevidencia;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblFGTS;
        private System.Windows.Forms.Label lblIndenizacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtContribuicao;
        private System.Windows.Forms.TextBox txtPrevidencia;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtFGTS;
        private System.Windows.Forms.TextBox txtIndenizacao;
        private System.Windows.Forms.TextBox txtFinal;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalcular;
        private System.Windows.Forms.TextBox txt13parc1;
        private System.Windows.Forms.Label lbl13parc1;
        private System.Windows.Forms.CheckBox check13parc1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox txtMeses;
    }
}