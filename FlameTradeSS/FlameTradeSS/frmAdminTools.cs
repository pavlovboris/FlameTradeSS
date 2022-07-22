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
    public partial class frmAdminTools : Form
    {
        public frmAdminTools()
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement usersManagement = new frmUsersManagement();
            CommonTasks.OpenForm(usersManagement);
        }

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            frmFunctions functions = new frmFunctions();
            CommonTasks.OpenForm(functions);
        }

        private void btnFunctionRoles_Click(object sender, EventArgs e)
        {
            frmRolesFunctions frmRolesFunctions = new frmRolesFunctions();
            CommonTasks.OpenForm(frmRolesFunctions);
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            frmPersons frmPersons = new frmPersons();
            CommonTasks.OpenForm(frmPersons);
        }

        private void frmAdminTools_Load(object sender, EventArgs e)
        {
            //UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdminTools_Paint(object sender, PaintEventArgs e)
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

        private void btnRolesOdPersons_Click(object sender, EventArgs e)
        {
            frmRolesOfPersons frmRolesOfPersons = new frmRolesOfPersons();
            CommonTasks.OpenForm(frmRolesOfPersons);
        }

        private void btnPersonsRoleOfPersons_Click(object sender, EventArgs e)
        {
            frmPersonsRoleOfPersons frmPersonsRoleOfPersons = new frmPersonsRoleOfPersons();
            CommonTasks.OpenForm(frmPersonsRoleOfPersons);
        }

        private void btnSequenceType_Click(object sender, EventArgs e)
        {
            frmSequenceTypes frmSequenceTypes = new frmSequenceTypes();
            CommonTasks.OpenForm(frmSequenceTypes);
        }

        private void btnSequences_Click(object sender, EventArgs e)
        {
            frmDocumentsSequences frmDocumentsSequences = new frmDocumentsSequences();
            CommonTasks.OpenForm(frmDocumentsSequences);
        }

        private void btnTransactionType_Click(object sender, EventArgs e)
        {
            frmTransactionTypes frmTransactionTypes = new frmTransactionTypes();
            CommonTasks.OpenForm(frmTransactionTypes);
        }

        private void btnSequenceTransactions_Click(object sender, EventArgs e)
        {
            frmSequenceTransactions frmSequenceTransactions = new frmSequenceTransactions();
            CommonTasks.OpenForm(frmSequenceTransactions);
        }

        private void btnMu_Click(object sender, EventArgs e)
        {
            frmMu frmMu = new frmMu();
            CommonTasks.OpenForm(frmMu);
        }

        private void btnPersonsType_Click(object sender, EventArgs e)
        {
            frmPersonsTypes frmPersonsTypes = new frmPersonsTypes();
            CommonTasks.OpenForm(frmPersonsTypes);
        }

        private void btnFinancialColors_Click(object sender, EventArgs e)
        {
            frmFinancialColors frmFinancialColors = new frmFinancialColors();
            CommonTasks.OpenForm(frmFinancialColors);
        }

        private void btnDocumentsList_Click(object sender, EventArgs e)
        {
            frmDocumentsAdmin frmDocumentsAdmin = new frmDocumentsAdmin();
            CommonTasks.OpenForm(frmDocumentsAdmin);
        }

        private void btnSurfaceTypes_Click(object sender, EventArgs e)
        {
            frmSurfacesTypes frmSurfacesTypes = new frmSurfacesTypes();
            CommonTasks.OpenForm(frmSurfacesTypes);
        }

        private void btnAccountingModels_Click(object sender, EventArgs e)
        {
            frmAccountingModels frmAccountingModels = new frmAccountingModels();
            CommonTasks.OpenForm(frmAccountingModels);
        }
    }
}
