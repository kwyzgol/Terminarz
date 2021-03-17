using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminarz
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            switch(Utilities.MainWindowAddr.AlarmEnable)
            {
                case true:
                    alarmComboBox.SelectedIndex = 0;
                    break;

                case false:
                    alarmComboBox.SelectedIndex = 1;
                    break;
            }

            switch(Utilities.MainWindowAddr.AlarmType)
            {
                case "BalloonTip":
                    typeComboBox.SelectedIndex = 0;
                    break;

                case "MessageBox":
                    typeComboBox.SelectedIndex = 1;
                    break;
            }

            switch(Utilities.MainWindowAddr.AlarmTime)
            {
                case 15:
                    timeComboBox.SelectedIndex = 0;
                    break;

                case 5:
                    timeComboBox.SelectedIndex = 1;
                    break;

                case 60:
                    timeComboBox.SelectedIndex = 2;
                    break;

                case 1440:
                    timeComboBox.SelectedIndex = 3;
                    break;

                case 10080:
                    timeComboBox.SelectedIndex = 4;
                    break;

                case 0:
                    timeComboBox.SelectedIndex = 5;
                    break;
            }

            switch(Utilities.MainWindowAddr.MinimizeEnable)
            {
                case true:
                    closeComboBox.SelectedIndex = 0;
                    break;

                case false:
                    closeComboBox.SelectedIndex = 1;
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string close = "", alarm = "", type = "";
            int time = 0;

            bool canUpdate = false;

            switch (closeComboBox.SelectedIndex)
            {
                case 0:
                    close = "yes";
                    break;

                case 1:
                    close = "no";
                    break;
            }

            switch (alarmComboBox.SelectedIndex)
            {
                case 0:
                    alarm = "yes";
                    break;

                case 1:
                    alarm = "no";
                    break;
            }

            switch (typeComboBox.SelectedIndex)
            {
                case 0:
                    type = "BalloonTip";
                    break;

                case 1:
                    type = "MessageBox";
                    break;
            }

            switch (timeComboBox.SelectedIndex)
            {
                case 0:
                    time = 15;
                    break;

                case 1:
                    time = 5;
                    break;

                case 2:
                    time = 60;
                    break;

                case 3:
                    time = 1440;
                    break;

                case 4:
                    time = 10080;
                    break;

                case 5:
                    time = 0;
                    break;
            }

            string cmd = string.Format("UPDATE project_settings SET minimize_enable = '{0}', alarm_enable = '{1}', alarm_type = '{2}', alarm_time = {3} WHERE user_id = {4}", close, alarm, type, time, Utilities.UserId);
            List<string> cmdList = new List<string>();
            cmdList.Add(cmd);
            canUpdate = Utilities.dmlOperation(cmdList);

            if(canUpdate)
            {
                Utilities.MainWindowAddr.settingsLoad();

                if (Utilities.MainWindowAddr.AlarmEnable)
                {
                    Utilities.MainWindowAddr.timerSync_Tick(null, null);
                    Utilities.MainWindowAddr.timerSync.Enabled = true;
                    Utilities.MainWindowAddr.timerCheck.Enabled = true;
                }
                else
                {
                    Utilities.MainWindowAddr.timerSync.Enabled = false;
                    Utilities.MainWindowAddr.timerCheck.Enabled = false;
                }
            }
        }
    }
}
