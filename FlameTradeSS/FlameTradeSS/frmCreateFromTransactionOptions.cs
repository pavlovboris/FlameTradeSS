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
    public partial class frmCreateFromTransactionOptions : Form
    {
        public frmCreateFromTransactionOptions()
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
            currentTransactionLinesBindingSource.DataSource = currentDocumetTransaction.TransactionLines ;
            muBindingSource.DataSource = db.Mu.ToList();
            partitionsBindingSource.DataSource = db.Partitions.ToList();
            surfacesBindingSource.DataSource = db.Surfaces.ToList();
            itemsBindingSource.DataSource = db.Items.ToList();

            List<Surfaces> existingSurfaces = new List<Surfaces>();

            foreach (TransactionLines transactionLines in currentDocumetTransaction.TransactionLines)
            {
                bool exist = false;


                foreach(Surfaces surfaces in existingSurfaces)
                {

                    if (surfaces == transactionLines.Surfaces)
                    {
                        exist = true;
                    }

                  
                }

                if (exist == false)
                {
                    existingSurfaces.Add(transactionLines.Surfaces);
                }
            }

            foreach (Surfaces surfaces in existingSurfaces)
            {
                
               // CheckBox newCheckBox = new CheckBox();
                //newCheckBox.Appearance = Appearance.Button;
                checkedListBoxPartitions.Items.Add(surfaces.SurfaceCode);

                checkedListBoxPartitions.SetItemChecked(checkedListBoxPartitions.Items.Count - 1,true);
                checkedListBoxPartitions.CheckOnClick = true;
            }
        }

        private  void btnMoveRight_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgvr in dgvLeft.Rows)
                {                  
                    if (dgvr.Cells[ChkBoxSelected.Index] != null && dgvr.Cells[ChkBoxSelected.Index].Value.ToString() == "1")
                    {
                        TransactionLines currentTransactionLines = dgvr.DataBoundItem as TransactionLines;

                        bool checkedSurface = false;                       

                        for (int i = 0; i<=checkedListBoxPartitions.Items.Count-1;i++)
                        {
                            if (checkedListBoxPartitions.GetItemChecked(i) == true)
                            {
                                if (currentTransactionLines.Surfaces.SurfaceCode == checkedListBoxPartitions.Items[i].ToString())
                                {
                                    checkedSurface = true;
                                }
                            }
                        }

                        if (currentTransactionLines != null && checkedSurface==true)
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

                            db.TransactionLines.Add(newTransactionLines);
                            newTransactionLinesBindingSource.Add(newTransactionLines);

                            PossibleSequenceTransformationsProperties newTransactionSettings = db.PossibleSequenceTransformationsProperties.Where(pstp => pstp.PossibleSequenceTransofrmation.DocumentSequenceID == newDocumentTransactions.Documents.DocumentSequenceID && pstp.PossibleSequenceTransofrmation.PossibleDocumentSequenceID == newDocumentTransactions.Documents.DocumentSequenceID && pstp.TransactionTypeID == currentDocumetTransaction.TransactionsType.ID && pstp.TransactionTypeIDTo == newDocumentTransactions.TransactionsType.ID).SingleOrDefault();

                            if (newTransactionSettings.RemainDeliveryQTYAction == 1)
                            {
                                newTransactionLines.RemainingDeliveryQTY = currentTransactionLines.Qty;
                            }

                            if (newTransactionSettings.RemainInvoiceQTYAction == 1)
                            {
                                newTransactionLines.RemainingInvoiceQTY = currentTransactionLines.Qty;
                            }

                            if (newTransactionSettings.RemainPackagingQTYAction == 1)
                            {
                                newTransactionLines.RemainingPackagingQTY = currentTransactionLines.Qty;
                            }

                            if (newTransactionSettings.RemainProductionQTYAction == 1)
                            {
                                newTransactionLines.RemainingProductionQTY = currentTransactionLines.Qty;
                            }

                            if (newTransactionSettings.RemainQTYAction == 1)
                            {
                                newTransactionLines.RemainingQTY = currentTransactionLines.Qty;
                            }

                            db.TransactionLines.Add(newTransactionLines);

                        }
                    }
                }
            } catch
            {
                CommonTasks.SendErrorMsg("Възникна грешка при автоматичното трансформиране, възможни са проблеми с новата транзакция! \n За да създадете нова транзакция базирана на друга транзакция коректно, трябва да са спазени следните условия:\n 1. Транзакцията от която се създава нова транзакция трябва да бъде запаметена. \n " +
                "2. Транзакцията която създавате трябва да бъде конфигурана в трансформациите на транзакцията от която създавате");

            }

           
        }

        private void FrmSplitTransactionsLinesQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSplitTransactionsLinesQty formSplitTransactionsLinesQty = sender as frmSplitTransactionsLinesQty;
            TransactionLines currentTransactionLines = dgvLeft.CurrentRow.DataBoundItem as TransactionLines;

           
 
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
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да затворите без да потвърдите промените? \nВсички непотвърдени промени ще бъдат изгубени!")==true)
            {

                List<TransactionLines> lines = new List<TransactionLines>();
                foreach(TransactionLines transactionLines in newTransactionLinesBindingSource)
                {
                    lines.Add(transactionLines);
                }

                foreach(TransactionLines transactionLines in lines )
                {

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

        private void dgvLeft_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           

            if (e.ColumnIndex == ChkBoxSelected.Index && e.Value == null)
            {
                e.Value = true;
                dgvLeft.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
            }
        }

        private void dgvLeft_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvRight_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1 && e.ColumnIndex== qtyDataGridViewTextBoxColumn1.Index && dgvRight.Rows[e.RowIndex]!=null)
            {
                TransactionLines transactionLines = dgvRight.Rows[e.RowIndex].DataBoundItem as TransactionLines;
                if ( transactionLines.RemainingDeliveryQTY!=0)
                {
                    transactionLines.RemainingDeliveryQTY = transactionLines.Qty;
                }

                if (transactionLines.RemainingInvoiceQTY != 0)
                {
                    transactionLines.RemainingInvoiceQTY = transactionLines.Qty;
                }

                if (transactionLines.RemainingPackagingQTY != 0)
                {
                    transactionLines.RemainingPackagingQTY = transactionLines.Qty;
                }

                if (transactionLines.RemainingProductionQTY != 0)
                {
                    transactionLines.RemainingProductionQTY = transactionLines.Qty;
                }

                if (transactionLines.RemainingQTY != 0)
                {
                    transactionLines.RemainingQTY = transactionLines.Qty;
                }
            }
        }
    }
}
