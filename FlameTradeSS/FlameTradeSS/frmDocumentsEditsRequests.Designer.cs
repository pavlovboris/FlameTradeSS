namespace FlameTradeSS
{
    partial class frmDocumentsEditsRequests
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.checkBoxRequestNow = new System.Windows.Forms.CheckBox();
            this.cmbRequestToRole = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(209, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(12, 32);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(251, 73);
            this.txtReason.TabIndex = 2;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(13, 13);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(122, 13);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Причина за редакция :";
            // 
            // checkBoxRequestNow
            // 
            this.checkBoxRequestNow.AutoSize = true;
            this.checkBoxRequestNow.Location = new System.Drawing.Point(13, 125);
            this.checkBoxRequestNow.Name = "checkBoxRequestNow";
            this.checkBoxRequestNow.Size = new System.Drawing.Size(121, 17);
            this.checkBoxRequestNow.TabIndex = 4;
            this.checkBoxRequestNow.Text = "Незабавно искане";
            this.checkBoxRequestNow.UseVisualStyleBackColor = true;
            this.checkBoxRequestNow.Visible = false;
            this.checkBoxRequestNow.CheckedChanged += new System.EventHandler(this.checkBoxRequestNow_CheckedChanged);
            this.checkBoxRequestNow.VisibleChanged += new System.EventHandler(this.checkBoxRequestNow_VisibleChanged);
            // 
            // cmbRequestToRole
            // 
            this.cmbRequestToRole.DataSource = this.rolesBindingSource;
            this.cmbRequestToRole.DisplayMember = "RoleName";
            this.cmbRequestToRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestToRole.FormattingEnabled = true;
            this.cmbRequestToRole.Location = new System.Drawing.Point(141, 125);
            this.cmbRequestToRole.Name = "cmbRequestToRole";
            this.cmbRequestToRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRequestToRole.TabIndex = 5;
            this.cmbRequestToRole.ValueMember = "RoleID";
            this.cmbRequestToRole.Visible = false;
            this.cmbRequestToRole.SelectedIndexChanged += new System.EventHandler(this.cmbRequestToRole_SelectedIndexChanged);
            this.cmbRequestToRole.VisibleChanged += new System.EventHandler(this.cmbRequestToRole_VisibleChanged);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(FlameTradeSS.Roles);
            // 
            // frmDocumentsEditsRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 189);
            this.Controls.Add(this.cmbRequestToRole);
            this.Controls.Add(this.checkBoxRequestNow);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(292, 228);
            this.Name = "frmDocumentsEditsRequests";
            this.Text = "Искане за редакция на документ";
            this.Load += new System.EventHandler(this.frmDocumentsEditsRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.CheckBox checkBoxRequestNow;
        private System.Windows.Forms.ComboBox cmbRequestToRole;
        private System.Windows.Forms.BindingSource rolesBindingSource;
    }
}