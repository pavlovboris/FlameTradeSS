using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmFinancialPlansList : Form
    {
        public frmFinancialPlansList()
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

        public List<DocumentsFinancialPlan> docfinPlans;
        public bool fromDocument = true;

        private  void frmFunctions_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            projectBindingSource.DataSource = db.Project.ToList();
            //docfinPlans = db.DocumentsFinancialPlan.Where(dfp => dfp.DocumentID == senderDocument.ID).ToList(); 

            if (fromDocument == true)
            {
                foreach (DocumentsFinancialPlan doc in docfinPlans)
                {
                    financialPlansBindingSource.Add(db.FinancialPlans.Where(fp => fp.ID == doc.FinancialPlanID).SingleOrDefault());
                }
            } else
            {
                financialPlansBindingSource.DataSource = db.FinancialPlans.ToList();
            }

 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFunctions_Paint(object sender, PaintEventArgs e)
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

        private void frmFunctions_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvFinancialPlans, Name + dgvFinancialPlans.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
        }

        public Documents senderDocument;

        private void dgvFinancialPlanColor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!= -1)
            {
                
                frmFinancialPlans frmFinancialPlans = new frmFinancialPlans();
                FinancialPlans financial = dgvFinancialPlans.Rows[e.RowIndex].DataBoundItem as FinancialPlans;
                
                frmFinancialPlans.financialPlans = financial;
                frmFinancialPlans.autoLoad = true;
                frmFinancialPlans.btnLoadFromDocument.Visible = false;
                frmFinancialPlans.isNew = false;
                Close();
                CommonTasks.OpenForm(frmFinancialPlans);

                int y = Screen.PrimaryScreen.Bounds.Bottom - this.Height;
                this.Location = new Point(0, y);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvFinancialPlans.CurrentRow.Index == -1 | dgvFinancialPlans.CurrentRow.DataBoundItem==null)
            {
                e.Cancel = true;
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuGraphicalFinancialPlan)
            {
                frmFinancialPlans frmFinancialPlans = new frmFinancialPlans();
                FinancialPlans financial = dgvFinancialPlans.CurrentRow.DataBoundItem as FinancialPlans;

                frmFinancialPlans.financialPlans = financial;
                frmFinancialPlans.autoLoad = true;
                frmFinancialPlans.btnLoadFromDocument.Visible = false;
                frmFinancialPlans.isNew = false;
                Close();
                CommonTasks.OpenForm(frmFinancialPlans);

                int y = Screen.PrimaryScreen.Bounds.Bottom - this.Height;
                this.Location = new Point(0, y);
            } else if (e.ClickedItem == toolStripMenuDgvFinancialPlan)
            {
                frmFinancialPlanDgv frmFinancialPlanDgv = new frmFinancialPlanDgv();
                frmFinancialPlanDgv.db = db;
                frmFinancialPlanDgv.financialPlans = dgvFinancialPlans.CurrentRow.DataBoundItem as FinancialPlans;
                Close();
                CommonTasks.OpenForm(frmFinancialPlanDgv);
            }
        }
    }
}
