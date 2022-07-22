namespace FlameTradeSS
{
    partial class frmReceiptModels
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
            this.dgvReceiptModels = new System.Windows.Forms.DataGridView();
            this.HasGeneralItems = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.contextMenuModel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuModelParameters = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isItemDirectRelatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.receiptModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptModels)).BeginInit();
            this.contextMenuModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceiptModels
            // 
            this.dgvReceiptModels.AllowUserToAddRows = false;
            this.dgvReceiptModels.AllowUserToDeleteRows = false;
            this.dgvReceiptModels.AllowUserToOrderColumns = true;
            this.dgvReceiptModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceiptModels.AutoGenerateColumns = false;
            this.dgvReceiptModels.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceiptModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelNameDataGridViewTextBoxColumn,
            this.HasGeneralItems,
            this.modelDescriptionDataGridViewTextBoxColumn,
            this.isItemDirectRelatedDataGridViewTextBoxColumn,
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn,
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn,
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn});
            this.dgvReceiptModels.ContextMenuStrip = this.contextMenuModel;
            this.dgvReceiptModels.DataSource = this.receiptModelsBindingSource;
            this.dgvReceiptModels.Location = new System.Drawing.Point(12, 82);
            this.dgvReceiptModels.MultiSelect = false;
            this.dgvReceiptModels.Name = "dgvReceiptModels";
            this.dgvReceiptModels.RowHeadersWidth = 20;
            this.dgvReceiptModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptModels.Size = new System.Drawing.Size(1125, 514);
            this.dgvReceiptModels.TabIndex = 9;
            this.dgvReceiptModels.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartners_CellMouseDown);
            // 
            // HasGeneralItems
            // 
            this.HasGeneralItems.DataPropertyName = "HasGeneralItems";
            this.HasGeneralItems.FalseValue = "0";
            this.HasGeneralItems.HeaderText = "Has Genera lItems";
            this.HasGeneralItems.Name = "HasGeneralItems";
            this.HasGeneralItems.TrueValue = "1";
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
            // contextMenuModel
            // 
            this.contextMenuModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuModelParameters});
            this.contextMenuModel.Name = "contextMenuModel";
            this.contextMenuModel.Size = new System.Drawing.Size(213, 26);
            this.contextMenuModel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuModel_ItemClicked);
            // 
            // toolStripMenuModelParameters
            // 
            this.toolStripMenuModelParameters.Name = "toolStripMenuModelParameters";
            this.toolStripMenuModelParameters.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuModelParameters.Text = "Receipt Model Parameters";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1044, 596);
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1094, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 49);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model Name";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // modelDescriptionDataGridViewTextBoxColumn
            // 
            this.modelDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ModelDescription";
            this.modelDescriptionDataGridViewTextBoxColumn.HeaderText = "Model Description";
            this.modelDescriptionDataGridViewTextBoxColumn.Name = "modelDescriptionDataGridViewTextBoxColumn";
            this.modelDescriptionDataGridViewTextBoxColumn.Width = 120;
            // 
            // isItemDirectRelatedDataGridViewTextBoxColumn
            // 
            this.isItemDirectRelatedDataGridViewTextBoxColumn.DataPropertyName = "IsItemDirectRelated";
            this.isItemDirectRelatedDataGridViewTextBoxColumn.FalseValue = "0";
            this.isItemDirectRelatedDataGridViewTextBoxColumn.HeaderText = "IsItem Direct Related";
            this.isItemDirectRelatedDataGridViewTextBoxColumn.Name = "isItemDirectRelatedDataGridViewTextBoxColumn";
            this.isItemDirectRelatedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isItemDirectRelatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isItemDirectRelatedDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // isPartitionDIrectRelatedDataGridViewTextBoxColumn
            // 
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.DataPropertyName = "IsPartitionDIrectRelated";
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.FalseValue = "0";
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.HeaderText = "IsPartition Direct Related";
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.Name = "isPartitionDIrectRelatedDataGridViewTextBoxColumn";
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.TrueValue = "1";
            this.isPartitionDIrectRelatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // isSecondPartitionDirectRelatedDataGridViewTextBoxColumn
            // 
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.DataPropertyName = "IsSecondPartitionDirectRelated";
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.FalseValue = "0";
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.HeaderText = "IsSecond Partition Direct Related";
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.Name = "isSecondPartitionDirectRelatedDataGridViewTextBoxColumn";
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.TrueValue = "1";
            this.isSecondPartitionDirectRelatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // isSurfaceDirectRelatedDataGridViewTextBoxColumn
            // 
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.DataPropertyName = "IsSurfaceDirectRelated";
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.FalseValue = "0";
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.HeaderText = "IsSurface Direct Related";
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.Name = "isSurfaceDirectRelatedDataGridViewTextBoxColumn";
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isSurfaceDirectRelatedDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // receiptModelsBindingSource
            // 
            this.receiptModelsBindingSource.DataSource = typeof(FlameTradeSS.ReceiptModels);
            // 
            // frmReceiptModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 660);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvReceiptModels);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceiptModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartners";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartners_FormClosing);
            this.Load += new System.EventHandler(this.frmPartners_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartners_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptModels)).EndInit();
            this.contextMenuModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvReceiptModels;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.BindingSource receiptModelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasGeneralItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isItemDirectRelatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPartitionDIrectRelatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSecondPartitionDirectRelatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSurfaceDirectRelatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuModel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModelParameters;
    }
}