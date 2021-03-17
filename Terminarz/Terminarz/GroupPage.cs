using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminarz
{
    public partial class GroupPage : Form
    {
        private string userPermission;
        private int groupId;

        public int GroupId { get { return groupId; } }

        public GroupPage(int groupId)
        {
            InitializeComponent();

            this.groupId = groupId;
            string cmd = string.Format("SELECT g.group_name, g.description, m.edit_permission FROM project_groups g JOIN project_membership m ON g.group_id = m.group_id WHERE g.group_id = {0} AND m.user_id = {1}", this.groupId, Utilities.UserId);
            OracleDataReader reader = Utilities.QueryResult(cmd);
            if (reader == null || reader.HasRows == false) Utilities.MainWindowAddr.GroupsRefresh();
            else
            {
                reader.Read();
                labelName.Text = reader.GetString(0);
                try { descRichTextBox.Text = reader.GetString(1); } catch(Exception exc) { }
                userPermission = reader.GetString(2);

                switch(userPermission)
                {
                    case "admin":
                        buttonSave.Enabled = true;
                        buttonSave.Visible = true;
                        descRichTextBox.ReadOnly = false;
                        buttonGroupDelete.Enabled = true;
                        buttonGroupDelete.Visible = true;
                        buttonSetAdmin.Enabled = true;
                        buttonSetAdmin.Visible = true;
                        buttonSetEdit.Enabled = true;
                        buttonSetEdit.Visible = true;
                        goto case "edit";

                    case "edit":
                        buttonAdd.Enabled = true;
                        buttonDelete.Enabled = true;
                        buttonAdd.Visible = true;
                        buttonDelete.Visible = true;
                        goto case "user";

                    case "user":
                        break;
                }

                ListRefresh();
            }
        }

        public void ListRefresh()
        {
            listView.Items.Clear();
            string cmd = string.Format("SELECT u.u_login, m.edit_permission, m.user_id FROM project_membership m JOIN project_users u ON m.user_id = u.user_id WHERE m.group_id = {0} ORDER BY m.edit_permission ASC, u.u_login ASC", groupId);
            OracleDataReader reader = Utilities.QueryResult(cmd);
            if (reader == null || reader.HasRows == false) Utilities.MainWindowAddr.GroupsRefresh();
            else
            {
                while (reader.Read())
                {
                    ListViewItem tmp = listView.Items.Add(reader.GetString(0));
                    switch (reader.GetString(1))
                    {
                        case "admin":
                            tmp.SubItems.Add("Administrator");
                            break;

                        case "edit":
                            tmp.SubItems.Add("Moderator");
                            break;

                        case "user":
                            tmp.SubItems.Add("Użytkownik");
                            break;
                    }
                    tmp.SubItems.Add(reader.GetInt32(2).ToString());
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (descRichTextBox.Text == null || descRichTextBox.Text.Equals("")) descRichTextBox.Text = " ";
            string cmd = string.Format("UPDATE project_groups SET description = '{0}' WHERE group_id = {1}", descRichTextBox.Text, groupId);
            List<string> cmdList = new List<string>();
            cmdList.Add(cmd);
            Utilities.dmlOperation(cmdList);
        }

        private void buttonGroupDelete_Click(object sender, EventArgs e)
        {
            string title = "Potwierdzenie";
            string text = "Czy na pewno chcesz trwale usunąć tą grupę?";
            DialogResult confirm = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string cmd = string.Format("DELETE FROM project_groups WHERE group_id = {0}", groupId);
                List<string> cmdList = new List<string>();
                cmdList.Add(cmd);
                bool result = Utilities.dmlOperation(cmdList);
                if (result) Utilities.MainWindowAddr.GroupsRefresh();
            }
        }

        private void buttonSetAdmin_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) MessageBox.Show("Aby tego użyć najpierw wybierz użytkownika z listy osób.", "Komunikat");
            else
            {
                string title = "Potwierdzenie";
                string text = "Użycie tej opcji spowoduje zdegradowanie do rangi moderatora. Czy chcesz kontynuować?";
                DialogResult confirm = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string cmdAdmin = string.Format("UPDATE project_membership SET edit_permission = 'edit' WHERE group_id = {0} AND user_id = {1}", groupId, Utilities.UserId);
                    string cmdUser = string.Format("UPDATE project_membership SET edit_permission = 'admin' WHERE group_id = {0} AND user_id = {1}", groupId, listView.SelectedItems[0].SubItems[2].Text);
                    List<string> cmdList = new List<string>();
                    cmdList.Add(cmdAdmin);
                    cmdList.Add(cmdUser);
                    bool result = Utilities.dmlOperation(cmdList);
                    if (result) Utilities.MainWindowAddr.GroupsRefresh();
                }
            }
        }

        private void buttonSetEdit_Click(object sender, EventArgs e)
        {
            bool canProceed = true;
            if (listView.SelectedItems.Count == 0) MessageBox.Show("Aby tego użyć najpierw wybierz użytkownika z listy osób.", "Komunikat");
            else
            {
                if(listView.SelectedItems[0].SubItems[1].Text.Equals("Moderator"))
                {
                    string cmd = string.Format("UPDATE project_membership SET edit_permission = 'user' WHERE group_id = {0} AND user_id = {1}", groupId, listView.SelectedItems[0].SubItems[2].Text);
                    List<string> cmdList = new List<string>();
                    cmdList.Add(cmd);
                    bool result = Utilities.dmlOperation(cmdList);
                    if (result) ListRefresh();
                    canProceed = false;
                    listView_SelectedIndexChanged(null, null);
                }

                if (canProceed == true && listView.SelectedItems[0].SubItems[1].Text.Equals("Użytkownik"))
                {
                    string cmd = string.Format("UPDATE project_membership SET edit_permission = 'edit' WHERE group_id = {0} AND user_id = {1}", groupId, listView.SelectedItems[0].SubItems[2].Text);
                    List<string> cmdList = new List<string>();
                    cmdList.Add(cmd);
                    bool result = Utilities.dmlOperation(cmdList);
                    if (result) ListRefresh();
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count != 0 && listView.SelectedItems[0].SubItems[1].Text.Equals("Moderator"))
            {
                buttonSetEdit.Text = "Odbierz uprawnienia";
            }
            else
            {
                buttonSetEdit.Text = "Mianuj moderatorem";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GroupAddUser tmp = new GroupAddUser(groupId, this);
            tmp.ShowDialog(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) MessageBox.Show("Aby tego użyć najpierw wybierz użytkownika z listy osób.", "Komunikat");
            else
            {
                if (listView.SelectedItems[0].SubItems[1].Text.Equals("Administrator")) MessageBox.Show("Administratora grupy nie można usunąć.", "Komunikat");
                else
                {
                    if (listView.SelectedItems[0].SubItems[2].Text.Equals(Utilities.UserId.ToString())) MessageBox.Show("Nie można usunąć w ten sposób siebie samego. Aby tego dokonać wybierz \"Opuść grupę\"", "Komunikat");
                    else
                    {
                        string title = "Potwierdzenie";
                        string text = string.Format("Czy na pewno chcesz usunąć użytkownika o nazwie {0}?", listView.SelectedItems[0].Text);
                        DialogResult confirm = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            string cmd = string.Format("DELETE FROM project_membership WHERE user_id = {0} AND group_id = {1} AND edit_permission != 'admin'", listView.SelectedItems[0].SubItems[2].Text, groupId);
                            List<string> cmdList = new List<string>();
                            cmdList.Add(cmd);
                            bool result = Utilities.dmlOperation(cmdList);
                            if (result) ListRefresh();
                        }
                    }
                }
            }
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            if(userPermission.Equals("admin")) MessageBox.Show("Administrator nie może odejść z grupy.", "Komunikat");
            else
            {
                string title = "Potwierdzenie";
                string text = "Czy jesteś pewien?";
                DialogResult confirm = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string cmd = string.Format("DELETE FROM project_membership WHERE user_id = {0} AND group_id = {1}", Utilities.UserId, groupId);
                    List<string> cmdList = new List<string>();
                    cmdList.Add(cmd);
                    bool result = Utilities.dmlOperation(cmdList);
                    if (result) Utilities.MainWindowAddr.GroupsRefresh();
                }
            }
        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) MessageBox.Show("Aby tego użyć najpierw wybierz użytkownika z listy osób.", "Komunikat");
            else
            {
                ProfileUser tmp = new ProfileUser(Int32.Parse(listView.SelectedItems[0].SubItems[2].Text));
                if (tmp.Created) tmp.Show();
            }
        }
    }
}
