namespace WaitresPOS1
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTableSubtitle = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnCategoryDesserts = new System.Windows.Forms.Button();
            this.btnCategoryDrinks = new System.Windows.Forms.Button();
            this.btnCategoryMains = new System.Windows.Forms.Button();
            this.btnCategoryStarters = new System.Windows.Forms.Button();
            this.pnlDishes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCenterOrder = new System.Windows.Forms.Panel();
            this.lblOrderGridTitle = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRightControls = new System.Windows.Forms.Panel();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnSendToKitchen = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.grpCustomItem = new System.Windows.Forms.GroupBox();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.txtCustomPrice = new System.Windows.Forms.TextBox();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.grpModifiers = new System.Windows.Forms.GroupBox();
            this.btnModWellDone = new System.Windows.Forms.Button();
            this.btnModDoubleSauce = new System.Windows.Forms.Button();
            this.btnModMedium = new System.Windows.Forms.Button();
            this.btnModNoSalt = new System.Windows.Forms.Button();
            this.btnModNoOnion = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpQuantity = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlCenterOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlRightControls.SuspendLayout();
            this.grpCustomItem.SuspendLayout();
            this.grpModifiers.SuspendLayout();
            this.grpQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.topPanel.Controls.Add(this.btnBack);
            this.topPanel.Controls.Add(this.lblTableSubtitle);
            this.topPanel.Controls.Add(this.lblTableName);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 70);
            this.topPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1020, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "⬅ Към залата";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTableSubtitle
            // 
            this.lblTableSubtitle.AutoSize = true;
            this.lblTableSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTableSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTableSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblTableSubtitle.Name = "lblTableSubtitle";
            this.lblTableSubtitle.Size = new System.Drawing.Size(437, 17);
            this.lblTableSubtitle.TabIndex = 1;
            this.lblTableSubtitle.Text = "Маркирайте ястия, добавете модификатори и изпратете кухненски бон";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTableName.ForeColor = System.Drawing.Color.White;
            this.lblTableName.Location = new System.Drawing.Point(20, 10);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(257, 30);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "🍽️ МАСА 1 — ПОРЪЧКА";
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.White;
            this.pnlLeftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftMenu.Controls.Add(this.lblMenuTitle);
            this.pnlLeftMenu.Controls.Add(this.pnlCategories);
            this.pnlLeftMenu.Controls.Add(this.pnlDishes);
            this.pnlLeftMenu.Location = new System.Drawing.Point(12, 80);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(380, 620);
            this.pnlLeftMenu.TabIndex = 1;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(12, 10);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(188, 20);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "📖 КАТЕГОРИИ МЕНЮ";
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.btnCategoryDesserts);
            this.pnlCategories.Controls.Add(this.btnCategoryDrinks);
            this.pnlCategories.Controls.Add(this.btnCategoryMains);
            this.pnlCategories.Controls.Add(this.btnCategoryStarters);
            this.pnlCategories.Location = new System.Drawing.Point(8, 35);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(362, 100);
            this.pnlCategories.TabIndex = 1;
            // 
            // btnCategoryDesserts
            // 
            this.btnCategoryDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryDesserts.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategoryDesserts.Location = new System.Drawing.Point(184, 52);
            this.btnCategoryDesserts.Name = "btnCategoryDesserts";
            this.btnCategoryDesserts.Size = new System.Drawing.Size(174, 44);
            this.btnCategoryDesserts.TabIndex = 3;
            this.btnCategoryDesserts.Text = "🍰 Десерти";
            this.btnCategoryDesserts.UseVisualStyleBackColor = true;
            this.btnCategoryDesserts.Click += new System.EventHandler(this.btnCategoryDesserts_Click);
            // 
            // btnCategoryDrinks
            // 
            this.btnCategoryDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryDrinks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategoryDrinks.Location = new System.Drawing.Point(4, 52);
            this.btnCategoryDrinks.Name = "btnCategoryDrinks";
            this.btnCategoryDrinks.Size = new System.Drawing.Size(174, 44);
            this.btnCategoryDrinks.TabIndex = 2;
            this.btnCategoryDrinks.Text = "🥤 Напитки";
            this.btnCategoryDrinks.UseVisualStyleBackColor = true;
            this.btnCategoryDrinks.Click += new System.EventHandler(this.btnCategoryDrinks_Click);
            // 
            // btnCategoryMains
            // 
            this.btnCategoryMains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryMains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryMains.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategoryMains.Location = new System.Drawing.Point(184, 3);
            this.btnCategoryMains.Name = "btnCategoryMains";
            this.btnCategoryMains.Size = new System.Drawing.Size(174, 44);
            this.btnCategoryMains.TabIndex = 1;
            this.btnCategoryMains.Text = "🥩 Основни";
            this.btnCategoryMains.UseVisualStyleBackColor = true;
            this.btnCategoryMains.Click += new System.EventHandler(this.btnCategoryMains_Click);
            // 
            // btnCategoryStarters
            // 
            this.btnCategoryStarters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryStarters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryStarters.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategoryStarters.Location = new System.Drawing.Point(4, 3);
            this.btnCategoryStarters.Name = "btnCategoryStarters";
            this.btnCategoryStarters.Size = new System.Drawing.Size(174, 44);
            this.btnCategoryStarters.TabIndex = 0;
            this.btnCategoryStarters.Text = "🥗 Предястия";
            this.btnCategoryStarters.UseVisualStyleBackColor = true;
            this.btnCategoryStarters.Click += new System.EventHandler(this.btnCategoryStarters_Click);
            // 
            // pnlDishes
            // 
            this.pnlDishes.AutoScroll = true;
            this.pnlDishes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlDishes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDishes.Location = new System.Drawing.Point(8, 142);
            this.pnlDishes.Name = "pnlDishes";
            this.pnlDishes.Padding = new System.Windows.Forms.Padding(6);
            this.pnlDishes.Size = new System.Drawing.Size(362, 465);
            this.pnlDishes.TabIndex = 2;
            // 
            // pnlCenterOrder
            // 
            this.pnlCenterOrder.BackColor = System.Drawing.Color.White;
            this.pnlCenterOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCenterOrder.Controls.Add(this.lblOrderGridTitle);
            this.pnlCenterOrder.Controls.Add(this.dgvOrder);
            this.pnlCenterOrder.Location = new System.Drawing.Point(402, 80);
            this.pnlCenterOrder.Name = "pnlCenterOrder";
            this.pnlCenterOrder.Size = new System.Drawing.Size(480, 620);
            this.pnlCenterOrder.TabIndex = 2;
            // 
            // lblOrderGridTitle
            // 
            this.lblOrderGridTitle.AutoSize = true;
            this.lblOrderGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblOrderGridTitle.Location = new System.Drawing.Point(12, 10);
            this.lblOrderGridTitle.Name = "lblOrderGridTitle";
            this.lblOrderGridTitle.Size = new System.Drawing.Size(256, 20);
            this.lblOrderGridTitle.TabIndex = 0;
            this.lblOrderGridTitle.Text = "📋 ПОРЪЧАНИ АРТИКУЛИ (СМЕТКА)";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeight = 35;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colPrice,
            this.colQuantity,
            this.colTotal,
            this.colNote});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Location = new System.Drawing.Point(8, 38);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 30;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(462, 568);
            this.dgvOrder.TabIndex = 1;
            this.dgvOrder.SelectionChanged += new System.EventHandler(this.dgvOrder_SelectionChanged);
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemName.HeaderText = "Артикул";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Цена";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 60;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Бр.";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 40;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Общо";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 65;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Забележка";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 110;
            // 
            // pnlRightControls
            // 
            this.pnlRightControls.BackColor = System.Drawing.Color.White;
            this.pnlRightControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightControls.Controls.Add(this.btnClearOrder);
            this.pnlRightControls.Controls.Add(this.btnSendToKitchen);
            this.pnlRightControls.Controls.Add(this.lblTotalAmount);
            this.pnlRightControls.Controls.Add(this.grpCustomItem);
            this.pnlRightControls.Controls.Add(this.grpModifiers);
            this.pnlRightControls.Controls.Add(this.grpQuantity);
            this.pnlRightControls.Location = new System.Drawing.Point(892, 80);
            this.pnlRightControls.Name = "pnlRightControls";
            this.pnlRightControls.Size = new System.Drawing.Size(296, 620);
            this.pnlRightControls.TabIndex = 3;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnClearOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClearOrder.Location = new System.Drawing.Point(10, 574);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(274, 34);
            this.btnClearOrder.TabIndex = 5;
            this.btnClearOrder.Text = "🧹 Освободи маса / Изчисти сметка";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnSendToKitchen
            // 
            this.btnSendToKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSendToKitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendToKitchen.FlatAppearance.BorderSize = 0;
            this.btnSendToKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToKitchen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendToKitchen.ForeColor = System.Drawing.Color.White;
            this.btnSendToKitchen.Location = new System.Drawing.Point(10, 514);
            this.btnSendToKitchen.Name = "btnSendToKitchen";
            this.btnSendToKitchen.Size = new System.Drawing.Size(274, 52);
            this.btnSendToKitchen.TabIndex = 4;
            this.btnSendToKitchen.Text = "🍳 ИЗПРАТИ КЪМ КУХНЯ";
            this.btnSendToKitchen.UseVisualStyleBackColor = false;
            this.btnSendToKitchen.Click += new System.EventHandler(this.btnSendToKitchen_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 460);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(274, 44);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "ОБЩО: 0.00 €";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomItem
            // 
            this.grpCustomItem.Controls.Add(this.btnAddCustom);
            this.grpCustomItem.Controls.Add(this.txtCustomPrice);
            this.grpCustomItem.Controls.Add(this.txtCustomName);
            this.grpCustomItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpCustomItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.grpCustomItem.Location = new System.Drawing.Point(10, 310);
            this.grpCustomItem.Name = "grpCustomItem";
            this.grpCustomItem.Size = new System.Drawing.Size(274, 138);
            this.grpCustomItem.TabIndex = 2;
            this.grpCustomItem.TabStop = false;
            this.grpCustomItem.Text = "➕ Артикул извън менюто";
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnAddCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnAddCustom.Location = new System.Drawing.Point(10, 92);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(254, 36);
            this.btnAddCustom.TabIndex = 2;
            this.btnAddCustom.Text = "+ Добави нестандартен";
            this.btnAddCustom.UseVisualStyleBackColor = false;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // txtCustomPrice
            // 
            this.txtCustomPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCustomPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomPrice.Location = new System.Drawing.Point(180, 56);
            this.txtCustomPrice.Name = "txtCustomPrice";
            this.txtCustomPrice.Size = new System.Drawing.Size(84, 24);
            this.txtCustomPrice.TabIndex = 1;
            this.txtCustomPrice.Text = "Цена (€)";
            this.txtCustomPrice.Enter += new System.EventHandler(this.txtCustomPrice_Enter);
            this.txtCustomPrice.Leave += new System.EventHandler(this.txtCustomPrice_Leave);
            // 
            // txtCustomName
            // 
            this.txtCustomName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCustomName.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomName.Location = new System.Drawing.Point(10, 24);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(254, 24);
            this.txtCustomName.TabIndex = 0;
            this.txtCustomName.Text = "Име на артикул...";
            this.txtCustomName.Enter += new System.EventHandler(this.txtCustomName_Enter);
            this.txtCustomName.Leave += new System.EventHandler(this.txtCustomName_Leave);
            // 
            // grpModifiers
            // 
            this.grpModifiers.Controls.Add(this.btnModWellDone);
            this.grpModifiers.Controls.Add(this.btnModDoubleSauce);
            this.grpModifiers.Controls.Add(this.btnModMedium);
            this.grpModifiers.Controls.Add(this.btnModNoSalt);
            this.grpModifiers.Controls.Add(this.btnModNoOnion);
            this.grpModifiers.Controls.Add(this.btnAddNote);
            this.grpModifiers.Controls.Add(this.txtNote);
            this.grpModifiers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpModifiers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.grpModifiers.Location = new System.Drawing.Point(10, 88);
            this.grpModifiers.Name = "grpModifiers";
            this.grpModifiers.Size = new System.Drawing.Size(274, 214);
            this.grpModifiers.TabIndex = 1;
            this.grpModifiers.TabStop = false;
            this.grpModifiers.Text = "📝 Забележка / Модификатор";
            // 
            // btnModWellDone
            // 
            this.btnModWellDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnModWellDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModWellDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnModWellDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModWellDone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModWellDone.Location = new System.Drawing.Point(140, 56);
            this.btnModWellDone.Name = "btnModWellDone";
            this.btnModWellDone.Size = new System.Drawing.Size(124, 26);
            this.btnModWellDone.TabIndex = 4;
            this.btnModWellDone.Text = "Добре изпечено";
            this.btnModWellDone.UseVisualStyleBackColor = false;
            this.btnModWellDone.Click += new System.EventHandler(this.QuickModifier_Click);
            // 
            // btnModDoubleSauce
            // 
            this.btnModDoubleSauce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnModDoubleSauce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModDoubleSauce.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnModDoubleSauce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModDoubleSauce.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModDoubleSauce.Location = new System.Drawing.Point(10, 88);
            this.btnModDoubleSauce.Name = "btnModDoubleSauce";
            this.btnModDoubleSauce.Size = new System.Drawing.Size(124, 26);
            this.btnModDoubleSauce.TabIndex = 5;
            this.btnModDoubleSauce.Text = "Двоен сос";
            this.btnModDoubleSauce.UseVisualStyleBackColor = false;
            this.btnModDoubleSauce.Click += new System.EventHandler(this.QuickModifier_Click);
            // 
            // btnModMedium
            // 
            this.btnModMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnModMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModMedium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnModMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModMedium.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModMedium.Location = new System.Drawing.Point(10, 56);
            this.btnModMedium.Name = "btnModMedium";
            this.btnModMedium.Size = new System.Drawing.Size(124, 26);
            this.btnModMedium.TabIndex = 3;
            this.btnModMedium.Text = "Средно изпечено";
            this.btnModMedium.UseVisualStyleBackColor = false;
            this.btnModMedium.Click += new System.EventHandler(this.QuickModifier_Click);
            // 
            // btnModNoSalt
            // 
            this.btnModNoSalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnModNoSalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModNoSalt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnModNoSalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModNoSalt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModNoSalt.Location = new System.Drawing.Point(140, 24);
            this.btnModNoSalt.Name = "btnModNoSalt";
            this.btnModNoSalt.Size = new System.Drawing.Size(124, 26);
            this.btnModNoSalt.TabIndex = 2;
            this.btnModNoSalt.Text = "Без сол";
            this.btnModNoSalt.UseVisualStyleBackColor = false;
            this.btnModNoSalt.Click += new System.EventHandler(this.QuickModifier_Click);
            // 
            // btnModNoOnion
            // 
            this.btnModNoOnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnModNoOnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModNoOnion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnModNoOnion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModNoOnion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModNoOnion.Location = new System.Drawing.Point(10, 24);
            this.btnModNoOnion.Name = "btnModNoOnion";
            this.btnModNoOnion.Size = new System.Drawing.Size(124, 26);
            this.btnModNoOnion.TabIndex = 1;
            this.btnModNoOnion.Text = "Без лук";
            this.btnModNoOnion.UseVisualStyleBackColor = false;
            this.btnModNoOnion.Click += new System.EventHandler(this.QuickModifier_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnAddNote.Location = new System.Drawing.Point(10, 165);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(254, 36);
            this.btnAddNote.TabIndex = 7;
            this.btnAddNote.Text = "💾 Запиши забележка";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNote.Location = new System.Drawing.Point(10, 126);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(254, 24);
            this.txtNote.TabIndex = 6;
            // 
            // grpQuantity
            // 
            this.grpQuantity.Controls.Add(this.btnRemoveItem);
            this.grpQuantity.Controls.Add(this.btnMinus);
            this.grpQuantity.Controls.Add(this.btnPlus);
            this.grpQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.grpQuantity.Location = new System.Drawing.Point(10, 10);
            this.grpQuantity.Name = "grpQuantity";
            this.grpQuantity.Size = new System.Drawing.Size(274, 72);
            this.grpQuantity.TabIndex = 0;
            this.grpQuantity.TabStop = false;
            this.grpQuantity.Text = "🔢 Количество за избрания ред";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemoveItem.Location = new System.Drawing.Point(176, 24);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(88, 36);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "🗑️ Изтрий";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMinus.Location = new System.Drawing.Point(92, 24);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(76, 36);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "➖ -1";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.btnPlus.Location = new System.Drawing.Point(10, 24);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 36);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "➕ +1";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 715);
            this.Controls.Add(this.pnlRightControls);
            this.Controls.Add(this.pnlCenterOrder);
            this.Controls.Add(this.pnlLeftMenu);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaiterPOS - Поръчка по маса";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlLeftMenu.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            this.pnlCenterOrder.ResumeLayout(false);
            this.pnlCenterOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlRightControls.ResumeLayout(false);
            this.grpCustomItem.ResumeLayout(false);
            this.grpCustomItem.PerformLayout();
            this.grpModifiers.ResumeLayout(false);
            this.grpModifiers.PerformLayout();
            this.grpQuantity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblTableSubtitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Button btnCategoryStarters;
        private System.Windows.Forms.Button btnCategoryMains;
        private System.Windows.Forms.Button btnCategoryDrinks;
        private System.Windows.Forms.Button btnCategoryDesserts;
        private System.Windows.Forms.FlowLayoutPanel pnlDishes;
        private System.Windows.Forms.Panel pnlCenterOrder;
        private System.Windows.Forms.Label lblOrderGridTitle;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.Panel pnlRightControls;
        private System.Windows.Forms.GroupBox grpQuantity;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.GroupBox grpModifiers;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnModNoOnion;
        private System.Windows.Forms.Button btnModNoSalt;
        private System.Windows.Forms.Button btnModMedium;
        private System.Windows.Forms.Button btnModDoubleSauce;
        private System.Windows.Forms.Button btnModWellDone;
        private System.Windows.Forms.GroupBox grpCustomItem;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.TextBox txtCustomPrice;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnSendToKitchen;
        private System.Windows.Forms.Button btnClearOrder;
    }
}