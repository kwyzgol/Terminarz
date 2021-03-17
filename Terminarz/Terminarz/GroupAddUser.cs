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
    public partial class GroupAddUser : Form
    {
        private int groupId;
        private GroupPage baseForm;

        public GroupAddUser(int groupId, GroupPage baseForm)
        {
            InitializeComponent();

            this.groupId = groupId;
            this.baseForm = baseForm;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string cmdCheck = string.Format("SELECT 'yes' FROM project_membership m JOIN project_users u ON m.user_id = u.user_id WHERE m.group_id = {0} AND u.u_login = '{1}'", groupId, textBoxName.Text);
            OracleDataReader readerCheck = Utilities.QueryResult(cmdCheck);
            if(readerCheck.HasRows)
            {
                MessageBox.Show("Użytkownik należy już do tej grupy.", "Komunikat");
            }
            else
            {
                string cmdUser = string.Format("SELECT user_id FROM project_users WHERE u_login = '{0}'", textBoxName.Text);
                OracleDataReader readerUser = Utilities.QueryResult(cmdUser);
                if(readerUser != null && readerUser.Read())
                {
                    string cmdInsert = string.Format("INSERT INTO project_membership(user_id, group_id, edit_permission) VALUES({0}, {1}, 'user')", readerUser.GetInt32(0), groupId);
                    List<string> cmdList = new List<string>();
                    cmdList.Add(cmdInsert);
                    bool result = Utilities.dmlOperation(cmdList);
                    if(result)
                    {
                        baseForm.ListRefresh();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nie znaleziono użytkownika o wskazanej nazwie.", "Komunikat");
                }
            }
        }
    }
}
