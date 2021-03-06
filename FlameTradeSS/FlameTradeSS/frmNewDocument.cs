using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmNewDocument : Form
    {
        public frmNewDocument()
        {
            InitializeComponent();
        }
        int maxID;

        List<TransactionsType> existingTransactionTypes = new List<TransactionsType>();

        private void frmNewDocument_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Hide();

            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmNewDocumentSize, Properties.Settings.Default.frmNewDocumentState, Properties.Settings.Default.frmNewDocumentLocation);

            newDocument = new Documents();
            newDocument.DocumentDate = DateTime.Now;
            newDocument.Users = db.Users.Where(u => u.ID == CurrentSessionData.CurrentUser.ID).SingleOrDefault();
            documentsBindingSource.DataSource = newDocument;

            maxID = db.DocumentTransactions.Max(dt => (int)dt.tempID);

            CurrentSessionData.Counter = maxID;            

            newDocument.DocumentDate = DateTime.Now;
            partnersBindingSource.DataSource = db.Partners.ToList();
            Partners nullPartner = new Partners();
            partnersBindingSource.Add(nullPartner);
            documentTransactionsBindingSource.DataSource = db.DocumentTransactions.Where(dt => dt.DocumentsID == newDocument.ID).ToList();
            cmbPartners.SelectedItem = nullPartner;
            cmbPartners.Enabled = false;
            txtDocumentNumber.Enabled = false;
            listBoxTransactionsAdd.Enabled = false;
            listBoxProjects.Enabled = false; 
            DocumentSequences nullDocumentSequence = new DocumentSequences();
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            documentSequencesBindingSource.Add(nullDocumentSequence);
            cmbDocumentSequence.SelectedItem = nullDocumentSequence;
            transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
            usersBindingSource.DataSource = db.Users.ToList();
            surfacesBindingSource.DataSource = db.Surfaces.ToList();
            receiptModelsBindingSource.DataSource = db.ReceiptModels.ToList();
            TransactionSurfaceID.ReadOnly = true;

            

            transactionsTypeBindingSource1.Add(new TransactionsType() { TypeName = "Всички" });
            foreach (DataGridViewRow dgvr in dgvDocumentTransactions.Rows)
            {
                DocumentTransactions documentTransactions = dgvr.DataBoundItem as DocumentTransactions;
                if (documentTransactions != null)
                {
                    //TransactionsType trt = documentTransactions.TransactionsType;

                    if (existingTransactionTypes.Where(trt => trt.Equals(documentTransactions.TransactionsType)).SingleOrDefault() == null)
                    {
                        transactionsTypeBindingSource1.Add(documentTransactions.TransactionsType);
                        existingTransactionTypes.Add(documentTransactions.TransactionsType);
                    }
                }
            }

            documentsProjectsBindingSource.DataSource = db.DocumentsProjects.Where(dp => dp.DocumentsID == newDocument.ID).ToList();

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvDocumentTransactions, Name + dgvDocumentTransactions.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }

            if( newDocument.IsBlocked == 0)
            {
                checkBoxIsBlocked.CheckState = System.Windows.Forms.CheckState.Unchecked;
            } else if (newDocument.IsBlocked == 1)
            {
                checkBoxIsBlocked.CheckState = CheckState.Checked;
            }
            db.Documents.Add(newDocument);

            Cursor.Current = Cursors.Default;
            Show();
        }

        private static readonly SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        public static Documents newDocument;

        private async void frmNewDocument_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.frmNewDocumentState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmNewDocumentLocation = this.Location;
                Properties.Settings.Default.frmNewDocumentSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmNewDocumentLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmNewDocumentSize = this.RestoreBounds.Size;
            }

            bool dispose = true;

            // don't forget to save the settings
            Properties.Settings.Default.Save();

            try
            {
                CommonTasks.WriteGrideViewSetting(dgvDocumentTransactions, Name + dgvDocumentTransactions.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            if (newDocument.Issued == 0)
            {
                DialogResult dialogResult = CommonTasks.SendQuestionMsg("Искате ли да запазите документа?");

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        //foreach(TransactionRowsDependancy transactionRowsDependancy in db.TransactionRowsDependancy.Where(tlrd => tlrd.TransactionLines.DocumentTransactions.DocumentsID==newDocument.ID))

                        dgvDocumentTransactions.Dispose();
                        await db.SaveChangesAsync();

                        foreach (TransactionRowsDependancy transactionRowsDependancy in db.TransactionRowsDependancy.Where(tlrd => tlrd.TransactionLines.DocumentTransactions.DocumentsID == newDocument.ID))
                        {
                            foreach(TransactionLines transactionLines in db.TransactionLines.Where(tl => tl.ID == transactionRowsDependancy.TransactionLines1.ID))
                            {
                                TransactionLines dependantTL = transactionRowsDependancy.TransactionLines;
                                switch (transactionRowsDependancy.ControlledParameter)
                                {
                                    case "RemainingQTY":
                                        if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                        {
                                            transactionLines.RemainingQTY = transactionLines.RemainingQTY - transactionRowsDependancy.TransactionLines.Qty;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        else
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingQTY = transactionLines.RemainingQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }

                                        break;
                                    case "RemainingInvoiceQTY":
                                        if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                        {
                                            transactionLines.RemainingInvoiceQTY = transactionLines.RemainingInvoiceQTY - transactionRowsDependancy.TransactionLines.Qty;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        else
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingInvoiceQTY = transactionLines.RemainingInvoiceQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        break;
                                    case "RemainingDeliveryQTY":
                                        if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                        {
                                            transactionLines.RemainingDeliveryQTY = transactionLines.RemainingDeliveryQTY - transactionRowsDependancy.TransactionLines.Qty;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        else
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingDeliveryQTY = transactionLines.RemainingDeliveryQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        break;
                                    case "RemainingPackagingQTY":
                                        if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                        {
                                            transactionLines.RemainingPackagingQTY = transactionLines.RemainingPackagingQTY - transactionRowsDependancy.TransactionLines.Qty;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        else
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingPackagingQTY = transactionLines.RemainingPackagingQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        break;
                                    case "RemainingProductionQTY":
                                        if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                        {
                                            transactionLines.RemainingProductionQTY = transactionLines.RemainingProductionQTY - transactionRowsDependancy.TransactionLines.Qty;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        else
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingProductionQTY = transactionLines.RemainingProductionQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                        break;
                                }
                            }
                        }
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else if (dialogResult == DialogResult.No)
                {
                    try
                    {
                        CommonTasks.WriteGrideViewSetting(dgvDocumentTransactions, Name + dgvDocumentTransactions.Name + CurrentSessionData.CurrentUser.UserName);
                    }
                    catch { }

                    dgvDocumentTransactions.Dispose();
                }
                else
                {
                    e.Cancel = true;
                    dispose = false;
                }
            }
            if (dispose == true)
            {
                dgvDocumentTransactions.Dispose();
            }
        }

        private void cmbDocumentSequence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDocumentSequence.SelectedIndex != documentSequencesBindingSource.Count-1 )
            {
                cmbPartners.Enabled = true;
                
                listBoxProjects.Enabled = true;
                documentsAttachmentsBindingSource.DataSource = db.DocumentsAttachments.Where(da => da.DocumentsID == newDocument.ID).ToList();
                DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;
               
               /* if (selectedDocumentSequence != null)
                {
                    newDocument.DocumentSequences = selectedDocumentSequence;
                }*/
                
                DgvOperations dgvOperations = new DgvOperations();
                dgvDocumentTransactions = dgvOperations.ConfigureDgv(dgvDocumentTransactions, db, selectedDocumentSequence, new DocumentTransactions());


                if (selectedDocumentSequence.SequenceType.PartnerType =="Customer")
                {
                    List<Partners> customers = new List<Partners>();

                    foreach (Customers isCustomer in db.Customers.ToList())
                    {
                        customers.Add(db.Partners.Where(p => p.ID == isCustomer.PartnerID).SingleOrDefault());
                    }

                    partnersBindingSource.DataSource = customers;
                    cmbPartners.SelectedItem = null;
                } else if (selectedDocumentSequence.SequenceType.PartnerType == "Supplier")
                {
                    List<Partners> suppliers = new List<Partners>();

                    foreach (Suppliers isSupler in db.Suppliers.ToList())
                    {
                        suppliers.Add(db.Partners.Where(ps => ps.ID == isSupler.PartnerID).SingleOrDefault());
                    }
                    partnersBindingSource.DataSource = suppliers;
                    cmbPartners.SelectedItem = null;
                }

                if (selectedDocumentSequence.SequenceType.NumberingReference == "Invoice Numbering ")
                {
                    txtDocumentNumber.Enabled = false;
                    txtDocumentNumber.Text = "0";
                }
                else if (selectedDocumentSequence.SequenceType.NumberingReference == "Standart Numbering")
                {
                    txtDocumentNumber.Enabled = false;
                    txtDocumentNumber.Text = "0";
                }
                else
                {
                    txtDocumentNumber.Enabled = true;
                }

                List<SequencesTransactions> lines = new List<SequencesTransactions>();

                lines = db.SequencesTransactions.Where(sq => sq.SquenceID == selectedDocumentSequence.ID).ToList();

                if (lines!=null)
                {
                    listBoxTransactionsAdd.Enabled = true;
                    listBoxTransactionsAdd.Items.Clear();
                    foreach (SequencesTransactions possible in lines.ToList())
                    {
                        listBoxTransactionsAdd.Items.Add(possible.TransactionsType);
                        listBoxTransactionsAdd.DisplayMember = "TypeName";
                    }
                }

            } else
            {
                listBoxTransactionsAdd.Items.Clear();
            }
        }


        private  void listBoxTransactionsAdd_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTransactionsAdd.SelectedItem!=null)
            {

                if (cmbPartners.SelectedValue == null)
                {
                    CommonTasks.SendErrorMsg("Не е избран Партьор! \n Моля не забравяйте да изберете партьор преди да продъжите.");
                }

                TransactionsType selectedTransactionType = listBoxTransactionsAdd.SelectedItem as TransactionsType;
                DocumentTransactions newDocumentTransaction = new DocumentTransactions();

                int tempID = CurrentSessionData.Counter + 1;

                CurrentSessionData.Counter = tempID;

                newDocumentTransaction.TransactionsType = selectedTransactionType;
                newDocumentTransaction.Documents = newDocument;
                newDocumentTransaction.UserID =CurrentSessionData.CurrentUser.ID;
                newDocumentTransaction.CreationDateTime = DateTime.Now;
                newDocumentTransaction.TransactionDate = DateTime.Now;
                newDocumentTransaction.AccountingEntriesModel = selectedTransactionType.AccountingEntriesModel;
                newDocumentTransaction.ReceiptModels = db.ReceiptModels.Where(rm => rm.ID == 1).SingleOrDefault(); ;

                frmDocumentTransactions newfrmDocumentTransactions = new frmDocumentTransactions();
                newDocumentTransaction.tempID = tempID;
                newfrmDocumentTransactions.Name = newfrmDocumentTransactions.Name + newDocumentTransaction.tempID;
                
                newfrmDocumentTransactions.documentTransactions = newDocumentTransaction;
                newfrmDocumentTransactions.db = db;
                db.DocumentTransactions.Add(newDocumentTransaction);
                newfrmDocumentTransactions.transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
                newfrmDocumentTransactions.MdiParent = this;
                documentTransactionsBindingSource.Add(newDocumentTransaction);
                documentTransactionsBindingSource.MoveLast();

                TabPage newTabFrmDocumentTransactions = new TabPage();

                newTabFrmDocumentTransactions.Name = newfrmDocumentTransactions.Name;
                newTabFrmDocumentTransactions.Text = selectedTransactionType.TypeName + " " + tempID.ToString();
                tabControlMain.TabPages.Add(newTabFrmDocumentTransactions);
                newTabFrmDocumentTransactions.Parent = tabControlMain;

                newTabFrmDocumentTransactions.Show();

                newfrmDocumentTransactions.TabCtrl = tabControlMain;
                newfrmDocumentTransactions.TabPag = newTabFrmDocumentTransactions;

                newfrmDocumentTransactions.Show();
                cmbDocumentSequence.Enabled = false;

                if (existingTransactionTypes.Where(trt => trt.Equals(selectedTransactionType)).SingleOrDefault() == null)
                {
                    existingTransactionTypes.Add(selectedTransactionType);
                    transactionsTypeBindingSource1.Add(selectedTransactionType);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentTransactions documentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;


            if (e.RowIndex != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem != null && e.ColumnIndex == TransactionSurfaceID.Index)
            {
                frmSurfaceSelector frmSurfaceSelector = new frmSurfaceSelector();
                frmSurfaceSelector.db = db;
                frmSurfaceSelector.surfaceTypes = db.SurfaceTypes.Where(st => st.ID == documentTransactions.TransactionsType.DefaultSurfaceTypeID).SingleOrDefault();
                frmSurfaceSelector.FormClosing += FrmSurfaceSelector_FormClosing;
                CommonTasks.OpenForm(frmSurfaceSelector);
            }else if (e.RowIndex != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem!=null )
            {
                bool isOpened = false;

                
                frmDocumentTransactions newfrmDocumentTransactions = new frmDocumentTransactions();

                newfrmDocumentTransactions.Name = newfrmDocumentTransactions.Name + documentTransactions.tempID.ToString();

                foreach (frmDocumentTransactions form in MdiChildren)
                {
                    if (form.Name == newfrmDocumentTransactions.Name)
                    {
                        isOpened = true;
                        form.Show();
                        newfrmDocumentTransactions.Dispose();
                        foreach(TabPage tabPage in tabControlMain.TabPages )
                        {
                            if (tabPage.Name == form.Name)
                            {
                                form.TabCtrl = tabControlMain ;
                                form.TabPag = tabPage;
                            } 
                        } 
                        break;
                    }
                }

                if (!isOpened)
                {
                    newfrmDocumentTransactions.transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
                    newfrmDocumentTransactions.MdiParent = this;
                    newfrmDocumentTransactions.documentTransactions = documentTransactions;
                    newfrmDocumentTransactions.db = db;

                    TabPage newTabFrmDocumentTransactions = new TabPage();
                    DocumentTransactions selectedTransactionType = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;

                    newTabFrmDocumentTransactions.Name = newfrmDocumentTransactions.Name;
                    newTabFrmDocumentTransactions.Text = selectedTransactionType.TransactionsType.TypeName + " " + documentTransactions.tempID.ToString();
                    tabControlMain.TabPages.Add(newTabFrmDocumentTransactions);
                    newTabFrmDocumentTransactions.Parent = tabControlMain;

                    newTabFrmDocumentTransactions.Show();
                    newfrmDocumentTransactions.TabCtrl = tabControlMain;
                    newfrmDocumentTransactions.TabPag = newTabFrmDocumentTransactions;

                    newfrmDocumentTransactions.Show();
                }
            }
        }

        private void FrmSurfaceSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSurfaceSelector frmSurfaceSelector = sender as frmSurfaceSelector;

            if (frmSurfaceSelector.xClicked != true && frmSurfaceSelector.dgvItemsSelector.CurrentRow.DataBoundItem != null)
            {
                Surfaces surfaces = frmSurfaceSelector.dgvItemsSelector.CurrentRow.DataBoundItem as Surfaces;
                dgvDocumentTransactions.CurrentRow.Cells[TransactionSurfaceID.Index].Value = surfaces.ID;

            }
        }

        private void contextMenuStripProjects_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuItemAdd)
            {
                frmProjectSelector projectSelector = new frmProjectSelector();
                projectSelector.db = db;
                projectSelector.FormClosing += ProjectSelector_FormClosing;

                CommonTasks.OpenForm(projectSelector);
            }
        }

        private void ProjectSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmProjectSelector projectSelector = (frmProjectSelector)sender;
            if (projectSelector.xClicked != true)
            {
                if (projectSelector.dgvProjects.CurrentRow.DataBoundItem != null)
                {
                    Project project = projectSelector.dgvProjects.CurrentRow.DataBoundItem as Project;
                    DocumentsProjects addProject = new DocumentsProjects();
                    addProject.ProjectID = project.ID;
                    addProject.DocumentsID = newDocument.ID;
                    documentsProjectsBindingSource.Add(addProject);
                    db.DocumentsProjects.Add(addProject);
                    documentsProjectsBindingSource.DataSource = db.DocumentsProjects.Where(dp => dp.DocumentsID == newDocument.ID).ToList();
                    projectBindingSource.Add(project);
                }
            }
        }

        private void contextMenuStripProjects_Opening(object sender, CancelEventArgs e)
        {
            ToolStripMenuItem removeProject = new ToolStripMenuItem();
            List<object> tsti = new List<object>();
            foreach (object obj in contextMenuStripProjects.Items)
            {
                tsti.Add(obj);
            }

            foreach (object toolStripMenuItem in tsti)
            {
                try
                {
                    ToolStripMenuItem toolStrip = toolStripMenuItem as ToolStripMenuItem;

                    if (toolStrip != null && toolStrip.Text == "Премахни Проект")
                    {
                        contextMenuStripProjects.Items.Remove(toolStrip);
                    }
                }
                catch { }
            }

            if (listBoxProjects.SelectedItem != null)
            {
                removeProject.Text = "Премахни Проект";
                removeProject.Click += RemoveProject_Click;
                contextMenuStripProjects.Items.Add(removeProject);
            }
        }

        private void RemoveProject_Click(object sender, EventArgs e)
        {
            Project selectedProject = listBoxProjects.SelectedItem as Project;
            if (selectedProject != null)
            {
                DocumentsProjects documentsProjects = db.DocumentsProjects.Where(dp => dp.ProjectID == selectedProject.ID && dp.DocumentsID == newDocument.ID).FirstOrDefault();
                if (documentsProjects != null)
                {
                    projectBindingSource.Remove(selectedProject);
                    documentsProjectsBindingSource.Remove(documentsProjects);
                    db.DocumentsProjects.Remove(documentsProjects);
                }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            FileDialog dialog = (FileDialog)sender;

            if (dialog.CheckFileExists == true)
            {
                try
                {
                    string filename = Path.GetFileName(dialog.FileName);
                    byte[] data = File.ReadAllBytes(dialog.FileName);

                    DocumentsAttachments uploadedFiles = new DocumentsAttachments();
                    uploadedFiles.FileName = filename;
                    uploadedFiles.FileData = data;
                    uploadedFiles.DocumentsID = newDocument.ID;
                    documentsAttachmentsBindingSource.Add(uploadedFiles);
                    db.DocumentsAttachments.Add(uploadedFiles);

                    MessageBox.Show("Файлът е качен успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (dgvAttachments.CurrentRow != null && dgvAttachments.CurrentRow.Index != -1 & dgvAttachments.CurrentRow.DataBoundItem != null)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да изтриете файл :" + dgvAttachments.CurrentRow.Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DocumentsAttachments uploadedFile = dgvAttachments.CurrentRow.DataBoundItem as DocumentsAttachments;
                    documentsAttachmentsBindingSource.Remove(uploadedFile);
                    db.DocumentsAttachments.Remove(uploadedFile);
                }
            }
        }

        private void dgvAttachments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvAttachments.Rows[e.RowIndex].DataBoundItem != null)
            {
                DocumentsAttachments uploadedFiles = new DocumentsAttachments();
                uploadedFiles = dgvAttachments.Rows[e.RowIndex].DataBoundItem as DocumentsAttachments;
                byte[] bytes = uploadedFiles.FileData;

                saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.FileName = uploadedFiles.FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.FileName = saveFileDialog1.FileName;
                    try
                    {
                        FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                        fs.Write(bytes, 0, bytes.Length);

                        fs.Close();

                        if (MessageBox.Show("Искате ли да стартирате файл : " + saveFileDialog1.FileName, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                Process.Start(saveFileDialog1.FileName);
                                MessageBox.Show("Файла е успешно записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Възникна грешка при записшане на файла, файла не записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void checkBoxIsBlocked_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxIsBlocked.DataBindings != null)
            {
                if (checkBoxIsBlocked.CheckState == CheckState.Checked)
                {
                    newDocument.IsBlocked = 1;
                }
                else
                {
                    newDocument.IsBlocked = 0;
                }
            }
        }

        private void txtDocumentNumber_EnabledChanged(object sender, EventArgs e)
        {
            if (txtDocumentNumber.Enabled == false)
            {
                btnIssueDocument.Enabled = true;
            }
            else
            {
                btnIssueDocument.Enabled = false;
            }
        }

        private async void btnIssueDocument_Click(object sender, EventArgs e)
        {
            if (newDocument.DocumentSequences!=null)
            {
                switch (newDocument.DocumentSequences.SequenceType.NumberingReference)
                {
                    case "Invoice Numbering ":
                        if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да издадете Документ : " + newDocument.DocumentNumber.ToString() + "@" + newDocument.DocumentSequences.SequenceName) == true)
                        {
                            if (documentTransactionsBindingSource.Count == 0 & cmbPartners.SelectedItem == null)
                            {
                                CommonTasks.SendErrorMsg("Не можете да издадете Документ без Редове и/или избран Партньор");
                            }
                            else
                            {
                                try
                                {
                                    int maxInvoiceN = db.InvoiceNumbering.Max(inv => inv.number);
                                    newDocument.DocumentNumber = maxInvoiceN + 1;
                                    InvoiceNumbering invoiceNumbering = new InvoiceNumbering();

                                    invoiceNumbering.documentID = newDocument.ID;
                                    invoiceNumbering.number = (int)newDocument.DocumentNumber;
                                    db.InvoiceNumbering.Add(invoiceNumbering);
                                    newDocument.Issued = 1;
                                    btnIssueDocument.Enabled = false;
                                    btnCancel.Enabled = true;
                                    cmbDocumentSequence.Enabled = false;
                                    cmbPartners.Enabled = false;
                                    dateTimeDocDate.Enabled = false;
                                    dgvDocumentTransactions.ReadOnly = true;
                                    listBoxTransactionsAdd.Enabled = false;
                                  
                                    await db.SaveChangesAsync();
                                    CommonTasks.SendInfoMsg("Документа е успешно издаден : "+newDocument.DocumentNumber.ToString()+"@"+newDocument.DocumentSequences.SequenceName);
                                    CommonTasks.PerformInventoryTransactions(db, newDocument, documentTransactionsBindingSource);
                                }
                                catch { CommonTasks.SendErrorMsg("Документа НЕ е издаден : " + newDocument.DocumentNumber.ToString() + "@" + newDocument.DocumentSequences.SequenceName); }
                            }

                        }
                        break;
                    case "Standart Numbering":
                        if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да издадете Документ : " + newDocument.DocumentSequences.SequenceName + "?") == true)
                        {
                            try
                            {
                                List<Numbering> maxNumber = new List<Numbering>();
                                maxNumber = db.Numbering.Where(n => n.SequenceID == newDocument.DocumentSequenceID).ToList();
                                int maxSeqNumber;
                                if (maxNumber.Count == 0)
                                {
                                    maxSeqNumber = 0;
                                }
                                else
                                {
                                    maxSeqNumber = maxNumber.Max(m => m.MaxSequenceNumber);
                                }

                                newDocument.DocumentNumber = maxSeqNumber + 1;
                                Numbering numbering = new Numbering();
                                numbering.MaxSequenceNumber = (int)newDocument.DocumentNumber;
                                numbering.SequenceID = newDocument.DocumentSequenceID;
                                db.Numbering.Add(numbering);
                                documentsBindingSource.DataSource = newDocument;
                                newDocument.Issued = 1;
                                btnIssueDocument.Enabled = false;
                                btnCancel.Enabled = true;
                                cmbDocumentSequence.Enabled = false;
                                cmbPartners.Enabled = false;
                                dateTimeDocDate.Enabled = false;
                                dgvDocumentTransactions.ReadOnly = true;
                                listBoxTransactionsAdd.Enabled = false;
                               
                                await db.SaveChangesAsync();
                                CommonTasks.SendInfoMsg("Документа е издаден успешно : " + newDocument.DocumentNumber.ToString() + "@" + newDocument.DocumentSequences.SequenceName);
                            }
                            catch { CommonTasks.SendErrorMsg("Документа НЕ е издаден"); }
                        }
                        break;
                }
            } else { CommonTasks.SendErrorMsg("Необходимо е документа да има избрана серия, партьор и добавени транзакции"); }
        }

        private void cmbPartners_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbPartners = (ComboBox)sender;

            if (Convert.ToInt32(cmbPartners.SelectedValue )!= 0)
            {
                listBoxTransactionsAdd.Enabled = true;
            //    newDocument.Partners = cmbPartners.SelectedItem as Partners;    
            } else
            {
                listBoxTransactionsAdd.Enabled = false;
            }
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            foreach (frmDocumentTransactions form in MdiChildren)
            {
                if (e.TabPageIndex != -1 && form.Name == tabControl.TabPages[e.TabPageIndex].Name)
                {
                    form.BringToFront();
                    form.Focus();
                }
            }
        }

        private void cmbSequenceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox filter = (ComboBox)sender;
            TransactionsType transactionsType = filter.SelectedItem as TransactionsType;
            if (transactionsType != null)
            {
                if (filter.SelectedIndex != 0)
                {
                    documentTransactionsBindingSource.DataSource = db.DocumentTransactions.Where(dt => dt.DocumentsID == newDocument.ID && dt.TransactionTypeID == transactionsType.ID).ToList();
                }
                else
                {
                    documentTransactionsBindingSource.DataSource = db.DocumentTransactions.Where(dt => dt.DocumentsID == newDocument.ID).ToList();
                }
            }
        }

        private void dgvDocumentTransactions_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index == TransactionTypes_TransactionTypeID_TypeName_ID.Index)
            {
                cmbSequenceFilter.Width = TransactionTypes_TransactionTypeID_TypeName_ID.Width;
            }
        }

        TextBox txtFilter;
        ComboBox cmbFilter;

        private void btnTransformFrom_Click(object sender, EventArgs e)
        {
            Panel panelTransformFrom = new Panel();
            panelTransformFrom.Location = btnTransformFrom.Location;
            panelTransformFrom.Width = 550;
            panelTransformFrom.Height = 600;
            panelTransformFrom.BorderStyle = BorderStyle.Fixed3D;
            panelTransformFrom.AutoScroll = true;
            
            this.Controls.Add(panelTransformFrom);
            panelTransformFrom.BringToFront();

            Button ok = new Button();
            ok.Text = "Вмъкни избраните документи";
            ok.Width = 200;
            Point okPoint = new Point();
            okPoint.X = 5;
            okPoint.Y = 5;
            ok.Location = okPoint;
            Button cancel = new Button();
            cancel.Text = "Отказ";
            cancel.Click += Cancel_Click;
            Point cancelPoint = new Point();
            cancelPoint.X = 205;
            cancelPoint.Y = 5;
            cancel.Location = cancelPoint;

            panelTransformFrom.Controls.Add(ok);
            panelTransformFrom.Controls.Add(cancel);

            Point lblFilterPoint = new Point();
            lblFilterPoint.X = 5;
            lblFilterPoint.Y = 50;
            Label lblFilter = new Label()
            {
                Text = "Филтър за серия :",
                Location = lblFilterPoint,
                Width = 110
            };

            panelTransformFrom.Controls.Add(lblFilter);

            Point cmbFilterPoint = new Point();
            cmbFilterPoint.X = 115;
            cmbFilterPoint.Y = 50;

            Point lblTextFilterPoint = new Point();
            lblTextFilterPoint.X = 5;
            lblTextFilterPoint.Y = 90;

            Label lblTextFilter = new Label()
            {
                Text = "Филтър :",
                Location = lblTextFilterPoint,
                Width = 50
            };

            panelTransformFrom.Controls.Add(lblTextFilter);

            Point txtFilterPoint = new Point();
            txtFilterPoint.X = 55;
            txtFilterPoint.Y = 90;

            txtFilter = new TextBox()
            {
                Name = "txtFilter",
                Location = txtFilterPoint,
                Width = 200,
            };
            txtFilter.TextChanged += TxtFilter_TextChanged;

            panelTransformFrom.Controls.Add(txtFilter);


            //BindingSource cmbFilterBinding = new BindingSource();
            List<DocumentSequences> possibleList = new List<DocumentSequences>();

            DocumentSequences selectedSequence = cmbDocumentSequence.SelectedItem as DocumentSequences; 

            if (selectedSequence.SequenceName != null)
            {
                foreach (PossibleSequenceTransofrmation pst in db.PossibleSequenceTransofrmation.Where(pt => pt.PossibleDocumentSequenceID == selectedSequence.ID ).ToList())
                {
                    possibleList.Add(pst.DocumentSequences);
                }

                cmbFilter = new ComboBox()
                {
                    Name = "cmbFilter",
                    DataSource = possibleList,
                    DisplayMember = "SequenceName",
                    ValueMember = "ID",
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    //SelectedIndex = 0,
                    Location = cmbFilterPoint
                };
                cmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;
                panelTransformFrom.Controls.Add(cmbFilter);

                Point poitDgv = new Point()
                {
                    X = 5,
                    Y = 120
                };

                BindingSource transformBinding = new BindingSource() { DataSource = typeof(Documents)};
                BindingSource sequenceBinding = new BindingSource();
                sequenceBinding.DataSource = db.DocumentSequences.ToList();

                DocumentSequences currentSeq = cmbFilter.SelectedItem as DocumentSequences;
                
                if (currentSeq!=null)
                {
                    transformBinding.DataSource = db.Documents.Where(d => d.DocumentSequenceID == currentSeq.ID).ToList();
                }

                DataGridViewComboBoxColumn sequence = new DataGridViewComboBoxColumn();
              
                sequence.Name = "sequences";
                sequence.HeaderText = "Серия";
                sequence.DataSource = sequenceBinding;
                sequence.DataPropertyName = "DocumentSequenceID";
                sequence.ValueMember = "ID";
                sequence.DisplayMember = "SequenceName";
                sequence.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                sequence.ReadOnly = true;

                DataGridViewTextBoxColumn number = new DataGridViewTextBoxColumn()
                {
                    Name = "number",
                    HeaderText = "Номер",
                    DataPropertyName = "DocumentNumber",
                    Width = 50
                };

                BindingSource partnerBinding = new BindingSource() { DataSource = typeof(Partners) };
                partnerBinding.DataSource = db.Partners.ToList();

                DataGridViewComboBoxColumn partner = new DataGridViewComboBoxColumn()
                {
                    Name = "Partner",
                    HeaderText = "Партньор",
                    DataSource = partnerBinding,
                    DataPropertyName = "PartnerID",
                    ValueMember = "ID",
                    DisplayMember = "Partner_Name",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                    ReadOnly = true,
                    Width = 200
                    
                };

                DataGridViewTextBoxColumn comment = new DataGridViewTextBoxColumn()
                {
                    Name ="comment",  
                    HeaderText = "Коментар",
                    DataPropertyName ="Comment",
                    Width = 250
                    
                };

                dgvDocsForTransformation = new DataGridView()
                {
                    AutoGenerateColumns = false,
                    AutoSize = true,
                    Width = 450,
                    Location = poitDgv,
                    Tag = transformBinding,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    ReadOnly = true,
                    RowHeadersWidth = 5,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,

                    MaximumSize = new Size(590, 1000),
                    Name = "dgvDocsForTransformation",
                    DataSource = transformBinding
                 };
                dgvDocsForTransformation.CellDoubleClick += DgvDocsForTransformation_CellDoubleClick;

                dgvDocsForTransformation.Columns.Add(sequence);
                dgvDocsForTransformation.Columns.Add(number);
                dgvDocsForTransformation.Columns.Add(partner);
                dgvDocsForTransformation.Columns.Add(comment);

                panelTransformFrom.Controls.Add(dgvDocsForTransformation);
            }
        }

        private void DgvDocsForTransformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDocsForTransformation.CurrentRow.Index!= -1)
            {
                Documents currentDoc = dgvDocsForTransformation.CurrentRow.DataBoundItem as Documents;
                
                List<Documents> documentsFrom = new List<Documents>();
                documentsFrom.Add(currentDoc);
                if (currentDoc!=null)
                {
                    DocumentsTransformations doDocumentTransofrmation = new DocumentsTransformations();
                    doDocumentTransofrmation.TransformDocument(db, newDocument, documentsFrom, documentTransactionsBindingSource, thisAction);
                }
            }
        }

        bool thisAction = false;

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
           // TextBox textBox = (TextBox)sender;
            DocumentSequences currentSequence = cmbFilter.SelectedItem as DocumentSequences;

            if (dgvDocsForTransformation != null && currentSequence != null)
            {
                BindingSource transformBinding = dgvDocsForTransformation.Tag as BindingSource;
                if (string.IsNullOrEmpty(txtFilter.Text))
                {
                    transformBinding.DataSource = db.Documents.Where(d => d.DocumentSequenceID == currentSequence.ID).ToList();
                }
                else
                {
                    transformBinding.DataSource = db.Documents.Where(d => d.DocumentSequenceID == currentSequence.ID && d.DocumentNumber.ToString().Contains(txtFilter.Text) | d.Partners.Partner_name.Contains(txtFilter.Text) | d.Comment.Contains(txtFilter.Text)).ToList();
                }
            }
        }

        DataGridView dgvDocsForTransformation;

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            DocumentSequences currentSeq = comboBox.SelectedItem as DocumentSequences;
            if(dgvDocsForTransformation!=null && currentSeq!=null)
            {
                BindingSource transformBinding = dgvDocsForTransformation.Tag as BindingSource;
                if(string.IsNullOrEmpty(txtFilter.Text))
                {
                    transformBinding.DataSource = db.Documents.Where(d => d.DocumentSequenceID == currentSeq.ID).ToList();
                } else
                {
                    transformBinding.DataSource = db.Documents.Where(d => d.DocumentSequenceID == currentSeq.ID && d.DocumentNumber.ToString().Contains(txtFilter.Text) | d.Partners.Partner_name.Contains(txtFilter.Text) | d.Comment.Contains(txtFilter.Text)).ToList();
                }
                
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Button sendr = (Button)sender;
            sendr.Parent.Dispose();
        }

        private void chkBoxThisAction_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                thisAction = true;
            } else
            {
                thisAction = false;
            }
        }
    }
}
