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
    public partial class EventAddType : Form
    {
        private EventsForm baseForm;
        private List<permissionClass> permissionList;
        public EventAddType(EventsForm addr, List<permissionClass> list)
        {
            InitializeComponent();

            this.baseForm = addr;
            this.permissionList = list;

            typeComboBox.SelectedItem = typeComboBox.Items[0];
            foreach(permissionClass p in permissionList)
            {
                typeComboBox.Items.Add("Grupa: " + p.GroupName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            EventAdd tmp;
            if (typeComboBox.SelectedIndex == 0)
            {
                tmp = new EventAdd(baseForm, "Osobiste", null, Utilities.UserId);
            }
            else
            {
                int tmpIndex = typeComboBox.SelectedIndex - 1;
                int groupId = permissionList[tmpIndex].GroupId;
                string groupName = permissionList[tmpIndex].GroupName;
                tmp = new EventAdd(baseForm, "Grupowe", groupName, groupId);
            }
            tmp.ShowDialog(this);
        }
    }
}
