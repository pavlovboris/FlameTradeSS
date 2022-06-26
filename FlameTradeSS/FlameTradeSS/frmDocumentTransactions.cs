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
                    break;
                case "MachineID":
                    dgvTransactionLines.Columns[itemIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[serviceIDDataGridViewTextBoxColumn.Name].Visible = false;
                    break;
                case "ServiceID":
                    dgvTransactionLines.Columns[itemIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[machineIDDataGridViewTextBoxColumn.Name].Visible = false;
                    break;
            }
            
                
        
        }

        public  FlameTradeDbEntities db;

        public  DocumentTransactions documentTransactions;


        private async void dgvTransactionLines_Click(object sender, EventArgs e)
        {
            if (documentTransactions.Documents.Issued == 0)
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
    }
}
