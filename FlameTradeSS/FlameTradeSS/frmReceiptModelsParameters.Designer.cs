namespace FlameTradeSS
{
    partial class frmReceiptModelsParameters
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
            this.dgvReceiptModelsParameters = new System.Windows.Forms.DataGridView();
            this.itemsParameterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsParametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.receiptModelsItemsParametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptModelsParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsParametersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsItemsParametersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(270, 6);
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
            this.btnSave.Location = new System.Drawing.Point(220, 367);
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
            this.btnRemove.Location = new System.Drawing.Point(98, 367);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvReceiptModelsParameters
            // 
            this.dgvReceiptModelsParameters.AllowUserToAddRows = false;
            this.dgvReceiptModelsParameters.AllowUserToDeleteRows = false;
            this.dgvReceiptModelsParameters.AllowUserToOrderColumns = true;
            this.dgvReceiptModelsParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceiptModelsParameters.AutoGenerateColumns = false;
            this.dgvReceiptModelsParameters.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptModelsParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceiptModelsParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptModelsParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemsParameterIDDataGridViewTextBoxColumn});
            this.dgvReceiptModelsParameters.ContextMenuStrip = this.contextMenuDgv;
            this.dgvReceiptModelsParameters.DataSource = this.receiptModelsItemsParametersBindingSource;
            this.dgvReceiptModelsParameters.Location = new System.Drawing.Point(12, 82);
            this.dgvReceiptModelsParameters.MultiSelect = false;
            this.dgvReceiptModelsParameters.Name = "dgvReceiptModelsParameters";
            this.dgvReceiptModelsParameters.RowHeadersWidth = 20;
            this.dgvReceiptModelsParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptModelsParameters.Size = new System.Drawing.Size(301, 285);
            this.dgvReceiptModelsParameters.TabIndex = 9;
            this.dgvReceiptModelsParameters.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartners_CellMouseDown);
            // 
            // itemsParameterIDDataGridViewTextBoxColumn
            // 
            this.itemsParameterIDDataGridViewTextBoxColumn.DataPropertyName = "ItemsParameterID";
            this.itemsParameterIDDataGridViewTextBoxColumn.DataSource = this.itemsParametersBindingSource;
            this.itemsParameterIDDataGridViewTextBoxColumn.DisplayMember = "ParameterCode";
            this.itemsParameterIDDataGridViewTextBoxColumn.HeaderText = "Items Parameter";
            this.itemsParameterIDDataGridViewTextBoxColumn.Name = "itemsParameterIDDataGridViewTextBoxColumn";
            this.itemsParameterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsParameterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemsParameterIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.itemsParameterIDDataGridViewTextBoxColumn.Width = 300;
            // 
            // itemsParametersBindingSource
            // 
            this.itemsParametersBindingSource.DataSource = typeof(FlameTradeSS.ItemsParameters);
            // 
            // contextMenuDgv
            // 
            this.contextMenuDgv.Name = "contextMenuDgv";
            this.contextMenuDgv.Size = new System.Drawing.Size(181, 26);
            this.contextMenuDgv.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuDgv_Closing);
            this.contextMenuDgv.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDgv_Opening);
            this.contextMenuDgv.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuDgv_ItemClicked);
            // 
            // receiptModelsItemsParametersBindingSource
            // 
            this.receiptModelsItemsParametersBindingSource.DataSource = typeof(FlameTradeSS.ReceiptModelsItemsParameters);
            // 
            // frmReceiptModelsParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 431);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvReceiptModelsParameters);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceiptModelsParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartners";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartners_FormClosing);
            this.Load += new System.EventHandler(this.frmPartners_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartners_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptModelsParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsParametersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsItemsParametersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvReceiptModelsParameters;
        private System.Windows.Forms.ContextMenuStrip contextMenuDgv;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsParameterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsParametersBindingSource;
        private System.Windows.Forms.BindingSource receiptModelsItemsParametersBindingSource;
    }
}