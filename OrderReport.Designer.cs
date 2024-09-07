namespace ABC_Car_Traders
{
    partial class OrderReport
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
            this.PartsLineItemGridView = new System.Windows.Forms.DataGridView();
            this.POrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POrderItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderTypeComboBox = new System.Windows.Forms.ComboBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PartsLineItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLineItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGridView)).BeginInit();
            this.SuspendLayout();
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
            this.PartsLineItemGridView.Location = new System.Drawing.Point(243, 394);
            this.PartsLineItemGridView.Name = "PartsLineItemGridView";
            this.PartsLineItemGridView.ReadOnly = true;
            this.PartsLineItemGridView.Size = new System.Drawing.Size(863, 200);
            this.PartsLineItemGridView.TabIndex = 76;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Order Type";
            // 
            // OrderTypeComboBox
            // 
            this.OrderTypeComboBox.FormattingEnabled = true;
            this.OrderTypeComboBox.Items.AddRange(new object[] {
            "Cars",
            "Car Parts"});
            this.OrderTypeComboBox.Location = new System.Drawing.Point(351, 15);
            this.OrderTypeComboBox.Name = "OrderTypeComboBox";
            this.OrderTypeComboBox.Size = new System.Drawing.Size(134, 21);
            this.OrderTypeComboBox.TabIndex = 74;
            this.OrderTypeComboBox.Text = "Select an Order Type";
            this.OrderTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderTypeComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(889, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "Global Search";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(986, 72);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(120, 20);
            this.SearchTxtBox.TabIndex = 72;
            this.SearchTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTxtBox_KeyUp);
            // 
            // InsMessLbl
            // 
            this.InsMessLbl.AutoSize = true;
            this.InsMessLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.InsMessLbl.Location = new System.Drawing.Point(505, 79);
            this.InsMessLbl.Name = "InsMessLbl";
            this.InsMessLbl.Size = new System.Drawing.Size(326, 13);
            this.InsMessLbl.TabIndex = 71;
            this.InsMessLbl.Text = "Select A Order From The Below Table to View The Order Line Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(594, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Order Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderLineItemsLbl
            // 
            this.OrderLineItemsLbl.AutoSize = true;
            this.OrderLineItemsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLineItemsLbl.ForeColor = System.Drawing.Color.White;
            this.OrderLineItemsLbl.Location = new System.Drawing.Point(579, 359);
            this.OrderLineItemsLbl.Name = "OrderLineItemsLbl";
            this.OrderLineItemsLbl.Size = new System.Drawing.Size(170, 25);
            this.OrderLineItemsLbl.TabIndex = 69;
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
            this.OrderLineItemsGridView.Location = new System.Drawing.Point(243, 394);
            this.OrderLineItemsGridView.Name = "OrderLineItemsGridView";
            this.OrderLineItemsGridView.ReadOnly = true;
            this.OrderLineItemsGridView.Size = new System.Drawing.Size(863, 200);
            this.OrderLineItemsGridView.TabIndex = 68;
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
            this.OrderDetailsGridView.Location = new System.Drawing.Point(243, 95);
            this.OrderDetailsGridView.Name = "OrderDetailsGridView";
            this.OrderDetailsGridView.ReadOnly = true;
            this.OrderDetailsGridView.Size = new System.Drawing.Size(863, 249);
            this.OrderDetailsGridView.TabIndex = 67;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Order Status";
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Items.AddRange(new object[] {
            "Processing",
            "Dispatched",
            "Cancelled"});
            this.OrderStatusComboBox.Location = new System.Drawing.Point(351, 51);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(134, 21);
            this.OrderStatusComboBox.TabIndex = 77;
            this.OrderStatusComboBox.Text = "Select an Order Status";
            this.OrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStatusComboBox_SelectedIndexChanged);
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Location = new System.Drawing.Point(9, 8);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(222, 593);
            this.DashboardPanel.TabIndex = 79;
            // 
            // OrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1116, 606);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderStatusComboBox);
            this.Controls.Add(this.PartsLineItemGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderTypeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.InsMessLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderLineItemsLbl);
            this.Controls.Add(this.OrderLineItemsGridView);
            this.Controls.Add(this.OrderDetailsGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "OrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderReport";
            ((System.ComponentModel.ISupportInitialize)(this.PartsLineItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLineItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartsLineItemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn POrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn POrderItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrderTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label InsMessLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OrderLineItemsLbl;
        private System.Windows.Forms.DataGridView OrderLineItemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OLIOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridView OrderDetailsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.Panel DashboardPanel;
    }
}