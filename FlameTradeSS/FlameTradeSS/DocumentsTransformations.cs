using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    internal class DocumentsTransformations
    {

        public void TransformDocument(FlameTradeDbEntities db,Documents documentsTo, List<Documents> documentsFrom, BindingSource documentTransactionsBindingSource)
        {
            foreach (Documents document in documentsFrom)
            {
                DocumentSequences sequences = document.DocumentSequences;
                foreach (DocumentTransactions documentTransactions in document.DocumentTransactions)
                {
                    foreach (PossibleSequenceTransofrmation possibleSequenceTransofrmation in db.PossibleSequenceTransofrmation.Where(pst => pst.DocumentSequenceID == sequences.ID ).ToList())
                    {
                        foreach (PossibleSequenceTransformationsProperties possibleSequenceTransformationsProperties in db.PossibleSequenceTransformationsProperties.Where(pstp => pstp.PossibleSqequenceTransformationID == possibleSequenceTransofrmation.ID && pstp.TransactionTypeID == documentTransactions.ID))
                        {
                            DocumentTransactions newDocTransaction = new DocumentTransactions();
                            newDocTransaction.DocumentsID = documentsTo.ID;
                            newDocTransaction.TransactionTypeID = possibleSequenceTransformationsProperties.TransactionTypeIDTo;
                            newDocTransaction.CreationDateTime = DateTime.Now;
                            newDocTransaction.ExpectedMatDate = documentTransactions.ExpectedMatDate;
                            newDocTransaction.ColorID = documentTransactions.ColorID;
                            newDocTransaction.Value1 = documentTransactions.Value1;
                            newDocTransaction.Qty1 = documentTransactions.Qty1;
                            newDocTransaction.Value2 = documentTransactions.Value2;
                            newDocTransaction.Value3 = documentTransactions.Value3;
                            newDocTransaction.Qty3 = documentTransactions.Qty3;
                            newDocTransaction.Comment = documentTransactions.Comment;
                            newDocTransaction.Qty2 = documentTransactions.Qty2;
                            newDocTransaction.NotForInvoice = documentTransactions.NotForInvoice;
                            if (possibleSequenceTransformationsProperties.UseReceipt == 1)
                            {
                                newDocTransaction.ReceiptModelID = 1;
                            } else
                            {
                                newDocTransaction.ReceiptModelID = documentTransactions.ReceiptModelID;
                            }
                            newDocTransaction.ReceivedDate = documentTransactions.ReceivedDate;
                            newDocTransaction.RequestedDate = documentTransactions.RequestedDate; 
                            newDocTransaction.RequestedDeliveryDate = documentTransactions.RequestedDeliveryDate;
                            newDocTransaction.TransactionSurfaceID = documentTransactions.TransactionSurfaceID;                          

                            documentTransactionsBindingSource.Add(newDocTransaction);
                            db.DocumentTransactions.Add(newDocTransaction);
                        }
                    }
                }
            }
        }
    }
}
