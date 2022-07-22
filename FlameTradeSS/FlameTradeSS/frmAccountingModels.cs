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
    public partial class frmAccountingModels : Form
    {
        public frmAccountingModels()
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
        public FlameTradeDbEntities db = securityService.NewDatabaseEntity();
        //public DocumentSequences documentSequences;



        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);


            accountingEntriesModelBindingSource.DataSource = db.AccountingEntriesModel.ToList();

            accountsBindingSource.DataSource = db.Accounts.ToList();
            accountsBindingSource.Add(new Accounts());
            accountsBindingSource1.DataSource = db.Accounts.ToList();
            accountsBindingSource1.Add(new Accounts());
            accountsBindingSource2.DataSource = db.Accounts.Where(a => a.AccountTypeID == 4).ToList();
            accountsBindingSource2.Add(new Accounts());

            currentModel = dgvAccountingModels.CurrentRow.DataBoundItem as AccountingEntriesModel;

            if (currentModel != null)
            {
                lblAccountingModelName.Text = currentModel.EntryName.ToString();
                
            }
   
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountingEntriesModel newAccountingModel = new AccountingEntriesModel();
            accountingEntriesModelBindingSource.Add(newAccountingModel);
            db.AccountingEntriesModel.Add(newAccountingModel);
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
            if (currentModel != null)
            {
                if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната трансформация ?") == true)
                {
                   
                }
            }
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (currentModel != null)
            {
                AccountingEntriesModelDetails newModelDetails = new AccountingEntriesModelDetails();
                newModelDetails.AccountingEntriesModel = currentModel;
               // currentModel.AccountingEntriesModelDetails.Add(newModelDetails);
                 accountingEntriesModelDetailsBindingSource.Add(newModelDetails);
               // accountingEntriesModelDetailsBindingSource.DataSource = currentModel.AccountingEntriesModelDetails;
                db.AccountingEntriesModelDetails.Add(newModelDetails);
            }


        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {

            if (currentModel != null)
            {
                if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : ?") == true)
                {

                }
            }
        }

        AccountingEntriesModel currentModel;

        private void dgvPossibleSequenceTransformations_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            accountingEntriesModelDetailsBindingSource.Clear();
            if (dgv.CurrentRow != null && dgv.CurrentRow.DataBoundItem != null) 
            {
                 currentModel = dgv.CurrentRow.DataBoundItem as AccountingEntriesModel;

                if (currentModel != null )
                {
                    
                    accountingEntriesModelDetailsBindingSource.DataSource = currentModel.AccountingEntriesModelDetails.ToList();
                }
            }
        }

        private void dgvPossibleSequenceTransformations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPossibleSequenceTransformations_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvAccountingModels.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
