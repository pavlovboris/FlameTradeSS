namespace FlameTradeSS
{
    partial class frmFinancialColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialColors));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvFinancialPlanColor = new System.Windows.Forms.DataGridView();
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialPlanColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialPlanColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlanColorsBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(243, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(293, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvFinancialPlanColor
            // 
            this.dgvFinancialPlanColor.AllowUserToAddRows = false;
            this.dgvFinancialPlanColor.AllowUserToDeleteRows = false;
            this.dgvFinancialPlanColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinancialPlanColor.AutoGenerateColumns = false;
            this.dgvFinancialPlanColor.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinancialPlanColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinancialPlanColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancialPlanColor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionTypeIDDataGridViewTextBoxColumn,
            this.financialColorDataGridViewTextBoxColumn});
            this.dgvFinancialPlanColor.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFinancialPlanColor.DataSource = this.financialPlanColorsBindingSource;
            this.dgvFinancialPlanColor.Location = new System.Drawing.Point(13, 65);
            this.dgvFinancialPlanColor.Name = "dgvFinancialPlanColor";
            this.dgvFinancialPlanColor.RowHeadersWidth = 20;
            this.dgvFinancialPlanColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinancialPlanColor.Size = new System.Drawing.Size(323, 333);
            this.dgvFinancialPlanColor.TabIndex = 0;
            this.dgvFinancialPlanColor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinancialPlanColor_CellClick);
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.DataSource = this.transactionsTypeBindingSource;
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transactionTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.transactionTypeIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // financialColorDataGridViewTextBoxColumn
            // 
            this.financialColorDataGridViewTextBoxColumn.DataPropertyName = "FinancialColor";
            this.financialColorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.financialColorDataGridViewTextBoxColumn.Name = "financialColorDataGridViewTextBoxColumn";
            this.financialColorDataGridViewTextBoxColumn.ReadOnly = true;
            this.financialColorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // financialPlanColorsBindingSource
            // 
            this.financialPlanColorsBindingSource.DataSource = typeof(FlameTradeSS.FinancialPlanColors);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuEdit.Text = "Редактирай";
            // 
            // frmFinancialColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 468);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvFinancialPlanColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancialColors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restrictions";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFunctions_FormClosing);
            this.Load += new System.EventHandler(this.frmFunctions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFunctions_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialPlanColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlanColorsBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFinancialPlanColor;
        private System.Windows.Forms.BindingSource financialPlanColorsBindingSource;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn financialColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
    }
}