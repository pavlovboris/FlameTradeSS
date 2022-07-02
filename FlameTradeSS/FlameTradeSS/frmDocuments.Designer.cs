namespace FlameTradeSS
{
    partial class frmDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocuments));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentSequenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBlockedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCanceledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costingModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.costingModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricingModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStripDocument = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuAddEditFinancialPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIsCanceled = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbSequence = new System.Windows.Forms.ComboBox();
            this.documentSequencesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costingModelsBindingSource)).BeginInit();
            this.contextMenuStripDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_48;
            this.btnMinimize.Location = new System.Drawing.Point(1146, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 48);
            this.btnMinimize.TabIndex = 28;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnMaximize.Location = new System.Drawing.Point(1201, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(49, 48);
            this.btnMaximize.TabIndex = 27;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1256, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AllowUserToOrderColumns = true;
            this.dgvDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.documentSequenceIDDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.documentDateDataGridViewTextBoxColumn,
            this.partnerIDDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.incomeValueDataGridViewTextBoxColumn,
            this.expenseValueDataGridViewTextBoxColumn,
            this.isBlockedDataGridViewTextBoxColumn,
            this.isCanceledDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.costingModelIDDataGridViewTextBoxColumn,
            this.pricingModelIDDataGridViewTextBoxColumn});
            this.dgvDocuments.ContextMenuStrip = this.contextMenuStripDocument;
            this.dgvDocuments.DataSource = this.documentsBindingSource;
            this.dgvDocuments.Location = new System.Drawing.Point(12, 135);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersWidth = 5;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.Size = new System.Drawing.Size(1288, 578);
            this.dgvDocuments.TabIndex = 29;
            this.dgvDocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellDoubleClick);
            this.dgvDocuments.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDocuments_ColumnDisplayIndexChanged);
            this.dgvDocuments.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDocuments_ColumnWidthChanged);
            this.dgvDocuments.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvDocuments_Scroll);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // documentSequenceIDDataGridViewTextBoxColumn
            // 
            this.documentSequenceIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentSequenceID";
            this.documentSequenceIDDataGridViewTextBoxColumn.DataSource = this.documentSequencesBindingSource;
            this.documentSequenceIDDataGridViewTextBoxColumn.DisplayMember = "SequenceName";
            this.documentSequenceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.documentSequenceIDDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.documentSequenceIDDataGridViewTextBoxColumn.Name = "documentSequenceIDDataGridViewTextBoxColumn";
            this.documentSequenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentSequenceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentSequenceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentSequenceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            this.documentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // documentDateDataGridViewTextBoxColumn
            // 
            this.documentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.documentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.documentDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.documentDateDataGridViewTextBoxColumn.Name = "documentDateDataGridViewTextBoxColumn";
            this.documentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDateDataGridViewTextBoxColumn.Width = 50;
            // 
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource;
            this.partnerIDDataGridViewTextBoxColumn.DisplayMember = "Partner_name";
            this.partnerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "Партньор";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
            this.partnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partnerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partnerIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.partnerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментар";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // incomeValueDataGridViewTextBoxColumn
            // 
            this.incomeValueDataGridViewTextBoxColumn.DataPropertyName = "IncomeValue";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.incomeValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.incomeValueDataGridViewTextBoxColumn.HeaderText = "Приход";
            this.incomeValueDataGridViewTextBoxColumn.Name = "incomeValueDataGridViewTextBoxColumn";
            this.incomeValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseValueDataGridViewTextBoxColumn
            // 
            this.expenseValueDataGridViewTextBoxColumn.DataPropertyName = "ExpenseValue";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.expenseValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.expenseValueDataGridViewTextBoxColumn.HeaderText = "Разход";
            this.expenseValueDataGridViewTextBoxColumn.Name = "expenseValueDataGridViewTextBoxColumn";
            this.expenseValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isBlockedDataGridViewTextBoxColumn
            // 
            this.isBlockedDataGridViewTextBoxColumn.DataPropertyName = "IsBlocked";
            this.isBlockedDataGridViewTextBoxColumn.FalseValue = "0";
            this.isBlockedDataGridViewTextBoxColumn.HeaderText = "Заключен";
            this.isBlockedDataGridViewTextBoxColumn.Name = "isBlockedDataGridViewTextBoxColumn";
            this.isBlockedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isBlockedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isBlockedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isBlockedDataGridViewTextBoxColumn.TrueValue = "1";
            this.isBlockedDataGridViewTextBoxColumn.Width = 70;
            // 
            // isCanceledDataGridViewTextBoxColumn
            // 
            this.isCanceledDataGridViewTextBoxColumn.DataPropertyName = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.HeaderText = "Анулиран";
            this.isCanceledDataGridViewTextBoxColumn.Name = "isCanceledDataGridViewTextBoxColumn";
            this.isCanceledDataGridViewTextBoxColumn.ReadOnly = true;
            this.isCanceledDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isCanceledDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isCanceledDataGridViewTextBoxColumn.Width = 70;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.userIDDataGridViewTextBoxColumn.DisplayMember = "UserName";
            this.userIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "Потребител";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(FlameTradeSS.Users);
            // 
            // costingModelIDDataGridViewTextBoxColumn
            // 
            this.costingModelIDDataGridViewTextBoxColumn.DataPropertyName = "CostingModelID";
            this.costingModelIDDataGridViewTextBoxColumn.DataSource = this.costingModelsBindingSource;
            this.costingModelIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.costingModelIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.costingModelIDDataGridViewTextBoxColumn.HeaderText = "Костинг Модел";
            this.costingModelIDDataGridViewTextBoxColumn.Name = "costingModelIDDataGridViewTextBoxColumn";
            this.costingModelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costingModelIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.costingModelIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.costingModelIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.costingModelIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // costingModelsBindingSource
            // 
            this.costingModelsBindingSource.DataSource = typeof(FlameTradeSS.CostingModels);
            // 
            // pricingModelIDDataGridViewTextBoxColumn
            // 
            this.pricingModelIDDataGridViewTextBoxColumn.DataPropertyName = "PricingModelID";
            this.pricingModelIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pricingModelIDDataGridViewTextBoxColumn.HeaderText = "Ценови Модел";
            this.pricingModelIDDataGridViewTextBoxColumn.Name = "pricingModelIDDataGridViewTextBoxColumn";
            this.pricingModelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricingModelIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pricingModelIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pricingModelIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // contextMenuStripDocument
            // 
            this.contextMenuStripDocument.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAddEditFinancialPlan});
            this.contextMenuStripDocument.Name = "contextMenuStripDocument";
            this.contextMenuStripDocument.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStripDocument.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripDocument_Opening);
            this.contextMenuStripDocument.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripDocument_ItemClicked);
            // 
            // toolStripMenuAddEditFinancialPlan
            // 
            this.toolStripMenuAddEditFinancialPlan.Name = "toolStripMenuAddEditFinancialPlan";
            this.toolStripMenuAddEditFinancialPlan.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuAddEditFinancialPlan.Text = "Финансов План";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataSource = typeof(FlameTradeSS.Documents);
            // 
            // cmbIsCanceled
            // 
            this.cmbIsCanceled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsCanceled.FormattingEnabled = true;
            this.cmbIsCanceled.Items.AddRange(new object[] {
            "Не",
            "Да",
            "Всички"});
            this.cmbIsCanceled.Location = new System.Drawing.Point(882, 108);
            this.cmbIsCanceled.Name = "cmbIsCanceled";
            this.cmbIsCanceled.Size = new System.Drawing.Size(70, 21);
            this.cmbIsCanceled.TabIndex = 30;
            this.cmbIsCanceled.SelectedIndexChanged += new System.EventHandler(this.cmbIsCanceled_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 66);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(594, 20);
            this.txtFilter.TabIndex = 31;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cmbSequence
            // 
            this.cmbSequence.DataSource = this.documentSequencesBindingSource1;
            this.cmbSequence.DisplayMember = "SequenceName";
            this.cmbSequence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSequence.FormattingEnabled = true;
            this.cmbSequence.Location = new System.Drawing.Point(67, 108);
            this.cmbSequence.Name = "cmbSequence";
            this.cmbSequence.Size = new System.Drawing.Size(95, 21);
            this.cmbSequence.TabIndex = 32;
            this.cmbSequence.ValueMember = "ID";
            this.cmbSequence.SelectedIndexChanged += new System.EventHandler(this.cmbSequence_SelectedIndexChanged);
            // 
            // documentSequencesBindingSource1
            // 
            this.documentSequencesBindingSource1.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // frmDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 725);
            this.Controls.Add(this.cmbSequence);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbIsCanceled);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocuments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocuments_FormClosing);
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            this.SizeChanged += new System.EventHandler(this.frmDocuments_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costingModelsBindingSource)).EndInit();
            this.contextMenuStripDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource costingModelsBindingSource;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.ComboBox cmbIsCanceled;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn documentSequenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBlockedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCanceledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn costingModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pricingModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbSequence;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDocument;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddEditFinancialPlan;
    }
}