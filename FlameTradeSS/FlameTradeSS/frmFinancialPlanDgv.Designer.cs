namespace FlameTradeSS
{
    partial class frmFinancialPlanDgv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialPlanDgv));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvFinancialPlansLines = new System.Windows.Forms.DataGridView();
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialPlanLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.financialGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.offerValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialPlansLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlanLinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(692, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvFinancialPlansLines
            // 
            this.dgvFinancialPlansLines.AllowUserToAddRows = false;
            this.dgvFinancialPlansLines.AllowUserToDeleteRows = false;
            this.dgvFinancialPlansLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinancialPlansLines.AutoGenerateColumns = false;
            this.dgvFinancialPlansLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinancialPlansLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinancialPlansLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancialPlansLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionTypeIDDataGridViewTextBoxColumn,
            this.financialGroupIDDataGridViewTextBoxColumn,
            this.offerValueDataGridViewTextBoxColumn,
            this.budgetValueDataGridViewTextBoxColumn,
            this.realValueDataGridViewTextBoxColumn,
            this.profitPercentDataGridViewTextBoxColumn});
            this.dgvFinancialPlansLines.DataSource = this.financialPlanLinesBindingSource;
            this.dgvFinancialPlansLines.Location = new System.Drawing.Point(13, 65);
            this.dgvFinancialPlansLines.MultiSelect = false;
            this.dgvFinancialPlansLines.Name = "dgvFinancialPlansLines";
            this.dgvFinancialPlansLines.ReadOnly = true;
            this.dgvFinancialPlansLines.RowHeadersWidth = 20;
            this.dgvFinancialPlansLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinancialPlansLines.Size = new System.Drawing.Size(722, 575);
            this.dgvFinancialPlansLines.TabIndex = 0;
            this.dgvFinancialPlansLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinancialPlanColor_CellDoubleClick);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // financialCategoriesBindingSource
            // 
            this.financialCategoriesBindingSource.DataSource = typeof(FlameTradeSS.FinancialCategories);
            // 
            // financialPlanLinesBindingSource
            // 
            this.financialPlanLinesBindingSource.DataSource = typeof(FlameTradeSS.FinancialPlanLines);
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.DataSource = this.transactionsTypeBindingSource;
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "Група";
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transactionTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.transactionTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // financialGroupIDDataGridViewTextBoxColumn
            // 
            this.financialGroupIDDataGridViewTextBoxColumn.DataPropertyName = "FinancialGroupID";
            this.financialGroupIDDataGridViewTextBoxColumn.DataSource = this.financialCategoriesBindingSource;
            this.financialGroupIDDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            this.financialGroupIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.financialGroupIDDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.financialGroupIDDataGridViewTextBoxColumn.Name = "financialGroupIDDataGridViewTextBoxColumn";
            this.financialGroupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.financialGroupIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.financialGroupIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.financialGroupIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.financialGroupIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // offerValueDataGridViewTextBoxColumn
            // 
            this.offerValueDataGridViewTextBoxColumn.DataPropertyName = "OfferValue";
            this.offerValueDataGridViewTextBoxColumn.HeaderText = "OfferValue";
            this.offerValueDataGridViewTextBoxColumn.Name = "offerValueDataGridViewTextBoxColumn";
            this.offerValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetValueDataGridViewTextBoxColumn
            // 
            this.budgetValueDataGridViewTextBoxColumn.DataPropertyName = "BudgetValue";
            this.budgetValueDataGridViewTextBoxColumn.HeaderText = "BudgetValue";
            this.budgetValueDataGridViewTextBoxColumn.Name = "budgetValueDataGridViewTextBoxColumn";
            this.budgetValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realValueDataGridViewTextBoxColumn
            // 
            this.realValueDataGridViewTextBoxColumn.DataPropertyName = "RealValue";
            this.realValueDataGridViewTextBoxColumn.HeaderText = "RealValue";
            this.realValueDataGridViewTextBoxColumn.Name = "realValueDataGridViewTextBoxColumn";
            this.realValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profitPercentDataGridViewTextBoxColumn
            // 
            this.profitPercentDataGridViewTextBoxColumn.DataPropertyName = "ProfitPercent";
            this.profitPercentDataGridViewTextBoxColumn.HeaderText = "ProfitPercent";
            this.profitPercentDataGridViewTextBoxColumn.Name = "profitPercentDataGridViewTextBoxColumn";
            this.profitPercentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmFinancialPlanDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 652);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFinancialPlansLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancialPlanDgv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restrictions";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFunctions_FormClosing);
            this.Load += new System.EventHandler(this.frmFunctions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFunctions_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialPlansLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlanLinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFinancialPlansLines;
        private System.Windows.Forms.BindingSource financialPlanLinesBindingSource;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.BindingSource financialCategoriesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn financialGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitPercentDataGridViewTextBoxColumn;
    }
}