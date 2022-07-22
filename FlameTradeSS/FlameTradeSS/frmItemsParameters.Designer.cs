namespace FlameTradeSS
{
    partial class frmItemsParameters
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
            this.dgvItemsParameters = new System.Windows.Forms.DataGridView();
            this.contextMenuDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.itemsParametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parameterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsParametersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(398, 6);
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
            this.btnSave.Location = new System.Drawing.Point(348, 407);
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
            this.btnRemove.Location = new System.Drawing.Point(98, 407);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvItemsParameters
            // 
            this.dgvItemsParameters.AllowUserToAddRows = false;
            this.dgvItemsParameters.AllowUserToDeleteRows = false;
            this.dgvItemsParameters.AllowUserToOrderColumns = true;
            this.dgvItemsParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemsParameters.AutoGenerateColumns = false;
            this.dgvItemsParameters.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemsParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemsParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterCodeDataGridViewTextBoxColumn,
            this.parameterNameDataGridViewTextBoxColumn});
            this.dgvItemsParameters.ContextMenuStrip = this.contextMenuDgv;
            this.dgvItemsParameters.DataSource = this.itemsParametersBindingSource;
            this.dgvItemsParameters.Location = new System.Drawing.Point(12, 82);
            this.dgvItemsParameters.MultiSelect = false;
            this.dgvItemsParameters.Name = "dgvItemsParameters";
            this.dgvItemsParameters.RowHeadersWidth = 20;
            this.dgvItemsParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsParameters.Size = new System.Drawing.Size(429, 325);
            this.dgvItemsParameters.TabIndex = 9;
            this.dgvItemsParameters.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartners_CellMouseDown);
            // 
            // contextMenuDgv
            // 
            this.contextMenuDgv.Name = "contextMenuDgv";
            this.contextMenuDgv.Size = new System.Drawing.Size(61, 4);
            this.contextMenuDgv.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuDgv_Closing);
            this.contextMenuDgv.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDgv_Opening);
            this.contextMenuDgv.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuDgv_ItemClicked);
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
            // itemsParametersBindingSource
            // 
            this.itemsParametersBindingSource.DataSource = typeof(FlameTradeSS.ItemsParameters);
            // 
            // parameterCodeDataGridViewTextBoxColumn
            // 
            this.parameterCodeDataGridViewTextBoxColumn.DataPropertyName = "ParameterCode";
            this.parameterCodeDataGridViewTextBoxColumn.HeaderText = "ParameterCode";
            this.parameterCodeDataGridViewTextBoxColumn.Name = "parameterCodeDataGridViewTextBoxColumn";
            this.parameterCodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // parameterNameDataGridViewTextBoxColumn
            // 
            this.parameterNameDataGridViewTextBoxColumn.DataPropertyName = "ParameterName";
            this.parameterNameDataGridViewTextBoxColumn.HeaderText = "ParameterName";
            this.parameterNameDataGridViewTextBoxColumn.Name = "parameterNameDataGridViewTextBoxColumn";
            this.parameterNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmItemsParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 471);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvItemsParameters);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemsParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartners";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartners_FormClosing);
            this.Load += new System.EventHandler(this.frmPartners_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartners_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsParametersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvItemsParameters;
        private System.Windows.Forms.ContextMenuStrip contextMenuDgv;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsParametersBindingSource;
    }
}