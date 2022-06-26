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
            this.transactionLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLines)).BeginInit();
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
            this.cmbTransactipnType.Size = new System.Drawing.Size(204, 21);
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
            this.dateTimeTransactionDate.Location = new System.Drawing.Point(240, 13);
            this.dateTimeTransactionDate.Name = "dateTimeTransactionDate";
            this.dateTimeTransactionDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimeTransactionDate.TabIndex = 1;
            // 
            // dgvTransactionLines
            // 
            this.dgvTransactionLines.AllowUserToAddRows = false;
            this.dgvTransactionLines.AllowUserToOrderColumns = true;
            this.dgvTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactionLines.AutoGenerateColumns = false;
            this.dgvTransactionLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionsIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
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
            this.dgvTransactionLines.Size = new System.Drawing.Size(692, 366);
            this.dgvTransactionLines.TabIndex = 2;
            this.dgvTransactionLines.Click += new System.EventHandler(this.dgvTransactionLines_Click);
            // 
            // transactionLinesBindingSource
            // 
            this.transactionLinesBindingSource.DataSource = typeof(FlameTradeSS.TransactionLines);
            // 
            // transactionsIDDataGridViewTextBoxColumn
            // 
            this.transactionsIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionsID";
            this.transactionsIDDataGridViewTextBoxColumn.HeaderText = "TransactionsID";
            this.transactionsIDDataGridViewTextBoxColumn.Name = "transactionsIDDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // machineIDDataGridViewTextBoxColumn
            // 
            this.machineIDDataGridViewTextBoxColumn.DataPropertyName = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.HeaderText = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.Name = "machineIDDataGridViewTextBoxColumn";
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // durationHoursDataGridViewTextBoxColumn
            // 
            this.durationHoursDataGridViewTextBoxColumn.DataPropertyName = "DurationHours";
            this.durationHoursDataGridViewTextBoxColumn.HeaderText = "DurationHours";
            this.durationHoursDataGridViewTextBoxColumn.Name = "durationHoursDataGridViewTextBoxColumn";
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            this.cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.HeaderText = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            // 
            // orderingDataGridViewTextBoxColumn
            // 
            this.orderingDataGridViewTextBoxColumn.DataPropertyName = "Ordering";
            this.orderingDataGridViewTextBoxColumn.HeaderText = "Ordering";
            this.orderingDataGridViewTextBoxColumn.Name = "orderingDataGridViewTextBoxColumn";
            // 
            // receiptIDDataGridViewTextBoxColumn
            // 
            this.receiptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.HeaderText = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.Name = "receiptIDDataGridViewTextBoxColumn";
            // 
            // muIDDataGridViewTextBoxColumn
            // 
            this.muIDDataGridViewTextBoxColumn.DataPropertyName = "MuID";
            this.muIDDataGridViewTextBoxColumn.HeaderText = "MuID";
            this.muIDDataGridViewTextBoxColumn.Name = "muIDDataGridViewTextBoxColumn";
            // 
            // partitionIDDataGridViewTextBoxColumn
            // 
            this.partitionIDDataGridViewTextBoxColumn.DataPropertyName = "PartitionID";
            this.partitionIDDataGridViewTextBoxColumn.HeaderText = "PartitionID";
            this.partitionIDDataGridViewTextBoxColumn.Name = "partitionIDDataGridViewTextBoxColumn";
            // 
            // secondPartitionIDDataGridViewTextBoxColumn
            // 
            this.secondPartitionIDDataGridViewTextBoxColumn.DataPropertyName = "SecondPartitionID";
            this.secondPartitionIDDataGridViewTextBoxColumn.HeaderText = "SecondPartitionID";
            this.secondPartitionIDDataGridViewTextBoxColumn.Name = "secondPartitionIDDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // additionExpenseDataGridViewTextBoxColumn
            // 
            this.additionExpenseDataGridViewTextBoxColumn.DataPropertyName = "AdditionExpense";
            this.additionExpenseDataGridViewTextBoxColumn.HeaderText = "AdditionExpense";
            this.additionExpenseDataGridViewTextBoxColumn.Name = "additionExpenseDataGridViewTextBoxColumn";
            // 
            // salePrice1DataGridViewTextBoxColumn
            // 
            this.salePrice1DataGridViewTextBoxColumn.DataPropertyName = "SalePrice1";
            this.salePrice1DataGridViewTextBoxColumn.HeaderText = "SalePrice1";
            this.salePrice1DataGridViewTextBoxColumn.Name = "salePrice1DataGridViewTextBoxColumn";
            // 
            // salePrice2DataGridViewTextBoxColumn
            // 
            this.salePrice2DataGridViewTextBoxColumn.DataPropertyName = "SalePrice2";
            this.salePrice2DataGridViewTextBoxColumn.HeaderText = "SalePrice2";
            this.salePrice2DataGridViewTextBoxColumn.Name = "salePrice2DataGridViewTextBoxColumn";
            // 
            // salePrice3DataGridViewTextBoxColumn
            // 
            this.salePrice3DataGridViewTextBoxColumn.DataPropertyName = "SalePrice3";
            this.salePrice3DataGridViewTextBoxColumn.HeaderText = "SalePrice3";
            this.salePrice3DataGridViewTextBoxColumn.Name = "salePrice3DataGridViewTextBoxColumn";
            // 
            // remainingQTYDataGridViewTextBoxColumn
            // 
            this.remainingQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.HeaderText = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.Name = "remainingQTYDataGridViewTextBoxColumn";
            // 
            // remainingInvoiceQTYDataGridViewTextBoxColumn
            // 
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingInvoiceQTY";
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.HeaderText = "RemainingInvoiceQTY";
            this.remainingInvoiceQTYDataGridViewTextBoxColumn.Name = "remainingInvoiceQTYDataGridViewTextBoxColumn";
            // 
            // remainingProductionQTYDataGridViewTextBoxColumn
            // 
            this.remainingProductionQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingProductionQTY";
            this.remainingProductionQTYDataGridViewTextBoxColumn.HeaderText = "RemainingProductionQTY";
            this.remainingProductionQTYDataGridViewTextBoxColumn.Name = "remainingProductionQTYDataGridViewTextBoxColumn";
            // 
            // remainingPackagingQTYDataGridViewTextBoxColumn
            // 
            this.remainingPackagingQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingPackagingQTY";
            this.remainingPackagingQTYDataGridViewTextBoxColumn.HeaderText = "RemainingPackagingQTY";
            this.remainingPackagingQTYDataGridViewTextBoxColumn.Name = "remainingPackagingQTYDataGridViewTextBoxColumn";
            // 
            // remainingDeliveryQTYDataGridViewTextBoxColumn
            // 
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingDeliveryQTY";
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.HeaderText = "RemainingDeliveryQTY";
            this.remainingDeliveryQTYDataGridViewTextBoxColumn.Name = "remainingDeliveryQTYDataGridViewTextBoxColumn";
            // 
            // expectedMatDateDataGridViewTextBoxColumn
            // 
            this.expectedMatDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedMatDate";
            this.expectedMatDateDataGridViewTextBoxColumn.HeaderText = "ExpectedMatDate";
            this.expectedMatDateDataGridViewTextBoxColumn.Name = "expectedMatDateDataGridViewTextBoxColumn";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // costPrice1DataGridViewTextBoxColumn
            // 
            this.costPrice1DataGridViewTextBoxColumn.DataPropertyName = "CostPrice1";
            this.costPrice1DataGridViewTextBoxColumn.HeaderText = "CostPrice1";
            this.costPrice1DataGridViewTextBoxColumn.Name = "costPrice1DataGridViewTextBoxColumn";
            // 
            // costPrice2DataGridViewTextBoxColumn
            // 
            this.costPrice2DataGridViewTextBoxColumn.DataPropertyName = "CostPrice2";
            this.costPrice2DataGridViewTextBoxColumn.HeaderText = "CostPrice2";
            this.costPrice2DataGridViewTextBoxColumn.Name = "costPrice2DataGridViewTextBoxColumn";
            // 
            // costPrice3DataGridViewTextBoxColumn
            // 
            this.costPrice3DataGridViewTextBoxColumn.DataPropertyName = "CostPrice3";
            this.costPrice3DataGridViewTextBoxColumn.HeaderText = "CostPrice3";
            this.costPrice3DataGridViewTextBoxColumn.Name = "costPrice3DataGridViewTextBoxColumn";
            // 
            // isCanceledDataGridViewTextBoxColumn
            // 
            this.isCanceledDataGridViewTextBoxColumn.DataPropertyName = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.HeaderText = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.Name = "isCanceledDataGridViewTextBoxColumn";
            // 
            // frmDocumentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(716, 589);
            this.Controls.Add(this.dgvTransactionLines);
            this.Controls.Add(this.dateTimeTransactionDate);
            this.Controls.Add(this.cmbTransactipnType);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDocumentTransactions";
            this.Text = "Document Transactions";
            this.Load += new System.EventHandler(this.frmDocumentTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTransactipnType;
        public System.Windows.Forms.BindingSource documentTransactionsBindingSource;
        public System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimeTransactionDate;
        public System.Windows.Forms.DataGridView dgvTransactionLines;
        private System.Windows.Forms.BindingSource transactionLinesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyclesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muIDDataGridViewTextBoxColumn;
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
    }
}