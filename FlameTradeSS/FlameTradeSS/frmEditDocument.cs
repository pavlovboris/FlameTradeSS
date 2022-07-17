using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmEditDocument : Form
    {
        public frmEditDocument()
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

            maxID = db.DocumentTransactions.Max(dt => (int)dt.tempID);

            CurrentSessionData.Counter = maxID;

            DgvOperations dgvOperations = new DgvOperations();


            partnersBindingSource.DataSource = db.Partners.ToList();
            documentsBindingSource.DataSource = newDocument;
            documentTransactionsBindingSource.DataSource = db.DocumentTransactions.Where(dt => dt.DocumentsID == newDocument.ID).ToList();
            documentSequencesBindingSource.DataSource = newDocument.DocumentSequences;
            receiptModelsBindingSource.DataSource = db.ReceiptModels.ToList();
            surfacesBindingSource.DataSource = db.Surfaces.ToList();
            transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
            documentsProjectsBindingSource.DataSource = db.DocumentsProjects.Where(dp => dp.DocumentsID == newDocument.ID).ToList();
            documentsAttachmentsBindingSource.DataSource = db.DocumentsAttachments.Where(da => da.DocumentsID == newDocument.ID).ToList();
            usersBindingSource.DataSource = db.Users.ToList();
            Surfaces_TransactionSurfaceID_SurfaceName_ID.ReadOnly = true;
            

            transactionsTypeBindingSource1.Add(new TransactionsType() { TypeName = "Всички"});
            foreach(DataGridViewRow dgvr in dgvDocumentTransactions.Rows)
            {
                DocumentTransactions dcmTransactions = dgvr.DataBoundItem as DocumentTransactions;
                if (dcmTransactions != null)
                {
                    //TransactionsType trt = documentTransactions.TransactionsType;
                    
                    if (existingTransactionTypes.Where(trt => trt.Equals(dcmTransactions.TransactionsType)).SingleOrDefault()==null)
                    {
                        transactionsTypeBindingSource1.Add(dcmTransactions.TransactionsType);
                        existingTransactionTypes.Add(dcmTransactions.TransactionsType);
                    }
                }
            }

            cmbSequenceFilter.SelectedIndex = 0;

            if (documentsProjectsBindingSource.DataSource != null)
            {
                foreach (DocumentsProjects dp in documentsProjectsBindingSource)
                {
                    Project project = dp.Project;
                    projectBindingSource.Add(project);
                }
            }

            List<SequencesTransactions> lines = new List<SequencesTransactions>();

            lines = db.SequencesTransactions.Where(sq => sq.SquenceID == newDocument.DocumentSequenceID).ToList();

            if (lines != null)
            {
                listBoxTransactionsAdd.Enabled = true;
                listBoxTransactionsAdd.Items.Clear();
                foreach (SequencesTransactions possible in lines.ToList())
                {
                    listBoxTransactionsAdd.Items.Add(possible.TransactionsType);
                    listBoxTransactionsAdd.DisplayMember = "TypeName";
                    
                }
            }

            if (newDocument.Issued == 0)
            {
               
            }
            else
            {
                listBoxTransactionsAdd.Enabled = false;
                btnIssueDocument.Enabled = false;
                btnCancel.Enabled = true;
                cmbDocumentSequence.Enabled = false;
                cmbPartners.Enabled = false;
                dateTimeDocDate.Enabled = false;
                dgvDocumentTransactions.ReadOnly = true;
              
            }

            if (newDocument.DocumentSequences.SequenceType.NumberingReference == "Invoice Numbering ")
            {
                txtDocumentNumber.Enabled = false;

            }
            else if (newDocument.DocumentSequences.SequenceType.NumberingReference == "Standart Numbering")
            {
                txtDocumentNumber.Enabled = false;

            }
            else
            {
                txtDocumentNumber.Enabled = true;
            }

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvDocumentTransactions, Name + dgvDocumentTransactions.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            Text = "Document : " + newDocument.DocumentSequences.SequenceName + " " + newDocument.DocumentNumber.ToString();

            if (newDocument.IsBlocked == 0)
            {
                checkBoxIsBlocked.CheckState = System.Windows.Forms.CheckState.Unchecked;
            }
            else if (newDocument.IsBlocked == 1)
            {
                checkBoxIsBlocked.CheckState = CheckState.Checked;
            }

            Cursor.Current = Cursors.Default;
            Show();
            dgvDocumentTransactions = dgvOperations.ConfigureDgv(dgvDocumentTransactions, db, newDocument.DocumentSequences, new DocumentTransactions());

        }

        //private static readonly SecurityService securityService = new SecurityService();
        public FlameTradeDbEntities db;

        public Documents newDocument;

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

            // don't forget to save the settings
            Properties.Settings.Default.Save();

            try
            {
                CommonTasks.WriteGrideViewSetting(dgvDocumentTransactions, Name + dgvDocumentTransactions.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            bool dispose = true;

            if (newDocument.Issued == 0)
            {
                DialogResult dialogResult = CommonTasks.SendQuestionMsg("Искате ли да запазите документа?");

                if (dialogResult == DialogResult.Yes)
                {

                    dgvDocumentTransactions.Dispose();

                    try
                    {
   
                        //make isBlocked=1;
                        await db.SaveChangesAsync();              
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message+"\n"+ex.InnerException.Message); }

                    foreach (TransactionRowsDependancy transactionRowsDependancy in db.TransactionRowsDependancy.Where(tlrd => tlrd.TransactionLines.DocumentTransactions.DocumentsID == newDocument.ID))
                    {
                        foreach (TransactionLines transactionLines in db.TransactionLines.Where(tl => tl.ID ==transactionRowsDependancy.TransactionLines1.ID))
                        {
                            TransactionLines dependantTL = transactionRowsDependancy.TransactionLines;
                            switch (transactionRowsDependancy.ControlledParameter)
                            {
                                case "RemainingQTY":
                                    if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                    {
                                        if (transactionRowsDependancy.TransactionLines.Qty != transactionRowsDependancy.InitialValue)
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingQTY = transactionLines.RemainingQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
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
                                        if (transactionRowsDependancy.TransactionLines.Qty != transactionRowsDependancy.InitialValue)
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingInvoiceQTY = transactionLines.RemainingInvoiceQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
                                    }
                                    else
                                    {
                                        double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty );
                                        transactionLines.RemainingInvoiceQTY = transactionLines.RemainingInvoiceQTY + diff;
                                        transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                    }
                                    break;
                                case "RemainingDeliveryQTY":
                                    if (transactionRowsDependancy.InitialValue == transactionRowsDependancy.LastValue)
                                    {
                                        if (transactionRowsDependancy.TransactionLines.Qty != transactionRowsDependancy.InitialValue)
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingDeliveryQTY = transactionLines.RemainingDeliveryQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
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
                                        if (transactionRowsDependancy.TransactionLines.Qty != transactionRowsDependancy.InitialValue)
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingPackagingQTY = transactionLines.RemainingPackagingQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
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
                                        if (transactionRowsDependancy.TransactionLines.Qty!= transactionRowsDependancy.InitialValue)
                                        {
                                            double diff = (double)(transactionRowsDependancy.LastValue - transactionRowsDependancy.TransactionLines.Qty);
                                            transactionLines.RemainingProductionQTY = transactionLines.RemainingProductionQTY + diff;
                                            transactionRowsDependancy.LastValue = transactionRowsDependancy.TransactionLines.Qty;
                                        }
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
                    try
                    {
                        await db.SaveChangesAsync();
                    } catch { }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvDocumentTransactions.Dispose();

                    UndoingChangesDbContextLevel(db);
                }
                else
                {
                    e.Cancel = true;
                    dispose = false;
                }
            }

            if(dispose == true)
            {
                dgvDocumentTransactions.Dispose();
            }
            
        }

        public static void UndoingChangesDbContextLevel(FlameTradeDbEntities context)
        {
            foreach (DbEntityEntry entry in context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default: break;
                }
            }
        }

        private void cmbDocumentSequence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbDocumentSequence.SelectedIndex != documentSequencesBindingSource.Count - 1)
                {
                    cmbPartners.Enabled = true;
                    DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;

                    if (selectedDocumentSequence.SequenceType.PartnerType == "Customer")
                    {
                        List<Partners> customers = new List<Partners>();

                        foreach (Customers isCustomer in db.Customers.ToList())
                        {
                            customers.Add(db.Partners.Where(p => p.ID == isCustomer.PartnerID).SingleOrDefault());
                        }

                        partnersBindingSource.DataSource = customers;
                        cmbPartners.SelectedItem = null;
                    }
                    else if (selectedDocumentSequence.SequenceType.PartnerType == "Supplier")
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

                }
            } catch { }
        }

        int tempID;

        private  void listBoxTransactionsAdd_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTransactionsAdd.SelectedItem != null)
            {
                TransactionsType selectedTransactionType = listBoxTransactionsAdd.SelectedItem as TransactionsType;
                DocumentTransactions newDocumentTransaction = new DocumentTransactions();

                tempID = CurrentSessionData.Counter + 1;

                CurrentSessionData.Counter = tempID;

                newDocumentTransaction.TransactionsType = selectedTransactionType;
                newDocumentTransaction.Documents = newDocument;
                newDocumentTransaction.UserID = CurrentSessionData.CurrentUser.ID;
                newDocumentTransaction.TransactionDate = DateTime.Now;
                newDocumentTransaction.CreationDateTime = DateTime.Now;
                newDocumentTransaction.ReceiptModelID = 1;
                frmDocumentTransactions newfrmDocumentTransactions = new frmDocumentTransactions();
                newDocumentTransaction.tempID = tempID;

                newfrmDocumentTransactions.Name = newfrmDocumentTransactions.Name + newDocumentTransaction.tempID;

                // newfrmDocumentTransactions.documentTransactionsBindingSource.Add(newDocumentTransaction);
                newfrmDocumentTransactions.transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
                newfrmDocumentTransactions.MdiParent = this;
                documentTransactionsBindingSource.Add(newDocumentTransaction);
                documentTransactionsBindingSource.MoveLast();
                db.DocumentTransactions.Add(newDocumentTransaction);
                newfrmDocumentTransactions.documentTransactions = newDocumentTransaction;
                newfrmDocumentTransactions.db = db;
                // newfrmDocumentTransactions.FormClosing += NewfrmDocumentTransactions_FormClosing;

                TabPage newTabFrmDocumentTransactions = new TabPage();

                newTabFrmDocumentTransactions.Name = newfrmDocumentTransactions.Name;
                newTabFrmDocumentTransactions.Text = selectedTransactionType.TypeName + " " + tempID.ToString();
                //newTabFrmDocumentTransactions.Click += NewTabFrmDocumentTransactions_Click;
                tabControlMain.TabPages.Add(newTabFrmDocumentTransactions);
                newTabFrmDocumentTransactions.Parent = tabControlMain;

                newTabFrmDocumentTransactions.Show();
                newfrmDocumentTransactions.TabCtrl = tabControlMain;
                newfrmDocumentTransactions.TabPag = newTabFrmDocumentTransactions;
                newfrmDocumentTransactions.Show();

                //newDocument.IsBlocked = 1;
                cmbDocumentSequence.Enabled = false;

                //await db.SaveChangesAsync();

                if (existingTransactionTypes.Where(trt => trt.Equals(selectedTransactionType)).SingleOrDefault()==null)
                {
                    existingTransactionTypes.Add(selectedTransactionType);
                    transactionsTypeBindingSource1.Add(selectedTransactionType);
                }
            }           
        }

        private void NewTabFrmDocumentTransactions_Click(object sender, EventArgs e)
        {
        }

        private void NewfrmDocumentTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDocumentTransactions closingForm = (frmDocumentTransactions)sender;
            e.Cancel = true;
            closingForm.Hide();
        }

        DocumentTransactions documentTransactions;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DocumentTransactions documentTransactions = new DocumentTransactions();
            //documentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;

            if (e.RowIndex != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem != null && e.ColumnIndex == Surfaces_TransactionSurfaceID_SurfaceName_ID.Index)
            {
                frmSurfaceSelector frmSurfaceSelector = new frmSurfaceSelector();
                frmSurfaceSelector.db = db;
                frmSurfaceSelector.surfaceTypes = db.SurfaceTypes.Where(st => st.ID == documentTransactions.TransactionsType.DefaultSurfaceTypeID).SingleOrDefault();
                frmSurfaceSelector.FormClosing += FrmSurfaceSelector_FormClosing;
                CommonTasks.OpenForm(frmSurfaceSelector);
            }
            else if (e.RowIndex != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem != null)
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
                        //newfrmDocumentTransactions.Dispose();


                        foreach (TabPage tabPage in tabControlMain.TabPages)
                        {
                            if (tabPage.Name == form.Name)
                            {
                                form.TabCtrl = tabControlMain;
                                form.TabPag = tabPage;
                            }
                        }
                        break;
                    }
                }

                if (newDocument.Issued == 1)
                {
                    newfrmDocumentTransactions.dgvTransactionLines.ReadOnly = true;
                    newfrmDocumentTransactions.dateTimeTransactionDate.Enabled = false;
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
                    //newTabFrmDocumentTransactions.Click += NewTabFrmDocumentTransactions_Click;
                    tabControlMain.TabPages.Add(newTabFrmDocumentTransactions);
                    newTabFrmDocumentTransactions.Parent = tabControlMain;
                    
                    newTabFrmDocumentTransactions.Show();
                    newfrmDocumentTransactions.TabCtrl = tabControlMain;
                    newfrmDocumentTransactions.TabPag = newTabFrmDocumentTransactions;

                    //   newfrmDocumentTransactions.FormClosing += NewfrmDocumentTransactions_FormClosing;
                    newfrmDocumentTransactions.Show();
                } else
                {                   
                }
            }
        }

        private void FrmSurfaceSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSurfaceSelector frmSurfaceSelector = sender as frmSurfaceSelector;
            
            if (frmSurfaceSelector.xClicked!=true && frmSurfaceSelector.dgvItemsSelector.CurrentRow.DataBoundItem!=null)
            {
                Surfaces surfaces = frmSurfaceSelector.dgvItemsSelector.CurrentRow.DataBoundItem as Surfaces;
                dgvDocumentTransactions.CurrentRow.Cells[Surfaces_TransactionSurfaceID_SurfaceName_ID.Index].Value = surfaces.ID;

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
                    addProject.Project = project;
                    addProject.Documents = newDocument;
                    documentsProjectsBindingSource.Add(addProject);
                    db.DocumentsProjects.Add(addProject);
                    documentsProjectsBindingSource.DataSource = newDocument.DocumentsProjects;
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
                                MessageBox.Show("Възникна грешка при записшане на файла, файла НЕ е записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (checkBoxIsBlocked.Checked == true)
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
            if (newDocument.Issued == 0 && txtDocumentNumber.Enabled == false)
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
            switch (newDocument.DocumentSequences.SequenceType.NumberingReference)
            {
                case "Invoice Numbering ":
                    if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да издадете Документ : " + newDocument.DocumentNumber.ToString() + "@" + newDocument.DocumentSequences.SequenceName) == true)
                    {
                        if(documentTransactionsBindingSource.Count==0 && cmbPartners.SelectedItem==null)
                        {
                            CommonTasks.SendErrorMsg("Не можете да издадете Документ без Редове и/или избран Партньор");
                        } else
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
                                CommonTasks.SendInfoMsg("Документа е успешно издаден : " + newDocument.DocumentNumber.ToString() + "@" + newDocument.DocumentSequences.SequenceName);
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

                            foreach(DocumentTransactions docTransactions in newDocument.DocumentTransactions)
                            {
                                int maxTransactionNumber = 0;

                                try
                                {
                                    maxTransactionNumber = db.TransactionNumbering.Where(tn => tn.DocumentID == newDocument.ID && tn.TransactionTypeID == docTransactions.TransactionTypeID).Max(tn => tn.Number);

                                } catch
                                {

                                }

                                docTransactions.TransactionNumber = newDocument.DocumentNumber.ToString() + "-" + docTransactions.TransactionsType.TypeName.ToString() + "-" + (maxTransactionNumber + 1).ToString();

                                TransactionNumbering transactionNumbering = new TransactionNumbering();
                                transactionNumbering.TransactionsType = docTransactions.TransactionsType;
                                transactionNumbering.Documents = newDocument;
                                transactionNumbering.Number = maxTransactionNumber + 1;
                                transactionNumbering.DocumentTransactions = docTransactions;

                                db.TransactionNumbering.Add(transactionNumbering);

                                await db.SaveChangesAsync();
                            }
                        }
                        catch { CommonTasks.SendErrorMsg("Документа НЕ е издаден"); }
                    }
                        break;
            }
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            foreach (frmDocumentTransactions form in MdiChildren)
            {
                if (e.TabPageIndex!=-1 && form.Name == tabControl.TabPages[e.TabPageIndex].Name)
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
            try
            {
                if (transactionsType!=null)
                {
                    if (filter.SelectedIndex!=0)
                    {
                        documentTransactionsBindingSource.DataSource = db.DocumentTransactions.SqlQuery("select * from DocumentTransactions dt where dt.DocumentsID=" + newDocument.ID + " AND dt.TransactionTypeID =" + transactionsType.ID).ToList();
                    } else
                    {
                        documentTransactionsBindingSource.DataSource = db.DocumentTransactions.Where(dt => dt.DocumentsID == newDocument.ID).ToList();
                    }

                }

            }
            catch { }
           /* try
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
            catch { } */
        }

        private void dgvDocumentTransactions_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                if (e.Column.Index == TransactionTypes_TransactionTypeID_TypeName_ID.Index)
                {
                    cmbSequenceFilter.Width = TransactionTypes_TransactionTypeID_TypeName_ID.Width;
                }
            } catch { }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvDocumentTransactions.CurrentRow.Index == -1 | dgvDocumentTransactions.CurrentRow.DataBoundItem== null)
            {
                e.Cancel = true;
            } else
            {
                if (documentTransactions!=null)
                {
                    List<ToolStripMenuItem> menu = new List<ToolStripMenuItem>();

                    foreach(ToolStripMenuItem toolStripMenuItem in toolStripMenuCreateFrom.DropDownItems)
                    {
                        menu.Add(toolStripMenuItem);
                    }

                    foreach (SequencesTransactions sequencesTransactions in db.SequencesTransactions.Where(st => st.SquenceID == newDocument.DocumentSequenceID))
                    {
                        bool exists = false;
                        foreach(ToolStripMenuItem existingStripMunu in menu)
                        {
                            if (sequencesTransactions.TransactionsType == existingStripMunu.Tag)
                            {
                                exists = true;
                            }
                        } 

                        if (exists == false)
                        {

                            ToolStripMenuItem newToolStripMenuItem = new ToolStripMenuItem();
                            newToolStripMenuItem.Text = sequencesTransactions.TransactionsType.TypeName;
                            newToolStripMenuItem.Tag = sequencesTransactions.TransactionsType;

                            toolStripMenuCreateFrom.DropDownItems.Add(newToolStripMenuItem);

                            ToolStripMenuItem allToolStripMenu = new ToolStripMenuItem();
                            allToolStripMenu.Text = "всички редове";
                            allToolStripMenu.Tag = sequencesTransactions.TransactionsType;
                            allToolStripMenu.Click += NewToolStripMenuItem_Click;

                            newToolStripMenuItem.DropDownItems.Add(allToolStripMenu);

                            ToolStripMenuItem specificToolStripMenu = new ToolStripMenuItem();
                            specificToolStripMenu.Text = "избор на редове";

                            specificToolStripMenu.Tag = sequencesTransactions.TransactionsType;
                            specificToolStripMenu.Click += SpecificToolStripMenu_Click;

                            newToolStripMenuItem.DropDownItems.Add(specificToolStripMenu);

                        }
                    }
                }
            }
        }

        private void SpecificToolStripMenu_Click(object sender, EventArgs e)
        {
            frmCreateFromTransactionOptions frmcreateFromTransactionOptions = new frmCreateFromTransactionOptions();
            frmcreateFromTransactionOptions.db = db;
            frmcreateFromTransactionOptions.currentDocumetTransaction = documentTransactions;

            ToolStripMenuItem sndrMenu = (ToolStripMenuItem)sender;
            tempID = CurrentSessionData.Counter + 1;

            CurrentSessionData.Counter = tempID;

            DocumentTransactions newDocumentTransactions = new DocumentTransactions();
            newDocumentTransactions.Documents = documentTransactions.Documents;
            newDocumentTransactions.TransactionsType = (TransactionsType)sndrMenu.Tag;
            newDocumentTransactions.CreationDateTime = DateTime.Now;
            newDocumentTransactions.TransactionDate = documentTransactions.TransactionDate;
            newDocumentTransactions.tempID = tempID;
            newDocumentTransactions.TransactionSurfaceID = documentTransactions.TransactionSurfaceID;
            newDocumentTransactions.UserID = CurrentSessionData.CurrentUser.ID;
            newDocumentTransactions.ColorID = documentTransactions.ColorID;
            newDocumentTransactions.Comment = documentTransactions.Comment;
            newDocumentTransactions.ExpectedMatDate = documentTransactions.ExpectedMatDate;
            newDocumentTransactions.NotForInvoice = documentTransactions.NotForInvoice;
            newDocumentTransactions.ReceiptModels = newDocumentTransactions.TransactionsType.ReceiptModels;
            //newDocumentTransactions.RequestedDeliveryDate = documentTransactions.RequestedDeliveryDate;
            //newDocumentTransactions.RequestedDate = documentTransactions.RequestedDate;
            newDocumentTransactions.ReceivedDate = documentTransactions.ReceivedDate;
            //newDocumentTransactions.IsReady = documentTransactions.IsReady;

            documentTransactionsBindingSource.Add(newDocumentTransactions);
            db.DocumentTransactions.Add(newDocumentTransactions);

            TransactionsTransformations transactionsTransformations = new TransactionsTransformations();
            transactionsTransformations.DocumentTransactions = newDocumentTransactions;
            transactionsTransformations.DocumentTransactions1 = documentTransactions;
            db.TransactionsTransformations.Add(transactionsTransformations);

            frmcreateFromTransactionOptions.newDocumentTransactions = newDocumentTransactions;
            frmcreateFromTransactionOptions.transactionsTransformations = transactionsTransformations;

            Enabled = false;

            frmcreateFromTransactionOptions.FormClosing += FrmcreateFromTransactionOptions_FormClosing;

            CommonTasks.OpenForm(frmcreateFromTransactionOptions);

        }

        private void FrmcreateFromTransactionOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem sndrMenu = (ToolStripMenuItem)sender;
            tempID = CurrentSessionData.Counter + 1;

            CurrentSessionData.Counter = tempID;

            DocumentTransactions newDocumentTransactions = new DocumentTransactions();
            newDocumentTransactions.Documents = documentTransactions.Documents;
            newDocumentTransactions.TransactionsType = (TransactionsType)sndrMenu.Tag;
            newDocumentTransactions.CreationDateTime = DateTime.Now;
            newDocumentTransactions.TransactionDate = documentTransactions.TransactionDate;
            newDocumentTransactions.tempID = tempID;
            newDocumentTransactions.TransactionSurfaceID = documentTransactions.TransactionSurfaceID;
            newDocumentTransactions.UserID = CurrentSessionData.CurrentUser.ID;
            newDocumentTransactions.ColorID = documentTransactions.ColorID;
            newDocumentTransactions.Comment = documentTransactions.Comment;
            newDocumentTransactions.ExpectedMatDate = documentTransactions.ExpectedMatDate;
            newDocumentTransactions.NotForInvoice = documentTransactions.NotForInvoice;
            newDocumentTransactions.ReceiptModels = newDocumentTransactions.TransactionsType.ReceiptModels;
            //newDocumentTransactions.RequestedDeliveryDate = documentTransactions.RequestedDeliveryDate;
            //newDocumentTransactions.RequestedDate = documentTransactions.RequestedDate;
            newDocumentTransactions.ReceivedDate = documentTransactions.ReceivedDate;
            //newDocumentTransactions.IsReady = documentTransactions.IsReady;

            documentTransactionsBindingSource.Add(newDocumentTransactions);
            db.DocumentTransactions.Add(newDocumentTransactions);

            TransactionsTransformations transactionsTransformations = new TransactionsTransformations();
            transactionsTransformations.DocumentTransactions = newDocumentTransactions;
            transactionsTransformations.DocumentTransactions1 = documentTransactions;
            db.TransactionsTransformations.Add(transactionsTransformations);

            //List<PossibleSequenceTransformationsProperties> possibleSequenceTransformationsProperties = new List<PossibleSequenceTransformationsProperties>();



            PossibleSequenceTransformationsProperties newTransactionSettings = db.PossibleSequenceTransformationsProperties.Where(pstp =>pstp.PossibleSequenceTransofrmation.DocumentSequenceID == newDocument.DocumentSequenceID && pstp.PossibleSequenceTransofrmation.PossibleDocumentSequenceID == newDocument.DocumentSequenceID && pstp.TransactionTypeID == documentTransactions.TransactionsType.ID && pstp.TransactionTypeIDTo == newDocumentTransactions.TransactionsType.ID).SingleOrDefault();
            
             //   possibleSequenceTransformationsProperties.Add(newTransactionSettings);
            

            List<TransactionLines> currentLines = new List<TransactionLines>();
            foreach (TransactionLines currentLine in documentTransactions.TransactionLines)
            {

            }

            foreach (TransactionLines transactionLines in documentTransactions.TransactionLines)
            {
                TransactionLines newTransactionLines = new TransactionLines();
                newTransactionLines.DocumentTransactions = newDocumentTransactions;
                newTransactionLines.Items = transactionLines.Items;
                newTransactionLines.Machines = transactionLines.Machines;
                newTransactionLines.Services = transactionLines.Services;
                newTransactionLines.AdditionExpense = transactionLines.AdditionExpense;
                newTransactionLines.Comment = transactionLines.Comment;
                newTransactionLines.TransactionReceipt = transactionLines.TransactionReceipt;
                newTransactionLines.WH = transactionLines.WH;
                newTransactionLines.StartDate = transactionLines.StartDate;
                newTransactionLines.SecondPartitionID = transactionLines.SecondPartitionID;
                newTransactionLines.RequestDate = transactionLines.RequestDate;
                newTransactionLines.CostPrice2 = transactionLines.CostPrice2;
                newTransactionLines.CostPrice1 = transactionLines.CostPrice1;
                newTransactionLines.CostPrice3 = transactionLines.CostPrice3;
                newTransactionLines.SalePrice2 = transactionLines.SalePrice2;
                newTransactionLines.SalePrice1 = transactionLines.SalePrice1;
                newTransactionLines.SalePrice3 = transactionLines.SalePrice3;
                newTransactionLines.Cycles = transactionLines.Cycles;
                newTransactionLines.DurationHours = transactionLines.DurationHours;
                newTransactionLines.Mu = transactionLines.Mu;
                newTransactionLines.EndDate = transactionLines.EndDate;
                newTransactionLines.FinancialCategories = transactionLines.FinancialCategories;
                newTransactionLines.Partitions = transactionLines.Partitions;
                newTransactionLines.Ordering = transactionLines.Ordering;
                newTransactionLines.SurfaceID = transactionLines.SurfaceID;
                newTransactionLines.Qty = transactionLines.Qty;
                
                if(newTransactionSettings.RemainDeliveryQTYAction ==1 )
                {
                    newTransactionLines.RemainingDeliveryQTY = transactionLines.Qty;
                }

                if(newTransactionSettings.RemainInvoiceQTYAction == 1)
                {
                    newTransactionLines.RemainingInvoiceQTY = transactionLines.Qty;
                }

                if ( newTransactionSettings.RemainPackagingQTYAction == 1) 
                { 
                    newTransactionLines.RemainingPackagingQTY = transactionLines.Qty;
                }

                if (newTransactionSettings.RemainProductionQTYAction==1)
                {
                    newTransactionLines.RemainingProductionQTY = transactionLines.Qty;
                }

                if (newTransactionSettings.RemainQTYAction == 1 )
                {
                    newTransactionLines.RemainingQTY = transactionLines.Qty;
                }

                db.TransactionLines.Add(newTransactionLines);
            }

           // Enabled = false;
        }

        private void contextMenuStripDocumentTransactions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuSplitTransaction)
            {
               // DocumentTransactions currentDocumentTransaction = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
                if (documentTransactions != null)
                {
                    tempID = CurrentSessionData.Counter + 1;

                    CurrentSessionData.Counter = tempID;

                    DocumentTransactions newDocumentTransactions = new DocumentTransactions();
                    newDocumentTransactions.Documents = documentTransactions.Documents;
                    newDocumentTransactions.TransactionsType = documentTransactions.TransactionsType;
                    newDocumentTransactions.CreationDateTime = DateTime.Now;
                    newDocumentTransactions.TransactionDate = documentTransactions.TransactionDate;
                    newDocumentTransactions.tempID = tempID;
                    newDocumentTransactions.TransactionSurfaceID = documentTransactions.TransactionSurfaceID;
                    newDocumentTransactions.UserID = CurrentSessionData.CurrentUser.ID;
                    newDocumentTransactions.ColorID = documentTransactions.ColorID;
                    newDocumentTransactions.Comment = documentTransactions.Comment;
                    newDocumentTransactions.ExpectedMatDate = documentTransactions.ExpectedMatDate;
                    newDocumentTransactions.NotForInvoice = documentTransactions.NotForInvoice;
                    newDocumentTransactions.ReceiptModels = documentTransactions.ReceiptModels;
                    newDocumentTransactions.RequestedDeliveryDate = documentTransactions.RequestedDeliveryDate;  
                    newDocumentTransactions.RequestedDate = documentTransactions.RequestedDate;
                    newDocumentTransactions.ReceivedDate = documentTransactions.ReceivedDate;
                    newDocumentTransactions.IsReady = documentTransactions.IsReady;

                    documentTransactionsBindingSource.Add(newDocumentTransactions);
                    db.DocumentTransactions.Add(newDocumentTransactions);

                    TransactionsTransformations transactionsTransformations = new TransactionsTransformations();
                    transactionsTransformations.DocumentTransactions = newDocumentTransactions;
                    transactionsTransformations.DocumentTransactions1 = documentTransactions;
                    db.TransactionsTransformations.Add(transactionsTransformations);

                    frmSplitTransactions frmSplitTransactions = new frmSplitTransactions();
                    frmSplitTransactions.currentDocumetTransaction = documentTransactions;
                    frmSplitTransactions.newDocumentTransactions = newDocumentTransactions;
                    frmSplitTransactions.db = db;
                    frmSplitTransactions.documentTransactionsbindingSource = documentTransactionsBindingSource;
                    frmSplitTransactions.transactionsTransformations = transactionsTransformations;
                    frmSplitTransactions.FormClosed += FrmSplitTransactions_FormClosed;

                    Enabled = false;

                    CommonTasks.OpenForm(frmSplitTransactions);
                }
            } else if (e.ClickedItem == toolStripMenuCreateFrom)
            {
               
            }
        }

        private void FrmSplitTransactions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            //DocumentTransactions currentDocumentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
            List<TransactionLines> linesList = new List<TransactionLines>();

            foreach (TransactionLines lines in documentTransactions.TransactionLines)
            {
                linesList.Add(lines);
            }

            foreach (TransactionLines emptyLine in linesList)
            {
                if (emptyLine.Qty==0)
                {
                    List<TransactionRowsDependancy> emptyLineDependancy = new List<TransactionRowsDependancy>();

                    foreach(TransactionRowsDependancy transactionRowsDependancy in db.TransactionRowsDependancy.Where(trd => trd.ControlledTransactionRowID == emptyLine.ID | trd.ControllingTransactionRowID== emptyLine.ID).ToList())
                    {
                        emptyLineDependancy.Add(transactionRowsDependancy);
                    }

                    if (emptyLineDependancy.Count>0)
                    {
                        foreach (TransactionRowsDependancy forRemoving in emptyLineDependancy)
                        {
                            db.TransactionRowsDependancy.Remove(forRemoving);
                        }
                    }

                    List<TransactionLinesTransformation> emtyTransactionLinesTransformation = new List<TransactionLinesTransformation>();
                    foreach(TransactionLinesTransformation transactionLinesTransformation in db.TransactionLinesTransformation.Where(tlt => tlt.TransactionLineID== emptyLine.ID | tlt.OriginTransactionLineID== emptyLine.ID).ToList())
                    {
                        emtyTransactionLinesTransformation.Add(transactionLinesTransformation);
                    }

                    if(emtyTransactionLinesTransformation.Count>0)
                    {
                        foreach(TransactionLinesTransformation forRemoving in emtyTransactionLinesTransformation)
                        {
                            db.TransactionLinesTransformation.Remove(forRemoving);
                        }
                    }

                    db.TransactionLines.Remove(emptyLine);
                }
            }
        }

        private void btnApplyReceiptModel_Click(object sender, EventArgs e)
        {
            if (dgvDocumentTransactions.CurrentRow.Index!=-1 && dgvDocumentTransactions.CurrentRow.DataBoundItem != null)
            {
               // DocumentTransactions currentTransaction = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
                ReceiptModels receiptModels = documentTransactions.ReceiptModels;
                
                if (documentTransactions.ReceiptModelID!=1 && documentTransactions.ReceiptModelID!=0 && documentTransactions.TransactionSurfaceID!=0)
                {
                    foreach (TransactionLines transactionLines in documentTransactions.TransactionLines)
                    {
                        if (receiptModels.HasGeneralItems==1 && receiptModels.IsItemDirectRelated==0 && receiptModels.IsSurfaceDirectRelated==0 && receiptModels.IsColorDirectRelated==0 && receiptModels.IsSecondPartitionDirectRelated==0 && receiptModels.IsPartitionDIrectRelated==0)
                        {
                            TransactionReceipt existingReceipt = db.TransactionReceipt.Where(tr => tr.ReceiptModelID == receiptModels.ID && tr.ItemID == transactionLines.ItemID && tr.SurfaceID== documentTransactions.TransactionSurfaceID).FirstOrDefault();

                            if (existingReceipt != null)
                            {
                                transactionLines.ReceiptID = existingReceipt.ID;

                                List<ReceiptLines> existingReceiptLines = new List<ReceiptLines>();
                                foreach (ReceiptLines receiptLines in existingReceipt.ReceiptLines)
                                {
                                    existingReceiptLines.Add(receiptLines);
                                }

                                if (existingReceiptLines.Count==0)
                                {
                                    foreach (ItemsParametersItems itemsParameters in db.ItemsParametersItems.Where(ipi => ipi.ItemsID == existingReceipt.ItemID).ToList())
                                    {
                                        foreach (ReceiptModelsItemsParameters receiptModelsItemsParameters in receiptModels.ReceiptModelsItemsParameters)
                                        {
                                            if (receiptModelsItemsParameters.ItemsParameterID == itemsParameters.ItemsParameterID)
                                            {
                                                ReceiptLines receiptLines = new ReceiptLines();
                                                receiptLines.TransactionReceipt = existingReceipt;
                                                receiptLines.Items = itemsParameters.Items1;
                                                receiptLines.ItemColorID = existingReceipt.ColorID;
                                                receiptLines.ItemPartitionID = existingReceipt.PartitionID;
                                                receiptLines.SecondPartitionID = existingReceipt.SecondPartitionID;
                                                receiptLines.Surfaces = existingReceipt.Surfaces;
                                                receiptLines.ItemQTY = itemsParameters.ParameterValue;
                                                receiptLines.ItemsParameters = itemsParameters.ItemsParameters;
                                                db.ReceiptLines.Add(receiptLines);
                                            }
                                        }
                                    }
                                }

                                /*  foreach (ReceiptLines receiptLines in existingReceiptLines)
                                  {
                                      bool exists = false;
                                      if (receiptLines.Surfaces == currentTransaction.Surfaces)
                                      {
                                          exists = true;
                                      }
                                      if (exists==false)
                                      {
                                          ReceiptLines newReceiptLine = new ReceiptLines();
                                          newReceiptLine.Items = receiptLines.Items;
                                          newReceiptLine.ItemQTY = receiptLines.ItemQTY;
                                          newReceiptLine.ItemsParameters = receiptLines.ItemsParameters;
                                          newReceiptLine.Partitions = receiptLines.Partitions;
                                          newReceiptLine.Partitions1 = receiptLines.Partitions1;
                                          newReceiptLine.Colors = receiptLines.Colors;
                                          newReceiptLine.TransactionReceipt = receiptLines.TransactionReceipt;
                                          if (currentTransaction.Surfaces != null)
                                          {
                                              newReceiptLine.Surfaces = currentTransaction.Surfaces;
                                          } else
                                          {
                                              newReceiptLine.Surfaces = db.Surfaces.Where(s => s.ID==1).SingleOrDefault();
                                          }
                                          db.ReceiptLines.Add(newReceiptLine);
                                      }
                                  } */
                            }
                            else
                            {
                                TransactionReceipt newTransactionReceipt = new TransactionReceipt();
                                newTransactionReceipt.Items = transactionLines.Items;
                                newTransactionReceipt.Name = "A-"+receiptModels.ModelName + "-" + documentTransactions.Surfaces.SurfaceCode+"-"+transactionLines.Items.Code.ToString();

                                newTransactionReceipt.ReceiptModels = receiptModels;

                                if (documentTransactions.ColorID != null)
                                {
                                    newTransactionReceipt.ColorID = (int)documentTransactions.ColorID;
                                }
                                else
                                {
                                    newTransactionReceipt.ColorID = 1;
                                }

                                if (documentTransactions.Surfaces != null)
                                {
                                    newTransactionReceipt.Surfaces = documentTransactions.Surfaces;
                                }
                                else
                                {
                                    newTransactionReceipt.SurfaceID = 1;
                                }

                                newTransactionReceipt.PartitionID = 1;
                                
                                newTransactionReceipt.SecondPartitionID = 1;
                                

                                db.TransactionReceipt.Add(newTransactionReceipt);
                                

                                foreach(ItemsParametersItems itemsParameters in db.ItemsParametersItems.Where(ipi => ipi.ItemsID==newTransactionReceipt.ItemID).ToList())
                                {
                                    foreach(ReceiptModelsItemsParameters receiptModelsItemsParameters in receiptModels.ReceiptModelsItemsParameters)
                                    {
                                        if (receiptModelsItemsParameters.ItemsParameterID == itemsParameters.ItemsParameterID)
                                        {
                                            ReceiptLines receiptLines = new ReceiptLines();
                                            receiptLines.TransactionReceipt = newTransactionReceipt;
                                            receiptLines.Items = itemsParameters.Items1;
                                            receiptLines.ItemColorID = newTransactionReceipt.ColorID;
                                            receiptLines.ItemPartitionID = newTransactionReceipt.PartitionID;
                                            receiptLines.SecondPartitionID = newTransactionReceipt.SecondPartitionID;
                                            receiptLines.Surfaces = newTransactionReceipt.Surfaces;
                                            receiptLines.ItemQTY = itemsParameters.ParameterValue;
                                            receiptLines.ItemsParameters = itemsParameters.ItemsParameters;
                                            db.ReceiptLines.Add(receiptLines);
                                        }
                                    }
                                }
                                transactionLines.TransactionReceipt = newTransactionReceipt;
                            }
                        }
                    }
                } else
                {
                    CommonTasks.SendErrorMsg("Не е приложен модел на рецепта. За да приложите модел е необходимо да сте избрали повърхност и активен модел за формиране на рецепта ");
                }
            }
        }

        private void contextMenuTabs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            if(tabControlMain.SelectedTab!=null)
            {
                foreach(Form form in MdiChildren)
                {
                    if (form.Name == tabControlMain.SelectedTab.Name)
                    {
                        form.Close();
                        tabControlMain.SelectedTab.Dispose();
                    }
                }
            }
        }

        private void dgvDocumentTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && dgvDocumentTransactions.CurrentRow.DataBoundItem!=null)
            {
                documentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
            }
        }

        private void dgvDocumentTransactions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (documentTransactions!=null)
            {
                if (e.ColumnIndex == ReceiptModel_ReceiptModelID_ModelName_ID.Index)
                {

                    documentTransactions.ReceiptModels = db.ReceiptModels.Where(rm => rm.ID == documentTransactions.ReceiptModelID).SingleOrDefault();
                }
                else if (e.ColumnIndex == Surfaces_TransactionSurfaceID_SurfaceName_ID.Index)
                {
                    documentTransactions.Surfaces = db.Surfaces.Where(s => s.ID == documentTransactions.TransactionSurfaceID).SingleOrDefault();
                }
                else if (e.ColumnIndex == ColorID.Index)
                {
                    documentTransactions.Colors = db.Colors.Where(c => c.ID == documentTransactions.ColorID).SingleOrDefault();
                }
            }
        }

        private void dgvDocumentTransactions_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgvDocumentTransactions.CurrentRow!=null && dgvDocumentTransactions.CurrentRow.DataBoundItem !=documentTransactions)
            {
                if (dgvDocumentTransactions.CurrentRow.Index != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem != null)
                {
                    documentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
                } else
                {
                    documentTransactions = null;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmCrystalReportsViewer frmCrystalReportsViewer = new frmCrystalReportsViewer();
            frmCrystalReportsViewer.db = db;
            frmCrystalReportsViewer.document = newDocument;
            frmCrystalReportsViewer.rptSingleDocumentOffer1.SetDatabaseLogon("CstmDBDefSol", "uncloak-TAIWAN-peccary-listless");
            //ParameterDiscreteValue parameter = new ParameterDiscreteValue();
            //parameter.Value = newDocument.ID;
            //parameter.IsRange = true;

            //frmCrystalReportsViewer.rptSingleDocument1.Parameter_DocumentID.CurrentValues.AddValue(newDocument.ID);
            //frmCrystalReportsViewer.rptSingleDocument1.Parameter_DocumentID.DefaultValues.Add(parameter);
           // frmCrystalReportsViewer.rptSingleDocument1.SetParameterValue(0,newDocument.ID);
            
            frmCrystalReportsViewer.Show();
        }
    }
}
