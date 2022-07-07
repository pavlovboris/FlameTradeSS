namespace FlameTradeSS
{
    partial class frmSurfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurfaces));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSurfaces = new System.Windows.Forms.DataGridView();
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.surfaceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(607, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvSurfaces
            // 
            this.dgvSurfaces.AllowUserToAddRows = false;
            this.dgvSurfaces.AllowUserToDeleteRows = false;
            this.dgvSurfaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSurfaces.AutoGenerateColumns = false;
            this.dgvSurfaces.BackgroundColor = System.Drawing.Color.White;
            this.dgvSurfaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSurfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurfaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surfaceCodeDataGridViewTextBoxColumn,
            this.surfaceNameDataGridViewTextBoxColumn,
            this.surfaceDescriptionDataGridViewTextBoxColumn,
            this.SurfaceTypeID});
            this.dgvSurfaces.DataSource = this.surfacesBindingSource;
            this.dgvSurfaces.Location = new System.Drawing.Point(18, 65);
            this.dgvSurfaces.Name = "dgvSurfaces";
            this.dgvSurfaces.RowHeadersWidth = 20;
            this.dgvSurfaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSurfaces.Size = new System.Drawing.Size(638, 346);
            this.dgvSurfaces.TabIndex = 10;
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 417);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 52);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_133_Icon_48;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(98, 417);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 52);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(557, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // surfaceTypesBindingSource
            // 
            this.surfaceTypesBindingSource.DataSource = typeof(FlameTradeSS.SurfaceTypes);
            // 
            // surfaceCodeDataGridViewTextBoxColumn
            // 
            this.surfaceCodeDataGridViewTextBoxColumn.DataPropertyName = "SurfaceCode";
            this.surfaceCodeDataGridViewTextBoxColumn.HeaderText = "Код на повърхност";
            this.surfaceCodeDataGridViewTextBoxColumn.Name = "surfaceCodeDataGridViewTextBoxColumn";
            this.surfaceCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // surfaceNameDataGridViewTextBoxColumn
            // 
            this.surfaceNameDataGridViewTextBoxColumn.DataPropertyName = "SurfaceName";
            this.surfaceNameDataGridViewTextBoxColumn.HeaderText = "Име на повърхност";
            this.surfaceNameDataGridViewTextBoxColumn.Name = "surfaceNameDataGridViewTextBoxColumn";
            this.surfaceNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // surfaceDescriptionDataGridViewTextBoxColumn
            // 
            this.surfaceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SurfaceDescription";
            this.surfaceDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание на повърхност";
            this.surfaceDescriptionDataGridViewTextBoxColumn.Name = "surfaceDescriptionDataGridViewTextBoxColumn";
            this.surfaceDescriptionDataGridViewTextBoxColumn.Width = 160;
            // 
            // SurfaceTypeID
            // 
            this.SurfaceTypeID.DataPropertyName = "SurfaceTypeID";
            this.SurfaceTypeID.DataSource = this.surfaceTypesBindingSource;
            this.SurfaceTypeID.DisplayMember = "TypeName";
            this.SurfaceTypeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SurfaceTypeID.HeaderText = "Тип на повърхност";
            this.SurfaceTypeID.Name = "SurfaceTypeID";
            this.SurfaceTypeID.ValueMember = "ID";
            this.SurfaceTypeID.Width = 150;
            // 
            // frmSurfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSurfaces);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSurfaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartnerGroups";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPartnerGroups_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPartnerGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSurfaces;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SurfaceTypeID;
        private System.Windows.Forms.BindingSource surfaceTypesBindingSource;
    }
}