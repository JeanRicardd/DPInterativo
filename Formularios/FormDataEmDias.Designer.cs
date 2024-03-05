
namespace DPInterativo.Formularios
{
    partial class FormDataEmDias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataEmDias));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDiaFim = new System.Windows.Forms.TextBox();
            this.txtMesFim = new System.Windows.Forms.TextBox();
            this.txtAnoFim = new System.Windows.Forms.TextBox();
            this.txtAnoInicio = new System.Windows.Forms.TextBox();
            this.txtMesInicio = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataX = new System.Windows.Forms.DateTimePicker();
            this.dataY = new System.Windows.Forms.DateTimePicker();
            this.checkDias = new System.Windows.Forms.CheckBox();
            this.btnCalcularDias = new System.Windows.Forms.Button();
            this.checkMais1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(139, 82);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDiaFim
            // 
            this.txtDiaFim.Location = new System.Drawing.Point(110, 319);
            this.txtDiaFim.Name = "txtDiaFim";
            this.txtDiaFim.Size = new System.Drawing.Size(44, 20);
            this.txtDiaFim.TabIndex = 2;
            this.txtDiaFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMesFim
            // 
            this.txtMesFim.Location = new System.Drawing.Point(160, 319);
            this.txtMesFim.Name = "txtMesFim";
            this.txtMesFim.Size = new System.Drawing.Size(44, 20);
            this.txtMesFim.TabIndex = 3;
            this.txtMesFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnoFim
            // 
            this.txtAnoFim.Location = new System.Drawing.Point(210, 319);
            this.txtAnoFim.Name = "txtAnoFim";
            this.txtAnoFim.Size = new System.Drawing.Size(44, 20);
            this.txtAnoFim.TabIndex = 4;
            this.txtAnoFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnoInicio
            // 
            this.txtAnoInicio.Location = new System.Drawing.Point(210, 293);
            this.txtAnoInicio.Name = "txtAnoInicio";
            this.txtAnoInicio.Size = new System.Drawing.Size(44, 20);
            this.txtAnoInicio.TabIndex = 7;
            this.txtAnoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(160, 293);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(44, 20);
            this.txtMesInicio.TabIndex = 6;
            this.txtMesInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(139, 163);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(93, 20);
            this.txtdias.TabIndex = 5;
            this.txtdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Fim:";
            // 
            // dataX
            // 
            this.dataX.Location = new System.Drawing.Point(80, 31);
            this.dataX.Name = "dataX";
            this.dataX.Size = new System.Drawing.Size(218, 20);
            this.dataX.TabIndex = 10;
            this.dataX.Value = new System.DateTime(2021, 1, 1, 12, 0, 0, 0);
            // 
            // dataY
            // 
            this.dataY.Location = new System.Drawing.Point(80, 54);
            this.dataY.Name = "dataY";
            this.dataY.Size = new System.Drawing.Size(218, 20);
            this.dataY.TabIndex = 11;
            this.dataY.Value = new System.DateTime(2021, 12, 31, 15, 5, 0, 0);
            // 
            // checkDias
            // 
            this.checkDias.AutoSize = true;
            this.checkDias.BackColor = System.Drawing.Color.Transparent;
            this.checkDias.ForeColor = System.Drawing.SystemColors.Control;
            this.checkDias.Location = new System.Drawing.Point(304, 34);
            this.checkDias.Name = "checkDias";
            this.checkDias.Size = new System.Drawing.Size(83, 17);
            this.checkDias.TabIndex = 12;
            this.checkDias.Text = "Daqui * dias";
            this.checkDias.UseVisualStyleBackColor = false;
            this.checkDias.CheckedChanged += new System.EventHandler(this.checkDias_CheckedChanged);
            this.checkDias.Click += new System.EventHandler(this.checkDias_Click);
            // 
            // btnCalcularDias
            // 
            this.btnCalcularDias.Location = new System.Drawing.Point(238, 163);
            this.btnCalcularDias.Name = "btnCalcularDias";
            this.btnCalcularDias.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularDias.TabIndex = 13;
            this.btnCalcularDias.Text = "Calcular";
            this.btnCalcularDias.UseVisualStyleBackColor = true;
            this.btnCalcularDias.Click += new System.EventHandler(this.btnCalcularDias_Click);
            // 
            // checkMais1
            // 
            this.checkMais1.AutoSize = true;
            this.checkMais1.BackColor = System.Drawing.Color.Transparent;
            this.checkMais1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkMais1.Location = new System.Drawing.Point(304, 57);
            this.checkMais1.Name = "checkMais1";
            this.checkMais1.Size = new System.Drawing.Size(95, 17);
            this.checkMais1.TabIndex = 14;
            this.checkMais1.Text = "Contar c/inicio";
            this.checkMais1.UseVisualStyleBackColor = false;
            this.checkMais1.Click += new System.EventHandler(this.checkMais1_Click);
            // 
            // FormDataEmDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DPInterativo.Properties.Resources.launch;
            this.ClientSize = new System.Drawing.Size(405, 123);
            this.Controls.Add(this.checkMais1);
            this.Controls.Add(this.btnCalcularDias);
            this.Controls.Add(this.checkDias);
            this.Controls.Add(this.dataY);
            this.Controls.Add(this.dataX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnoInicio);
            this.Controls.Add(this.txtMesInicio);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.txtAnoFim);
            this.Controls.Add(this.txtMesFim);
            this.Controls.Add(this.txtDiaFim);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataEmDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteractCalc - Distancia de dias";
            this.Load += new System.EventHandler(this.FormDataEmDias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDiaFim;
        private System.Windows.Forms.TextBox txtMesFim;
        private System.Windows.Forms.TextBox txtAnoFim;
        private System.Windows.Forms.TextBox txtAnoInicio;
        private System.Windows.Forms.TextBox txtMesInicio;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataX;
        private System.Windows.Forms.DateTimePicker dataY;
        private System.Windows.Forms.CheckBox checkDias;
        private System.Windows.Forms.Button btnCalcularDias;
        private System.Windows.Forms.CheckBox checkMais1;
    }
}