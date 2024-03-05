namespace DPInterativo.Formularios
{
    partial class FormDecimoTerceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDecimoTerceiro));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.dataManual = new System.Windows.Forms.RadioButton();
            this.dataAutomatica = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIRRF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2Parcela = new System.Windows.Forms.TextBox();
            this.txt1Parcela = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.novoValor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblnovoINSS = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.btnCalcular = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDeducao = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeducao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(151, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 30;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº de meses trabalhados:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(151, 87);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 32;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // dataManual
            // 
            this.dataManual.AutoSize = true;
            this.dataManual.Location = new System.Drawing.Point(681, 177);
            this.dataManual.Name = "dataManual";
            this.dataManual.Size = new System.Drawing.Size(85, 17);
            this.dataManual.TabIndex = 10;
            this.dataManual.TabStop = true;
            this.dataManual.Text = "Data manual";
            this.dataManual.UseVisualStyleBackColor = true;
            this.dataManual.CheckedChanged += new System.EventHandler(this.dataManual_CheckedChanged);
            // 
            // dataAutomatica
            // 
            this.dataAutomatica.AutoSize = true;
            this.dataAutomatica.Location = new System.Drawing.Point(572, 177);
            this.dataAutomatica.Name = "dataAutomatica";
            this.dataAutomatica.Size = new System.Drawing.Size(103, 17);
            this.dataAutomatica.TabIndex = 11;
            this.dataAutomatica.TabStop = true;
            this.dataAutomatica.Text = "Data automática";
            this.dataAutomatica.UseVisualStyleBackColor = true;
            this.dataAutomatica.CheckedChanged += new System.EventHandler(this.dataAutomatica_CheckedChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(656, 70);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 12;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data de admissão:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIRRF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtINSS);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUnica);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt2Parcela);
            this.panel1.Controls.Add(this.txt1Parcela);
            this.panel1.Location = new System.Drawing.Point(275, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 152);
            this.panel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "IRRF:";
            // 
            // txtIRRF
            // 
            this.txtIRRF.Location = new System.Drawing.Point(56, 119);
            this.txtIRRF.Name = "txtIRRF";
            this.txtIRRF.Size = new System.Drawing.Size(100, 20);
            this.txtIRRF.TabIndex = 19;
            this.txtIRRF.TabStop = false;
            this.txtIRRF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "INSS:";
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(56, 93);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(100, 20);
            this.txtINSS.TabIndex = 14;
            this.txtINSS.TabStop = false;
            this.txtINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unica:";
            // 
            // txtUnica
            // 
            this.txtUnica.Location = new System.Drawing.Point(56, 67);
            this.txtUnica.Name = "txtUnica";
            this.txtUnica.Size = new System.Drawing.Size(100, 20);
            this.txtUnica.TabIndex = 12;
            this.txtUnica.TabStop = false;
            this.txtUnica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "2º parc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "1º parc:";
            // 
            // txt2Parcela
            // 
            this.txt2Parcela.Location = new System.Drawing.Point(56, 41);
            this.txt2Parcela.Name = "txt2Parcela";
            this.txt2Parcela.Size = new System.Drawing.Size(100, 20);
            this.txt2Parcela.TabIndex = 9;
            this.txt2Parcela.TabStop = false;
            this.txt2Parcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt1Parcela
            // 
            this.txt1Parcela.Location = new System.Drawing.Point(56, 15);
            this.txt1Parcela.Name = "txt1Parcela";
            this.txt1Parcela.Size = new System.Drawing.Size(100, 20);
            this.txt1Parcela.TabIndex = 8;
            this.txt1Parcela.TabStop = false;
            this.txt1Parcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(556, 104);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(95, 13);
            this.lblINSS.TabIndex = 15;
            this.lblINSS.Text = "Data de admissão:";
            // 
            // novoValor
            // 
            this.novoValor.AutoSize = true;
            this.novoValor.Location = new System.Drawing.Point(556, 136);
            this.novoValor.Name = "novoValor";
            this.novoValor.Size = new System.Drawing.Size(95, 13);
            this.novoValor.TabIndex = 16;
            this.novoValor.Text = "Data de admissão:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nº de dependentes:";
            // 
            // lblnovoINSS
            // 
            this.lblnovoINSS.AutoSize = true;
            this.lblnovoINSS.Location = new System.Drawing.Point(589, 9);
            this.lblnovoINSS.Name = "lblnovoINSS";
            this.lblnovoINSS.Size = new System.Drawing.Size(35, 13);
            this.lblnovoINSS.TabIndex = 21;
            this.lblnovoINSS.Text = "IRRF:";
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Location = new System.Drawing.Point(598, 35);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(51, 13);
            this.lblVar.TabIndex = 22;
            this.lblVar.Text = "IRRFVar:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Location = new System.Drawing.Point(166, 113);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Primary = true;
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDeducao
            // 
            this.txtDeducao.Location = new System.Drawing.Point(152, 61);
            this.txtDeducao.Name = "txtDeducao";
            this.txtDeducao.Size = new System.Drawing.Size(99, 20);
            this.txtDeducao.TabIndex = 33;
            this.txtDeducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormDecimoTerceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(467, 164);
            this.Controls.Add(this.txtDeducao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblnovoINSS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.novoValor);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dataAutomatica);
            this.Controls.Add(this.dataManual);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDecimoTerceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular 13º";
            this.Load += new System.EventHandler(this.FormDecimoTerceiro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeducao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.RadioButton dataManual;
        private System.Windows.Forms.RadioButton dataAutomatica;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2Parcela;
        private System.Windows.Forms.TextBox txt1Parcela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label novoValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIRRF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblnovoINSS;
        private System.Windows.Forms.Label lblVar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalcular;
        private System.Windows.Forms.NumericUpDown txtDeducao;
    }
}