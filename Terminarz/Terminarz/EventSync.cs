using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Terminarz
{
    class EventSync
    {
        private string name;
        private DateTime date;

        public EventSync(string name, DateTimeOffset date)
        {
            this.name = name;
            this.date = date.ToLocalTime().DateTime;
        }

        public bool Equals(DateTime compareValue, int timeDifference)
        {
            compareValue = compareValue.AddMinutes(timeDifference);
            bool dateCompere = this.date.ToShortDateString().Equals(compareValue.ToShortDateString());
            bool timeCompare = this.date.ToShortTimeString().Equals(compareValue.ToShortTimeString());

            if (dateCompere && timeCompare) return true;
            else return false;
        }

        public void Notify(string type)
        {
            if (type.Equals("BalloonTip"))
            {
                string text = string.Format("Przypomnienie o wydarzeniu: {0}\nData wydarzenia: {1}\nGodzina: {2}", this.name, this.date.ToShortDateString(), this.date.ToShortTimeString());
                Utilities.MainWindowAddr.notifyIcon.BalloonTipText = text;
                Utilities.MainWindowAddr.notifyIcon.ShowBalloonTip(30000);
            }

            if (type.Equals("MessageBox")) 
            {
                string text = string.Format("Przypomnienie o wydarzeniu: {0}\nData wydarzenia: {1}\nGodzina: {2}", this.name, this.date.ToShortDateString(), this.date.ToShortTimeString());
                System.Windows.Forms.MessageBox.Show(text, "Przypomnienie");
            }
        }
    }
}
