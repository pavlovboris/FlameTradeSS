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
    public partial class frmProjectDocuments : Form
    {
        public frmProjectDocuments()
        {
            InitializeComponent();
        }

        private const int cCaption = 300;   // Caption bar height;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public Project project;
        private void frmPartnerGroups_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);
        }

        private static readonly SecurityService securityService = new SecurityService();
        public FlameTradeDbEntities db;

        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (db == null)
            {
                db = securityService.NewDatabaseEntity();
            }
            if(project!=null)
            {
                lblProjectName.Text = project.ProjectName;
            }

           
            usersBindingSource.DataSource = db.Users.ToList();
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            documentSequencesBindingSource.Add(new DocumentSequences() { SequenceName = "All" });
            cmbSequence.SelectedItem = cmbSequence.Items[cmbSequence.Items.Count-1];
            cmbIsCanceled.SelectedIndex = 0;

            partnersBindingSource.DataSource = db.Partners.ToList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProjectAttachments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvProjectDocuments.Rows[e.RowIndex].DataBoundItem != null)
            {
                frmEditDocument frmEditDocument = new frmEditDocument();
                frmEditDocument.newDocument = dgvProjectDocuments.CurrentRow.DataBoundItem as Documents;
                frmEditDocument.db = db;


                foreach (Control mdicontrol in frmEditDocument.Controls)
                {
                    MdiClient mdiClient = mdicontrol as MdiClient;
                    if (mdiClient != null)
                    {
                        mdiClient.BackColor = Color.White;
                        break;
                    }
                }
                CommonTasks.OpenForm(frmEditDocument);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentSequences documentSequences = cmbSequence.SelectedItem as DocumentSequences;
            if (documentSequences != null && documentSequences.SequenceName == "All")
            {
                switch (cmbIsCanceled.SelectedIndex)
                {
                    case 0:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 1:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 0).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 2:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 1).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                }
            }
            else if (documentSequences != null)
            {
                switch (cmbIsCanceled.SelectedIndex)
                {
                    case 0:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.DocumentSequenceID == documentSequences.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 1:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 0 && dp.Documents.DocumentSequenceID == documentSequences.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 2:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 1 && dp.Documents.DocumentSequenceID == documentSequences.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                }
            }
        }

        private void cmbSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentSequences documentSequences = cmbSequence.SelectedItem as DocumentSequences;
            if (documentSequences != null && documentSequences.SequenceName == "All")
            {
                switch (cmbIsCanceled.SelectedIndex)
                {
                    case 0:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 1:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 0).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 2:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 1).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                }
            }
            else if (documentSequences != null)
            {
                switch (cmbIsCanceled.SelectedIndex)
                {
                    case 0:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.DocumentSequenceID == documentSequences.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 1:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 0 && dp.Documents.DocumentSequenceID == documentSequences.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                    case 2:
                        documentsBindingSource.Clear();
                        foreach (DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID == project.ID && dp.Documents.IsCanceled == 1 && dp.Documents.DocumentSequenceID == documentSequences.ID).ToList())
                        {
                            documentsBindingSource.Add(documentsProjects.Documents);
                        }
                        break;
                }
            }
        }
    }
}
