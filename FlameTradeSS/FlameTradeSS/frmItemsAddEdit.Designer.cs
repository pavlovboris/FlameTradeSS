namespace FlameTradeSS
{
    partial class frmItemsAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsAddEdit));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSecondCode = new System.Windows.Forms.TextBox();
            this.lblSecondCode = new System.Windows.Forms.Label();
            this.txtForeignID = new System.Windows.Forms.TextBox();
            this.lblForeignID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbMu = new System.Windows.Forms.ComboBox();
            this.muBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDefaultMu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(578, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 49);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_045_Icon_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(528, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(24, 58);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(144, 13);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "Код - трябва да е уникален";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(27, 75);
            this.txtCode.MaxLength = 250;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(191, 20);
            this.txtCode.TabIndex = 16;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(FlameTradeSS.Items);
            // 
            // txtSecondCode
            // 
            this.txtSecondCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "SecondCode", true));
            this.txtSecondCode.Location = new System.Drawing.Point(224, 74);
            this.txtSecondCode.MaxLength = 250;
            this.txtSecondCode.Name = "txtSecondCode";
            this.txtSecondCode.Size = new System.Drawing.Size(185, 20);
            this.txtSecondCode.TabIndex = 18;
            // 
            // lblSecondCode
            // 
            this.lblSecondCode.AutoSize = true;
            this.lblSecondCode.Location = new System.Drawing.Point(221, 57);
            this.lblSecondCode.Name = "lblSecondCode";
            this.lblSecondCode.Size = new System.Drawing.Size(188, 13);
            this.lblSecondCode.TabIndex = 17;
            this.lblSecondCode.Text = "Втори Код - може да остане празен";
            // 
            // txtForeignID
            // 
            this.txtForeignID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ForeignItemID", true));
            this.txtForeignID.Location = new System.Drawing.Point(415, 75);
            this.txtForeignID.MaxLength = 100;
            this.txtForeignID.Name = "txtForeignID";
            this.txtForeignID.Size = new System.Drawing.Size(206, 20);
            this.txtForeignID.TabIndex = 20;
            // 
            // lblForeignID
            // 
            this.lblForeignID.AutoSize = true;
            this.lblForeignID.Location = new System.Drawing.Point(412, 58);
            this.lblForeignID.Name = "lblForeignID";
            this.lblForeignID.Size = new System.Drawing.Size(209, 13);
            this.lblForeignID.TabIndex = 19;
            this.lblForeignID.Text = "Отдалечен ИН - може да остане празен";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 102);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(57, 13);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(27, 118);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(382, 20);
            this.txtDescription.TabIndex = 22;
            // 
            // cmbMu
            // 
            this.cmbMu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "DefaultMu", true));
            this.cmbMu.DataSource = this.muBindingSource;
            this.cmbMu.DisplayMember = "Name";
            this.cmbMu.FormattingEnabled = true;
            this.cmbMu.Location = new System.Drawing.Point(27, 178);
            this.cmbMu.Name = "cmbMu";
            this.cmbMu.Size = new System.Drawing.Size(176, 21);
            this.cmbMu.TabIndex = 23;
            this.cmbMu.ValueMember = "ID";
            // 
            // muBindingSource
            // 
            this.muBindingSource.DataSource = typeof(FlameTradeSS.Mu);
            // 
            // lblDefaultMu
            // 
            this.lblDefaultMu.AutoSize = true;
            this.lblDefaultMu.Location = new System.Drawing.Point(27, 159);
            this.lblDefaultMu.Name = "lblDefaultMu";
            this.lblDefaultMu.Size = new System.Drawing.Size(176, 13);
            this.lblDefaultMu.TabIndex = 24;
            this.lblDefaultMu.Text = "Мерна Единица по подразбиране";
            // 
            // frmItemsAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblDefaultMu);
            this.Controls.Add(this.cmbMu);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtForeignID);
            this.Controls.Add(this.lblForeignID);
            this.Controls.Add(this.txtSecondCode);
            this.Controls.Add(this.lblSecondCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemsAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItemsAddEdit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmItemsAddEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmItemsAddEdit_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TextBox txtSecondCode;
        private System.Windows.Forms.Label lblSecondCode;
        private System.Windows.Forms.TextBox txtForeignID;
        private System.Windows.Forms.Label lblForeignID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbMu;
        private System.Windows.Forms.BindingSource muBindingSource;
        private System.Windows.Forms.Label lblDefaultMu;
    }
}