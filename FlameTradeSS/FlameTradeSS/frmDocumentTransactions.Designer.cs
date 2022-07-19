namespace FlameTradeSS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbTransactipnType = new System.Windows.Forms.ComboBox();
            this.documentTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTransactionLines = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuTransactionLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transactionLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Items_ItemID_Code_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Items_ItemID_Description_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Machines_MachineID_Code_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Services_ServiceID_Code_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Surfaces_SurfaceID_SurfaceName_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionReceipt_ReceiptID_Name_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mu_MuID_Code_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Partitions_PartitionID_code_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Partitions_SecondPartitionID_Code_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinancialCategoryID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingInvoiceQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingProductionQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingPackagingQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingDeliveryQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedMatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse_WH_WhCode_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsCanceled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
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
            this.cmbTransactipnType.Location = new System.Drawing.Point(12, 23);
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
            this.dateTimeTransactionDate.Location = new System.Drawing.Point(179, 23);
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
            this.Items_ItemID_Code_ID,
            this.Items_ItemID_Description_ID,
            this.Machines_MachineID_Code_ID,
            this.Services_ServiceID_Code_ID,
            this.Surfaces_SurfaceID_SurfaceName_ID,
            this.StartDate,
            this.EndDate,
            this.DurationHours,
            this.Cycles,
            this.Ordering,
            this.TransactionReceipt_ReceiptID_Name_ID,
            this.Mu_MuID_Code_ID,
            this.Partitions_PartitionID_code_ID,
            this.Partitions_SecondPartitionID_Code_ID,
            this.Qty,
            this.FinancialCategoryID,
            this.Comment,
            this.AdditionExpense,
            this.SalePrice1,
            this.SalePrice2,
            this.SalePrice3,
            this.RemainingQTY,
            this.RemainingInvoiceQTY,
            this.RemainingProductionQTY,
            this.RemainingPackagingQTY,
            this.RemainingDeliveryQTY,
            this.ExpectedMatDate,
            this.RequestDate,
            this.CostPrice1,
            this.CostPrice2,
            this.CostPrice3,
            this.Warehouse_WH_WhCode_ID,
            this.IsCanceled});
            this.dgvTransactionLines.ContextMenuStrip = this.contextMenuTransactionLines;
            this.dgvTransactionLines.DataSource = this.transactionLinesBindingSource;
            this.dgvTransactionLines.Location = new System.Drawing.Point(12, 211);
            this.dgvTransactionLines.Name = "dgvTransactionLines";
            this.dgvTransactionLines.RowHeadersWidth = 20;
            this.dgvTransactionLines.Size = new System.Drawing.Size(902, 329);
            this.dgvTransactionLines.TabIndex = 2;
            this.dgvTransactionLines.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTransactionLines_CellBeginEdit);
            this.dgvTransactionLines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionLines_CellClick);
            this.dgvTransactionLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionLines_CellDoubleClick);
            this.dgvTransactionLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionLines_CellValueChanged);
            this.dgvTransactionLines.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTransactionLines_RowsAdded);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataSource = typeof(FlameTradeSS.Machines);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(FlameTradeSS.Services);
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // transactionReceiptBindingSource
            // 
            this.transactionReceiptBindingSource.DataSource = typeof(FlameTradeSS.TransactionReceipt);
            // 
            // muBindingSource
            // 
            this.muBindingSource.DataSource = typeof(FlameTradeSS.Mu);
            // 
            // partitionsBindingSource
            // 
            this.partitionsBindingSource.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // partitionsBindingSource1
            // 
            this.partitionsBindingSource1.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // financialCategoriesBindingSource
            // 
            this.financialCategoriesBindingSource.DataSource = typeof(FlameTradeSS.FinancialCategories);
            // 
            // contextMenuTransactionLines
            // 
            this.contextMenuTransactionLines.Name = "contextMenuTransactionLines";
            this.contextMenuTransactionLines.Size = new System.Drawing.Size(61, 4);
            this.contextMenuTransactionLines.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuTransactionLines_Opening);
            // 
            // transactionLinesBindingSource
            // 
            this.transactionLinesBindingSource.DataSource = typeof(FlameTradeSS.TransactionLines);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(276, 20);
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
            this.btnClose.Location = new System.Drawing.Point(871, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataSource = typeof(FlameTradeSS.Warehouses);
            // 
            // Items_ItemID_Code_ID
            // 
            this.Items_ItemID_Code_ID.DataPropertyName = "ItemID";
            this.Items_ItemID_Code_ID.DataSource = this.itemsBindingSource;
            this.Items_ItemID_Code_ID.DisplayMember = "Code";
            this.Items_ItemID_Code_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Items_ItemID_Code_ID.HeaderText = "Код";
            this.Items_ItemID_Code_ID.MinimumWidth = 10;
            this.Items_ItemID_Code_ID.Name = "Items_ItemID_Code_ID";
            this.Items_ItemID_Code_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Items_ItemID_Code_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Items_ItemID_Code_ID.ValueMember = "ID";
            // 
            // Items_ItemID_Description_ID
            // 
            this.Items_ItemID_Description_ID.DataPropertyName = "ItemID";
            this.Items_ItemID_Description_ID.DataSource = this.itemsBindingSource;
            this.Items_ItemID_Description_ID.DisplayMember = "Description";
            this.Items_ItemID_Description_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Items_ItemID_Description_ID.HeaderText = "Описание";
            this.Items_ItemID_Description_ID.MinimumWidth = 10;
            this.Items_ItemID_Description_ID.Name = "Items_ItemID_Description_ID";
            this.Items_ItemID_Description_ID.ValueMember = "ID";
            this.Items_ItemID_Description_ID.Width = 200;
            // 
            // Machines_MachineID_Code_ID
            // 
            this.Machines_MachineID_Code_ID.DataPropertyName = "MachineID";
            this.Machines_MachineID_Code_ID.DataSource = this.machinesBindingSource;
            this.Machines_MachineID_Code_ID.DisplayMember = "Code";
            this.Machines_MachineID_Code_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Machines_MachineID_Code_ID.HeaderText = "Машина";
            this.Machines_MachineID_Code_ID.MinimumWidth = 10;
            this.Machines_MachineID_Code_ID.Name = "Machines_MachineID_Code_ID";
            this.Machines_MachineID_Code_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Machines_MachineID_Code_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Machines_MachineID_Code_ID.ValueMember = "ID";
            // 
            // Services_ServiceID_Code_ID
            // 
            this.Services_ServiceID_Code_ID.DataPropertyName = "ServiceID";
            this.Services_ServiceID_Code_ID.DataSource = this.servicesBindingSource;
            this.Services_ServiceID_Code_ID.DisplayMember = "Code";
            this.Services_ServiceID_Code_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Services_ServiceID_Code_ID.HeaderText = "Услуга";
            this.Services_ServiceID_Code_ID.MinimumWidth = 10;
            this.Services_ServiceID_Code_ID.Name = "Services_ServiceID_Code_ID";
            this.Services_ServiceID_Code_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Services_ServiceID_Code_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Services_ServiceID_Code_ID.ValueMember = "ID";
            // 
            // Surfaces_SurfaceID_SurfaceName_ID
            // 
            this.Surfaces_SurfaceID_SurfaceName_ID.DataPropertyName = "SurfaceID";
            this.Surfaces_SurfaceID_SurfaceName_ID.DataSource = this.surfacesBindingSource;
            this.Surfaces_SurfaceID_SurfaceName_ID.DisplayMember = "SurfaceName";
            this.Surfaces_SurfaceID_SurfaceName_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Surfaces_SurfaceID_SurfaceName_ID.HeaderText = "Повърхност";
            this.Surfaces_SurfaceID_SurfaceName_ID.Name = "Surfaces_SurfaceID_SurfaceName_ID";
            this.Surfaces_SurfaceID_SurfaceName_ID.ValueMember = "ID";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.StartDate.HeaderText = "Начална Дата";
            this.StartDate.MinimumWidth = 10;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 110;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.EndDate.HeaderText = "Крайна Дата";
            this.EndDate.MinimumWidth = 10;
            this.EndDate.Name = "EndDate";
            // 
            // DurationHours
            // 
            this.DurationHours.DataPropertyName = "DurationHours";
            dataGridViewCellStyle3.Format = "N2";
            this.DurationHours.DefaultCellStyle = dataGridViewCellStyle3;
            this.DurationHours.HeaderText = "Часове";
            this.DurationHours.MinimumWidth = 10;
            this.DurationHours.Name = "DurationHours";
            // 
            // Cycles
            // 
            this.Cycles.DataPropertyName = "Cycles";
            dataGridViewCellStyle4.Format = "N0";
            this.Cycles.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cycles.HeaderText = "Цикли";
            this.Cycles.MinimumWidth = 10;
            this.Cycles.Name = "Cycles";
            this.Cycles.Width = 80;
            // 
            // Ordering
            // 
            this.Ordering.DataPropertyName = "Ordering";
            dataGridViewCellStyle5.Format = "N0";
            this.Ordering.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ordering.HeaderText = "Подредба";
            this.Ordering.MinimumWidth = 10;
            this.Ordering.Name = "Ordering";
            // 
            // TransactionReceipt_ReceiptID_Name_ID
            // 
            this.TransactionReceipt_ReceiptID_Name_ID.DataPropertyName = "ReceiptID";
            this.TransactionReceipt_ReceiptID_Name_ID.DataSource = this.transactionReceiptBindingSource;
            this.TransactionReceipt_ReceiptID_Name_ID.DisplayMember = "Name";
            this.TransactionReceipt_ReceiptID_Name_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TransactionReceipt_ReceiptID_Name_ID.HeaderText = "Рецепта";
            this.TransactionReceipt_ReceiptID_Name_ID.MinimumWidth = 10;
            this.TransactionReceipt_ReceiptID_Name_ID.Name = "TransactionReceipt_ReceiptID_Name_ID";
            this.TransactionReceipt_ReceiptID_Name_ID.ReadOnly = true;
            this.TransactionReceipt_ReceiptID_Name_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionReceipt_ReceiptID_Name_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TransactionReceipt_ReceiptID_Name_ID.ValueMember = "ID";
            this.TransactionReceipt_ReceiptID_Name_ID.Width = 200;
            // 
            // Mu_MuID_Code_ID
            // 
            this.Mu_MuID_Code_ID.DataPropertyName = "MuID";
            this.Mu_MuID_Code_ID.DataSource = this.muBindingSource;
            this.Mu_MuID_Code_ID.DisplayMember = "Code";
            this.Mu_MuID_Code_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Mu_MuID_Code_ID.HeaderText = "МЕ";
            this.Mu_MuID_Code_ID.MinimumWidth = 10;
            this.Mu_MuID_Code_ID.Name = "Mu_MuID_Code_ID";
            this.Mu_MuID_Code_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mu_MuID_Code_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Mu_MuID_Code_ID.ValueMember = "ID";
            this.Mu_MuID_Code_ID.Width = 200;
            // 
            // Partitions_PartitionID_code_ID
            // 
            this.Partitions_PartitionID_code_ID.DataPropertyName = "PartitionID";
            this.Partitions_PartitionID_code_ID.DataSource = this.partitionsBindingSource;
            this.Partitions_PartitionID_code_ID.DisplayMember = "Code";
            this.Partitions_PartitionID_code_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Partitions_PartitionID_code_ID.HeaderText = "Партида1";
            this.Partitions_PartitionID_code_ID.MinimumWidth = 10;
            this.Partitions_PartitionID_code_ID.Name = "Partitions_PartitionID_code_ID";
            this.Partitions_PartitionID_code_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Partitions_PartitionID_code_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Partitions_PartitionID_code_ID.ValueMember = "ID";
            this.Partitions_PartitionID_code_ID.Width = 200;
            // 
            // Partitions_SecondPartitionID_Code_ID
            // 
            this.Partitions_SecondPartitionID_Code_ID.DataPropertyName = "SecondPartitionID";
            this.Partitions_SecondPartitionID_Code_ID.DataSource = this.partitionsBindingSource1;
            this.Partitions_SecondPartitionID_Code_ID.DisplayMember = "Code";
            this.Partitions_SecondPartitionID_Code_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Partitions_SecondPartitionID_Code_ID.HeaderText = "Партида2";
            this.Partitions_SecondPartitionID_Code_ID.MinimumWidth = 10;
            this.Partitions_SecondPartitionID_Code_ID.Name = "Partitions_SecondPartitionID_Code_ID";
            this.Partitions_SecondPartitionID_Code_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Partitions_SecondPartitionID_Code_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Partitions_SecondPartitionID_Code_ID.ValueMember = "ID";
            this.Partitions_SecondPartitionID_Code_ID.Width = 200;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle6;
            this.Qty.HeaderText = "К-ВО";
            this.Qty.MinimumWidth = 10;
            this.Qty.Name = "Qty";
            this.Qty.Width = 200;
            // 
            // FinancialCategoryID
            // 
            this.FinancialCategoryID.DataPropertyName = "FinancialCategoryID";
            this.FinancialCategoryID.DataSource = this.financialCategoriesBindingSource;
            this.FinancialCategoryID.DisplayMember = "CategoryName";
            this.FinancialCategoryID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.FinancialCategoryID.HeaderText = "Финансова Категория";
            this.FinancialCategoryID.Name = "FinancialCategoryID";
            this.FinancialCategoryID.ValueMember = "ID";
            this.FinancialCategoryID.Width = 130;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // AdditionExpense
            // 
            this.AdditionExpense.DataPropertyName = "AdditionExpense";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            this.AdditionExpense.DefaultCellStyle = dataGridViewCellStyle7;
            this.AdditionExpense.HeaderText = "Допълнителен Разход";
            this.AdditionExpense.MaxInputLength = 100;
            this.AdditionExpense.MinimumWidth = 10;
            this.AdditionExpense.Name = "AdditionExpense";
            this.AdditionExpense.Width = 200;
            // 
            // SalePrice1
            // 
            this.SalePrice1.DataPropertyName = "SalePrice1";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = "0";
            this.SalePrice1.DefaultCellStyle = dataGridViewCellStyle8;
            this.SalePrice1.HeaderText = "Цена1";
            this.SalePrice1.MinimumWidth = 10;
            this.SalePrice1.Name = "SalePrice1";
            this.SalePrice1.Width = 200;
            // 
            // SalePrice2
            // 
            this.SalePrice2.DataPropertyName = "SalePrice2";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = "0";
            this.SalePrice2.DefaultCellStyle = dataGridViewCellStyle9;
            this.SalePrice2.HeaderText = "Цена2";
            this.SalePrice2.MinimumWidth = 10;
            this.SalePrice2.Name = "SalePrice2";
            this.SalePrice2.Width = 200;
            // 
            // SalePrice3
            // 
            this.SalePrice3.DataPropertyName = "SalePrice3";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "0";
            this.SalePrice3.DefaultCellStyle = dataGridViewCellStyle10;
            this.SalePrice3.HeaderText = "Цена3";
            this.SalePrice3.MinimumWidth = 10;
            this.SalePrice3.Name = "SalePrice3";
            this.SalePrice3.Width = 200;
            // 
            // RemainingQTY
            // 
            this.RemainingQTY.DataPropertyName = "RemainingQTY";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.RemainingQTY.DefaultCellStyle = dataGridViewCellStyle11;
            this.RemainingQTY.HeaderText = "Оставащо К-ВО";
            this.RemainingQTY.MinimumWidth = 10;
            this.RemainingQTY.Name = "RemainingQTY";
            this.RemainingQTY.Width = 200;
            // 
            // RemainingInvoiceQTY
            // 
            this.RemainingInvoiceQTY.DataPropertyName = "RemainingInvoiceQTY";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.RemainingInvoiceQTY.DefaultCellStyle = dataGridViewCellStyle12;
            this.RemainingInvoiceQTY.HeaderText = "ОставащоФ-Ра К-ВО";
            this.RemainingInvoiceQTY.MinimumWidth = 10;
            this.RemainingInvoiceQTY.Name = "RemainingInvoiceQTY";
            this.RemainingInvoiceQTY.Width = 200;
            // 
            // RemainingProductionQTY
            // 
            this.RemainingProductionQTY.DataPropertyName = "RemainingProductionQTY";
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.RemainingProductionQTY.DefaultCellStyle = dataGridViewCellStyle13;
            this.RemainingProductionQTY.HeaderText = "ОставащоПр-во К-ВО";
            this.RemainingProductionQTY.MinimumWidth = 10;
            this.RemainingProductionQTY.Name = "RemainingProductionQTY";
            this.RemainingProductionQTY.Width = 200;
            // 
            // RemainingPackagingQTY
            // 
            this.RemainingPackagingQTY.DataPropertyName = "RemainingPackagingQTY";
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.RemainingPackagingQTY.DefaultCellStyle = dataGridViewCellStyle14;
            this.RemainingPackagingQTY.HeaderText = "ОставащоO-не К-ВО";
            this.RemainingPackagingQTY.MinimumWidth = 10;
            this.RemainingPackagingQTY.Name = "RemainingPackagingQTY";
            this.RemainingPackagingQTY.Width = 200;
            // 
            // RemainingDeliveryQTY
            // 
            this.RemainingDeliveryQTY.DataPropertyName = "RemainingDeliveryQTY";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.RemainingDeliveryQTY.DefaultCellStyle = dataGridViewCellStyle15;
            this.RemainingDeliveryQTY.HeaderText = "ОставащоД-ка К-ВО";
            this.RemainingDeliveryQTY.MinimumWidth = 10;
            this.RemainingDeliveryQTY.Name = "RemainingDeliveryQTY";
            this.RemainingDeliveryQTY.Width = 200;
            // 
            // ExpectedMatDate
            // 
            this.ExpectedMatDate.DataPropertyName = "ExpectedMatDate";
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.ExpectedMatDate.DefaultCellStyle = dataGridViewCellStyle16;
            this.ExpectedMatDate.HeaderText = "Очаквана Дата - Мат.";
            this.ExpectedMatDate.MinimumWidth = 10;
            this.ExpectedMatDate.Name = "ExpectedMatDate";
            this.ExpectedMatDate.Width = 200;
            // 
            // RequestDate
            // 
            this.RequestDate.DataPropertyName = "RequestDate";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.RequestDate.DefaultCellStyle = dataGridViewCellStyle17;
            this.RequestDate.HeaderText = "Искана Дата";
            this.RequestDate.MinimumWidth = 10;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.Width = 200;
            // 
            // CostPrice1
            // 
            this.CostPrice1.DataPropertyName = "CostPrice1";
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = "0";
            this.CostPrice1.DefaultCellStyle = dataGridViewCellStyle18;
            this.CostPrice1.HeaderText = "ЦенаС-ст1";
            this.CostPrice1.MinimumWidth = 10;
            this.CostPrice1.Name = "CostPrice1";
            this.CostPrice1.Width = 200;
            // 
            // CostPrice2
            // 
            this.CostPrice2.DataPropertyName = "CostPrice2";
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = "0";
            this.CostPrice2.DefaultCellStyle = dataGridViewCellStyle19;
            this.CostPrice2.HeaderText = "ЦенаС-ст2";
            this.CostPrice2.MinimumWidth = 10;
            this.CostPrice2.Name = "CostPrice2";
            this.CostPrice2.Width = 200;
            // 
            // CostPrice3
            // 
            this.CostPrice3.DataPropertyName = "CostPrice3";
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = "0";
            this.CostPrice3.DefaultCellStyle = dataGridViewCellStyle20;
            this.CostPrice3.HeaderText = "ЦенаС-ст3";
            this.CostPrice3.MinimumWidth = 10;
            this.CostPrice3.Name = "CostPrice3";
            this.CostPrice3.Width = 200;
            // 
            // Warehouse_WH_WhCode_ID
            // 
            this.Warehouse_WH_WhCode_ID.DataPropertyName = "WH";
            this.Warehouse_WH_WhCode_ID.DataSource = this.warehousesBindingSource;
            this.Warehouse_WH_WhCode_ID.DisplayMember = "WhCode";
            this.Warehouse_WH_WhCode_ID.HeaderText = "WH";
            this.Warehouse_WH_WhCode_ID.Name = "Warehouse_WH_WhCode_ID";
            this.Warehouse_WH_WhCode_ID.ValueMember = "WhID";
            // 
            // IsCanceled
            // 
            this.IsCanceled.DataPropertyName = "IsCanceled";
            this.IsCanceled.FalseValue = "0";
            this.IsCanceled.HeaderText = "Анулиран Ред";
            this.IsCanceled.MinimumWidth = 10;
            this.IsCanceled.Name = "IsCanceled";
            this.IsCanceled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsCanceled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsCanceled.TrueValue = "1";
            this.IsCanceled.Width = 200;
            // 
            // frmDocumentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(926, 552);
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
            this.VisibleChanged += new System.EventHandler(this.frmDocumentTransactions_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
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
        public System.Windows.Forms.DateTimePicker dateTimeTransactionDate;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.BindingSource partitionsBindingSource;
        private System.Windows.Forms.BindingSource partitionsBindingSource1;
        private System.Windows.Forms.BindingSource financialCategoriesBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuTransactionLines;
        private System.Windows.Forms.DataGridViewComboBoxColumn Items_ItemID_Code_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Items_ItemID_Description_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Machines_MachineID_Code_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Services_ServiceID_Code_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Surfaces_SurfaceID_SurfaceName_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordering;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransactionReceipt_ReceiptID_Name_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mu_MuID_Code_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Partitions_PartitionID_code_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Partitions_SecondPartitionID_Code_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn FinancialCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingInvoiceQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingProductionQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingPackagingQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingDeliveryQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedMatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Warehouse_WH_WhCode_ID;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCanceled;
    }
}