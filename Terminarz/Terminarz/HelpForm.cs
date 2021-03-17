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
    public partial class HelpForm : Form
    {
        private List<string> videoId;

        public HelpForm()
        {
            InitializeComponent();

            videoId = new List<string>();
            videoId.Add("KfEJOE9pSkI");
            videoId.Add("KfEJOE9pSkI");
            videoId.Add("KfEJOE9pSkI");
            videoId.Add("KfEJOE9pSkI");
            videoId.Add("KfEJOE9pSkI");

            topicComboBox.SelectedIndex = 0;
        }

        private void topicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser.Visible = true;
            ShowVideo(videoId[topicComboBox.SelectedIndex]);
        }

        private void ShowVideo(string videoId)
        {
            string htmlCode =
                "<html>" +
                        "<head>" +
                                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head>" +
                        "<body style =\"background-color:#f0f0f0;\">" +
                                "<iframe width = \"528\" height = \"297\" src = \"https://www.youtube.com/embed/{0}\" frameborder = \"0\" allow = \"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\"></iframe>" +
                        "</body>" +
                "</html>";

            webBrowser.DocumentText = string.Format(htmlCode, videoId);
        }
    }
}
