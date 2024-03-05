
namespace DPInterativo.NovoFormPrincipal
{
    partial class FormDeduzindoINSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeduzindoINSS));
            this.btnConfirmarINSS = new System.Windows.Forms.Button();
            this.txtDeduzirINSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmarINSS
            // 
            this.btnConfirmarINSS.Location = new System.Drawing.Point(219, 24);
            this.btnConfirmarINSS.Name = "btnConfirmarINSS";
            this.btnConfirmarINSS.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarINSS.TabIndex = 0;
            this.btnConfirmarINSS.Text = "Confirmar";
            this.btnConfirmarINSS.UseVisualStyleBackColor = true;
            this.btnConfirmarINSS.Click += new System.EventHandler(this.btnConfirmarINSS_Click);
            // 
            // txtDeduzirINSS
            // 
            this.txtDeduzirINSS.Location = new System.Drawing.Point(100, 26);
            this.txtDeduzirINSS.MaxLength = 8;
            this.txtDeduzirINSS.Name = "txtDeduzirINSS";
            this.txtDeduzirINSS.Size = new System.Drawing.Size(113, 20);
            this.txtDeduzirINSS.TabIndex = 1;
            this.txtDeduzirINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeduzirINSS.TextChanged += new System.EventHandler(this.txtDeduzirINSS_TextChanged);
            this.txtDeduzirINSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeduzirINSS_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor a deduzir:";
            // 
            // FormDeduzindoINSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(327, 68);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeduzirINSS);
            this.Controls.Add(this.btnConfirmarINSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeduzindoINSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteractCalc - Deduzindo INSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarINSS;
        private System.Windows.Forms.TextBox txtDeduzirINSS;
        private System.Windows.Forms.Label label1;
    }
}