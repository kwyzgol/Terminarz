namespace Terminarz
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginLoadWPF = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // loginLoadWPF
            // 
            this.loginLoadWPF.BackColor = System.Drawing.Color.Transparent;
            this.loginLoadWPF.BackColorTransparent = true;
            this.loginLoadWPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLoadWPF.Location = new System.Drawing.Point(0, 0);
            this.loginLoadWPF.Name = "loginLoadWPF";
            this.loginLoadWPF.Size = new System.Drawing.Size(296, 418);
            this.loginLoadWPF.TabIndex = 0;
            this.loginLoadWPF.Text = "elementHost1";
            this.loginLoadWPF.Child = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(296, 418);
            this.Controls.Add(this.loginLoadWPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost loginLoadWPF;
    }
}