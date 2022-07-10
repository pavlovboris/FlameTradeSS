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
    public partial class frmSplitTransactions : Form
    {
        public frmSplitTransactions()
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

        public DocumentTransactions currentDocumetTransaction;
        public DocumentTransactions newDocumentTransactions;
        public TransactionsTransformations transactionsTransformations;
       
        public FlameTradeDbEntities db ;

        private void frmRolesFunctions_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
            lblTransactionType.Text = currentDocumetTransaction.ID + "@" + currentDocumetTransaction.TransactionsType.TypeName;
            currentTransactionLinesBindingSource.DataSource = db.TransactionLines.Where(tl => tl.TransactionsID == currentDocumetTransaction.ID).ToList();
            muBindingSource.DataSource = db.Mu.ToList();
            partitionsBindingSource.DataSource = db.Partitions.ToList();
            surfacesBindingSource.DataSource = db.Surfaces.ToList();
            itemsBindingSource.DataSource = db.Items.ToList();
 
        }

        private void cmbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }
      
        private  void btnMoveRight_Click(object sender, EventArgs e)
        {
            TransactionLines currentTransactionLines = dgvLeft.CurrentRow.DataBoundItem as TransactionLines;
            if (currentTransactionLines!=null)
            { 
                TransactionLines newTransactionLines = new TransactionLines();
                newTransactionLines.DocumentTransactions = newDocumentTransactions;
                newTransactionLines.Items = currentTransactionLines.Items;
                newTransactionLines.Machines = currentTransactionLines.Machines;
                newTransactionLines.Services = currentTransactionLines.Services;
                newTransactionLines.AdditionExpense = currentTransactionLines.AdditionExpense;
                newTransactionLines.Comment = currentTransactionLines.Comment;
                newTransactionLines.TransactionReceipt = currentTransactionLines.TransactionReceipt;
                newTransactionLines.WH = currentTransactionLines.WH;
                newTransactionLines.StartDate = currentTransactionLines.StartDate;
                newTransactionLines.SecondPartitionID = currentTransactionLines.SecondPartitionID;
                newTransactionLines.RequestDate = currentTransactionLines.RequestDate;
                newTransactionLines.CostPrice2 = currentTransactionLines.CostPrice2;
                newTransactionLines.CostPrice1 = currentTransactionLines.CostPrice1;
                newTransactionLines.CostPrice3 = currentTransactionLines.CostPrice3;
                newTransactionLines.SalePrice2 = currentTransactionLines.SalePrice2;
                newTransactionLines.SalePrice1 = currentTransactionLines.SalePrice1;
                newTransactionLines.SalePrice3 = currentTransactionLines.SalePrice3;
                newTransactionLines.Cycles = currentTransactionLines.Cycles;
                newTransactionLines.DurationHours = currentTransactionLines.DurationHours;
                newTransactionLines.Mu = currentTransactionLines.Mu;
                newTransactionLines.EndDate = currentTransactionLines.EndDate;
                newTransactionLines.FinancialCategories = currentTransactionLines.FinancialCategories;
                newTransactionLines.Partitions = currentTransactionLines.Partitions;
                newTransactionLines.Ordering = currentTransactionLines.Ordering;
                newTransactionLines.SurfaceID = currentTransactionLines.SurfaceID;
                newTransactionLines.Qty = currentTransactionLines.Qty;
                btnClose.Enabled = false;
                btnConfirm.Enabled = false;
                btnMoveLeft.Enabled = false;
                btnMoveRight.Enabled = false;
                dgvLeft.Enabled = false;
                dgvRight.Enabled = false;

                //db.TransactionLines.Add(newTransactionLines);
                //newTransactionLinesBindingSource.Add(newTransactionLines);

                frmSplitTransactionsLinesQty frmSplitTransactionsLinesQty = new frmSplitTransactionsLinesQty();
                
                frmSplitTransactionsLinesQty.newTransactionLines = newTransactionLines;
                frmSplitTransactionsLinesQty.transactionLinesBindingSource = newTransactionLinesBindingSource;
                frmSplitTransactionsLinesQty.db = db;                
                frmSplitTransactionsLinesQty.currentTransactionLines = currentTransactionLines;
                frmSplitTransactionsLinesQty.FormClosing += FrmSplitTransactionsLinesQty_FormClosing;
                frmSplitTransactionsLinesQty.ShowDialog();
            }
        }

        private void FrmSplitTransactionsLinesQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSplitTransactionsLinesQty formSplitTransactionsLinesQty = sender as frmSplitTransactionsLinesQty;
            TransactionLines currentTransactionLines = dgvLeft.CurrentRow.DataBoundItem as TransactionLines;

            if (formSplitTransactionsLinesQty.cancel == false )
            {
                foreach (TransactionRowsDependancy rowsDependancy in currentTransactionLines.TransactionRowsDependancy)
                {
                    TransactionRowsDependancy transactionRowsDependancy = new TransactionRowsDependancy();
                    transactionRowsDependancy.TransactionLines = formSplitTransactionsLinesQty.newTransactionLines;
                    transactionRowsDependancy.TransactionLines1 = rowsDependancy.TransactionLines1;
                    transactionRowsDependancy.ControlledParameter = rowsDependancy.ControlledParameter;
                    transactionRowsDependancy.InitialValue = rowsDependancy.InitialValue;
                    transactionRowsDependancy.LastValue = 0;
                    db.TransactionRowsDependancy.Add(transactionRowsDependancy);
                }
            }
 
            btnClose.Enabled = true;
            btnConfirm.Enabled = true;
            btnMoveLeft.Enabled = true;
            btnMoveRight.Enabled = true;
            dgvLeft.Enabled = true;
            dgvRight.Enabled = true;
        }

        private  void btnMoveLeft_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да затворите без да потвърдите промените? Всички непотвърдени промени ще бъдат изгубени!")==true)
            {

                List<TransactionLines> lines = new List<TransactionLines>();
                foreach(TransactionLines transactionLines in newTransactionLinesBindingSource)
                {
                    lines.Add(transactionLines);
                }

                foreach(TransactionLines transactionLines in lines )
                {
                    List<TransactionRowsDependancy> rowsDependancies = new List<TransactionRowsDependancy>();
                    foreach(TransactionRowsDependancy transactionRowsDependancy in transactionLines.TransactionRowsDependancy)
                    {
                        rowsDependancies.Add(transactionRowsDependancy);
                    }

                    foreach(TransactionRowsDependancy transactionRowsDependancy in rowsDependancies)
                    {
                        db.TransactionRowsDependancy.Remove(transactionRowsDependancy);
                    }
                    db.TransactionLines.Remove(transactionLines);
                }

                documentTransactionsbindingSource.Remove(newDocumentTransactions);
                db.DocumentTransactions.Remove(newDocumentTransactions);
                db.TransactionsTransformations.Remove(transactionsTransformations);
                CurrentSessionData.Counter = CurrentSessionData.Counter - 1;
                Close();
            }
        }

        private void frmRolesFunctions_Paint(object sender, PaintEventArgs e)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да потвърдите операцията? ") == true)
            {
                Close();
            }
        }
    }
}
