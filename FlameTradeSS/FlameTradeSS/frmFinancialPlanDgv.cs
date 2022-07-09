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
    public partial class frmFinancialPlanDgv : Form
    {
        public frmFinancialPlanDgv()
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

        public FlameTradeDbEntities db ;
        public FinancialPlans financialPlans;

        private  void frmFunctions_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            financialPlanLinesBindingSource.DataSource = db.FinancialPlanLines.Where(fpl => fpl.FinancialPlanID == financialPlans.ID).ToList();
            transactionsTypeBindingSource.DataSource = db.TransactionsType.Where(tt => tt.IsFinancialType == 1).ToList();
            financialCategoriesBindingSource.DataSource = db.FinancialCategories.ToList();

            foreach (DataGridViewRow dgvr in dgvFinancialPlansLines.Rows)
            {
                if (dgvr.Index != - 1)
                {
                    FinancialPlanLines financialPlanLines = dgvr.DataBoundItem as FinancialPlanLines;
                    Color color = Color.FromArgb(Convert.ToInt32(db.FinancialPlanColors.Where(fpc => fpc.TransactionTypeID == financialPlanLines.TransactionTypeID).SingleOrDefault().FinancialColor));
                    dgvr.DefaultCellStyle.BackColor = color;
                }
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
                CommonTasks.WriteGrideViewSetting(dgvFinancialPlansLines, Name + dgvFinancialPlansLines.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
        }

        private void dgvFinancialPlanColor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
        }
    }
}
