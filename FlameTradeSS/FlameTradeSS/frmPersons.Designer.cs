namespace FlameTradeSS
{
    partial class frmPersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersons));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personSureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(793, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 47);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersons.AutoGenerateColumns = false;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNameDataGridViewTextBoxColumn,
            this.personMiddleNameDataGridViewTextBoxColumn,
            this.personSureNameDataGridViewTextBoxColumn,
            this.PersonTypeID,
            this.personAddressDataGridViewTextBoxColumn,
            this.personEmailDataGridViewTextBoxColumn,
            this.personPhoneDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvPersons.DataSource = this.personsBindingSource;
            this.dgvPersons.Location = new System.Drawing.Point(12, 57);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 20;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(823, 328);
            this.dgvPersons.TabIndex = 27;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "PersonName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.personNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            // 
            // personMiddleNameDataGridViewTextBoxColumn
            // 
            this.personMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "PersonMiddleName";
            this.personMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.personMiddleNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.personMiddleNameDataGridViewTextBoxColumn.Name = "personMiddleNameDataGridViewTextBoxColumn";
            // 
            // personSureNameDataGridViewTextBoxColumn
            // 
            this.personSureNameDataGridViewTextBoxColumn.DataPropertyName = "PersonSureName";
            this.personSureNameDataGridViewTextBoxColumn.HeaderText = "Sure Name";
            this.personSureNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.personSureNameDataGridViewTextBoxColumn.Name = "personSureNameDataGridViewTextBoxColumn";
            // 
            // PersonTypeID
            // 
            this.PersonTypeID.DataPropertyName = "PersonTypeID";
            this.PersonTypeID.DataSource = this.personsTypeBindingSource;
            this.PersonTypeID.DisplayMember = "PersonTypeName";
            this.PersonTypeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.PersonTypeID.HeaderText = "Person Type";
            this.PersonTypeID.Name = "PersonTypeID";
            this.PersonTypeID.ValueMember = "ID";
            // 
            // personsTypeBindingSource
            // 
            this.personsTypeBindingSource.DataSource = typeof(FlameTradeSS.PersonsType);
            // 
            // personAddressDataGridViewTextBoxColumn
            // 
            this.personAddressDataGridViewTextBoxColumn.DataPropertyName = "PersonAddress";
            this.personAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.personAddressDataGridViewTextBoxColumn.MaxInputLength = 250;
            this.personAddressDataGridViewTextBoxColumn.Name = "personAddressDataGridViewTextBoxColumn";
            // 
            // personEmailDataGridViewTextBoxColumn
            // 
            this.personEmailDataGridViewTextBoxColumn.DataPropertyName = "PersonEmail";
            this.personEmailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.personEmailDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.personEmailDataGridViewTextBoxColumn.Name = "personEmailDataGridViewTextBoxColumn";
            // 
            // personPhoneDataGridViewTextBoxColumn
            // 
            this.personPhoneDataGridViewTextBoxColumn.DataPropertyName = "PersonPhone";
            dataGridViewCellStyle1.Format = "+### #### ## ## ## ";
            dataGridViewCellStyle1.NullValue = null;
            this.personPhoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.personPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.personPhoneDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.personPhoneDataGridViewTextBoxColumn.Name = "personPhoneDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MaxInputLength = 250;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataSource = typeof(FlameTradeSS.Persons);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(742, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(95, 387);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 52);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(9, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersons";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPersons_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPersons_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource personsTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personSureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn PersonTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}