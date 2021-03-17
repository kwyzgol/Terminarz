namespace Terminarz
{
    partial class GroupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupPage));
            this.listView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxDesc = new System.Windows.Forms.GroupBox();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.buttonProfil = new System.Windows.Forms.Button();
            this.buttonSetAdmin = new System.Windows.Forms.Button();
            this.buttonSetEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonGroupDelete = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.groupBoxDesc.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.TimeColumn});
            this.listView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView.ForeColor = System.Drawing.Color.White;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 21);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(263, 134);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Nazwa użytkownika";
            this.NameColumn.Width = 142;
            // 
            // TimeColumn
            // 
            this.TimeColumn.Text = "Ranga";
            this.TimeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeColumn.Width = 100;
            // 
            // descRichTextBox
            // 
            this.descRichTextBox.DetectUrls = false;
            this.descRichTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descRichTextBox.Location = new System.Drawing.Point(6, 21);
            this.descRichTextBox.MaxLength = 400;
            this.descRichTextBox.Name = "descRichTextBox";
            this.descRichTextBox.ReadOnly = true;
            this.descRichTextBox.Size = new System.Drawing.Size(459, 90);
            this.descRichTextBox.TabIndex = 3;
            this.descRichTextBox.Text = "";
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.AutoSize = true;
            this.labelNameTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelNameTitle.Location = new System.Drawing.Point(12, 9);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(79, 23);
            this.labelNameTitle.TabIndex = 1;
            this.labelNameTitle.Text = "Nazwa:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelName.Location = new System.Drawing.Point(97, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(157, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "<nazwa_grupy>";
            // 
            // groupBoxDesc
            // 
            this.groupBoxDesc.Controls.Add(this.descRichTextBox);
            this.groupBoxDesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.groupBoxDesc.Location = new System.Drawing.Point(12, 35);
            this.groupBoxDesc.Name = "groupBoxDesc";
            this.groupBoxDesc.Size = new System.Drawing.Size(471, 117);
            this.groupBoxDesc.TabIndex = 12;
            this.groupBoxDesc.TabStop = false;
            this.groupBoxDesc.Text = "Opis";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonProfil);
            this.groupBoxList.Controls.Add(this.listView);
            this.groupBoxList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.groupBoxList.Location = new System.Drawing.Point(209, 158);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(274, 201);
            this.groupBoxList.TabIndex = 13;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Lista osób";
            // 
            // buttonProfil
            // 
            this.buttonProfil.BackColor = System.Drawing.Color.White;
            this.buttonProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonProfil.Image = global::Terminarz.Properties.Resources.icons8_contacts_27_1;
            this.buttonProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfil.Location = new System.Drawing.Point(6, 161);
            this.buttonProfil.Name = "buttonProfil";
            this.buttonProfil.Size = new System.Drawing.Size(262, 34);
            this.buttonProfil.TabIndex = 11;
            this.buttonProfil.Text = "Profil";
            this.buttonProfil.UseVisualStyleBackColor = false;
            this.buttonProfil.Click += new System.EventHandler(this.buttonProfil_Click);
            // 
            // buttonSetAdmin
            // 
            this.buttonSetAdmin.BackColor = System.Drawing.Color.White;
            this.buttonSetAdmin.Enabled = false;
            this.buttonSetAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonSetAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetAdmin.Location = new System.Drawing.Point(12, 198);
            this.buttonSetAdmin.Name = "buttonSetAdmin";
            this.buttonSetAdmin.Size = new System.Drawing.Size(191, 34);
            this.buttonSetAdmin.TabIndex = 6;
            this.buttonSetAdmin.Text = "Mianuj administratorem";
            this.buttonSetAdmin.UseVisualStyleBackColor = false;
            this.buttonSetAdmin.Visible = false;
            this.buttonSetAdmin.Click += new System.EventHandler(this.buttonSetAdmin_Click);
            // 
            // buttonSetEdit
            // 
            this.buttonSetEdit.BackColor = System.Drawing.Color.White;
            this.buttonSetEdit.Enabled = false;
            this.buttonSetEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonSetEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetEdit.Location = new System.Drawing.Point(12, 238);
            this.buttonSetEdit.Name = "buttonSetEdit";
            this.buttonSetEdit.Size = new System.Drawing.Size(191, 34);
            this.buttonSetEdit.TabIndex = 7;
            this.buttonSetEdit.Text = "Mianuj moderatorem";
            this.buttonSetEdit.UseVisualStyleBackColor = false;
            this.buttonSetEdit.Visible = false;
            this.buttonSetEdit.Click += new System.EventHandler(this.buttonSetEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonSave.Image = global::Terminarz.Properties.Resources.icons8_edit_27_1;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(382, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 34);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonDelete.Image = global::Terminarz.Properties.Resources.icons8_denied_27_1;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(110, 279);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 34);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonAdd.Image = global::Terminarz.Properties.Resources.icons8_add_user_male_27_1;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(12, 279);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 34);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonGroupDelete
            // 
            this.buttonGroupDelete.BackColor = System.Drawing.Color.White;
            this.buttonGroupDelete.Enabled = false;
            this.buttonGroupDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGroupDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonGroupDelete.Image = global::Terminarz.Properties.Resources.icons8_cancel_27_1;
            this.buttonGroupDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroupDelete.Location = new System.Drawing.Point(12, 158);
            this.buttonGroupDelete.Name = "buttonGroupDelete";
            this.buttonGroupDelete.Size = new System.Drawing.Size(191, 34);
            this.buttonGroupDelete.TabIndex = 5;
            this.buttonGroupDelete.Text = "Usuń grupę";
            this.buttonGroupDelete.UseVisualStyleBackColor = false;
            this.buttonGroupDelete.Visible = false;
            this.buttonGroupDelete.Click += new System.EventHandler(this.buttonGroupDelete_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.BackColor = System.Drawing.Color.White;
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonLeave.Image = global::Terminarz.Properties.Resources.icons8_exit_27_1;
            this.buttonLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeave.Location = new System.Drawing.Point(12, 319);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(191, 34);
            this.buttonLeave.TabIndex = 10;
            this.buttonLeave.Text = "Opuść grupę";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // GroupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 365);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSetEdit);
            this.Controls.Add(this.buttonSetAdmin);
            this.Controls.Add(this.buttonGroupDelete);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxDesc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupPage";
            this.Text = "GroupPage";
            this.groupBoxDesc.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader TimeColumn;
        private System.Windows.Forms.RichTextBox descRichTextBox;
        private System.Windows.Forms.Label labelNameTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxDesc;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button buttonProfil;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Button buttonGroupDelete;
        private System.Windows.Forms.Button buttonSetAdmin;
        private System.Windows.Forms.Button buttonSetEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}