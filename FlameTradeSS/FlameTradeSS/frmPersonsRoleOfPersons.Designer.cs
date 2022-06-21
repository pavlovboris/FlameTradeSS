namespace FlameTradeSS
{
    partial class frmPersonsRoleOfPersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonsRoleOfPersons));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPerson = new System.Windows.Forms.Label();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvRight = new System.Windows.Forms.DataGridView();
            this.roleOfPersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roleOfPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsRolesOfPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleOfPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsRolesOfPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(718, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPerson
            // 
            this.lblPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(442, 30);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(40, 13);
            this.lblPerson.TabIndex = 9;
            this.lblPerson.Text = "Person";
            // 
            // cmbPerson
            // 
            this.cmbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPerson.DataSource = this.personsBindingSource;
            this.cmbPerson.DisplayMember = "PersonName";
            this.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(488, 27);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(224, 21);
            this.cmbPerson.TabIndex = 8;
            this.cmbPerson.ValueMember = "ID";
            this.cmbPerson.SelectionChangeCommitted += new System.EventHandler(this.cmbPerson_SelectionChangeCommitted);
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
            this.btnMoveLeft.Location = new System.Drawing.Point(409, 251);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(63, 56);
            this.btnMoveLeft.TabIndex = 13;
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_055_Icon_64;
            this.btnMoveRight.Location = new System.Drawing.Point(409, 189);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(63, 56);
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
            this.roleOfPersonIDDataGridViewTextBoxColumn});
            this.dgvRight.DataSource = this.personsRolesOfPersonsBindingSource;
            this.dgvRight.Location = new System.Drawing.Point(488, 62);
            this.dgvRight.Name = "dgvRight";
            this.dgvRight.ReadOnly = true;
            this.dgvRight.RowHeadersWidth = 20;
            this.dgvRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRight.Size = new System.Drawing.Size(273, 414);
            this.dgvRight.TabIndex = 11;
            // 
            // roleOfPersonIDDataGridViewTextBoxColumn
            // 
            this.roleOfPersonIDDataGridViewTextBoxColumn.DataPropertyName = "RoleOfPersonID";
            this.roleOfPersonIDDataGridViewTextBoxColumn.DataSource = this.roleOfPersonsBindingSource;
            this.roleOfPersonIDDataGridViewTextBoxColumn.DisplayMember = "RoleName";
            this.roleOfPersonIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.roleOfPersonIDDataGridViewTextBoxColumn.HeaderText = "Role Name";
            this.roleOfPersonIDDataGridViewTextBoxColumn.Name = "roleOfPersonIDDataGridViewTextBoxColumn";
            this.roleOfPersonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleOfPersonIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleOfPersonIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roleOfPersonIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.roleOfPersonIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // roleOfPersonsBindingSource
            // 
            this.roleOfPersonsBindingSource.DataSource = typeof(FlameTradeSS.RoleOfPersons);
            // 
            // personsRolesOfPersonsBindingSource
            // 
            this.personsRolesOfPersonsBindingSource.DataSource = typeof(FlameTradeSS.PersonsRolesOfPersons);
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
            this.roleNameDataGridViewTextBoxColumn,
            this.roleDescriptionDataGridViewTextBoxColumn});
            this.dgvLeft.DataSource = this.roleOfPersonsBindingSource;
            this.dgvLeft.Location = new System.Drawing.Point(12, 62);
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.ReadOnly = true;
            this.dgvLeft.RowHeadersWidth = 20;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeft.Size = new System.Drawing.Size(382, 414);
            this.dgvLeft.TabIndex = 10;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Role Name";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleDescriptionDataGridViewTextBoxColumn
            // 
            this.roleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "RoleDescription";
            this.roleDescriptionDataGridViewTextBoxColumn.HeaderText = "Role Description";
            this.roleDescriptionDataGridViewTextBoxColumn.Name = "roleDescriptionDataGridViewTextBoxColumn";
            this.roleDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDescriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // frmPersonsRoleOfPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 495);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvRight);
            this.Controls.Add(this.dgvLeft);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonsRoleOfPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonsRoleOfPersons";
            this.Load += new System.EventHandler(this.frmPersonsRoleOfPersons_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPersonsRoleOfPersons_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleOfPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsRolesOfPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dgvRight;
        private System.Windows.Forms.BindingSource personsRolesOfPersonsBindingSource;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.BindingSource roleOfPersonsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleOfPersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDescriptionDataGridViewTextBoxColumn;
    }
}