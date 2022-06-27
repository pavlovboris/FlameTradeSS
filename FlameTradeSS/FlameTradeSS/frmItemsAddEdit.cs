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
    public partial class frmItemsAddEdit : Form
    {
        public frmItemsAddEdit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(CommonTasks.SendWarningMsg("Незапазените промени няма да бъдат отразени, искате ли да затворите?")==true)
            {
                Close();
            }
            
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

        private static SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmItemsAddEdit_Paint(object sender, PaintEventArgs e)
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
        public Items newItem;
        private void frmItemsAddEdit_Load(object sender, EventArgs e)
        {
            itemsBindingSource.DataSource = newItem;
            if(newItem.ID==0)
            {
                db.Items.Add(newItem);
            }

            itemCategoryBindingSource.DataSource = db.ItemCategory.ToList();
            itemsGroupsBindingSource.DataSource = db.ItemsGroups.ToList();
            muBindingSource.DataSource = db.Mu.ToList();
            partitionsBindingSource.DataSource = db.Partitions.ToList();
            surfacesBindingSource.DataSource = db.Surfaces.ToList();

            List < Partners > suppliers = new List<Partners>();
            foreach (Suppliers isSupplier in db.Suppliers)
            {
                suppliers.Add(db.Partners.Where(p => p.ID == isSupplier.PartnerID).SingleOrDefault());
            }

            partnersBindingSource.DataSource = suppliers;
          
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CommonTasks.SendWarningMsg("Искате ли да запаметите?")==true)
            {
                try
                {
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените бяха запаметени успешно");
                } catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени! \n" + ex.InnerException.Message);
                }
            }
        }
    }
}
