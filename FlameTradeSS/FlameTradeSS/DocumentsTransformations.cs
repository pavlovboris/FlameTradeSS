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

        public void TransformDocument(FlameTradeDbEntities db,Documents documentsTo, List<Documents> documentsFrom, BindingSource documentTransactionsBindingSource,bool thisAction)
        {
            foreach (Documents document in documentsFrom)
            {
                DocumentSequences sequences = document.DocumentSequences;
                foreach (DocumentTransactions documentTransactions in document.DocumentTransactions)
                {
                    foreach (PossibleSequenceTransofrmation possibleSequenceTransofrmation in db.PossibleSequenceTransofrmation.Where(pst => pst.DocumentSequenceID == sequences.ID && pst.PossibleDocumentSequenceID==documentsTo.DocumentSequenceID ).ToList())
                    {
                        foreach (PossibleSequenceTransformationsProperties possibleSequenceTransformationsProperties in db.PossibleSequenceTransformationsProperties.Where(pstp => pstp.PossibleSqequenceTransformationID == possibleSequenceTransofrmation.ID && pstp.TransactionTypeID == documentTransactions.TransactionTypeID).ToList())
                        {
                            int tempID = CurrentSessionData.Counter + 1;

                            CurrentSessionData.Counter = tempID;

                            DocumentTransactions newDocTransaction = new DocumentTransactions();
                            newDocTransaction.Documents = documentsTo;
                            newDocTransaction.TransactionDate = DateTime.Now;
                            newDocTransaction.TransactionTypeID = possibleSequenceTransformationsProperties.TransactionTypeIDTo;
                            newDocTransaction.CreationDateTime = DateTime.Now;
                            newDocTransaction.UserID = CurrentSessionData.CurrentUser.ID;
                            newDocTransaction.ExpectedMatDate = documentTransactions.ExpectedMatDate;
                            newDocTransaction.ColorID = documentTransactions.ColorID;
                            newDocTransaction.Value1 = documentTransactions.Value1;
                            newDocTransaction.Qty1 = documentTransactions.Qty1;
                            newDocTransaction.Value2 = documentTransactions.Value2;
                            newDocTransaction.tempID = tempID;
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

                            TransactionsTransformations newTransactionsTransformations = new TransactionsTransformations();
                            newTransactionsTransformations.DocumentTransactions1 = newDocTransaction;
                            newTransactionsTransformations.DocumentTransactions = documentTransactions;
                            db.TransactionsTransformations.Add(newTransactionsTransformations);

                            foreach (TransactionLines transactionLines in documentTransactions.TransactionLines)
                            {
                                if (possibleSequenceTransformationsProperties.UseReceipt != 1)
                                {
                                    TransactionLines newTransactionLine = new TransactionLines();
                                    newTransactionLine.DocumentTransactions = newDocTransaction;
                                    newTransactionLine.AdditionExpense = transactionLines.AdditionExpense;
                                    newTransactionLine.Comment = transactionLines.Comment;
                                    newTransactionLine.CostPrice1 = transactionLines.CostPrice1;
                                    newTransactionLine.CostPrice2 = transactionLines.CostPrice2;
                                    newTransactionLine.CostPrice3 = transactionLines.CostPrice3;
                                    newTransactionLine.SalePrice1 = transactionLines.SalePrice1;
                                    newTransactionLine.SalePrice2 = transactionLines.SalePrice2;
                                    newTransactionLine.SalePrice3 = transactionLines.SalePrice3;
                                    newTransactionLine.SecondPartitionID = transactionLines.SecondPartitionID;
                                    newTransactionLine.ServiceID = transactionLines.ServiceID;
                                    newTransactionLine.StartDate = transactionLines.StartDate;
                                    newTransactionLine.Cycles = transactionLines.Cycles;
                                    newTransactionLine.DurationHours = transactionLines.DurationHours;
                                    newTransactionLine.EndDate = transactionLines.EndDate;
                                    newTransactionLine.MuID = transactionLines.MuID;
                                    newTransactionLine.ExpectedMatDate = transactionLines.ExpectedMatDate;
                                    newTransactionLine.RequestDate = transactionLines.RequestDate;
                                    newTransactionLine.FinancialCategoryID = transactionLines.FinancialCategoryID;
                                    newTransactionLine.ItemID = transactionLines.ItemID;
                                    newTransactionLine.MachineID = transactionLines.MachineID;
                                    newTransactionLine.Ordering = transactionLines.Ordering;
                                    newTransactionLine.PartitionID = transactionLines.PartitionID;
                                    newTransactionLine.ReceiptID = transactionLines.ReceiptID;
                                    newTransactionLine.SurfaceID = transactionLines.SurfaceID;
                                    newTransactionLine.WH = transactionLines.WH;
                                    

                                    

                                    if (thisAction == true)
                                    {
                                        
                                        if (possibleSequenceTransformationsProperties.RemainQTYthis == 1)
                                        {
                                            if (transactionLines.RemainingQTY != null)
                                            {
                                                newTransactionLine.Qty = transactionLines.RemainingQTY;

                                                if (possibleSequenceTransformationsProperties.RemainQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainDeliveryQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingDeliveryQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainPackagingQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingPackagingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainProductionQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingProductionQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainInvoiceQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingInvoiceQTY = transactionLines.Qty;
                                                }

                                                TransactionRowsDependancy newTransactionRowsDependancy = new TransactionRowsDependancy();
                                                newTransactionRowsDependancy.TransactionLines = newTransactionLine;
                                                newTransactionRowsDependancy.TransactionLines1 = transactionLines;
                                                newTransactionRowsDependancy.ControlledParameter = "RemainQTY";
                                                newTransactionRowsDependancy.InitialValue = transactionLines.RemainingQTY;
                                                newTransactionRowsDependancy.LastValue = transactionLines.RemainingQTY;
                                                db.TransactionRowsDependancy.Add(newTransactionRowsDependancy);
                                            }
                                        } 

                                        if (possibleSequenceTransformationsProperties.RemainInvoiceQTYthis == 1)
                                        {
                                            if (transactionLines.RemainingInvoiceQTY != null)
                                            {
                                                newTransactionLine.Qty = transactionLines.RemainingInvoiceQTY;

                                                if (possibleSequenceTransformationsProperties.RemainQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainDeliveryQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingDeliveryQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainPackagingQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingPackagingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainProductionQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingProductionQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainInvoiceQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingInvoiceQTY = transactionLines.Qty;
                                                }

                                                TransactionRowsDependancy newTransactionRowsDependancy = new TransactionRowsDependancy();
                                                newTransactionRowsDependancy.TransactionLines = newTransactionLine;
                                                newTransactionRowsDependancy.TransactionLines1 = transactionLines;
                                                newTransactionRowsDependancy.ControlledParameter = "RemainingInvoiceQTY";
                                                newTransactionRowsDependancy.InitialValue = transactionLines.RemainingInvoiceQTY;
                                                newTransactionRowsDependancy.LastValue = transactionLines.RemainingInvoiceQTY;
                                                db.TransactionRowsDependancy.Add(newTransactionRowsDependancy);
                                            }
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainDeliveryQTYthis == 1)
                                        {
                                            if (transactionLines.RemainingDeliveryQTY != null)
                                            {
                                                newTransactionLine.Qty = transactionLines.RemainingDeliveryQTY;

                                                if (possibleSequenceTransformationsProperties.RemainQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainDeliveryQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingDeliveryQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainPackagingQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingPackagingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainProductionQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingProductionQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainInvoiceQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingInvoiceQTY = transactionLines.Qty;
                                                }

                                                TransactionRowsDependancy newTransactionRowsDependancy = new TransactionRowsDependancy();
                                                newTransactionRowsDependancy.TransactionLines = newTransactionLine;
                                                newTransactionRowsDependancy.TransactionLines1 = transactionLines;
                                                newTransactionRowsDependancy.ControlledParameter = "RemainingDeliveryQTY";
                                                newTransactionRowsDependancy.InitialValue = transactionLines.RemainingDeliveryQTY;
                                                newTransactionRowsDependancy.LastValue = transactionLines.RemainingDeliveryQTY;
                                                db.TransactionRowsDependancy.Add(newTransactionRowsDependancy);
                                            }
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainPackagingQTYthis == 1)
                                        {
                                            if (transactionLines.RemainingPackagingQTY != null)
                                            {
                                                newTransactionLine.Qty = transactionLines.RemainingPackagingQTY;

                                                if (possibleSequenceTransformationsProperties.RemainQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainDeliveryQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingDeliveryQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainPackagingQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingPackagingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainProductionQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingProductionQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainInvoiceQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingInvoiceQTY = transactionLines.Qty;
                                                }

                                                TransactionRowsDependancy newTransactionRowsDependancy = new TransactionRowsDependancy();
                                                newTransactionRowsDependancy.TransactionLines = newTransactionLine;
                                                newTransactionRowsDependancy.TransactionLines1 = transactionLines;
                                                newTransactionRowsDependancy.ControlledParameter = "RemainingPackagingQTY";
                                                newTransactionRowsDependancy.InitialValue = transactionLines.RemainingPackagingQTY;
                                                newTransactionRowsDependancy.LastValue = transactionLines.RemainingPackagingQTY;
                                                db.TransactionRowsDependancy.Add(newTransactionRowsDependancy);
                                            }
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainProductionQTYthis == 1)
                                        {
                                            if (transactionLines.RemainingProductionQTY != null)
                                            {
                                                newTransactionLine.Qty = transactionLines.RemainingProductionQTY;

                                                if (possibleSequenceTransformationsProperties.RemainQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainDeliveryQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingDeliveryQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainPackagingQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingPackagingQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainProductionQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingProductionQTY = transactionLines.Qty;
                                                }

                                                if (possibleSequenceTransformationsProperties.RemainInvoiceQTYAction == 1)
                                                {
                                                    newTransactionLine.RemainingInvoiceQTY = transactionLines.Qty;
                                                }

                                                TransactionRowsDependancy newTransactionRowsDependancy = new TransactionRowsDependancy();
                                                newTransactionRowsDependancy.TransactionLines = newTransactionLine;
                                                newTransactionRowsDependancy.TransactionLines1 = transactionLines;
                                                newTransactionRowsDependancy.ControlledParameter = "RemainingProductionQTY";
                                                newTransactionRowsDependancy.InitialValue = transactionLines.RemainingProductionQTY;
                                                newTransactionRowsDependancy.LastValue = transactionLines.RemainingProductionQTY;
                                                db.TransactionRowsDependancy.Add(newTransactionRowsDependancy);
                                            }
                                        }
                                    } else
                                    {
                                        newTransactionLine.Qty = transactionLines.Qty;

                                        if (possibleSequenceTransformationsProperties.RemainQTYAction == 1)
                                        {
                                            newTransactionLine.RemainingQTY = transactionLines.Qty;
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainDeliveryQTYAction == 1)
                                        {
                                            newTransactionLine.RemainingDeliveryQTY = transactionLines.Qty;
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainPackagingQTYAction==1)
                                        {
                                            newTransactionLine.RemainingPackagingQTY = transactionLines.Qty;
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainProductionQTYAction ==1 )
                                        {
                                            newTransactionLine.RemainingProductionQTY = transactionLines.Qty;
                                        }

                                        if (possibleSequenceTransformationsProperties.RemainInvoiceQTYAction == 1)
                                        {
                                            newTransactionLine.RemainingInvoiceQTY = transactionLines.Qty;
                                        }
                                    }
                                    db.TransactionLines.Add(newTransactionLine);
                                }
                            }
                        }
                    }
                }
                DocumentTransformation newDocTransformation = new DocumentTransformation();
                newDocTransformation.DocID = documentsTo.ID;
                newDocTransformation.OriginDocID = document.ID;
                db.DocumentTransformation.Add(newDocTransformation);
            }
        }
    }
}
