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
    public partial class frmItemsGroups : Form
    {
        public frmItemsGroups()
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

        private void frmPartnerGroups_Paint(object sender, PaintEventArgs e)
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

        private static readonly SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            itemsGroupsBindingSource.DataSource = db.ItemsGroups.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemsGroups newItemGroup = new ItemsGroups();
            itemsGroupsBindingSource.Add(newItemGroup);
            itemsGroupsBindingSource.MoveLast();
            db.ItemsGroups.Add(newItemGroup);
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
                    CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени!!!");
                    if (CommonTasks.SendWarningMsg("Искате ли да видите детайлите") == true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ItemsGroups itemGroups= dgvItemGroups.CurrentRow.DataBoundItem as ItemsGroups;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : " + itemGroups.GroupName + "?") == true)
            {
                if (dgvItemGroups.CurrentRow.Index != -1)
                {
                    if (itemGroups != null)
                    {
                        itemsGroupsBindingSource.Remove(itemGroups);
                        db.ItemsGroups.Remove(itemGroups);
                    }
                }
            }
        }
    }
}
