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
    public partial class frmFinancialColors : Form
    {
        public frmFinancialColors()
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

        private void frmFunctions_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            financialPlanColorsBindingSource.DataSource = db.FinancialPlanColors.ToList();
            transactionsTypeBindingSource.DataSource = db.TransactionsType.Where(tt => tt.IsFinancialType == 1).ToList();

            // List<TransactionsType> missingTransactionTypes = new List<TransactionsType>();

            foreach (TransactionsType transactionsType in db.TransactionsType.Where(tt => tt.IsFinancialType == 1).ToList())
            {
                bool existing = false;
                foreach (FinancialPlanColors financial in db.FinancialPlanColors)
                {
                    if (financial.TransactionTypeID == transactionsType.ID)
                    {
                        existing = true;
                    }
                }
                if (existing == false)
                {
                    //missingTransactionTypes.Add(transactionsType);
                    FinancialPlanColors financialPlanColors = new FinancialPlanColors();
                    financialPlanColors.TransactionTypeID = transactionsType.ID;
                    financialPlanColors.FinancialColor = Color.Gray.ToArgb().ToString();

                    financialPlanColorsBindingSource.Add(financialPlanColors);
                    db.FinancialPlanColors.Add(financialPlanColors);
                }

                foreach (DataGridViewRow dgvr in dgvFinancialPlanColor.Rows)
                {
                    dgvr.ReadOnly = true;
                }
            }

            foreach (DataGridViewRow dgvr in dgvFinancialPlanColor.Rows)
            {
                FinancialPlanColors planColors = dgvr.DataBoundItem as FinancialPlanColors;
                foreach (DataGridViewCell cell in dgvr.Cells)
                {
                    cell.Style.BackColor = Color.FromArgb(Convert.ToInt32(planColors.FinancialColor));
                }
            }

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvFinancialPlanColor, Name + dgvFinancialPlanColor.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите промените") == true)
            {
                try
                {
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените са запазени успешно");
                } catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени!!! \n Ако сте премахнали функция, възможно е тя да е присвоена на Роля и за това да не може да бъде изтрита");
                    if (CommonTasks.SendWarningMsg("Искате ли да видите детайлите") == true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }
            }
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
                CommonTasks.WriteGrideViewSetting(dgvFinancialPlanColor, Name + dgvFinancialPlanColor.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
        }

        private void dgvFinancialPlanColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == financialColorDataGridViewTextBoxColumn.Index)
            {

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    dgvFinancialPlanColor.CurrentCell.Value = colorDialog1.Color.ToArgb().ToString();
                    foreach (DataGridViewCell cell in dgvFinancialPlanColor.Rows[e.RowIndex].Cells)
                    {
                        cell.Style.BackColor = colorDialog1.Color;
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvFinancialPlanColor.CurrentRow.Index == -1 || dgvFinancialPlanColor.CurrentRow.DataBoundItem ==null)
            {
                e.Cancel = true;
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuEdit)
            {
                dgvFinancialPlanColor.CurrentRow.ReadOnly = false;
            }
        }
    }
}
