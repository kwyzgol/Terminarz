namespace Terminarz
{
    partial class EventAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventAdd));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDateTitle = new System.Windows.Forms.Label();
            this.labelTimeTitle = new System.Windows.Forms.Label();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.minuteComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelTypeTitle = new System.Windows.Forms.Label();
            this.labelGroupTitle = new System.Windows.Forms.Label();
            this.groupBoxDesc = new System.Windows.Forms.GroupBox();
            this.descRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBasic.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(7, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(288, 28);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Dodawanie wydarzenia";
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.AutoSize = true;
            this.labelNameTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelNameTitle.Location = new System.Drawing.Point(6, 18);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(79, 23);
            this.labelNameTitle.TabIndex = 8;
            this.labelNameTitle.Text = "Nazwa:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(112, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker.TabIndex = 12;
            // 
            // labelDateTitle
            // 
            this.labelDateTitle.AutoSize = true;
            this.labelDateTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelDateTitle.Location = new System.Drawing.Point(6, 53);
            this.labelDateTitle.Name = "labelDateTitle";
            this.labelDateTitle.Size = new System.Drawing.Size(60, 23);
            this.labelDateTitle.TabIndex = 11;
            this.labelDateTitle.Text = "Data:";
            // 
            // labelTimeTitle
            // 
            this.labelTimeTitle.AutoSize = true;
            this.labelTimeTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTimeTitle.Location = new System.Drawing.Point(6, 82);
            this.labelTimeTitle.Name = "labelTimeTitle";
            this.labelTimeTitle.Size = new System.Drawing.Size(94, 23);
            this.labelTimeTitle.TabIndex = 15;
            this.labelTimeTitle.Text = "Godzina:";
            // 
            // hourComboBox
            // 
            this.hourComboBox.BackColor = System.Drawing.Color.White;
            this.hourComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hourComboBox.ForeColor = System.Drawing.Color.Black;
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hourComboBox.Location = new System.Drawing.Point(112, 83);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(53, 26);
            this.hourComboBox.TabIndex = 16;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTime.Location = new System.Drawing.Point(171, 82);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(15, 23);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = ":";
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.BackColor = System.Drawing.Color.White;
            this.minuteComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.minuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minuteComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minuteComboBox.ForeColor = System.Drawing.Color.Black;
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minuteComboBox.Location = new System.Drawing.Point(192, 83);
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(53, 26);
            this.minuteComboBox.TabIndex = 18;
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.Controls.Add(this.textBoxName);
            this.groupBoxBasic.Controls.Add(this.labelTimeTitle);
            this.groupBoxBasic.Controls.Add(this.minuteComboBox);
            this.groupBoxBasic.Controls.Add(this.labelNameTitle);
            this.groupBoxBasic.Controls.Add(this.labelTime);
            this.groupBoxBasic.Controls.Add(this.labelDateTitle);
            this.groupBoxBasic.Controls.Add(this.hourComboBox);
            this.groupBoxBasic.Controls.Add(this.dateTimePicker);
            this.groupBoxBasic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBasic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.groupBoxBasic.Location = new System.Drawing.Point(12, 53);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(261, 136);
            this.groupBoxBasic.TabIndex = 19;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "Podstawowe informacje";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(112, 19);
            this.textBoxName.MaxLength = 25;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 26);
            this.textBoxName.TabIndex = 9;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.pictureBox);
            this.groupBoxDetails.Controls.Add(this.labelType);
            this.groupBoxDetails.Controls.Add(this.labelGroup);
            this.groupBoxDetails.Controls.Add(this.labelTypeTitle);
            this.groupBoxDetails.Controls.Add(this.labelGroupTitle);
            this.groupBoxDetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.groupBoxDetails.Location = new System.Drawing.Point(279, 53);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(358, 136);
            this.groupBoxDetails.TabIndex = 20;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Szczegóły";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Terminarz.Properties.Resources.icons8_calendar_96_1;
            this.pictureBox.Location = new System.Drawing.Point(257, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(95, 86);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelType.Location = new System.Drawing.Point(6, 37);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(180, 23);
            this.labelType.TabIndex = 13;
            this.labelType.Text = "<typ_wydarzenia>";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelGroup.Location = new System.Drawing.Point(6, 104);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(157, 23);
            this.labelGroup.TabIndex = 12;
            this.labelGroup.Text = "<nazwa_grupy>";
            // 
            // labelTypeTitle
            // 
            this.labelTypeTitle.AutoSize = true;
            this.labelTypeTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTypeTitle.Location = new System.Drawing.Point(6, 14);
            this.labelTypeTitle.Name = "labelTypeTitle";
            this.labelTypeTitle.Size = new System.Drawing.Size(47, 23);
            this.labelTypeTitle.TabIndex = 8;
            this.labelTypeTitle.Text = "Typ:";
            // 
            // labelGroupTitle
            // 
            this.labelGroupTitle.AutoSize = true;
            this.labelGroupTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGroupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelGroupTitle.Location = new System.Drawing.Point(6, 81);
            this.labelGroupTitle.Name = "labelGroupTitle";
            this.labelGroupTitle.Size = new System.Drawing.Size(138, 23);
            this.labelGroupTitle.TabIndex = 11;
            this.labelGroupTitle.Text = "Nazwa grupy:";
            // 
            // groupBoxDesc
            // 
            this.groupBoxDesc.Controls.Add(this.descRichTextBox);
            this.groupBoxDesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.groupBoxDesc.Location = new System.Drawing.Point(12, 195);
            this.groupBoxDesc.Name = "groupBoxDesc";
            this.groupBoxDesc.Size = new System.Drawing.Size(625, 130);
            this.groupBoxDesc.TabIndex = 21;
            this.groupBoxDesc.TabStop = false;
            this.groupBoxDesc.Text = "Szczegóły";
            // 
            // descRichTextBox
            // 
            this.descRichTextBox.DetectUrls = false;
            this.descRichTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descRichTextBox.Location = new System.Drawing.Point(6, 21);
            this.descRichTextBox.MaxLength = 400;
            this.descRichTextBox.Name = "descRichTextBox";
            this.descRichTextBox.Size = new System.Drawing.Size(613, 103);
            this.descRichTextBox.TabIndex = 0;
            this.descRichTextBox.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonAdd.Image = global::Terminarz.Properties.Resources.icons8_add_27_1;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(12, 331);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(309, 34);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonCancel.Image = global::Terminarz.Properties.Resources.icons8_cancel_27_1;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(328, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(309, 34);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EventAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 378);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxDesc);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxBasic);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie wydarzenia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventAdd_FormClosed);
            this.groupBoxBasic.ResumeLayout(false);
            this.groupBoxBasic.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxDesc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNameTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDateTitle;
        private System.Windows.Forms.Label labelTimeTitle;
        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox minuteComboBox;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelTypeTitle;
        private System.Windows.Forms.Label labelGroupTitle;
        private System.Windows.Forms.GroupBox groupBoxDesc;
        private System.Windows.Forms.RichTextBox descRichTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}