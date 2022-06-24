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
    public partial class frmNewDocument : Form
    {
        public frmNewDocument()
        {
            InitializeComponent();
        }

        private void frmNewDocument_Load(object sender, EventArgs e)
        {
            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmNewDocumentSize, Properties.Settings.Default.frmNewDocumentState, Properties.Settings.Default.frmNewDocumentLocation);

            db.Documents.Add(newDocument);
            partnersBindingSource.DataSource = db.Partners.ToList();
            Partners nullPartner = new Partners();
            partnersBindingSource.Add(nullPartner);
            cmbPartners.SelectedItem = nullPartner;
            cmbPartners.Enabled = false;
            DocumentSequences nullDocumentSequence = new DocumentSequences();
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            documentSequencesBindingSource.Add(nullDocumentSequence);
            cmbDocumentSequence.SelectedItem = nullDocumentSequence;
        }

        private static readonly SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        public static Documents newDocument;

        private void frmNewDocument_FormClosing(object sender, FormClosingEventArgs e)
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
                CommonTasks.SendInfoMsg("Ще се имплементира механизъм за запазване на промените");
            } else if (dialogResult == DialogResult.No)
            {
                
            } else
            {
                e.Cancel = true ;
            }
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDocumentTransactions frmDocumentTransactions = new frmDocumentTransactions();
            frmDocumentTransactions.MdiParent = this;
            
            frmDocumentTransactions.Show();
        }
    }
}
