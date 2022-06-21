namespace FlameTradeSS
{
    partial class frmAdminTools
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnFunctions = new System.Windows.Forms.Button();
            this.btnFunctionRoles = new System.Windows.Forms.Button();
            this.grpBoxUsers = new System.Windows.Forms.GroupBox();
            this.grpBoxPersons = new System.Windows.Forms.GroupBox();
            this.btnPersons = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxUsers.SuspendLayout();
            this.grpBoxPersons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(17, 36);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 23);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Location = new System.Drawing.Point(17, 65);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(75, 23);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnFunctions
            // 
            this.btnFunctions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFunctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunctions.Location = new System.Drawing.Point(17, 137);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(75, 23);
            this.btnFunctions.TabIndex = 2;
            this.btnFunctions.Text = "Restrictions";
            this.btnFunctions.UseVisualStyleBackColor = true;
            this.btnFunctions.Click += new System.EventHandler(this.btnFunctions_Click);
            // 
            // btnFunctionRoles
            // 
            this.btnFunctionRoles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFunctionRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunctionRoles.Location = new System.Drawing.Point(17, 94);
            this.btnFunctionRoles.Name = "btnFunctionRoles";
            this.btnFunctionRoles.Size = new System.Drawing.Size(75, 37);
            this.btnFunctionRoles.TabIndex = 3;
            this.btnFunctionRoles.Text = "Roles Restrictions";
            this.btnFunctionRoles.UseVisualStyleBackColor = true;
            this.btnFunctionRoles.Click += new System.EventHandler(this.btnFunctionRoles_Click);
            // 
            // grpBoxUsers
            // 
            this.grpBoxUsers.Controls.Add(this.btnFunctionRoles);
            this.grpBoxUsers.Controls.Add(this.btnUsers);
            this.grpBoxUsers.Controls.Add(this.btnFunctions);
            this.grpBoxUsers.Controls.Add(this.btnRoles);
            this.grpBoxUsers.Location = new System.Drawing.Point(13, 13);
            this.grpBoxUsers.Name = "grpBoxUsers";
            this.grpBoxUsers.Size = new System.Drawing.Size(122, 291);
            this.grpBoxUsers.TabIndex = 4;
            this.grpBoxUsers.TabStop = false;
            this.grpBoxUsers.Text = "Users";
            // 
            // grpBoxPersons
            // 
            this.grpBoxPersons.Controls.Add(this.btnPersons);
            this.grpBoxPersons.Location = new System.Drawing.Point(155, 13);
            this.grpBoxPersons.Name = "grpBoxPersons";
            this.grpBoxPersons.Size = new System.Drawing.Size(122, 291);
            this.grpBoxPersons.TabIndex = 5;
            this.grpBoxPersons.TabStop = false;
            this.grpBoxPersons.Text = "Persons";
            // 
            // btnPersons
            // 
            this.btnPersons.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersons.Location = new System.Drawing.Point(24, 36);
            this.btnPersons.Name = "btnPersons";
            this.btnPersons.Size = new System.Drawing.Size(75, 23);
            this.btnPersons.TabIndex = 4;
            this.btnPersons.Text = "Persons";
            this.btnPersons.UseVisualStyleBackColor = true;
            this.btnPersons.Click += new System.EventHandler(this.btnPersons_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_48;
            this.btnMinimize.Location = new System.Drawing.Point(572, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 43);
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
            this.btnMaximize.Location = new System.Drawing.Point(627, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(49, 43);
            this.btnMaximize.TabIndex = 27;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(682, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 43);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 316);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.grpBoxPersons);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBoxUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.frmAdminTools_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdminTools_Paint);
            this.grpBoxUsers.ResumeLayout(false);
            this.grpBoxPersons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnFunctions;
        private System.Windows.Forms.Button btnFunctionRoles;
        private System.Windows.Forms.GroupBox grpBoxUsers;
        private System.Windows.Forms.GroupBox grpBoxPersons;
        private System.Windows.Forms.Button btnPersons;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}