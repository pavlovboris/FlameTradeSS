namespace FlameTradeSS
{
    partial class frmPartnersPersons
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPartner = new System.Windows.Forms.Label();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.Person_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personsFullNameViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvRight = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnerPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsFullNameViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerPersonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(858, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPartner
            // 
            this.lblPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartner.AutoSize = true;
            this.lblPartner.Location = new System.Drawing.Point(517, 31);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(50, 13);
            this.lblPartner.TabIndex = 9;
            this.lblPartner.Text = "Партьор";
            // 
            // cmbPartner
            // 
            this.cmbPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPartner.DataSource = this.partnersBindingSource;
            this.cmbPartner.DisplayMember = "Partner_name";
            this.cmbPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(573, 28);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(279, 21);
            this.cmbPartner.TabIndex = 8;
            this.cmbPartner.ValueMember = "ID";
            this.cmbPartner.SelectionChangeCommitted += new System.EventHandler(this.cmbPartner_SelectionChangeCommitted);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
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
            this.Person_Name,
            this.commentDataGridViewTextBoxColumn});
            this.dgvLeft.DataSource = this.personsBindingSource;
            this.dgvLeft.Location = new System.Drawing.Point(21, 65);
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.ReadOnly = true;
            this.dgvLeft.RowHeadersWidth = 20;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeft.Size = new System.Drawing.Size(450, 382);
            this.dgvLeft.TabIndex = 10;
            // 
            // Person_Name
            // 
            this.Person_Name.DataPropertyName = "ID";
            this.Person_Name.DataSource = this.personsFullNameViewBindingSource;
            this.Person_Name.DisplayMember = "Person_Name";
            this.Person_Name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Person_Name.HeaderText = "Име";
            this.Person_Name.Name = "Person_Name";
            this.Person_Name.ReadOnly = true;
            this.Person_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Person_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Person_Name.ValueMember = "ID";
            this.Person_Name.Width = 300;
            // 
            // personsFullNameViewBindingSource
            // 
            this.personsFullNameViewBindingSource.DataSource = typeof(FlameTradeSS.PersonsFullNameView);
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataSource = typeof(FlameTradeSS.Persons);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_056_Icon_64;
            this.btnMoveLeft.Location = new System.Drawing.Point(481, 233);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 67);
            this.btnMoveLeft.TabIndex = 12;
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_055_Icon_64;
            this.btnMoveRight.Location = new System.Drawing.Point(481, 150);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 68);
            this.btnMoveRight.TabIndex = 11;
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
            this.personIDDataGridViewTextBoxColumn});
            this.dgvRight.DataSource = this.partnerPersonsBindingSource;
            this.dgvRight.Location = new System.Drawing.Point(574, 65);
            this.dgvRight.Name = "dgvRight";
            this.dgvRight.ReadOnly = true;
            this.dgvRight.RowHeadersWidth = 20;
            this.dgvRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRight.Size = new System.Drawing.Size(327, 382);
            this.dgvRight.TabIndex = 13;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.DataSource = this.personsFullNameViewBindingSource;
            this.personIDDataGridViewTextBoxColumn.DisplayMember = "Person_Name";
            this.personIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.personIDDataGridViewTextBoxColumn.HeaderText = "Име";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.personIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.personIDDataGridViewTextBoxColumn.Width = 300;
            // 
            // partnerPersonsBindingSource
            // 
            this.partnerPersonsBindingSource.DataSource = typeof(FlameTradeSS.PartnerPersons);
            // 
            // frmPartnersPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 480);
            this.Controls.Add(this.dgvRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvLeft);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.cmbPartner);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPartnersPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnersPersons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartnersPersons_FormClosing);
            this.Load += new System.EventHandler(this.frmPartnersPersons_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnersPersons_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsFullNameViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerPersonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.BindingSource personsFullNameViewBindingSource;
        private System.Windows.Forms.DataGridView dgvRight;
        private System.Windows.Forms.BindingSource partnerPersonsBindingSource;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Person_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn personIDDataGridViewTextBoxColumn;
    }
}