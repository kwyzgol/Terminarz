using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for LoginWPF.xaml
    /// </summary>
    public partial class LoginWPF : UserControl
    {
        public LoginWPF()
        {
            InitializeComponent();
        }

        private void LoginWPFControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Utilities.LoginAddr.moveStart();
        }

        private void LoginWPFControl_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.LoginAddr.moveUpdate();
        }

        private void LoginWPFControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Utilities.LoginAddr.moveStop();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities.LoginAddr.Close();
        }

        private void goRegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities.LoginAddr.goRegistration();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities.DatabaseConnection();

            Utilities.LoginProcedure(loginEdit.Text, passwordEdit.Password);
        }

        private void loginEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) loginButton_Click(null, null);
        }

        private void passwordEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) loginButton_Click(null, null);
        }

        private void LoginWPFControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) exitButton_Click(null, null);
        }
    }
}
