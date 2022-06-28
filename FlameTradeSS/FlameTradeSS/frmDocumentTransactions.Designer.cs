﻿namespace FlameTradeSS
{
    partial class frmDocumentTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbTransactipnType = new System.Windows.Forms.ComboBox();
            this.documentTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTransactionLines = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemDescriptionDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.machineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.muBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPartitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionExpenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingInvoiceQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingProductionQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingPackagingQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDeliveryQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedMatDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCanceledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTransactipnType
            // 
            this.cmbTransactipnType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.documentTransactionsBindingSource, "TransactionTypeID", true));
            this.cmbTransactipnType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentTransactionsBindingSource, "TransactionTypeID", true));
            this.cmbTransactipnType.DataSource = this.transactionsTypeBindingSource;
            this.cmbTransactipnType.DisplayMember = "TypeName";
            this.cmbTransactipnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTransactipnType.Enabled = false;
            this.cmbTransactipnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransactipnType.FormattingEnabled = true;
            this.cmbTransactipnType.Location = new System.Drawing.Point(12, 12);
            this.cmbTransactipnType.Name = "cmbTransactipnType";
            this.cmbTransactipnType.Size = new System.Drawing.Size(162, 21);
            this.cmbTransactipnType.TabIndex = 0;
            this.cmbTransactipnType.ValueMember = "ID";
            // 
            // documentTransactionsBindingSource
            // 
            this.documentTransactionsBindingSource.DataSource = typeof(FlameTradeSS.DocumentTransactions);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // dateTimeTransactionDate
            // 
            this.dateTimeTransactionDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentTransactionsBindingSource, "TransactionDate", true));
            this.dateTimeTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransactionDate.Location = new System.Drawing.Point(180, 13);
            this.dateTimeTransactionDate.Name = "dateTimeTransactionDate";
            this.dateTimeTransactionDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimeTransactionDate.TabIndex = 1;
            // 
            // dgvTransactionLines
            // 
            this.dgvTransactionLines.AllowUserToOrderColumns = true;
            this.dgvTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactionLines.AutoGenerateColumns = false;
            this.dgvTransactionLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.ItemDescriptionDataGridViewComboBoxColumn,
            this.machineIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.durationHoursDataGridViewTextBoxColumn,
            this.cyclesDataGridViewTextBoxColumn,
            this.orderingDataGridViewTextBoxColumn,
            this.receiptIDDataGridViewTextBoxColumn,
            this.muIDDataGridViewTextBoxColumn,
            this.partitionIDDataGridViewTextBoxColumn,
            this.secondPartitionIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.additionExpenseDataGridViewTextBoxColumn,
            this.salePrice1DataGridViewTextBoxColumn,
            this.salePrice2DataGridViewTextBoxColumn,
            this.salePrice3DataGridViewTextBoxColumn,
            this.remainingQTYDataGridViewTextBoxColumn,
            this.remainingInvoiceQTYDataGridViewTextBoxColumn,
            this.remainingProductionQTYDataGridViewTextBoxColumn,
            this.remainingPackagingQTYDataGridViewTextBoxColumn,
            this.remainingDeliveryQTYDataGridViewTextBoxColumn,
            this.expectedMatDateDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.costPrice1DataGridViewTextBoxColumn,
            this.costPrice2DataGridViewTextBoxColumn,
            this.costPrice3DataGridViewTextBoxColumn,
            this.isCanceledDataGridViewTextBoxColumn});
            this.dgvTransactionLines.DataSource = this.transactionLinesBindingSource;
            this.dgvTransactionLines.Location = new System.Drawing.Point(12, 211);
            this.dgvTransactionLines.Name = "dgvTransactionLines";
            this.dgvTransactionLines.RowHeadersWidth = 20;
            this.dgvTransactionLines.Size = new System.Drawing.Size(692, 329);
            this.dgvTransactionLines.TabIndex = 2;
            this.dgvTransactionLines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionLines_CellClick);
            this.dgvTransactionLines.CurrentCellChanged += new System.EventHandler(this.dgvTransactionLines_CurrentCellChanged);
            this.dgvTransactionLines.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTransactionLines_RowsAdded);
            this.dgvTransactionLines.Click += new System.EventHandler(this.dgvTransactionLines_Click);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.DataSource = this.itemsBindingSource;
            this.itemIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Код";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.itemIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // ItemDescriptionDataGridViewComboBoxColumn
            // 
            this.ItemDescriptionDataGridViewComboBoxColumn.DataPropertyName = "ItemID";
            this.ItemDescriptionDataGridViewComboBoxColumn.DataSource = this.itemsBindingSource;
            this.ItemDescriptionDataGridViewComboBoxColumn.DisplayMember = "Description";
            this.ItemDescriptionDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemDescriptionDataGridViewComboBoxColumn.HeaderText = "Описание";
            this.ItemDescriptionDataGridViewComboBoxColumn.MinimumWidth = 10;
            this.ItemDescriptionDataGridViewComboBoxColumn.Name = "ItemDescriptionDataGridViewComboBoxColumn";
            this.ItemDescriptionDataGridViewComboBoxColumn.ValueMember = "ID";
            this.ItemDescriptionDataGridViewComboBoxColumn.Width = 200;
            // 
            // machineIDDataGridViewTextBoxColumn
            // 
            this.machineIDDataGridViewTextBoxColumn.DataPropertyName = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.HeaderText = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.machineIDDataGridViewTextBoxColumn.Name = "machineIDDataGridViewTextBoxColumn";
            this.machineIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // durationHoursDataGridViewTextBoxColumn
            // 
            this.durationHoursDataGridViewTextBoxColumn.DataPropertyName = "DurationHours";
            this.durationHoursDataGridViewTextBoxColumn.HeaderText = "DurationHours";
            this.durationHoursDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.durationHoursDataGridViewTextBoxColumn.Name = "durationHoursDataGridViewTextBoxColumn";
            this.durationHoursDataGridViewTextBoxColumn.Width = 200;
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            this.cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.HeaderText = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            this.cyclesDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderingDataGridViewTextBoxColumn
            // 
            this.orderingDataGridViewTextBoxColumn.DataPropertyName = "Ordering";
            this.orderingDataGridViewTextBoxColumn.HeaderText = "Ordering";
            this.orderingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderingDataGridViewTextBoxColumn.Name = "orderingDataGridViewTextBoxColumn";
            this.orderingDataGridViewTextBoxColumn.Width = 200;
            // 
            // receiptIDDataGridViewTextBoxColumn
            // 
            this.receiptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.DataSource = this.transactionReceiptBindingSource;
            this.receiptIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.receiptIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.receiptIDDataGridViewTextBoxColumn.HeaderText = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.receiptIDDataGridViewTextBoxColumn.Name = "receiptIDDataGridViewTextBoxColumn";
            this.receiptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.receiptIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.receiptIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // transactionReceiptBindingSource
            // 
            this.transactionReceiptBindingSource.DataSource = typeof(FlameTradeSS.TransactionReceipt);
            // 
            // muIDDataGridViewTextBoxColumn
            // 
            this.muIDDataGridViewTextBoxColumn.DataPropertyName = "MuID";
            this.muIDDataGridViewTextBoxColumn.DataSource = this.muBindingSource;
            this.muIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.muIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.muIDDataGridViewTextBoxColumn.HeaderText = "МЕ";
            this.muIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.muIDDataGridViewTextBoxColumn.Name = "muIDDataGridViewTextBoxColumn";
            this.muIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.muIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.muIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.muIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // muBindingSource
            // 
            this.muBindingSource.DataSource = typeof(FlameTradeSS.Mu);
            // 
            // partitionIDDataGridViewTextBoxColumn
            // 
            this.partitionIDDataGridViewTextBoxColumn.DataPropertyName = "PartitionID";
            this.partitionIDDataGridViewTextBoxColumn.HeaderText = "PartitionID";
            this.partitionIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.partitionIDDataGridViewTextBoxColumn.Name = "partitionIDDataGridViewTextBoxColumn";
            this.partitionIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // secondPartitionIDDataGridViewTextBoxColumn
            // 
            this.secondPartitionIDDataGridViewTextBoxColumn.DataPropertyName = "SecondPartitionID";
            this.secondPartitionIDDataGridViewTextBoxColumn.HeaderText = "SecondPartitionID";
            this.secondPartitionIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.secondPartitionIDDataGridViewTextBoxColumn.Name = "secondPartitionIDDataGridViewTextBoxColumn";
            this.secondPartitionIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 200;
            // 
            // additionExpenseDataGridViewTextBoxColumn
            // 
            this.additionExpenseDataGridViewTextBoxColumn.DataPropertyName = "AdditionExpense";
            this.additionExpenseDataGridViewTextBoxColumn.HeaderText = "AdditionExpense";
            this.additionExpenseDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.additionExpenseDataGridViewTextBoxColumn.Name = "additionExpenseDataGridViewTextBoxColumn";
            this.additionExpenseDataGridViewTextBoxColumn.Width = 200;
            // 
            // salePrice1DataGridViewTextBoxColumn
            // 
            this.salePrice1DataGridViewTextBoxColumn.DataPropertyName = "SalePrice1";
            this.salePrice1DataGridViewTextBoxColumn.HeaderText = "SalePrice1";
            this.salePrice1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salePrice1DataGridViewTextBoxColumn.Name = "salePrice1DataGridViewTextBoxColumn";
            this.salePrice1DataGridViewTextBoxColumn.Width = 200;
            // 
            // salePrice2DataGridViewTextBoxColumn
            // 
            this.salePrice2DataGridViewTextBoxColumn.DataPropertyName = "SalePrice2";
            this.salePrice2DataGridViewTextBoxColumn.HeaderText = "SalePrice2";
            this.salePrice2DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salePrice2DataGridViewTextBoxColumn.Name = "salePrice2DataGridViewTextBoxColumn";
            this.salePrice2DataGridViewTextBoxColumn.Width = 200;
            // 
            // salePrice3DataGridViewTextBoxColumn
            // 
            this.salePrice3DataGridViewTextBoxColumn.DataPropertyName = "SalePrice3";
            this.salePrice3DataGridViewTextBoxColumn.HeaderText = "SalePrice3";
            this.salePrice3DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salePrice3DataGridViewTextBoxColumn.Name = "salePrice3DataGridViewTextBoxColumn";
            this.salePrice3DataGridViewTextBoxColumn.Width = 200;
            // 
            // remainingQTYDataGridViewTextBoxColumn
            // 
            this.remainingQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.HeaderText = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remainingQTYDataGridViewTextBoxColumn.Name = "remainingQTYDataGridViewTextBoxColumn";
            this.remainingQTYDataGridViewTextBoxColumn.Width = 200;
            // 
            // remainingInvoiceQTYDataGridViewTextBoxColumn
            // 
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingInvoiceQTY";
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.HeaderText = "RemainingInvoiceQTY";
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.Name = "remainingInvoiceQTYDataGridViewTextBoxColumn";
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.Width = 200;
            // 
            // remainingProductionQTYDataGridViewTextBoxColumn
            // 
            this.remainingProductionQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingProductionQTY";
            this.remainingProductionQTYDataGridViewTextBoxColumn.HeaderText = "RemainingProductionQTY";
            this.remainingProductionQTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remainingProductionQTYDataGridViewTextBoxColumn.Name = "remainingProductionQTYDataGridViewTextBoxColumn";
            this.remainingProductionQTYDataGridViewTextBoxColumn.Width = 200;
            // 
            // remainingPackagingQTYDataGridViewTextBoxColumn
            // 
            this.remainingPackagingQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingPackagingQTY";
            this.remainingPackagingQTYDataGridViewTextBoxColumn.HeaderText = "RemainingPackagingQTY";
            this.remainingPackagingQTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remainingPackagingQTYDataGridViewTextBoxColumn.Name = "remainingPackagingQTYDataGridViewTextBoxColumn";
            this.remainingPackagingQTYDataGridViewTextBoxColumn.Width = 200;
            // 
            // remainingDeliveryQTYDataGridViewTextBoxColumn
            // 
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingDeliveryQTY";
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.HeaderText = "RemainingDeliveryQTY";
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.Name = "remainingDeliveryQTYDataGridViewTextBoxColumn";
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.Width = 200;
            // 
            // expectedMatDateDataGridViewTextBoxColumn
            // 
            this.expectedMatDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedMatDate";
            this.expectedMatDateDataGridViewTextBoxColumn.HeaderText = "ExpectedMatDate";
            this.expectedMatDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.expectedMatDateDataGridViewTextBoxColumn.Name = "expectedMatDateDataGridViewTextBoxColumn";
            this.expectedMatDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // costPrice1DataGridViewTextBoxColumn
            // 
            this.costPrice1DataGridViewTextBoxColumn.DataPropertyName = "CostPrice1";
            this.costPrice1DataGridViewTextBoxColumn.HeaderText = "CostPrice1";
            this.costPrice1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.costPrice1DataGridViewTextBoxColumn.Name = "costPrice1DataGridViewTextBoxColumn";
            this.costPrice1DataGridViewTextBoxColumn.Width = 200;
            // 
            // costPrice2DataGridViewTextBoxColumn
            // 
            this.costPrice2DataGridViewTextBoxColumn.DataPropertyName = "CostPrice2";
            this.costPrice2DataGridViewTextBoxColumn.HeaderText = "CostPrice2";
            this.costPrice2DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.costPrice2DataGridViewTextBoxColumn.Name = "costPrice2DataGridViewTextBoxColumn";
            this.costPrice2DataGridViewTextBoxColumn.Width = 200;
            // 
            // costPrice3DataGridViewTextBoxColumn
            // 
            this.costPrice3DataGridViewTextBoxColumn.DataPropertyName = "CostPrice3";
            this.costPrice3DataGridViewTextBoxColumn.HeaderText = "CostPrice3";
            this.costPrice3DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.costPrice3DataGridViewTextBoxColumn.Name = "costPrice3DataGridViewTextBoxColumn";
            this.costPrice3DataGridViewTextBoxColumn.Width = 200;
            // 
            // isCanceledDataGridViewTextBoxColumn
            // 
            this.isCanceledDataGridViewTextBoxColumn.DataPropertyName = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.HeaderText = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.isCanceledDataGridViewTextBoxColumn.Name = "isCanceledDataGridViewTextBoxColumn";
            this.isCanceledDataGridViewTextBoxColumn.Width = 200;
            // 
            // transactionLinesBindingSource
            // 
            this.transactionLinesBindingSource.DataSource = typeof(FlameTradeSS.TransactionLines);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(351, 12);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(75, 23);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "+ Задачи";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(655, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDocumentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(716, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.dgvTransactionLines);
            this.Controls.Add(this.dateTimeTransactionDate);
            this.Controls.Add(this.cmbTransactipnType);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocumentTransactions";
            this.Text = "Document Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocumentTransactions_FormClosing);
            this.Load += new System.EventHandler(this.frmDocumentTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTransactipnType;
        public System.Windows.Forms.BindingSource documentTransactionsBindingSource;
        public System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        public System.Windows.Forms.DataGridView dgvTransactionLines;
        public System.Windows.Forms.BindingSource transactionLinesBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource muBindingSource;
        private System.Windows.Forms.BindingSource transactionReceiptBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemDescriptionDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyclesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn receiptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn muIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPartitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionExpenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingInvoiceQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingProductionQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingPackagingQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDeliveryQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedMatDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCanceledDataGridViewTextBoxColumn;
        public System.Windows.Forms.DateTimePicker dateTimeTransactionDate;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnClose;
    }
}