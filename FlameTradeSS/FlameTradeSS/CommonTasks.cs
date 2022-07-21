using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FlameTradeSS
{
    internal class CommonTasks
    {
        public static void ExitApplication()
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да затворите " + Application.ProductName.ToString(), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                List<Form> openForms = new List<Form>();

                foreach(Form frm in Application.OpenForms)
                {
                    openForms.Add(frm);
                }

                foreach(Form f in openForms)
                {
                    if (f.Name != "frmLogin")
                    {
                        f.Close();
                    } else
                    {
                        Properties.Settings.Default.frmLoginUserName = frmLogin.Instance.txtUserName.Text;
                        Properties.Settings.Default.Save();
                    }
                }
                Application.ExitThread();
            }
        }

        public static void SendErrorMsg(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SendInfoMsg(string message)
        {
            MessageBox.Show(message, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool SendWarningMsg(string message)
        {
            if(MessageBox.Show(message,"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) ==DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static DialogResult SendQuestionMsg(string message)
        {
            DialogResult dialog = MessageBox.Show(message, "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                return DialogResult.Yes;
            } else if (dialog==DialogResult.No)
            {
                return DialogResult.No;
            } else { return DialogResult.Cancel; }
        }

        public static void OpenForm(Form form)
        {
            List<Form> openForms = new List<Form>();

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            foreach(Form f in openForms)
            {
                if (f.Name == form.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen==false)
            {
                form.Show();
                UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, form);
            }
        }

        public static void ReadDataGridViewSetting(DataGridView dgv, string FileName)
        {

            //declare the xmldocument object  
            XmlDocument xmldoc = new XmlDocument();
            //and also xmllistnode  
            XmlNodeList xmlnode;
            //declare the filestream for reading and accessing the xml file  
            FileStream fs = new FileStream("..\\XML\\" + FileName + ".xml", FileMode.Open, FileAccess.Read);
            //pass the filestreanm as object for xmlnode load event  
            xmldoc.Load(fs);
            //in this line we actuallty find our setting root name which i set it as column name sth look like this  
            //<setting>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //</setting>  
            xmlnode = xmldoc.GetElementsByTagName("column");
            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                //read the first node of the current column node and set it datagrideview name'  
                //and we are going to use it in our code for setting the columns properties  
                string columnName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                int width = int.Parse(xmlnode[i].ChildNodes.Item(1).InnerText.Trim());
                string headertext = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                int displayindex = int.Parse(xmlnode[i].ChildNodes.Item(3).InnerText.Trim());
                Boolean visible = Convert.ToBoolean(xmlnode[i].ChildNodes.Item(4).InnerText.Trim());
                //after finding and perparing data now i set the grid properties  
                //set the witdh  
                dgv.Columns[columnName].Width = width;
                //set the headertext  
                dgv.Columns[columnName].HeaderText = headertext;
                //set the column index it means the order of the column  
                dgv.Columns[columnName].DisplayIndex = displayindex;
                //set the visibility  
                dgv.Columns[columnName].Visible = visible;
            }
            fs.Close();
        }

        public  static void WriteGrideViewSetting(DataGridView dgv, string FileName)
        {
            //declaring teh xmlwritter object  
            XmlTextWriter settingwriter = new XmlTextWriter("..\\XML\\" + FileName + ".xml", null);

            //starting the root node which in this example i set the gridview name for this starting node  
            //<setting>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //</setting>  
            // the line blow declare the setting tag of the current example and specify the name for the this tag  
            settingwriter.WriteStartDocument();
            settingwriter.WriteStartElement(dgv.Name);
            int count = dgv.Columns.Count;
            //count the gridview column  
            for (int i = 0; i < count; i++)
            {
                //now create the column root node  
                settingwriter.WriteStartElement("column");
                //then creat the name node and fill the value in this node  
                settingwriter.WriteStartElement("Name");
                settingwriter.WriteString(dgv.Columns[i].Name);
                // close the name node  
                settingwriter.WriteEndElement();
                //these three node are declared similar to previous node  
                settingwriter.WriteStartElement("width");
                settingwriter.WriteString(dgv.Columns[i].Width.ToString());
                settingwriter.WriteEndElement();
                settingwriter.WriteStartElement("headertext");
                settingwriter.WriteString(dgv.Columns[i].HeaderText);
                settingwriter.WriteEndElement();
                settingwriter.WriteStartElement("displayindex");
                settingwriter.WriteString(dgv.Columns[i].DisplayIndex.ToString());
                settingwriter.WriteEndElement();
                settingwriter.WriteStartElement("visible");
                settingwriter.WriteString(dgv.Columns[i].Visible.ToString());
                settingwriter.WriteEndElement();
                //end the column node  
                settingwriter.WriteEndElement();
            }
            //end the main root of the xml file which is datagrid name  
            settingwriter.WriteEndElement();
            //end the settingwritter  
            settingwriter.WriteEndDocument();
            //the close the wriiter  
            settingwriter.Close();
        }

        public static void RestoreForm(Form form, System.Drawing.Size size, FormWindowState state,System.Drawing.Point location) 
        {
            if (size.Width == 0 || size.Height == 0)
            {
                // first start
                // optional: add default values
            }
            else
            {
                form.WindowState = state;

                // we don't want a minimized window at startup
                if (form.WindowState ==FormWindowState.Minimized) form.WindowState = FormWindowState.Normal;

                form.Location = location;
                form.Size = size;
            }
        }

        public static async void DeleteDocument(FlameTradeDbEntities db, Documents documents) 
        {
            //To Be updated

            try
            {
                if (documents.Issued == 0)
                {
                    List<DocumentTransactions> documentTransactionsList = db.DocumentTransactions.Where(dt1 => dt1.DocumentsID == documents.ID).ToList();
                    foreach (DocumentTransactions dt in documentTransactionsList)
                    {
                        List<TransactionLines> transactionLinesList = db.TransactionLines.Where(tl => tl.TransactionsID == dt.ID).ToList();
                        foreach (TransactionLines transactionLine in transactionLinesList)
                        {
                            List<TransactionRowsDependancy> transactionRowsDependancies = db.TransactionRowsDependancy.Where(trd => trd.ControlledTransactionRowID == transactionLine.ID | trd.ControllingTransactionRowID == transactionLine.ID).ToList();

                            foreach(TransactionRowsDependancy transactionRowsDependancy in transactionRowsDependancies)
                            {
                                db.TransactionRowsDependancy.Remove(transactionRowsDependancy);
                            }

                            await db.SaveChangesAsync();

                            db.TransactionLines.Remove(transactionLine);
                        }

                        List<TransactionPersons> transactionPersonsList = db.TransactionPersons.Where(tp => tp.DocumentTransactionsID == dt.ID).ToList();
                        foreach (TransactionPersons transactionPerson in transactionPersonsList)
                        {
                            db.TransactionPersons.Remove(transactionPerson);
                        }

                        List<TransactionsTransformations> transactionsTransformationsList = db.TransactionsTransformations.Where(tt => tt.TransactionID == dt.ID || tt.OriginTransactionID == dt.ID).ToList();
                        foreach (TransactionsTransformations transactionsTransformations in transactionsTransformationsList)
                        {
                            db.TransactionsTransformations.Remove(transactionsTransformations);
                        }

                        await db.SaveChangesAsync();
                        db.DocumentTransactions.Remove(dt);                        
                    }

                    List<DocumentsProjects> documentsProjectsList = db.DocumentsProjects.Where(dp => dp.DocumentsID == documents.ID).ToList();
                    foreach (DocumentsProjects project in documentsProjectsList)
                    {
                        db.DocumentsProjects.Remove(project);
                        
                    }

                    List<DocumentsAttachments> documentsAttachmentsList = db.DocumentsAttachments.Where(da => da.DocumentsID == documents.ID).ToList();
                    foreach (DocumentsAttachments documentsAttachments in documentsAttachmentsList)
                    {
                        db.DocumentsAttachments.Remove(documentsAttachments);
                        
                    }

                    List<DocumentTransformation> documentTransformationsList = db.DocumentTransformation.Where(dt1 => dt1.DocID == documents.ID || dt1.OriginDocID == documents.ID).ToList();
                    foreach (DocumentTransformation documentTransformation in documentTransformationsList)
                    {
                        db.DocumentTransformation.Remove(documentTransformation);
                        
                    }

                    List<DocumentsFinancialPlan> documentsFinancialPlans = db.DocumentsFinancialPlan.Where(dfp => dfp.DocumentID == documents.ID).ToList();
                    foreach(DocumentsFinancialPlan financialPlan in documentsFinancialPlans)
                    {
                        db.DocumentsFinancialPlan.Remove(financialPlan);
                    }

                    await db.SaveChangesAsync();

                    db.Documents.Remove(documents);
                    await db.SaveChangesAsync();
                }
                
            } catch (Exception ex) { SendErrorMsg(ex.Message); }
        }


        public static void SendEditRequestEmail(string htmlString, LogsEditRestrictedDocuments logsEditRestrictedDocuments)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Timeout = 10000;
                message.From = new MailAddress(Properties.Settings.Default.editRequestEmail);
                foreach (Users users in logsEditRestrictedDocuments.Roles.Users)
                {
                    if (users.SystemEmail != null)
                    {
                        message.To.Add(new MailAddress(users.SystemEmail));
                    }
                }
                message.Subject = "" + logsEditRestrictedDocuments.Documents.DocumentNumber.ToString() + "@" + logsEditRestrictedDocuments.Documents.DocumentSequences.SequenceName + " Edit Request from User :" + logsEditRestrictedDocuments.Users.UserName;
                message.IsBodyHtml = false; //to make message body as html  
                message.Body = htmlString;
                message.Priority = MailPriority.High;
                smtp.Port = 26;
                smtp.Host = Properties.Settings.Default.editRequestHost;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Properties.Settings.Default.editRequestUserName, Properties.Settings.Default.editRequestPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

        public static  void PerformInventoryTransactions(FlameTradeDbEntities db, Documents document, BindingSource documentTransactionsBindingSource)
        {
            try
            {
                if (document.DocumentSequences.IsReal==1)
                {
                    foreach(DocumentTransactions documentTransactions in documentTransactionsBindingSource)
                    {
                        foreach(TransactionLines transactionLines in documentTransactions.TransactionLines)
                        {
                            if (transactionLines.Items != null)
                            {
                                if (transactionLines.Inventory.Count == 0 && transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier != 0)
                                {
                                    Inventory inventory = new Inventory();
                                    inventory.Items = transactionLines.Items;
                                    inventory.TransactionLines = transactionLines;

                                    if (transactionLines.Qty != null )
                                    {
                                        if (transactionLines.Partitions1 != null && transactionLines.Partitions != null)
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.Partitions.Value * transactionLines.Partitions1.Value * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = transactionLines.Partitions;
                                            inventory.Partitions1 = transactionLines.Partitions1;
                                        }
                                        else if (transactionLines.Partitions != null && transactionLines.Partitions1 == null)
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.Partitions.Value * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = transactionLines.Partitions;
                                        }
                                        else if (transactionLines.Partitions == null && transactionLines.Partitions1 != null)
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.Partitions1.Value * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = db.Partitions.Where(p => p.ID == 1).SingleOrDefault();
                                            inventory.Partitions1 = transactionLines.Partitions1;
                                        }
                                        else
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = db.Partitions.Where(p => p.ID == 1).SingleOrDefault();
                                        }
                                    }
                                    else 
                                    {
                                        inventory.QTY = 0;
                                    }

                                    inventory.Price = transactionLines.CostPrice1;
                                    inventory.TransactionDate = DateTime.Now;

                                    if (transactionLines.Surfaces != null)
                                    {
                                        inventory.Surfaces = transactionLines.Surfaces;
                                    }
                                    else
                                    {
                                        inventory.Surfaces = db.Surfaces.Where(s => s.ID == 1).SingleOrDefault();
                                    }

                                    if (transactionLines.Warehouses != null)
                                    {
                                        inventory.Warehouses = transactionLines.Warehouses;
                                    } else
                                    {
                                        inventory.Warehouses = db.Warehouses.Where(w => w.WhID == 1).SingleOrDefault();
                                    }

                                    db.Inventory.Add(inventory);

                                } else if (transactionLines.Inventory.Count>0 && transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier != 0)
                                {
                                    Inventory inventory = (Inventory)transactionLines.Inventory.SingleOrDefault();
                                    inventory.Items = transactionLines.Items;
                                   // inventory.TransactionLines = transactionLines;
                                    if (transactionLines.Qty != null && transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier != 0)
                                    {
                                        if (transactionLines.Partitions1 != null && transactionLines.Partitions != null)
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.Partitions.Value * transactionLines.Partitions1.Value * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = transactionLines.Partitions;
                                            inventory.Partitions1 = transactionLines.Partitions1;
                                        }
                                        else if (transactionLines.Partitions != null && transactionLines.Partitions1 == null)
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.Partitions.Value * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = transactionLines.Partitions;
                                        }
                                        else if (transactionLines.Partitions == null && transactionLines.Partitions1 != null)
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.Partitions1.Value * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = db.Partitions.Where(p => p.ID == 1).SingleOrDefault();
                                            inventory.Partitions1 = transactionLines.Partitions1;
                                        }
                                        else
                                        {
                                            inventory.QTY = (double)transactionLines.Qty * transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier;
                                            inventory.Partitions = db.Partitions.Where(p => p.ID == 1).SingleOrDefault();
                                        }
                                    }
                                    else if (transactionLines.DocumentTransactions.TransactionsType.TransactionMultiplier != 0)
                                    {
                                        inventory.QTY = 0;
                                    }

                                    inventory.Price = transactionLines.CostPrice1;
                                    inventory.TransactionDate = DateTime.Now;

                                    if (transactionLines.Surfaces != null)
                                    {
                                        inventory.Surfaces = transactionLines.Surfaces;
                                    }
                                    else
                                    {
                                        inventory.Surfaces = db.Surfaces.Where(s => s.ID == 1).SingleOrDefault();
                                    }

                                    if (transactionLines.Warehouses != null)
                                    {
                                        inventory.Warehouses = transactionLines.Warehouses;
                                    }
                                    else
                                    {
                                        inventory.Warehouses = db.Warehouses.Where(w => w.WhID == 1).SingleOrDefault();
                                    }
                                }
                            }

                            if (transactionLines.Services!=null)
                            {

                            } 
                            
                            if (transactionLines.Machines!=null) 
                            {

                            }
                        }
                    }
                }
               // await db.SaveChangesAsync();
            } catch 
            {
                CommonTasks.SendErrorMsg("Нещо се обърка при запаметяване на операциите свързани със склада");
            }
        }

        public static void PerformAccountingOperations(Documents newDocument, FlameTradeDbEntities db)
        {  
            try
            {
                    if (newDocument.DocumentSequences.IsGeneratingAccountingEntry == 1)
                    {                           
                         foreach (DocumentTransactions transactions in newDocument.DocumentTransactions)
                         {
                            if (transactions.AccountingEntriesModel != null)
                            {
                                foreach (AccountingEntriesModelDetails modelDetails in transactions.AccountingEntriesModel.AccountingEntriesModelDetails)
                                {
                                    if (modelDetails.Accounts1 != null)
                                    {
                                        AccountingEntries newDebitAccountEntries = new AccountingEntries();

                                        bool exists = false;

                                        foreach (AccountingEntries existingEntries in transactions.AccountingEntries)
                                        {
                                            if (existingEntries.Accounts == modelDetails.Accounts1 && existingEntries.AccountingEntriesModelDetails == modelDetails)
                                            {
                                                exists = true;
                                            }
                                        }

                                        if (exists == true)
                                        {
                                            newDebitAccountEntries = transactions.AccountingEntries.Where(ae => ae.AccountID == modelDetails.Accounts1.ID && ae.OriginModelDetailID == modelDetails.ID).SingleOrDefault();
                                            if (modelDetails.VATAccountID != null & modelDetails.VatType == 2)
                                            {
                                                newDebitAccountEntries.DebitValue = 1 * modelDetails.PercentOfValue + 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            else
                                            {
                                                newDebitAccountEntries.DebitValue = 1 * modelDetails.PercentOfValue;
                                            }


                                        }
                                        else
                                        {
                                            newDebitAccountEntries.Accounts = modelDetails.Accounts1;
                                            if (modelDetails.VATAccountID != null & modelDetails.VatType == 2)
                                            {
                                                newDebitAccountEntries.DebitValue = 1 * modelDetails.PercentOfValue + 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            else
                                            {
                                                newDebitAccountEntries.DebitValue = 1 * modelDetails.PercentOfValue;
                                            }
                                            newDebitAccountEntries.EntryDate = DateTime.Now;
                                            newDebitAccountEntries.Documents = newDocument;
                                            newDebitAccountEntries.DocumentTransactions = transactions;
                                            newDebitAccountEntries.AccountingCatalogID = 1;
                                            newDebitAccountEntries.IsVATEntry = 0;
                                            newDebitAccountEntries.AccountingEntriesModel = modelDetails.AccountingEntriesModel;
                                            newDebitAccountEntries.AccountingEntriesModelDetails = modelDetails;

                                            db.AccountingEntries.Add(newDebitAccountEntries);
                                        }



                                    }

                                    if (modelDetails.Accounts != null)
                                    {
                                        AccountingEntries newCreditAccountEntries = new AccountingEntries();


                                        bool exists = false;

                                        foreach (AccountingEntries existingEntries in transactions.AccountingEntries)
                                        {
                                            if (existingEntries.Accounts == modelDetails.Accounts && existingEntries.AccountingEntriesModelDetails == modelDetails)
                                            {
                                                exists = true;
                                            }
                                        }

                                        if (exists == true)
                                        {
                                            newCreditAccountEntries = transactions.AccountingEntries.Where(ae => ae.AccountID == modelDetails.Accounts.ID && ae.OriginModelDetailID == modelDetails.ID).SingleOrDefault();
                                            if (modelDetails.VATAccountID != null && modelDetails.VatType == 1)
                                            {
                                                newCreditAccountEntries.CreditValue = 1 * modelDetails.PercentOfValue + 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            else
                                            {
                                                newCreditAccountEntries.CreditValue = 1 * modelDetails.PercentOfValue;
                                            }
                                        }
                                        else
                                        {
                                            newCreditAccountEntries.Accounts = modelDetails.Accounts;
                                            if (modelDetails.VATAccountID != null && modelDetails.VatType == 1)
                                            {
                                                newCreditAccountEntries.CreditValue = 1 * modelDetails.PercentOfValue + 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            else
                                            {
                                                newCreditAccountEntries.CreditValue = 1 * modelDetails.PercentOfValue;
                                            }
                                            newCreditAccountEntries.EntryDate = DateTime.Now;
                                            newCreditAccountEntries.Documents = newDocument;
                                            newCreditAccountEntries.DocumentTransactions = transactions;
                                            newCreditAccountEntries.AccountingCatalogID = 1;
                                            newCreditAccountEntries.IsVATEntry = 0;
                                            newCreditAccountEntries.AccountingEntriesModel = modelDetails.AccountingEntriesModel;
                                            newCreditAccountEntries.AccountingEntriesModelDetails = modelDetails;
                                            db.AccountingEntries.Add(newCreditAccountEntries);
                                        }
                                    }

                                    if (modelDetails.Accounts2 != null)
                                    {
                                        AccountingEntries newVATEntry = new AccountingEntries();

                                        bool exists = false;

                                        foreach (AccountingEntries existingEntries in transactions.AccountingEntries)
                                        {
                                            if (existingEntries.Accounts == modelDetails.Accounts2 && existingEntries.AccountingEntriesModelDetails == modelDetails)
                                            {
                                                exists = true;
                                            }
                                        }

                                        if (exists == true)
                                        {
                                            newVATEntry = transactions.AccountingEntries.Where(ae => ae.AccountID == modelDetails.Accounts2.ID && ae.OriginModelDetailID == modelDetails.ID).SingleOrDefault();
                                            if (modelDetails.VatType == 1)
                                            {
                                                newVATEntry.DebitValue = 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            else if (modelDetails.VatType == 2)
                                            {
                                                newVATEntry.CreditValue = 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }

                                        }
                                        else
                                        {
                                            newVATEntry.Accounts = modelDetails.Accounts2;
                                            newVATEntry.IsVATEntry = 1;
                                            if (modelDetails.VatType == 1)
                                            {
                                                newVATEntry.DebitValue = 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            else if (modelDetails.VatType == 2)
                                            {
                                                newVATEntry.CreditValue = 1 * modelDetails.PercentOfValue * modelDetails.VATPercent;
                                            }
                                            newVATEntry.EntryDate = DateTime.Now;
                                            newVATEntry.Documents = newDocument;
                                            newVATEntry.DocumentTransactions = transactions;
                                            newVATEntry.AccountingCatalogID = 1;
                                            newVATEntry.AccountingEntriesModel = modelDetails.AccountingEntriesModel;
                                            newVATEntry.AccountingEntriesModelDetails = modelDetails;
                                            db.AccountingEntries.Add(newVATEntry);
                                        }
                                    }
                                }
                            }
                        }
                       //     await db.SaveChangesAsync();
                    }
            } catch { CommonTasks.SendErrorMsg("Нещо се обърка, счетовордният запис не е запазен!!!"); }
        }
    }
}
