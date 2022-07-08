namespace FlameTradeSS
{
    partial class frmPossibleSequenceTransformations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPossibleSequenceTransformations));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPossibleSequenceTransformations = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDocumentSequenceLabel = new System.Windows.Forms.Label();
            this.lblDocumentSequenceName = new System.Windows.Forms.Label();
            this.dgvTransformationsProperties = new System.Windows.Forms.DataGridView();
            this.buttonRemove2 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.transactionsTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possibleSequenceTransformationsPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possibleSequenceTransofrmationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useReceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TransactionTypeIDTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.remainQTYActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remainProductionQTYActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remainPackagingQTYActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemainQTYthis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemainProductionQTYthis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemainPackagingQTYthis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemainDeliveryQTYthis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemainInvoiceQTYthis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleSequenceTransformations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransformationsProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possibleSequenceTransformationsPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possibleSequenceTransofrmationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1231, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPossibleSequenceTransformations
            // 
            this.dgvPossibleSequenceTransformations.AllowUserToAddRows = false;
            this.dgvPossibleSequenceTransformations.AllowUserToDeleteRows = false;
            this.dgvPossibleSequenceTransformations.AutoGenerateColumns = false;
            this.dgvPossibleSequenceTransformations.BackgroundColor = System.Drawing.Color.White;
            this.dgvPossibleSequenceTransformations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPossibleSequenceTransformations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPossibleSequenceTransformations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn});
            this.dgvPossibleSequenceTransformations.DataSource = this.possibleSequenceTransofrmationBindingSource;
            this.dgvPossibleSequenceTransformations.Location = new System.Drawing.Point(12, 65);
            this.dgvPossibleSequenceTransformations.MultiSelect = false;
            this.dgvPossibleSequenceTransformations.Name = "dgvPossibleSequenceTransformations";
            this.dgvPossibleSequenceTransformations.RowHeadersWidth = 20;
            this.dgvPossibleSequenceTransformations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPossibleSequenceTransformations.Size = new System.Drawing.Size(331, 364);
            this.dgvPossibleSequenceTransformations.TabIndex = 10;
            this.dgvPossibleSequenceTransformations.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPossibleSequenceTransformations_CellValueChanged);
            this.dgvPossibleSequenceTransformations.CurrentCellChanged += new System.EventHandler(this.dgvPossibleSequenceTransformations_CurrentCellChanged);
            this.dgvPossibleSequenceTransformations.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPossibleSequenceTransformations_CurrentCellDirtyStateChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(98, 435);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 52);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1181, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDocumentSequenceLabel
            // 
            this.lblDocumentSequenceLabel.AutoSize = true;
            this.lblDocumentSequenceLabel.Location = new System.Drawing.Point(12, 26);
            this.lblDocumentSequenceLabel.Name = "lblDocumentSequenceLabel";
            this.lblDocumentSequenceLabel.Size = new System.Drawing.Size(105, 13);
            this.lblDocumentSequenceLabel.TabIndex = 14;
            this.lblDocumentSequenceLabel.Text = "DocumentSequence";
            // 
            // lblDocumentSequenceName
            // 
            this.lblDocumentSequenceName.AutoSize = true;
            this.lblDocumentSequenceName.Location = new System.Drawing.Point(13, 43);
            this.lblDocumentSequenceName.Name = "lblDocumentSequenceName";
            this.lblDocumentSequenceName.Size = new System.Drawing.Size(13, 13);
            this.lblDocumentSequenceName.TabIndex = 15;
            this.lblDocumentSequenceName.Text = "?";
            // 
            // dgvTransformationsProperties
            // 
            this.dgvTransformationsProperties.AllowUserToAddRows = false;
            this.dgvTransformationsProperties.AllowUserToDeleteRows = false;
            this.dgvTransformationsProperties.AutoGenerateColumns = false;
            this.dgvTransformationsProperties.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransformationsProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransformationsProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransformationsProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useReceiptDataGridViewTextBoxColumn,
            this.TransactionTypeIDTo,
            this.transactionTypeIDDataGridViewTextBoxColumn,
            this.remainQTYActionDataGridViewTextBoxColumn,
            this.remainProductionQTYActionDataGridViewTextBoxColumn,
            this.remainPackagingQTYActionDataGridViewTextBoxColumn,
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn,
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn,
            this.RemainQTYthis,
            this.RemainProductionQTYthis,
            this.RemainPackagingQTYthis,
            this.RemainDeliveryQTYthis,
            this.RemainInvoiceQTYthis});
            this.dgvTransformationsProperties.DataSource = this.possibleSequenceTransformationsPropertiesBindingSource;
            this.dgvTransformationsProperties.Location = new System.Drawing.Point(349, 65);
            this.dgvTransformationsProperties.Name = "dgvTransformationsProperties";
            this.dgvTransformationsProperties.RowHeadersWidth = 20;
            this.dgvTransformationsProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransformationsProperties.Size = new System.Drawing.Size(925, 364);
            this.dgvTransformationsProperties.TabIndex = 16;
            // 
            // buttonRemove2
            // 
            this.buttonRemove2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove2.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRemove2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove2.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.buttonRemove2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove2.Location = new System.Drawing.Point(435, 435);
            this.buttonRemove2.Name = "buttonRemove2";
            this.buttonRemove2.Size = new System.Drawing.Size(100, 52);
            this.buttonRemove2.TabIndex = 18;
            this.buttonRemove2.Text = "Remove";
            this.buttonRemove2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove2.UseVisualStyleBackColor = true;
            this.buttonRemove2.Click += new System.EventHandler(this.buttonRemove2_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd2.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdd2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd2.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.buttonAdd2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd2.Location = new System.Drawing.Point(349, 435);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(80, 52);
            this.buttonAdd2.TabIndex = 17;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // transactionsTypeBindingSource1
            // 
            this.transactionsTypeBindingSource1.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // possibleSequenceTransformationsPropertiesBindingSource
            // 
            this.possibleSequenceTransformationsPropertiesBindingSource.DataSource = typeof(FlameTradeSS.PossibleSequenceTransformationsProperties);
            // 
            // possibleDocumentSequenceIDDataGridViewTextBoxColumn
            // 
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.DataPropertyName = "PossibleDocumentSequenceID";
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.DataSource = this.documentSequencesBindingSource;
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.DisplayMember = "SequenceName";
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.HeaderText = "Възможни Трансформации";
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.Name = "possibleDocumentSequenceIDDataGridViewTextBoxColumn";
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.possibleDocumentSequenceIDDataGridViewTextBoxColumn.Width = 300;
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // possibleSequenceTransofrmationBindingSource
            // 
            this.possibleSequenceTransofrmationBindingSource.DataSource = typeof(FlameTradeSS.PossibleSequenceTransofrmation);
            // 
            // useReceiptDataGridViewTextBoxColumn
            // 
            this.useReceiptDataGridViewTextBoxColumn.DataPropertyName = "UseReceipt";
            this.useReceiptDataGridViewTextBoxColumn.FalseValue = "0";
            this.useReceiptDataGridViewTextBoxColumn.HeaderText = "UseReceipt";
            this.useReceiptDataGridViewTextBoxColumn.Name = "useReceiptDataGridViewTextBoxColumn";
            this.useReceiptDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.useReceiptDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.useReceiptDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // TransactionTypeIDTo
            // 
            this.TransactionTypeIDTo.DataPropertyName = "TransactionTypeIDTo";
            this.TransactionTypeIDTo.DataSource = this.transactionsTypeBindingSource1;
            this.TransactionTypeIDTo.DisplayMember = "TypeName";
            this.TransactionTypeIDTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TransactionTypeIDTo.HeaderText = "To Transaction Type";
            this.TransactionTypeIDTo.Name = "TransactionTypeIDTo";
            this.TransactionTypeIDTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionTypeIDTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TransactionTypeIDTo.ValueMember = "ID";
            this.TransactionTypeIDTo.Width = 150;
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.DataSource = this.transactionsTypeBindingSource;
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "Fron Transaction Type";
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transactionTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.transactionTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // remainQTYActionDataGridViewTextBoxColumn
            // 
            this.remainQTYActionDataGridViewTextBoxColumn.DataPropertyName = "RemainQTYAction";
            this.remainQTYActionDataGridViewTextBoxColumn.FalseValue = "0";
            this.remainQTYActionDataGridViewTextBoxColumn.HeaderText = "RemainQTYAction";
            this.remainQTYActionDataGridViewTextBoxColumn.Name = "remainQTYActionDataGridViewTextBoxColumn";
            this.remainQTYActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remainQTYActionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remainQTYActionDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // remainProductionQTYActionDataGridViewTextBoxColumn
            // 
            this.remainProductionQTYActionDataGridViewTextBoxColumn.DataPropertyName = "RemainProductionQTYAction";
            this.remainProductionQTYActionDataGridViewTextBoxColumn.FalseValue = "0";
            this.remainProductionQTYActionDataGridViewTextBoxColumn.HeaderText = "RemainProductionQTYAction";
            this.remainProductionQTYActionDataGridViewTextBoxColumn.Name = "remainProductionQTYActionDataGridViewTextBoxColumn";
            this.remainProductionQTYActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remainProductionQTYActionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remainProductionQTYActionDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // remainPackagingQTYActionDataGridViewTextBoxColumn
            // 
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.DataPropertyName = "RemainPackagingQTYAction";
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.FalseValue = "0";
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.HeaderText = "RemainPackagingQTYAction";
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.Name = "remainPackagingQTYActionDataGridViewTextBoxColumn";
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remainPackagingQTYActionDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // remainDeliveryQTYActionDataGridViewTextBoxColumn
            // 
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.DataPropertyName = "RemainDeliveryQTYAction";
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.FalseValue = "0";
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.HeaderText = "RemainDeliveryQTYAction";
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.Name = "remainDeliveryQTYActionDataGridViewTextBoxColumn";
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remainDeliveryQTYActionDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // remainInvoiceQTYActionDataGridViewTextBoxColumn
            // 
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.DataPropertyName = "RemainInvoiceQTYAction";
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.FalseValue = "0";
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.HeaderText = "RemainInvoiceQTYAction";
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.Name = "remainInvoiceQTYActionDataGridViewTextBoxColumn";
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remainInvoiceQTYActionDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // RemainQTYthis
            // 
            this.RemainQTYthis.DataPropertyName = "RemainQTYthis";
            this.RemainQTYthis.FalseValue = "0";
            this.RemainQTYthis.HeaderText = "RemainQTYthis";
            this.RemainQTYthis.Name = "RemainQTYthis";
            this.RemainQTYthis.TrueValue = "1";
            // 
            // RemainProductionQTYthis
            // 
            this.RemainProductionQTYthis.DataPropertyName = "RemainProductionQTYthis";
            this.RemainProductionQTYthis.FalseValue = "0";
            this.RemainProductionQTYthis.HeaderText = "RemainProductionQTYthis";
            this.RemainProductionQTYthis.Name = "RemainProductionQTYthis";
            this.RemainProductionQTYthis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RemainProductionQTYthis.TrueValue = "1";
            // 
            // RemainPackagingQTYthis
            // 
            this.RemainPackagingQTYthis.DataPropertyName = "RemainPackagingQTYthis";
            this.RemainPackagingQTYthis.FalseValue = "0";
            this.RemainPackagingQTYthis.HeaderText = "RemainPackagingQTYthis";
            this.RemainPackagingQTYthis.Name = "RemainPackagingQTYthis";
            this.RemainPackagingQTYthis.TrueValue = "1";
            // 
            // RemainDeliveryQTYthis
            // 
            this.RemainDeliveryQTYthis.DataPropertyName = "RemainDeliveryQTYthis";
            this.RemainDeliveryQTYthis.FalseValue = "0";
            this.RemainDeliveryQTYthis.HeaderText = "RemainDeliveryQTYthis";
            this.RemainDeliveryQTYthis.Name = "RemainDeliveryQTYthis";
            this.RemainDeliveryQTYthis.TrueValue = "1";
            // 
            // RemainInvoiceQTYthis
            // 
            this.RemainInvoiceQTYthis.DataPropertyName = "RemainInvoiceQTYthis";
            this.RemainInvoiceQTYthis.FalseValue = "0";
            this.RemainInvoiceQTYthis.HeaderText = "RemainInvoiceQTYthis";
            this.RemainInvoiceQTYthis.Name = "RemainInvoiceQTYthis";
            this.RemainInvoiceQTYthis.TrueValue = "1";
            // 
            // frmPossibleSequenceTransformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 499);
            this.Controls.Add(this.buttonRemove2);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.dgvTransformationsProperties);
            this.Controls.Add(this.lblDocumentSequenceName);
            this.Controls.Add(this.lblDocumentSequenceLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPossibleSequenceTransformations);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPossibleSequenceTransformations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleSequenceTransformations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransformationsProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possibleSequenceTransformationsPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possibleSequenceTransofrmationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPossibleSequenceTransformations;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDocumentSequenceLabel;
        private System.Windows.Forms.Label lblDocumentSequenceName;
        private System.Windows.Forms.DataGridView dgvTransformationsProperties;
        private System.Windows.Forms.Button buttonRemove2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.BindingSource possibleSequenceTransofrmationBindingSource;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.BindingSource possibleSequenceTransformationsPropertiesBindingSource;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn possibleDocumentSequenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useReceiptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransactionTypeIDTo;
        private System.Windows.Forms.DataGridViewComboBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn remainQTYActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn remainProductionQTYActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn remainPackagingQTYActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn remainDeliveryQTYActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn remainInvoiceQTYActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemainQTYthis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemainProductionQTYthis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemainPackagingQTYthis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemainDeliveryQTYthis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemainInvoiceQTYthis;
    }
}