namespace FlameTradeSS
{
    partial class frmAccountingModels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountingModels));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvAccountingModels = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAccountingModel = new System.Windows.Forms.Label();
            this.lblAccountingModelName = new System.Windows.Forms.Label();
            this.dgvModelsDetails = new System.Windows.Forms.DataGridView();
            this.buttonRemove2 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.accountingEntriesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountingEntriesModelDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.debitAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.creditAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.percentOfValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vATPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountingModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingEntriesModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingEntriesModelDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(954, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAccountingModels
            // 
            this.dgvAccountingModels.AllowUserToAddRows = false;
            this.dgvAccountingModels.AllowUserToDeleteRows = false;
            this.dgvAccountingModels.AutoGenerateColumns = false;
            this.dgvAccountingModels.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountingModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccountingModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountingModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryNameDataGridViewTextBoxColumn});
            this.dgvAccountingModels.DataSource = this.accountingEntriesModelBindingSource;
            this.dgvAccountingModels.Location = new System.Drawing.Point(12, 65);
            this.dgvAccountingModels.MultiSelect = false;
            this.dgvAccountingModels.Name = "dgvAccountingModels";
            this.dgvAccountingModels.RowHeadersWidth = 20;
            this.dgvAccountingModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountingModels.Size = new System.Drawing.Size(331, 364);
            this.dgvAccountingModels.TabIndex = 10;
            this.dgvAccountingModels.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPossibleSequenceTransformations_CellValueChanged);
            this.dgvAccountingModels.CurrentCellChanged += new System.EventHandler(this.dgvPossibleSequenceTransformations_CurrentCellChanged);
            this.dgvAccountingModels.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPossibleSequenceTransformations_CurrentCellDirtyStateChanged);
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
            this.btnSave.Location = new System.Drawing.Point(904, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAccountingModel
            // 
            this.lblAccountingModel.AutoSize = true;
            this.lblAccountingModel.Location = new System.Drawing.Point(12, 26);
            this.lblAccountingModel.Name = "lblAccountingModel";
            this.lblAccountingModel.Size = new System.Drawing.Size(93, 13);
            this.lblAccountingModel.TabIndex = 14;
            this.lblAccountingModel.Text = "Accounting Model";
            // 
            // lblAccountingModelName
            // 
            this.lblAccountingModelName.AutoSize = true;
            this.lblAccountingModelName.Location = new System.Drawing.Point(13, 43);
            this.lblAccountingModelName.Name = "lblAccountingModelName";
            this.lblAccountingModelName.Size = new System.Drawing.Size(13, 13);
            this.lblAccountingModelName.TabIndex = 15;
            this.lblAccountingModelName.Text = "?";
            // 
            // dgvModelsDetails
            // 
            this.dgvModelsDetails.AllowUserToAddRows = false;
            this.dgvModelsDetails.AllowUserToDeleteRows = false;
            this.dgvModelsDetails.AutoGenerateColumns = false;
            this.dgvModelsDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvModelsDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModelsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.debitAccountIDDataGridViewTextBoxColumn,
            this.creditAccountIDDataGridViewTextBoxColumn,
            this.percentOfValueDataGridViewTextBoxColumn,
            this.vATAccountIDDataGridViewTextBoxColumn,
            this.vATPercentDataGridViewTextBoxColumn,
            this.vatTypeDataGridViewTextBoxColumn});
            this.dgvModelsDetails.DataSource = this.accountingEntriesModelDetailsBindingSource;
            this.dgvModelsDetails.Location = new System.Drawing.Point(349, 65);
            this.dgvModelsDetails.Name = "dgvModelsDetails";
            this.dgvModelsDetails.RowHeadersWidth = 20;
            this.dgvModelsDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelsDetails.Size = new System.Drawing.Size(642, 364);
            this.dgvModelsDetails.TabIndex = 16;
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
            // accountingEntriesModelBindingSource
            // 
            this.accountingEntriesModelBindingSource.DataSource = typeof(FlameTradeSS.AccountingEntriesModel);
            // 
            // entryNameDataGridViewTextBoxColumn
            // 
            this.entryNameDataGridViewTextBoxColumn.DataPropertyName = "EntryName";
            this.entryNameDataGridViewTextBoxColumn.HeaderText = "Model Name";
            this.entryNameDataGridViewTextBoxColumn.Name = "entryNameDataGridViewTextBoxColumn";
            this.entryNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // accountingEntriesModelDetailsBindingSource
            // 
            this.accountingEntriesModelDetailsBindingSource.DataSource = typeof(FlameTradeSS.AccountingEntriesModelDetails);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(FlameTradeSS.Accounts);
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataSource = typeof(FlameTradeSS.Accounts);
            // 
            // accountsBindingSource2
            // 
            this.accountsBindingSource2.DataSource = typeof(FlameTradeSS.Accounts);
            // 
            // debitAccountIDDataGridViewTextBoxColumn
            // 
            this.debitAccountIDDataGridViewTextBoxColumn.DataPropertyName = "DebitAccountID";
            this.debitAccountIDDataGridViewTextBoxColumn.DataSource = this.accountsBindingSource;
            this.debitAccountIDDataGridViewTextBoxColumn.DisplayMember = "AccountCode";
            this.debitAccountIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.debitAccountIDDataGridViewTextBoxColumn.HeaderText = "Debit Account";
            this.debitAccountIDDataGridViewTextBoxColumn.Name = "debitAccountIDDataGridViewTextBoxColumn";
            this.debitAccountIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debitAccountIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.debitAccountIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // creditAccountIDDataGridViewTextBoxColumn
            // 
            this.creditAccountIDDataGridViewTextBoxColumn.DataPropertyName = "CreditAccountID";
            this.creditAccountIDDataGridViewTextBoxColumn.DataSource = this.accountsBindingSource1;
            this.creditAccountIDDataGridViewTextBoxColumn.DisplayMember = "AccountCode";
            this.creditAccountIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.creditAccountIDDataGridViewTextBoxColumn.HeaderText = "Credit Account";
            this.creditAccountIDDataGridViewTextBoxColumn.Name = "creditAccountIDDataGridViewTextBoxColumn";
            this.creditAccountIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creditAccountIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.creditAccountIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // percentOfValueDataGridViewTextBoxColumn
            // 
            this.percentOfValueDataGridViewTextBoxColumn.DataPropertyName = "PercentOfValue";
            this.percentOfValueDataGridViewTextBoxColumn.HeaderText = "PercentOfValue";
            this.percentOfValueDataGridViewTextBoxColumn.Name = "percentOfValueDataGridViewTextBoxColumn";
            // 
            // vATAccountIDDataGridViewTextBoxColumn
            // 
            this.vATAccountIDDataGridViewTextBoxColumn.DataPropertyName = "VATAccountID";
            this.vATAccountIDDataGridViewTextBoxColumn.DataSource = this.accountsBindingSource2;
            this.vATAccountIDDataGridViewTextBoxColumn.DisplayMember = "AccountCode";
            this.vATAccountIDDataGridViewTextBoxColumn.HeaderText = "VAT Account";
            this.vATAccountIDDataGridViewTextBoxColumn.Name = "vATAccountIDDataGridViewTextBoxColumn";
            this.vATAccountIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vATAccountIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vATAccountIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // vATPercentDataGridViewTextBoxColumn
            // 
            this.vATPercentDataGridViewTextBoxColumn.DataPropertyName = "VATPercent";
            this.vATPercentDataGridViewTextBoxColumn.HeaderText = "VATPercent";
            this.vATPercentDataGridViewTextBoxColumn.Name = "vATPercentDataGridViewTextBoxColumn";
            // 
            // vatTypeDataGridViewTextBoxColumn
            // 
            this.vatTypeDataGridViewTextBoxColumn.DataPropertyName = "VatType";
            this.vatTypeDataGridViewTextBoxColumn.HeaderText = "VatType";
            this.vatTypeDataGridViewTextBoxColumn.Name = "vatTypeDataGridViewTextBoxColumn";
            // 
            // frmAccountingModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 499);
            this.Controls.Add(this.buttonRemove2);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.dgvModelsDetails);
            this.Controls.Add(this.lblAccountingModelName);
            this.Controls.Add(this.lblAccountingModel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAccountingModels);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountingModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountingModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingEntriesModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingEntriesModelDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAccountingModels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAccountingModel;
        private System.Windows.Forms.Label lblAccountingModelName;
        private System.Windows.Forms.DataGridView dgvModelsDetails;
        private System.Windows.Forms.Button buttonRemove2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountingEntriesModelBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn debitAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn creditAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vATAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountingEntriesModelDetailsBindingSource;
    }
}