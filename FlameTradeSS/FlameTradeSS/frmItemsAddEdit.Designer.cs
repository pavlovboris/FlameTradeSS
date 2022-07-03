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
            this.cmbDefaultMu = new System.Windows.Forms.ComboBox();
            this.muBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDefaultMu = new System.Windows.Forms.Label();
            this.lblDefaultPartition = new System.Windows.Forms.Label();
            this.cmbDefaultPartition = new System.Windows.Forms.ComboBox();
            this.partitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.itemsGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picItemPicture = new System.Windows.Forms.PictureBox();
            this.lblDefaultSupplier = new System.Windows.Forms.Label();
            this.cmbDefaultSupplier = new System.Windows.Forms.ComboBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStaticWeigth = new System.Windows.Forms.TextBox();
            this.lblStaticWeigth = new System.Windows.Forms.Label();
            this.txtStaticSurface = new System.Windows.Forms.TextBox();
            this.StaticSurface = new System.Windows.Forms.Label();
            this.txtStaticLength = new System.Windows.Forms.TextBox();
            this.lblStaticLength = new System.Windows.Forms.Label();
            this.txtStaticHeight = new System.Windows.Forms.TextBox();
            this.lvlStaticHeght = new System.Windows.Forms.Label();
            this.txtStaticWidth = new System.Windows.Forms.TextBox();
            this.lblStaticWidth = new System.Windows.Forms.Label();
            this.btnDynamicParameters = new System.Windows.Forms.Button();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.btnFiles = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.lblDefaultSurface = new System.Windows.Forms.Label();
            this.cmbDefaultSurface = new System.Windows.Forms.ComboBox();
            this.surfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialogChangePicture = new System.Windows.Forms.OpenFileDialog();
            this.lblFinancialCategory = new System.Windows.Forms.Label();
            this.cmbFinancialCategory = new System.Windows.Forms.ComboBox();
            this.financialCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FlameTradeSS.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.btnClose.Location = new System.Drawing.Point(582, 6);
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
            this.btnSave.Location = new System.Drawing.Point(480, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 52);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // cmbDefaultMu
            // 
            this.cmbDefaultMu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "DefaultMu", true));
            this.cmbDefaultMu.DataSource = this.muBindingSource;
            this.cmbDefaultMu.DisplayMember = "Name";
            this.cmbDefaultMu.FormattingEnabled = true;
            this.cmbDefaultMu.Location = new System.Drawing.Point(27, 178);
            this.cmbDefaultMu.Name = "cmbDefaultMu";
            this.cmbDefaultMu.Size = new System.Drawing.Size(176, 21);
            this.cmbDefaultMu.TabIndex = 23;
            this.cmbDefaultMu.ValueMember = "ID";
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
            // lblDefaultPartition
            // 
            this.lblDefaultPartition.AutoSize = true;
            this.lblDefaultPartition.Location = new System.Drawing.Point(27, 211);
            this.lblDefaultPartition.Name = "lblDefaultPartition";
            this.lblDefaultPartition.Size = new System.Drawing.Size(140, 13);
            this.lblDefaultPartition.TabIndex = 26;
            this.lblDefaultPartition.Text = "Партида по подразбиране";
            // 
            // cmbDefaultPartition
            // 
            this.cmbDefaultPartition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "DefaultPartition", true));
            this.cmbDefaultPartition.DataSource = this.partitionsBindingSource;
            this.cmbDefaultPartition.DisplayMember = "Name";
            this.cmbDefaultPartition.FormattingEnabled = true;
            this.cmbDefaultPartition.Location = new System.Drawing.Point(27, 230);
            this.cmbDefaultPartition.Name = "cmbDefaultPartition";
            this.cmbDefaultPartition.Size = new System.Drawing.Size(176, 21);
            this.cmbDefaultPartition.TabIndex = 25;
            this.cmbDefaultPartition.ValueMember = "ID";
            // 
            // partitionsBindingSource
            // 
            this.partitionsBindingSource.DataSource = typeof(FlameTradeSS.Partitions);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(233, 211);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 30;
            this.lblGroup.Text = "Група";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "ItemsGroupID", true));
            this.cmbGroup.DataSource = this.itemsGroupsBindingSource;
            this.cmbGroup.DisplayMember = "GroupName";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(233, 230);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(176, 21);
            this.cmbGroup.TabIndex = 29;
            this.cmbGroup.ValueMember = "ID";
            // 
            // itemsGroupsBindingSource
            // 
            this.itemsGroupsBindingSource.DataSource = typeof(FlameTradeSS.ItemsGroups);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(233, 159);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 13);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "Категория ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "ItemCategory", true));
            this.cmbCategory.DataSource = this.itemCategoryBindingSource;
            this.cmbCategory.DisplayMember = "CategoryName";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(233, 178);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(176, 21);
            this.cmbCategory.TabIndex = 27;
            this.cmbCategory.ValueMember = "ID";
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(FlameTradeSS.ItemCategory);
            // 
            // picItemPicture
            // 
            this.picItemPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picItemPicture.ErrorImage")));
            this.picItemPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picItemPicture.InitialImage")));
            this.picItemPicture.Location = new System.Drawing.Point(416, 118);
            this.picItemPicture.Name = "picItemPicture";
            this.picItemPicture.Size = new System.Drawing.Size(205, 133);
            this.picItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemPicture.TabIndex = 31;
            this.picItemPicture.TabStop = false;
            // 
            // lblDefaultSupplier
            // 
            this.lblDefaultSupplier.AutoSize = true;
            this.lblDefaultSupplier.Location = new System.Drawing.Point(27, 319);
            this.lblDefaultSupplier.Name = "lblDefaultSupplier";
            this.lblDefaultSupplier.Size = new System.Drawing.Size(152, 13);
            this.lblDefaultSupplier.TabIndex = 33;
            this.lblDefaultSupplier.Text = "Доставчик по подразбиране";
            // 
            // cmbDefaultSupplier
            // 
            this.cmbDefaultSupplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "DefaultSupplierID", true));
            this.cmbDefaultSupplier.DataSource = this.partnersBindingSource;
            this.cmbDefaultSupplier.DisplayMember = "Partner_name";
            this.cmbDefaultSupplier.FormattingEnabled = true;
            this.cmbDefaultSupplier.Location = new System.Drawing.Point(27, 338);
            this.cmbDefaultSupplier.Name = "cmbDefaultSupplier";
            this.cmbDefaultSupplier.Size = new System.Drawing.Size(363, 21);
            this.cmbDefaultSupplier.TabIndex = 32;
            this.cmbDefaultSupplier.ValueMember = "ID";
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(FlameTradeSS.Partners);
            // 
            // txtStaticWeigth
            // 
            this.txtStaticWeigth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "StaticWeigth", true));
            this.txtStaticWeigth.Location = new System.Drawing.Point(27, 385);
            this.txtStaticWeigth.MaxLength = 250;
            this.txtStaticWeigth.Name = "txtStaticWeigth";
            this.txtStaticWeigth.Size = new System.Drawing.Size(103, 20);
            this.txtStaticWeigth.TabIndex = 35;
            // 
            // lblStaticWeigth
            // 
            this.lblStaticWeigth.AutoSize = true;
            this.lblStaticWeigth.Location = new System.Drawing.Point(27, 368);
            this.lblStaticWeigth.Name = "lblStaticWeigth";
            this.lblStaticWeigth.Size = new System.Drawing.Size(103, 13);
            this.lblStaticWeigth.TabIndex = 34;
            this.lblStaticWeigth.Text = "Статично Тегло-гр.";
            // 
            // txtStaticSurface
            // 
            this.txtStaticSurface.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "StaticSurface", true));
            this.txtStaticSurface.Location = new System.Drawing.Point(136, 385);
            this.txtStaticSurface.MaxLength = 250;
            this.txtStaticSurface.Name = "txtStaticSurface";
            this.txtStaticSurface.Size = new System.Drawing.Size(122, 20);
            this.txtStaticSurface.TabIndex = 37;
            // 
            // StaticSurface
            // 
            this.StaticSurface.AutoSize = true;
            this.StaticSurface.Location = new System.Drawing.Point(136, 368);
            this.StaticSurface.Name = "StaticSurface";
            this.StaticSurface.Size = new System.Drawing.Size(122, 13);
            this.StaticSurface.TabIndex = 36;
            this.StaticSurface.Text = "Статична Площ-кв.мм.";
            // 
            // txtStaticLength
            // 
            this.txtStaticLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "StaticLength", true));
            this.txtStaticLength.Location = new System.Drawing.Point(264, 385);
            this.txtStaticLength.MaxLength = 250;
            this.txtStaticLength.Name = "txtStaticLength";
            this.txtStaticLength.Size = new System.Drawing.Size(126, 20);
            this.txtStaticLength.TabIndex = 39;
            // 
            // lblStaticLength
            // 
            this.lblStaticLength.AutoSize = true;
            this.lblStaticLength.Location = new System.Drawing.Point(264, 368);
            this.lblStaticLength.Name = "lblStaticLength";
            this.lblStaticLength.Size = new System.Drawing.Size(126, 13);
            this.lblStaticLength.TabIndex = 38;
            this.lblStaticLength.Text = "Статична Дължина-мм.";
            // 
            // txtStaticHeight
            // 
            this.txtStaticHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "StaticHeight", true));
            this.txtStaticHeight.Location = new System.Drawing.Point(61, 430);
            this.txtStaticHeight.MaxLength = 250;
            this.txtStaticHeight.Name = "txtStaticHeight";
            this.txtStaticHeight.Size = new System.Drawing.Size(118, 20);
            this.txtStaticHeight.TabIndex = 43;
            // 
            // lvlStaticHeght
            // 
            this.lvlStaticHeght.AutoSize = true;
            this.lvlStaticHeght.Location = new System.Drawing.Point(58, 413);
            this.lvlStaticHeght.Name = "lvlStaticHeght";
            this.lvlStaticHeght.Size = new System.Drawing.Size(126, 13);
            this.lvlStaticHeght.TabIndex = 42;
            this.lvlStaticHeght.Text = "Статична Височина-мм.";
            // 
            // txtStaticWidth
            // 
            this.txtStaticWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "StaticWidth", true));
            this.txtStaticWidth.Location = new System.Drawing.Point(208, 430);
            this.txtStaticWidth.MaxLength = 250;
            this.txtStaticWidth.Name = "txtStaticWidth";
            this.txtStaticWidth.Size = new System.Drawing.Size(125, 20);
            this.txtStaticWidth.TabIndex = 45;
            // 
            // lblStaticWidth
            // 
            this.lblStaticWidth.AutoSize = true;
            this.lblStaticWidth.Location = new System.Drawing.Point(205, 413);
            this.lblStaticWidth.Name = "lblStaticWidth";
            this.lblStaticWidth.Size = new System.Drawing.Size(128, 13);
            this.lblStaticWidth.TabIndex = 44;
            this.lblStaticWidth.Text = "Статична Широчина-мм.";
            // 
            // btnDynamicParameters
            // 
            this.btnDynamicParameters.Location = new System.Drawing.Point(456, 295);
            this.btnDynamicParameters.Name = "btnDynamicParameters";
            this.btnDynamicParameters.Size = new System.Drawing.Size(141, 37);
            this.btnDynamicParameters.TabIndex = 48;
            this.btnDynamicParameters.Text = "Управление на Динамични Параметри";
            this.btnDynamicParameters.UseVisualStyleBackColor = true;
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.Location = new System.Drawing.Point(416, 257);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(93, 25);
            this.btnChangePicture.TabIndex = 49;
            this.btnChangePicture.Text = "Смени Снимка";
            this.btnChangePicture.UseVisualStyleBackColor = true;
            this.btnChangePicture.Click += new System.EventHandler(this.btnChangePicture_Click);
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(528, 257);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(93, 25);
            this.btnFiles.TabIndex = 50;
            this.btnFiles.Text = "Файлове";
            this.btnFiles.UseVisualStyleBackColor = true;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(456, 338);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(141, 25);
            this.btnReceipt.TabIndex = 51;
            this.btnReceipt.Text = "Рецепти за Артикула";
            this.btnReceipt.UseVisualStyleBackColor = true;
            // 
            // lblDefaultSurface
            // 
            this.lblDefaultSurface.AutoSize = true;
            this.lblDefaultSurface.Location = new System.Drawing.Point(27, 262);
            this.lblDefaultSurface.Name = "lblDefaultSurface";
            this.lblDefaultSurface.Size = new System.Drawing.Size(158, 13);
            this.lblDefaultSurface.TabIndex = 53;
            this.lblDefaultSurface.Text = "Повърхност по подразбиране";
            // 
            // cmbDefaultSurface
            // 
            this.cmbDefaultSurface.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "DefaultSurfaceID", true));
            this.cmbDefaultSurface.DataSource = this.surfacesBindingSource;
            this.cmbDefaultSurface.DisplayMember = "SurfaceName";
            this.cmbDefaultSurface.FormattingEnabled = true;
            this.cmbDefaultSurface.Location = new System.Drawing.Point(27, 281);
            this.cmbDefaultSurface.Name = "cmbDefaultSurface";
            this.cmbDefaultSurface.Size = new System.Drawing.Size(176, 21);
            this.cmbDefaultSurface.TabIndex = 52;
            this.cmbDefaultSurface.ValueMember = "ID";
            // 
            // surfacesBindingSource
            // 
            this.surfacesBindingSource.DataSource = typeof(FlameTradeSS.Surfaces);
            // 
            // openFileDialogChangePicture
            // 
            this.openFileDialogChangePicture.FileName = "openFileDialog1";
            this.openFileDialogChangePicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogChangePicture_FileOk);
            // 
            // lblFinancialCategory
            // 
            this.lblFinancialCategory.AutoSize = true;
            this.lblFinancialCategory.Location = new System.Drawing.Point(233, 262);
            this.lblFinancialCategory.Name = "lblFinancialCategory";
            this.lblFinancialCategory.Size = new System.Drawing.Size(122, 13);
            this.lblFinancialCategory.TabIndex = 55;
            this.lblFinancialCategory.Text = "Финансова Категория";
            // 
            // cmbFinancialCategory
            // 
            this.cmbFinancialCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "FinancialCategoryID", true));
            this.cmbFinancialCategory.DataSource = this.financialCategoriesBindingSource;
            this.cmbFinancialCategory.DisplayMember = "CategoryName";
            this.cmbFinancialCategory.FormattingEnabled = true;
            this.cmbFinancialCategory.Location = new System.Drawing.Point(233, 281);
            this.cmbFinancialCategory.Name = "cmbFinancialCategory";
            this.cmbFinancialCategory.Size = new System.Drawing.Size(176, 21);
            this.cmbFinancialCategory.TabIndex = 54;
            this.cmbFinancialCategory.ValueMember = "ID";
            // 
            // financialCategoriesBindingSource
            // 
            this.financialCategoriesBindingSource.DataSource = typeof(FlameTradeSS.FinancialCategories);
            // 
            // frmItemsAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 484);
            this.ControlBox = false;
            this.Controls.Add(this.lblFinancialCategory);
            this.Controls.Add(this.cmbFinancialCategory);
            this.Controls.Add(this.lblDefaultSurface);
            this.Controls.Add(this.cmbDefaultSurface);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.btnChangePicture);
            this.Controls.Add(this.btnDynamicParameters);
            this.Controls.Add(this.txtStaticWidth);
            this.Controls.Add(this.lblStaticWidth);
            this.Controls.Add(this.txtStaticHeight);
            this.Controls.Add(this.lvlStaticHeght);
            this.Controls.Add(this.txtStaticLength);
            this.Controls.Add(this.lblStaticLength);
            this.Controls.Add(this.txtStaticSurface);
            this.Controls.Add(this.StaticSurface);
            this.Controls.Add(this.txtStaticWeigth);
            this.Controls.Add(this.lblStaticWeigth);
            this.Controls.Add(this.lblDefaultSupplier);
            this.Controls.Add(this.cmbDefaultSupplier);
            this.Controls.Add(this.picItemPicture);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblDefaultPartition);
            this.Controls.Add(this.cmbDefaultPartition);
            this.Controls.Add(this.lblDefaultMu);
            this.Controls.Add(this.cmbDefaultMu);
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
            ((System.ComponentModel.ISupportInitialize)(this.partitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCategoriesBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbDefaultMu;
        private System.Windows.Forms.BindingSource muBindingSource;
        private System.Windows.Forms.Label lblDefaultMu;
        private System.Windows.Forms.Label lblDefaultPartition;
        private System.Windows.Forms.ComboBox cmbDefaultPartition;
        private System.Windows.Forms.BindingSource partitionsBindingSource;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.BindingSource itemsGroupsBindingSource;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.PictureBox picItemPicture;
        private System.Windows.Forms.Label lblDefaultSupplier;
        private System.Windows.Forms.ComboBox cmbDefaultSupplier;
        private System.Windows.Forms.TextBox txtStaticWeigth;
        private System.Windows.Forms.Label lblStaticWeigth;
        private System.Windows.Forms.TextBox txtStaticSurface;
        private System.Windows.Forms.Label StaticSurface;
        private System.Windows.Forms.TextBox txtStaticLength;
        private System.Windows.Forms.Label lblStaticLength;
        private System.Windows.Forms.TextBox txtStaticHeight;
        private System.Windows.Forms.Label lvlStaticHeght;
        private System.Windows.Forms.TextBox txtStaticWidth;
        private System.Windows.Forms.Label lblStaticWidth;
        private System.Windows.Forms.Button btnDynamicParameters;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.Label lblDefaultSurface;
        private System.Windows.Forms.ComboBox cmbDefaultSurface;
        private System.Windows.Forms.BindingSource surfacesBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialogChangePicture;
        private System.Windows.Forms.Label lblFinancialCategory;
        private System.Windows.Forms.ComboBox cmbFinancialCategory;
        private System.Windows.Forms.BindingSource financialCategoriesBindingSource;
    }
}