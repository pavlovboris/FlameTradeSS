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
    public partial class frmRolesOfPersons : Form
    {
        public frmRolesOfPersons()
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

        private void frmRolesOfPersons_Load(object sender, EventArgs e)
        {
            roleOfPersonsBindingSource.DataSource = db.RoleOfPersons.ToList();
        }

        private void frmRolesOfPersons_Paint(object sender, PaintEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoleOfPersons roleOfPersons = new RoleOfPersons();
            roleOfPersonsBindingSource.Add(roleOfPersons);
            roleOfPersonsBindingSource.MoveLast();
            db.RoleOfPersons.Add(roleOfPersons);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите промените") == true)
            {
                try
                {
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените са запазени успешно");
                }
                catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени!!! \n Ако сте премахнали функция, възможно е тя да е присвоена на Роля и за това да не може да бъде изтрита");
                    if (CommonTasks.SendWarningMsg("Искате ли да видите детайлите") == true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RoleOfPersons roleOfPersons = dgvRolesOfPersons.CurrentRow.DataBoundItem as RoleOfPersons;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : " + roleOfPersons.RoleName + "?") == true)
            {
                if (dgvRolesOfPersons.CurrentRow.Index != -1)
                {
                    if (roleOfPersons != null)
                    {
                        roleOfPersonsBindingSource.EndEdit();
                        roleOfPersonsBindingSource.Remove(roleOfPersons);
                        db.RoleOfPersons.Remove(roleOfPersons);
                    }
                }
            }
        }
    }
}
