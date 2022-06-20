namespace FlameTradeSS
{
    partial class frmUsersManagement
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(13, 13);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 20;
            this.dgvUsers.Size = new System.Drawing.Size(525, 388);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsers_CellFormatting);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(FlameTradeSS.Roles);
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataSource = typeof(FlameTradeSS.Persons);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(FlameTradeSS.Users);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 102;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.DataSource = this.rolesBindingSource;
            this.roleIDDataGridViewTextBoxColumn.DisplayMember = "RoleName";
            this.roleIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roleIDDataGridViewTextBoxColumn.ValueMember = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.Width = 101;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.DataSource = this.personsBindingSource;
            this.personIDDataGridViewTextBoxColumn.DisplayMember = "PersonName";
            this.personIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.personIDDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.personIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.personIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 471);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmUsersManagement";
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn personIDDataGridViewTextBoxColumn;
    }
}