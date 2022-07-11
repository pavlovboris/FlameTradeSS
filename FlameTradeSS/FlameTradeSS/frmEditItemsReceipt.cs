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
    public partial class frmEditItemsReceipt : Form
    {
        public frmEditItemsReceipt()
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

        public FlameTradeDbEntities db;
        public TransactionReceipt transactionReceipt;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPartners_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvReceiptLines, Name + dgvReceiptLines.Name + CurrentSessionData.CurrentUser.UserName);
            } catch
            {

            }
            if (transactionReceipt.ID!=0)
            {
                receiptLinesBindingSource.DataSource = db.ReceiptLines.Where(rl => rl.TransactionReceiptID == transactionReceipt.ID).ToList();
                itemsBindingSource.DataSource = db.Items.ToList();
                itemsBindingSource.Add(new Items());
                colorsBindingSource.DataSource = db.Colors.ToList();
                colorsBindingSource.Add(new Colors());
                partitionsBindingSource.DataSource = db.Partitions.ToList();
                partitionsBindingSource.Add(new Partitions());
                partitionsBindingSource1.DataSource = db.Partitions.ToList();
                partitionsBindingSource1.Add(new Partitions());
                surfacesBindingSource.DataSource = db.Surfaces.ToList();
                surfacesBindingSource.Add(new Surfaces());
                itemsParametersBindingSource.DataSource = db.ItemsParameters.ToList();
                itemsParametersBindingSource.Add(new ItemsParameters());
            }

            //CommonTasks.RestoreForm(this, Properties.Settings.Default.frmPartnersSize, Properties.Settings.Default.frmPartnersState, Properties.Settings.Default.frmPartnersLocation);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReceiptLines newReceiptLine  = new ReceiptLines();
            receiptLinesBindingSource.Add(newReceiptLine);
            receiptLinesBindingSource.MoveLast();
            db.ReceiptLines.Add(newReceiptLine);
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
            ReceiptLines receiptLines = dgvReceiptLines.CurrentRow.DataBoundItem as ReceiptLines;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраният ред : " + receiptLines.ID + "?") == true)
            {
                if (dgvReceiptLines.CurrentRow.Index != -1)
                {
                    if (receiptLines != null)
                    {
                        receiptLinesBindingSource.Remove(receiptLines);
                        db.ReceiptLines.Remove(receiptLines);
                    }
                }
            }
        }


        private void frmPartners_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvReceiptLines, Name + dgvReceiptLines.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

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
            Properties.Settings.Default.Save(); */
        }

      

        private void dgvPartners_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                if (e.RowIndex != -1 && dgvReceiptLines.Rows[e.RowIndex].DataBoundItem != null)
                {
                    dgvReceiptLines.CurrentCell = dgvReceiptLines.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvReceiptLines.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                receiptLinesBindingSource.DataSource = db.ReceiptLines.Where(rl => rl.TransactionReceiptID==transactionReceipt.ID && rl.Surfaces.SurfaceCode.Contains(txtFilter.Text)).ToList();
            } else
            {
                receiptLinesBindingSource.DataSource = db.ReceiptLines.Where(rl => rl.TransactionReceiptID == transactionReceipt.ID);
            }
        }
    }
}
