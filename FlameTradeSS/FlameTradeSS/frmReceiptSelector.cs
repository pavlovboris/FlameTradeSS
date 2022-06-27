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
    public partial class frmReceiptSelector : Form
    {
        public frmReceiptSelector()
        {
            InitializeComponent();
        }

        public bool xClicked = false;

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

        public FlameTradeDbEntities db;
        public Items item;

        private void frmProjectSelector_Load(object sender, EventArgs e)
        {
            if (item != null)
            {
                transactionReceiptBindingSource.DataSource = db.TransactionReceipt.Where(tr => tr.ID == 3 || tr.ItemID == item.ID).ToList();
               
            }
            itemsBindingSource.DataSource = db.Items.ToList();
            txtFilter.SelectAll();
        }

        private void frmProjectSelector_Paint(object sender, PaintEventArgs e)
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
            xClicked = true; 
            Close();
        }

        private void dgvProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReceipts.CurrentRow.Index!=-1 && dgvReceipts.CurrentRow.DataBoundItem!=null)
            {
                Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty( txtFilter.Text))
            {
                if (item != null)
                {
                    transactionReceiptBindingSource.DataSource = db.TransactionReceipt.Where(tr => tr.ItemID == item.ID &&  tr.Name.Contains(txtFilter.Text) || tr.Description.Contains(txtFilter.Text)).ToList();
                }
               
            } else
            {    
                if (item != null)
                {
                    transactionReceiptBindingSource.DataSource = db.TransactionReceipt.Where(tr => tr.ID == 3 || tr.ItemID == item.ID).ToList();
                }
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                dgvReceipts.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                xClicked = true;
                Close();
            } else if (e.KeyData == Keys.Escape)
            {
                dgvReceipts.Focus();
            }
        }

        private void dgvProjects_KeyDown(object sender, KeyEventArgs e)
        {
            if(dgvReceipts.CurrentRow.Index!= -1 && dgvReceipts.CurrentRow.DataBoundItem!=null)
            {
                if (e.KeyValue == 13)
                {
                    Close();
                }
                else if (e.KeyData == Keys.Escape)
                {
                    xClicked = true;
                    Close();
                }
            }
        }

        private void btmProjectAdd_Click(object sender, EventArgs e)
        {
            frmProjects frmProjects = new frmProjects();
            frmProjects.FormClosed += FrmProjects_FormClosed;
            frmProjects.db = db;
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                frmProjects.newProjectName = txtFilter.Text;
            }
            CommonTasks.OpenForm(frmProjects);
            frmProjects.btnAdd.PerformClick();
            frmProjects.btnRemove.Enabled = false;
            frmProjects.btnAdd.Enabled = false;
            frmProjects.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            frmProjects frm = btn.Parent as frmProjects;

          //  frm.Close();
        }

        private  void FrmProjects_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
