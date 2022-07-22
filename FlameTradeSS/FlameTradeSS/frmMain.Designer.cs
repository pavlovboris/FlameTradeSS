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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Добави Артикул");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Списък с Артикули");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Артикули", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Групи");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Категории");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Списък с Партиди");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Видове Партиди");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Партиди", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Повърхности");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Параметри");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Настройки", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Отчети");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Групи");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Категории");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ценови Групи");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Партньори-Хора");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Настройки", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Отчети");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAdminTools = new System.Windows.Forms.Button();
            this.treeViewInventory = new System.Windows.Forms.TreeView();
            this.treeViewPartners = new System.Windows.Forms.TreeView();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.lblCurentUserLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuProduction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuReceiptModels = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPartnersMng = new System.Windows.Forms.Button();
            this.btnFinancialPlans = new System.Windows.Forms.Button();
            this.btnNewDocument = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.contextMenuProduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminTools
            // 
            this.btnAdminTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminTools.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdminTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminTools.Location = new System.Drawing.Point(1062, 533);
            this.btnAdminTools.Name = "btnAdminTools";
            this.btnAdminTools.Size = new System.Drawing.Size(75, 23);
            this.btnAdminTools.TabIndex = 21;
            this.btnAdminTools.Text = "Admin Tools";
            this.btnAdminTools.UseVisualStyleBackColor = true;
            this.btnAdminTools.Click += new System.EventHandler(this.btnAdminTools_Click);
            // 
            // treeViewInventory
            // 
            this.treeViewInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewInventory.Location = new System.Drawing.Point(196, 109);
            this.treeViewInventory.Name = "treeViewInventory";
            treeNode1.Name = "ItemsNewItem";
            treeNode1.Text = "Добави Артикул";
            treeNode2.Name = "ItemsList";
            treeNode2.Text = "Списък с Артикули";
            treeNode3.Name = "InventoryItems";
            treeNode3.Text = "Артикули";
            treeNode4.Name = "InvenotryGroup";
            treeNode4.Text = "Групи";
            treeNode5.Name = "InventoryCategory";
            treeNode5.Text = "Категории";
            treeNode6.Name = "ItemsPartitionsTypeList";
            treeNode6.Text = "Списък с Партиди";
            treeNode7.Name = "ItemsPartitionsTypes";
            treeNode7.Text = "Видове Партиди";
            treeNode8.Name = "InventoryPartitions";
            treeNode8.Text = "Партиди";
            treeNode9.Name = "InventorySurfaces";
            treeNode9.Text = "Повърхности";
            treeNode10.Name = "ItemsParameters";
            treeNode10.Text = "Параметри";
            treeNode11.Name = "InventorySettings";
            treeNode11.Text = "Настройки";
            treeNode12.Name = "InventoryReports";
            treeNode12.Text = "Отчети";
            this.treeViewInventory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode11,
            treeNode12});
            this.treeViewInventory.Size = new System.Drawing.Size(195, 223);
            this.treeViewInventory.TabIndex = 35;
            this.treeViewInventory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewInventory_NodeMouseDoubleClick);
            // 
            // treeViewPartners
            // 
            this.treeViewPartners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewPartners.Location = new System.Drawing.Point(17, 109);
            this.treeViewPartners.Name = "treeViewPartners";
            treeNode13.Name = "PartnerGroup";
            treeNode13.Text = "Групи";
            treeNode14.Name = "PartnerCategory";
            treeNode14.Text = "Категории";
            treeNode15.Name = "PartnerStaticPriceGroup";
            treeNode15.Text = "Ценови Групи";
            treeNode16.Name = "PersonPartners";
            treeNode16.Text = "Партньори-Хора";
            treeNode17.Name = "PartnerSettings";
            treeNode17.Text = "Настройки";
            treeNode18.Name = "PartnerReports";
            treeNode18.Text = "Отчети";
            this.treeViewPartners.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            this.treeViewPartners.Size = new System.Drawing.Size(173, 146);
            this.treeViewPartners.TabIndex = 29;
            this.treeViewPartners.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPartners_NodeMouseDoubleClick);
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(135, 535);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentUserName.TabIndex = 18;
            this.lblCurrentUserName.Text = "?";
            // 
            // lblCurentUserLabel
            // 
            this.lblCurentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurentUserLabel.AutoSize = true;
            this.lblCurentUserLabel.Location = new System.Drawing.Point(64, 535);
            this.lblCurentUserLabel.Name = "lblCurentUserLabel";
            this.lblCurentUserLabel.Size = new System.Drawing.Size(72, 13);
            this.lblCurentUserLabel.TabIndex = 17;
            this.lblCurentUserLabel.Text = "Current User :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuProduction
            // 
            this.contextMenuProduction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuReceiptModels});
            this.contextMenuProduction.Name = "contextMenuProduction";
            this.contextMenuProduction.Size = new System.Drawing.Size(183, 26);
            this.contextMenuProduction.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuProduction_ItemClicked);
            // 
            // toolStripMenuReceiptModels
            // 
            this.toolStripMenuReceiptModels.Name = "toolStripMenuReceiptModels";
            this.toolStripMenuReceiptModels.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuReceiptModels.Text = "Модели на Рецепти";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_076_Icon_48;
            this.btnLogOut.Location = new System.Drawing.Point(10, 505);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(49, 47);
            this.btnLogOut.TabIndex = 26;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // btnPartnersMng
            // 
            this.btnPartnersMng.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPartnersMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartnersMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPartnersMng.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_109_Icon_48;
            this.btnPartnersMng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartnersMng.Location = new System.Drawing.Point(17, 51);
            this.btnPartnersMng.Name = "btnPartnersMng";
            this.btnPartnersMng.Size = new System.Drawing.Size(132, 52);
            this.btnPartnersMng.TabIndex = 28;
            this.btnPartnersMng.Text = "Партньори";
            this.btnPartnersMng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPartnersMng.UseVisualStyleBackColor = true;
            this.btnPartnersMng.Click += new System.EventHandler(this.btnPartnersMng_Click);
            // 
            // btnFinancialPlans
            // 
            this.btnFinancialPlans.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinancialPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancialPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinancialPlans.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_power_Icon_48;
            this.btnFinancialPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinancialPlans.Location = new System.Drawing.Point(938, 73);
            this.btnFinancialPlans.Name = "btnFinancialPlans";
            this.btnFinancialPlans.Size = new System.Drawing.Size(199, 52);
            this.btnFinancialPlans.TabIndex = 36;
            this.btnFinancialPlans.Text = "Финансови Планове";
            this.btnFinancialPlans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinancialPlans.UseVisualStyleBackColor = true;
            this.btnFinancialPlans.Click += new System.EventHandler(this.btnFinancialPlans_Click);
            this.btnFinancialPlans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.btnFinancialPlans.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.btnFinancialPlans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // btnNewDocument
            // 
            this.btnNewDocument.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewDocument.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_051_Icon_48;
            this.btnNewDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDocument.Location = new System.Drawing.Point(728, 200);
            this.btnNewDocument.Name = "btnNewDocument";
            this.btnNewDocument.Size = new System.Drawing.Size(153, 50);
            this.btnNewDocument.TabIndex = 34;
            this.btnNewDocument.Text = "Нов Документ";
            this.btnNewDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewDocument.UseVisualStyleBackColor = true;
            this.btnNewDocument.Click += new System.EventHandler(this.btnNewDocument_Click);
            this.btnNewDocument.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.btnNewDocument.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.btnNewDocument.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // btnProduction
            // 
            this.btnProduction.ContextMenuStrip = this.contextMenuProduction;
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
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            this.btnProduction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.btnProduction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.btnProduction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_037_Icon_48;
            this.btnMaximize.Location = new System.Drawing.Point(1033, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(49, 48);
            this.btnMaximize.TabIndex = 24;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWarehouse.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_132_Icon_48;
            this.btnWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarehouse.Location = new System.Drawing.Point(196, 51);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(97, 52);
            this.btnWarehouse.TabIndex = 32;
            this.btnWarehouse.Text = "Склад";
            this.btnWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(1088, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_48;
            this.btnMinimize.Location = new System.Drawing.Point(978, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 48);
            this.btnMinimize.TabIndex = 25;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProjects.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_web_Icon_48;
            this.btnProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.Location = new System.Drawing.Point(938, 131);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(113, 52);
            this.btnProjects.TabIndex = 31;
            this.btnProjects.Text = "Проекти";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            this.btnProjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.btnProjects.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.btnProjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // btnDocuments
            // 
            this.btnDocuments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDocuments.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_orbs2_095_Icon_48;
            this.btnDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocuments.Location = new System.Drawing.Point(728, 142);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(130, 52);
            this.btnDocuments.TabIndex = 30;
            this.btnDocuments.Text = "Документи";
            this.btnDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            this.btnDocuments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.btnDocuments.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.btnDocuments.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 568);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPartnersMng);
            this.Controls.Add(this.lblCurentUserLabel);
            this.Controls.Add(this.lblCurrentUserName);
            this.Controls.Add(this.btnFinancialPlans);
            this.Controls.Add(this.treeViewPartners);
            this.Controls.Add(this.treeViewInventory);
            this.Controls.Add(this.btnNewDocument);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnAdminTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(421, 398);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuProduction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdminTools;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnNewDocument;
        private System.Windows.Forms.TreeView treeViewInventory;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.TreeView treeViewPartners;
        private System.Windows.Forms.Button btnPartnersMng;
        private System.Windows.Forms.Button btnFinancialPlans;
        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.Label lblCurentUserLabel;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ContextMenuStrip contextMenuProduction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReceiptModels;
    }
}