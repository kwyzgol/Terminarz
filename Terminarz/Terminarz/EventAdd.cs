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
    public partial class EventAdd : Form
    {
        private enum FormMode
        {
            AddMode,
            EditMode,
            DescMode
        }

        private EventsForm baseForm;
        private string type;
        private string groupName;
        private int id;
        private FormMode mode;

        public EventAdd(EventsForm addr, string type, string groupName, int id) //AddMode
        {
            InitializeComponent();

            this.baseForm = addr;
            this.type = type;
            this.groupName = groupName;
            this.id = id;
            this.mode = FormMode.AddMode;

            dateTimePicker.Value = baseForm.dateTimePicker1.Value;
            DateTime now = DateTime.Now;
            hourComboBox.SelectedIndex = now.Hour;
            minuteComboBox.SelectedIndex = now.Minute;
            labelType.Text = type;
            if (groupName != null)
            {
                labelGroup.Text = groupName;
            }
            else 
            {
                labelGroupTitle.Text = null;
                labelGroup.Text = null;
            }
        }

        public EventAdd(EventsForm addr, EventClass eventInfo)  //EditMode
        {
            InitializeComponent();

            this.baseForm = addr;
            this.type = eventInfo.EventType;
            this.groupName = eventInfo.GroupName;
            this.id = eventInfo.EventId;
            this.mode = FormMode.EditMode;

            this.Text = "Edycja wydarzenia";
            labelTitle.Text = "Edycja wydarzenia";
            buttonAdd.Text = "Zapisz";
            textBoxName.Text = eventInfo.EventName;
            dateTimePicker.Value = eventInfo.EventDate;
            hourComboBox.SelectedIndex = eventInfo.EventDate.Hour;
            minuteComboBox.SelectedIndex = eventInfo.EventDate.Minute;
            descRichTextBox.Text = eventInfo.Desc;

            labelType.Text = type;
            if (groupName.Equals("-"))
            {
                labelGroupTitle.Text = null;
                labelGroup.Text = null;
            }
            else
            {
                labelGroup.Text = groupName;
            }
        }

        public EventAdd(EventClass eventInfo)   //DescMode
        {
            InitializeComponent();

            this.mode = FormMode.DescMode;

            this.Text = "Opis wydarzenia";
            labelTitle.Text = "Opis wydarzenia";
            textBoxName.Text = eventInfo.EventName;
            dateTimePicker.Value = eventInfo.EventDate;
            hourComboBox.SelectedIndex = eventInfo.EventDate.Hour;
            minuteComboBox.SelectedIndex = eventInfo.EventDate.Minute;
            descRichTextBox.Text = eventInfo.Desc;
            buttonCancel.Text = "Zamknij";

            labelType.Text = eventInfo.EventType;
            if (eventInfo.GroupName.Equals("-"))
            {
                labelGroupTitle.Text = null;
                labelGroup.Text = null;
            }
            else
            {
                labelGroup.Text = eventInfo.GroupName;
            }

            buttonAdd.Enabled = false;
            buttonAdd.Visible = false;
            textBoxName.ReadOnly = true;
            dateTimePicker.Enabled = false;
            hourComboBox.Enabled = false;
            minuteComboBox.Enabled = false;
            descRichTextBox.ReadOnly = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mode == FormMode.AddMode) this.Owner.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool status = false;

            if(mode == FormMode.AddMode)
            {
                string idType;
                string tmpType;
                if (type.Equals("Osobiste"))
                {
                    idType = "user_id";
                    tmpType = "user";
                }
                else
                {
                    idType = "group_id";
                    tmpType = "group";
                }
                if (textBoxName.Text == null || textBoxName.Text.Equals("")) textBoxName.Text = " ";
                if (descRichTextBox.Text == null || descRichTextBox.Text.Equals("")) descRichTextBox.Text = " ";
                DateTime eventDate = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, Int32.Parse(hourComboBox.SelectedItem.ToString()), Int32.Parse(minuteComboBox.SelectedItem.ToString()), 0);
                eventDate = eventDate.ToUniversalTime();
                string cmdTime = string.Format("TO_TIMESTAMP_TZ('{0}.{1}.{2} {3}:{4} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM')", eventDate.Day.ToString("D2"), eventDate.Month.ToString("D2"), eventDate.Year, eventDate.Hour.ToString("D2"), eventDate.Minute.ToString("D2"));
                string cmd = string.Format("INSERT INTO project_events(event_id, event_name, event_date, description, event_type, {0}) VALUES(project_events_seq.NEXTVAL, '{1}', {2}, '{3}', '{4}', '{5}')", idType, textBoxName.Text, cmdTime, descRichTextBox.Text, tmpType, this.id);
                List<string> cmdList = new List<string>();
                cmdList.Add(cmd);
                status = Utilities.dmlOperation(cmdList);
                if (status)
                {
                    baseForm.EventsShow();
                    Utilities.MainWindowAddr.timerSync_Tick(null, null);
                }
            }

            if(mode == FormMode.EditMode)
            {
                if (textBoxName.Text == null || textBoxName.Text.Equals("")) textBoxName.Text = " ";
                if (descRichTextBox.Text == null || descRichTextBox.Text.Equals("")) descRichTextBox.Text = " ";
                DateTime eventDate = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, Int32.Parse(hourComboBox.SelectedItem.ToString()), Int32.Parse(minuteComboBox.SelectedItem.ToString()), 0);
                eventDate = eventDate.ToUniversalTime();
                string cmdTime = string.Format("TO_TIMESTAMP_TZ('{0}.{1}.{2} {3}:{4} 00:00', 'fm DD:MM:YYYY HH24:MI TZH:TZM')", eventDate.Day.ToString("D2"), eventDate.Month.ToString("D2"), eventDate.Year, eventDate.Hour.ToString("D2"), eventDate.Minute.ToString("D2"));
                string cmd = string.Format("UPDATE project_events SET event_name = '{0}', event_date = {1}, description = '{2}' WHERE event_id = {3}", textBoxName.Text, cmdTime, descRichTextBox.Text, this.id);
                List<string> cmdList = new List<string>();
                cmdList.Add(cmd);
                status = Utilities.dmlOperation(cmdList);
                if(status)
                {
                    baseForm.EventsShow();
                    Utilities.MainWindowAddr.timerSync_Tick(null, null);
                }
            }

            this.Close();
        }
    }
}
