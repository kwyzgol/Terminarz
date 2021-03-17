namespace Terminarz
{
    partial class EventsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.groupBoxToday = new System.Windows.Forms.GroupBox();
            this.labelDateTitle = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTimeTitle = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDateSelect2 = new System.Windows.Forms.Label();
            this.labelDateSelect1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxToday
            // 
            this.groupBoxToday.Controls.Add(this.labelDateTitle);
            this.groupBoxToday.Controls.Add(this.labelTime);
            this.groupBoxToday.Controls.Add(this.labelDate);
            this.groupBoxToday.Controls.Add(this.labelTimeTitle);
            this.groupBoxToday.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.groupBoxToday.Location = new System.Drawing.Point(12, 12);
            this.groupBoxToday.Name = "groupBoxToday";
            this.groupBoxToday.Size = new System.Drawing.Size(200, 70);
            this.groupBoxToday.TabIndex = 1;
            this.groupBoxToday.TabStop = false;
            this.groupBoxToday.Text = "Dzisiaj";
            // 
            // labelDateTitle
            // 
            this.labelDateTitle.AutoSize = true;
            this.labelDateTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelDateTitle.Location = new System.Drawing.Point(6, 18);
            this.labelDateTitle.Name = "labelDateTitle";
            this.labelDateTitle.Size = new System.Drawing.Size(60, 23);
            this.labelDateTitle.TabIndex = 2;
            this.labelDateTitle.Text = "Data:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTime.Location = new System.Drawing.Point(106, 41);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(86, 23);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00:00";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelDate.Location = new System.Drawing.Point(84, 18);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(108, 23);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "00.00.0000";
            // 
            // labelTimeTitle
            // 
            this.labelTimeTitle.AutoSize = true;
            this.labelTimeTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTimeTitle.Location = new System.Drawing.Point(6, 41);
            this.labelTimeTitle.Name = "labelTimeTitle";
            this.labelTimeTitle.Size = new System.Drawing.Size(94, 23);
            this.labelTimeTitle.TabIndex = 3;
            this.labelTimeTitle.Text = "Godzina:";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelMode.Location = new System.Drawing.Point(12, 94);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(53, 23);
            this.labelMode.TabIndex = 6;
            this.labelMode.Text = "Tryb:";
            // 
            // modeComboBox
            // 
            this.modeComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.modeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modeComboBox.ForeColor = System.Drawing.Color.White;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Dzisiejsze wydarzenia",
            "Nadchodzące wydarzenia",
            "Konkretna data",
            "Przedział czasu"});
            this.modeComboBox.Location = new System.Drawing.Point(67, 91);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(233, 26);
            this.modeComboBox.TabIndex = 7;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // listViewEvents
            // 
            this.listViewEvents.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewEvents.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.TimeColumn,
            this.DateColumn,
            this.TypeColumn,
            this.GroupNameColumn});
            this.listViewEvents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewEvents.ForeColor = System.Drawing.Color.White;
            this.listViewEvents.FullRowSelect = true;
            this.listViewEvents.GridLines = true;
            this.listViewEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(16, 123);
            this.listViewEvents.MultiSelect = false;
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.ShowItemToolTips = true;
            this.listViewEvents.Size = new System.Drawing.Size(618, 189);
            this.listViewEvents.TabIndex = 12;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
            this.listViewEvents.SelectedIndexChanged += new System.EventHandler(this.listViewEvents_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Nazwa";
            this.NameColumn.Width = 150;
            // 
            // TimeColumn
            // 
            this.TimeColumn.Text = "Godzina";
            this.TimeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeColumn.Width = 75;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Data";
            this.DateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateColumn.Width = 110;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Typ";
            this.TypeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypeColumn.Width = 110;
            // 
            // GroupNameColumn
            // 
            this.GroupNameColumn.Text = "Nazwa grupy";
            this.GroupNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GroupNameColumn.Width = 150;
            // 
            // labelDateSelect2
            // 
            this.labelDateSelect2.AutoSize = true;
            this.labelDateSelect2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateSelect2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelDateSelect2.Location = new System.Drawing.Point(497, 66);
            this.labelDateSelect2.Name = "labelDateSelect2";
            this.labelDateSelect2.Size = new System.Drawing.Size(40, 23);
            this.labelDateSelect2.TabIndex = 9;
            this.labelDateSelect2.Text = "Do:";
            this.labelDateSelect2.Visible = false;
            // 
            // labelDateSelect1
            // 
            this.labelDateSelect1.AutoSize = true;
            this.labelDateSelect1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateSelect1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelDateSelect1.Location = new System.Drawing.Point(333, 66);
            this.labelDateSelect1.Name = "labelDateSelect1";
            this.labelDateSelect1.Size = new System.Drawing.Size(60, 23);
            this.labelDateSelect1.TabIndex = 8;
            this.labelDateSelect1.Text = "Data:";
            this.labelDateSelect1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(501, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonDelete.Image = global::Terminarz.Properties.Resources.icons8_cancel_27_1;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(328, 319);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 34);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonEdit.Image = global::Terminarz.Properties.Resources.icons8_edit_27_1;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(172, 319);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 34);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDesc
            // 
            this.buttonDesc.BackColor = System.Drawing.Color.White;
            this.buttonDesc.Enabled = false;
            this.buttonDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonDesc.Image = global::Terminarz.Properties.Resources.icons8_document_27_1;
            this.buttonDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesc.Location = new System.Drawing.Point(484, 319);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(150, 34);
            this.buttonDesc.TabIndex = 16;
            this.buttonDesc.Text = "Opis";
            this.buttonDesc.UseVisualStyleBackColor = false;
            this.buttonDesc.Visible = false;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.White;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonEvents.Image = global::Terminarz.Properties.Resources.icons8_add_27_1;
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(16, 319);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(150, 34);
            this.buttonEvents.TabIndex = 13;
            this.buttonEvents.Text = "Dodaj";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDateSelect2);
            this.Controls.Add(this.labelDateSelect1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.groupBoxToday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.groupBoxToday.ResumeLayout(false);
            this.groupBoxToday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxToday;
        private System.Windows.Forms.Label labelDateTitle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTimeTitle;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader TimeColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ColumnHeader GroupNameColumn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Label labelDateSelect2;
        private System.Windows.Forms.Label labelDateSelect1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}