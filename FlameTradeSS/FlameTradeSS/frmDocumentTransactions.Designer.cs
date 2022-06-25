namespace FlameTradeSS
{
    partial class frmDocumentTransactions
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
            this.cmbTransactipnType = new System.Windows.Forms.ComboBox();
            this.documentTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeTransactionDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTransactipnType
            // 
            this.cmbTransactipnType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.documentTransactionsBindingSource, "TransactionTypeID", true));
            this.cmbTransactipnType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentTransactionsBindingSource, "TransactionTypeID", true));
            this.cmbTransactipnType.DataSource = this.transactionsTypeBindingSource;
            this.cmbTransactipnType.DisplayMember = "TypeName";
            this.cmbTransactipnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTransactipnType.Enabled = false;
            this.cmbTransactipnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransactipnType.FormattingEnabled = true;
            this.cmbTransactipnType.Location = new System.Drawing.Point(12, 12);
            this.cmbTransactipnType.Name = "cmbTransactipnType";
            this.cmbTransactipnType.Size = new System.Drawing.Size(204, 21);
            this.cmbTransactipnType.TabIndex = 0;
            this.cmbTransactipnType.ValueMember = "ID";
            // 
            // documentTransactionsBindingSource
            // 
            this.documentTransactionsBindingSource.DataSource = typeof(FlameTradeSS.DocumentTransactions);
            // 
            // transactionsTypeBindingSource
            // 
            this.transactionsTypeBindingSource.DataSource = typeof(FlameTradeSS.TransactionsType);
            // 
            // dateTimeTransactionDate
            // 
            this.dateTimeTransactionDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentTransactionsBindingSource, "TransactionDate", true));
            this.dateTimeTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransactionDate.Location = new System.Drawing.Point(240, 13);
            this.dateTimeTransactionDate.Name = "dateTimeTransactionDate";
            this.dateTimeTransactionDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimeTransactionDate.TabIndex = 1;
            // 
            // frmDocumentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(716, 589);
            this.Controls.Add(this.dateTimeTransactionDate);
            this.Controls.Add(this.cmbTransactipnType);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDocumentTransactions";
            this.Text = "Document Transactions";
            this.Load += new System.EventHandler(this.frmDocumentTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTransactipnType;
        public System.Windows.Forms.BindingSource documentTransactionsBindingSource;
        public System.Windows.Forms.BindingSource transactionsTypeBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimeTransactionDate;
    }
}