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
    public partial class frmFinancialPlans : Form
    {
        public frmFinancialPlans()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }
        public List<DocumentTransactions> transactionsType;
        private void frmDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //CommonTasks.WriteGrideViewSetting(dgvItems, Name + dgvItems.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            Properties.Settings.Default.frmFinancialPlanState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmFinancialPlanLocation = this.Location;
                Properties.Settings.Default.frmFinancialPlanSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmFinancialPlanLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmFinancialPlanSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
     
        }

        private const int cGrip = 10;      // Grip size
        private const int cCaption = 600;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);

            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            // rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //  e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
            
        }

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

        private static readonly SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        public FinancialPlans financialPlans;
        private  void frmDocuments_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            Hide();
            
            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmItemsSize, Properties.Settings.Default.frmItemsState, Properties.Settings.Default.frmItemsLocation);

            try
            {
                //CommonTasks.ReadDataGridViewSetting(dgvItems, Name + dgvItems.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch
            {

            }

            Properties.Settings.Default.Save();
            financialPlansBindingSource.DataSource = db.FinancialPlans.ToList();
            //financialPlans.Project = db.Project.First();
            //financialPlans.CreationDate = DateTime.Now;
            financialPlansBindingSource.Add(financialPlans);
            financialPlansBindingSource.MoveLast();
            //db.FinancialPlans.Add(financialPlans);
            //await db.SaveChangesAsync();
            projectBindingSource.DataSource = db.Project.ToList();
            Cursor.Current = Cursors.Default;
            Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Point pointMouse = new Point();
        private Control ctrlMoved = new Control();
        private bool bMoving = false;

        private void Control_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //if not left mouse button, exit
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            // save cursor location
            pointMouse = e.Location;
            //remember that we're moving
            bMoving = true;
        }

        private void Control_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            bMoving = false;
        }

        private void Control_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //if not being moved or left mouse button not used, exit
            if (!bMoving || e.Button != MouseButtons.Left)
            {
                return;
            }
            //get control reference
            ctrlMoved = (Control)sender;
            //set control's position based upon mouse's position change
            ctrlMoved.Left += e.X - pointMouse.X;
            ctrlMoved.Top += e.Y - pointMouse.Y;
        }

      
     

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            List<DocumentTransactions> transactions = new List<DocumentTransactions>();
            foreach (DocumentTransactions doctrans in transactionsType)
            {
                bool exist = false;
                foreach (Control flowPanel in panelFlowPanel.Controls)
                {
                    if (flowPanel.Tag == doctrans)
                    {
                        exist = true;
                    }
                }
                if (exist == false)
                {
                    transactions.Add(doctrans);
                }
            }

            AddingItems add = new AddingItems();
         
            add.AddFlowLayoutItem(panelFlowPanel,db,transactions, financialPlans,financialPlanLinesbindingSource);           
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            db.FinancialPlans.Add(financialPlans);
            foreach(FinancialPlanLines financialPlanLines in financialPlanLinesbindingSource)
            {
                db.FinancialPlanLines.Add(financialPlanLines);
            }
            await db.SaveChangesAsync();
        }
    }
}
