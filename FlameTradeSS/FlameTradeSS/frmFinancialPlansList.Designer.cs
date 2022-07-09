namespace FlameTradeSS
{
    partial class frmFinancialPlansList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialPlansList));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvFinancialPlans = new System.Windows.Forms.DataGridView();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentOfferValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBudgetValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentRealValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuGraphicalFinancialPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDgvFinancialPlan = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlansBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(732, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvFinancialPlans
            // 
            this.dgvFinancialPlans.AllowUserToAddRows = false;
            this.dgvFinancialPlans.AllowUserToDeleteRows = false;
            this.dgvFinancialPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinancialPlans.AutoGenerateColumns = false;
            this.dgvFinancialPlans.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinancialPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinancialPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancialPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.contractNumberDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.currentOfferValueDataGridViewTextBoxColumn,
            this.currentBudgetValueDataGridViewTextBoxColumn,
            this.currentRealValueDataGridViewTextBoxColumn});
            this.dgvFinancialPlans.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFinancialPlans.DataSource = this.financialPlansBindingSource;
            this.dgvFinancialPlans.Location = new System.Drawing.Point(13, 65);
            this.dgvFinancialPlans.MultiSelect = false;
            this.dgvFinancialPlans.Name = "dgvFinancialPlans";
            this.dgvFinancialPlans.ReadOnly = true;
            this.dgvFinancialPlans.RowHeadersWidth = 20;
            this.dgvFinancialPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinancialPlans.Size = new System.Drawing.Size(762, 271);
            this.dgvFinancialPlans.TabIndex = 0;
            this.dgvFinancialPlans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinancialPlanColor_CellDoubleClick);
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.DataSource = this.projectBindingSource;
            this.projectIDDataGridViewTextBoxColumn.DisplayMember = "ProjectName";
            this.projectIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "Проект";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.projectIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.projectIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(FlameTradeSS.Project);
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractNumberDataGridViewTextBoxColumn
            // 
            this.contractNumberDataGridViewTextBoxColumn.DataPropertyName = "ContractNumber";
            this.contractNumberDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.contractNumberDataGridViewTextBoxColumn.Name = "contractNumberDataGridViewTextBoxColumn";
            this.contractNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментар";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentOfferValueDataGridViewTextBoxColumn
            // 
            this.currentOfferValueDataGridViewTextBoxColumn.DataPropertyName = "CurrentOfferValue";
            this.currentOfferValueDataGridViewTextBoxColumn.HeaderText = "Оферирана Ст-ст";
            this.currentOfferValueDataGridViewTextBoxColumn.Name = "currentOfferValueDataGridViewTextBoxColumn";
            this.currentOfferValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentOfferValueDataGridViewTextBoxColumn.Width = 120;
            // 
            // currentBudgetValueDataGridViewTextBoxColumn
            // 
            this.currentBudgetValueDataGridViewTextBoxColumn.DataPropertyName = "CurrentBudgetValue";
            this.currentBudgetValueDataGridViewTextBoxColumn.HeaderText = "Бюджетна Ст-ст";
            this.currentBudgetValueDataGridViewTextBoxColumn.Name = "currentBudgetValueDataGridViewTextBoxColumn";
            this.currentBudgetValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentBudgetValueDataGridViewTextBoxColumn.Width = 120;
            // 
            // currentRealValueDataGridViewTextBoxColumn
            // 
            this.currentRealValueDataGridViewTextBoxColumn.DataPropertyName = "CurrentRealValue";
            this.currentRealValueDataGridViewTextBoxColumn.HeaderText = "Реална Ст-ст";
            this.currentRealValueDataGridViewTextBoxColumn.Name = "currentRealValueDataGridViewTextBoxColumn";
            this.currentRealValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // financialPlansBindingSource
            // 
            this.financialPlansBindingSource.DataSource = typeof(FlameTradeSS.FinancialPlans);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuGraphicalFinancialPlan,
            this.toolStripMenuDgvFinancialPlan});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuGraphicalFinancialPlan
            // 
            this.toolStripMenuGraphicalFinancialPlan.Name = "toolStripMenuGraphicalFinancialPlan";
            this.toolStripMenuGraphicalFinancialPlan.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuGraphicalFinancialPlan.Text = "Отвори с графичен изглед";
            // 
            // toolStripMenuDgvFinancialPlan
            // 
            this.toolStripMenuDgvFinancialPlan.Name = "toolStripMenuDgvFinancialPlan";
            this.toolStripMenuDgvFinancialPlan.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuDgvFinancialPlan.Text = "Отвори с табличен изглед";
            // 
            // frmFinancialPlansList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 348);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFinancialPlans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancialPlansList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restrictions";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFunctions_FormClosing);
            this.Load += new System.EventHandler(this.frmFunctions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFunctions_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlansBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFinancialPlans;
        private System.Windows.Forms.BindingSource financialPlansBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentOfferValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBudgetValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentRealValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuGraphicalFinancialPlan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDgvFinancialPlan;
    }
}