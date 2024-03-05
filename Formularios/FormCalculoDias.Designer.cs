
namespace DPInterativo.Formularios
{
    partial class FormCalculoDias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoDias));
            this.dataSelecao = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dateX = new System.Windows.Forms.DateTimePicker();
            this.dateY = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataSelecao
            // 
            this.dataSelecao.Location = new System.Drawing.Point(120, 28);
            this.dataSelecao.Name = "dataSelecao";
            this.dataSelecao.Size = new System.Drawing.Size(238, 20);
            this.dataSelecao.TabIndex = 1;
            this.dataSelecao.Value = new System.DateTime(2021, 1, 1, 12, 0, 0, 0);
            this.dataSelecao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataSelecao_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(162, 112);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateX
            // 
            this.dateX.Enabled = false;
            this.dateX.Location = new System.Drawing.Point(120, 54);
            this.dateX.Name = "dateX";
            this.dateX.Size = new System.Drawing.Size(238, 20);
            this.dateX.TabIndex = 3;
            this.dateX.Value = new System.DateTime(2021, 1, 1, 12, 0, 0, 0);
            // 
            // dateY
            // 
            this.dateY.Enabled = false;
            this.dateY.Location = new System.Drawing.Point(120, 80);
            this.dateY.Name = "dateY";
            this.dateY.Size = new System.Drawing.Size(238, 20);
            this.dateY.TabIndex = 4;
            this.dateY.Value = new System.DateTime(2021, 1, 1, 12, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Período Aquisitivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Período Concessivo:";
            // 
            // FormCalculoDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DPInterativo.Properties.Resources.launch;
            this.ClientSize = new System.Drawing.Size(434, 147);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateY);
            this.Controls.Add(this.dateX);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataSelecao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculoDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteractCalc - Calculo de Aquisição";
            this.Load += new System.EventHandler(this.FormCalculoDias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dataSelecao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker dateX;
        private System.Windows.Forms.DateTimePicker dateY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}