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
    public partial class frmDocumentTransformation : Form
    {
        public frmDocumentTransformation()
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
        public Documents document;

        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (document != null)
            {
                lblDocumentNumber.Text = 
                    document.DocumentNumber.ToString()+"@"+ document.DocumentSequences.SequenceName.ToString() ;
                partnersBindingSource.DataSource = db.Partners.ToList();
                documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
                List<DocumentTransformation> fromTransformations = new List<DocumentTransformation>();
                fromTransformations = db.DocumentTransformation.Where(dt => dt.DocID == document.ID).ToList();
                List<DocumentTransformation> toTransformation = new List<DocumentTransformation>(); 
                toTransformation = db.DocumentTransformation.Where(dt => dt.OriginDocID == document.ID).ToList();
                foreach (DocumentTransformation fromdocumentTransformation in fromTransformations)
                {
                    documentsBindingSource.Add(fromdocumentTransformation.Documents1);
                }
                foreach (DocumentTransformation todocumentTransformation in toTransformation)
                {
                    documentsBindingSource1.Add(todocumentTransformation.Documents);
                }
            }        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
