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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        private const int cGrip = 10;      // Grip size
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
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            CommonTasks.ExitApplication();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Hide();
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (CurrentSessionData.CurrentUser!=null)
            {
                lblCurrentUserName.Text = CurrentSessionData.CurrentUser.UserName.ToString();
            }
            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmMainSize, Properties.Settings.Default.frmMainState, Properties.Settings.Default.frmMainLocation);

            Cursor.Current = Cursors.Default;
            Show();

            try
            {
                btnDocuments.Location = Properties.Settings.Default.btnDocumentsLocation;
                btnNewDocument.Location = Properties.Settings.Default.btnNewDocumentLocation;
                btnFinancialPlans.Location = Properties.Settings.Default.btnFinancialPlans;
                btnProjects.Location = Properties.Settings.Default.btnProjectsLocation;
                btnProduction.Location = Properties.Settings.Default.btnProductionLocation;
            } catch { }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                
            } else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnAdminTools_Click(object sender, EventArgs e)
        {
            frmAdminTools adminTools = new frmAdminTools();
            CommonTasks.OpenForm(adminTools);
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            if(CommonTasks.SendWarningMsg(CurrentSessionData.CurrentUser.UserName.ToString()+" сигурни ли сте, че искате да излезете?") == true) 
            {
                this.Close();
                SecurityService securityService = new SecurityService();
                securityService.userLogOut();
                frmLogin.Instance.Show();
                frmLogin.Instance.txtPassword.Text = "";
                List<Form> forms = new List<Form>();
                
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name != "frmLogin" && frm.Name != "frmMain")
                    {
                        forms.Add(frm);
                    }
                }

                foreach (Form frm in forms)
                {
                    frm.Close();
                }
            }
        }

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

        private void btnPartnersMng_Click(object sender, EventArgs e)
        {
            frmPartners frmPartners = new frmPartners();
            CommonTasks.OpenForm(frmPartners);
        }

        private void treeViewPartners_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "PartnerGroup":
                    frmPartnerGroups frmPartnerGroups = new frmPartnerGroups();
                    CommonTasks.OpenForm(frmPartnerGroups);
                    break;
                case "PartnerCategory":
                    frmPartnerCategory frmPartnerCategory = new frmPartnerCategory();
                    CommonTasks.OpenForm(frmPartnerCategory);
                    break;
                case "PartnerStaticPriceGroup":
                    CommonTasks.SendInfoMsg("works - Price groups");
                    break;
                case "PersonPartners":
                    frmPartnersPersons frmPartnersPersons = new frmPartnersPersons();
                    CommonTasks.OpenForm(frmPartnersPersons);
                    break;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.frmMainState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmMainLocation = this.Location;
                Properties.Settings.Default.frmMainSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmMainLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmMainSize = this.RestoreBounds.Size;
            }

            Properties.Settings.Default.btnDocumentsLocation = btnDocuments.Location;
            Properties.Settings.Default.btnNewDocumentLocation = btnNewDocument.Location;
            Properties.Settings.Default.btnFinancialPlans = btnFinancialPlans.Location;
            Properties.Settings.Default.btnProjectsLocation = btnProjects.Location;
            Properties.Settings.Default.btnProductionLocation = btnProduction.Location;

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            frmProjects frmProjects = new frmProjects();
            CommonTasks.OpenForm(frmProjects);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            frmDocuments frmDocuments = new frmDocuments();
            CommonTasks.OpenForm(frmDocuments);
        }

        private void btnNewDocument_Click(object sender, EventArgs e)
        {
            frmNewDocument frmNewDocument = new frmNewDocument();
            foreach (Control mdicontrol in frmNewDocument.Controls)
            {
                MdiClient mdiClient = mdicontrol as MdiClient;
                if (mdiClient!=null)
                {
                    mdiClient.BackColor = Color.White;
                    break;
                }
            }

            //Documents newDocument = new Documents();
            //newDocument.UserID = CurrentSessionData.CurrentUser.ID ;
            //frmNewDocument.documentsBindingSource.DataSource = newDocument;
            //frmNewDocument.newDocument = newDocument;
            //frmNewDocument.dateTimeDocDate.Value = DateTime.Now;
            CommonTasks.OpenForm(frmNewDocument);
        }

        private void treeViewInventory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "ItemsNewItem":
                    frmItemsAddEdit frmItemsAddEdit = new frmItemsAddEdit();
                    frmItemsAddEdit.newItem = new Items();
                    CommonTasks.OpenForm(frmItemsAddEdit);
                    break;
                case "ItemsList":
                    frmItems frmItems = new frmItems();
                    CommonTasks.OpenForm(frmItems);
                    break;
                case "InvenotryGroup":
                    frmItemsGroups frmItemsGroups = new frmItemsGroups();
                    CommonTasks.OpenForm(frmItemsGroups);
                    break;
                case "InventoryCategory":
                    frmItemsCategory frmItemsCategory = new frmItemsCategory();
                    CommonTasks.OpenForm(frmItemsCategory);
                    break;
                case "ItemsPartitionsTypes":
                    frmPartitionsType frmPartitionsType = new frmPartitionsType();
                    CommonTasks.OpenForm(frmPartitionsType);
                    break;
                case "InventorySurfaces":
                    frmSurfaces frmSurfaces = new frmSurfaces();
                    CommonTasks.OpenForm(frmSurfaces);
                    break;
                case "ItemsParameters":
                    frmItemsParameters frmItemsParameters = new frmItemsParameters();
                    CommonTasks.OpenForm(frmItemsParameters);
                    break;
            }
        }

        private void btnFinancialPlans_Click(object sender, EventArgs e)
        {
            frmFinancialPlansList frmFinancialPlansList = new frmFinancialPlansList();
            frmFinancialPlansList.fromDocument = false;
            CommonTasks.OpenForm(frmFinancialPlansList);
        }

        private Point pointMouse = new Point();
        private Control ctrlMoved = new Control();
        private bool bMoving = false;

        private void Control_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == btnDocuments.Name)
            {
                btn.Click += btnDocuments_Click;
            }
            else if (btn.Name == btnNewDocument.Name)
            {
                btn.Click += btnNewDocument_Click;
            }
            else if (btn.Name == btnFinancialPlans.Name)
            {
                btn.Click += btnFinancialPlans_Click;
            }
            else if (btn.Name == btnProduction.Name)
            {
                btn.Click += btnProduction_Click;
            }
            else if (btn.Name == btnProjects.Name)
            {
                btn.Click += btnProjects_Click;
            }

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
            Button btn = (Button)sender;

            btn.BringToFront();
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
            
            if (btn.Name == btnDocuments.Name)
            {
                btn.Click -= btnDocuments_Click;
            } else if (btn.Name == btnNewDocument.Name)
            {
                btn.Click -= btnNewDocument_Click;
            } else if (btn.Name == btnFinancialPlans.Name)
            {
                btn.Click -= btnFinancialPlans_Click;
            } else if (btn.Name == btnProduction.Name)
            {
                btn.Click -= btnProduction_Click;
            } else if (btn.Name == btnProjects.Name)
            {
                btn.Click -= btnProjects_Click;
            }
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuProduction_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuReceiptModels)
            {
                frmReceiptModels frmReceiptModels = new frmReceiptModels();
                CommonTasks.OpenForm(frmReceiptModels);
            }
        }
    }
}
