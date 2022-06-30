namespace FlameTradeSS
{
    partial class frmDocumentSequencesProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentSequencesProperties));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDocumentSequenceProperties = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDocumentSequenceLabel = new System.Windows.Forms.Label();
            this.lblDocumentSequenceName = new System.Windows.Forms.Label();
            this.dgvDocumentSequenceProperties2 = new System.Windows.Forms.DataGridView();
            this.buttonRemove2 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.dgvFieldsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.documentSequencesPropertiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentSequencesPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFieldsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TransactonTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inVisibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.readOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.disabledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvFieldsIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inVisibleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.readOnlyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequenceProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequenceProperties2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesPropertiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesPropertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1161, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDocumentSequenceProperties
            // 
            this.dgvDocumentSequenceProperties.AllowUserToAddRows = false;
            this.dgvDocumentSequenceProperties.AllowUserToDeleteRows = false;
            this.dgvDocumentSequenceProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentSequenceProperties.AutoGenerateColumns = false;
            this.dgvDocumentSequenceProperties.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentSequenceProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentSequenceProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentSequenceProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFieldsIDDataGridViewTextBoxColumn,
            this.TransactonTypeID,
            this.inVisibleDataGridViewTextBoxColumn,
            this.readOnlyDataGridViewTextBoxColumn,
            this.disabledDataGridViewTextBoxColumn});
            this.dgvDocumentSequenceProperties.DataSource = this.documentSequencesPropertiesBindingSource;
            this.dgvDocumentSequenceProperties.Location = new System.Drawing.Point(12, 65);
            this.dgvDocumentSequenceProperties.Name = "dgvDocumentSequenceProperties";
            this.dgvDocumentSequenceProperties.RowHeadersWidth = 20;
            this.dgvDocumentSequenceProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentSequenceProperties.Size = new System.Drawing.Size(669, 796);
            this.dgvDocumentSequenceProperties.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 867);
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
            this.btnRemove.Location = new System.Drawing.Point(98, 867);
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
            this.btnSave.Location = new System.Drawing.Point(1111, 867);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDocumentSequenceLabel
            // 
            this.lblDocumentSequenceLabel.AutoSize = true;
            this.lblDocumentSequenceLabel.Location = new System.Drawing.Point(12, 26);
            this.lblDocumentSequenceLabel.Name = "lblDocumentSequenceLabel";
            this.lblDocumentSequenceLabel.Size = new System.Drawing.Size(105, 13);
            this.lblDocumentSequenceLabel.TabIndex = 14;
            this.lblDocumentSequenceLabel.Text = "DocumentSequence";
            // 
            // lblDocumentSequenceName
            // 
            this.lblDocumentSequenceName.AutoSize = true;
            this.lblDocumentSequenceName.Location = new System.Drawing.Point(13, 43);
            this.lblDocumentSequenceName.Name = "lblDocumentSequenceName";
            this.lblDocumentSequenceName.Size = new System.Drawing.Size(13, 13);
            this.lblDocumentSequenceName.TabIndex = 15;
            this.lblDocumentSequenceName.Text = "?";
            // 
            // dgvDocumentSequenceProperties2
            // 
            this.dgvDocumentSequenceProperties2.AllowUserToAddRows = false;
            this.dgvDocumentSequenceProperties2.AllowUserToDeleteRows = false;
            this.dgvDocumentSequenceProperties2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentSequenceProperties2.AutoGenerateColumns = false;
            this.dgvDocumentSequenceProperties2.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentSequenceProperties2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentSequenceProperties2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentSequenceProperties2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFieldsIDDataGridViewTextBoxColumn1,
            this.inVisibleDataGridViewTextBoxColumn1,
            this.readOnlyDataGridViewTextBoxColumn1});
            this.dgvDocumentSequenceProperties2.DataSource = this.documentSequencesPropertiesBindingSource1;
            this.dgvDocumentSequenceProperties2.Location = new System.Drawing.Point(700, 65);
            this.dgvDocumentSequenceProperties2.Name = "dgvDocumentSequenceProperties2";
            this.dgvDocumentSequenceProperties2.RowHeadersWidth = 20;
            this.dgvDocumentSequenceProperties2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentSequenceProperties2.Size = new System.Drawing.Size(504, 796);
            this.dgvDocumentSequenceProperties2.TabIndex = 16;
            // 
            // buttonRemove2
            // 
            this.buttonRemove2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove2.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRemove2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove2.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.buttonRemove2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove2.Location = new System.Drawing.Point(786, 867);
            this.buttonRemove2.Name = "buttonRemove2";
            this.buttonRemove2.Size = new System.Drawing.Size(100, 52);
            this.buttonRemove2.TabIndex = 18;
            this.buttonRemove2.Text = "Remove";
            this.buttonRemove2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove2.UseVisualStyleBackColor = true;
            this.buttonRemove2.Click += new System.EventHandler(this.buttonRemove2_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd2.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdd2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd2.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.buttonAdd2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd2.Location = new System.Drawing.Point(700, 867);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(80, 52);
            this.buttonAdd2.TabIndex = 17;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // dgvFieldsBindingSource1
            // 
            this.dgvFieldsBindingSource1.DataSource = typeof(FlameTradeSS.DgvFields);
            // 
            // documentSequencesPropertiesBindingSource1
            // 
            this.documentSequencesPropertiesBindingSource1.DataSource = typeof(FlameTradeSS.DocumentSequencesProperties);
            // 
            // dgvFieldsBindingSource
            // 
            this.dgvFieldsBindingSource.DataSource = typeof(FlameTradeSS.DgvFields);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // documentSequencesPropertiesBindingSource
            // 
            this.documentSequencesPropertiesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequencesProperties);
            // 
            // dgvFieldsIDDataGridViewTextBoxColumn
            // 
            this.dgvFieldsIDDataGridViewTextBoxColumn.DataPropertyName = "DgvFieldsID";
            this.dgvFieldsIDDataGridViewTextBoxColumn.DataSource = this.dgvFieldsBindingSource;
            this.dgvFieldsIDDataGridViewTextBoxColumn.DisplayMember = "FieldName";
            this.dgvFieldsIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgvFieldsIDDataGridViewTextBoxColumn.HeaderText = "DocumentTransactionLinesColumns";
            this.dgvFieldsIDDataGridViewTextBoxColumn.Name = "dgvFieldsIDDataGridViewTextBoxColumn";
            this.dgvFieldsIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFieldsIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvFieldsIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.dgvFieldsIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // TransactonTypeID
            // 
            this.TransactonTypeID.DataPropertyName = "TransactonTypeID";
            this.TransactonTypeID.DataSource = this.transactionsTypeBindingSource;
            this.TransactonTypeID.DisplayMember = "TypeName";
            this.TransactonTypeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TransactonTypeID.HeaderText = "Transacton Type";
            this.TransactonTypeID.Name = "TransactonTypeID";
            this.TransactonTypeID.ValueMember = "ID";
            // 
            // inVisibleDataGridViewTextBoxColumn
            // 
            this.inVisibleDataGridViewTextBoxColumn.DataPropertyName = "InVisible";
            this.inVisibleDataGridViewTextBoxColumn.FalseValue = "0";
            this.inVisibleDataGridViewTextBoxColumn.HeaderText = "InVisible";
            this.inVisibleDataGridViewTextBoxColumn.Name = "inVisibleDataGridViewTextBoxColumn";
            this.inVisibleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inVisibleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inVisibleDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // readOnlyDataGridViewTextBoxColumn
            // 
            this.readOnlyDataGridViewTextBoxColumn.DataPropertyName = "ReadOnly";
            this.readOnlyDataGridViewTextBoxColumn.FalseValue = "0";
            this.readOnlyDataGridViewTextBoxColumn.HeaderText = "ReadOnly";
            this.readOnlyDataGridViewTextBoxColumn.Name = "readOnlyDataGridViewTextBoxColumn";
            this.readOnlyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.readOnlyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.readOnlyDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // disabledDataGridViewTextBoxColumn
            // 
            this.disabledDataGridViewTextBoxColumn.DataPropertyName = "Disabled";
            this.disabledDataGridViewTextBoxColumn.FalseValue = "0";
            this.disabledDataGridViewTextBoxColumn.HeaderText = "Disabled";
            this.disabledDataGridViewTextBoxColumn.Name = "disabledDataGridViewTextBoxColumn";
            this.disabledDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.disabledDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.disabledDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // dgvFieldsIDDataGridViewTextBoxColumn1
            // 
            this.dgvFieldsIDDataGridViewTextBoxColumn1.DataPropertyName = "DgvFieldsID";
            this.dgvFieldsIDDataGridViewTextBoxColumn1.DataSource = this.dgvFieldsBindingSource1;
            this.dgvFieldsIDDataGridViewTextBoxColumn1.DisplayMember = "FieldName";
            this.dgvFieldsIDDataGridViewTextBoxColumn1.HeaderText = "DocumentTransactionColumns";
            this.dgvFieldsIDDataGridViewTextBoxColumn1.Name = "dgvFieldsIDDataGridViewTextBoxColumn1";
            this.dgvFieldsIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFieldsIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvFieldsIDDataGridViewTextBoxColumn1.ValueMember = "ID";
            this.dgvFieldsIDDataGridViewTextBoxColumn1.Width = 300;
            // 
            // inVisibleDataGridViewTextBoxColumn1
            // 
            this.inVisibleDataGridViewTextBoxColumn1.DataPropertyName = "InVisible";
            this.inVisibleDataGridViewTextBoxColumn1.FalseValue = "0";
            this.inVisibleDataGridViewTextBoxColumn1.HeaderText = "InVisible";
            this.inVisibleDataGridViewTextBoxColumn1.Name = "inVisibleDataGridViewTextBoxColumn1";
            this.inVisibleDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inVisibleDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inVisibleDataGridViewTextBoxColumn1.TrueValue = "1";
            // 
            // readOnlyDataGridViewTextBoxColumn1
            // 
            this.readOnlyDataGridViewTextBoxColumn1.DataPropertyName = "ReadOnly";
            this.readOnlyDataGridViewTextBoxColumn1.FalseValue = "0";
            this.readOnlyDataGridViewTextBoxColumn1.HeaderText = "ReadOnly";
            this.readOnlyDataGridViewTextBoxColumn1.Name = "readOnlyDataGridViewTextBoxColumn1";
            this.readOnlyDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.readOnlyDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.readOnlyDataGridViewTextBoxColumn1.TrueValue = "1";
            // 
            // frmDocumentSequencesProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 931);
            this.Controls.Add(this.buttonRemove2);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.dgvDocumentSequenceProperties2);
            this.Controls.Add(this.lblDocumentSequenceName);
            this.Controls.Add(this.lblDocumentSequenceLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDocumentSequenceProperties);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDocumentSequencesProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequenceProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequenceProperties2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesPropertiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesPropertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDocumentSequenceProperties;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource dgvFieldsBindingSource;
        private System.Windows.Forms.BindingSource documentSequencesPropertiesBindingSource;
        private System.Windows.Forms.Label lblDocumentSequenceLabel;
        private System.Windows.Forms.Label lblDocumentSequenceName;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.DataGridView dgvDocumentSequenceProperties2;
        private System.Windows.Forms.BindingSource documentSequencesPropertiesBindingSource1;
        private System.Windows.Forms.Button buttonRemove2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.BindingSource dgvFieldsBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvFieldsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransactonTypeID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inVisibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn readOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disabledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvFieldsIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inVisibleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn readOnlyDataGridViewTextBoxColumn1;
    }
}