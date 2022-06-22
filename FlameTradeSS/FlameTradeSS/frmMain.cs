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

       // private static bool isLogout = false; 

        private const int cGrip = 10;      // Grip size
        private const int cCaption = 600;   // Caption bar height;

      /*  protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            // rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //  e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                            // call a member of the graphics class
           // g.DrawLine(p,2,2, Size.Width-4,2);
            //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2,2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);
        }*/

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
            
                //.ExitApplication();
            
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            CommonTasks.ExitApplication();
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
            CommonTasks.OpenForm(adminTools);
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            if(CommonTasks.SendWarningMsg(CurrentSessionData.CurrentUser.UserName.ToString()+" сигурни ли сте, че искате да излезете?") == true) 
            {
                //isLogout = true;
                
                FormClosed -= frmMain_FormClosed;
                this.Close();
                SecurityService securityService = new SecurityService();
                securityService.userLogOut();
                frmLogin.Instance.Show();
                frmLogin.Instance.txtPassword.Text = "";
                List<Form> forms = new List<Form>();
                
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name != "frmLogin" && frm.Name != "frmMain")
                    {
                        forms.Add(frm);
                    }
                }

                foreach (Form frm in forms)
                {
                    frm.Close();
                }
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            // rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //  e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);
        }

        private void btnPartnersMng_Click(object sender, EventArgs e)
        {
            frmPartners frmPartners = new frmPartners();
            CommonTasks.OpenForm(frmPartners);
        }

        private void treeViewPartners_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "PartnerGroup":
                    frmPartnerGroups frmPartnerGroups = new frmPartnerGroups();
                    CommonTasks.OpenForm(frmPartnerGroups);
                    break;
                case "PartnerCategory":
                    frmPartnerCategory frmPartnerCategory = new frmPartnerCategory();
                    CommonTasks.OpenForm(frmPartnerCategory);
                    break;
                case "PartnerStaticPriceGroup":
                    CommonTasks.SendInfoMsg("works - Price groups");
                    break;
                case "PersonPartners":
                    frmPartnersPersons frmPartnersPersons = new frmPartnersPersons();
                    CommonTasks.OpenForm(frmPartnersPersons);
                    break;


            }
        }
    }
}
