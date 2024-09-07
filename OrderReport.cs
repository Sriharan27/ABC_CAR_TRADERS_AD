using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderReport : Form
    {
        private string connectionString;
        private int originalFormHeight;
        private int expandedFormHeight;
        private int userId = UserSession.UserId;
        private string userRole = UserSession.Role;

        //Constructor
        public OrderReport()
        {
            InitializeComponent();
            LoadDashboard();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            expandedFormHeight = this.Height;
            originalFormHeight = expandedFormHeight - OrderLineItemsGridView.Height - OrderLineItemsLbl.Height;
            this.Height = originalFormHeight;
            OrderLineItemsGridView.Visible = false;
            OrderLineItemsLbl.Visible = false;
            PartsLineItemGridView.Visible = false;
            OrderStatusComboBox.Enabled = false;
        }

        //Data Loading
        private void LoadOrderDetails(string selectedStatus, string selectedItem)
        {
            try
            {
                if (userRole == "Admin")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "select ORD.OrderDate as 'OrderDate', ORD.OrderID, ORD.TotalAmount as 'TotalOrderAmount', CONCAT(US.FirstName, ' ', US.LastName) as 'CustName', US.Email as 'CustEmail', US.Phone as 'CustPhNo', US.Address as 'CustAddress' from orders ORD " +
                                        "inner join users US on ORD.UserID = US.UserID " +
                                        "where ORD.ItemType = '" + selectedItem + "' and ORD.OrderStatus = '" + selectedStatus + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable OrderDetailsTable = new DataTable();
                        adapter.Fill(OrderDetailsTable);
                        OrderDetailsGridView.Columns["OrderDate"].DataPropertyName = "OrderDate";
                        OrderDetailsGridView.Columns["OrderID"].DataPropertyName = "OrderID";
                        OrderDetailsGridView.Columns["TotalOrderAmount"].DataPropertyName = "TotalOrderAmount";
                        OrderDetailsGridView.Columns["CustName"].DataPropertyName = "CustName";
                        OrderDetailsGridView.Columns["CustEmail"].DataPropertyName = "CustEmail";
                        OrderDetailsGridView.Columns["CustPhNo"].DataPropertyName = "CustPhNo";
                        OrderDetailsGridView.Columns["CustAddress"].DataPropertyName = "CustAddress";
                        OrderDetailsGridView.DataSource = OrderDetailsTable;
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "select ORD.OrderDate as 'OrderDate', ORD.OrderID, ORD.TotalAmount as 'TotalOrderAmount', CONCAT(US.FirstName, ' ', US.LastName) as 'CustName', US.Email as 'CustEmail', US.Phone as 'CustPhNo', US.Address as 'CustAddress' from orders ORD " +
                                        "inner join users US on ORD.UserID = US.UserID " +
                                        "where ORD.ItemType = '" + selectedItem + "' and ORD.OrderStatus = '" + selectedStatus + "' and ORD.UserID =  " + userId + "";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable OrderDetailsTable = new DataTable();
                        adapter.Fill(OrderDetailsTable);
                        OrderDetailsGridView.Columns["OrderDate"].DataPropertyName = "OrderDate";
                        OrderDetailsGridView.Columns["OrderID"].DataPropertyName = "OrderID";
                        OrderDetailsGridView.Columns["TotalOrderAmount"].DataPropertyName = "TotalOrderAmount";
                        OrderDetailsGridView.Columns["CustName"].DataPropertyName = "CustName";
                        OrderDetailsGridView.Columns["CustEmail"].DataPropertyName = "CustEmail";
                        OrderDetailsGridView.Columns["CustPhNo"].DataPropertyName = "CustPhNo";
                        OrderDetailsGridView.Columns["CustAddress"].DataPropertyName = "CustAddress";
                        OrderDetailsGridView.DataSource = OrderDetailsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadOrderLineItems(int orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select OI.OrderID as 'OLIOrderID', OI.OrderItemID, CONCAT(c.Make,' ',c.Model) as 'Car', CD.Colour, " +
                                   "c.Year, OI.UnitPrice, OI.Quantity, OI.TotalPrice, OI.ItemID from OrderItems OI " +
                                   "inner join CarDetails CD on CD.DetailID = OI.ItemID " +
                                   "inner join Cars C on C.CarID = CD.CarID " +
                                   "where OI.orderid = @orderId";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@orderId", orderId);

                    DataTable OrderLineItemsTable = new DataTable();
                    adapter.Fill(OrderLineItemsTable);

                    OrderLineItemsGridView.Columns["OLIOrderID"].DataPropertyName = "OLIOrderID";
                    OrderLineItemsGridView.Columns["OrderItemID"].DataPropertyName = "OrderItemID";
                    OrderLineItemsGridView.Columns["Car"].DataPropertyName = "Car";
                    OrderLineItemsGridView.Columns["Colour"].DataPropertyName = "Colour";
                    OrderLineItemsGridView.Columns["Year"].DataPropertyName = "Year";
                    OrderLineItemsGridView.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
                    OrderLineItemsGridView.Columns["Quantity"].DataPropertyName = "Quantity";
                    OrderLineItemsGridView.Columns["TotalPrice"].DataPropertyName = "TotalPrice";
                    OrderLineItemsGridView.Columns["ItemID"].DataPropertyName = "ItemID";

                    OrderLineItemsGridView.DataSource = OrderLineItemsTable;
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"An error occurred while accessing the database: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PartsLoadOrderLineItems(int orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select OI.OrderID as 'POrderID', OI.OrderItemID as 'POrderItemID', " +
                        "CP.PartName, CONCAT(c.Make,' ',c.Model) as 'CarType', OI.UnitPrice as 'PUnitPrice', " +
                        "OI.Quantity as 'OQuantity', OI.TotalPrice as 'PTotAmount', OI.ItemID as 'PartID' " +
                        "from OrderItems OI inner join CarParts CP on OI.ItemID = CP.PartID " +
                        "inner join Cars C on C.CarID = CP.CarID where OI.OrderID = @orderId";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@orderId", orderId);

                    DataTable PartsOrderLineItemsTable = new DataTable();
                    adapter.Fill(PartsOrderLineItemsTable);

                    PartsLineItemGridView.Columns["POrderID"].DataPropertyName = "POrderID";
                    PartsLineItemGridView.Columns["POrderItemID"].DataPropertyName = "POrderItemID";
                    PartsLineItemGridView.Columns["PartName"].DataPropertyName = "PartName";
                    PartsLineItemGridView.Columns["CarType"].DataPropertyName = "CarType";
                    PartsLineItemGridView.Columns["PUnitPrice"].DataPropertyName = "PUnitPrice";
                    PartsLineItemGridView.Columns["OQuantity"].DataPropertyName = "OQuantity";
                    PartsLineItemGridView.Columns["PTotAmount"].DataPropertyName = "PTotAmount";
                    PartsLineItemGridView.Columns["PartID"].DataPropertyName = "PartID";

                    PartsLineItemGridView.DataSource = PartsOrderLineItemsTable;
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"An error occurred while accessing the database: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UI Event Handlers
        private void OrderTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderStatusComboBox.Text = "Select an Order Status";
            OrderStatusComboBox.Enabled = true;
            Reset();
        }
        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            
            if (OrderTypeComboBox.SelectedItem == null) 
            {
                MessageBox.Show("Select an order type before selecting the status","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return; 
            }

            string selectedItem = OrderTypeComboBox.SelectedItem.ToString().Replace(" ", "");
            string selectedStatus = OrderStatusComboBox.SelectedItem.ToString();
            LoadOrderDetails(selectedStatus, selectedItem);
        }
        private void OrderDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedItem = OrderTypeComboBox.SelectedItem.ToString();
                if (selectedItem == "Cars")
                {
                    InsMessLbl.Visible = false;
                    DataGridViewRow selectedRow = OrderDetailsGridView.Rows[e.RowIndex];
                    int orderID = int.Parse(selectedRow.Cells[1].Value?.ToString());
                    OrderLineItemsLbl.Visible = true;
                    PartsLineItemGridView.Visible = false;
                    OrderLineItemsGridView.Visible = true;
                    LoadOrderLineItems(orderID);
                    this.Height = expandedFormHeight;
                    this.CenterToScreen();
                }
                else if (selectedItem == "Car Parts")
                {
                    InsMessLbl.Visible = false;
                    DataGridViewRow selectedRow = OrderDetailsGridView.Rows[e.RowIndex];
                    int orderID = int.Parse(selectedRow.Cells[1].Value?.ToString());
                    OrderLineItemsGridView.Visible = false;
                    OrderLineItemsLbl.Visible = true;
                    PartsLineItemGridView.Visible = true;
                    PartsLoadOrderLineItems(orderID);
                    this.Height = expandedFormHeight;
                    this.CenterToScreen();
                }
            }
        }
        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = SearchTxtBox.Text.Trim();
            DataTable carTable = (DataTable)OrderDetailsGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(OrderDate, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(OrderID, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(TotalOrderAmount, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(CustName, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(CustEmail, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(CustPhNo, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(CustAddress, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }

        //Utility Methods
        private void Reset()
        {
            OrderLineItemsGridView.Visible = false;
            OrderLineItemsLbl.Visible = false;
            PartsLineItemGridView.Visible = false;
            this.Height = originalFormHeight;
            this.CenterToScreen();
        }
        private void LoadDashboard()
        {
            if (userRole == "Admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard();

                DashboardPanel.Controls.Clear();

                adminDashboard.TopLevel = false;
                adminDashboard.FormBorderStyle = FormBorderStyle.None;

                DashboardPanel.Controls.Add(adminDashboard);

                adminDashboard.Show();
            }
            else
            {
                CustomerDashboard customerDashboard = new CustomerDashboard();
                customerDashboard.TopLevel = false;
                customerDashboard.FormBorderStyle = FormBorderStyle.None;
                DashboardPanel.Controls.Clear();
                DashboardPanel.Controls.Add(customerDashboard);
                customerDashboard.Show();
            }

        }
    }
}
