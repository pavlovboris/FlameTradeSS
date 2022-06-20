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
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(13, 13);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 23);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(13, 42);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(75, 23);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnFunctions
            // 
            this.btnFunctions.Location = new System.Drawing.Point(13, 114);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(75, 23);
            this.btnFunctions.TabIndex = 2;
            this.btnFunctions.Text = "Restrictions";
            this.btnFunctions.UseVisualStyleBackColor = true;
            this.btnFunctions.Click += new System.EventHandler(this.btnFunctions_Click);
            // 
            // btnFunctionRoles
            // 
            this.btnFunctionRoles.Location = new System.Drawing.Point(13, 71);
            this.btnFunctionRoles.Name = "btnFunctionRoles";
            this.btnFunctionRoles.Size = new System.Drawing.Size(75, 37);
            this.btnFunctionRoles.TabIndex = 3;
            this.btnFunctionRoles.Text = "Roles Restrictions";
            this.btnFunctionRoles.UseVisualStyleBackColor = true;
            // 
            // frmAdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 316);
            this.Controls.Add(this.btnFunctionRoles);
            this.Controls.Add(this.btnFunctions);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnUsers);
            this.Name = "frmAdminTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnFunctions;
        private System.Windows.Forms.Button btnFunctionRoles;
    }
}