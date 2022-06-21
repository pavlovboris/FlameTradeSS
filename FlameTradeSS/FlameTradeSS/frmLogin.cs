using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlameTradeSS.SecurityService;

namespace FlameTradeSS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private const int cCaption = 300;   // Caption bar height;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private static frmLogin _instance;

        public Users UserInfo { get; set; }

        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }
        }
       
        public static SecurityService securityService = new SecurityService();

        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            CommonTasks.ExitApplication();
        }

        private bool draging = false;
        private Point pointClicked;
        private void pictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;
            }
        }

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                draging = false;
            }
        }

        private void pictureBoxLogo_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
        }

        private  void pictureBoxLogIn_Click(object sender, EventArgs e)
        {
            Users result = securityService.LoggedUser(db, txtUserName.Text, txtPassword.Text);

            if (result != null)
            {
                UserInfo = result;
                frmMain frmMain = new frmMain();
                CurrentSessionData.CurrentfrmMain = frmMain;
                frmMain.Show();
                Hide();

            }
            else
            {
                CommonTasks.SendErrorMsg("Потребителското име или паролата са изписани грешно, моля опитайте отново");
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode != Keys.Enter)
            {
            } else if (e.KeyCode==Keys.Enter & txtPassword.Text!="")
            {
                pictureBoxLogIn_Click(sender, e);   
            } else
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
            } else if (e.KeyCode==Keys.Enter & txtUserName.Text!="")
            {
                pictureBoxLogIn_Click(sender, e);
            } else
            {
                txtUserName.Focus();
            }
        }
    }
}
