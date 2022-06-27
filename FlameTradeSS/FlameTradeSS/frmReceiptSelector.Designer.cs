namespace FlameTradeSS
{
    partial class frmReceiptSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptSelector));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btmProjectAdd = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(639, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvReceipts
            // 
            this.dgvReceipts.AllowUserToAddRows = false;
            this.dgvReceipts.AllowUserToDeleteRows = false;
            this.dgvReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceipts.AutoGenerateColumns = false;
            this.dgvReceipts.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.ItemIDDataGridViewComboBoxColumn});
            this.dgvReceipts.DataSource = this.transactionReceiptBindingSource;
            this.dgvReceipts.Location = new System.Drawing.Point(12, 92);
            this.dgvReceipts.MultiSelect = false;
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.ReadOnly = true;
            this.dgvReceipts.RowHeadersWidth = 20;
            this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipts.Size = new System.Drawing.Size(671, 228);
            this.dgvReceipts.TabIndex = 13;
            this.dgvReceipts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellDoubleClick);
            this.dgvReceipts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProjects_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(13, 61);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(670, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // btmProjectAdd
            // 
            this.btmProjectAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmProjectAdd.BackColor = System.Drawing.Color.White;
            this.btmProjectAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmProjectAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmProjectAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btmProjectAdd.Location = new System.Drawing.Point(13, 7);
            this.btmProjectAdd.Name = "btmProjectAdd";
            this.btmProjectAdd.Size = new System.Drawing.Size(49, 53);
            this.btmProjectAdd.TabIndex = 15;
            this.btmProjectAdd.UseVisualStyleBackColor = false;
            this.btmProjectAdd.Click += new System.EventHandler(this.btmProjectAdd_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // transactionReceiptBindingSource
            // 
            this.transactionReceiptBindingSource.DataSource = typeof(FlameTradeSS.TransactionReceipt);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.DataSource = this.itemsBindingSource;
            this.itemIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item Code";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.itemIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ItemIDDataGridViewComboBoxColumn
            // 
            this.ItemIDDataGridViewComboBoxColumn.DataPropertyName = "ItemID";
            this.ItemIDDataGridViewComboBoxColumn.DataSource = this.itemsBindingSource;
            this.ItemIDDataGridViewComboBoxColumn.DisplayMember = "Description";
            this.ItemIDDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemIDDataGridViewComboBoxColumn.HeaderText = "Item Description";
            this.ItemIDDataGridViewComboBoxColumn.Name = "ItemIDDataGridViewComboBoxColumn";
            this.ItemIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.ItemIDDataGridViewComboBoxColumn.ValueMember = "ID";
            this.ItemIDDataGridViewComboBoxColumn.Width = 200;
            // 
            // frmReceiptSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 332);
            this.Controls.Add(this.btmProjectAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvReceipts);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReceiptSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProjectSelector";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProjectSelector_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmProjectSelector_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.DataGridView dgvReceipts;
        private System.Windows.Forms.Button btmProjectAdd;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource transactionReceiptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemIDDataGridViewComboBoxColumn;
    }
}