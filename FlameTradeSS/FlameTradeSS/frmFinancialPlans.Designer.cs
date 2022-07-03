namespace FlameTradeSS
{
    partial class frmFinancialPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialPlans));
            this.btnClose = new System.Windows.Forms.Button();
            this.panelFlowPanel = new System.Windows.Forms.Panel();
            this.financialPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMainPanel = new System.Windows.Forms.Panel();
            this.txtCurrentRealValue = new System.Windows.Forms.TextBox();
            this.txtCurrentBudgetValue = new System.Windows.Forms.TextBox();
            this.txtCurrentOfferValue = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.dateTimeCreationDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.txtFinancialPlanID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.financialPlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.panelMainPanel.SuspendLayout();
            this.SuspendLayout();
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
            // panelFlowPanel
            // 
            this.panelFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFlowPanel.AutoScroll = true;
            this.panelFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFlowPanel.Location = new System.Drawing.Point(12, 201);
            this.panelFlowPanel.Name = "panelFlowPanel";
            this.panelFlowPanel.Size = new System.Drawing.Size(1163, 512);
            this.panelFlowPanel.TabIndex = 28;
            // 
            // financialPlansBindingSource
            // 
            this.financialPlansBindingSource.DataSource = typeof(FlameTradeSS.FinancialPlans);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(FlameTradeSS.Project);
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.Controls.Add(this.txtCurrentRealValue);
            this.panelMainPanel.Controls.Add(this.txtCurrentBudgetValue);
            this.panelMainPanel.Controls.Add(this.txtCurrentOfferValue);
            this.panelMainPanel.Controls.Add(this.txtComment);
            this.panelMainPanel.Controls.Add(this.dateTimeCreationDate);
            this.panelMainPanel.Controls.Add(this.cmbProject);
            this.panelMainPanel.Controls.Add(this.txtFinancialPlanID);
            this.panelMainPanel.Controls.Add(this.button1);
            this.panelMainPanel.Location = new System.Drawing.Point(14, 95);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.Size = new System.Drawing.Size(1161, 100);
            this.panelMainPanel.TabIndex = 29;
            // 
            // txtCurrentRealValue
            // 
            this.txtCurrentRealValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialPlansBindingSource, "CurrentRealValue", true));
            this.txtCurrentRealValue.Location = new System.Drawing.Point(961, 13);
            this.txtCurrentRealValue.Name = "txtCurrentRealValue";
            this.txtCurrentRealValue.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentRealValue.TabIndex = 7;
            // 
            // txtCurrentBudgetValue
            // 
            this.txtCurrentBudgetValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialPlansBindingSource, "CurrentBudgetValue", true));
            this.txtCurrentBudgetValue.Location = new System.Drawing.Point(855, 13);
            this.txtCurrentBudgetValue.Name = "txtCurrentBudgetValue";
            this.txtCurrentBudgetValue.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentBudgetValue.TabIndex = 6;
            // 
            // txtCurrentOfferValue
            // 
            this.txtCurrentOfferValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialPlansBindingSource, "CurrentOfferValue", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtCurrentOfferValue.Location = new System.Drawing.Point(749, 12);
            this.txtCurrentOfferValue.Name = "txtCurrentOfferValue";
            this.txtCurrentOfferValue.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentOfferValue.TabIndex = 5;
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialPlansBindingSource, "Comment", true));
            this.txtComment.Location = new System.Drawing.Point(371, 12);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(371, 20);
            this.txtComment.TabIndex = 4;
            // 
            // dateTimeCreationDate
            // 
            this.dateTimeCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCreationDate.Location = new System.Drawing.Point(262, 13);
            this.dateTimeCreationDate.Name = "dateTimeCreationDate";
            this.dateTimeCreationDate.Size = new System.Drawing.Size(102, 20);
            this.dateTimeCreationDate.TabIndex = 3;
            // 
            // cmbProject
            // 
            this.cmbProject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.financialPlansBindingSource, "ProjectID", true));
            this.cmbProject.DataSource = this.projectBindingSource;
            this.cmbProject.DisplayMember = "ProjectName";
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(135, 12);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(121, 21);
            this.cmbProject.TabIndex = 2;
            this.cmbProject.ValueMember = "ID";
            // 
            // txtFinancialPlanID
            // 
            this.txtFinancialPlanID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialPlansBindingSource, "ID", true));
            this.txtFinancialPlanID.Enabled = false;
            this.txtFinancialPlanID.Location = new System.Drawing.Point(3, 12);
            this.txtFinancialPlanID.Name = "txtFinancialPlanID";
            this.txtFinancialPlanID.Size = new System.Drawing.Size(126, 20);
            this.txtFinancialPlanID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // frmFinancialPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 725);
            this.Controls.Add(this.panelMainPanel);
            this.Controls.Add(this.panelFlowPanel);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancialPlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocuments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocuments_FormClosing);
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialPlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.panelMainPanel.ResumeLayout(false);
            this.panelMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Panel panelFlowPanel;
        private System.Windows.Forms.BindingSource projectBindingSource;
        public System.Windows.Forms.BindingSource financialPlansBindingSource;
        private System.Windows.Forms.Panel panelMainPanel;
        private System.Windows.Forms.TextBox txtCurrentRealValue;
        private System.Windows.Forms.TextBox txtCurrentBudgetValue;
        private System.Windows.Forms.TextBox txtCurrentOfferValue;
        private System.Windows.Forms.TextBox txtComment;
        public System.Windows.Forms.DateTimePicker dateTimeCreationDate;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.TextBox txtFinancialPlanID;
        private System.Windows.Forms.Button button1;
    }
}