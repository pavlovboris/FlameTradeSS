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
    public partial class frmRolesFunctions : Form
    {
        public frmRolesFunctions()
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


        static SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmRolesFunctions_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (CurrentSessionData.CurrentUser.RoleID==1)
            {
                rolesBindingSource.DataSource = db.Roles.ToList();
            } else
            {
                rolesBindingSource.DataSource = db.Roles.Where(r=> r.RoleID!=1).ToList();
            }

            functionsBindingSource.DataSource = db.Functions.ToList();

            Roles selectedRole = cmbRoles.SelectedItem as Roles;
            if (selectedRole!=null)
            {
                functionRolesBindingSource.DataSource = db.FunctionRoles.Where(r => r.RoleID == selectedRole.RoleID).ToList();
            }
        }

        private void cmbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Roles selectedRole = cmbRoles.SelectedItem as Roles;

            if (selectedRole!=null)
            {
                functionRolesBindingSource.DataSource = db.FunctionRoles.Where(r => r.RoleID == selectedRole.RoleID).ToList();
            }
        }

        private async void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (functionRolesBindingSource.DataSource!=null)
            {
                Roles selectedRole = cmbRoles.SelectedItem as Roles;
                if (selectedRole!=null)
                {
                    foreach(DataGridViewRow dgvr in dgvLeft.SelectedRows)
                    {
                        Functions f = dgvr.DataBoundItem as Functions;
                        if (f!=null)
                        {
                            FunctionRoles fr = db.FunctionRoles.Where(p=> p.FunctionID==f.ID && p.RoleID==selectedRole.RoleID).SingleOrDefault();
                            if (fr==null)
                            {
                                FunctionRoles frr = new FunctionRoles() { RoleID = selectedRole.RoleID, FunctionID=f.ID };
                                db.FunctionRoles.Add(frr);
                            }
                        }
                    }
                    await db.SaveChangesAsync();
                    functionRolesBindingSource.DataSource = db.FunctionRoles.Where(r => r.RoleID == selectedRole.RoleID).ToList();
                }
            }
        }

        private async void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (functionRolesBindingSource.DataSource!=null)
            {
                Roles selectedRole = cmbRoles.SelectedItem as Roles;
                if (selectedRole!=null)
                {
                    foreach(DataGridViewRow dgvr in dgvRight.SelectedRows)
                    {
                        FunctionRoles fr = dgvr.DataBoundItem as FunctionRoles;
                        if (fr!=null)
                        {
                            db.FunctionRoles.Remove(fr);
                            functionRolesBindingSource.Remove(fr);
                        }
                    }
                    await db.SaveChangesAsync();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRolesFunctions_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);
        }
    }
}
