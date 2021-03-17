using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Oracle.ManagedDataAccess.Client;

namespace Terminarz
{
    public static class Utilities
    {
        public static Login LoginAddr { get; set; }
        public static MainWindow MainWindowAddr { get; set; }
        private static int _userId = -1;
        public static int UserId 
        {
            get { return _userId; } 
        }
        private static OracleConnection con = null;


        public static void DatabaseConnection()
        {
            try
            {
                string conString = "User Id=root; password=12345;" + "Data Source=127.0.0.1:1521/oltpstud; Pooling=false;";
                con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
            }
            catch(Exception exc)
            {
                con = null;
            }
        }
        public static OracleDataReader QueryResult(string queryCommand) 
        {
            try
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = queryCommand;
                OracleDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Błąd podczas wysyłania zapytania do bazy danych. Sprawdź swoje połączenie internetowe.");
                return null;
            }
        }
        public static bool dmlOperation(List<string> cmdList)
        {
            try
            {
                OracleTransaction transaction = con.BeginTransaction();
                OracleCommand cmd = con.CreateCommand();
                cmd.Transaction = transaction;

                try
                {
                    foreach (string cmdText in cmdList)
                    {
                        cmd.CommandText = cmdText;
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception exc)
                {
                    transaction.Rollback();
                    MessageBox.Show("Błąd podczas próby zapisu do bazy danych. Sprawdź swoje połączenie internetowe.", "Komunikat");
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd podczas próby zapisu do bazy danych. Sprawdź swoje połączenie internetowe.", "Komunikat");
                return false;
            }
        }
        public static void LoginProcedure(string userLogin, string userPassword)
        {
            string cmd = string.Format("SELECT user_id FROM project_users WHERE u_login = '{0}' AND u_password = '{1}'", userLogin, userPassword);
            OracleDataReader reader = QueryResult(cmd);
            if (reader != null)
            {
                if (reader.Read())
                {
                    _userId = reader.GetInt32(0);

                    DateTimeOffset now = DateTimeOffset.UtcNow;
                    List<string> loginDateInsert = new List<string>();
                    loginDateInsert.Add(string.Format("INSERT INTO project_login_history VALUES({0}, TO_TIMESTAMP_TZ('{1}.{2}.{3} {4}:{5} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM'))", _userId, now.Day, now.Month, now.Year, now.Hour, now.Minute));
                    dmlOperation(loginDateInsert);

                    MainWindowAddr = new MainWindow();
                    MainWindowAddr.Show();
                    LoginAddr.Hide();
                }
                else MessageBox.Show("Błędne dane logowania.", "Komunikat");
            }
        }
        public static void LogoutProcedure()
        {
            LoginAddr.LoginWPFAddr.loginEdit.Clear();
            LoginAddr.LoginWPFAddr.passwordEdit.Clear();

            LoginAddr.RegisterWPFAddr.loginEdit.Clear();
            LoginAddr.RegisterWPFAddr.passwordEdit.Clear();
            LoginAddr.RegisterWPFAddr.passwordVisible.Clear();
            LoginAddr.RegisterWPFAddr.firstNameEdit.Clear();
            LoginAddr.RegisterWPFAddr.lastNameEdit.Clear();
            LoginAddr.RegisterWPFAddr.emailEdit.Clear();

            _userId = -1;

            LoginAddr.goLogin();
            LoginAddr.Show();
            if (MainWindowAddr != null)
            {
                MainWindowAddr.UserClose = false;
                MainWindowAddr.Close();
            }
        }
    }
}
