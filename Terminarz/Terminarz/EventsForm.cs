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
using System.Windows.Media.TextFormatting;

namespace Terminarz
{
    public partial class EventsForm : Form
    {
        private List<EventClass> eventsList;
        private List<permissionClass> permissionList;

        public List<EventClass> EventsList { get { return eventsList; } }

        public EventsForm()
        {
            InitializeComponent();

            timer_Tick(null, null);
            modeComboBox.SelectedItem = modeComboBox.Items[0];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.labelDate.Text = now.ToShortDateString();
            this.labelTime.Text = now.ToLongTimeString();
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(modeComboBox.SelectedIndex)
            {
                case 0: //Today
                    dateTimePicker1.Value = DateTime.Now;
                    labelDateSelect1.Visible = false;
                    labelDateSelect2.Visible = false;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Visible = false;
                    EventsShow();
                    break;

                case 1: //Future
                    dateTimePicker1.Value = DateTime.Now;
                    labelDateSelect1.Visible = false;
                    labelDateSelect2.Visible = false;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Visible = false;
                    EventsShow();
                    break;

                case 2: //Specific date
                    dateTimePicker2.Visible = false;
                    labelDateSelect2.Visible = false;
                    dateTimePicker1.Value = DateTime.Now;
                    labelDateSelect1.Text = "Data:";
                    labelDateSelect1.Visible = true;
                    dateTimePicker1.Visible = true;
                    break;

                case 3: //Specific period of time
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                    labelDateSelect1.Text = "Od:";
                    labelDateSelect1.Visible = true;
                    labelDateSelect2.Visible = true;
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (modeComboBox.SelectedIndex == 2 || modeComboBox.SelectedIndex == 3) EventsShow();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (modeComboBox.SelectedIndex == 3) EventsShow();
        }

        public void EventsShow()
        {
            DateTime now = DateTime.Now;
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            DateTime tmp1, tmp2;

            switch(modeComboBox.SelectedIndex)
            {
                case 0: //Today
                    start = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
                    end = new DateTime (now.Year, now.Month, now.Day, 23, 59, 59);
                    break;

                case 1: //Future
                    start = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                    break;

                case 2: //Specific date
                    tmp1 = dateTimePicker1.Value;
                    start = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, 0, 0, 0);
                    end = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, 23, 59, 59);
                    break;

                case 3: //Specific period of time
                    tmp1 = dateTimePicker1.Value;
                    tmp2 = dateTimePicker2.Value;
                    start = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, 0, 0, 0);
                    end = new DateTime(tmp2.Year, tmp2.Month, tmp2.Day, 23, 59, 59);
                    break;
            }

            string cmdTime;
            if (modeComboBox.SelectedIndex == 1)
            {
                start = start.ToUniversalTime();
                string tmpString = string.Format("'{0}.{1}.{2} {3}:{4} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM'", start.Day.ToString("D2"), start.Month.ToString("D2"), start.Year, start.Hour.ToString("D2"), start.Minute.ToString("D2"));
                cmdTime = string.Format("e.event_date >= TO_TIMESTAMP_TZ({0})", tmpString);
            }
            else 
            {
                start = start.ToUniversalTime();
                end = end.ToUniversalTime();
                string tmpString1 = string.Format("'{0}.{1}.{2} {3}:{4} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM'", start.Day.ToString("D2"), start.Month.ToString("D2"), start.Year, start.Hour.ToString("D2"), start.Minute.ToString("D2"));
                string tmpString2 = string.Format("'{0}.{1}.{2} {3}:{4} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM'", end.Day.ToString("D2"), end.Month.ToString("D2"), end.Year, end.Hour.ToString("D2"), end.Minute.ToString("D2"));
                cmdTime = string.Format("e.event_date >= TO_TIMESTAMP_TZ({0}) AND e.event_date <= TO_TIMESTAMP_TZ({1})", tmpString1, tmpString2);
            }

            string cmd = string.Format("SELECT e.event_name, e.event_date, e.event_type, g.group_name, e.event_id, e.group_id, e.description FROM project_events e LEFT OUTER JOIN project_groups g ON e.group_id = g.group_id WHERE {0} AND (e.user_id = {1} OR e.group_id IN (SELECT group_id FROM project_membership WHERE user_id = {1})) ORDER BY e.event_date ASC", cmdTime, Utilities.UserId);
            OracleDataReader reader = Utilities.QueryResult(cmd);
            eventsList = new List<EventClass>();
            try
            {
                while (reader.Read())
                {
                    EventClass tmp;
                    if (reader.GetString(2).Equals("user"))
                    {
                        tmp = new EventClass(reader.GetString(0), reader.GetDateTimeOffset(1).ToLocalTime().DateTime, reader.GetInt32(4), reader.GetString(6));
                    }
                    else
                    {
                        tmp = new EventClass(reader.GetString(0), reader.GetDateTimeOffset(1).ToLocalTime().DateTime, reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6));
                    }
                    eventsList.Add(tmp);
                }

                string permissionCmd = string.Format("SELECT m.group_id, m.edit_permission, g.group_name FROM project_membership m JOIN project_groups g ON m.group_id = g.group_id WHERE m.user_id = {0} AND m.edit_permission IN('admin', 'edit')", Utilities.UserId);
                OracleDataReader permissionReader = Utilities.QueryResult(permissionCmd);
                permissionList = new List<permissionClass>();
                while(permissionReader.Read())
                {
                    permissionClass tmp = new permissionClass(permissionReader.GetInt32(0), permissionReader.GetString(1), permissionReader.GetString(2));
                    permissionList.Add(tmp);
                }
            }
            catch(Exception exc)
            {
                Utilities.MainWindowAddr.loadFailded();
            }

            listViewEvents.SelectedItems.Clear();
            listViewEvents.Items.Clear();

            foreach (EventClass ev in eventsList)
            {
                ListViewItem tmp = listViewEvents.Items.Add(ev.EventName);
                tmp.SubItems.Add(ev.EventDate.ToShortTimeString());
                tmp.SubItems.Add(ev.EventDate.ToShortDateString());
                tmp.SubItems.Add(ev.EventType);
                tmp.SubItems.Add(ev.GroupName);
                tmp.SubItems.Add(ev.EventId.ToString());
                tmp.SubItems.Add(ev.GroupId.ToString());
                tmp.SubItems.Add(ev.Desc);
            }
        }

        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewEvents.SelectedIndices.Count != 0)
            {
                buttonDesc.Enabled = true;
                buttonDesc.Visible = true;

                bool canEdit = false;
                if (listViewEvents.SelectedItems[0].SubItems[3].Text.Equals("Osobiste")) canEdit = true;
                else
                {
                    int groupId = Int32.Parse(listViewEvents.SelectedItems[0].SubItems[6].Text);
                    foreach(permissionClass p in permissionList)
                    {
                        if (groupId == p.GroupId) canEdit = true;
                    }
                }

                if(canEdit)
                {
                    buttonEdit.Enabled = true;
                    buttonEdit.Visible = true;
                    buttonDelete.Enabled = true;
                    buttonDelete.Visible = true;
                }
            }
            else
            {
                buttonDesc.Enabled = false;
                buttonDesc.Visible = false;
                buttonEdit.Enabled = false;
                buttonEdit.Visible = false;
                buttonDelete.Enabled = false;
                buttonDelete.Visible = false;
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            EventAddType tmp = new EventAddType(this, permissionList);
            tmp.ShowDialog(this);
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            int tmpIndex = listViewEvents.SelectedItems[0].Index;
            EventAdd tmp = new EventAdd(eventsList[tmpIndex]);
            tmp.ShowDialog(this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int tmpIndex = listViewEvents.SelectedItems[0].Index;
            EventAdd tmp = new EventAdd(this, eventsList[tmpIndex]);
            tmp.ShowDialog(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string title = "Potwierdzenie";
            string text = "Czy na pewno chcesz trwale usunąć to wydarzenie?";
            DialogResult confirm = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string eventId = listViewEvents.SelectedItems[0].SubItems[5].Text;
                string cmd = string.Format("DELETE FROM project_events WHERE event_id = {0}", eventId);
                List<string> cmdList = new List<string>();
                cmdList.Add(cmd);
                bool result = Utilities.dmlOperation(cmdList);
                if (result) EventsShow();
            }
        }
    }
}
