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
    public partial class frmProjectSelector : Form
    {
        public frmProjectSelector()
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

        private void frmProjectSelector_Load(object sender, EventArgs e)
        {
            projectBindingSource.DataSource = db.Project.ToList();
            txtFilter.Focus();
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
            if (dgvProjects.CurrentRow.Index!=-1 && dgvProjects.CurrentRow.DataBoundItem!=null)
            {
                Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty( txtFilter.Text))
            {
                projectBindingSource.DataSource = db.Project.Where(p => p.ProjectName.Contains(txtFilter.Text)).ToList();
            } else
            {
                projectBindingSource.DataSource = db.Project.ToList();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                dgvProjects.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                xClicked = true;
                Close();
            } else if (e.KeyData == Keys.Escape)
            {
                dgvProjects.Focus();
            }
        }

        private void dgvProjects_KeyDown(object sender, KeyEventArgs e)
        {
            if(dgvProjects.CurrentRow.Index!= -1 && dgvProjects.CurrentRow.DataBoundItem!=null)
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
            string temptext = "";
            temptext = txtFilter.Text;
            txtFilter.Text = "";
            txtFilter.Text = temptext;
        }
    }
}
