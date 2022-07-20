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
    public partial class frmItemSelector : Form
    {
        public frmItemSelector()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public bool xClicked = true;

        private const int cCaption = 300;   // Caption bar height;

      /*  protected override void WndProc(ref Message m)
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
        }*/

        public FlameTradeDbEntities db;
       

        private void frmProjectSelector_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive == 0 && i.Code.Contains(txtFilter.Text) || i.Description.Contains(txtFilter.Text) || i.ItemCategory1.CategoryName.Contains(txtFilter.Text) || i.ItemsGroups.GroupName.Contains(txtFilter.Text)).ToList();
            }
            else
            {
                itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive == 0).ToList();
            }

            //itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive==0).ToList();
            itemsGroupsBindingSource.DataSource = db.ItemsGroups.ToList();
            itemCategoryBindingSource.DataSource = db.ItemCategory.ToList();

        }

        private void frmProjectSelector_Paint(object sender, PaintEventArgs e)
        {
         /*   Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            xClicked = true; 
            Close();
        }

        private void dgvProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemsSelector.CurrentRow.Index!=-1 && dgvItemsSelector.CurrentRow.DataBoundItem!=null)
            {
                xClicked = false;
                Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           /* if(!string.IsNullOrEmpty( txtFilter.Text))
            {
                
                    itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive==0 && i.Code.Contains(txtFilter.Text ) || i.Description.Contains(txtFilter.Text) || i.ItemCategory1.CategoryName.Contains(txtFilter.Text) || i.ItemsGroups.GroupName.Contains(txtFilter.Text) ).ToList();
                
               
            } else
            {    
                    itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive == 0 ).ToList();
            }*/
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40 | e.KeyValue == 13)
            {

                if (!string.IsNullOrEmpty(txtFilter.Text))
                {

                    itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive == 0 && i.Code.Contains(txtFilter.Text) || i.Description.Contains(txtFilter.Text) || i.ItemCategory1.CategoryName.Contains(txtFilter.Text) || i.ItemsGroups.GroupName.Contains(txtFilter.Text)).ToList();


                }
                else
                {
                    itemsBindingSource.DataSource = db.Items.Where(i => i.IsInactive == 0).ToList();
                }

                dgvItemsSelector.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                xClicked = true;
                Close();
            } else if (e.KeyData == Keys.Escape)
            {
                dgvItemsSelector.Focus();
            }
        }

        private void dgvProjects_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyValue == 13)
                {
                    if (dgvItemsSelector.CurrentRow != null && dgvItemsSelector.CurrentRow.Index != -1 && dgvItemsSelector.CurrentRow.DataBoundItem != null)
                    {
                        xClicked = false;
                        Close();
                    }
                }
                else if (e.KeyData == Keys.Escape)
                {
                    xClicked = true;
                    Close();
                } else if (e.KeyValue == 8)
                {
                    txtFilter.Focus();
                    txtFilter.SelectAll();
                    
                }
            
        }

        private void btmProjectAdd_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
          
          //  frm.Close();
        }

        private  void FrmProjects_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frmItemSelector_Shown(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
            {
                txtFilter.SelectAll();

            } else
            {
                txtFilter.SelectionStart = 2;
            }
        }
    }
}
