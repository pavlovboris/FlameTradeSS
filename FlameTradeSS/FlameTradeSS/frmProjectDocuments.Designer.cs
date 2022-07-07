namespace FlameTradeSS
{
    partial class frmProjectDocuments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDocuments));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.dgvProjectDocuments = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.documentSequenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isCanceledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(925, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(12, 21);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(77, 20);
            this.lblProject.TabIndex = 17;
            this.lblProject.Text = "Проект : ";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(82, 21);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(18, 20);
            this.lblProjectName.TabIndex = 18;
            this.lblProjectName.Text = "?";
            // 
            // dgvProjectDocuments
            // 
            this.dgvProjectDocuments.AllowUserToAddRows = false;
            this.dgvProjectDocuments.AllowUserToDeleteRows = false;
            this.dgvProjectDocuments.AutoGenerateColumns = false;
            this.dgvProjectDocuments.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjectDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjectDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentSequenceIDDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.partnerIDDataGridViewTextBoxColumn,
            this.documentDateDataGridViewTextBoxColumn,
            this.incomeValueDataGridViewTextBoxColumn,
            this.expenseValueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.isCanceledDataGridViewTextBoxColumn});
            this.dgvProjectDocuments.DataSource = this.documentsBindingSource;
            this.dgvProjectDocuments.Location = new System.Drawing.Point(16, 97);
            this.dgvProjectDocuments.MultiSelect = false;
            this.dgvProjectDocuments.Name = "dgvProjectDocuments";
            this.dgvProjectDocuments.ReadOnly = true;
            this.dgvProjectDocuments.RowHeadersWidth = 5;
            this.dgvProjectDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectDocuments.Size = new System.Drawing.Size(952, 357);
            this.dgvProjectDocuments.TabIndex = 19;
            this.dgvProjectDocuments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectAttachments_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Всички",
            "Не",
            "Да"});
            this.comboBox1.Location = new System.Drawing.Point(861, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // documentSequenceIDDataGridViewTextBoxColumn
            // 
            this.documentSequenceIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentSequenceID";
            this.documentSequenceIDDataGridViewTextBoxColumn.DataSource = this.documentSequencesBindingSource;
            this.documentSequenceIDDataGridViewTextBoxColumn.DisplayMember = "SequenceName";
            this.documentSequenceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.documentSequenceIDDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.documentSequenceIDDataGridViewTextBoxColumn.Name = "documentSequenceIDDataGridViewTextBoxColumn";
            this.documentSequenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentSequenceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentSequenceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentSequenceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            this.documentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource;
            this.partnerIDDataGridViewTextBoxColumn.DisplayMember = "Partner_name";
            this.partnerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "Партьор";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
            this.partnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partnerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partnerIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.partnerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
            // 
            // documentDateDataGridViewTextBoxColumn
            // 
            this.documentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.documentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.documentDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.documentDateDataGridViewTextBoxColumn.Name = "documentDateDataGridViewTextBoxColumn";
            this.documentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // incomeValueDataGridViewTextBoxColumn
            // 
            this.incomeValueDataGridViewTextBoxColumn.DataPropertyName = "IncomeValue";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.incomeValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.incomeValueDataGridViewTextBoxColumn.HeaderText = "Приход";
            this.incomeValueDataGridViewTextBoxColumn.Name = "incomeValueDataGridViewTextBoxColumn";
            this.incomeValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.incomeValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // expenseValueDataGridViewTextBoxColumn
            // 
            this.expenseValueDataGridViewTextBoxColumn.DataPropertyName = "ExpenseValue";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.expenseValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.expenseValueDataGridViewTextBoxColumn.HeaderText = "Разход";
            this.expenseValueDataGridViewTextBoxColumn.Name = "expenseValueDataGridViewTextBoxColumn";
            this.expenseValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.expenseValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментар";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.userIDDataGridViewTextBoxColumn.DisplayMember = "UserName";
            this.userIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "Потребител";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(FlameTradeSS.Users);
            // 
            // isCanceledDataGridViewTextBoxColumn
            // 
            this.isCanceledDataGridViewTextBoxColumn.DataPropertyName = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.FalseValue = "0";
            this.isCanceledDataGridViewTextBoxColumn.HeaderText = "Анулиран";
            this.isCanceledDataGridViewTextBoxColumn.Name = "isCanceledDataGridViewTextBoxColumn";
            this.isCanceledDataGridViewTextBoxColumn.ReadOnly = true;
            this.isCanceledDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isCanceledDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isCanceledDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataSource = typeof(FlameTradeSS.Documents);
            // 
            // frmProjectDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 466);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvProjectDocuments);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProjectDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.DataGridView dgvProjectDocuments;
        private System.Windows.Forms.DataGridViewComboBoxColumn documentSequenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCanceledDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}