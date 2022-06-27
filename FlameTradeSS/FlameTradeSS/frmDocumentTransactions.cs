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
    public partial class frmDocumentTransactions : Form
    {
        public frmDocumentTransactions()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }


        private void frmDocumentTransactions_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);


            documentTransactionsBindingSource.DataSource = documentTransactions;
            transactionLinesBindingSource.DataSource = db.TransactionLines.Where(tl => tl.TransactionsID == documentTransactions.ID).ToList();
            muBindingSource.DataSource = db.Mu.ToList();
            itemsBindingSource.DataSource = db.Items.ToList();
            
            if (dgvTransactionLines.CurrentRow != null && dgvTransactionLines.CurrentRow.DataBoundItem != null)
            {
                TransactionLines transactionLines = dgvTransactionLines.CurrentRow.DataBoundItem as TransactionLines;
                transactionLines.TransactionsID = documentTransactions.ID;
            }

            switch (documentTransactions.TransactionsType.LinesType.Name)
            {
                case "ItemID":
                    dgvTransactionLines.Columns[machineIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[serviceIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[startDateDataGridViewTextBoxColumn.Name].Visible=false;
                    dgvTransactionLines.Columns[endDateDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[durationHoursDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[cyclesDataGridViewTextBoxColumn.Name].Visible = false;
                    itemsBindingSource.DataSource = db.Items.ToList();
                    transactionReceiptBindingSource.DataSource = db.TransactionReceipt.ToList();
                    
                    break;
                case "MachineID":
                    dgvTransactionLines.Columns[ItemDescriptionDataGridViewComboBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[itemIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[serviceIDDataGridViewTextBoxColumn.Name].Visible = false;
                    break;
                case "ServiceID":
                    dgvTransactionLines.Columns[ItemDescriptionDataGridViewComboBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[itemIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[machineIDDataGridViewTextBoxColumn.Name].Visible = false;
                    break;
            }
            
                
        
        }

        public  FlameTradeDbEntities db;

        public  DocumentTransactions documentTransactions;


        private async void dgvTransactionLines_Click(object sender, EventArgs e)
        {
         
                if (documentTransactions.Documents==null || documentTransactions.Documents.Issued == 0 )
                {
                    if (documentTransactions.ID == 0)
                    {
                        await db.SaveChangesAsync();
                    }

                    if (transactionLinesBindingSource.Count == 0)
                    {
                        TransactionLines transaction = new TransactionLines();
                        transaction.TransactionsID = documentTransactions.ID;
                        transactionLinesBindingSource.Add(transaction);
                        db.TransactionLines.Add(transaction);
                    }
                }
            
            
        }

        private void frmDocumentTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = true;
           // Hide();
        }

        private void dgvTransactionLines_CurrentCellChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvTransactionLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == receiptIDDataGridViewTextBoxColumn.Index)
            {
                if (dgvTransactionLines.Rows[e.RowIndex].Cells[itemIDDataGridViewTextBoxColumn.Index].Value != null)
                {
                    frmReceiptSelector frmReceiptSelector = new frmReceiptSelector();
                    frmReceiptSelector.db = db;
                    frmReceiptSelector.FormClosing += FrmReceiptSelector_FormClosing;
                    Items item = new Items();
                    int itmId = (int)dgvTransactionLines.Rows[e.RowIndex].Cells[itemIDDataGridViewTextBoxColumn.Index].Value;
                    item = db.Items.Where(i => i.ID ==  itmId ).SingleOrDefault();
                    frmReceiptSelector.item = item;
                    CommonTasks.OpenForm(frmReceiptSelector);
                }
            } 
        }

        private void FrmReceiptSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmReceiptSelector frmReceiptSelector = (frmReceiptSelector)sender;

            if (frmReceiptSelector.xClicked!=true)
            {
                if (frmReceiptSelector.dgvReceipts.CurrentRow.DataBoundItem!=null)
                {
                    TransactionReceipt transactionReceipt = frmReceiptSelector.dgvReceipts.CurrentRow.DataBoundItem as TransactionReceipt;
                    dgvTransactionLines.CurrentCell.Value = transactionReceipt.ID;
                }
            }
        }
    }
}
