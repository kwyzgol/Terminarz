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
    public partial class ProfileForm : Form
    {
        private char passwordChar;
        private bool passwordShow = false;

        public ProfileForm()
        {
            InitializeComponent();

            passwordChar = textBoxPassword1.PasswordChar;

            string cmd = string.Format("SELECT u_login, first_name, last_name, email, informations FROM project_users WHERE user_id = {0}", Utilities.UserId);
            OracleDataReader reader = Utilities.QueryResult(cmd);

            if (reader == null) Utilities.MainWindowAddr.loadFailded();
            else
            {
                if (reader.Read())
                {
                    labelLogin.Text = reader.GetString(0);
                    try { textBoxName.Text = reader.GetString(1); } catch(Exception exc) { }
                    try { textBoxLastname.Text = reader.GetString(2); } catch(Exception exc) { }
                    try { textBoxEmail.Text = reader.GetString(3); } catch(Exception exc) { }
                    try { descRichTextBox.Text = reader.GetString(4); } catch(Exception exc) { }
                }
            }
        }

        private void pictureEyeOn_Click(object sender, EventArgs e)
        {
            if(passwordShow == true)
            {
                textBoxPassword1.PasswordChar = this.passwordChar;
                textBoxPassword2.PasswordChar = this.passwordChar;
                pictureEyeOff.Enabled = true;
                pictureEyeOff.Visible = true;
                pictureEyeOn.Enabled = false;
                pictureEyeOn.Visible = false;
                passwordShow = false;
            }
        }

        private void pictureEyeOff_Click(object sender, EventArgs e)
        {
            if(passwordShow == false)
            {
                textBoxPassword1.PasswordChar = (char)0;
                textBoxPassword2.PasswordChar = (char)0;
                pictureEyeOn.Enabled = true;
                pictureEyeOn.Visible = true;
                pictureEyeOff.Enabled = false;
                pictureEyeOff.Visible = false;
                passwordShow = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool canProceed = true;
            bool updatePassword = false;

            if (!textBoxPassword1.Text.Equals("") || !textBoxPassword2.Text.Equals(""))
            {
                if (textBoxPassword1.Text.Equals(textBoxPassword2.Text))
                {
                    updatePassword = true;
                }
                else 
                {
                    canProceed = false;
                    MessageBox.Show("Podane hasła różnią się, sprawdź ich poprawność.", "Komunikat");
                }
            }

            if(canProceed)
            {
                string cmd = string.Format("UPDATE project_users SET first_name = '{0}', last_name = '{1}', email = '{2}', informations = '{3}'", textBoxName.Text, textBoxLastname.Text, textBoxEmail.Text, descRichTextBox.Text);
                if (updatePassword) cmd += string.Format(", u_password = '{0}'", textBoxPassword1.Text);
                cmd += string.Format(" WHERE user_id = {0}", Utilities.UserId);
                List<string> cmdList = new List<string>();
                cmdList.Add(cmd);
                Utilities.dmlOperation(cmdList);
            }
        }
    }
}
