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
    public partial class frmDocumentSequencesProperties : Form
    {
        public frmDocumentSequencesProperties()
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

        //private static readonly SecurityService securityService = new SecurityService();
        public FlameTradeDbEntities db;
        public DocumentSequences documentSequences;



        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            documentSequencesPropertiesBindingSource.DataSource = db.DocumentSequencesProperties.Where(ds => ds.DocumentSequenceID == documentSequences.ID && ds.DgvFields.DataGridViewName== "dgvTransactionLines").ToList();
            documentSequencesPropertiesBindingSource1.DataSource = db.DocumentSequencesProperties.Where(ds1 => ds1.DocumentSequenceID==documentSequences.ID &&  ds1.DgvFields.DataGridViewName== "dgvDocumentTransactions").ToList();
            dgvFieldsBindingSource.DataSource = db.DgvFields.Where(dgvf1 => dgvf1.DataGridViewName == "dgvTransactionLines").ToList();
            dgvFieldsBindingSource1.DataSource = db.DgvFields.Where(dgvf1 => dgvf1.DataGridViewName == "dgvDocumentTransactions").ToList();
            dgvFieldsBindingSource.Add(new DgvFields());
            dgvFieldsBindingSource1.Add(new DgvFields());
            transactionsTypeBindingSource.DataSource = db.TransactionsType.Where(tt => tt.SequencesTransactions.Where(st => st.SquenceID==documentSequences.ID).Any()).ToList();
            lblDocumentSequenceName.Text = documentSequences.SequenceName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DocumentSequencesProperties documentSequencesProperties = new DocumentSequencesProperties();
            documentSequencesProperties.DocumentSequenceID = documentSequences.ID;
            documentSequencesPropertiesBindingSource.Add(documentSequencesProperties);
            documentSequencesPropertiesBindingSource.MoveLast();
            db.DocumentSequencesProperties.Add(documentSequencesProperties);
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
            DocumentSequencesProperties documentSequencesProperties= dgvDocumentSequenceProperties.CurrentRow.DataBoundItem as DocumentSequencesProperties;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : ?") == true)
            {
                if (documentSequencesProperties!=null)
                {
                    
                        documentSequencesPropertiesBindingSource.Remove(documentSequencesProperties);
                        db.DocumentSequencesProperties.Remove(documentSequencesProperties);
                    
                }
            }
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            DocumentSequencesProperties documentSequencesProperties = new DocumentSequencesProperties();
            documentSequencesProperties.DocumentSequenceID = documentSequences.ID;
            documentSequencesPropertiesBindingSource1.Add(documentSequencesProperties);
            documentSequencesPropertiesBindingSource1.MoveLast();
            db.DocumentSequencesProperties.Add(documentSequencesProperties);
        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            DocumentSequencesProperties documentSequencesProperties = dgvDocumentSequenceProperties2.CurrentRow.DataBoundItem as DocumentSequencesProperties;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : ?") == true)
            {
                if (documentSequencesProperties != null)
                {

                    documentSequencesPropertiesBindingSource1.Remove(documentSequencesProperties);
                    db.DocumentSequencesProperties.Remove(documentSequencesProperties);

                }
            }
        }
    }
}
