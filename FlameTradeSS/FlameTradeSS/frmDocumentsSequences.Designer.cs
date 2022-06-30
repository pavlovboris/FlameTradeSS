namespace FlameTradeSS
{
    partial class frmDocumentsSequences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentsSequences));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDocumentSequences = new System.Windows.Forms.DataGridView();
            this.sequenceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStripDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sequenceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(539, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDocumentSequences
            // 
            this.dgvDocumentSequences.AllowUserToAddRows = false;
            this.dgvDocumentSequences.AllowUserToDeleteRows = false;
            this.dgvDocumentSequences.AllowUserToOrderColumns = true;
            this.dgvDocumentSequences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentSequences.AutoGenerateColumns = false;
            this.dgvDocumentSequences.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentSequences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentSequences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentSequences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequenceNameDataGridViewTextBoxColumn,
            this.sequenceDescriptionDataGridViewTextBoxColumn,
            this.isRealDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn});
            this.dgvDocumentSequences.ContextMenuStrip = this.contextMenuStripDgv;
            this.dgvDocumentSequences.DataSource = this.documentSequencesBindingSource;
            this.dgvDocumentSequences.Location = new System.Drawing.Point(12, 65);
            this.dgvDocumentSequences.MultiSelect = false;
            this.dgvDocumentSequences.Name = "dgvDocumentSequences";
            this.dgvDocumentSequences.RowHeadersWidth = 20;
            this.dgvDocumentSequences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentSequences.Size = new System.Drawing.Size(570, 346);
            this.dgvDocumentSequences.TabIndex = 10;
            // 
            // sequenceTypeBindingSource
            // 
            this.sequenceTypeBindingSource.DataSource = typeof(FlameTradeSS.SequenceType);
            // 
            // contextMenuStripDgv
            // 
            this.contextMenuStripDgv.Name = "contextMenuStripDgv";
            this.contextMenuStripDgv.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripDgv.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripDgv_Opening);
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 417);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(98, 417);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 52);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(489, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sequenceNameDataGridViewTextBoxColumn
            // 
            this.sequenceNameDataGridViewTextBoxColumn.DataPropertyName = "SequenceName";
            this.sequenceNameDataGridViewTextBoxColumn.HeaderText = "Sequence Name";
            this.sequenceNameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.sequenceNameDataGridViewTextBoxColumn.Name = "sequenceNameDataGridViewTextBoxColumn";
            this.sequenceNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sequenceDescriptionDataGridViewTextBoxColumn
            // 
            this.sequenceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SequenceDescription";
            this.sequenceDescriptionDataGridViewTextBoxColumn.HeaderText = "SequenceDescription";
            this.sequenceDescriptionDataGridViewTextBoxColumn.MaxInputLength = 250;
            this.sequenceDescriptionDataGridViewTextBoxColumn.Name = "sequenceDescriptionDataGridViewTextBoxColumn";
            this.sequenceDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // isRealDataGridViewTextBoxColumn
            // 
            this.isRealDataGridViewTextBoxColumn.DataPropertyName = "IsReal";
            this.isRealDataGridViewTextBoxColumn.FalseValue = "0";
            this.isRealDataGridViewTextBoxColumn.HeaderText = "IsReal";
            this.isRealDataGridViewTextBoxColumn.Name = "isRealDataGridViewTextBoxColumn";
            this.isRealDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRealDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isRealDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.DataSource = this.sequenceTypeBindingSource;
            this.typeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.typeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "Sequence Type";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.typeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmDocumentsSequences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDocumentSequences);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(395, 481);
            this.Name = "frmDocumentsSequences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDocumentSequences;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource sequenceTypeBindingSource;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeIDDataGridViewTextBoxColumn;
    }
}