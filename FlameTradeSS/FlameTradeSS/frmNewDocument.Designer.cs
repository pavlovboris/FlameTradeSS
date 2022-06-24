namespace FlameTradeSS
{
    partial class frmNewDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewDocument));
            this.cmbPartners = new System.Windows.Forms.ComboBox();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.cmbDocumentSequence = new System.Windows.Forms.ComboBox();
            this.documentSequencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDocumentDate = new System.Windows.Forms.Label();
            this.dateTimeDocDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.cmbPartners.Location = new System.Drawing.Point(27, 98);
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
            this.lblCustomerName.Location = new System.Drawing.Point(25, 82);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(56, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Партньор";
            // 
            // lblSequence
            // 
            this.lblSequence.AutoSize = true;
            this.lblSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSequence.Location = new System.Drawing.Point(25, 26);
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
            this.cmbDocumentSequence.FormattingEnabled = true;
            this.cmbDocumentSequence.Location = new System.Drawing.Point(27, 42);
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
            this.lblDocumentDate.Location = new System.Drawing.Point(423, 26);
            this.lblDocumentDate.Name = "lblDocumentDate";
            this.lblDocumentDate.Size = new System.Drawing.Size(108, 13);
            this.lblDocumentDate.TabIndex = 7;
            this.lblDocumentDate.Text = "Дата на Документа";
            // 
            // dateTimeDocDate
            // 
            this.dateTimeDocDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentsBindingSource, "DocumentDate", true));
            this.dateTimeDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDocDate.Location = new System.Drawing.Point(421, 42);
            this.dateTimeDocDate.Name = "dateTimeDocDate";
            this.dateTimeDocDate.Size = new System.Drawing.Size(110, 20);
            this.dateTimeDocDate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbDocumentSequence);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbPartners);
            this.panel1.Controls.Add(this.dateTimeDocDate);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblDocumentDate);
            this.panel1.Controls.Add(this.lblSequence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 157);
            this.panel1.TabIndex = 12;
            // 
            // frmNewDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 863);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmNewDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewDocument_FormClosing);
            this.Load += new System.EventHandler(this.frmNewDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSequencesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}