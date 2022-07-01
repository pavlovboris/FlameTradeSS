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
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            this.Enter += Form_Gotfocus;
        }

        private const int cGrip = 20;      // Grip size
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
        }



        private void frmDocumentTransactions_Load(object sender, EventArgs e)
        {
            this.GotFocus += new EventHandler(Form_Gotfocus);
            
            //this.BackColor = Color.White;
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvTransactionLines, Name + dgvTransactionLines.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            DgvOperations dgvOperations = new DgvOperations();
            dgvTransactionLines = dgvOperations.ConfigureDgv(dgvTransactionLines, db, documentTransactions.Documents.DocumentSequences,documentTransactions);

            documentTransactionsBindingSource.DataSource = documentTransactions;
            transactionLinesBindingSource.DataSource = db.TransactionLines.Where(tl => tl.TransactionsID == documentTransactions.ID).ToList();
            muBindingSource.DataSource = db.Mu.ToList();
            itemsBindingSource.DataSource = db.Items.ToList();
            
            if (dgvTransactionLines.CurrentRow != null && dgvTransactionLines.CurrentRow.DataBoundItem != null)
            {
                TransactionLines transactionLines = dgvTransactionLines.CurrentRow.DataBoundItem as TransactionLines;
                transactionLines.TransactionsID = documentTransactions.ID;
            }

            switch (documentTransactions.TransactionsType.LinesType.Name)
            {
                case "ItemID":


                    dgvTransactionLines.Columns[Machines_MachineID_Code_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Services_ServiceID_Code_ID.Name].Visible = false;
                   
                    itemsBindingSource.DataSource = db.Items.ToList();
                    transactionReceiptBindingSource.DataSource = db.TransactionReceipt.ToList();
                    surfacesBindingSource.DataSource = db.Surfaces.ToList();
                    partitionsBindingSource.DataSource = db.Partitions.ToList();
                    partitionsBindingSource1.DataSource = db.Partitions.ToList();
                    muBindingSource.DataSource = db.Mu.ToList();
                    break;
                case "MachineID":
                    dgvTransactionLines.Columns[Items_ItemID_Description_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Items_ItemID_Code_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Services_ServiceID_Code_ID.Name].Visible = false;
                    
                    
                    break;
                case "ServiceID":
                    dgvTransactionLines.Columns[Items_ItemID_Description_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Items_ItemID_Code_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Machines_MachineID_Code_ID.Name].Visible = false;
                    servicesBindingSource.DataSource= db.Services.ToList();
                    break;
            }

            
            
        }

        private void FrmDocumentTransactions_GotFocus(object sender, EventArgs e)
        {

        }

        public  FlameTradeDbEntities db;

        public  DocumentTransactions documentTransactions;

        private void dgvTransactionLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmReceiptSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmReceiptSelector frmReceiptSelector = (frmReceiptSelector)sender;

            if (frmReceiptSelector.xClicked!=true)
            {
                if (frmReceiptSelector.dgvReceipts.CurrentRow.DataBoundItem!=null)
                {
                    TransactionReceipt transactionReceipt = frmReceiptSelector.dgvReceipts.CurrentRow.DataBoundItem as TransactionReceipt;
                    dgvTransactionLines.CurrentCell.Value = transactionReceipt.ID;
                }
            }
        }
        BindingSource transactionTasksDataBindingSource;
        DataGridView dgvTasks;
        private void btnTasks_Click(object sender, EventArgs e)
        {
            

            

            btnTasks.Visible = false;
            dgvTasks = new DataGridView();
            
            if (transactionTasksDataBindingSource == null)
            {
                transactionTasksDataBindingSource = new BindingSource();
                transactionTasksDataBindingSource.DataSource = db.TransactionPersons.Where(tp => tp.DocumentTransactionsID == documentTransactions.ID).ToList();
            }
           
            BindingSource personsDataBindingSource = new BindingSource();
            BindingSource tasksDataBindingSource = new BindingSource();
            BindingSource taskStatusBindingSource = new BindingSource();

            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.AutoGenerateColumns = false;
            dgvTasks.AutoSize = true;
            
            personsDataBindingSource.DataSource = db.PersonsFullNameView.ToList();
            tasksDataBindingSource.DataSource = db.Tasks.ToList();
            taskStatusBindingSource.DataSource = db.TaskStatuses.ToList();

            tasksDataBindingSource.Add(new Tasks());

            DataGridViewComboBoxColumn taskNameDataGridViewColumn = new DataGridViewComboBoxColumn();
            taskNameDataGridViewColumn.Name = "TaskName";
           // taskNameDataGridViewColumn.Width = 100;
            taskNameDataGridViewColumn.HeaderText = "Task";
            taskNameDataGridViewColumn.DataPropertyName = "TaskID";
            taskNameDataGridViewColumn.DataSource = tasksDataBindingSource;
            taskNameDataGridViewColumn.DisplayMember = "TaskName";
            taskNameDataGridViewColumn.ValueMember = "ID";
            taskNameDataGridViewColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            taskNameDataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewComboBoxColumn personNameDataGridViewColumn = new DataGridViewComboBoxColumn();
            personNameDataGridViewColumn.Name = "Person_Name";
            //personNameDataGridViewColumn.Width = 100;
            personNameDataGridViewColumn.HeaderText = "Responsible Person";
            personNameDataGridViewColumn.DataPropertyName = "PersonID";
            personNameDataGridViewColumn.DataSource = personsDataBindingSource;
            personNameDataGridViewColumn.DisplayMember = "Person_Name";
            personNameDataGridViewColumn.ValueMember = "ID";
            personNameDataGridViewColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            personsDataBindingSource.Add(new PersonsFullNameView());
            taskNameDataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewComboBoxColumn taskStatusComboBoxColumn = new DataGridViewComboBoxColumn();
            taskStatusComboBoxColumn.Name = "Status";
            taskStatusComboBoxColumn.DataPropertyName = "TaskStatusID";
            taskStatusComboBoxColumn.DataSource = taskStatusBindingSource;
            taskStatusComboBoxColumn.DisplayMember = "StatusName";
            taskStatusComboBoxColumn.ValueMember = "ID";
            taskStatusComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            taskStatusBindingSource.Add(new TaskStatuses());
            taskStatusComboBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvTasks.DataSource = transactionTasksDataBindingSource;
            Point pointDgvTasks = new Point();
            pointDgvTasks.X = btnTasks.Location.X;
            pointDgvTasks.Y = btnTasks.Location.Y+30;
            dgvTasks.Location = pointDgvTasks;
           
            dgvTasks.Columns.Add(taskNameDataGridViewColumn);
            dgvTasks.Columns.Add(personNameDataGridViewColumn);
            dgvTasks.Columns.Add(taskStatusComboBoxColumn);
           // dgvTasks.Size = new System.Drawing.Size(100, 100);
            dgvTasks.RowHeadersWidth = 5;
            

            Controls.Add(dgvTasks);
            dgvTasks.BringToFront();

            ok = new Button();
            ok.Text = "Ok";
            ok.Click += Ok_Click;
            Point okPoint = new Point();
            okPoint.X = dgvTasks.Location.X ;
            okPoint.Y = btnTasks.Location.Y;
            ok.Location = okPoint;
            Controls.Add(ok);

            cancel = new Button();   
            cancel.Text = "Cancel";
            cancel.Click += Cancel_Click;
            Point cancelPoint = new Point();
            cancelPoint.Y = okPoint.Y;
            cancelPoint.X = okPoint.X + 150;
            cancel.Location= cancelPoint;
            Controls.Add(cancel);

        }

        Button ok;
        Button cancel;

        private void Cancel_Click(object sender, EventArgs e)
        {
            Button cancel = (Button)sender;
            dgvTasks.Dispose();
            ok.Dispose();
            transactionTasksDataBindingSource.Clear();
            transactionTasksDataBindingSource = null;
            cancel.Dispose();
            btnTasks.Show();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Button ok = (Button)sender;
            foreach(DataGridViewRow row in dgvTasks.Rows )
            {
                if (row.Index != -1 && !row.IsNewRow)
                {
                     
                    TransactionPersons transactionPersons = row.DataBoundItem as TransactionPersons;
                    if (transactionPersons.ID==0)
                    {
                        transactionPersons.DocumentTransactionsID = documentTransactions.ID;
                        transactionPersons.TaskStatusID = 1; // workaround till status is added to dgv

                        db.TransactionPersons.Add(transactionPersons);
                    }
                }
            }

            ok.Dispose();
            cancel.Dispose();
            dgvTasks.Dispose();
            btnTasks.Show();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();

           

         /*   if (MdiParent.Name == "frmEditDocument")
            {
               frmEditDocument form = MdiParent as frmEditDocument;
               
                foreach (TabPage tabPage in form.tabControlMain.TabPages )
                {
                    if (tabPage.Name == Name)
                    {
                       // tabPage.Dispose();
                    }
                }
            } else if (MdiParent.Name == "frmNewDocument")
            {
                frmNewDocument form = Parent as frmNewDocument;

                foreach (TabPage tabPage in form.tabControlMain.TabPages)
                {
                    if (tabPage.Name == Name)
                    {
                        //tabPage.Dispose();
                    }
                }

            }*/

          
        }

        private TabControl tabCtrl;
        private TabPage tabPag;
        private void  Form_Gotfocus(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        public TabPage TabPag
        {
            get
            {
                return tabPag;
            }
            set
            {
                tabPag = value;
            }
        }

        public TabControl TabCtrl
        {
            set
            {
                tabCtrl = value;
            }
        }

        private void frmDocumentTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvTransactionLines, Name + dgvTransactionLines.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }
        }

        private void dgvTransactionLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1 && e.ColumnIndex == Items_ItemID_Code_ID.Index)
            {
                //TransactionLines transactionLines = dgvTransactionLines.Rows[e.RowIndex].DataBoundItem as TransactionLines;
                int itemID = (int)dgvTransactionLines.Rows[e.RowIndex].Cells[Items_ItemID_Code_ID.Index].Value;
                Items item = db.Items.Where(i => i.ID.Equals(itemID)).SingleOrDefault();
                

                if (item.DefaultMu != 0)
                {
                    dgvTransactionLines.Rows[e.RowIndex].Cells[Mu_MuID_Code_ID.Index].Value = item.DefaultMu;
                } 
                
                if (item.DefaultPartition != 0)
                {
                    dgvTransactionLines.Rows[e.RowIndex].Cells[Partitions_PartitionID_code_ID.Index].Value = item.DefaultPartition;
                } 

                if (item.DefaultSurfaceID!= 0)
                {
                    dgvTransactionLines.Rows[e.RowIndex].Cells[Surfaces_SurfaceID_SurfaceName_ID.Index].Value = item.DefaultSurfaceID;
                }
            }
        }

        private void dgvTransactionLines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.ColumnIndex == TransactionReceipt_ReceiptID_Name_ID.Index)
            {
                if (dgvTransactionLines.Rows[e.RowIndex].Cells[Items_ItemID_Code_ID.Index].Value != null)
                {
                    frmReceiptSelector frmReceiptSelector = new frmReceiptSelector();
                    frmReceiptSelector.db = db;
                    frmReceiptSelector.FormClosing += FrmReceiptSelector_FormClosing;
                    Items item = new Items();
                    int itmId = (int)dgvTransactionLines.Rows[e.RowIndex].Cells[Items_ItemID_Code_ID.Index].Value;
                    item = db.Items.Where(i => i.ID == itmId).SingleOrDefault();
                    frmReceiptSelector.item = item;
                    CommonTasks.OpenForm(frmReceiptSelector);
                }
            } else if (e.ColumnIndex != -1 && e.ColumnIndex == Items_ItemID_Description_ID.Index)
            {
                frmItemSelector frmItemSelector  = new frmItemSelector();
                frmItemSelector.db = db;
                frmItemSelector.FormClosing += FrmItemSelector_FormClosing;
                CommonTasks.OpenForm(frmItemSelector);
            }
        }

        private void FrmItemSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmItemSelector frmItemSelector = (frmItemSelector)sender;
            Items selectedItem = frmItemSelector.dgvItemsSelector.CurrentRow.DataBoundItem as Items;
            if (selectedItem != null)
            {
                if(frmItemSelector.xClicked==false)
                {
                    dgvTransactionLines.CurrentRow.Cells[Items_ItemID_Code_ID.Index].Value = selectedItem.ID;

                }
            }
        }
    }
}
