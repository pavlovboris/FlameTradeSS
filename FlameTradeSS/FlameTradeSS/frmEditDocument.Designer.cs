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
            this.cmbSequenceFilter = new System.Windows.Forms.ComboBox();
            this.transactionsTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.TransactionTypes_TransactionTypeID_TypeName_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotForInvoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedMatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptModel_ReceiptModelID_ModelName_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.receiptModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RequestedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReady = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsConfirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Users_UserID_UserName_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreationDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCanceled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDocumentTransactions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSplitTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.documentTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.listBoxTransactionsAdd = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.btnApplyReceiptModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsAttachmentsBindingSource)).BeginInit();
            this.contextMenuStripProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.contextMenuStripDocumentTransactions.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnApplyReceiptModel);
            this.panel1.Controls.Add(this.cmbSequenceFilter);
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
            this.panel1.MinimumSize = new System.Drawing.Size(1450, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 239);
            this.panel1.TabIndex = 12;
            // 
            // cmbSequenceFilter
            // 
            this.cmbSequenceFilter.DataSource = this.transactionsTypeBindingSource1;
            this.cmbSequenceFilter.DisplayMember = "TypeName";
            this.cmbSequenceFilter.FormattingEnabled = true;
            this.cmbSequenceFilter.Location = new System.Drawing.Point(45, 91);
            this.cmbSequenceFilter.Name = "cmbSequenceFilter";
            this.cmbSequenceFilter.Size = new System.Drawing.Size(103, 21);
            this.cmbSequenceFilter.TabIndex = 29;
            this.cmbSequenceFilter.ValueMember = "ID";
            this.cmbSequenceFilter.SelectedIndexChanged += new System.EventHandler(this.cmbSequenceFilter_SelectedIndexChanged);
            // 
            // transactionsTypeBindingSource1
            // 
            this.transactionsTypeBindingSource1.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(989, 52);
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
            this.btnIssueDocument.Location = new System.Drawing.Point(989, 6);
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
            this.btnRemoveFile.Location = new System.Drawing.Point(1491, 199);
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
            this.btnAddFile.Location = new System.Drawing.Point(1394, 199);
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
            this.lblAttachments.Location = new System.Drawing.Point(1391, 9);
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
            this.dgvAttachments.Location = new System.Drawing.Point(1394, 29);
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
            this.lblProjects.Location = new System.Drawing.Point(1173, 9);
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
            this.listBoxProjects.Location = new System.Drawing.Point(1176, 29);
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
            this.TransactionTypes_TransactionTypeID_TypeName_ID,
            this.NotForInvoice,
            this.TransactionDate,
            this.Comment,
            this.ExpectedMatDate,
            this.RequestedDate,
            this.receivedDateDataGridViewTextBoxColumn,
            this.ReceiptModel_ReceiptModelID_ModelName_ID,
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID,
            this.RequestedDeliveryDate,
            this.Qty1,
            this.Qty2,
            this.Qty3,
            this.Value1,
            this.Value2,
            this.Value3,
            this.IsCompleated,
            this.IsReady,
            this.IsConfirmed,
            this.IsDelivered,
            this.Users_UserID_UserName_ID,
            this.CreationDateTime,
            this.ColorID,
            this.IsCanceled});
            this.dgvDocumentTransactions.ContextMenuStrip = this.contextMenuStripDocumentTransactions;
            this.dgvDocumentTransactions.DataSource = this.documentTransactionsBindingSource;
            this.dgvDocumentTransactions.Location = new System.Drawing.Point(27, 116);
            this.dgvDocumentTransactions.MultiSelect = false;
            this.dgvDocumentTransactions.Name = "dgvDocumentTransactions";
            this.dgvDocumentTransactions.RowHeadersWidth = 20;
            this.dgvDocumentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentTransactions.Size = new System.Drawing.Size(1361, 105);
            this.dgvDocumentTransactions.TabIndex = 12;
            this.dgvDocumentTransactions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dgvDocumentTransactions.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDocumentTransactions_ColumnWidthChanged);
            // 
            // TransactionTypes_TransactionTypeID_TypeName_ID
            // 
            this.TransactionTypes_TransactionTypeID_TypeName_ID.DataPropertyName = "TransactionTypeID";
            this.TransactionTypes_TransactionTypeID_TypeName_ID.DataSource = this.transactionsTypeBindingSource;
            this.TransactionTypes_TransactionTypeID_TypeName_ID.DisplayMember = "TypeName";
            this.TransactionTypes_TransactionTypeID_TypeName_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TransactionTypes_TransactionTypeID_TypeName_ID.HeaderText = "Транзакция";
            this.TransactionTypes_TransactionTypeID_TypeName_ID.Name = "TransactionTypes_TransactionTypeID_TypeName_ID";
            this.TransactionTypes_TransactionTypeID_TypeName_ID.ReadOnly = true;
            this.TransactionTypes_TransactionTypeID_TypeName_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionTypes_TransactionTypeID_TypeName_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TransactionTypes_TransactionTypeID_TypeName_ID.ValueMember = "ID";
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // NotForInvoice
            // 
            this.NotForInvoice.DataPropertyName = "NotForInvoice";
            this.NotForInvoice.FalseValue = "0";
            this.NotForInvoice.HeaderText = "!Фактура";
            this.NotForInvoice.Name = "NotForInvoice";
            this.NotForInvoice.TrueValue = "1";
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.TransactionDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.TransactionDate.HeaderText = "Дата";
            this.TransactionDate.Name = "TransactionDate";
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // ExpectedMatDate
            // 
            this.ExpectedMatDate.DataPropertyName = "ExpectedMatDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ExpectedMatDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExpectedMatDate.HeaderText = "Очаквана Дата";
            this.ExpectedMatDate.Name = "ExpectedMatDate";
            this.ExpectedMatDate.Width = 110;
            // 
            // RequestedDate
            // 
            this.RequestedDate.DataPropertyName = "RequestedDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.RequestedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.RequestedDate.HeaderText = "Искана Дата";
            this.RequestedDate.Name = "RequestedDate";
            // 
            // receivedDateDataGridViewTextBoxColumn
            // 
            this.receivedDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivedDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.receivedDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.receivedDateDataGridViewTextBoxColumn.HeaderText = "Дата на Получаване";
            this.receivedDateDataGridViewTextBoxColumn.Name = "receivedDateDataGridViewTextBoxColumn";
            this.receivedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // ReceiptModel_ReceiptModelID_ModelName_ID
            // 
            this.ReceiptModel_ReceiptModelID_ModelName_ID.DataPropertyName = "ReceiptModelID";
            this.ReceiptModel_ReceiptModelID_ModelName_ID.DataSource = this.receiptModelsBindingSource;
            this.ReceiptModel_ReceiptModelID_ModelName_ID.DisplayMember = "ModelName";
            this.ReceiptModel_ReceiptModelID_ModelName_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ReceiptModel_ReceiptModelID_ModelName_ID.HeaderText = "Модел на Рецепта";
            this.ReceiptModel_ReceiptModelID_ModelName_ID.Name = "ReceiptModel_ReceiptModelID_ModelName_ID";
            this.ReceiptModel_ReceiptModelID_ModelName_ID.ValueMember = "ID";
            this.ReceiptModel_ReceiptModelID_ModelName_ID.Width = 120;
            // 
            // receiptModelsBindingSource
            // 
            this.receiptModelsBindingSource.DataSource = typeof(FlameTradeSS.ReceiptModels);
            // 
            // Surfaces_TransactionSurfaceID_SurfaceName_ID
            // 
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.DataPropertyName = "TransactionSurfaceID";
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.DataSource = this.surfacesBindingSource;
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.DisplayMember = "SurfaceName";
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.HeaderText = "Повърхност";
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.Name = "Surfaces_TransactionSurfaceID_SurfaceName_ID";
            this.Surfaces_TransactionSurfaceID_SurfaceName_ID.ValueMember = "ID";
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // RequestedDeliveryDate
            // 
            this.RequestedDeliveryDate.DataPropertyName = "RequestedDeliveryDate";
            dataGridViewCellStyle5.Format = "d";
            this.RequestedDeliveryDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.RequestedDeliveryDate.HeaderText = "Искана Дата на Доставка";
            this.RequestedDeliveryDate.Name = "RequestedDeliveryDate";
            this.RequestedDeliveryDate.Width = 165;
            // 
            // Qty1
            // 
            this.Qty1.DataPropertyName = "Qty1";
            this.Qty1.HeaderText = "К-ВО 1";
            this.Qty1.Name = "Qty1";
            this.Qty1.ReadOnly = true;
            // 
            // Qty2
            // 
            this.Qty2.DataPropertyName = "Qty2";
            this.Qty2.HeaderText = "К-ВО 2";
            this.Qty2.Name = "Qty2";
            this.Qty2.ReadOnly = true;
            // 
            // Qty3
            // 
            this.Qty3.DataPropertyName = "Qty3";
            this.Qty3.HeaderText = "К-ВО 3";
            this.Qty3.Name = "Qty3";
            this.Qty3.ReadOnly = true;
            // 
            // Value1
            // 
            this.Value1.DataPropertyName = "Value1";
            this.Value1.HeaderText = "Стойност 1";
            this.Value1.Name = "Value1";
            this.Value1.ReadOnly = true;
            // 
            // Value2
            // 
            this.Value2.DataPropertyName = "Value2";
            this.Value2.HeaderText = "Стойност 2";
            this.Value2.Name = "Value2";
            this.Value2.ReadOnly = true;
            // 
            // Value3
            // 
            this.Value3.DataPropertyName = "Value3";
            this.Value3.HeaderText = "Стойност 3";
            this.Value3.Name = "Value3";
            this.Value3.ReadOnly = true;
            // 
            // IsCompleated
            // 
            this.IsCompleated.DataPropertyName = "IsCompleated";
            this.IsCompleated.HeaderText = "IsCompleated";
            this.IsCompleated.Name = "IsCompleated";
            // 
            // IsReady
            // 
            this.IsReady.DataPropertyName = "IsReady";
            this.IsReady.HeaderText = "IsReady";
            this.IsReady.Name = "IsReady";
            // 
            // IsConfirmed
            // 
            this.IsConfirmed.DataPropertyName = "IsConfirmed";
            this.IsConfirmed.HeaderText = "IsConfirmed";
            this.IsConfirmed.Name = "IsConfirmed";
            // 
            // IsDelivered
            // 
            this.IsDelivered.DataPropertyName = "IsDelivered";
            this.IsDelivered.HeaderText = "IsDelivered";
            this.IsDelivered.Name = "IsDelivered";
            // 
            // Users_UserID_UserName_ID
            // 
            this.Users_UserID_UserName_ID.DataPropertyName = "UserID";
            this.Users_UserID_UserName_ID.DataSource = this.usersBindingSource;
            this.Users_UserID_UserName_ID.DisplayMember = "UserName";
            this.Users_UserID_UserName_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Users_UserID_UserName_ID.HeaderText = "Потребител";
            this.Users_UserID_UserName_ID.Name = "Users_UserID_UserName_ID";
            this.Users_UserID_UserName_ID.ReadOnly = true;
            this.Users_UserID_UserName_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Users_UserID_UserName_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Users_UserID_UserName_ID.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(FlameTradeSS.Users);
            // 
            // CreationDateTime
            // 
            this.CreationDateTime.DataPropertyName = "CreationDateTime";
            dataGridViewCellStyle6.Format = "d";
            this.CreationDateTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.CreationDateTime.HeaderText = "CreationDateTime";
            this.CreationDateTime.Name = "CreationDateTime";
            this.CreationDateTime.ReadOnly = true;
            // 
            // ColorID
            // 
            this.ColorID.DataPropertyName = "ColorID";
            this.ColorID.HeaderText = "ColorID";
            this.ColorID.Name = "ColorID";
            // 
            // IsCanceled
            // 
            this.IsCanceled.DataPropertyName = "IsCanceled";
            this.IsCanceled.HeaderText = "IsCanceled";
            this.IsCanceled.Name = "IsCanceled";
            // 
            // contextMenuStripDocumentTransactions
            // 
            this.contextMenuStripDocumentTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSplitTransaction});
            this.contextMenuStripDocumentTransactions.Name = "contextMenuStripDocumentTransactions";
            this.contextMenuStripDocumentTransactions.Size = new System.Drawing.Size(185, 26);
            this.contextMenuStripDocumentTransactions.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStripDocumentTransactions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripDocumentTransactions_ItemClicked);
            // 
            // toolStripMenuSplitTransaction
            // 
            this.toolStripMenuSplitTransaction.Name = "toolStripMenuSplitTransaction";
            this.toolStripMenuSplitTransaction.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuSplitTransaction.Text = "Раздели Транзакция";
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
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 239);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1550, 26);
            this.tabControlMain.TabIndex = 14;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // btnApplyReceiptModel
            // 
            this.btnApplyReceiptModel.Location = new System.Drawing.Point(705, 91);
            this.btnApplyReceiptModel.Name = "btnApplyReceiptModel";
            this.btnApplyReceiptModel.Size = new System.Drawing.Size(278, 23);
            this.btnApplyReceiptModel.TabIndex = 30;
            this.btnApplyReceiptModel.Text = "Приложи Модел на Рецепта";
            this.btnApplyReceiptModel.UseVisualStyleBackColor = true;
            this.btnApplyReceiptModel.Click += new System.EventHandler(this.btnApplyReceiptModel_Click);
            // 
            // frmEditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 858);
            this.Controls.Add(this.tabControlMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsAttachmentsBindingSource)).EndInit();
            this.contextMenuStripProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.contextMenuStripDocumentTransactions.ResumeLayout(false);
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
        public System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource receiptModelsBindingSource;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransactionTypes_TransactionTypeID_TypeName_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotForInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedMatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ReceiptModel_ReceiptModelID_ModelName_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Surfaces_TransactionSurfaceID_SurfaceName_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCompleated;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReady;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsConfirmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDelivered;
        private System.Windows.Forms.DataGridViewComboBoxColumn Users_UserID_UserName_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCanceled;
        private System.Windows.Forms.ComboBox cmbSequenceFilter;
        private System.Windows.Forms.BindingSource transactionsTypeBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDocumentTransactions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSplitTransaction;
        private System.Windows.Forms.Button btnApplyReceiptModel;
    }
}