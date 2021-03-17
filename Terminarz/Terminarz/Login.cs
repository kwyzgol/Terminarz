using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Terminarz
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point cursorLocation;
        private Point formLocation;

        public LoginWPF LoginWPFAddr { get; set; }
        public RegisterWPF RegisterWPFAddr { get; set; }

        public Login()
        {
            InitializeComponent();

            LoginWPFAddr = new LoginWPF();
            RegisterWPFAddr = new RegisterWPF();
            loginLoadWPF.Child = LoginWPFAddr;
        }

        public void moveStart()
        {
            dragging = true;
            cursorLocation = Cursor.Position;
            formLocation = this.Location;
        }

        public void moveUpdate()
        {
            if(dragging)
            {
                Point moveValue = Point.Subtract(Cursor.Position, new Size(cursorLocation));
                this.Location = Point.Add(formLocation, new Size(moveValue));
            }
        }

        public void moveStop()
        {
            dragging = false;
        }

        public void goRegistration()
        {
            this.loginLoadWPF.Child = RegisterWPFAddr;
        }

        public void goLogin()
        {
            this.loginLoadWPF.Child = LoginWPFAddr;
        }
    }
}
