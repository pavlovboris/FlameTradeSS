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
    public partial class frmSurfaceSelector : Form
    {
        public frmSurfaceSelector()
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

        public SurfaceTypes surfaceTypes;

        private void frmProjectSelector_Load(object sender, EventArgs e)
        {
            surfacesBindingSource.DataSource = db.Surfaces.Where(s => s.SurfaceTypeID == surfaceTypes.ID).ToList();
            surfaceTypesBindingSource.DataSource = db.SurfaceTypes.ToList();
            cmbSurfaceTypes.SelectedItem = surfaceTypes;
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
            if (dgvItemsSelector.CurrentRow.Index!=-1 && dgvItemsSelector.CurrentRow.DataBoundItem!=null)
            {
                Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            surfaceTypes = (SurfaceTypes)cmbSurfaceTypes.SelectedItem;
            if (!string.IsNullOrEmpty( txtFilter.Text))
            {
                surfacesBindingSource.DataSource = db.Surfaces.Where(s => s.SurfaceCode.Contains(txtFilter.Text) | s.SurfaceDescription.Contains(txtFilter.Text) | s.SurfaceName.Contains(txtFilter.Text) && s.SurfaceTypeID == surfaceTypes.ID).ToList();
            } else
            {
                surfacesBindingSource.DataSource = db.Surfaces.Where(s => s.SurfaceTypeID == surfaceTypes.ID).ToList();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
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
            if(dgvItemsSelector.CurrentRow.Index!= -1 && dgvItemsSelector.CurrentRow.DataBoundItem!=null)
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

        private void frmItemSelector_Shown(object sender, EventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void cmbSurfaceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                surfaceTypes = (SurfaceTypes)cmbSurfaceTypes.SelectedItem;
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    surfacesBindingSource.DataSource = db.Surfaces.Where(s => s.SurfaceCode.Contains(txtFilter.Text) || s.SurfaceDescription.Contains(txtFilter.Text) || s.SurfaceTypeID == surfaceTypes.ID).ToList();
                }
                else
                {
                    surfacesBindingSource.DataSource = db.Surfaces.Where(s => s.SurfaceTypeID == surfaceTypes.ID).ToList();
                }
            } catch { }
 
        }
    }
}
