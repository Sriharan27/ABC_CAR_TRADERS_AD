namespace ABC_Car_Traders
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
            this.OrderTabControl = new System.Windows.Forms.TabControl();
            this.OrderCartabPage = new System.Windows.Forms.TabPage();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ColourComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CarsCloseCartBtn = new System.Windows.Forms.Button();
            this.CarCartBtn = new System.Windows.Forms.Button();
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CarStockTxtBox = new System.Windows.Forms.TextBox();
            this.CarClearCartItemsBtn = new System.Windows.Forms.Button();
            this.CarOrderCartItemsBtn = new System.Windows.Forms.Button();
            this.CarsCartGridView = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarOrderQtyBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.CarComboBox = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddToCartCarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.YearTxtBox = new System.Windows.Forms.TextBox();
            this.CarsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderCarPartsTab = new System.Windows.Forms.TabPage();
            this.PartsCheckOutBtn = new System.Windows.Forms.Button();
            this.PartsCloseCartBtn = new System.Windows.Forms.Button();
            this.CartBtn = new System.Windows.Forms.Button();
            this.PartsPictureBox = new System.Windows.Forms.PictureBox();
            this.ClearCartItemsBtn = new System.Windows.Forms.Button();
            this.OrderCartItemsBtn = new System.Windows.Forms.Button();
            this.PartsCartGridView = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.PartsStockTxtBox = new System.Windows.Forms.TextBox();
            this.OrderQtyBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PartsDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PartsPriceTxtBox = new System.Windows.Forms.TextBox();
            this.PartNameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CarPartCarComboBox = new System.Windows.Forms.ComboBox();
            this.PartsResetBtn = new System.Windows.Forms.Button();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.OrderTabControl.SuspendLayout();
            this.OrderCartabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarOrderQtyBox)).BeginInit();
            this.OrderCarPartsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderQtyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderTabControl
            // 
            this.OrderTabControl.Controls.Add(this.OrderCartabPage);
            this.OrderTabControl.Controls.Add(this.OrderCarPartsTab);
            this.OrderTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTabControl.Location = new System.Drawing.Point(222, 2);
            this.OrderTabControl.Multiline = true;
            this.OrderTabControl.Name = "OrderTabControl";
            this.OrderTabControl.SelectedIndex = 0;
            this.OrderTabControl.Size = new System.Drawing.Size(746, 688);
            this.OrderTabControl.TabIndex = 0;
            this.OrderTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OrderTabControl_DrawItem);
            // 
            // OrderCartabPage
            // 
            this.OrderCartabPage.BackColor = System.Drawing.Color.Black;
            this.OrderCartabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrderCartabPage.Controls.Add(this.CheckOutBtn);
            this.OrderCartabPage.Controls.Add(this.label5);
            this.OrderCartabPage.Controls.Add(this.ColourComboBox);
            this.OrderCartabPage.Controls.Add(this.label13);
            this.OrderCartabPage.Controls.Add(this.CarsCloseCartBtn);
            this.OrderCartabPage.Controls.Add(this.CarCartBtn);
            this.OrderCartabPage.Controls.Add(this.CarPictureBox);
            this.OrderCartabPage.Controls.Add(this.label11);
            this.OrderCartabPage.Controls.Add(this.CarStockTxtBox);
            this.OrderCartabPage.Controls.Add(this.CarClearCartItemsBtn);
            this.OrderCartabPage.Controls.Add(this.CarOrderCartItemsBtn);
            this.OrderCartabPage.Controls.Add(this.CarsCartGridView);
            this.OrderCartabPage.Controls.Add(this.CarOrderQtyBox);
            this.OrderCartabPage.Controls.Add(this.label1);
            this.OrderCartabPage.Controls.Add(this.label4);
            this.OrderCartabPage.Controls.Add(this.DescriptionTxtBox);
            this.OrderCartabPage.Controls.Add(this.CarComboBox);
            this.OrderCartabPage.Controls.Add(this.ResetBtn);
            this.OrderCartabPage.Controls.Add(this.AddToCartCarBtn);
            this.OrderCartabPage.Controls.Add(this.label3);
            this.OrderCartabPage.Controls.Add(this.label2);
            this.OrderCartabPage.Controls.Add(this.PriceTxtBox);
            this.OrderCartabPage.Controls.Add(this.YearTxtBox);
            this.OrderCartabPage.Controls.Add(this.CarsPanel);
            this.OrderCartabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCartabPage.Location = new System.Drawing.Point(4, 27);
            this.OrderCartabPage.Name = "OrderCartabPage";
            this.OrderCartabPage.Size = new System.Drawing.Size(738, 657);
            this.OrderCartabPage.TabIndex = 0;
            this.OrderCartabPage.Text = "Order Cars";
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.CheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.Location = new System.Drawing.Point(617, 344);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(107, 29);
            this.CheckOutBtn.TabIndex = 102;
            this.CheckOutBtn.Text = "CheckOut";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Car";
            // 
            // ColourComboBox
            // 
            this.ColourComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColourComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ColourComboBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ColourComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourComboBox.FormattingEnabled = true;
            this.ColourComboBox.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.ColourComboBox.Location = new System.Drawing.Point(164, 179);
            this.ColourComboBox.Name = "ColourComboBox";
            this.ColourComboBox.Size = new System.Drawing.Size(227, 24);
            this.ColourComboBox.TabIndex = 100;
            this.ColourComboBox.SelectedIndexChanged += new System.EventHandler(this.ColourComboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(10, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 99;
            this.label13.Text = "Colour";
            // 
            // CarsCloseCartBtn
            // 
            this.CarsCloseCartBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsCloseCartBtn.ForeColor = System.Drawing.Color.Black;
            this.CarsCloseCartBtn.Location = new System.Drawing.Point(603, 10);
            this.CarsCloseCartBtn.Name = "CarsCloseCartBtn";
            this.CarsCloseCartBtn.Size = new System.Drawing.Size(130, 23);
            this.CarsCloseCartBtn.TabIndex = 98;
            this.CarsCloseCartBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CarsCloseCartBtn.UseVisualStyleBackColor = true;
            this.CarsCloseCartBtn.Click += new System.EventHandler(this.CarsCloseCartBtn_Click);
            // 
            // CarCartBtn
            // 
            this.CarCartBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarCartBtn.Location = new System.Drawing.Point(603, 11);
            this.CarCartBtn.Name = "CarCartBtn";
            this.CarCartBtn.Size = new System.Drawing.Size(130, 23);
            this.CarCartBtn.TabIndex = 96;
            this.CarCartBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CarCartBtn.UseVisualStyleBackColor = true;
            this.CarCartBtn.Click += new System.EventHandler(this.CarCartBtn_Click);
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.Location = new System.Drawing.Point(404, 42);
            this.CarPictureBox.Name = "CarPictureBox";
            this.CarPictureBox.Size = new System.Drawing.Size(329, 283);
            this.CarPictureBox.TabIndex = 93;
            this.CarPictureBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Available Quantity";
            // 
            // CarStockTxtBox
            // 
            this.CarStockTxtBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CarStockTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarStockTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarStockTxtBox.Location = new System.Drawing.Point(164, 255);
            this.CarStockTxtBox.Name = "CarStockTxtBox";
            this.CarStockTxtBox.ReadOnly = true;
            this.CarStockTxtBox.Size = new System.Drawing.Size(227, 22);
            this.CarStockTxtBox.TabIndex = 91;
            // 
            // CarClearCartItemsBtn
            // 
            this.CarClearCartItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.CarClearCartItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarClearCartItemsBtn.Location = new System.Drawing.Point(392, 625);
            this.CarClearCartItemsBtn.Name = "CarClearCartItemsBtn";
            this.CarClearCartItemsBtn.Size = new System.Drawing.Size(163, 26);
            this.CarClearCartItemsBtn.TabIndex = 90;
            this.CarClearCartItemsBtn.Text = "Clear Cart Items";
            this.CarClearCartItemsBtn.UseVisualStyleBackColor = false;
            this.CarClearCartItemsBtn.Click += new System.EventHandler(this.CarClearCartItemsBtn_Click);
            // 
            // CarOrderCartItemsBtn
            // 
            this.CarOrderCartItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.CarOrderCartItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarOrderCartItemsBtn.Location = new System.Drawing.Point(561, 625);
            this.CarOrderCartItemsBtn.Name = "CarOrderCartItemsBtn";
            this.CarOrderCartItemsBtn.Size = new System.Drawing.Size(163, 26);
            this.CarOrderCartItemsBtn.TabIndex = 88;
            this.CarOrderCartItemsBtn.Text = "Order Cart Items";
            this.CarOrderCartItemsBtn.UseVisualStyleBackColor = false;
            this.CarOrderCartItemsBtn.Click += new System.EventHandler(this.CarOrderCartItemsBtn_Click);
            // 
            // CarsCartGridView
            // 
            this.CarsCartGridView.AllowUserToAddRows = false;
            this.CarsCartGridView.AllowUserToDeleteRows = false;
            this.CarsCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.CarName,
            this.YOM,
            this.Colour,
            this.Price,
            this.Description,
            this.AvailableStock,
            this.OrderQty,
            this.SubTot,
            this.Remove,
            this.DetailID});
            this.CarsCartGridView.Location = new System.Drawing.Point(4, 381);
            this.CarsCartGridView.Name = "CarsCartGridView";
            this.CarsCartGridView.ReadOnly = true;
            this.CarsCartGridView.Size = new System.Drawing.Size(729, 240);
            this.CarsCartGridView.TabIndex = 64;
            this.CarsCartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsCartGridView_CellClick);
            this.CarsCartGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CarsCartGridView_CellPainting);
            // 
            // CarID
            // 
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.Visible = false;
            // 
            // CarName
            // 
            this.CarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarName.HeaderText = "Car Name";
            this.CarName.Name = "CarName";
            this.CarName.ReadOnly = true;
            // 
            // YOM
            // 
            this.YOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YOM.HeaderText = "Year Of Manufacture";
            this.YOM.Name = "YOM";
            this.YOM.ReadOnly = true;
            // 
            // Colour
            // 
            this.Colour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AvailableStock
            // 
            this.AvailableStock.HeaderText = "Available Stock";
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.ReadOnly = true;
            this.AvailableStock.Visible = false;
            // 
            // OrderQty
            // 
            this.OrderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderQty.HeaderText = "Order Quantity";
            this.OrderQty.Name = "OrderQty";
            this.OrderQty.ReadOnly = true;
            // 
            // SubTot
            // 
            this.SubTot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTot.HeaderText = "Sub Total";
            this.SubTot.Name = "SubTot";
            this.SubTot.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // DetailID
            // 
            this.DetailID.HeaderText = "DetailID";
            this.DetailID.Name = "DetailID";
            this.DetailID.ReadOnly = true;
            this.DetailID.Visible = false;
            // 
            // CarOrderQtyBox
            // 
            this.CarOrderQtyBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CarOrderQtyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarOrderQtyBox.Location = new System.Drawing.Point(164, 303);
            this.CarOrderQtyBox.Name = "CarOrderQtyBox";
            this.CarOrderQtyBox.Size = new System.Drawing.Size(120, 22);
            this.CarOrderQtyBox.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Description";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DescriptionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxtBox.Location = new System.Drawing.Point(164, 112);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.ReadOnly = true;
            this.DescriptionTxtBox.Size = new System.Drawing.Size(227, 57);
            this.DescriptionTxtBox.TabIndex = 59;
            // 
            // CarComboBox
            // 
            this.CarComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CarComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CarComboBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarComboBox.FormattingEnabled = true;
            this.CarComboBox.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.CarComboBox.Location = new System.Drawing.Point(164, 42);
            this.CarComboBox.Name = "CarComboBox";
            this.CarComboBox.Size = new System.Drawing.Size(227, 24);
            this.CarComboBox.TabIndex = 58;
            this.CarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarComboBox_SelectedIndexChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(164, 344);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(103, 29);
            this.ResetBtn.TabIndex = 48;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddToCartCarBtn
            // 
            this.AddToCartCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.AddToCartCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartCarBtn.Location = new System.Drawing.Point(284, 344);
            this.AddToCartCarBtn.Name = "AddToCartCarBtn";
            this.AddToCartCarBtn.Size = new System.Drawing.Size(107, 29);
            this.AddToCartCarBtn.TabIndex = 46;
            this.AddToCartCarBtn.Text = "Add To Cart";
            this.AddToCartCarBtn.UseVisualStyleBackColor = false;
            this.AddToCartCarBtn.Click += new System.EventHandler(this.AddToCartCarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Year";
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PriceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxtBox.Location = new System.Drawing.Point(164, 219);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.ReadOnly = true;
            this.PriceTxtBox.Size = new System.Drawing.Size(227, 22);
            this.PriceTxtBox.TabIndex = 40;
            // 
            // YearTxtBox
            // 
            this.YearTxtBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.YearTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTxtBox.Location = new System.Drawing.Point(164, 81);
            this.YearTxtBox.Name = "YearTxtBox";
            this.YearTxtBox.ReadOnly = true;
            this.YearTxtBox.Size = new System.Drawing.Size(227, 22);
            this.YearTxtBox.TabIndex = 39;
            // 
            // CarsPanel
            // 
            this.CarsPanel.BackColor = System.Drawing.Color.Transparent;
            this.CarsPanel.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.digital_art_car_vehicle_wallpaper_preview;
            this.CarsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarsPanel.Location = new System.Drawing.Point(4, 5);
            this.CarsPanel.Name = "CarsPanel";
            this.CarsPanel.Size = new System.Drawing.Size(487, 378);
            this.CarsPanel.TabIndex = 101;
            // 
            // OrderCarPartsTab
            // 
            this.OrderCarPartsTab.BackColor = System.Drawing.Color.Black;
            this.OrderCarPartsTab.Controls.Add(this.PartsCheckOutBtn);
            this.OrderCarPartsTab.Controls.Add(this.PartsCloseCartBtn);
            this.OrderCarPartsTab.Controls.Add(this.CartBtn);
            this.OrderCarPartsTab.Controls.Add(this.PartsPictureBox);
            this.OrderCarPartsTab.Controls.Add(this.ClearCartItemsBtn);
            this.OrderCarPartsTab.Controls.Add(this.OrderCartItemsBtn);
            this.OrderCarPartsTab.Controls.Add(this.PartsCartGridView);
            this.OrderCarPartsTab.Controls.Add(this.label12);
            this.OrderCarPartsTab.Controls.Add(this.PartsStockTxtBox);
            this.OrderCarPartsTab.Controls.Add(this.OrderQtyBox);
            this.OrderCarPartsTab.Controls.Add(this.label10);
            this.OrderCarPartsTab.Controls.Add(this.label7);
            this.OrderCarPartsTab.Controls.Add(this.PartsDescriptionTxtBox);
            this.OrderCarPartsTab.Controls.Add(this.label9);
            this.OrderCarPartsTab.Controls.Add(this.PartsPriceTxtBox);
            this.OrderCarPartsTab.Controls.Add(this.PartNameComboBox);
            this.OrderCarPartsTab.Controls.Add(this.label6);
            this.OrderCarPartsTab.Controls.Add(this.CarPartCarComboBox);
            this.OrderCarPartsTab.Controls.Add(this.PartsResetBtn);
            this.OrderCarPartsTab.Controls.Add(this.AddToCartBtn);
            this.OrderCarPartsTab.Controls.Add(this.label8);
            this.OrderCarPartsTab.Controls.Add(this.flowLayoutPanel1);
            this.OrderCarPartsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OrderCarPartsTab.ForeColor = System.Drawing.Color.Black;
            this.OrderCarPartsTab.Location = new System.Drawing.Point(4, 27);
            this.OrderCarPartsTab.Name = "OrderCarPartsTab";
            this.OrderCarPartsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderCarPartsTab.Size = new System.Drawing.Size(738, 657);
            this.OrderCarPartsTab.TabIndex = 1;
            this.OrderCarPartsTab.Text = "Order Car Parts";
            // 
            // PartsCheckOutBtn
            // 
            this.PartsCheckOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.PartsCheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsCheckOutBtn.Location = new System.Drawing.Point(613, 338);
            this.PartsCheckOutBtn.Name = "PartsCheckOutBtn";
            this.PartsCheckOutBtn.Size = new System.Drawing.Size(107, 29);
            this.PartsCheckOutBtn.TabIndex = 103;
            this.PartsCheckOutBtn.Text = "CheckOut";
            this.PartsCheckOutBtn.UseVisualStyleBackColor = false;
            this.PartsCheckOutBtn.Click += new System.EventHandler(this.PartsCheckOutBtn_Click);
            // 
            // PartsCloseCartBtn
            // 
            this.PartsCloseCartBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsCloseCartBtn.ForeColor = System.Drawing.Color.Black;
            this.PartsCloseCartBtn.Location = new System.Drawing.Point(604, 2);
            this.PartsCloseCartBtn.Name = "PartsCloseCartBtn";
            this.PartsCloseCartBtn.Size = new System.Drawing.Size(130, 23);
            this.PartsCloseCartBtn.TabIndex = 99;
            this.PartsCloseCartBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PartsCloseCartBtn.UseVisualStyleBackColor = true;
            this.PartsCloseCartBtn.Click += new System.EventHandler(this.PartsCloseCartBtn_Click);
            // 
            // CartBtn
            // 
            this.CartBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBtn.ForeColor = System.Drawing.Color.Black;
            this.CartBtn.Location = new System.Drawing.Point(603, 3);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(130, 23);
            this.CartBtn.TabIndex = 95;
            this.CartBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CartBtn.UseVisualStyleBackColor = true;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // PartsPictureBox
            // 
            this.PartsPictureBox.Location = new System.Drawing.Point(404, 40);
            this.PartsPictureBox.Name = "PartsPictureBox";
            this.PartsPictureBox.Size = new System.Drawing.Size(329, 283);
            this.PartsPictureBox.TabIndex = 94;
            this.PartsPictureBox.TabStop = false;
            // 
            // ClearCartItemsBtn
            // 
            this.ClearCartItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ClearCartItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearCartItemsBtn.Location = new System.Drawing.Point(375, 625);
            this.ClearCartItemsBtn.Name = "ClearCartItemsBtn";
            this.ClearCartItemsBtn.Size = new System.Drawing.Size(163, 26);
            this.ClearCartItemsBtn.TabIndex = 87;
            this.ClearCartItemsBtn.Text = "Clear Cart Items";
            this.ClearCartItemsBtn.UseVisualStyleBackColor = false;
            this.ClearCartItemsBtn.Click += new System.EventHandler(this.ClearCartItemsBtn_Click);
            // 
            // OrderCartItemsBtn
            // 
            this.OrderCartItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.OrderCartItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.OrderCartItemsBtn.Location = new System.Drawing.Point(557, 625);
            this.OrderCartItemsBtn.Name = "OrderCartItemsBtn";
            this.OrderCartItemsBtn.Size = new System.Drawing.Size(163, 26);
            this.OrderCartItemsBtn.TabIndex = 85;
            this.OrderCartItemsBtn.Text = "Order Cart Items";
            this.OrderCartItemsBtn.UseVisualStyleBackColor = false;
            this.OrderCartItemsBtn.Click += new System.EventHandler(this.OrderCartItemsBtn_Click);
            // 
            // PartsCartGridView
            // 
            this.PartsCartGridView.AllowUserToAddRows = false;
            this.PartsCartGridView.AllowUserToDeleteRows = false;
            this.PartsCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.CarTypeColumn,
            this.PartNameColumn,
            this.PriceColumn,
            this.DescriptionColumn,
            this.AvailableQuantityColumn,
            this.OrderQuantityColumn,
            this.SubTotal,
            this.PartRemove});
            this.PartsCartGridView.Location = new System.Drawing.Point(6, 373);
            this.PartsCartGridView.Name = "PartsCartGridView";
            this.PartsCartGridView.ReadOnly = true;
            this.PartsCartGridView.Size = new System.Drawing.Size(730, 251);
            this.PartsCartGridView.TabIndex = 1;
            this.PartsCartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsCartGridView_CellClick);
            this.PartsCartGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.PartsCartGridView_CellPainting);
            // 
            // PartId
            // 
            this.PartId.HeaderText = "PartId";
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            this.PartId.Visible = false;
            // 
            // CarTypeColumn
            // 
            this.CarTypeColumn.HeaderText = "Car Type";
            this.CarTypeColumn.Name = "CarTypeColumn";
            this.CarTypeColumn.ReadOnly = true;
            // 
            // PartNameColumn
            // 
            this.PartNameColumn.HeaderText = "Part Name";
            this.PartNameColumn.Name = "PartNameColumn";
            this.PartNameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // AvailableQuantityColumn
            // 
            this.AvailableQuantityColumn.HeaderText = "Available Quantity";
            this.AvailableQuantityColumn.Name = "AvailableQuantityColumn";
            this.AvailableQuantityColumn.ReadOnly = true;
            this.AvailableQuantityColumn.Visible = false;
            // 
            // OrderQuantityColumn
            // 
            this.OrderQuantityColumn.HeaderText = "Order Quantity";
            this.OrderQuantityColumn.Name = "OrderQuantityColumn";
            this.OrderQuantityColumn.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // PartRemove
            // 
            this.PartRemove.HeaderText = "Action";
            this.PartRemove.Name = "PartRemove";
            this.PartRemove.ReadOnly = true;
            this.PartRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PartRemove.Text = "Remove";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 84;
            this.label12.Text = "Available Quantity";
            // 
            // PartsStockTxtBox
            // 
            this.PartsStockTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsStockTxtBox.Location = new System.Drawing.Point(165, 247);
            this.PartsStockTxtBox.Name = "PartsStockTxtBox";
            this.PartsStockTxtBox.ReadOnly = true;
            this.PartsStockTxtBox.Size = new System.Drawing.Size(227, 22);
            this.PartsStockTxtBox.TabIndex = 83;
            // 
            // OrderQtyBox
            // 
            this.OrderQtyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderQtyBox.Location = new System.Drawing.Point(165, 292);
            this.OrderQtyBox.Name = "OrderQtyBox";
            this.OrderQtyBox.Size = new System.Drawing.Size(120, 22);
            this.OrderQtyBox.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Order Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Description";
            // 
            // PartsDescriptionTxtBox
            // 
            this.PartsDescriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsDescriptionTxtBox.Location = new System.Drawing.Point(165, 172);
            this.PartsDescriptionTxtBox.Multiline = true;
            this.PartsDescriptionTxtBox.Name = "PartsDescriptionTxtBox";
            this.PartsDescriptionTxtBox.ReadOnly = true;
            this.PartsDescriptionTxtBox.Size = new System.Drawing.Size(227, 57);
            this.PartsDescriptionTxtBox.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Price";
            // 
            // PartsPriceTxtBox
            // 
            this.PartsPriceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsPriceTxtBox.Location = new System.Drawing.Point(165, 129);
            this.PartsPriceTxtBox.Name = "PartsPriceTxtBox";
            this.PartsPriceTxtBox.ReadOnly = true;
            this.PartsPriceTxtBox.Size = new System.Drawing.Size(227, 22);
            this.PartsPriceTxtBox.TabIndex = 76;
            // 
            // PartNameComboBox
            // 
            this.PartNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PartNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PartNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameComboBox.FormattingEnabled = true;
            this.PartNameComboBox.Location = new System.Drawing.Point(165, 86);
            this.PartNameComboBox.Name = "PartNameComboBox";
            this.PartNameComboBox.Size = new System.Drawing.Size(227, 24);
            this.PartNameComboBox.TabIndex = 74;
            this.PartNameComboBox.SelectedIndexChanged += new System.EventHandler(this.PartNameComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Part Name";
            // 
            // CarPartCarComboBox
            // 
            this.CarPartCarComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CarPartCarComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CarPartCarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPartCarComboBox.FormattingEnabled = true;
            this.CarPartCarComboBox.Location = new System.Drawing.Point(165, 42);
            this.CarPartCarComboBox.Name = "CarPartCarComboBox";
            this.CarPartCarComboBox.Size = new System.Drawing.Size(227, 24);
            this.CarPartCarComboBox.TabIndex = 72;
            this.CarPartCarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarPartCarComboBox_SelectedIndexChanged);
            // 
            // PartsResetBtn
            // 
            this.PartsResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.PartsResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PartsResetBtn.Location = new System.Drawing.Point(156, 336);
            this.PartsResetBtn.Name = "PartsResetBtn";
            this.PartsResetBtn.Size = new System.Drawing.Size(103, 29);
            this.PartsResetBtn.TabIndex = 68;
            this.PartsResetBtn.Text = "Reset";
            this.PartsResetBtn.UseVisualStyleBackColor = false;
            this.PartsResetBtn.Click += new System.EventHandler(this.PartsResetBtn_Click);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.AddToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddToCartBtn.Location = new System.Drawing.Point(285, 336);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(107, 29);
            this.AddToCartBtn.TabIndex = 67;
            this.AddToCartBtn.Text = "Add to Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Car Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.Parts;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(730, 375);
            this.flowLayoutPanel1.TabIndex = 105;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.Black;
            this.DashboardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DashboardPanel.Location = new System.Drawing.Point(9, 1);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(218, 685);
            this.DashboardPanel.TabIndex = 104;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(966, 685);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.OrderTabControl);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderTabControl.ResumeLayout(false);
            this.OrderCartabPage.ResumeLayout(false);
            this.OrderCartabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarOrderQtyBox)).EndInit();
            this.OrderCarPartsTab.ResumeLayout(false);
            this.OrderCarPartsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderQtyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OrderTabControl;
        private System.Windows.Forms.TabPage OrderCartabPage;
        private System.Windows.Forms.TabPage OrderCarPartsTab;
        private System.Windows.Forms.ComboBox CarComboBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button AddToCartCarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox YearTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.NumericUpDown CarOrderQtyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CarPartCarComboBox;
        private System.Windows.Forms.Button PartsResetBtn;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PartsDescriptionTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PartsPriceTxtBox;
        private System.Windows.Forms.ComboBox PartNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PartsStockTxtBox;
        private System.Windows.Forms.NumericUpDown OrderQtyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView CarsCartGridView;
        private System.Windows.Forms.DataGridView PartsCartGridView;
        private System.Windows.Forms.Button OrderCartItemsBtn;
        private System.Windows.Forms.Button ClearCartItemsBtn;
        private System.Windows.Forms.Button CarClearCartItemsBtn;
        private System.Windows.Forms.Button CarOrderCartItemsBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CarStockTxtBox;
        private System.Windows.Forms.PictureBox CarPictureBox;
        private System.Windows.Forms.PictureBox PartsPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn PartRemove;
        private System.Windows.Forms.Button CartBtn;
        private System.Windows.Forms.Button CarCartBtn;
        private System.Windows.Forms.Button CarsCloseCartBtn;
        private System.Windows.Forms.Button PartsCloseCartBtn;
        private System.Windows.Forms.ComboBox ColourComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTot;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.FlowLayoutPanel CarsPanel;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.Button PartsCheckOutBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel DashboardPanel;
    }
}