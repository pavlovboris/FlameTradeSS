namespace FlameTradeSS
{
    partial class frmMain
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
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.lblCurentUserLabel = new System.Windows.Forms.Label();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
            this.btnAdminTools = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExit.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.pictureBoxExit.Location = new System.Drawing.Point(969, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(60, 49);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 16;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // lblCurentUserLabel
            // 
            this.lblCurentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurentUserLabel.AutoSize = true;
            this.lblCurentUserLabel.Location = new System.Drawing.Point(13, 514);
            this.lblCurentUserLabel.Name = "lblCurentUserLabel";
            this.lblCurentUserLabel.Size = new System.Drawing.Size(72, 13);
            this.lblCurentUserLabel.TabIndex = 17;
            this.lblCurentUserLabel.Text = "Current User :";
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(84, 514);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentUserName.TabIndex = 18;
            this.lblCurrentUserName.Text = "?";
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_256;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(847, 0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(60, 49);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 19;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxMaximize
            // 
            this.pictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_256;
            this.pictureBoxMaximize.Location = new System.Drawing.Point(908, 0);
            this.pictureBoxMaximize.Name = "pictureBoxMaximize";
            this.pictureBoxMaximize.Size = new System.Drawing.Size(60, 49);
            this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximize.TabIndex = 20;
            this.pictureBoxMaximize.TabStop = false;
            this.pictureBoxMaximize.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // btnAdminTools
            // 
            this.btnAdminTools.Location = new System.Drawing.Point(942, 503);
            this.btnAdminTools.Name = "btnAdminTools";
            this.btnAdminTools.Size = new System.Drawing.Size(75, 23);
            this.btnAdminTools.TabIndex = 21;
            this.btnAdminTools.Text = "Admin Tools";
            this.btnAdminTools.UseVisualStyleBackColor = true;
            this.btnAdminTools.Click += new System.EventHandler(this.btnAdminTools_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 539);
            this.Controls.Add(this.btnAdminTools);
            this.Controls.Add(this.pictureBoxMaximize);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.lblCurrentUserName);
            this.Controls.Add(this.lblCurentUserLabel);
            this.Controls.Add(this.pictureBoxExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label lblCurentUserLabel;
        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxMaximize;
        private System.Windows.Forms.Button btnAdminTools;
    }
}