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
    public partial class ProfileUser : Form
    {
        public bool Created { get; }

        public ProfileUser(int id)
        {
            InitializeComponent();

            string cmd = string.Format("SELECT u_login, first_name, last_name, email, informations FROM project_users WHERE user_id = {0}", id);
            OracleDataReader reader = Utilities.QueryResult(cmd);

            if (reader == null || reader.HasRows == false) Created = false;
            else
            {
                if (reader.Read())
                {
                    labelLogin.Text = reader.GetString(0);
                    try { textBoxName.Text = reader.GetString(1); } catch (Exception exc) { }
                    try { textBoxLastname.Text = reader.GetString(2); } catch (Exception exc) { }
                    try { textBoxEmail.Text = reader.GetString(3); } catch (Exception exc) { }
                    try { descRichTextBox.Text = reader.GetString(4); } catch (Exception exc) { }
                    Created = true;
                }
            }
        }
    }
}
