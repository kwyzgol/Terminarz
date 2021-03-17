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
    public partial class GroupAdd : Form
    {
        public GroupAdd()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(textBoxName == null || textBoxName.Text.Equals(""))
            {
                MessageBox.Show("Pole \"Nazwa\" nie może być puste.", "Komunikat");
            }
            else
            {
                if (descRichTextBox.Text == null || descRichTextBox.Text.Equals("")) descRichTextBox.Text = " ";
                string cmdGroup = string.Format("INSERT INTO project_groups(group_id, admin_id, group_name, description) VALUES(project_groups_seq.NEXTVAL, {0}, '{1}', '{2}')", Utilities.UserId, textBoxName.Text, descRichTextBox.Text);
                string cmdMembership = string.Format("INSERT INTO project_membership(user_id, group_id, edit_permission) VALUES({0}, project_groups_seq.CURRVAL, 'admin')", Utilities.UserId);
                List<string> cmdList = new List<string>();
                cmdList.Add(cmdGroup);
                cmdList.Add(cmdMembership);
                Utilities.dmlOperation(cmdList);
                Utilities.MainWindowAddr.GroupsRefresh();
            }
        }
    }
}
