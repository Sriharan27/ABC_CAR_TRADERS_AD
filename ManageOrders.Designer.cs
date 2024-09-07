namespace ABC_Car_Traders
{
    partial class ManageOrders
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
            this.AdminOrderManagement = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.InsMessLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderLineItemsLbl = new System.Windows.Forms.Label();
            this.OrderLineItemsGridView = new System.Windows.Forms.DataGridView();
            this.OLIOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailsGridView = new System.Windows.Forms.DataGridView();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPhNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CancelOrderBtn = new System.Windows.Forms.Button();
            this.DispatchOrderBtn = new System.Windows.Forms.Button();
            this.CarOrderIDTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.PSearchTxtBox = new System.Windows.Forms.TextBox();
            this.PartsInstructionsLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartsOrderLineItemLbl = new System.Windows.Forms.Label();
            this.PartsLineItemGridView = new System.Windows.Forms.DataGridView();
            this.POrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POrderItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsOrderDetailsGridView = new System.Windows.Forms.DataGridView();
            this.PartsOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsTotalOrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsCustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsCustPhNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsCustAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsResetBtn = new System.Windows.Forms.Button();
            this.PartsCancelOrderBtn = new System.Windows.Forms.Button();
            this.PartsDispatchOrderBtn = new System.Windows.Forms.Button();
            this.PartsOrderIdTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.AdminOrderManagement.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLineItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsLineItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsOrderDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminOrderManagement
            // 
            this.AdminOrderManagement.Controls.Add(this.tabPage1);
            this.AdminOrderManagement.Controls.Add(this.tabPage2);
            this.AdminOrderManagement.Location = new System.Drawing.Point(226, 1);
            this.AdminOrderManagement.Name = "AdminOrderManagement";
            this.AdminOrderManagement.SelectedIndex = 0;
            this.AdminOrderManagement.Size = new System.Drawing.Size(887, 646);
            this.AdminOrderManagement.TabIndex = 0;
            this.AdminOrderManagement.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.AdminOrderManagement_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.SearchTxtBox);
            this.tabPage1.Controls.Add(this.InsMessLbl);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.OrderLineItemsLbl);
            this.tabPage1.Controls.Add(this.OrderLineItemsGridView);
            this.tabPage1.Controls.Add(this.OrderDetailsGridView);
            this.tabPage1.Controls.Add(this.ResetBtn);
            this.tabPage1.Controls.Add(this.CancelOrderBtn);
            this.tabPage1.Controls.Add(this.DispatchOrderBtn);
            this.tabPage1.Controls.Add(this.CarOrderIDTxtBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Car Orders";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(2, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Global Search";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(99, 90);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(120, 20);
            this.SearchTxtBox.TabIndex = 55;
            this.SearchTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTxtBox_KeyUp);
            // 
            // InsMessLbl
            // 
            this.InsMessLbl.AutoSize = true;
            this.InsMessLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.InsMessLbl.Location = new System.Drawing.Point(265, 97);
            this.InsMessLbl.Name = "InsMessLbl";
            this.InsMessLbl.Size = new System.Drawing.Size(326, 13);
            this.InsMessLbl.TabIndex = 10;
            this.InsMessLbl.Text = "Select A Order From The Below Table to View The Order Line Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(354, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderLineItemsLbl
            // 
            this.OrderLineItemsLbl.AutoSize = true;
            this.OrderLineItemsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLineItemsLbl.ForeColor = System.Drawing.Color.White;
            this.OrderLineItemsLbl.Location = new System.Drawing.Point(339, 377);
            this.OrderLineItemsLbl.Name = "OrderLineItemsLbl";
            this.OrderLineItemsLbl.Size = new System.Drawing.Size(170, 25);
            this.OrderLineItemsLbl.TabIndex = 7;
            this.OrderLineItemsLbl.Text = "Order Line Items";
            this.OrderLineItemsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderLineItemsGridView
            // 
            this.OrderLineItemsGridView.AllowUserToAddRows = false;
            this.OrderLineItemsGridView.AllowUserToDeleteRows = false;
            this.OrderLineItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderLineItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OLIOrderID,
            this.OrderItemID,
            this.Car,
            this.Colour,
            this.Year,
            this.UnitPrice,
            this.Quantity,
            this.TotalPrice,
            this.ItemID});
            this.OrderLineItemsGridView.Location = new System.Drawing.Point(3, 412);
            this.OrderLineItemsGridView.Name = "OrderLineItemsGridView";
            this.OrderLineItemsGridView.ReadOnly = true;
            this.OrderLineItemsGridView.Size = new System.Drawing.Size(863, 200);
            this.OrderLineItemsGridView.TabIndex = 6;
            // 
            // OLIOrderID
            // 
            this.OLIOrderID.HeaderText = "Order ID";
            this.OLIOrderID.Name = "OLIOrderID";
            this.OLIOrderID.ReadOnly = true;
            // 
            // OrderItemID
            // 
            this.OrderItemID.HeaderText = "Order Item ID";
            this.OrderItemID.Name = "OrderItemID";
            this.OrderItemID.ReadOnly = true;
            // 
            // Car
            // 
            this.Car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Car.HeaderText = "Car Type";
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            // 
            // Colour
            // 
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.HeaderText = "Year Of Manufacture";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Order Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Amount";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // OrderDetailsGridView
            // 
            this.OrderDetailsGridView.AllowUserToAddRows = false;
            this.OrderDetailsGridView.AllowUserToDeleteRows = false;
            this.OrderDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDate,
            this.OrderID,
            this.TotalOrderAmount,
            this.CustName,
            this.CustEmail,
            this.CustPhNo,
            this.CustAddress});
            this.OrderDetailsGridView.Location = new System.Drawing.Point(3, 113);
            this.OrderDetailsGridView.Name = "OrderDetailsGridView";
            this.OrderDetailsGridView.ReadOnly = true;
            this.OrderDetailsGridView.Size = new System.Drawing.Size(863, 249);
            this.OrderDetailsGridView.TabIndex = 5;
            this.OrderDetailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDetailsGridView_CellClick);
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // TotalOrderAmount
            // 
            this.TotalOrderAmount.HeaderText = "Total Order Amount";
            this.TotalOrderAmount.Name = "TotalOrderAmount";
            this.TotalOrderAmount.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Customer Name";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // CustEmail
            // 
            this.CustEmail.HeaderText = "Customer Email";
            this.CustEmail.Name = "CustEmail";
            this.CustEmail.ReadOnly = true;
            // 
            // CustPhNo
            // 
            this.CustPhNo.HeaderText = "Customer Phone Num";
            this.CustPhNo.Name = "CustPhNo";
            this.CustPhNo.ReadOnly = true;
            // 
            // CustAddress
            // 
            this.CustAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustAddress.HeaderText = "Customer Address";
            this.CustAddress.Name = "CustAddress";
            this.CustAddress.ReadOnly = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(237, 21);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CancelOrderBtn
            // 
            this.CancelOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.CancelOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrderBtn.ForeColor = System.Drawing.Color.White;
            this.CancelOrderBtn.Location = new System.Drawing.Point(466, 21);
            this.CancelOrderBtn.Name = "CancelOrderBtn";
            this.CancelOrderBtn.Size = new System.Drawing.Size(88, 23);
            this.CancelOrderBtn.TabIndex = 3;
            this.CancelOrderBtn.Text = "Cancel Order";
            this.CancelOrderBtn.UseVisualStyleBackColor = false;
            this.CancelOrderBtn.Click += new System.EventHandler(this.CancelOrderBtn_Click);
            // 
            // DispatchOrderBtn
            // 
            this.DispatchOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.DispatchOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispatchOrderBtn.ForeColor = System.Drawing.Color.White;
            this.DispatchOrderBtn.Location = new System.Drawing.Point(342, 21);
            this.DispatchOrderBtn.Name = "DispatchOrderBtn";
            this.DispatchOrderBtn.Size = new System.Drawing.Size(94, 23);
            this.DispatchOrderBtn.TabIndex = 2;
            this.DispatchOrderBtn.Text = "Dispatch Order";
            this.DispatchOrderBtn.UseVisualStyleBackColor = false;
            this.DispatchOrderBtn.Click += new System.EventHandler(this.DispatchOrderBtn_Click);
            // 
            // CarOrderIDTxtBox
            // 
            this.CarOrderIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarOrderIDTxtBox.Location = new System.Drawing.Point(96, 21);
            this.CarOrderIDTxtBox.Name = "CarOrderIDTxtBox";
            this.CarOrderIDTxtBox.ReadOnly = true;
            this.CarOrderIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.CarOrderIDTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.PSearchTxtBox);
            this.tabPage2.Controls.Add(this.PartsInstructionsLbl);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.PartsOrderLineItemLbl);
            this.tabPage2.Controls.Add(this.PartsLineItemGridView);
            this.tabPage2.Controls.Add(this.PartsOrderDetailsGridView);
            this.tabPage2.Controls.Add(this.PartsResetBtn);
            this.tabPage2.Controls.Add(this.PartsCancelOrderBtn);
            this.tabPage2.Controls.Add(this.PartsDispatchOrderBtn);
            this.tabPage2.Controls.Add(this.PartsOrderIdTxtBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Car Parts Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Global Search";
            // 
            // PSearchTxtBox
            // 
            this.PSearchTxtBox.Location = new System.Drawing.Point(99, 90);
            this.PSearchTxtBox.Name = "PSearchTxtBox";
            this.PSearchTxtBox.Size = new System.Drawing.Size(120, 20);
            this.PSearchTxtBox.TabIndex = 57;
            this.PSearchTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PSearchTxtBox_KeyUp);
            // 
            // PartsInstructionsLbl
            // 
            this.PartsInstructionsLbl.AutoSize = true;
            this.PartsInstructionsLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.PartsInstructionsLbl.Location = new System.Drawing.Point(265, 97);
            this.PartsInstructionsLbl.Name = "PartsInstructionsLbl";
            this.PartsInstructionsLbl.Size = new System.Drawing.Size(326, 13);
            this.PartsInstructionsLbl.TabIndex = 20;
            this.PartsInstructionsLbl.Text = "Select A Order From The Below Table to View The Order Line Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(354, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PartsOrderLineItemLbl
            // 
            this.PartsOrderLineItemLbl.AutoSize = true;
            this.PartsOrderLineItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsOrderLineItemLbl.ForeColor = System.Drawing.Color.White;
            this.PartsOrderLineItemLbl.Location = new System.Drawing.Point(339, 377);
            this.PartsOrderLineItemLbl.Name = "PartsOrderLineItemLbl";
            this.PartsOrderLineItemLbl.Size = new System.Drawing.Size(170, 25);
            this.PartsOrderLineItemLbl.TabIndex = 18;
            this.PartsOrderLineItemLbl.Text = "Order Line Items";
            this.PartsOrderLineItemLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PartsLineItemGridView
            // 
            this.PartsLineItemGridView.AllowUserToAddRows = false;
            this.PartsLineItemGridView.AllowUserToDeleteRows = false;
            this.PartsLineItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsLineItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.POrderID,
            this.POrderItemID,
            this.PartName,
            this.CarType,
            this.PUnitPrice,
            this.OQuantity,
            this.PTotAmount,
            this.PartID});
            this.PartsLineItemGridView.Location = new System.Drawing.Point(3, 412);
            this.PartsLineItemGridView.Name = "PartsLineItemGridView";
            this.PartsLineItemGridView.ReadOnly = true;
            this.PartsLineItemGridView.Size = new System.Drawing.Size(863, 200);
            this.PartsLineItemGridView.TabIndex = 17;
            // 
            // POrderID
            // 
            this.POrderID.HeaderText = "Order ID";
            this.POrderID.Name = "POrderID";
            this.POrderID.ReadOnly = true;
            // 
            // POrderItemID
            // 
            this.POrderItemID.HeaderText = "Order Item ID";
            this.POrderItemID.Name = "POrderItemID";
            this.POrderItemID.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarType.HeaderText = "Car Type";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // PUnitPrice
            // 
            this.PUnitPrice.HeaderText = "Unit Price";
            this.PUnitPrice.Name = "PUnitPrice";
            this.PUnitPrice.ReadOnly = true;
            // 
            // OQuantity
            // 
            this.OQuantity.HeaderText = "Order Quantity";
            this.OQuantity.Name = "OQuantity";
            this.OQuantity.ReadOnly = true;
            // 
            // PTotAmount
            // 
            this.PTotAmount.HeaderText = "Total Amount";
            this.PTotAmount.Name = "PTotAmount";
            this.PTotAmount.ReadOnly = true;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "ItemID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Visible = false;
            // 
            // PartsOrderDetailsGridView
            // 
            this.PartsOrderDetailsGridView.AllowUserToAddRows = false;
            this.PartsOrderDetailsGridView.AllowUserToDeleteRows = false;
            this.PartsOrderDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsOrderDetailsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartsOrderDate,
            this.PartsOrderID,
            this.PartsTotalOrderAmount,
            this.PartsCustName,
            this.PartsCustEmail,
            this.PartsCustPhNo,
            this.PartsCustAddress});
            this.PartsOrderDetailsGridView.Location = new System.Drawing.Point(3, 113);
            this.PartsOrderDetailsGridView.Name = "PartsOrderDetailsGridView";
            this.PartsOrderDetailsGridView.ReadOnly = true;
            this.PartsOrderDetailsGridView.Size = new System.Drawing.Size(863, 249);
            this.PartsOrderDetailsGridView.TabIndex = 16;
            this.PartsOrderDetailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsOrderDetailsGridView_CellClick);
            // 
            // PartsOrderDate
            // 
            this.PartsOrderDate.HeaderText = "Order Date";
            this.PartsOrderDate.Name = "PartsOrderDate";
            this.PartsOrderDate.ReadOnly = true;
            // 
            // PartsOrderID
            // 
            this.PartsOrderID.HeaderText = "Order ID";
            this.PartsOrderID.Name = "PartsOrderID";
            this.PartsOrderID.ReadOnly = true;
            // 
            // PartsTotalOrderAmount
            // 
            this.PartsTotalOrderAmount.HeaderText = "Total Order Amount";
            this.PartsTotalOrderAmount.Name = "PartsTotalOrderAmount";
            this.PartsTotalOrderAmount.ReadOnly = true;
            // 
            // PartsCustName
            // 
            this.PartsCustName.HeaderText = "Customer Name";
            this.PartsCustName.Name = "PartsCustName";
            this.PartsCustName.ReadOnly = true;
            // 
            // PartsCustEmail
            // 
            this.PartsCustEmail.HeaderText = "Customer Email";
            this.PartsCustEmail.Name = "PartsCustEmail";
            this.PartsCustEmail.ReadOnly = true;
            // 
            // PartsCustPhNo
            // 
            this.PartsCustPhNo.HeaderText = "Customer Phone Num";
            this.PartsCustPhNo.Name = "PartsCustPhNo";
            this.PartsCustPhNo.ReadOnly = true;
            // 
            // PartsCustAddress
            // 
            this.PartsCustAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartsCustAddress.HeaderText = "Customer Address";
            this.PartsCustAddress.Name = "PartsCustAddress";
            this.PartsCustAddress.ReadOnly = true;
            // 
            // PartsResetBtn
            // 
            this.PartsResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.PartsResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsResetBtn.ForeColor = System.Drawing.Color.White;
            this.PartsResetBtn.Location = new System.Drawing.Point(237, 21);
            this.PartsResetBtn.Name = "PartsResetBtn";
            this.PartsResetBtn.Size = new System.Drawing.Size(75, 23);
            this.PartsResetBtn.TabIndex = 15;
            this.PartsResetBtn.Text = "Reset";
            this.PartsResetBtn.UseVisualStyleBackColor = false;
            this.PartsResetBtn.Click += new System.EventHandler(this.PartsResetBtn_Click);
            // 
            // PartsCancelOrderBtn
            // 
            this.PartsCancelOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.PartsCancelOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsCancelOrderBtn.ForeColor = System.Drawing.Color.White;
            this.PartsCancelOrderBtn.Location = new System.Drawing.Point(466, 21);
            this.PartsCancelOrderBtn.Name = "PartsCancelOrderBtn";
            this.PartsCancelOrderBtn.Size = new System.Drawing.Size(88, 23);
            this.PartsCancelOrderBtn.TabIndex = 14;
            this.PartsCancelOrderBtn.Text = "Cancel Order";
            this.PartsCancelOrderBtn.UseVisualStyleBackColor = false;
            this.PartsCancelOrderBtn.Click += new System.EventHandler(this.PartsCancelOrderBtn_Click);
            // 
            // PartsDispatchOrderBtn
            // 
            this.PartsDispatchOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.PartsDispatchOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsDispatchOrderBtn.ForeColor = System.Drawing.Color.White;
            this.PartsDispatchOrderBtn.Location = new System.Drawing.Point(342, 21);
            this.PartsDispatchOrderBtn.Name = "PartsDispatchOrderBtn";
            this.PartsDispatchOrderBtn.Size = new System.Drawing.Size(94, 23);
            this.PartsDispatchOrderBtn.TabIndex = 13;
            this.PartsDispatchOrderBtn.Text = "Dispatch Order";
            this.PartsDispatchOrderBtn.UseVisualStyleBackColor = false;
            this.PartsDispatchOrderBtn.Click += new System.EventHandler(this.PartsDispatchOrderBtn_Click);
            // 
            // PartsOrderIdTxtBox
            // 
            this.PartsOrderIdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsOrderIdTxtBox.Location = new System.Drawing.Point(96, 21);
            this.PartsOrderIdTxtBox.Name = "PartsOrderIdTxtBox";
            this.PartsOrderIdTxtBox.ReadOnly = true;
            this.PartsOrderIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PartsOrderIdTxtBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Order ID";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Location = new System.Drawing.Point(9, 1);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(222, 642);
            this.DashboardPanel.TabIndex = 80;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1098, 645);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.AdminOrderManagement);
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.AdminOrderManagement.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLineItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsLineItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsOrderDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminOrderManagement;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CancelOrderBtn;
        private System.Windows.Forms.Button DispatchOrderBtn;
        private System.Windows.Forms.TextBox CarOrderIDTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrderDetailsGridView;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.DataGridView OrderLineItemsGridView;
        private System.Windows.Forms.Label OrderLineItemsLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustAddress;
        private System.Windows.Forms.Label InsMessLbl;
        private System.Windows.Forms.Label PartsInstructionsLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PartsOrderLineItemLbl;
        private System.Windows.Forms.DataGridView PartsLineItemGridView;
        private System.Windows.Forms.DataGridView PartsOrderDetailsGridView;
        private System.Windows.Forms.Button PartsResetBtn;
        private System.Windows.Forms.Button PartsCancelOrderBtn;
        private System.Windows.Forms.Button PartsDispatchOrderBtn;
        private System.Windows.Forms.TextBox PartsOrderIdTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsTotalOrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsCustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsCustPhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsCustAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn POrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn POrderItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PSearchTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OLIOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.Panel DashboardPanel;
    }
}