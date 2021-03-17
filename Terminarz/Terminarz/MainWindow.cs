using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Terminarz
{
    public partial class MainWindow : Form
    {
        private enum FormType
        {
            Events,
            Profile,
            Groups,
            Settings,
            Help,
            Info
        }

        public bool MinimizeEnable { get; set; }
        public bool AlarmEnable { get; set; }
        public string AlarmType { get; set; }
        public int AlarmTime { get; set; }

        public bool UserClose { get; set; } = true;

        private bool dragging = false;
        private Point cursorLocation;
        private Point formLocation;

        private Form actualForm = null;
        private int actualButton = -1;

        private List<EventSync> syncList = null;

        private bool firstFail = true;

        private bool isMinimized = false;

        public MainWindow()
        {
            InitializeComponent();

            settingsLoad();
            if (AlarmEnable)
            {
                timerSync_Tick(null, null);
                timerSync.Enabled = true;
                timerCheck.Enabled = true;
            }

            notifyIcon.Visible = true;

            formChoose(FormType.Events);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            cursorLocation = Cursor.Position;
            formLocation = this.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point moveValue = Point.Subtract(Cursor.Position, new Size(cursorLocation));
                this.Location = Point.Add(formLocation, new Size(moveValue));
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void formChoose(FormType type)
        {
            if ((int)type != actualButton)
            {
                if (actualForm != null) actualForm.Close();

                switch (actualButton)
                {
                    case -1:
                        break;

                    case (int)FormType.Events:
                        buttonEvents.BackgroundImage = null;
                        break;

                    case (int)FormType.Profile:
                        buttonProfile.BackgroundImage = null;
                        break;

                    case (int)FormType.Groups:
                        buttonGroups.BackgroundImage = null;
                        break;

                    case (int)FormType.Settings:
                        buttonSettings.BackgroundImage = null;
                        break;

                    case (int)FormType.Help:
                        buttonHelp.BackgroundImage = null;
                        break;

                    case (int)FormType.Info:
                        buttonInfo.BackgroundImage = null;
                        break;
                }

                switch ((int)type)
                {
                    case (int)FormType.Events:
                        buttonEvents.BackgroundImage = buttonStyle.Images[0];
                        actualForm = new EventsForm();
                        break;

                    case (int)FormType.Profile:
                        buttonProfile.BackgroundImage = buttonStyle.Images[0];
                        actualForm = new ProfileForm();
                        break;

                    case (int)FormType.Groups:
                        buttonGroups.BackgroundImage = buttonStyle.Images[0];
                        actualForm = new GroupsForm();
                        break;

                    case (int)FormType.Settings:
                        buttonSettings.BackgroundImage = buttonStyle.Images[0];
                        actualForm = new SettingsForm();
                        break;

                    case (int)FormType.Help:
                        buttonHelp.BackgroundImage = buttonStyle.Images[0];
                        actualForm = new HelpForm();
                        break;

                    case (int)FormType.Info:
                        buttonInfo.BackgroundImage = buttonStyle.Images[0];
                        actualForm = new InfoForm();
                        break;
                }

                actualForm.TopLevel = false;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(actualForm);
                mainPanel.Tag = actualForm;
                actualForm.Show();
                actualButton = (int)type;
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            formChoose(FormType.Events);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            formChoose(FormType.Profile);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            formChoose(FormType.Groups);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            formChoose(FormType.Settings);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            formChoose(FormType.Help);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            formChoose(FormType.Info);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            timerSync.Enabled = false;
            timerCheck.Enabled = false;
            timerFail.Enabled = false;
            notifyIcon.Visible = false;
            actualForm.Close();
            actualForm = null;
            Utilities.LogoutProcedure();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Utilities.LoginAddr.Close();
        }

        public void forcedLogout()
        {
            timerSync.Enabled = false;
            timerCheck.Enabled = false;
            timerFail.Enabled = false;
            notifyIcon.Visible = false;
            if (isMinimized == false)
            {
                actualForm.Close();
                actualForm = null;
            }
            Utilities.LogoutProcedure();
        }

        public void settingsLoad()
        {
            try
            {
                string cmd = string.Format("SELECT minimize_enable, alarm_enable, alarm_type, alarm_time FROM project_settings WHERE user_id = {0}", Utilities.UserId);
                OracleDataReader reader = Utilities.QueryResult(cmd);

                reader.Read();

                string tmpString = reader.GetString(0);
                if (tmpString.Equals("yes")) MinimizeEnable = true;
                else MinimizeEnable = false;

                tmpString = reader.GetString(1);
                if (tmpString.Equals("yes")) AlarmEnable = true;
                else AlarmEnable = false;

                AlarmType = reader.GetString(2);

                AlarmTime = reader.GetInt32(3);
            }
            catch (Exception exc)
            {
                loadFailded();
            }
        }
        public void loadFailded()
        {
            if (firstFail)
            {
                MessageBox.Show("Wystąpił błąd. Wkrótce nastąpi wylogowanie.");
                timerFail.Enabled = true;
                firstFail = false;
            }
    }

        public void timerSync_Tick(object sender, EventArgs e)
        {
            try
            {
                List<EventSync> tmp = new List<EventSync>();
                DateTime now = DateTime.UtcNow;
                string date = string.Format("'{0}.{1}.{2} {3}:{4} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM'", now.Day.ToString("D2"), now.Month.ToString("D2"), now.Year, now.Hour.ToString("D2"), now.Minute.ToString("D2"));
                string cmd = string.Format("SELECT event_name, event_date FROM project_events WHERE event_date > TO_TIMESTAMP_TZ({0}) AND (user_id = {1} OR group_id IN (SELECT group_id FROM project_membership WHERE user_id = {1}))", date, Utilities.UserId);
                OracleDataReader reader = Utilities.QueryResult(cmd);
                while(reader.Read())
                {
                    tmp.Add(new EventSync(reader.GetString(0), reader.GetDateTimeOffset(1)));
                }
                syncList = tmp;
            }
            catch (Exception exc)
            {
                loadFailded();
            }

        }


        private void timerCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach(EventSync eventSync in syncList)
                {
                    if (eventSync.Equals(DateTime.Now, AlarmTime)) eventSync.Notify(AlarmType);
                }
            }
            catch(Exception exc)
            {
                loadFailded();
            }
        }

        private void timerFail_Tick(object sender, EventArgs e)
        {
                timerSync.Enabled = false;
                timerCheck.Enabled = false;
                forcedLogout();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            if (MinimizeEnable)
            {
                this.Hide();
                actualForm.Close();
                actualForm = null;
                switch (actualButton)
                {
                    case -1:
                        break;

                    case (int)FormType.Events:
                        buttonEvents.BackgroundImage = null;
                        break;

                    case (int)FormType.Profile:
                        buttonProfile.BackgroundImage = null;
                        break;

                    case (int)FormType.Groups:
                        buttonGroups.BackgroundImage = null;
                        break;

                    case (int)FormType.Settings:
                        buttonSettings.BackgroundImage = null;
                        break;

                    case (int)FormType.Help:
                        buttonHelp.BackgroundImage = null;
                        break;

                    case (int)FormType.Info:
                        buttonInfo.BackgroundImage = null;
                        break;
                }
                actualButton = -1;
                isMinimized = true;

                notifyIcon.BalloonTipTitle = "Informacja";
                notifyIcon.BalloonTipText = "Program Terminarz nadal działa w tle.";
                notifyIcon.ShowBalloonTip(30000);
                notifyIcon.BalloonTipTitle = "Przypomnienie";
            }
            else Utilities.LoginAddr.Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && UserClose == true)
            {
                e.Cancel = true;
                pictureClose_Click(null, null);
            }
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isMinimized)
            {
                this.Show();
                formChoose(FormType.Events);
                isMinimized = false;
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.LoginAddr.Close();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                otworzToolStripMenuItem_Click(null, null);
            }
        }

        public void GroupsRefresh()
        {
            if (actualButton == (int)FormType.Groups)
            {
                actualForm.Close();
                actualButton = -1;
                formChoose(FormType.Groups);
            }
        }
    }
}
