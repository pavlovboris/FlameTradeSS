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
    public partial class frmDocumentTransactions : Form
    {
        public frmDocumentTransactions()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        private void frmDocumentTransactions_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
            
            documentTransactionsBindingSource.DataSource = documentTransactions;
        }

        public  FlameTradeDbEntities db;

        public  DocumentTransactions documentTransactions;

        /* private const int cGrip = 10;      // Grip size
         private const int cCaption = 600;   // Caption bar height;

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
                 if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                 {
                     m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                     return;
                 }
             }
             base.WndProc(ref m);
         }
         protected override void OnPaint(PaintEventArgs e)
         {
             Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
             ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
             // rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
             //  e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
             Graphics g = this.CreateGraphics();
             // create  a  pen object with which to draw
             Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                   // call a member of the graphics class
                                                   // g.DrawLine(p,2,2, Size.Width-4,2);
                                                   //g.DrawLine(p,2,2,2,Size.Height-4);
             Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
             g.DrawRectangle(p, r);
         }*/
    }
}
