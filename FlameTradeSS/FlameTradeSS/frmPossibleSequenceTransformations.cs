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
    public partial class frmPossibleSequenceTransformations : Form
    {
        public frmPossibleSequenceTransformations()
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
            lblDocumentSequenceName.Text = documentSequences.SequenceName;
            
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            documentSequencesBindingSource.Add(new DocumentSequences());
            possibleSequenceTransofrmationBindingSource.Add(new PossibleSequenceTransofrmation());
            possibleSequenceTransofrmationBindingSource.DataSource = db.PossibleSequenceTransofrmation.Where(pst => pst.DocumentSequenceID == documentSequences.ID).ToList();

            List<SequencesTransactions> sequencesTransactions = db.SequencesTransactions.Where(st => st.SquenceID == documentSequences.ID).ToList();            
            transactionsTypeBindingSource.Add(new TransactionsType());
            transactionsTypeBindingSource1.Add(new TransactionsType());

            foreach (SequencesTransactions sequence in sequencesTransactions)
            {
                transactionsTypeBindingSource.Add(db.TransactionsType.Where(tt => tt.ID == sequence.TransactionTypeID).SingleOrDefault());
            }
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PossibleSequenceTransofrmation possibleSequenceTransofrmation = new PossibleSequenceTransofrmation();
            possibleSequenceTransofrmation.DocumentSequenceID = documentSequences.ID;
            possibleSequenceTransofrmationBindingSource.Add(possibleSequenceTransofrmation);
            possibleSequenceTransofrmationBindingSource.MoveLast();
            db.PossibleSequenceTransofrmation.Add(possibleSequenceTransofrmation);
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
          
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            PossibleSequenceTransformationsProperties transformationsProperties = new PossibleSequenceTransformationsProperties();
            PossibleSequenceTransofrmation possible = dgvPossibleSequenceTransformations.CurrentRow.DataBoundItem as PossibleSequenceTransofrmation;
            if(possible != null)
            {
                transformationsProperties.PossibleSqequenceTransformationID = possible.ID;
                possibleSequenceTransformationsPropertiesBindingSource.Add(transformationsProperties);
                possibleSequenceTransformationsPropertiesBindingSource.MoveLast();
                db.PossibleSequenceTransformationsProperties.Add(transformationsProperties);
            }
        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            DocumentSequencesProperties documentSequencesProperties = dgvTransformationsProperties.CurrentRow.DataBoundItem as DocumentSequencesProperties;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : ?") == true)
            {
                if (documentSequencesProperties != null)
                {
                }
            }
        }

        private void dgvPossibleSequenceTransformations_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            possibleSequenceTransformationsPropertiesBindingSource.Clear();
            if (dgv.CurrentRow != null && dgv.CurrentRow.DataBoundItem != null) 
            {
                PossibleSequenceTransofrmation possibleSequence = dgv.CurrentRow.DataBoundItem as PossibleSequenceTransofrmation;

                if (possibleSequence != null && possibleSequence.PossibleDocumentSequenceID != 0)
                {
                    List<SequencesTransactions> sequencesTransactions = db.SequencesTransactions.Where(st => st.SquenceID == possibleSequence.PossibleDocumentSequenceID).ToList();

                    possibleSequenceTransformationsPropertiesBindingSource.DataSource = db.PossibleSequenceTransformationsProperties.Where(pstp => pstp.PossibleSqequenceTransformationID == possibleSequence.ID).ToList();
                    transactionsTypeBindingSource1.Clear();
                    transactionsTypeBindingSource1.Add(new TransactionsType());
                    foreach (SequencesTransactions sequence in sequencesTransactions)
                    {
                        transactionsTypeBindingSource1.Add(db.TransactionsType.Where(tt => tt.ID == sequence.TransactionTypeID).SingleOrDefault());
                    }
                }
            }
        }

        private void dgvPossibleSequenceTransformations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            possibleSequenceTransformationsPropertiesBindingSource.Clear();
            if (dgv.CurrentRow != null && dgv.CurrentRow.DataBoundItem != null)
            {
                PossibleSequenceTransofrmation possibleSequence = dgv.CurrentRow.DataBoundItem as PossibleSequenceTransofrmation;

                if (possibleSequence != null && possibleSequence.PossibleDocumentSequenceID != 0)
                {
                    List<SequencesTransactions> sequencesTransactions = db.SequencesTransactions.Where(st => st.SquenceID == possibleSequence.PossibleDocumentSequenceID).ToList();

                    possibleSequenceTransformationsPropertiesBindingSource.DataSource = db.PossibleSequenceTransformationsProperties.Where(pstp => pstp.PossibleSqequenceTransformationID == possibleSequence.ID).ToList();
                    transactionsTypeBindingSource1.Clear();
                    transactionsTypeBindingSource1.Add(new TransactionsType());

                    foreach (SequencesTransactions sequence in sequencesTransactions)
                    {
                        transactionsTypeBindingSource1.Add(db.TransactionsType.Where(tt => tt.ID == sequence.TransactionTypeID).SingleOrDefault());
                    }
                }
            }
        }

        private void dgvPossibleSequenceTransformations_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvPossibleSequenceTransformations.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
