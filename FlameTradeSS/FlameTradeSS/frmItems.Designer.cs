namespace FlameTradeSS
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.muBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIsInactive = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.itemCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultMuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.defaultPartitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.defaultSurfaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isInactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.defaultSupplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.staticWeigthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staticSurfaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staticHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staticWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staticLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreignItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_48;
            this.btnMinimize.Location = new System.Drawing.Point(1021, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 48);
            this.btnMinimize.TabIndex = 28;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnMaximize.Location = new System.Drawing.Point(1076, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(49, 48);
            this.btnMaximize.TabIndex = 27;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1131, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.secondCodeDataGridViewTextBoxColumn,
            this.defaultMuDataGridViewTextBoxColumn,
            this.defaultPartitionDataGridViewTextBoxColumn,
            this.itemsGroupIDDataGridViewTextBoxColumn,
            this.itemCategoryDataGridViewTextBoxColumn,
            this.defaultSurfaceIDDataGridViewTextBoxColumn,
            this.isInactiveDataGridViewTextBoxColumn,
            this.defaultSupplierIDDataGridViewTextBoxColumn,
            this.staticWeigthDataGridViewTextBoxColumn,
            this.staticSurfaceDataGridViewTextBoxColumn,
            this.staticHeightDataGridViewTextBoxColumn,
            this.staticWidthDataGridViewTextBoxColumn,
            this.staticLengthDataGridViewTextBoxColumn,
            this.foreignItemIDDataGridViewTextBoxColumn});
            this.dgvItems.DataSource = this.itemsBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(12, 135);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 20;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1163, 578);
            this.dgvItems.TabIndex = 29;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellDoubleClick);
            this.dgvItems.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDocuments_ColumnDisplayIndexChanged);
            this.dgvItems.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDocuments_ColumnWidthChanged);
            this.dgvItems.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvDocuments_Scroll);
            // 
            // muBindingSource
            // 
            this.muBindingSource.DataSource = typeof(FlameTradeSS.Mu);
            // 
            // partitionsBindingSource
            // 
            this.partitionsBindingSource.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // itemsGroupsBindingSource
            // 
            this.itemsGroupsBindingSource.DataSource = typeof(FlameTradeSS.ItemsGroups);
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(FlameTradeSS.ItemCategory);
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // cmbIsInactive
            // 
            this.cmbIsInactive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsInactive.FormattingEnabled = true;
            this.cmbIsInactive.Items.AddRange(new object[] {
            "Не",
            "Да",
            "Всички"});
            this.cmbIsInactive.Location = new System.Drawing.Point(932, 108);
            this.cmbIsInactive.Name = "cmbIsInactive";
            this.cmbIsInactive.Size = new System.Drawing.Size(99, 21);
            this.cmbIsInactive.TabIndex = 30;
            this.cmbIsInactive.SelectedIndexChanged += new System.EventHandler(this.cmbIsCanceled_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 66);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(594, 20);
            this.txtFilter.TabIndex = 31;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.itemCategoryBindingSource1;
            this.cmbCategory.DisplayMember = "CategoryName";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(635, 108);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(95, 21);
            this.cmbCategory.TabIndex = 32;
            this.cmbCategory.ValueMember = "ID";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSequence_SelectedIndexChanged);
            // 
            // itemCategoryBindingSource1
            // 
            this.itemCategoryBindingSource1.DataSource = typeof(FlameTradeSS.ItemCategory);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondCodeDataGridViewTextBoxColumn
            // 
            this.secondCodeDataGridViewTextBoxColumn.DataPropertyName = "SecondCode";
            this.secondCodeDataGridViewTextBoxColumn.HeaderText = "SecondCode";
            this.secondCodeDataGridViewTextBoxColumn.Name = "secondCodeDataGridViewTextBoxColumn";
            this.secondCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultMuDataGridViewTextBoxColumn
            // 
            this.defaultMuDataGridViewTextBoxColumn.DataPropertyName = "DefaultMu";
            this.defaultMuDataGridViewTextBoxColumn.DataSource = this.muBindingSource;
            this.defaultMuDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.defaultMuDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultMuDataGridViewTextBoxColumn.HeaderText = "DefaultMu";
            this.defaultMuDataGridViewTextBoxColumn.Name = "defaultMuDataGridViewTextBoxColumn";
            this.defaultMuDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultMuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultMuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultMuDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // defaultPartitionDataGridViewTextBoxColumn
            // 
            this.defaultPartitionDataGridViewTextBoxColumn.DataPropertyName = "DefaultPartition";
            this.defaultPartitionDataGridViewTextBoxColumn.DataSource = this.partitionsBindingSource;
            this.defaultPartitionDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.defaultPartitionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultPartitionDataGridViewTextBoxColumn.HeaderText = "DefaultPartition";
            this.defaultPartitionDataGridViewTextBoxColumn.Name = "defaultPartitionDataGridViewTextBoxColumn";
            this.defaultPartitionDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultPartitionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultPartitionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultPartitionDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // itemsGroupIDDataGridViewTextBoxColumn
            // 
            this.itemsGroupIDDataGridViewTextBoxColumn.DataPropertyName = "ItemsGroupID";
            this.itemsGroupIDDataGridViewTextBoxColumn.DataSource = this.itemsGroupsBindingSource;
            this.itemsGroupIDDataGridViewTextBoxColumn.DisplayMember = "GroupName";
            this.itemsGroupIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemsGroupIDDataGridViewTextBoxColumn.HeaderText = "ItemsGroupID";
            this.itemsGroupIDDataGridViewTextBoxColumn.Name = "itemsGroupIDDataGridViewTextBoxColumn";
            this.itemsGroupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemsGroupIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGroupIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemsGroupIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // itemCategoryDataGridViewTextBoxColumn
            // 
            this.itemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory";
            this.itemCategoryDataGridViewTextBoxColumn.DataSource = this.itemCategoryBindingSource;
            this.itemCategoryDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            this.itemCategoryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemCategoryDataGridViewTextBoxColumn.HeaderText = "ItemCategory";
            this.itemCategoryDataGridViewTextBoxColumn.Name = "itemCategoryDataGridViewTextBoxColumn";
            this.itemCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemCategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemCategoryDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // defaultSurfaceIDDataGridViewTextBoxColumn
            // 
            this.defaultSurfaceIDDataGridViewTextBoxColumn.DataPropertyName = "DefaultSurfaceID";
            this.defaultSurfaceIDDataGridViewTextBoxColumn.DataSource = this.surfacesBindingSource;
            this.defaultSurfaceIDDataGridViewTextBoxColumn.DisplayMember = "SurfaceName";
            this.defaultSurfaceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultSurfaceIDDataGridViewTextBoxColumn.HeaderText = "DefaultSurfaceID";
            this.defaultSurfaceIDDataGridViewTextBoxColumn.Name = "defaultSurfaceIDDataGridViewTextBoxColumn";
            this.defaultSurfaceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultSurfaceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultSurfaceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultSurfaceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // isInactiveDataGridViewTextBoxColumn
            // 
            this.isInactiveDataGridViewTextBoxColumn.DataPropertyName = "IsInactive";
            this.isInactiveDataGridViewTextBoxColumn.FalseValue = "0";
            this.isInactiveDataGridViewTextBoxColumn.HeaderText = "IsInactive";
            this.isInactiveDataGridViewTextBoxColumn.Name = "isInactiveDataGridViewTextBoxColumn";
            this.isInactiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isInactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isInactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isInactiveDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // defaultSupplierIDDataGridViewTextBoxColumn
            // 
            this.defaultSupplierIDDataGridViewTextBoxColumn.DataPropertyName = "DefaultSupplierID";
            this.defaultSupplierIDDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource;
            this.defaultSupplierIDDataGridViewTextBoxColumn.DisplayMember = "Partner_name";
            this.defaultSupplierIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultSupplierIDDataGridViewTextBoxColumn.HeaderText = "DefaultSupplierID";
            this.defaultSupplierIDDataGridViewTextBoxColumn.Name = "defaultSupplierIDDataGridViewTextBoxColumn";
            this.defaultSupplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultSupplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultSupplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultSupplierIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // staticWeigthDataGridViewTextBoxColumn
            // 
            this.staticWeigthDataGridViewTextBoxColumn.DataPropertyName = "StaticWeigth";
            this.staticWeigthDataGridViewTextBoxColumn.HeaderText = "StaticWeigth";
            this.staticWeigthDataGridViewTextBoxColumn.Name = "staticWeigthDataGridViewTextBoxColumn";
            this.staticWeigthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staticSurfaceDataGridViewTextBoxColumn
            // 
            this.staticSurfaceDataGridViewTextBoxColumn.DataPropertyName = "StaticSurface";
            this.staticSurfaceDataGridViewTextBoxColumn.HeaderText = "StaticSurface";
            this.staticSurfaceDataGridViewTextBoxColumn.Name = "staticSurfaceDataGridViewTextBoxColumn";
            this.staticSurfaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staticHeightDataGridViewTextBoxColumn
            // 
            this.staticHeightDataGridViewTextBoxColumn.DataPropertyName = "StaticHeight";
            this.staticHeightDataGridViewTextBoxColumn.HeaderText = "StaticHeight";
            this.staticHeightDataGridViewTextBoxColumn.Name = "staticHeightDataGridViewTextBoxColumn";
            this.staticHeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staticWidthDataGridViewTextBoxColumn
            // 
            this.staticWidthDataGridViewTextBoxColumn.DataPropertyName = "StaticWidth";
            this.staticWidthDataGridViewTextBoxColumn.HeaderText = "StaticWidth";
            this.staticWidthDataGridViewTextBoxColumn.Name = "staticWidthDataGridViewTextBoxColumn";
            this.staticWidthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staticLengthDataGridViewTextBoxColumn
            // 
            this.staticLengthDataGridViewTextBoxColumn.DataPropertyName = "StaticLength";
            this.staticLengthDataGridViewTextBoxColumn.HeaderText = "StaticLength";
            this.staticLengthDataGridViewTextBoxColumn.Name = "staticLengthDataGridViewTextBoxColumn";
            this.staticLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foreignItemIDDataGridViewTextBoxColumn
            // 
            this.foreignItemIDDataGridViewTextBoxColumn.DataPropertyName = "ForeignItemID";
            this.foreignItemIDDataGridViewTextBoxColumn.HeaderText = "ForeignItemID";
            this.foreignItemIDDataGridViewTextBoxColumn.Name = "foreignItemIDDataGridViewTextBoxColumn";
            this.foreignItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 725);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbIsInactive);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocuments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocuments_FormClosing);
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            this.SizeChanged += new System.EventHandler(this.frmDocuments_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ComboBox cmbIsInactive;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource muBindingSource;
        private System.Windows.Forms.BindingSource partitionsBindingSource;
        private System.Windows.Forms.BindingSource itemsGroupsBindingSource;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultMuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultPartitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultSurfaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultSupplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticWeigthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticSurfaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreignItemIDDataGridViewTextBoxColumn;
    }
}