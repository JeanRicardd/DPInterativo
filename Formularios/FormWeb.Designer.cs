
namespace DPInterativo.Formularios
{
    partial class FormWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeb));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txtURL = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 48);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(844, 509);
            this.webBrowser.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtURL.BorderColor = System.Drawing.Color.Silver;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.Enabled = false;
            this.txtURL.FocusedBaseColor = System.Drawing.Color.Silver;
            this.txtURL.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtURL.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.SelectedText = "";
            this.txtURL.Size = new System.Drawing.Size(844, 30);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "url do site";
            // 
            // FormWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 578);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWeb";
            this.Text = "WebAcess - InteractCalc";
            this.Load += new System.EventHandler(this.FormWeb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private Guna.UI.WinForms.GunaTextBox txtURL;
        //private EO.WebBrowser.WebView webView1;
    }
}