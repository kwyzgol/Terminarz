using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminarz
{
    public partial class GroupsForm : Form
    {
        private Button actualButton = null;
        private Form actualForm = null;

        public Button ActualButton { get { return actualButton; } }

        public GroupsForm()
        {
            InitializeComponent();

            string cmd = string.Format("SELECT m.group_id, g.group_name FROM project_membership m JOIN project_groups g ON m.group_id = g.group_id WHERE m.user_id = {0}", Utilities.UserId);
            OracleDataReader reader = Utilities.QueryResult(cmd);

            if(reader != null)
                while(reader.Read())
                {
                    int groupId = reader.GetInt32(0);
                    string groupName = reader.GetString(1);
                    GroupButton tmp = new GroupButton(groupId, groupName);
                    tmp.Click += new EventHandler(GroupButton_Click);
                    panelLeft.Controls.Add(tmp);
                    tmp.BringToFront();
                }
        }

        public void buttonChoose(Button button)
        {
            if (actualButton != null) actualButton.BackgroundImage = null;
            if (actualForm != null) actualForm.Close();
            button.BackgroundImage = Utilities.MainWindowAddr.buttonStyle.Images[0];
            actualButton = button;
        }

        public void GroupButton_Click(object sender, EventArgs e)
        {
            GroupButton button = (GroupButton)sender;
            buttonChoose(button);

            actualForm = new GroupPage(button.GroupId);
            actualForm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(actualForm);
            mainPanel.Tag = actualForm;
            actualForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonChoose(button);

            actualForm = new GroupAdd();
            actualForm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(actualForm);
            mainPanel.Tag = actualForm;
            actualForm.Show();
        }
    }
}
