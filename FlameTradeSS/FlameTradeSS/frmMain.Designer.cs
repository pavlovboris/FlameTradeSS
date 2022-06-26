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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Групи");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Категории");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ценови Групи");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Партньори-Хора");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Настройки", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Отчети");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Групи");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Категории");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Партиди");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Настройки", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Отчети");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCurentUserLabel = new System.Windows.Forms.Label();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.btnAdminTools = new System.Windows.Forms.Button();
            this.treeViewPartners = new System.Windows.Forms.TreeView();
            this.btnNewDocument = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnPartnersMng = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.treeViewInventory = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblCurentUserLabel
            // 
            this.lblCurentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurentUserLabel.AutoSize = true;
            this.lblCurentUserLabel.Location = new System.Drawing.Point(60, 617);
            this.lblCurentUserLabel.Name = "lblCurentUserLabel";
            this.lblCurentUserLabel.Size = new System.Drawing.Size(72, 13);
            this.lblCurentUserLabel.TabIndex = 17;
            this.lblCurentUserLabel.Text = "Current User :";
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(131, 617);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentUserName.TabIndex = 18;
            this.lblCurrentUserName.Text = "?";
            // 
            // btnAdminTools
            // 
            this.btnAdminTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminTools.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdminTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminTools.Location = new System.Drawing.Point(906, 607);
            this.btnAdminTools.Name = "btnAdminTools";
            this.btnAdminTools.Size = new System.Drawing.Size(75, 23);
            this.btnAdminTools.TabIndex = 21;
            this.btnAdminTools.Text = "Admin Tools";
            this.btnAdminTools.UseVisualStyleBackColor = true;
            this.btnAdminTools.Click += new System.EventHandler(this.btnAdminTools_Click);
            // 
            // treeViewPartners
            // 
            this.treeViewPartners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewPartners.Location = new System.Drawing.Point(12, 131);
            this.treeViewPartners.Name = "treeViewPartners";
            treeNode1.Name = "PartnerGroup";
            treeNode1.Text = "Групи";
            treeNode2.Name = "PartnerCategory";
            treeNode2.Text = "Категории";
            treeNode3.Name = "PartnerStaticPriceGroup";
            treeNode3.Text = "Ценови Групи";
            treeNode4.Name = "PersonPartners";
            treeNode4.Text = "Партньори-Хора";
            treeNode5.Name = "PartnerSettings";
            treeNode5.Text = "Настройки";
            treeNode6.Name = "PartnerReports";
            treeNode6.Text = "Отчети";
            this.treeViewPartners.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeViewPartners.Size = new System.Drawing.Size(173, 146);
            this.treeViewPartners.TabIndex = 29;
            this.treeViewPartners.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPartners_NodeMouseDoubleClick);
            // 
            // btnNewDocument
            // 
            this.btnNewDocument.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewDocument.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_051_Icon_48;
            this.btnNewDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDocument.Location = new System.Drawing.Point(191, 131);
            this.btnNewDocument.Name = "btnNewDocument";
            this.btnNewDocument.Size = new System.Drawing.Size(153, 50);
            this.btnNewDocument.TabIndex = 34;
            this.btnNewDocument.Text = "Нов Документ";
            this.btnNewDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewDocument.UseVisualStyleBackColor = true;
            this.btnNewDocument.Click += new System.EventHandler(this.btnNewDocument_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProduction.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_power_Icon_48;
            this.btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.Location = new System.Drawing.Point(728, 73);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(153, 52);
            this.btnProduction.TabIndex = 33;
            this.btnProduction.Text = "Производство";
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduction.UseVisualStyleBackColor = true;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWarehouse.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_132_Icon_48;
            this.btnWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarehouse.Location = new System.Drawing.Point(573, 73);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(97, 52);
            this.btnWarehouse.TabIndex = 32;
            this.btnWarehouse.Text = "Склад";
            this.btnWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            // 
            // btnProjects
            // 
            this.btnProjects.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProjects.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_web_Icon_48;
            this.btnProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.Location = new System.Drawing.Point(384, 73);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(113, 52);
            this.btnProjects.TabIndex = 31;
            this.btnProjects.Text = "Проекти";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDocuments.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_095_Icon_48;
            this.btnDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocuments.Location = new System.Drawing.Point(191, 73);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(130, 52);
            this.btnDocuments.TabIndex = 30;
            this.btnDocuments.Text = "Документи";
            this.btnDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnPartnersMng
            // 
            this.btnPartnersMng.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPartnersMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartnersMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPartnersMng.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_109_Icon_48;
            this.btnPartnersMng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartnersMng.Location = new System.Drawing.Point(12, 73);
            this.btnPartnersMng.Name = "btnPartnersMng";
            this.btnPartnersMng.Size = new System.Drawing.Size(132, 52);
            this.btnPartnersMng.TabIndex = 28;
            this.btnPartnersMng.Text = "Партньори";
            this.btnPartnersMng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPartnersMng.UseVisualStyleBackColor = true;
            this.btnPartnersMng.Click += new System.EventHandler(this.btnPartnersMng_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_076_Icon_48;
            this.btnLogOut.Location = new System.Drawing.Point(6, 587);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(49, 47);
            this.btnLogOut.TabIndex = 26;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_48;
            this.btnMinimize.Location = new System.Drawing.Point(832, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 48);
            this.btnMinimize.TabIndex = 25;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnMaximize.Location = new System.Drawing.Point(887, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(49, 48);
            this.btnMaximize.TabIndex = 24;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(942, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // treeViewInventory
            // 
            this.treeViewInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewInventory.Location = new System.Drawing.Point(573, 131);
            this.treeViewInventory.Name = "treeViewInventory";
            treeNode7.Name = "InvenotryGroup";
            treeNode7.Text = "Групи";
            treeNode8.Name = "InventoryCategory";
            treeNode8.Text = "Категории";
            treeNode9.Name = "InventoryPartitions";
            treeNode9.Text = "Партиди";
            treeNode10.Name = "InventorySettings";
            treeNode10.Text = "Настройки";
            treeNode11.Name = "InventoryReports";
            treeNode11.Text = "Отчети";
            this.treeViewInventory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeViewInventory.Size = new System.Drawing.Size(173, 146);
            this.treeViewInventory.TabIndex = 35;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 642);
            this.Controls.Add(this.treeViewInventory);
            this.Controls.Add(this.btnNewDocument);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.treeViewPartners);
            this.Controls.Add(this.btnPartnersMng);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdminTools);
            this.Controls.Add(this.lblCurrentUserName);
            this.Controls.Add(this.lblCurentUserLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(421, 398);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurentUserLabel;
        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.Button btnAdminTools;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPartnersMng;
        private System.Windows.Forms.TreeView treeViewPartners;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnNewDocument;
        private System.Windows.Forms.TreeView treeViewInventory;
    }
}