namespace FlameTradeSS
{
    partial class frmSurfaceSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurfaceSelector));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvItemsSelector = new System.Windows.Forms.DataGridView();
            this.surfaceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbSurfaceTypes = new System.Windows.Forms.ComboBox();
            this.surfaceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(590, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 53);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.surfaceCodeDataGridViewTextBoxColumn,
            this.surfaceNameDataGridViewTextBoxColumn,
            this.surfaceDescriptionDataGridViewTextBoxColumn,
            this.surfaceTypeIDDataGridViewTextBoxColumn});
            this.dgvItemsSelector.DataSource = this.surfacesBindingSource;
            this.dgvItemsSelector.Location = new System.Drawing.Point(12, 116);
            this.dgvItemsSelector.MultiSelect = false;
            this.dgvItemsSelector.Name = "dgvItemsSelector";
            this.dgvItemsSelector.ReadOnly = true;
            this.dgvItemsSelector.RowHeadersWidth = 5;
            this.dgvItemsSelector.RowTemplate.Height = 30;
            this.dgvItemsSelector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsSelector.Size = new System.Drawing.Size(622, 218);
            this.dgvItemsSelector.TabIndex = 1;
            this.dgvItemsSelector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellDoubleClick);
            this.dgvItemsSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProjects_KeyDown);
            // 
            // surfaceTypesBindingSource
            // 
            this.surfaceTypesBindingSource.DataSource = typeof(FlameTradeSS.SurfaceTypes);
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(13, 66);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(621, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // cmbSurfaceTypes
            // 
            this.cmbSurfaceTypes.DataSource = this.surfaceTypesBindingSource;
            this.cmbSurfaceTypes.DisplayMember = "TypeName";
            this.cmbSurfaceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurfaceTypes.FormattingEnabled = true;
            this.cmbSurfaceTypes.Location = new System.Drawing.Point(482, 92);
            this.cmbSurfaceTypes.Name = "cmbSurfaceTypes";
            this.cmbSurfaceTypes.Size = new System.Drawing.Size(152, 21);
            this.cmbSurfaceTypes.TabIndex = 16;
            this.cmbSurfaceTypes.ValueMember = "ID";
            this.cmbSurfaceTypes.SelectedIndexChanged += new System.EventHandler(this.cmbSurfaceTypes_SelectedIndexChanged);
            // 
            // surfaceCodeDataGridViewTextBoxColumn
            // 
            this.surfaceCodeDataGridViewTextBoxColumn.DataPropertyName = "SurfaceCode";
            this.surfaceCodeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.surfaceCodeDataGridViewTextBoxColumn.Name = "surfaceCodeDataGridViewTextBoxColumn";
            this.surfaceCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surfaceNameDataGridViewTextBoxColumn
            // 
            this.surfaceNameDataGridViewTextBoxColumn.DataPropertyName = "SurfaceName";
            this.surfaceNameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.surfaceNameDataGridViewTextBoxColumn.Name = "surfaceNameDataGridViewTextBoxColumn";
            this.surfaceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // surfaceDescriptionDataGridViewTextBoxColumn
            // 
            this.surfaceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SurfaceDescription";
            this.surfaceDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.surfaceDescriptionDataGridViewTextBoxColumn.Name = "surfaceDescriptionDataGridViewTextBoxColumn";
            this.surfaceDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // surfaceTypeIDDataGridViewTextBoxColumn
            // 
            this.surfaceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "SurfaceTypeID";
            this.surfaceTypeIDDataGridViewTextBoxColumn.DataSource = this.surfaceTypesBindingSource;
            this.surfaceTypeIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.surfaceTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.surfaceTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.surfaceTypeIDDataGridViewTextBoxColumn.Name = "surfaceTypeIDDataGridViewTextBoxColumn";
            this.surfaceTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surfaceTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.surfaceTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.surfaceTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmSurfaceSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 346);
            this.Controls.Add(this.cmbSurfaceTypes);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvItemsSelector);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSurfaceSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProjectSelector";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProjectSelector_Load);
            this.Shown += new System.EventHandler(this.frmItemSelector_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmProjectSelector_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.DataGridView dgvItemsSelector;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.ComboBox cmbSurfaceTypes;
        private System.Windows.Forms.BindingSource surfaceTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn surfaceTypeIDDataGridViewTextBoxColumn;
    }
}