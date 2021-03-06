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
    public partial class frmDocumentsSequences : Form
    {
        public frmDocumentsSequences()
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
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            sequenceTypeBindingSource.DataSource = db.SequenceType.ToList();
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            SequenceType nullType = new SequenceType();
            sequenceTypeBindingSource.Add(nullType);

            foreach(DataGridViewRow dgvr in dgvDocumentSequences.Rows)
            {
                dgvr.ReadOnly = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DocumentSequences newDocumentSequence = new DocumentSequences();
            documentSequencesBindingSource.Add(newDocumentSequence);
            documentSequencesBindingSource.MoveLast();
            db.DocumentSequences.Add(newDocumentSequence);
            dgvDocumentSequences.CurrentRow.ReadOnly = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите промените") == true)
            {
                try
                {
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените са запазени успешно");
                }
                catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени!!!");
                    if (CommonTasks.SendWarningMsg("Искате ли да видите детайлите") == true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DocumentSequences documentSequence = dgvDocumentSequences.CurrentRow.DataBoundItem as DocumentSequences;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : " + documentSequence.SequenceName + "?") == true)
            {
                if (dgvDocumentSequences.CurrentRow.Index != -1)
                {
                    if (documentSequence != null)
                    {
                        documentSequencesBindingSource.Remove(documentSequence);
                        db.DocumentSequences.Remove(documentSequence);
                    }
                }
            }
        }

        private void contextMenuStripDgv_Opening(object sender, CancelEventArgs e)
        {

            contextMenuStripDgv.Items.Clear();  
            if (dgvDocumentSequences.CurrentRow.Index != -1)
            {
                DocumentSequences documentSequences = dgvDocumentSequences.CurrentRow.DataBoundItem as DocumentSequences;
                if (documentSequences!=null && documentSequences.ID!= 0) 
                {
                    ToolStripMenuItem editSequencesPropertirs = new ToolStripMenuItem();
                    editSequencesPropertirs.Text = "Редактиране на Свойствата на : " + documentSequences.SequenceName;
                    editSequencesPropertirs.Click += EditSequencesPropertirs_Click;
                    contextMenuStripDgv.Items.Add(editSequencesPropertirs);

                    ToolStripMenuItem editPossibleSequenceTransformations = new ToolStripMenuItem();
                    editPossibleSequenceTransformations.Text = "Редактиране на Трансформации на :" + documentSequences.SequenceName;
                    editPossibleSequenceTransformations.Click += EditPossibleSequenceTransformations_Click;
                    contextMenuStripDgv.Items.Add(editPossibleSequenceTransformations);

                } else if (documentSequences.ID == 0)
                {
                    CommonTasks.SendErrorMsg("Моля, преди да продължите, ЗАПАМЕТЕТЕ промените");
                }

                ToolStripSeparator toolStripSeparator = new ToolStripSeparator();
                contextMenuStripDgv.Items.Add(toolStripSeparator);

                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                toolStripMenuItem.Text = "Редактирай";
                toolStripMenuItem.Click += ToolStripMenuItem_Click;
                contextMenuStripDgv.Items.Add(toolStripMenuItem);
             }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDocumentSequences.CurrentRow.ReadOnly = false; 
        }

        private void EditPossibleSequenceTransformations_Click(object sender, EventArgs e)
        {
            DocumentSequences documentSequences = dgvDocumentSequences.CurrentRow.DataBoundItem as DocumentSequences;
            if (documentSequences!=null)
            {
                frmPossibleSequenceTransformations frmPossibleSequenceTransformations = new frmPossibleSequenceTransformations();
                frmPossibleSequenceTransformations.documentSequences = documentSequences;
                frmPossibleSequenceTransformations.db = db;
                CommonTasks.OpenForm(frmPossibleSequenceTransformations);

            }
        }

        private void EditSequencesPropertirs_Click(object sender, EventArgs e)
        {
            DocumentSequences documentSequences = dgvDocumentSequences.CurrentRow.DataBoundItem as DocumentSequences;
            frmDocumentSequencesProperties frm = new frmDocumentSequencesProperties();
            frm.db = db;
            frm.documentSequences = documentSequences;
            CommonTasks.OpenForm(frm);
        }
    }
}
