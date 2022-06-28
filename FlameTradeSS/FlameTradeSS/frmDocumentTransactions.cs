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
                    dgvTransactionLines.Columns[machineIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[serviceIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[startDateDataGridViewTextBoxColumn.Name].Visible=false;
                    dgvTransactionLines.Columns[endDateDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[durationHoursDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[cyclesDataGridViewTextBoxColumn.Name].Visible = false;
                    itemsBindingSource.DataSource = db.Items.ToList();
                    transactionReceiptBindingSource.DataSource = db.TransactionReceipt.ToList();
                    
                    break;
                case "MachineID":
                    dgvTransactionLines.Columns[ItemDescriptionDataGridViewComboBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[itemIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[serviceIDDataGridViewTextBoxColumn.Name].Visible = false;
                    
                    break;
                case "ServiceID":
                    dgvTransactionLines.Columns[ItemDescriptionDataGridViewComboBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[itemIDDataGridViewTextBoxColumn.Name].Visible = false;
                    dgvTransactionLines.Columns[machineIDDataGridViewTextBoxColumn.Name].Visible = false;
                    break;
            }
        }

        public  FlameTradeDbEntities db;

        public  DocumentTransactions documentTransactions;


        private async void dgvTransactionLines_Click(object sender, EventArgs e)
        {
        }

        private void frmDocumentTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = true;
           // Hide();
        }

        private void dgvTransactionLines_CurrentCellChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvTransactionLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == receiptIDDataGridViewTextBoxColumn.Index)
            {
                if (dgvTransactionLines.Rows[e.RowIndex].Cells[itemIDDataGridViewTextBoxColumn.Index].Value != null)
                {
                    frmReceiptSelector frmReceiptSelector = new frmReceiptSelector();
                    frmReceiptSelector.db = db;
                    frmReceiptSelector.FormClosing += FrmReceiptSelector_FormClosing;
                    Items item = new Items();
                    int itmId = (int)dgvTransactionLines.Rows[e.RowIndex].Cells[itemIDDataGridViewTextBoxColumn.Index].Value;
                    item = db.Items.Where(i => i.ID ==  itmId ).SingleOrDefault();
                    frmReceiptSelector.item = item;
                    CommonTasks.OpenForm(frmReceiptSelector);
                }
            } 
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
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.AutoGenerateColumns = false;
            dgvTasks.AutoSize = true;
            
            personsDataBindingSource.DataSource = db.PersonsFullNameView.ToList();
            tasksDataBindingSource.DataSource = db.Tasks.ToList();

            tasksDataBindingSource.Add(new Tasks());

            DataGridViewComboBoxColumn taskNameDataGridViewColumn = new DataGridViewComboBoxColumn();
            taskNameDataGridViewColumn.Name = "TaskName";
            taskNameDataGridViewColumn.Width = 100;
            taskNameDataGridViewColumn.HeaderText = "Task";
            taskNameDataGridViewColumn.DataPropertyName = "TaskID";
            taskNameDataGridViewColumn.DataSource = tasksDataBindingSource;
            taskNameDataGridViewColumn.DisplayMember = "TaskName";
            taskNameDataGridViewColumn.ValueMember = "ID";
            

            DataGridViewComboBoxColumn personNameDataGridViewColumn = new DataGridViewComboBoxColumn();
            personNameDataGridViewColumn.Name = "Person_Name";
            personNameDataGridViewColumn.Width = 100;
            personNameDataGridViewColumn.HeaderText = "Responsible Person";
            personNameDataGridViewColumn.DataPropertyName = "PersonID";
            personNameDataGridViewColumn.DataSource = personsDataBindingSource;
            personNameDataGridViewColumn.DisplayMember = "Person_Name";
            personNameDataGridViewColumn.ValueMember = "ID";
            personsDataBindingSource.Add(new PersonsFullNameView());

            dgvTasks.DataSource = transactionTasksDataBindingSource;
            Point pointDgvTasks = new Point();
            pointDgvTasks.X = btnTasks.Location.X;
            pointDgvTasks.Y = btnTasks.Location.Y+30;
            dgvTasks.Location = pointDgvTasks;
           
            dgvTasks.Columns.Add(taskNameDataGridViewColumn);
            dgvTasks.Columns.Add(personNameDataGridViewColumn);
            dgvTasks.Size = new System.Drawing.Size(100, 100);
            

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

        private void dgvTransactionLines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
          /*  DataGridView dgvr = (DataGridView)sender;
            TransactionLines transactionLines = dgvr.Rows[e.RowIndex].DataBoundItem as TransactionLines;
            if (e.RowIndex!=0 &&  transactionLines==null && dgvr.Rows[e.RowIndex].IsNewRow)
            {
                
                transactionLines.TransactionsID = documentTransactions.ID;

                db.TransactionLines.Add(transactionLines);
            }*/
        }
    }
}
