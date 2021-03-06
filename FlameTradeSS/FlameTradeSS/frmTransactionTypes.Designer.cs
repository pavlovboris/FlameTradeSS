namespace FlameTradeSS
{
    partial class frmTransactionTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionTypes));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTransactionTypes = new System.Windows.Forms.DataGridView();
            this.linesTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingEntriesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionMultiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DefaultSurfaceTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DefaultReceiptModelID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DefaultAccountingEntryModelID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingEntriesModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(850, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTransactionTypes
            // 
            this.dgvTransactionTypes.AllowUserToAddRows = false;
            this.dgvTransactionTypes.AllowUserToDeleteRows = false;
            this.dgvTransactionTypes.AllowUserToOrderColumns = true;
            this.dgvTransactionTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactionTypes.AutoGenerateColumns = false;
            this.dgvTransactionTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactionTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeNameDataGridViewTextBoxColumn,
            this.transactionMultiplierDataGridViewTextBoxColumn,
            this.linesRelationDataGridViewTextBoxColumn,
            this.DefaultSurfaceTypeID,
            this.DefaultReceiptModelID,
            this.DefaultAccountingEntryModelID,
            this.Abbreviation});
            this.dgvTransactionTypes.DataSource = this.transactionsTypeBindingSource;
            this.dgvTransactionTypes.Location = new System.Drawing.Point(12, 65);
            this.dgvTransactionTypes.Name = "dgvTransactionTypes";
            this.dgvTransactionTypes.RowHeadersWidth = 20;
            this.dgvTransactionTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionTypes.Size = new System.Drawing.Size(881, 346);
            this.dgvTransactionTypes.TabIndex = 10;
            // 
            // linesTypeBindingSource
            // 
            this.linesTypeBindingSource.DataSource = typeof(FlameTradeSS.LinesType);
            // 
            // surfaceTypesBindingSource
            // 
            this.surfaceTypesBindingSource.DataSource = typeof(FlameTradeSS.SurfaceTypes);
            // 
            // receiptModelsBindingSource
            // 
            this.receiptModelsBindingSource.DataSource = typeof(FlameTradeSS.ReceiptModels);
            // 
            // accountingEntriesModelBindingSource
            // 
            this.accountingEntriesModelBindingSource.DataSource = typeof(FlameTradeSS.AccountingEntriesModel);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 417);
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
            this.btnRemove.Location = new System.Drawing.Point(98, 417);
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
            this.btnSave.Location = new System.Drawing.Point(800, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Type Name";
            this.typeNameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // transactionMultiplierDataGridViewTextBoxColumn
            // 
            this.transactionMultiplierDataGridViewTextBoxColumn.DataPropertyName = "TransactionMultiplier";
            this.transactionMultiplierDataGridViewTextBoxColumn.HeaderText = "Transaction Multiplier";
            this.transactionMultiplierDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.transactionMultiplierDataGridViewTextBoxColumn.Name = "transactionMultiplierDataGridViewTextBoxColumn";
            this.transactionMultiplierDataGridViewTextBoxColumn.Width = 156;
            // 
            // linesRelationDataGridViewTextBoxColumn
            // 
            this.linesRelationDataGridViewTextBoxColumn.DataPropertyName = "LinesRelation";
            this.linesRelationDataGridViewTextBoxColumn.DataSource = this.linesTypeBindingSource;
            this.linesRelationDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.linesRelationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.linesRelationDataGridViewTextBoxColumn.HeaderText = "Lines Type";
            this.linesRelationDataGridViewTextBoxColumn.Name = "linesRelationDataGridViewTextBoxColumn";
            this.linesRelationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linesRelationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linesRelationDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // DefaultSurfaceTypeID
            // 
            this.DefaultSurfaceTypeID.DataPropertyName = "DefaultSurfaceTypeID";
            this.DefaultSurfaceTypeID.DataSource = this.surfaceTypesBindingSource;
            this.DefaultSurfaceTypeID.DisplayMember = "TypeName";
            this.DefaultSurfaceTypeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.DefaultSurfaceTypeID.HeaderText = "Default Surface Type";
            this.DefaultSurfaceTypeID.Name = "DefaultSurfaceTypeID";
            this.DefaultSurfaceTypeID.ValueMember = "ID";
            this.DefaultSurfaceTypeID.Width = 150;
            // 
            // DefaultReceiptModelID
            // 
            this.DefaultReceiptModelID.DataPropertyName = "DefaultReceiptModelID";
            this.DefaultReceiptModelID.DataSource = this.receiptModelsBindingSource;
            this.DefaultReceiptModelID.DisplayMember = "ModelName";
            this.DefaultReceiptModelID.HeaderText = "DefaultReceiptModelID";
            this.DefaultReceiptModelID.Name = "DefaultReceiptModelID";
            this.DefaultReceiptModelID.ValueMember = "ID";
            // 
            // DefaultAccountingEntryModelID
            // 
            this.DefaultAccountingEntryModelID.DataPropertyName = "DefaultAccountingEntryModelID";
            this.DefaultAccountingEntryModelID.DataSource = this.accountingEntriesModelBindingSource;
            this.DefaultAccountingEntryModelID.DisplayMember = "EntryName";
            this.DefaultAccountingEntryModelID.HeaderText = "DefaultAccountingEntryModelID";
            this.DefaultAccountingEntryModelID.Name = "DefaultAccountingEntryModelID";
            this.DefaultAccountingEntryModelID.ValueMember = "ID";
            this.DefaultAccountingEntryModelID.Width = 150;
            // 
            // Abbreviation
            // 
            this.Abbreviation.DataPropertyName = "Abbreviation";
            this.Abbreviation.HeaderText = "Abbreviation";
            this.Abbreviation.Name = "Abbreviation";
            // 
            // frmTransactionTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTransactionTypes);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(656, 481);
            this.Name = "frmTransactionTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingEntriesModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTransactionTypes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource linesTypeBindingSource;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.BindingSource surfaceTypesBindingSource;
        private System.Windows.Forms.BindingSource receiptModelsBindingSource;
        private System.Windows.Forms.BindingSource accountingEntriesModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionMultiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn linesRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefaultSurfaceTypeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefaultReceiptModelID;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefaultAccountingEntryModelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abbreviation;
    }
}