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
            this.dgvFieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentSequencesPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFieldsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TransactonTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inVisibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.readOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.disabledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentSequenceProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(641, 6);
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
            this.dgvDocumentSequenceProperties.Size = new System.Drawing.Size(672, 412);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 483);
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
            this.btnRemove.Location = new System.Drawing.Point(98, 483);
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
            this.btnSave.Location = new System.Drawing.Point(591, 483);
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
            // dgvFieldsBindingSource
            // 
            this.dgvFieldsBindingSource.DataSource = typeof(FlameTradeSS.DgvFields);
            // 
            // documentSequencesPropertiesBindingSource
            // 
            this.documentSequencesPropertiesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequencesProperties);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // dgvFieldsIDDataGridViewTextBoxColumn
            // 
            this.dgvFieldsIDDataGridViewTextBoxColumn.DataPropertyName = "DgvFieldsID";
            this.dgvFieldsIDDataGridViewTextBoxColumn.DataSource = this.dgvFieldsBindingSource;
            this.dgvFieldsIDDataGridViewTextBoxColumn.DisplayMember = "FieldName";
            this.dgvFieldsIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgvFieldsIDDataGridViewTextBoxColumn.HeaderText = "DocumentTransactionColumns";
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
            // frmDocumentSequencesProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 547);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvFieldsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransactonTypeID;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inVisibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn readOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disabledDataGridViewTextBoxColumn;
    }
}