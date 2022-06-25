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
    public partial class frmEditDocument : Form
    {
        public frmEditDocument()
        {
            InitializeComponent();
        }

        private void frmNewDocument_Load(object sender, EventArgs e)
        {
            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmNewDocumentSize, Properties.Settings.Default.frmNewDocumentState, Properties.Settings.Default.frmNewDocumentLocation);

           
           
            partnersBindingSource.DataSource = db.Partners.ToList();
            documentsBindingSource.DataSource = newDocument;
            documentTransactionsBindingSource.DataSource = db.DocumentTransactions.Where(dt => dt.DocumentsID==newDocument.ID).ToList();
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            
            transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
            documentsProjectsBindingSource.DataSource = db.DocumentsProjects.Where(dp => dp.DocumentsID == newDocument.ID).ToList();

           if (documentsProjectsBindingSource.DataSource!=null)
            {
                foreach(DocumentsProjects dp in documentsProjectsBindingSource)
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
            } catch { }

            Text ="Document : "+newDocument.DocumentSequences.SequenceName+" "+ newDocument.DocumentNumber.ToString();
        }

        private static readonly SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        public  Documents newDocument;

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

            DialogResult dialogResult = CommonTasks.SendQuestionMsg("Искате ли да запазите документа?");

            if (dialogResult == DialogResult.Yes)
            {
                try { await db.SaveChangesAsync(); } catch (Exception ex) { MessageBox.Show(ex.Message); } 
            } else if (dialogResult == DialogResult.No)
            {
                
            } else
            {
                e.Cancel = true ;
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
                DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;

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

               
            }
        }

        private void listBoxTransactionsAdd_DoubleClick(object sender, EventArgs e)
        {
            TransactionsType selectedTransactionType = listBoxTransactionsAdd.SelectedItem as TransactionsType;
            DocumentTransactions newDocumentTransaction = new DocumentTransactions();
            
            newDocumentTransaction.TransactionTypeID = selectedTransactionType.ID;
            newDocumentTransaction.DocumentsID = newDocument.ID;
            newDocumentTransaction.UserID = newDocument.UserID;
            newDocumentTransaction.TransactionDate = DateTime.Now;
            newDocumentTransaction.CreationDateTime = DateTime.Now;
            frmDocumentTransactions newfrmDocumentTransactions = new frmDocumentTransactions();
            newfrmDocumentTransactions.documentTransactions = newDocumentTransaction;
            newfrmDocumentTransactions.db = db;
            db.DocumentTransactions.Add(newDocumentTransaction);
            newfrmDocumentTransactions.documentTransactionsBindingSource.Add(newDocumentTransaction);
            newfrmDocumentTransactions.transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
            newfrmDocumentTransactions.MdiParent = this;
            documentTransactionsBindingSource.Add(newDocumentTransaction);
            documentTransactionsBindingSource.MoveLast();
           
            newfrmDocumentTransactions.Show();

            newDocument.IsBlocked = 1;
            cmbDocumentSequence.Enabled = false;
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvDocumentTransactions.CurrentRow.DataBoundItem!=null )
            {
                DocumentTransactions documentTransactions = dgvDocumentTransactions.CurrentRow.DataBoundItem as DocumentTransactions;
                frmDocumentTransactions newfrmDocumentTransactions = new frmDocumentTransactions();
                newfrmDocumentTransactions.transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
                newfrmDocumentTransactions.MdiParent = this;
                newfrmDocumentTransactions.documentTransactions = documentTransactions;
                //newfrmDocumentTransactions.documentTransactionsBindingSource.DataSource = documentTransactions;
                newfrmDocumentTransactions.db = db;

                newfrmDocumentTransactions.Show();

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
            foreach(object obj in contextMenuStripProjects.Items)
            {
                tsti.Add(obj);
            }

            foreach (object toolStripMenuItem in tsti)
            {
                try
                {
                    ToolStripMenuItem toolStrip = toolStripMenuItem as ToolStripMenuItem;

                    if (toolStrip!=null && toolStrip.Text == "Премахни Проект")
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
            
            DocumentsProjects documentsProjects = db.DocumentsProjects.Where(dp => dp.ProjectID == selectedProject.ID && dp.DocumentsID == newDocument.ID).FirstOrDefault();
            projectBindingSource.Remove(selectedProject);
            documentsProjectsBindingSource.Remove(documentsProjects);
            db.DocumentsProjects.Remove(documentsProjects);
            
        }
    }
}
