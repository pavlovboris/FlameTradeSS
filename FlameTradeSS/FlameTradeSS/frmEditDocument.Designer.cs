namespace FlameTradeSS
{
    partial class frmEditDocument
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDocument));
            this.cmbPartners = new System.Windows.Forms.ComboBox();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.cmbDocumentSequence = new System.Windows.Forms.ComboBox();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDocumentDate = new System.Windows.Forms.Label();
            this.dateTimeDocDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssueDocument = new System.Windows.Forms.Button();
            this.checkBoxIsBlocked = new System.Windows.Forms.CheckBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsAttachmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProjects = new System.Windows.Forms.Label();
            this.lblPossibleTransactons = new System.Windows.Forms.Label();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.contextMenuStripProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.documentsProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDocumentTransactions = new System.Windows.Forms.DataGridView();
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.listBoxTransactionsAdd = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NotForInvoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedMatDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedDeliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompleatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isConfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCanceledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsAttachmentsBindingSource)).BeginInit();
            this.contextMenuStripProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPartners
            // 
            this.cmbPartners.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPartners.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPartners.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentsBindingSource, "PartnerID", true));
            this.cmbPartners.DataSource = this.partnersBindingSource;
            this.cmbPartners.DisplayMember = "Partner_name";
            this.cmbPartners.FormattingEnabled = true;
            this.cmbPartners.Location = new System.Drawing.Point(27, 67);
            this.cmbPartners.Name = "cmbPartners";
            this.cmbPartners.Size = new System.Drawing.Size(347, 21);
            this.cmbPartners.TabIndex = 1;
            this.cmbPartners.ValueMember = "ID";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataSource = typeof(FlameTradeSS.Documents);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Location = new System.Drawing.Point(25, 52);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(56, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Партньор";
            // 
            // lblSequence
            // 
            this.lblSequence.AutoSize = true;
            this.lblSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSequence.Location = new System.Drawing.Point(25, 9);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(113, 13);
            this.lblSequence.TabIndex = 5;
            this.lblSequence.Text = "Серия на Документа";
            // 
            // cmbDocumentSequence
            // 
            this.cmbDocumentSequence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDocumentSequence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDocumentSequence.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentsBindingSource, "DocumentSequenceID", true));
            this.cmbDocumentSequence.DataSource = this.documentSequencesBindingSource;
            this.cmbDocumentSequence.DisplayMember = "SequenceName";
            this.cmbDocumentSequence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentSequence.Enabled = false;
            this.cmbDocumentSequence.FormattingEnabled = true;
            this.cmbDocumentSequence.Location = new System.Drawing.Point(27, 27);
            this.cmbDocumentSequence.Name = "cmbDocumentSequence";
            this.cmbDocumentSequence.Size = new System.Drawing.Size(347, 21);
            this.cmbDocumentSequence.TabIndex = 4;
            this.cmbDocumentSequence.ValueMember = "ID";
            this.cmbDocumentSequence.SelectionChangeCommitted += new System.EventHandler(this.cmbDocumentSequence_SelectionChangeCommitted);
            // 
            // documentSequencesBindingSource
            // 
            this.documentSequencesBindingSource.DataSource = typeof(FlameTradeSS.DocumentSequences);
            // 
            // lblDocumentDate
            // 
            this.lblDocumentDate.AutoSize = true;
            this.lblDocumentDate.Location = new System.Drawing.Point(423, 9);
            this.lblDocumentDate.Name = "lblDocumentDate";
            this.lblDocumentDate.Size = new System.Drawing.Size(108, 13);
            this.lblDocumentDate.TabIndex = 7;
            this.lblDocumentDate.Text = "Дата на Документа";
            // 
            // dateTimeDocDate
            // 
            this.dateTimeDocDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentsBindingSource, "DocumentDate", true));
            this.dateTimeDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDocDate.Location = new System.Drawing.Point(421, 27);
            this.dateTimeDocDate.Name = "dateTimeDocDate";
            this.dateTimeDocDate.Size = new System.Drawing.Size(110, 20);
            this.dateTimeDocDate.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnIssueDocument);
            this.panel1.Controls.Add(this.checkBoxIsBlocked);
            this.panel1.Controls.Add(this.lblComment);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(this.btnRemoveFile);
            this.panel1.Controls.Add(this.btnAddFile);
            this.panel1.Controls.Add(this.lblAttachments);
            this.panel1.Controls.Add(this.dgvAttachments);
            this.panel1.Controls.Add(this.lblProjects);
            this.panel1.Controls.Add(this.lblPossibleTransactons);
            this.panel1.Controls.Add(this.listBoxProjects);
            this.panel1.Controls.Add(this.dgvDocumentTransactions);
            this.panel1.Controls.Add(this.lblDocumentNumber);
            this.panel1.Controls.Add(this.txtDocumentNumber);
            this.panel1.Controls.Add(this.listBoxTransactionsAdd);
            this.panel1.Controls.Add(this.cmbDocumentSequence);
            this.panel1.Controls.Add(this.cmbPartners);
            this.panel1.Controls.Add(this.dateTimeDocDate);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblDocumentDate);
            this.panel1.Controls.Add(this.lblSequence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1618, 239);
            this.panel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(1067, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Анулирай Документа";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnIssueDocument
            // 
            this.btnIssueDocument.Enabled = false;
            this.btnIssueDocument.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIssueDocument.Location = new System.Drawing.Point(1067, 12);
            this.btnIssueDocument.Name = "btnIssueDocument";
            this.btnIssueDocument.Size = new System.Drawing.Size(75, 36);
            this.btnIssueDocument.TabIndex = 27;
            this.btnIssueDocument.Text = "Издай Документа";
            this.btnIssueDocument.UseVisualStyleBackColor = true;
            this.btnIssueDocument.Click += new System.EventHandler(this.btnIssueDocument_Click);
            // 
            // checkBoxIsBlocked
            // 
            this.checkBoxIsBlocked.AutoSize = true;
            this.checkBoxIsBlocked.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.documentsBindingSource, "IsBlocked", true));
            this.checkBoxIsBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIsBlocked.Location = new System.Drawing.Point(554, 91);
            this.checkBoxIsBlocked.Name = "checkBoxIsBlocked";
            this.checkBoxIsBlocked.Size = new System.Drawing.Size(140, 17);
            this.checkBoxIsBlocked.TabIndex = 26;
            this.checkBoxIsBlocked.Text = "Документа е блокиран";
            this.checkBoxIsBlocked.UseVisualStyleBackColor = true;
            this.checkBoxIsBlocked.CheckStateChanged += new System.EventHandler(this.checkBoxIsBlocked_CheckedChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(702, 9);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(57, 13);
            this.lblComment.TabIndex = 25;
            this.lblComment.Text = "Коментар";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentsBindingSource, "Comment", true));
            this.txtComment.Location = new System.Drawing.Point(705, 29);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(278, 56);
            this.txtComment.TabIndex = 24;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFile.Location = new System.Drawing.Point(1559, 199);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(47, 23);
            this.btnRemoveFile.TabIndex = 23;
            this.btnRemoveFile.Text = "-";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFile.Location = new System.Drawing.Point(1462, 199);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(47, 23);
            this.btnAddFile.TabIndex = 22;
            this.btnAddFile.Text = "+";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lblAttachments
            // 
            this.lblAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Location = new System.Drawing.Point(1459, 9);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(54, 13);
            this.lblAttachments.TabIndex = 21;
            this.lblAttachments.Text = "Файлове";
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.AllowUserToAddRows = false;
            this.dgvAttachments.AllowUserToDeleteRows = false;
            this.dgvAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttachments.AutoGenerateColumns = false;
            this.dgvAttachments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAttachments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn});
            this.dgvAttachments.DataSource = this.documentsAttachmentsBindingSource;
            this.dgvAttachments.Location = new System.Drawing.Point(1462, 29);
            this.dgvAttachments.MultiSelect = false;
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.ReadOnly = true;
            this.dgvAttachments.RowHeadersWidth = 20;
            this.dgvAttachments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttachments.Size = new System.Drawing.Size(144, 164);
            this.dgvAttachments.TabIndex = 20;
            this.dgvAttachments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachments_CellDoubleClick);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // documentsAttachmentsBindingSource
            // 
            this.documentsAttachmentsBindingSource.DataSource = typeof(FlameTradeSS.DocumentsAttachments);
            // 
            // lblProjects
            // 
            this.lblProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(1241, 9);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(50, 13);
            this.lblProjects.TabIndex = 16;
            this.lblProjects.Text = "Проекти";
            // 
            // lblPossibleTransactons
            // 
            this.lblPossibleTransactons.AutoSize = true;
            this.lblPossibleTransactons.Location = new System.Drawing.Point(551, 9);
            this.lblPossibleTransactons.Name = "lblPossibleTransactons";
            this.lblPossibleTransactons.Size = new System.Drawing.Size(125, 13);
            this.lblPossibleTransactons.TabIndex = 15;
            this.lblPossibleTransactons.Text = "Възможни Транзакции";
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProjects.ContextMenuStrip = this.contextMenuStripProjects;
            this.listBoxProjects.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentsProjectsBindingSource, "ProjectID", true));
            this.listBoxProjects.DataSource = this.projectBindingSource;
            this.listBoxProjects.DisplayMember = "ProjectName";
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.Location = new System.Drawing.Point(1244, 29);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(212, 82);
            this.listBoxProjects.TabIndex = 14;
            this.listBoxProjects.ValueMember = "ID";
            // 
            // contextMenuStripProjects
            // 
            this.contextMenuStripProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripSeparator1});
            this.contextMenuStripProjects.Name = "contextMenuStripProjects";
            this.contextMenuStripProjects.Size = new System.Drawing.Size(159, 32);
            this.contextMenuStripProjects.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripProjects_Opening);
            this.contextMenuStripProjects.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripProjects_ItemClicked);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemAdd.Text = "Добави Проект";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // documentsProjectsBindingSource
            // 
            this.documentsProjectsBindingSource.DataSource = typeof(FlameTradeSS.DocumentsProjects);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(FlameTradeSS.Project);
            // 
            // dgvDocumentTransactions
            // 
            this.dgvDocumentTransactions.AllowUserToAddRows = false;
            this.dgvDocumentTransactions.AllowUserToDeleteRows = false;
            this.dgvDocumentTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentTransactions.AutoGenerateColumns = false;
            this.dgvDocumentTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionTypeIDDataGridViewTextBoxColumn,
            this.NotForInvoice,
            this.transactionDateDataGridViewTextBoxColumn,
            this.expectedMatDateDataGridViewTextBoxColumn,
            this.requestedDateDataGridViewTextBoxColumn,
            this.receivedDateDataGridViewTextBoxColumn,
            this.requestedDeliveryDateDataGridViewTextBoxColumn,
            this.qty1DataGridViewTextBoxColumn,
            this.qty2DataGridViewTextBoxColumn,
            this.qty3DataGridViewTextBoxColumn,
            this.value1DataGridViewTextBoxColumn,
            this.value2DataGridViewTextBoxColumn,
            this.value3DataGridViewTextBoxColumn,
            this.isCompleatedDataGridViewTextBoxColumn,
            this.isReadyDataGridViewTextBoxColumn,
            this.isConfirmedDataGridViewTextBoxColumn,
            this.isDeliveredDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.creationDateTimeDataGridViewTextBoxColumn,
            this.colorIDDataGridViewTextBoxColumn,
            this.isCanceledDataGridViewTextBoxColumn});
            this.dgvDocumentTransactions.DataSource = this.documentTransactionsBindingSource;
            this.dgvDocumentTransactions.Location = new System.Drawing.Point(27, 116);
            this.dgvDocumentTransactions.MultiSelect = false;
            this.dgvDocumentTransactions.Name = "dgvDocumentTransactions";
            this.dgvDocumentTransactions.RowHeadersWidth = 20;
            this.dgvDocumentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentTransactions.Size = new System.Drawing.Size(1429, 105);
            this.dgvDocumentTransactions.TabIndex = 12;
            this.dgvDocumentTransactions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // documentTransactionsBindingSource
            // 
            this.documentTransactionsBindingSource.DataSource = typeof(FlameTradeSS.DocumentTransactions);
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(418, 52);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(116, 13);
            this.lblDocumentNumber.TabIndex = 11;
            this.lblDocumentNumber.Text = "Номер на Документа";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentsBindingSource, "DocumentNumber", true));
            this.txtDocumentNumber.Location = new System.Drawing.Point(421, 68);
            this.txtDocumentNumber.MaxLength = 20;
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(110, 20);
            this.txtDocumentNumber.TabIndex = 10;
            this.txtDocumentNumber.EnabledChanged += new System.EventHandler(this.txtDocumentNumber_EnabledChanged);
            // 
            // listBoxTransactionsAdd
            // 
            this.listBoxTransactionsAdd.FormattingEnabled = true;
            this.listBoxTransactionsAdd.Location = new System.Drawing.Point(554, 29);
            this.listBoxTransactionsAdd.Name = "listBoxTransactionsAdd";
            this.listBoxTransactionsAdd.Size = new System.Drawing.Size(145, 56);
            this.listBoxTransactionsAdd.TabIndex = 9;
            this.listBoxTransactionsAdd.DoubleClick += new System.EventHandler(this.listBoxTransactionsAdd_DoubleClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.DataSource = this.transactionsTypeBindingSource;
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.transactionTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "Транзакция";
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transactionTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // NotForInvoice
            // 
            this.NotForInvoice.DataPropertyName = "NotForInvoice";
            this.NotForInvoice.FalseValue = "0";
            this.NotForInvoice.HeaderText = "!Фактура";
            this.NotForInvoice.Name = "NotForInvoice";
            this.NotForInvoice.TrueValue = "1";
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.transactionDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            // 
            // expectedMatDateDataGridViewTextBoxColumn
            // 
            this.expectedMatDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedMatDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.expectedMatDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.expectedMatDateDataGridViewTextBoxColumn.HeaderText = "ExpectedMatDate";
            this.expectedMatDateDataGridViewTextBoxColumn.Name = "expectedMatDateDataGridViewTextBoxColumn";
            // 
            // requestedDateDataGridViewTextBoxColumn
            // 
            this.requestedDateDataGridViewTextBoxColumn.DataPropertyName = "RequestedDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.requestedDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.requestedDateDataGridViewTextBoxColumn.HeaderText = "RequestedDate";
            this.requestedDateDataGridViewTextBoxColumn.Name = "requestedDateDataGridViewTextBoxColumn";
            // 
            // receivedDateDataGridViewTextBoxColumn
            // 
            this.receivedDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivedDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.receivedDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.receivedDateDataGridViewTextBoxColumn.HeaderText = "ReceivedDate";
            this.receivedDateDataGridViewTextBoxColumn.Name = "receivedDateDataGridViewTextBoxColumn";
            // 
            // requestedDeliveryDateDataGridViewTextBoxColumn
            // 
            this.requestedDeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "RequestedDeliveryDate";
            dataGridViewCellStyle5.Format = "d";
            this.requestedDeliveryDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.requestedDeliveryDateDataGridViewTextBoxColumn.HeaderText = "RequestedDeliveryDate";
            this.requestedDeliveryDateDataGridViewTextBoxColumn.Name = "requestedDeliveryDateDataGridViewTextBoxColumn";
            // 
            // qty1DataGridViewTextBoxColumn
            // 
            this.qty1DataGridViewTextBoxColumn.DataPropertyName = "Qty1";
            this.qty1DataGridViewTextBoxColumn.HeaderText = "Qty1";
            this.qty1DataGridViewTextBoxColumn.Name = "qty1DataGridViewTextBoxColumn";
            this.qty1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qty2DataGridViewTextBoxColumn
            // 
            this.qty2DataGridViewTextBoxColumn.DataPropertyName = "Qty2";
            this.qty2DataGridViewTextBoxColumn.HeaderText = "Qty2";
            this.qty2DataGridViewTextBoxColumn.Name = "qty2DataGridViewTextBoxColumn";
            this.qty2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qty3DataGridViewTextBoxColumn
            // 
            this.qty3DataGridViewTextBoxColumn.DataPropertyName = "Qty3";
            this.qty3DataGridViewTextBoxColumn.HeaderText = "Qty3";
            this.qty3DataGridViewTextBoxColumn.Name = "qty3DataGridViewTextBoxColumn";
            this.qty3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // value1DataGridViewTextBoxColumn
            // 
            this.value1DataGridViewTextBoxColumn.DataPropertyName = "Value1";
            this.value1DataGridViewTextBoxColumn.HeaderText = "Value1";
            this.value1DataGridViewTextBoxColumn.Name = "value1DataGridViewTextBoxColumn";
            this.value1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // value2DataGridViewTextBoxColumn
            // 
            this.value2DataGridViewTextBoxColumn.DataPropertyName = "Value2";
            this.value2DataGridViewTextBoxColumn.HeaderText = "Value2";
            this.value2DataGridViewTextBoxColumn.Name = "value2DataGridViewTextBoxColumn";
            this.value2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // value3DataGridViewTextBoxColumn
            // 
            this.value3DataGridViewTextBoxColumn.DataPropertyName = "Value3";
            this.value3DataGridViewTextBoxColumn.HeaderText = "Value3";
            this.value3DataGridViewTextBoxColumn.Name = "value3DataGridViewTextBoxColumn";
            this.value3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCompleatedDataGridViewTextBoxColumn
            // 
            this.isCompleatedDataGridViewTextBoxColumn.DataPropertyName = "IsCompleated";
            this.isCompleatedDataGridViewTextBoxColumn.HeaderText = "IsCompleated";
            this.isCompleatedDataGridViewTextBoxColumn.Name = "isCompleatedDataGridViewTextBoxColumn";
            // 
            // isReadyDataGridViewTextBoxColumn
            // 
            this.isReadyDataGridViewTextBoxColumn.DataPropertyName = "IsReady";
            this.isReadyDataGridViewTextBoxColumn.HeaderText = "IsReady";
            this.isReadyDataGridViewTextBoxColumn.Name = "isReadyDataGridViewTextBoxColumn";
            // 
            // isConfirmedDataGridViewTextBoxColumn
            // 
            this.isConfirmedDataGridViewTextBoxColumn.DataPropertyName = "IsConfirmed";
            this.isConfirmedDataGridViewTextBoxColumn.HeaderText = "IsConfirmed";
            this.isConfirmedDataGridViewTextBoxColumn.Name = "isConfirmedDataGridViewTextBoxColumn";
            // 
            // isDeliveredDataGridViewTextBoxColumn
            // 
            this.isDeliveredDataGridViewTextBoxColumn.DataPropertyName = "IsDelivered";
            this.isDeliveredDataGridViewTextBoxColumn.HeaderText = "IsDelivered";
            this.isDeliveredDataGridViewTextBoxColumn.Name = "isDeliveredDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateTimeDataGridViewTextBoxColumn
            // 
            this.creationDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationDateTime";
            dataGridViewCellStyle6.Format = "d";
            this.creationDateTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.creationDateTimeDataGridViewTextBoxColumn.HeaderText = "CreationDateTime";
            this.creationDateTimeDataGridViewTextBoxColumn.Name = "creationDateTimeDataGridViewTextBoxColumn";
            this.creationDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorIDDataGridViewTextBoxColumn
            // 
            this.colorIDDataGridViewTextBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.HeaderText = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.Name = "colorIDDataGridViewTextBoxColumn";
            // 
            // isCanceledDataGridViewTextBoxColumn
            // 
            this.isCanceledDataGridViewTextBoxColumn.DataPropertyName = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.HeaderText = "IsCanceled";
            this.isCanceledDataGridViewTextBoxColumn.Name = "isCanceledDataGridViewTextBoxColumn";
            // 
            // frmEditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1618, 863);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmEditDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewDocument_FormClosing);
            this.Load += new System.EventHandler(this.frmNewDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsAttachmentsBindingSource)).EndInit();
            this.contextMenuStripProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPartners;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.ComboBox cmbDocumentSequence;
        private System.Windows.Forms.BindingSource documentSequencesBindingSource;
        private System.Windows.Forms.Label lblDocumentDate;
        public System.Windows.Forms.DateTimePicker dateTimeDocDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.ListBox listBoxTransactionsAdd;
        private System.Windows.Forms.DataGridView dgvDocumentTransactions;
        private System.Windows.Forms.BindingSource documentTransactionsBindingSource;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.BindingSource documentsProjectsBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProjects;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblPossibleTransactons;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentsAttachmentsBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.CheckBox checkBoxIsBlocked;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIssueDocument;
        private System.Windows.Forms.DataGridViewComboBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotForInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedMatDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedDeliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn value1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn value2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn value3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCompleatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isReadyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isConfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCanceledDataGridViewTextBoxColumn;
    }
}