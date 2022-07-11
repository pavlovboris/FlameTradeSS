namespace FlameTradeSS
{
    partial class frmEditItemsReceipt
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvReceiptLines = new System.Windows.Forms.DataGridView();
            this.receiptLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsParametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemColorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPartitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.secondPartitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.surfaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsParameterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblTransactionReceiptlbl = new System.Windows.Forms.Label();
            this.lblTransactionReceiptName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsParametersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(717, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 49);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(667, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(98, 596);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 52);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 596);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvReceiptLines
            // 
            this.dgvReceiptLines.AllowUserToAddRows = false;
            this.dgvReceiptLines.AllowUserToDeleteRows = false;
            this.dgvReceiptLines.AllowUserToOrderColumns = true;
            this.dgvReceiptLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceiptLines.AutoGenerateColumns = false;
            this.dgvReceiptLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceiptLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemColorIDDataGridViewTextBoxColumn,
            this.itemQTYDataGridViewTextBoxColumn,
            this.itemPartitionIDDataGridViewTextBoxColumn,
            this.secondPartitionIDDataGridViewTextBoxColumn,
            this.surfaceIDDataGridViewTextBoxColumn,
            this.itemsParameterIDDataGridViewTextBoxColumn});
            this.dgvReceiptLines.DataSource = this.receiptLinesBindingSource;
            this.dgvReceiptLines.Location = new System.Drawing.Point(12, 82);
            this.dgvReceiptLines.MultiSelect = false;
            this.dgvReceiptLines.Name = "dgvReceiptLines";
            this.dgvReceiptLines.RowHeadersWidth = 20;
            this.dgvReceiptLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptLines.Size = new System.Drawing.Size(748, 514);
            this.dgvReceiptLines.TabIndex = 9;
            this.dgvReceiptLines.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartners_CellMouseDown);
            // 
            // receiptLinesBindingSource
            // 
            this.receiptLinesBindingSource.DataSource = typeof(FlameTradeSS.ReceiptLines);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(13, 56);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(35, 13);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Location = new System.Drawing.Point(54, 56);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(381, 13);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataSource = typeof(FlameTradeSS.Colors);
            // 
            // partitionsBindingSource
            // 
            this.partitionsBindingSource.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // partitionsBindingSource1
            // 
            this.partitionsBindingSource1.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // itemsParametersBindingSource
            // 
            this.itemsParametersBindingSource.DataSource = typeof(FlameTradeSS.ItemsParameters);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.DataSource = this.itemsBindingSource;
            this.itemIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Код";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // itemColorIDDataGridViewTextBoxColumn
            // 
            this.itemColorIDDataGridViewTextBoxColumn.DataPropertyName = "ItemColorID";
            this.itemColorIDDataGridViewTextBoxColumn.DataSource = this.colorsBindingSource;
            this.itemColorIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemColorIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.itemColorIDDataGridViewTextBoxColumn.HeaderText = "Цвят";
            this.itemColorIDDataGridViewTextBoxColumn.Name = "itemColorIDDataGridViewTextBoxColumn";
            this.itemColorIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemColorIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemColorIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // itemQTYDataGridViewTextBoxColumn
            // 
            this.itemQTYDataGridViewTextBoxColumn.DataPropertyName = "ItemQTY";
            this.itemQTYDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.itemQTYDataGridViewTextBoxColumn.Name = "itemQTYDataGridViewTextBoxColumn";
            // 
            // itemPartitionIDDataGridViewTextBoxColumn
            // 
            this.itemPartitionIDDataGridViewTextBoxColumn.DataPropertyName = "ItemPartitionID";
            this.itemPartitionIDDataGridViewTextBoxColumn.DataSource = this.partitionsBindingSource;
            this.itemPartitionIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.itemPartitionIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.itemPartitionIDDataGridViewTextBoxColumn.HeaderText = "Партида";
            this.itemPartitionIDDataGridViewTextBoxColumn.Name = "itemPartitionIDDataGridViewTextBoxColumn";
            this.itemPartitionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemPartitionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemPartitionIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // secondPartitionIDDataGridViewTextBoxColumn
            // 
            this.secondPartitionIDDataGridViewTextBoxColumn.DataPropertyName = "SecondPartitionID";
            this.secondPartitionIDDataGridViewTextBoxColumn.DataSource = this.partitionsBindingSource1;
            this.secondPartitionIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.secondPartitionIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.secondPartitionIDDataGridViewTextBoxColumn.HeaderText = "Втора Партида";
            this.secondPartitionIDDataGridViewTextBoxColumn.Name = "secondPartitionIDDataGridViewTextBoxColumn";
            this.secondPartitionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secondPartitionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secondPartitionIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.secondPartitionIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // surfaceIDDataGridViewTextBoxColumn
            // 
            this.surfaceIDDataGridViewTextBoxColumn.DataPropertyName = "SurfaceID";
            this.surfaceIDDataGridViewTextBoxColumn.DataSource = this.surfacesBindingSource;
            this.surfaceIDDataGridViewTextBoxColumn.DisplayMember = "SurfaceCode";
            this.surfaceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.surfaceIDDataGridViewTextBoxColumn.HeaderText = "Повърхност";
            this.surfaceIDDataGridViewTextBoxColumn.Name = "surfaceIDDataGridViewTextBoxColumn";
            this.surfaceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surfaceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.surfaceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // itemsParameterIDDataGridViewTextBoxColumn
            // 
            this.itemsParameterIDDataGridViewTextBoxColumn.DataPropertyName = "ItemsParameterID";
            this.itemsParameterIDDataGridViewTextBoxColumn.DataSource = this.itemsParametersBindingSource;
            this.itemsParameterIDDataGridViewTextBoxColumn.DisplayMember = "ParameterCode";
            this.itemsParameterIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.itemsParameterIDDataGridViewTextBoxColumn.HeaderText = "Параметър";
            this.itemsParameterIDDataGridViewTextBoxColumn.Name = "itemsParameterIDDataGridViewTextBoxColumn";
            this.itemsParameterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsParameterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemsParameterIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // lblTransactionReceiptlbl
            // 
            this.lblTransactionReceiptlbl.AutoSize = true;
            this.lblTransactionReceiptlbl.Location = new System.Drawing.Point(13, 13);
            this.lblTransactionReceiptlbl.Name = "lblTransactionReceiptlbl";
            this.lblTransactionReceiptlbl.Size = new System.Drawing.Size(108, 13);
            this.lblTransactionReceiptlbl.TabIndex = 15;
            this.lblTransactionReceiptlbl.Text = "Име на рецептата : ";
            // 
            // lblTransactionReceiptName
            // 
            this.lblTransactionReceiptName.AutoSize = true;
            this.lblTransactionReceiptName.Location = new System.Drawing.Point(120, 13);
            this.lblTransactionReceiptName.Name = "lblTransactionReceiptName";
            this.lblTransactionReceiptName.Size = new System.Drawing.Size(13, 13);
            this.lblTransactionReceiptName.TabIndex = 16;
            this.lblTransactionReceiptName.Text = "?";
            // 
            // frmEditItemsReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 660);
            this.Controls.Add(this.lblTransactionReceiptName);
            this.Controls.Add(this.lblTransactionReceiptlbl);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvReceiptLines);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditItemsReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartners";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartners_FormClosing);
            this.Load += new System.EventHandler(this.frmPartners_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartners_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsParametersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvReceiptLines;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.BindingSource receiptLinesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemColorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemPartitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partitionsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn secondPartitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partitionsBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn surfaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsParameterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsParametersBindingSource;
        private System.Windows.Forms.Label lblTransactionReceiptlbl;
        private System.Windows.Forms.Label lblTransactionReceiptName;
    }
}