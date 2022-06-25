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
    public partial class frmSequenceTransactions : Form
    {
        public frmSequenceTransactions()
        {
            InitializeComponent();
        }

        static SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPersonsRoleOfPersons_Paint(object sender, PaintEventArgs e)
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

        private void frmPersonsRoleOfPersons_Load(object sender, EventArgs e)
        {
            //UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            transactionsTypeBindingSource.DataSource = db.TransactionsType.ToList();
            linesTypeBindingSource.DataSource = db.LinesType.ToList();

            DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;
            if (selectedDocumentSequence != null)
            {
                sequencesTransactionsBindingSource.DataSource = db.SequencesTransactions.Where(st=> st.SquenceID==selectedDocumentSequence.ID).ToList();
            }
        }

        private void cmbPerson_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;
            if (selectedDocumentSequence != null)
            {
                sequencesTransactionsBindingSource.DataSource = db.SequencesTransactions.Where(st => st.SquenceID == selectedDocumentSequence.ID).ToList();
            }
        }

        private async void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (sequencesTransactionsBindingSource.DataSource!=null)
            {
                DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;
                if (selectedDocumentSequence != null)
                {
                    foreach (DataGridViewRow dgvr in dgvLeft.SelectedRows)
                    {
                        TransactionsType transactionsType = (TransactionsType)dgvr.DataBoundItem;
                        if (transactionsType != null)
                        {
                            SequencesTransactions sequencesTransactions = db.SequencesTransactions.Where(st => st.TransactionTypeID == transactionsType.ID && st.SquenceID == selectedDocumentSequence.ID).SingleOrDefault();
                            if (sequencesTransactions == null)
                            {
                                SequencesTransactions newSequenceTransaction = new SequencesTransactions() { SquenceID=selectedDocumentSequence.ID, TransactionTypeID =transactionsType.ID };
                                db.SequencesTransactions.Add(newSequenceTransaction);
                            }
                        }
                    }
                    await db.SaveChangesAsync();
                    sequencesTransactionsBindingSource.DataSource = db.SequencesTransactions.Where(st => st.SquenceID == selectedDocumentSequence.ID).ToList();
                }
            }
        }

        private async void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (sequencesTransactionsBindingSource.DataSource!=null)
            {
                DocumentSequences selectedDocumentSequence = cmbDocumentSequence.SelectedItem as DocumentSequences;
                if (selectedDocumentSequence != null)
                {
                    foreach (DataGridViewRow dgvr in dgvRight.SelectedRows)
                    {
                        SequencesTransactions sequencesTransactions = (SequencesTransactions)dgvr.DataBoundItem;
                        if (sequencesTransactions != null)
                        {
                            sequencesTransactionsBindingSource.Remove(sequencesTransactions);
                            db.SequencesTransactions.Remove(sequencesTransactions);
                        }
                    }
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
