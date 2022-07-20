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
                CommonTasks.ReadDataGridViewSetting(dgvTransactionLines, "DocumentTransactions" + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            try
            {
                CommonTasks.RestoreForm(this, Properties.Settings.Default.frmDocumentsTransactionsSize, Properties.Settings.Default.frmDocumentsTransactionsState, Properties.Settings.Default.frmDocumentsTransactionsLocation);
            }
            catch { }

            DgvOperations dgvOperations = new DgvOperations();
            dgvTransactionLines = dgvOperations.ConfigureDgv(dgvTransactionLines, db, documentTransactions.Documents.DocumentSequences,documentTransactions);

            List<PossibleFinancialCategoryTransactionsType> allTransactions = new List<PossibleFinancialCategoryTransactionsType>();
            allTransactions = db.PossibleFinancialCategoryTransactionsType.Where(pfct => pfct.TransactionTypeID == documentTransactions.TransactionTypeID).ToList();


            foreach(PossibleFinancialCategoryTransactionsType possible in allTransactions)
            {
                financialCategoriesBindingSource.Add(db.FinancialCategories.Where(fc => fc.ID == possible.FinancialCategoryID).SingleOrDefault());
            }
            documentTransactionsBindingSource.DataSource = documentTransactions;
            transactionLinesBindingSource.DataSource = documentTransactions.TransactionLines.ToList();
            muBindingSource.DataSource = db.Mu.ToList();
            itemsBindingSource.DataSource = db.Items.ToList();
            warehousesBindingSource.DataSource = db.Warehouses.ToList();
            warehousesBindingSource.Add(new Warehouses());



            switch (documentTransactions.TransactionsType.LinesType.Name)
            {
                case "ItemID":


                    dgvTransactionLines.Columns[Machines_MachineID_Code_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Services_ServiceID_Code_ID.Name].Visible = false;
                    Items_ItemID_Code_ID.Visible = true;
                    Items_ItemID_Description_ID.Visible = true;
                    
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
                    Machines_MachineID_Code_ID.Visible = true;
                    
                    break;
                case "ServiceID":
                    dgvTransactionLines.Columns[Items_ItemID_Description_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Items_ItemID_Code_ID.Name].Visible = false;
                    dgvTransactionLines.Columns[Machines_MachineID_Code_ID.Name].Visible = false;
                    servicesBindingSource.DataSource= db.Services.ToList();
                    Services_ServiceID_Code_ID.Visible = true;
                    break;
            }
            if (RemainingQTY.Visible == true)
            {
                RemainingQTY.ReadOnly = true;
                RemainingQTY.DefaultCellStyle.BackColor = Color.LightYellow;
            }
            if (RemainingInvoiceQTY.Visible == true)
            {
                RemainingInvoiceQTY.ReadOnly = true;
                RemainingInvoiceQTY.DefaultCellStyle.BackColor = Color.LightYellow;
            }
            if (RemainingDeliveryQTY.Visible == true)
            {
                RemainingDeliveryQTY.ReadOnly = true;
                RemainingDeliveryQTY.DefaultCellStyle.BackColor = Color.LightYellow;
            }
            if (RemainingPackagingQTY.Visible == true)
            {
                RemainingPackagingQTY.ReadOnly = true;
                RemainingPackagingQTY.DefaultCellStyle.BackColor = Color.LightYellow;
            }
            if (RemainingProductionQTY.Visible == true)
            {
                RemainingProductionQTY.ReadOnly = true;
                RemainingProductionQTY.DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        public  FlameTradeDbEntities db;

        public  DocumentTransactions documentTransactions;

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
                CommonTasks.WriteGrideViewSetting(dgvTransactionLines, "DocumentTransactions" +CurrentSessionData.CurrentUser.UserName);
            }
            catch { }
        }

        private void dgvTransactionLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                TransactionLines transactionLines = dgvTransactionLines.CurrentRow.DataBoundItem as TransactionLines;

                if (transactionLines!=null && transactionLines.DocumentTransactions == null)
                {
                    transactionLines.DocumentTransactions = documentTransactions;
                    transactionLines.Warehouses = db.Warehouses.Where(w => w.WhID == 1).SingleOrDefault();
                    db.TransactionLines.Add(transactionLines);
                }
            }
           

            if (e.RowIndex!=-1 && e.ColumnIndex == Items_ItemID_Code_ID.Index | e.ColumnIndex == Items_ItemID_Description_ID.Index)
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

                if (item.FinancialCategoryID != null)
                {
                    bool exists = false;
                    foreach(FinancialCategories financialCategories in financialCategoriesBindingSource)
                    {
                        if (financialCategories.ID == item.FinancialCategoryID)
                        {
                            exists = true;
                        }
                    }
                    if (exists==true)
                    {
                        dgvTransactionLines.Rows[e.RowIndex].Cells[FinancialCategoryID.Index].Value = item.FinancialCategoryID; 
                    }
                }
            } else if (e.RowIndex!=-1 && e.ColumnIndex == Qty.Index)
            {
                if(RemainingQTY.Visible == true)
                {
                    double oldNewDiff = (double)dgvTransactionLines.CurrentCell.Value - qtyOldValue;
                    if (dgvTransactionLines.CurrentRow.Cells[RemainingQTY.Index].Value!=null)
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingQTY.Index].Value = (double)dgvTransactionLines.CurrentRow.Cells[RemainingQTY.Index].Value + oldNewDiff;
                    } else
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingQTY.Index].Value = dgvTransactionLines.CurrentCell.Value;
                    }
                }
                if (RemainingInvoiceQTY.Visible == true)
                {
                    double oldNewDiff = (double)dgvTransactionLines.CurrentCell.Value - qtyOldValue;
                    if (dgvTransactionLines.CurrentRow.Cells[RemainingInvoiceQTY.Index].Value != null)
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingInvoiceQTY.Index].Value = (double)dgvTransactionLines.CurrentRow.Cells[RemainingInvoiceQTY.Index].Value + oldNewDiff;
                    } else
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingInvoiceQTY.Index].Value = dgvTransactionLines.CurrentCell.Value;
                    }
                }
                if (RemainingDeliveryQTY.Visible == true)
                {
                    double oldNewDiff = (double)dgvTransactionLines.CurrentCell.Value - qtyOldValue;
                    if (dgvTransactionLines.CurrentRow.Cells[RemainingDeliveryQTY.Index].Value != null)
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingDeliveryQTY.Index].Value = (double)dgvTransactionLines.CurrentRow.Cells[RemainingDeliveryQTY.Index].Value + oldNewDiff;
                    }
                    else
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingDeliveryQTY.Index].Value = dgvTransactionLines.CurrentCell.Value;
                    }
                }
                if (RemainingPackagingQTY.Visible == true)
                {
                    double oldNewDiff = (double)dgvTransactionLines.CurrentCell.Value - qtyOldValue;
                    if (dgvTransactionLines.CurrentRow.Cells[RemainingPackagingQTY.Index].Value != null)
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingPackagingQTY.Index].Value = (double)dgvTransactionLines.CurrentRow.Cells[RemainingPackagingQTY.Index].Value + oldNewDiff;
                    }
                    else
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingPackagingQTY.Index].Value = dgvTransactionLines.CurrentCell.Value;
                    }
                }
                if (RemainingProductionQTY.Visible == true)
                {
                    double oldNewDiff = (double)dgvTransactionLines.CurrentCell.Value - qtyOldValue;
                    if (dgvTransactionLines.CurrentRow.Cells[RemainingProductionQTY.Index].Value != null)
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingProductionQTY.Index].Value = (double)dgvTransactionLines.CurrentRow.Cells[RemainingProductionQTY.Index].Value + oldNewDiff;
                    }
                    else
                    {
                        dgvTransactionLines.CurrentRow.Cells[RemainingProductionQTY.Index].Value = dgvTransactionLines.CurrentCell.Value;
                    }
                }
            }
        }

        double qtyOldValue = 0;

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
            } else if (e.ColumnIndex != -1 && e.ColumnIndex == Items_ItemID_Description_ID.Index | e.ColumnIndex == Items_ItemID_Code_ID.Index)
            {
                if (dgvTransactionLines.Rows[e.RowIndex].IsNewRow==true)
                {
                    dgvTransactionLines.AllowUserToAddRows = false;
                   // transactionLinesBindingSource.RemoveCurrent();
                }
                frmItemSelector frmItemSelector  = new frmItemSelector();
                frmItemSelector.db = db;
                frmItemSelector.FormClosing += FrmItemSelector_FormClosing;
                CommonTasks.OpenForm(frmItemSelector);
            }
        }
        
        private void FrmItemSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            frmItemSelector frmItemSelector = (frmItemSelector)sender;

            Items selectedItem = null;


            if (frmItemSelector.dgvItemsSelector.CurrentRow!=null)
            {
                selectedItem = frmItemSelector.dgvItemsSelector.CurrentRow.DataBoundItem as Items;
            }

            if (selectedItem != null)
            {
                if (frmItemSelector.xClicked == false)
                {
                    if (dgvTransactionLines.AllowUserToAddRows == false)
                    {

                        transactionLinesBindingSource.RemoveAt(transactionLinesBindingSource.Count-1);
                        TransactionLines newline = new TransactionLines();
                       
                        newline.Items = selectedItem;
                        newline.DocumentTransactions = documentTransactions;
                        newline.Warehouses = db.Warehouses.Where(w => w.WhID == 1).SingleOrDefault();
                        transactionLinesBindingSource.Add(newline);
                        transactionLinesBindingSource.MoveLast();
                        db.TransactionLines.Add(newline);
                        dgvTransactionLines.CurrentRow.Cells[Items_ItemID_Code_ID.Index].Value = selectedItem.ID;

                        if (selectedItem.DefaultMu != 0)
                        {
                            dgvTransactionLines.Rows[dgvTransactionLines.RowCount-1].Cells[Mu_MuID_Code_ID.Index].Value = selectedItem.DefaultMu;
                        }

                        if (selectedItem.DefaultPartition != 0)
                        {
                            dgvTransactionLines.Rows[dgvTransactionLines.RowCount - 1].Cells[Partitions_PartitionID_code_ID.Index].Value = selectedItem.DefaultPartition;
                        }

                        if (selectedItem.DefaultSurfaceID != 0)
                        {
                            dgvTransactionLines.Rows[dgvTransactionLines.RowCount - 1].Cells[Surfaces_SurfaceID_SurfaceName_ID.Index].Value = selectedItem.DefaultSurfaceID;
                        }

                        if (selectedItem.FinancialCategoryID != null)
                        {
                            bool exists = false;
                            foreach (FinancialCategories financialCategories in financialCategoriesBindingSource)
                            {
                                if (financialCategories.ID == selectedItem.FinancialCategoryID)
                                {
                                    exists = true;
                                }
                            }
                            if (exists == true)
                            {
                                dgvTransactionLines.Rows[dgvTransactionLines.RowCount - 1].Cells[FinancialCategoryID.Index].Value = selectedItem.FinancialCategoryID;
                            }
                        }

                        dgvTransactionLines.AllowUserToAddRows = true;

                    } else
                    {
                        dgvTransactionLines.CurrentRow.Cells[Items_ItemID_Code_ID.Index].Value = selectedItem.ID;
                    }

                } else
                {
                    if (dgvTransactionLines.AllowUserToAddRows == false)
                    {
                        transactionLinesBindingSource.RemoveAt(transactionLinesBindingSource.Count - 1);
                        dgvTransactionLines.AllowUserToAddRows = true;
                    }
                }
            }
        }

        private void dgvTransactionLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == Qty.Index )
            {
                if (dgvTransactionLines.CurrentCell.Value!=null)
                {
                    qtyOldValue = (double)dgvTransactionLines.CurrentCell.Value;
                }
            }
        }

        private void frmDocumentTransactions_VisibleChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.frmDocumentsTransactionsState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmDocumentsTransactionsLocation = this.Location;
                Properties.Settings.Default.frmDocumentsTransactionsSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmDocumentsTransactionsLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmDocumentsTransactionsSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();

            try
            {
                CommonTasks.WriteGrideViewSetting(dgvTransactionLines, "DocumentTransactions" + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }
        }

        private void contextMenuTransactionLines_Opening(object sender, CancelEventArgs e)
        {
            if (dgvTransactionLines.CurrentRow.Index==-1 | dgvTransactionLines.CurrentRow.DataBoundItem==null)
            {
                e.Cancel = true;
            }
            else if (dgvTransactionLines.CurrentCell.ColumnIndex == TransactionReceipt_ReceiptID_Name_ID.Index && dgvTransactionLines.CurrentCell.Value != null)
            {
                bool editReceiptMenuItemExists = false;

                foreach(ToolStripMenuItem toolStripMenuItem in contextMenuTransactionLines.Items)
                {
                    if (toolStripMenuItem.Text== "Редакция на рецепта")
                    {
                        editReceiptMenuItemExists = true;
                    }
                }

                if (editReceiptMenuItemExists== false)
                {
                    ToolStripMenuItem editReceipt = new ToolStripMenuItem();
                    editReceipt.Text = "Редакция на рецепта";
                    editReceipt.Click += EditReceipt_Click;
                    contextMenuTransactionLines.Items.Add(editReceipt);
                }
            }
        }

        private void EditReceipt_Click(object sender, EventArgs e)
        {
            frmEditItemsReceipt frmEditItemsReceipt = new frmEditItemsReceipt();
            frmEditItemsReceipt.db = db;
            int transactionReceiptID = (int)dgvTransactionLines.CurrentRow.Cells[TransactionReceipt_ReceiptID_Name_ID.Index].Value;
            frmEditItemsReceipt.transactionReceipt =db.TransactionReceipt.Where(tr => tr.ID == transactionReceiptID ).SingleOrDefault();
            CommonTasks.OpenForm(frmEditItemsReceipt);
        }

        private void dgvTransactionLines_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           if (dgvTransactionLines.CurrentRow!=null && dgvTransactionLines.CurrentRow.Index != -1 && char.IsNumber(e.KeyChar) | char.IsSymbol(e.KeyChar) && dgvTransactionLines.CurrentCell.ColumnIndex == Items_ItemID_Code_ID.Index | dgvTransactionLines.CurrentCell.ColumnIndex == Items_ItemID_Description_ID.Index)
           {
              if (dgvTransactionLines.CurrentRow.IsNewRow == true)
              {
                  dgvTransactionLines.AllowUserToAddRows = false;
              }
              frmItemSelector frmItemSelector = new frmItemSelector();
              frmItemSelector.db = db;
              frmItemSelector.txtFilter.Text = e.KeyChar.ToString();
              frmItemSelector.txtFilter.SelectedText = null;
              frmItemSelector.FormClosing += FrmItemSelector_FormClosing;
              CommonTasks.OpenForm(frmItemSelector);
           }
        }
    }
}
