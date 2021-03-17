namespace Terminarz
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.labelTopic = new System.Windows.Forms.Label();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTopic.Location = new System.Drawing.Point(12, 9);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(72, 23);
            this.labelTopic.TabIndex = 8;
            this.labelTopic.Text = "Temat:";
            // 
            // topicComboBox
            // 
            this.topicComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.topicComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.topicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topicComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topicComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topicComboBox.ForeColor = System.Drawing.Color.White;
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Items.AddRange(new object[] {
            "Logowanie oraz rejestracja",
            "Modyfikowanie profilu",
            "Grupy: Tworzenie i zarządzanie",
            "Wydarzenia: Tworzenie i zarządzanie",
            "Ustawienia"});
            this.topicComboBox.Location = new System.Drawing.Point(85, 10);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(549, 26);
            this.topicComboBox.TabIndex = 9;
            this.topicComboBox.SelectedIndexChanged += new System.EventHandler(this.topicComboBox_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(84, 42);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(550, 319);
            this.webBrowser.TabIndex = 10;
            this.webBrowser.Visible = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.topicComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}