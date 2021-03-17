using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminarz
{
    public class EventClass
    {
        public string EventName { get; }
        public DateTime EventDate { get; }
        public string EventType { get; }
        public string GroupName { get; }
        public int EventId { get; }
        public int GroupId { get; }
        public string Desc { get; }

        public EventClass(string setEventName, DateTime setEventDate, string setGroupName, int setEventId, int setGroupId, string setDesc)
        {
            this.EventName = setEventName;
            this.EventDate = setEventDate;
            this.EventType = "Grupowe";
            this.GroupName = setGroupName;
            this.EventId = setEventId;
            this.GroupId = setGroupId;
            this.Desc = setDesc;
        }

        public EventClass(string setEventName, DateTime setEventDate, int setEventId, string setDesc)
        {
            this.EventName = setEventName;
            this.EventDate = setEventDate;
            this.EventType = "Osobiste";
            this.GroupName = "-";
            this.EventId = setEventId;
            this.GroupId = -1;
            this.Desc = setDesc;
        }
    }
}
