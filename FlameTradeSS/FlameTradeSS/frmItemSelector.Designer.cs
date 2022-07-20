namespace FlameTradeSS
{
    partial class frmItemSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemSelector));
            this.dgvItemsSelector = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btmProjectAdd = new System.Windows.Forms.Button();
            this.ItemCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PictureData = new System.Windows.Forms.DataGridViewImageColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemsSelector
            // 
            this.dgvItemsSelector.AllowUserToAddRows = false;
            this.dgvItemsSelector.AllowUserToDeleteRows = false;
            this.dgvItemsSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemsSelector.AutoGenerateColumns = false;
            this.dgvItemsSelector.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemsSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemsSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsSelector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.itemsGroupIDDataGridViewTextBoxColumn,
            this.ItemCategory,
            this.secondCodeDataGridViewTextBoxColumn,
            this.PictureData});
            this.dgvItemsSelector.DataSource = this.itemsBindingSource;
            this.dgvItemsSelector.Location = new System.Drawing.Point(12, 41);
            this.dgvItemsSelector.MultiSelect = false;
            this.dgvItemsSelector.Name = "dgvItemsSelector";
            this.dgvItemsSelector.ReadOnly = true;
            this.dgvItemsSelector.RowHeadersWidth = 20;
            this.dgvItemsSelector.RowTemplate.Height = 40;
            this.dgvItemsSelector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsSelector.Size = new System.Drawing.Size(623, 220);
            this.dgvItemsSelector.TabIndex = 1;
            this.dgvItemsSelector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellDoubleClick);
            this.dgvItemsSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProjects_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(13, 10);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(622, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // btmProjectAdd
            // 
            this.btmProjectAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmProjectAdd.BackColor = System.Drawing.Color.White;
            this.btmProjectAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmProjectAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmProjectAdd.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btmProjectAdd.Location = new System.Drawing.Point(-85, 7);
            this.btmProjectAdd.Name = "btmProjectAdd";
            this.btmProjectAdd.Size = new System.Drawing.Size(49, 53);
            this.btmProjectAdd.TabIndex = 15;
            this.btmProjectAdd.UseVisualStyleBackColor = false;
            this.btmProjectAdd.Click += new System.EventHandler(this.btmProjectAdd_Click);
            // 
            // ItemCategory
            // 
            this.ItemCategory.DataPropertyName = "ItemCategory";
            this.ItemCategory.DataSource = this.itemCategoryBindingSource;
            this.ItemCategory.DisplayMember = "CategoryName";
            this.ItemCategory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemCategory.HeaderText = "ItemCategory";
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.ReadOnly = true;
            this.ItemCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemCategory.ValueMember = "ID";
            // 
            // PictureData
            // 
            this.PictureData.DataPropertyName = "PictureData";
            this.PictureData.HeaderText = "PictureData";
            this.PictureData.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.PictureData.Name = "PictureData";
            this.PictureData.ReadOnly = true;
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
            // itemsGroupsBindingSource
            // 
            this.itemsGroupsBindingSource.DataSource = typeof(FlameTradeSS.ItemsGroups);
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(FlameTradeSS.ItemCategory);
            // 
            // secondCodeDataGridViewTextBoxColumn
            // 
            this.secondCodeDataGridViewTextBoxColumn.DataPropertyName = "SecondCode";
            this.secondCodeDataGridViewTextBoxColumn.HeaderText = "SecondCode";
            this.secondCodeDataGridViewTextBoxColumn.Name = "secondCodeDataGridViewTextBoxColumn";
            this.secondCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // frmItemSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 273);
            this.Controls.Add(this.btmProjectAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvItemsSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Избор на Артикул";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProjectSelector_Load);
            this.Shown += new System.EventHandler(this.frmItemSelector_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmProjectSelector_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvItemsSelector;
        private System.Windows.Forms.Button btmProjectAdd;
        private System.Windows.Forms.BindingSource itemsGroupsBindingSource;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        public System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn PictureData;
    }
}