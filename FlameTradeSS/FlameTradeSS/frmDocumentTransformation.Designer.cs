namespace FlameTradeSS
{
    partial class frmDocumentTransformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentTransformation));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTransofrmationFrom = new System.Windows.Forms.DataGridView();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.dgvDocumentsTo = new System.Windows.Forms.DataGridView();
            this.lblFromTransformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toSequenceDataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPartnerDataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fromDocumentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDocumentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromPartnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransofrmationFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentsTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(950, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTransofrmationFrom
            // 
            this.dgvTransofrmationFrom.AllowUserToAddRows = false;
            this.dgvTransofrmationFrom.AllowUserToDeleteRows = false;
            this.dgvTransofrmationFrom.AutoGenerateColumns = false;
            this.dgvTransofrmationFrom.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransofrmationFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransofrmationFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransofrmationFrom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn,
            this.fromDocumentNumberDataGridViewTextBoxColumn,
            this.fromDocumentDateDataGridViewTextBoxColumn,
            this.fromPartnerIDDataGridViewTextBoxColumn,
            this.Comment});
            this.dgvTransofrmationFrom.DataSource = this.documentsBindingSource;
            this.dgvTransofrmationFrom.Location = new System.Drawing.Point(12, 65);
            this.dgvTransofrmationFrom.MultiSelect = false;
            this.dgvTransofrmationFrom.Name = "dgvTransofrmationFrom";
            this.dgvTransofrmationFrom.ReadOnly = true;
            this.dgvTransofrmationFrom.RowHeadersWidth = 5;
            this.dgvTransofrmationFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransofrmationFrom.Size = new System.Drawing.Size(488, 243);
            this.dgvTransofrmationFrom.TabIndex = 10;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(196, 9);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(13, 13);
            this.lblDocumentNumber.TabIndex = 15;
            this.lblDocumentNumber.Text = "?";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(20, 9);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(170, 13);
            this.lblDocument.TabIndex = 14;
            this.lblDocument.Text = "Номер @ Серия на Документа :";
            // 
            // dgvDocumentsTo
            // 
            this.dgvDocumentsTo.AllowUserToAddRows = false;
            this.dgvDocumentsTo.AllowUserToDeleteRows = false;
            this.dgvDocumentsTo.AutoGenerateColumns = false;
            this.dgvDocumentsTo.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentsTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentsTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentsTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toSequenceDataGridViewComboBoxColumn1,
            this.toNumberDataGridViewTextBoxColumn1,
            this.toDateDataGridViewTextBoxColumn2,
            this.toPartnerDataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dgvDocumentsTo.DataSource = this.documentsBindingSource1;
            this.dgvDocumentsTo.Location = new System.Drawing.Point(506, 65);
            this.dgvDocumentsTo.MultiSelect = false;
            this.dgvDocumentsTo.Name = "dgvDocumentsTo";
            this.dgvDocumentsTo.ReadOnly = true;
            this.dgvDocumentsTo.RowHeadersWidth = 5;
            this.dgvDocumentsTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentsTo.Size = new System.Drawing.Size(488, 243);
            this.dgvDocumentsTo.TabIndex = 16;
            // 
            // lblFromTransformation
            // 
            this.lblFromTransformation.AutoSize = true;
            this.lblFromTransformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromTransformation.Location = new System.Drawing.Point(12, 43);
            this.lblFromTransformation.Name = "lblFromTransformation";
            this.lblFromTransformation.Size = new System.Drawing.Size(178, 16);
            this.lblFromTransformation.TabIndex = 17;
            this.lblFromTransformation.Text = "Документа произлиза от :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Документ/и произлищи от :";
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
            // 
            // documentsBindingSource1
            // 
            this.documentsBindingSource1.DataSource = typeof(FlameTradeSS.Documents);
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataSource = typeof(FlameTradeSS.Documents);
            // 
            // toSequenceDataGridViewComboBoxColumn1
            // 
            this.toSequenceDataGridViewComboBoxColumn1.DataPropertyName = "DocumentSequenceID";
            this.toSequenceDataGridViewComboBoxColumn1.DataSource = this.documentSequencesBindingSource;
            this.toSequenceDataGridViewComboBoxColumn1.DisplayMember = "SequenceName";
            this.toSequenceDataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.toSequenceDataGridViewComboBoxColumn1.HeaderText = "Серия";
            this.toSequenceDataGridViewComboBoxColumn1.Name = "toSequenceDataGridViewComboBoxColumn1";
            this.toSequenceDataGridViewComboBoxColumn1.ReadOnly = true;
            this.toSequenceDataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.toSequenceDataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.toSequenceDataGridViewComboBoxColumn1.ValueMember = "ID";
            // 
            // toNumberDataGridViewTextBoxColumn1
            // 
            this.toNumberDataGridViewTextBoxColumn1.DataPropertyName = "DocumentNumber";
            this.toNumberDataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.toNumberDataGridViewTextBoxColumn1.Name = "toNumberDataGridViewTextBoxColumn1";
            this.toNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn2
            // 
            this.toDateDataGridViewTextBoxColumn2.DataPropertyName = "DocumentDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.toDateDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.toDateDataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.toDateDataGridViewTextBoxColumn2.Name = "toDateDataGridViewTextBoxColumn2";
            this.toDateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // toPartnerDataGridViewComboBoxColumn2
            // 
            this.toPartnerDataGridViewComboBoxColumn2.DataPropertyName = "PartnerID";
            this.toPartnerDataGridViewComboBoxColumn2.DataSource = this.partnersBindingSource;
            this.toPartnerDataGridViewComboBoxColumn2.DisplayMember = "Partner_name";
            this.toPartnerDataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.toPartnerDataGridViewComboBoxColumn2.HeaderText = "Партьор";
            this.toPartnerDataGridViewComboBoxColumn2.Name = "toPartnerDataGridViewComboBoxColumn2";
            this.toPartnerDataGridViewComboBoxColumn2.ReadOnly = true;
            this.toPartnerDataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.toPartnerDataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.toPartnerDataGridViewComboBoxColumn2.ValueMember = "ID";
            this.toPartnerDataGridViewComboBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn1.HeaderText = "Коментар";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // fromDocumentSequenceIDDataGridViewTextBoxColumn
            // 
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentSequenceID";
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.DataSource = this.documentSequencesBindingSource;
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.DisplayMember = "SequenceName";
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.Name = "fromDocumentSequenceIDDataGridViewTextBoxColumn";
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fromDocumentSequenceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // fromDocumentNumberDataGridViewTextBoxColumn
            // 
            this.fromDocumentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.fromDocumentNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.fromDocumentNumberDataGridViewTextBoxColumn.Name = "fromDocumentNumberDataGridViewTextBoxColumn";
            this.fromDocumentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDocumentDateDataGridViewTextBoxColumn
            // 
            this.fromDocumentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fromDocumentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fromDocumentDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.fromDocumentDateDataGridViewTextBoxColumn.Name = "fromDocumentDateDataGridViewTextBoxColumn";
            this.fromDocumentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromPartnerIDDataGridViewTextBoxColumn
            // 
            this.fromPartnerIDDataGridViewTextBoxColumn.DataPropertyName = "PartnerID";
            this.fromPartnerIDDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource;
            this.fromPartnerIDDataGridViewTextBoxColumn.DisplayMember = "Partner_name";
            this.fromPartnerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fromPartnerIDDataGridViewTextBoxColumn.HeaderText = "Партьор";
            this.fromPartnerIDDataGridViewTextBoxColumn.Name = "fromPartnerIDDataGridViewTextBoxColumn";
            this.fromPartnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromPartnerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fromPartnerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fromPartnerIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.fromPartnerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Коментар";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 300;
            // 
            // frmDocumentTransformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFromTransformation);
            this.Controls.Add(this.dgvDocumentsTo);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.dgvTransofrmationFrom);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDocumentTransformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransofrmationFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentsTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTransofrmationFrom;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.BindingSource documentsBindingSource1;
        private System.Windows.Forms.DataGridView dgvDocumentsTo;
        private System.Windows.Forms.Label lblFromTransformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn fromDocumentSequenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDocumentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDocumentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fromPartnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewComboBoxColumn toSequenceDataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn toPartnerDataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}