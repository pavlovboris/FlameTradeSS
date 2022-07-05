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

            // don't forget to save the settings
            Properties.Settings.Default.Save();
            if (newDocument.Issued == 0)
            {
                DialogResult dialogResult = CommonTasks.SendQuestionMsg("Искате ли да запазите документа?");

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        foreach (Form form in this.MdiChildren)
                        {
                            frmDocumentTransactions frmDocTrans = form as frmDocumentTransactions;

                           // frmDocTrans.FormClosing -= NewfrmDocumentTransactions_FormClosing;
                            foreach (DataGridViewRow row in frmDocTrans.dgvTransactionLines.Rows)
                            {
                                if (!row.IsNewRow && row.Index != -1 && row.DataBoundItem != null)
                                {
                                    TransactionLines transactionLines = row.DataBoundItem as TransactionLines;
                                    if (transactionLines.ID == 0)
                                    {
                                        transactionLines.TransactionsID = frmDocTrans.documentTransactions.ID;
                                        db.TransactionLines.Add(transactionLines);
                                    }
                                }
                            }
                        }
                        await db.SaveChangesAsync();
                        dgvAttachments.Dispose();
                        dgvDocumentTransactions.Dispose();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else if (dialogResult == DialogResult.No)
                {
                   // foreach (Form form in this.MdiChildren)
                   // {
                     //   form.FormClosing -= NewfrmDocumentTransactions_FormClosing;
                  //  }

                    if (newDocument.DocumentSequenceID!=0 && newDocument.PartnerID!=0 && newDocument.IsBlocked==0)
                    {
                        CommonTasks.DeleteDocument(db, newDocument);
                    }
                    
                }
                else
                {
                    e.Cancel = true;
                }
            }
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvDocumentTransactions, Name + dgvDocumentTransactions.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
            
        }

        private void cmbDocumentSequence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDocumentSequence.SelectedIndex != documentSequencesBindingSource.Count-1 )
            {
                cmbPartners.Enabled = true;
                
                listBoxProjects.Enabled = true;
                documentsAttachmentsBindingSource.DataSource = db.DocumentsAttachments.Where(da => da.DocumentsID == newDocument.ID).ToList();
                DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;


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


        private async void listBoxTransactionsAdd_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTransactionsAdd.SelectedItem!=null)
            {
                TransactionsType selectedTransactionType = listBoxTransactionsAdd.SelectedItem as TransactionsType;
                DocumentTransactions newDocumentTransaction = new DocumentTransactions();

                int tempID = CurrentSessionData.Counter + 1;

                CurrentSessionData.Counter = tempID;

                newDocumentTransaction.TransactionTypeID = selectedTransactionType.ID;
                newDocumentTransaction.DocumentsID = newDocument.ID;
                newDocumentTransaction.UserID =CurrentSessionData.CurrentUser.ID;
                newDocumentTransaction.CreationDateTime = DateTime.Now;
                newDocumentTransaction.TransactionDate = DateTime.Now;
                newDocumentTransaction.ReceiptModels = db.ReceiptModels.Where(rm => rm.ID == 1).SingleOrDefault(); ;

                frmDocumentTransactions newfrmDocumentTransactions = new frmDocumentTransactions();
                newDocumentTransaction.tempID = tempID;
                newfrmDocumentTransactions.Name = newfrmDocumentTransactions.Name + newDocumentTransaction.tempID;
                
                newfrmDocumentTransactions.documentTransactions = newDocumentTransaction;
                newfrmDocumentTransactions.db = db;
                db.DocumentTransactions.Add(newDocumentTransaction);
                await db.SaveChangesAsync();
                // newfrmDocumentTransactions.documentTransactionsBindingSource.Add(newDocumentTransaction);
                newfrmDocumentTransactions.transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
                newfrmDocumentTransactions.MdiParent = this;
                documentTransactionsBindingSource.Add(newDocumentTransaction);
                documentTransactionsBindingSource.MoveLast();
                //newfrmDocumentTransactions.FormClosing += NewfrmDocumentTransactions_FormClosing;

                TabPage newTabFrmDocumentTransactions = new TabPage();

                newTabFrmDocumentTransactions.Name = newfrmDocumentTransactions.Name;
                newTabFrmDocumentTransactions.Text = selectedTransactionType.TypeName + " " + tempID.ToString();
                //newTabFrmDocumentTransactions.Click += NewTabFrmDocumentTransactions_Click;
                tabControlMain.TabPages.Add(newTabFrmDocumentTransactions);
                newTabFrmDocumentTransactions.Parent = tabControlMain;

                newTabFrmDocumentTransactions.Show();
                //tabControlMain.SelectedTab = newTabFrmDocumentTransactions;

                newfrmDocumentTransactions.TabCtrl = tabControlMain;
                newfrmDocumentTransactions.TabPag = newTabFrmDocumentTransactions;

                newfrmDocumentTransactions.Show();
                //newDocument.IsBlocked = 1;
                cmbDocumentSequence.Enabled = false;


                await db.SaveChangesAsync();

                if (existingTransactionTypes.Where(trt => trt.Equals(selectedTransactionType)).SingleOrDefault() == null)
                {
                    existingTransactionTypes.Add(selectedTransactionType);
                    transactionsTypeBindingSource1.Add(selectedTransactionType);
                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem!=null )
            {
                bool isOpened = false;

                DocumentTransactions documentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
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
                                }
                                catch { CommonTasks.SendErrorMsg("Дактурата НЕ е издаден : " + newDocument.DocumentNumber.ToString() + "@" + newDocument.DocumentSequences.SequenceName); }
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

        private void btnTransformFrom_Click(object sender, EventArgs e)
        {
            Panel panelTransformFrom = new Panel();
            panelTransformFrom.Location = btnTransformFrom.Location;
            panelTransformFrom.Width = 400;
            panelTransformFrom.Height = 500;
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
                Text = "Филтър : ",
                Location = lblFilterPoint,
                Width = 100
            };
            Point cmbFilterPoint = new Point();
            cmbFilterPoint.X = 105;
            cmbFilterPoint.Y = 50;

            //BindingSource cmbFilterBinding = new BindingSource();
            List<DocumentSequences> possibleList = new List<DocumentSequences>();

            DocumentSequences selectedSequence = cmbDocumentSequence.SelectedItem as DocumentSequences; 

            if (selectedSequence.SequenceName != null)
            {
                foreach (PossibleSequenceTransofrmation pst in db.PossibleSequenceTransofrmation.Where(pt => pt.PossibleDocumentSequenceID == selectedSequence.ID ).ToList())
                {
                    possibleList.Add(pst.DocumentSequences);
                }

                ComboBox cmbFilter = new ComboBox()
                {
                    Name = "cmbFilter",
                    DataSource = possibleList,
                    DisplayMember = "SequenceName",
                    ValueMember = "ID",
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
                sequence.DataSource = sequenceBinding;
                sequence.DataPropertyName = "DocumentSequenceID";
                sequence.ValueMember = "ID";
                sequence.DisplayMember = "SequenceName";
                sequence.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                dgvDocsForTransformation = new DataGridView()
                {
                    AutoGenerateColumns = false,
                    AutoSize = true,
                    Width = 390,
                    Location = poitDgv,
                    Tag = transformBinding,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    RowHeadersWidth = 5,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,

                    MaximumSize = new Size(500, 1000),
                    Name = "dgvDocsForTransformation",
                    DataSource = transformBinding
                 };

                dgvDocsForTransformation.Columns.Add(sequence);

                panelTransformFrom.Controls.Add(dgvDocsForTransformation);
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
                transformBinding.DataSource = db.Documents.Where(d => d.DocumentSequenceID == currentSeq.ID).ToList();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Button sendr = (Button)sender;
            sendr.Parent.Dispose();
        }
    }
}
