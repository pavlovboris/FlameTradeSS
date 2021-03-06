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
    public partial class frmItemsParameters : Form
    {
        public frmItemsParameters()
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

        private void frmPartners_Paint(object sender, PaintEventArgs e)
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
        public FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Items item;

        private void frmPartners_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
            itemsParametersBindingSource.DataSource = db.ItemsParameters.ToList();

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvItemsParameters, Name + dgvItemsParameters.Name + CurrentSessionData.CurrentUser.UserName);
            } catch
            {

            }

            //CommonTasks.RestoreForm(this, Properties.Settings.Default.frmPartnersSize, Properties.Settings.Default.frmPartnersState, Properties.Settings.Default.frmPartnersLocation);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemsParameters newItemParameters = new ItemsParameters();
           
            itemsParametersBindingSource.Add(newItemParameters);
            itemsParametersBindingSource.MoveLast();
            db.ItemsParameters.Add(newItemParameters);
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
            ItemsParameters itemsParameters = dgvItemsParameters.CurrentRow.DataBoundItem as ItemsParameters;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраният модел за рецепта: " + itemsParameters.ParameterName + "?") == true)
            {
                if (dgvItemsParameters.CurrentRow.Index != -1)
                {
                    if (itemsParameters != null)
                    {
                        itemsParametersBindingSource.Remove(itemsParameters);
                        db.ItemsParameters.Remove(itemsParameters);
                    }
                }
            }
        }


        private void frmPartners_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* try
            {
                CommonTasks.WriteGrideViewSetting(dgvItemsParametersItems, Name + dgvItemsParametersItems.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }*/

          /*  Properties.Settings.Default.frmPartnersState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmPartnersLocation = this.Location;
                Properties.Settings.Default.frmPartnersSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmPartnersLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmPartnersSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();*/
        }

        private void contextMenuDgv_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuDgv_Opening(object sender, CancelEventArgs e)
        {
          /*  if (dgvReceiptModels.CurrentCell.ColumnIndex== -1 )
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            }

            if (dgvReceiptModels.CurrentRow != null && dgvReceiptModels.CurrentRow.Index != -1)
            {
                Partners selectedPartner = dgvReceiptModels.CurrentRow.DataBoundItem as Partners;

                Customers isCustomer = db.Customers.Where(c => c.PartnerID == selectedPartner.ID).SingleOrDefault();
                Suppliers isSupplier = db.Suppliers.Where(s => s.PartnerID == selectedPartner.ID).SingleOrDefault();

                ToolStripMenuItem customer = new ToolStripMenuItem();
                ToolStripMenuItem supplier = new ToolStripMenuItem();


                if (isCustomer!=null)
                {
                    customer.Text = "Премахни от КЛИЕНТИ";

                    customer.Click += Customer_RemoveClick;
                } else
                {
                    customer.Text = "Добави към КЛИЕНТИ";

                    customer.Click += Customer_AddClick;
                }

                if (isSupplier != null)
                {
                    supplier.Text = "Премахни от ДОСТАВЧИЦИ";

                    supplier.Click += Supplier_RemoveClick;
                } else
                {
                    supplier.Text = "Добави към ДОСТАВЧИЦИ";

                    supplier.Click += Supplier_AddClick;
                }

                contextMenuDgv.Items.Add(supplier);
                contextMenuDgv.Items.Add(customer);
            }*/
        }

        private async void Supplier_AddClick(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            Partners partners = dgvItemsParameters.CurrentRow.DataBoundItem as Partners;

            if (partners != null)
            {
                try
                {
                    suppliers.PartnerID = partners.ID;
                    db.Suppliers.Add(suppliers);
                    await db.SaveChangesAsync();
                }
                catch { CommonTasks.SendErrorMsg("Партньора не е добавен!!!"); }

            }
        }

        private async void Supplier_RemoveClick(object sender, EventArgs e)
        {
            Partners partners = dgvItemsParameters.CurrentRow.DataBoundItem as Partners;

            if (partners != null)
            {
                try
                {
                    Suppliers suppliers = db.Suppliers.Where(s => s.PartnerID == partners.ID).SingleOrDefault();

                    if (suppliers != null)
                    {
                        db.Suppliers.Remove(suppliers);
                        await db.SaveChangesAsync();
                    }
                }
                catch { CommonTasks.SendErrorMsg("Партньора не е премахнат!!!"); }
            }
        }

        private async void Customer_RemoveClick(object sender, EventArgs e)
        {
            Partners partners = dgvItemsParameters.CurrentRow.DataBoundItem as Partners;

            if (partners != null)
            {
                try
                {
                    Customers customers = db.Customers.Where(c => c.PartnerID == partners.ID).SingleOrDefault();

                    if (customers!=null)
                    {
                        db.Customers.Remove(customers);
                        await db.SaveChangesAsync();
                    }
                } catch { CommonTasks.SendErrorMsg("Партньора не е премахнат!!!"); }
            }
        }

        private async  void Customer_AddClick(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            Partners partners = dgvItemsParameters.CurrentRow.DataBoundItem as Partners;

            if (partners!=null)
            {
                try
                {
                    customers.PartnerID = partners.ID;
                    db.Customers.Add(customers);
                    await db.SaveChangesAsync();
                }
                catch { CommonTasks.SendErrorMsg("Партньора не е добавен!!!"); }
                
            }
        }

        private  void contextMenuDgv_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            contextMenuDgv.Items.Clear();
        }

        private void dgvPartners_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                if (e.RowIndex != -1 && dgvItemsParameters.Rows[e.RowIndex].DataBoundItem != null)
                {
                    dgvItemsParameters.CurrentCell = dgvItemsParameters.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvItemsParameters.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
          /*  if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                itemsParametersBindingSource.DataSource = db.ItemsParametersItems.Where(p => p.ModelName.Contains(txtFilter.Text)).ToList();
            } else
            {
                receiptModelsBindingSource.DataSource = db.ReceiptModels.ToList();
            }*/
        }
    }
}
