namespace FlameTradeSS
{
    partial class frmCreateFromTransactionOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateFromTransactionOptions));
            this.lbTransactionlbl = new System.Windows.Forms.Label();
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentTransactionLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRight = new System.Windows.Forms.DataGridView();
            this.newTransactionLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.checkedListBoxPartitions = new System.Windows.Forms.CheckedListBox();
            this.documentTransactionsbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.muIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partitionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkBoxSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.surfaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTransactionLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTransactionLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTransactionlbl
            // 
            this.lbTransactionlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTransactionlbl.AutoSize = true;
            this.lbTransactionlbl.Location = new System.Drawing.Point(14, 30);
            this.lbTransactionlbl.Name = "lbTransactionlbl";
            this.lbTransactionlbl.Size = new System.Drawing.Size(77, 13);
            this.lbTransactionlbl.TabIndex = 1;
            this.lbTransactionlbl.Text = "Транзакция : ";
            // 
            // dgvLeft
            // 
            this.dgvLeft.AllowUserToAddRows = false;
            this.dgvLeft.AllowUserToDeleteRows = false;
            this.dgvLeft.AutoGenerateColumns = false;
            this.dgvLeft.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChkBoxSelected,
            this.itemIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.muIDDataGridViewTextBoxColumn,
            this.partitionIDDataGridViewTextBoxColumn,
            this.surfaceIDDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvLeft.DataSource = this.currentTransactionLinesBindingSource;
            this.dgvLeft.Location = new System.Drawing.Point(12, 59);
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.RowHeadersWidth = 5;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeft.Size = new System.Drawing.Size(627, 387);
            this.dgvLeft.TabIndex = 2;
            this.dgvLeft.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeft_CellContentClick);
            this.dgvLeft.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLeft_CellFormatting);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // muBindingSource
            // 
            this.muBindingSource.DataSource = typeof(FlameTradeSS.Mu);
            // 
            // partitionsBindingSource
            // 
            this.partitionsBindingSource.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // currentTransactionLinesBindingSource
            // 
            this.currentTransactionLinesBindingSource.DataSource = typeof(FlameTradeSS.TransactionLines);
            // 
            // dgvRight
            // 
            this.dgvRight.AllowUserToAddRows = false;
            this.dgvRight.AllowUserToDeleteRows = false;
            this.dgvRight.AutoGenerateColumns = false;
            this.dgvRight.BackgroundColor = System.Drawing.Color.White;
            this.dgvRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn1,
            this.muIDDataGridViewTextBoxColumn1,
            this.partitionIDDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn1,
            this.surfaceIDDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn1});
            this.dgvRight.DataSource = this.newTransactionLinesBindingSource;
            this.dgvRight.Location = new System.Drawing.Point(759, 59);
            this.dgvRight.Name = "dgvRight";
            this.dgvRight.RowHeadersWidth = 5;
            this.dgvRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRight.Size = new System.Drawing.Size(630, 387);
            this.dgvRight.TabIndex = 3;
            this.dgvRight.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRight_CellValueChanged);
            // 
            // newTransactionLinesBindingSource
            // 
            this.newTransactionLinesBindingSource.DataSource = typeof(FlameTradeSS.TransactionLines);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(87, 31);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(13, 13);
            this.lblTransactionType.TabIndex = 7;
            this.lblTransactionType.Text = "?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(1276, 446);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 52);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Потвърди";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1347, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_056_Icon_64;
            this.btnMoveLeft.Location = new System.Drawing.Point(657, 284);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 66);
            this.btnMoveLeft.TabIndex = 5;
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_055_Icon_64;
            this.btnMoveRight.Location = new System.Drawing.Point(657, 211);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 67);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // checkedListBoxPartitions
            // 
            this.checkedListBoxPartitions.FormattingEnabled = true;
            this.checkedListBoxPartitions.Location = new System.Drawing.Point(645, 6);
            this.checkedListBoxPartitions.Name = "checkedListBoxPartitions";
            this.checkedListBoxPartitions.Size = new System.Drawing.Size(101, 169);
            this.checkedListBoxPartitions.TabIndex = 15;
            // 
            // documentTransactionsbindingSource
            // 
            this.documentTransactionsbindingSource.DataSource = typeof(FlameTradeSS.DocumentTransactions);
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            this.itemIDDataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn1.DataSource = this.itemsBindingSource;
            this.itemIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.itemIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIDDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            this.itemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIDDataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // muIDDataGridViewTextBoxColumn1
            // 
            this.muIDDataGridViewTextBoxColumn1.DataPropertyName = "MuID";
            this.muIDDataGridViewTextBoxColumn1.DataSource = this.muBindingSource;
            this.muIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.muIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.muIDDataGridViewTextBoxColumn1.HeaderText = "МЕ";
            this.muIDDataGridViewTextBoxColumn1.Name = "muIDDataGridViewTextBoxColumn1";
            this.muIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.muIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.muIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.muIDDataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // partitionIDDataGridViewTextBoxColumn1
            // 
            this.partitionIDDataGridViewTextBoxColumn1.DataPropertyName = "PartitionID";
            this.partitionIDDataGridViewTextBoxColumn1.DataSource = this.partitionsBindingSource;
            this.partitionIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.partitionIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partitionIDDataGridViewTextBoxColumn1.HeaderText = "Партида";
            this.partitionIDDataGridViewTextBoxColumn1.Name = "partitionIDDataGridViewTextBoxColumn1";
            this.partitionIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.partitionIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partitionIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partitionIDDataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "К-ВО";
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            // 
            // surfaceIDDataGridViewTextBoxColumn1
            // 
            this.surfaceIDDataGridViewTextBoxColumn1.DataPropertyName = "SurfaceID";
            this.surfaceIDDataGridViewTextBoxColumn1.DataSource = this.surfacesBindingSource;
            this.surfaceIDDataGridViewTextBoxColumn1.DisplayMember = "SurfaceCode";
            this.surfaceIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.surfaceIDDataGridViewTextBoxColumn1.HeaderText = "Повърхност";
            this.surfaceIDDataGridViewTextBoxColumn1.Name = "surfaceIDDataGridViewTextBoxColumn1";
            this.surfaceIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.surfaceIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surfaceIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.surfaceIDDataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Коментар";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ChkBoxSelected
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "False";
            this.ChkBoxSelected.DefaultCellStyle = dataGridViewCellStyle1;
            this.ChkBoxSelected.FalseValue = "0";
            this.ChkBoxSelected.HeaderText = "Избран";
            this.ChkBoxSelected.Name = "ChkBoxSelected";
            this.ChkBoxSelected.TrueValue = "1";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.DataSource = this.itemsBindingSource;
            this.itemIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Код";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "К-ВО";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // muIDDataGridViewTextBoxColumn
            // 
            this.muIDDataGridViewTextBoxColumn.DataPropertyName = "MuID";
            this.muIDDataGridViewTextBoxColumn.DataSource = this.muBindingSource;
            this.muIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.muIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.muIDDataGridViewTextBoxColumn.HeaderText = "МЕ";
            this.muIDDataGridViewTextBoxColumn.Name = "muIDDataGridViewTextBoxColumn";
            this.muIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.muIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.muIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.muIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // partitionIDDataGridViewTextBoxColumn
            // 
            this.partitionIDDataGridViewTextBoxColumn.DataPropertyName = "PartitionID";
            this.partitionIDDataGridViewTextBoxColumn.DataSource = this.partitionsBindingSource;
            this.partitionIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.partitionIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partitionIDDataGridViewTextBoxColumn.HeaderText = "Партида";
            this.partitionIDDataGridViewTextBoxColumn.Name = "partitionIDDataGridViewTextBoxColumn";
            this.partitionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partitionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partitionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partitionIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // surfaceIDDataGridViewTextBoxColumn
            // 
            this.surfaceIDDataGridViewTextBoxColumn.DataPropertyName = "SurfaceID";
            this.surfaceIDDataGridViewTextBoxColumn.DataSource = this.surfacesBindingSource;
            this.surfaceIDDataGridViewTextBoxColumn.DisplayMember = "SurfaceName";
            this.surfaceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.surfaceIDDataGridViewTextBoxColumn.HeaderText = "Повърхност";
            this.surfaceIDDataGridViewTextBoxColumn.Name = "surfaceIDDataGridViewTextBoxColumn";
            this.surfaceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surfaceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.surfaceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментар";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCreateFromTransactionOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1401, 510);
            this.Controls.Add(this.checkedListBoxPartitions);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvRight);
            this.Controls.Add(this.dgvLeft);
            this.Controls.Add(this.lbTransactionlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateFromTransactionOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles Restrictions";
            this.Load += new System.EventHandler(this.frmRolesFunctions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmRolesFunctions_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTransactionLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTransactionLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTransactionlbl;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.DataGridView dgvRight;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.BindingSource currentTransactionLinesBindingSource;
        private System.Windows.Forms.BindingSource newTransactionLinesBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource muBindingSource;
        private System.Windows.Forms.BindingSource partitionsBindingSource;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        public System.Windows.Forms.BindingSource documentTransactionsbindingSource;
        private System.Windows.Forms.CheckedListBox checkedListBoxPartitions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkBoxSelected;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn muIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn surfaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn muIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn partitionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn surfaceIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
    }
}