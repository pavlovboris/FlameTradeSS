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
            partnersBindingSource.DataSource = db.Partners.ToList();

            foreach(DocumentsProjects documentsProjects in db.DocumentsProjects.Where(dp => dp.ProjectID==project.ID).ToList())
            {
                documentsBindingSource.Add(documentsProjects.Documents);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProjectAttachments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
