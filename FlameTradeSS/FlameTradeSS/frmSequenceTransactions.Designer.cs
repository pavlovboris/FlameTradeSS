namespace FlameTradeSS
{
    partial class frmSequenceTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSequenceTransactions));
            this.btnClose = new System.Windows.Forms.Button();
            this.lvlSequence = new System.Windows.Forms.Label();
            this.cmbDocumentSequence = new System.Windows.Forms.ComboBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvRight = new System.Windows.Forms.DataGridView();
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linesTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionMultiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sequencesTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequencesTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(749, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 51);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvlSequence
            // 
            this.lvlSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlSequence.AutoSize = true;
            this.lvlSequence.Location = new System.Drawing.Point(457, 30);
            this.lvlSequence.Name = "lvlSequence";
            this.lvlSequence.Size = new System.Drawing.Size(56, 13);
            this.lvlSequence.TabIndex = 9;
            this.lvlSequence.Text = "Sequence";
            // 
            // cmbDocumentSequence
            // 
            this.cmbDocumentSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDocumentSequence.DataSource = this.documentSequencesBindingSource;
            this.cmbDocumentSequence.DisplayMember = "SequenceName";
            this.cmbDocumentSequence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDocumentSequence.FormattingEnabled = true;
            this.cmbDocumentSequence.Location = new System.Drawing.Point(519, 27);
            this.cmbDocumentSequence.Name = "cmbDocumentSequence";
            this.cmbDocumentSequence.Size = new System.Drawing.Size(224, 21);
            this.cmbDocumentSequence.TabIndex = 8;
            this.cmbDocumentSequence.ValueMember = "ID";
            this.cmbDocumentSequence.SelectionChangeCommitted += new System.EventHandler(this.cmbPerson_SelectionChangeCommitted);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_056_Icon_64;
            this.btnMoveLeft.Location = new System.Drawing.Point(437, 251);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(63, 68);
            this.btnMoveLeft.TabIndex = 13;
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_055_Icon_64;
            this.btnMoveRight.Location = new System.Drawing.Point(437, 169);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(63, 71);
            this.btnMoveRight.TabIndex = 12;
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
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
            this.transactionTypeIDDataGridViewTextBoxColumn});
            this.dgvRight.DataSource = this.sequencesTransactionsBindingSource;
            this.dgvRight.Location = new System.Drawing.Point(516, 62);
            this.dgvRight.Name = "dgvRight";
            this.dgvRight.ReadOnly = true;
            this.dgvRight.RowHeadersWidth = 20;
            this.dgvRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRight.Size = new System.Drawing.Size(273, 414);
            this.dgvRight.TabIndex = 11;
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
            this.typeNameDataGridViewTextBoxColumn,
            this.transactionMultiplierDataGridViewTextBoxColumn,
            this.linesRelationDataGridViewTextBoxColumn});
            this.dgvLeft.DataSource = this.transactionsTypeBindingSource;
            this.dgvLeft.Location = new System.Drawing.Point(12, 62);
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.ReadOnly = true;
            this.dgvLeft.RowHeadersWidth = 20;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeft.Size = new System.Drawing.Size(397, 414);
            this.dgvLeft.TabIndex = 10;
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // linesTypeBindingSource
            // 
            this.linesTypeBindingSource.DataSource = typeof(FlameTradeSS.LinesType);
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // transactionMultiplierDataGridViewTextBoxColumn
            // 
            this.transactionMultiplierDataGridViewTextBoxColumn.DataPropertyName = "TransactionMultiplier";
            this.transactionMultiplierDataGridViewTextBoxColumn.HeaderText = "Transaction Multiplier";
            this.transactionMultiplierDataGridViewTextBoxColumn.Name = "transactionMultiplierDataGridViewTextBoxColumn";
            this.transactionMultiplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionMultiplierDataGridViewTextBoxColumn.Width = 150;
            // 
            // linesRelationDataGridViewTextBoxColumn
            // 
            this.linesRelationDataGridViewTextBoxColumn.DataPropertyName = "LinesRelation";
            this.linesRelationDataGridViewTextBoxColumn.DataSource = this.linesTypeBindingSource;
            this.linesRelationDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.linesRelationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.linesRelationDataGridViewTextBoxColumn.HeaderText = "Lines Relation";
            this.linesRelationDataGridViewTextBoxColumn.Name = "linesRelationDataGridViewTextBoxColumn";
            this.linesRelationDataGridViewTextBoxColumn.ReadOnly = true;
            this.linesRelationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linesRelationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linesRelationDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // sequencesTransactionsBindingSource
            // 
            this.sequencesTransactionsBindingSource.DataSource = typeof(FlameTradeSS.SequencesTransactions);
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.DataSource = this.transactionsTypeBindingSource;
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transactionTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.transactionTypeIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // frmSequenceTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvRight);
            this.Controls.Add(this.dgvLeft);
            this.Controls.Add(this.lvlSequence);
            this.Controls.Add(this.cmbDocumentSequence);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSequenceTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonsRoleOfPersons";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPersonsRoleOfPersons_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPersonsRoleOfPersons_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequencesTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lvlSequence;
        private System.Windows.Forms.ComboBox cmbDocumentSequence;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dgvRight;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.BindingSource sequencesTransactionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionMultiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn linesRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource linesTypeBindingSource;
    }
}