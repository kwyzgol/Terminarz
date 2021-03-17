using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminarz
{
    public class GroupButton : Button
    {
        public int GroupId{ get; }

        public GroupButton(int groupId, string name) : base() 
        {
            this.BackColor = System.Drawing.Color.White;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Size = new System.Drawing.Size(151, 34);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = false;
            this.AutoEllipsis = true;

            this.Text = name;
            this.GroupId = groupId;
        }
    }
}
