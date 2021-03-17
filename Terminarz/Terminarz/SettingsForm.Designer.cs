namespace Terminarz
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.labelAlarm = new System.Windows.Forms.Label();
            this.alarmComboBox = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.closeComboBox = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelAlarm.Location = new System.Drawing.Point(12, 79);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(71, 23);
            this.labelAlarm.TabIndex = 8;
            this.labelAlarm.Text = "Alarm:";
            // 
            // alarmComboBox
            // 
            this.alarmComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.alarmComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.alarmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alarmComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarmComboBox.ForeColor = System.Drawing.Color.White;
            this.alarmComboBox.FormattingEnabled = true;
            this.alarmComboBox.Items.AddRange(new object[] {
            "Włączony",
            "Wyłączony"});
            this.alarmComboBox.Location = new System.Drawing.Point(168, 76);
            this.alarmComboBox.Name = "alarmComboBox";
            this.alarmComboBox.Size = new System.Drawing.Size(339, 26);
            this.alarmComboBox.TabIndex = 9;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelType.Location = new System.Drawing.Point(12, 111);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(118, 23);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Typ alarmu:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.typeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeComboBox.ForeColor = System.Drawing.Color.White;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Powiadomienie",
            "Komunikat w oknie"});
            this.typeComboBox.Location = new System.Drawing.Point(168, 108);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(339, 26);
            this.typeComboBox.TabIndex = 11;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelClose.Location = new System.Drawing.Point(12, 216);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(150, 23);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "Po zamknięciu:";
            // 
            // closeComboBox
            // 
            this.closeComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.closeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.closeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeComboBox.ForeColor = System.Drawing.Color.White;
            this.closeComboBox.FormattingEnabled = true;
            this.closeComboBox.Items.AddRange(new object[] {
            "Minimalizuj do zasobnika systemowego",
            "Zakończ działanie programu"});
            this.closeComboBox.Location = new System.Drawing.Point(168, 217);
            this.closeComboBox.Name = "closeComboBox";
            this.closeComboBox.Size = new System.Drawing.Size(339, 26);
            this.closeComboBox.TabIndex = 13;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTime.Location = new System.Drawing.Point(12, 143);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(131, 23);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Czas alarmu:";
            // 
            // timeComboBox
            // 
            this.timeComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.timeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeComboBox.ForeColor = System.Drawing.Color.White;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "15 minut przed",
            "5 minut przed",
            "Godzina przed",
            "Dzień przed",
            "Tydzień przed",
            "W chwili wydarzenia"});
            this.timeComboBox.Location = new System.Drawing.Point(168, 140);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(339, 26);
            this.timeComboBox.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(260, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(122, 25);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Ustawienia";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonSave.Image = global::Terminarz.Properties.Resources.icons8_edit_27_1;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(484, 319);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 34);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Terminarz.Properties.Resources.icons8_settings_27_1;
            this.pictureBox.Location = new System.Drawing.Point(234, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(27, 28);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.closeComboBox);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.labelAlarm);
            this.Controls.Add(this.alarmComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.ComboBox alarmComboBox;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ComboBox closeComboBox;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}