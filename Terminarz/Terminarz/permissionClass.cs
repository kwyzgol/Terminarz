using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminarz
{
    public class permissionClass
    {
        public int GroupId { get; }
        public string EditPermission { get; }
        public string GroupName { get; }

        public permissionClass(int groupId, string editPermission, string groupName)
        {
            this.GroupId = groupId;
            this.EditPermission = editPermission;
            this.GroupName = groupName;
        }
    }
}
