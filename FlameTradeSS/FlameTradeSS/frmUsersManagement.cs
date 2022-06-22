using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FlameTradeSS
{
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
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


        private static readonly SecurityService securityService = new SecurityService();   
        static FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (CurrentSessionData.CurrentUser.RoleID!=1)
            {
                usersBindingSource.DataSource = db.Users.Where(u=> u.RoleID!=1).ToList();
            } else
            {
                usersBindingSource.DataSource = db.Users.ToList();
            }
 
            rolesBindingSource.DataSource = db.Roles.ToList();
            personsFullNameViewBindingSource.DataSource = db.PersonsFullNameView.ToList();

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvUsers, Name + dgvUsers.Name + CurrentSessionData.CurrentUser.UserName);

            } catch { }


        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == passwordDataGridViewTextBoxColumn.Index)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users newUsers = new Users();
            usersBindingSource.Add(newUsers);
            usersBindingSource.MoveLast();
            db.Users.Add(newUsers);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите всички промени?")==true)
            {
                try
                {
                    usersBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените са запаметени успешно");
                } catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Нещо се обърка, промените НЕ бяха запаметени!!!");
                    if(CommonTasks.SendWarningMsg("Искате ли да разгледате детайлите на грешката?")==true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }
                
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Users userForRemoving = dgvUsers.CurrentRow.DataBoundItem as Users;
            if (CommonTasks.SendWarningMsg("Сугурни ли сте, че искате да маркираният потребител : "+userForRemoving.UserName+"?")==true)
            {
                usersBindingSource.Remove(userForRemoving);
                db.Users.Remove(userForRemoving);
            }            
        }

        private void dgvUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3 & e.RowIndex!=-1)
            {
                if (CurrentSessionData.CurrentUser.RoleID!=1)
                {
                    if ((int)dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==1)
                    {
                        dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =2;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUsersManagement_Paint(object sender, PaintEventArgs e)
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

        private void frmUsersManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommonTasks.WriteGrideViewSetting(dgvUsers, Name + dgvUsers.Name + CurrentSessionData.CurrentUser.UserName);
        }
    }
}
