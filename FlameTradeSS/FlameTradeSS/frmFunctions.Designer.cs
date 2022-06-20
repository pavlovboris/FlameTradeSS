namespace FlameTradeSS
{
    partial class frmFunctions
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
            this.dgvFunctions = new System.Windows.Forms.DataGridView();
            this.functionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.controllNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.controlActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.functionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunctions
            // 
            this.dgvFunctions.AllowUserToAddRows = false;
            this.dgvFunctions.AllowUserToDeleteRows = false;
            this.dgvFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFunctions.AutoGenerateColumns = false;
            this.dgvFunctions.BackgroundColor = System.Drawing.Color.White;
            this.dgvFunctions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFunctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionNameDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.controllNameDataGridViewTextBoxColumn,
            this.controlActionDataGridViewTextBoxColumn});
            this.dgvFunctions.DataSource = this.functionsBindingSource;
            this.dgvFunctions.Location = new System.Drawing.Point(13, 13);
            this.dgvFunctions.Name = "dgvFunctions";
            this.dgvFunctions.RowHeadersWidth = 20;
            this.dgvFunctions.Size = new System.Drawing.Size(522, 362);
            this.dgvFunctions.TabIndex = 0;
            // 
            // functionNameDataGridViewTextBoxColumn
            // 
            this.functionNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.HeaderText = "Restriction Name";
            this.functionNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.functionNameDataGridViewTextBoxColumn.Name = "functionNameDataGridViewTextBoxColumn";
            this.functionNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // formNameDataGridViewTextBoxColumn
            // 
            this.formNameDataGridViewTextBoxColumn.DataPropertyName = "FormName";
            this.formNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.formNameDataGridViewTextBoxColumn.HeaderText = "Form Name";
            this.formNameDataGridViewTextBoxColumn.Name = "formNameDataGridViewTextBoxColumn";
            this.formNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // controllNameDataGridViewTextBoxColumn
            // 
            this.controllNameDataGridViewTextBoxColumn.DataPropertyName = "ControllName";
            this.controllNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.controllNameDataGridViewTextBoxColumn.HeaderText = "Control Name";
            this.controllNameDataGridViewTextBoxColumn.Name = "controllNameDataGridViewTextBoxColumn";
            this.controllNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.controllNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // controlActionDataGridViewTextBoxColumn
            // 
            this.controlActionDataGridViewTextBoxColumn.DataPropertyName = "ControlAction";
            this.controlActionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.controlActionDataGridViewTextBoxColumn.HeaderText = "Control Action";
            this.controlActionDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Disable",
            "Remove"});
            this.controlActionDataGridViewTextBoxColumn.Name = "controlActionDataGridViewTextBoxColumn";
            this.controlActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.controlActionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // functionsBindingSource
            // 
            this.functionsBindingSource.DataSource = typeof(FlameTradeSS.Functions);
            // 
            // frmFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.dgvFunctions);
            this.Name = "frmFunctions";
            this.Text = "Restrictions";
            this.Load += new System.EventHandler(this.frmFunctions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunctions;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn controllNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn controlActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource functionsBindingSource;
    }
}