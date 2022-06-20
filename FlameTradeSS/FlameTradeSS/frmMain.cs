using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        private static bool isLogout = false; 

        private const int cGrip = 10;      // Grip size
        private const int cCaption = 300;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            // rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //  e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

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
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogout==false)
            {
                CommonTasks.ExitApplication();
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (CurrentSessionData.CurrentUser!=null)
            {
                lblCurrentUserName.Text = CurrentSessionData.CurrentUser.UserName.ToString();
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                
            } else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnAdminTools_Click(object sender, EventArgs e)
        {
            frmAdminTools adminTools = new frmAdminTools();
            adminTools.Show();
        }
    }
}
