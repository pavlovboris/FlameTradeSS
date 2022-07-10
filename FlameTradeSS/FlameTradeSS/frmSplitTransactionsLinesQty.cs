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
    public partial class frmSplitTransactionsLinesQty : Form
    {
        public frmSplitTransactionsLinesQty()
        {
            InitializeComponent();
        }
        public TransactionLines newTransactionLines;
        public TransactionLines currentTransactionLines;
        public FlameTradeDbEntities db;
        public bool cancel = true;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (currentTransactionLines.Qty <= Convert.ToDouble(txtQty.Text))
            {
                CommonTasks.SendErrorMsg("Не можете да прехвърлите по-голямо или равно количество в новата транзакция!");
            } else
            {
                double qtyOldValue = (double)currentTransactionLines.Qty;
                newTransactionLines.Qty = Convert.ToDouble(txtQty.Text);
                currentTransactionLines.Qty = currentTransactionLines.Qty - newTransactionLines.Qty;

                if (currentTransactionLines.RemainingQTY!=null)
                {
                    double oldNewDiff = (double)currentTransactionLines.Qty - qtyOldValue;

                    currentTransactionLines.RemainingQTY = currentTransactionLines.RemainingQTY + oldNewDiff;
                    newTransactionLines.RemainingQTY = newTransactionLines.Qty;
                }
                if (currentTransactionLines.RemainingInvoiceQTY!=null)
                {
                    double oldNewDiff = (double)currentTransactionLines.Qty - qtyOldValue;
                  
                    currentTransactionLines.RemainingInvoiceQTY = currentTransactionLines.RemainingInvoiceQTY + oldNewDiff;
                    newTransactionLines.RemainingInvoiceQTY = newTransactionLines.Qty;
                }
                if (currentTransactionLines.RemainingDeliveryQTY != null)
                {
                    double oldNewDiff = (double)currentTransactionLines.Qty - qtyOldValue;

                    currentTransactionLines.RemainingDeliveryQTY = currentTransactionLines.RemainingDeliveryQTY + oldNewDiff;
                    newTransactionLines.RemainingDeliveryQTY = newTransactionLines.Qty;
                }
                if (currentTransactionLines.RemainingPackagingQTY != null)
                {
                    double oldNewDiff = (double)currentTransactionLines.Qty - qtyOldValue;

                    currentTransactionLines.RemainingPackagingQTY = currentTransactionLines.RemainingPackagingQTY + oldNewDiff;
                    newTransactionLines.RemainingPackagingQTY = newTransactionLines.Qty;
                }
                if (currentTransactionLines.RemainingProductionQTY != null)
                {
                    double oldNewDiff = (double)currentTransactionLines.Qty - qtyOldValue;

                    currentTransactionLines.RemainingProductionQTY = currentTransactionLines.RemainingProductionQTY + oldNewDiff;
                    newTransactionLines.RemainingProductionQTY = newTransactionLines.Qty;
                }


                db.TransactionLines.Add(newTransactionLines);
                cancel = false;
                Close();
            }
        }

        private void frmSplitTransactionsLinesQty_Load(object sender, EventArgs e)
        {
            transactionLinesBindingSource.Add(newTransactionLines);
            transactionLinesBindingSource.MoveLast();
            txtQty.Text = newTransactionLines.Qty.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            transactionLinesBindingSource.Remove(newTransactionLines);
            Close();
        }
    }
}
