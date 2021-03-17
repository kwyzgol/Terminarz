using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Terminarz
{
    /// <summary>
    /// Interaction logic for RegisterWPF.xaml
    /// </summary>
    public partial class RegisterWPF : UserControl
    {
        private bool visible = false;
        public RegisterWPF()
        {
            InitializeComponent();
        }

        private void goLoginButton_Click(object sender, RoutedEventArgs e)
        {
            visibilityOff_MouseLeftButtonUp(null, null);
            Utilities.LoginAddr.goLogin();
        }

        private void RegisterWPFControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Utilities.LoginAddr.moveStart();
        }

        private void RegisterWPFControl_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.LoginAddr.moveUpdate();
        }

        private void RegisterWPFControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Utilities.LoginAddr.moveStop();
        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities.DatabaseConnection();
            bool canRegister = true;

            visibilityOff_MouseLeftButtonUp(null, null);

            if (loginEdit.Text.Length == 0 || passwordEdit.Password.Length == 0)
            {
                canRegister = false;
                MessageBox.Show("Login i hasło nie mogą być puste");
            }
            else
            {
                try
                {
                    string loginLower = loginEdit.Text.ToLower();
                    string cmdText = string.Format("SELECT 'Already exists' FROM project_users WHERE LOWER(u_login) = '{0}'", loginLower);
                    OracleDataReader cmdReader = Utilities.QueryResult(cmdText);

                    if (cmdReader.HasRows)
                    {
                        canRegister = false;
                        MessageBox.Show("Istnieje już taki login");
                    }
                }
                catch(Exception exc)
                {
                    canRegister = false;
                }
            }

            if (canRegister)
            {
                List<string> registrationCmd = new List<string>();
                
                string userInsert = "INSERT INTO project_users(user_id, u_login, u_password";
                if (firstNameEdit.Text.Length != 0) userInsert += ", first_name";
                if (lastNameEdit.Text.Length != 0) userInsert += ", last_name";
                if (emailEdit.Text.Length != 0) userInsert += ", email";
               
                userInsert += ") VALUES (project_users_seq.NEXTVAL, '" + loginEdit.Text + "', '" + passwordEdit.Password;
                if (firstNameEdit.Text.Length != 0) userInsert += "', '" + firstNameEdit.Text;
                if (lastNameEdit.Text.Length != 0) userInsert += "', '" + lastNameEdit.Text;
                if (emailEdit.Text.Length != 0) userInsert += "', '" + emailEdit.Text;
                userInsert += "')";

                registrationCmd.Add(userInsert);
                registrationCmd.Add("INSERT INTO project_settings VALUES(project_users_seq.CURRVAL, 'yes', 'yes', 'BalloonTip', 15)");
                Utilities.dmlOperation(registrationCmd);

                Utilities.LoginProcedure(loginEdit.Text, passwordEdit.Password);
            }
        }

        private void visibilityChange_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(visible == false)
            {
                visibilityChange.Visibility = Visibility.Hidden;
                visibilityOff.Visibility = Visibility.Visible;

                passwordEdit.Visibility = Visibility.Hidden;
                passwordVisible.Visibility = Visibility.Visible;

                passwordVisible.Text = passwordEdit.Password;

                visible = true;
            }
        }

        private void visibilityOff_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (visible == true)
            {
                visibilityOff.Visibility = Visibility.Hidden;
                visibilityChange.Visibility = Visibility.Visible;

                passwordVisible.Visibility = Visibility.Hidden;
                passwordEdit.Visibility = Visibility.Visible;

                passwordEdit.Password = passwordVisible.Text;

                visible = false;
            }
        }

        private void loginEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) registrationButton_Click(null, null);
        }

        private void passwordEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) registrationButton_Click(null, null);
        }

        private void firstNameEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) registrationButton_Click(null, null);
        }

        private void lastNameEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) registrationButton_Click(null, null);
        }

        private void emailEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) registrationButton_Click(null, null);
        }

        private void passwordVisible_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) registrationButton_Click(null, null);
        }

        private void RegisterWPFControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) goLoginButton_Click(null, null);
        }
    }
}
