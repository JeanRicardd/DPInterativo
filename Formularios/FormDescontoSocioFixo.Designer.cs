namespace DPInterativo.Formularios
{
    partial class FormDescontoSocioFixo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescontoSocioFixo));
            this.txtvalor11 = new System.Windows.Forms.TextBox();
            this.txtvalor20 = new System.Windows.Forms.TextBox();
            this.txtResultado20 = new System.Windows.Forms.TextBox();
            this.txtResultado11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcular = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalor11
            // 
            this.txtvalor11.Location = new System.Drawing.Point(116, 38);
            this.txtvalor11.Name = "txtvalor11";
            this.txtvalor11.Size = new System.Drawing.Size(115, 20);
            this.txtvalor11.TabIndex = 0;
            this.txtvalor11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtvalor11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor11_KeyPress);
            // 
            // txtvalor20
            // 
            this.txtvalor20.Location = new System.Drawing.Point(116, 64);
            this.txtvalor20.Name = "txtvalor20";
            this.txtvalor20.Size = new System.Drawing.Size(115, 20);
            this.txtvalor20.TabIndex = 1;
            this.txtvalor20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtvalor20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor20_KeyPress);
            // 
            // txtResultado20
            // 
            this.txtResultado20.Location = new System.Drawing.Point(111, 41);
            this.txtResultado20.Name = "txtResultado20";
            this.txtResultado20.Size = new System.Drawing.Size(115, 20);
            this.txtResultado20.TabIndex = 3;
            this.txtResultado20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado11
            // 
            this.txtResultado11.Location = new System.Drawing.Point(111, 15);
            this.txtResultado11.Name = "txtResultado11";
            this.txtResultado11.Size = new System.Drawing.Size(115, 20);
            this.txtResultado11.TabIndex = 2;
            this.txtResultado11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor para 11%:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor para 20%:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado de 11%:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado de 20%:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.txtResultado11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtResultado20);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 72);
            this.panel1.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Location = new System.Drawing.Point(107, 168);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Primary = true;
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormDescontoSocioFixo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(278, 208);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalor20);
            this.Controls.Add(this.txtvalor11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDescontoSocioFixo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desconto Fixo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor11;
        private System.Windows.Forms.TextBox txtvalor20;
        private System.Windows.Forms.TextBox txtResultado20;
        private System.Windows.Forms.TextBox txtResultado11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalcular;
    }
}