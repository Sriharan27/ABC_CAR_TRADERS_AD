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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders
{
    public partial class ManageOrders : Form
    {
        private string connectionString;
        private int originalFormHeight;
        private int expandedFormHeight;

        //Constructor
        public ManageOrders()
        {
            InitializeComponent();
            LoadDashboard();

            AdminOrderManagement.SizeMode = TabSizeMode.Fixed;

            int tabWidth = (AdminOrderManagement.Width - 5) / AdminOrderManagement.TabCount; 

            AdminOrderManagement.ItemSize = new Size(tabWidth, AdminOrderManagement.ItemSize.Height);
            AdminOrderManagement.DrawMode = TabDrawMode.OwnerDrawFixed;

            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            expandedFormHeight = this.Height;
            originalFormHeight = expandedFormHeight - OrderLineItemsGridView.Height - OrderLineItemsLbl.Height;
            this.Height = originalFormHeight;
            OrderLineItemsGridView.Visible = false;
            OrderLineItemsLbl.Visible = false;
            PartsLineItemGridView.Visible = false;
            PartsOrderLineItemLbl.Visible = false;
            LoadOrderDetails();
            PartsLoadOrderDetails();
        }

        //Data Loading
        private void LoadOrderDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select ORD.OrderDate as 'OrderDate', ORD.OrderID, ORD.TotalAmount as 'TotalOrderAmount', CONCAT(US.FirstName, ' ', US.LastName) as 'CustName', US.Email as 'CustEmail', US.Phone as 'CustPhNo', US.Address as 'CustAddress' from orders ORD " +
                                    "inner join users US on ORD.UserID = US.UserID " +
                                    "where ORD.ItemType = 'Cars' and ORD.OrderStatus = 'Processing'";
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
        private void PartsLoadOrderDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select ORD.OrderDate as 'OrderDate', ORD.OrderID, ORD.TotalAmount as 'TotalOrderAmount', CONCAT(US.FirstName, ' ', US.LastName) as 'CustName', US.Email as 'CustEmail', US.Phone as 'CustPhNo', US.Address as 'CustAddress' from orders ORD " +
                                    "inner join users US on ORD.UserID = US.UserID " +
                                    "where ORD.ItemType = 'CarParts' and ORD.OrderStatus = 'Processing'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable PartsOrderDetailsTable = new DataTable();
                    adapter.Fill(PartsOrderDetailsTable);
                    PartsOrderDetailsGridView.Columns["PartsOrderDate"].DataPropertyName = "OrderDate";
                    PartsOrderDetailsGridView.Columns["PartsOrderID"].DataPropertyName = "OrderID";
                    PartsOrderDetailsGridView.Columns["PartsTotalOrderAmount"].DataPropertyName = "TotalOrderAmount";
                    PartsOrderDetailsGridView.Columns["PartsCustName"].DataPropertyName = "CustName";
                    PartsOrderDetailsGridView.Columns["PartsCustEmail"].DataPropertyName = "CustEmail";
                    PartsOrderDetailsGridView.Columns["PartsCustPhNo"].DataPropertyName = "CustPhNo";
                    PartsOrderDetailsGridView.Columns["PartsCustAddress"].DataPropertyName = "CustAddress";
                    PartsOrderDetailsGridView.DataSource = PartsOrderDetailsTable;
                }

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
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            InsMessLbl.Visible = true;
            CarOrderIDTxtBox.Text = null;
            OrderLineItemsGridView.Visible = false;
            OrderLineItemsLbl.Visible = false;
            this.Height = originalFormHeight;
            this.CenterToScreen();
        }
        private void OrderDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                InsMessLbl.Visible = false;
                DataGridViewRow selectedRow = OrderDetailsGridView.Rows[e.RowIndex];
                int orderID = int.Parse(selectedRow.Cells[1].Value?.ToString());
                OrderLineItemsLbl.Visible = true;
                OrderLineItemsGridView.Visible = true;
                LoadOrderLineItems(orderID);
                CarOrderIDTxtBox.Text = orderID.ToString();
                this.Height = expandedFormHeight;
                this.CenterToScreen();
            }
        }
        private void DispatchOrderBtn_Click(object sender, EventArgs e)
        {
            if (CarOrderIDTxtBox.Text == null)
            {
                MessageBox.Show("Select an Order to Dispatch.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", CarOrderIDTxtBox.Text);
                        command.Parameters.AddWithValue("@OrderStatus", "Dispatched");

                        command.ExecuteNonQuery();
                        MessageBox.Show("Order Dispatched successfully!");
                        ResetBtn_Click(sender, e);
                        LoadOrderDetails();
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (CarOrderIDTxtBox.Text == null)
            {
                MessageBox.Show("Select an Order to Dispatch.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //Update Status
                    string UpdateOrderStatus = "update Orders set OrderStatus = 'Cancelled' where OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(UpdateOrderStatus, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@OrderID", CarOrderIDTxtBox.Text);
                        command.ExecuteNonQuery();
                    };

                    string updateStockQuery = "UPDATE CarDetails SET Stock = Stock + @Quantity where DetailID = @DetailID";

                    foreach (DataGridViewRow row in OrderLineItemsGridView.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        int detailId = Convert.ToInt32(row.Cells["ItemID"].Value);

                        // Update stock
                        using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@DetailID", detailId);

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    ResetBtn_Click(sender, e);
                    LoadOrderDetails();

                    MessageBox.Show("Order Cancelled successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while cancelling the order: " + ex.Message);
                }
            }
        }
        private void PartsOrderDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PartsInstructionsLbl.Visible = false;
                DataGridViewRow selectedRow = PartsOrderDetailsGridView.Rows[e.RowIndex];
                int orderID = int.Parse(selectedRow.Cells[1].Value?.ToString());
                PartsOrderLineItemLbl.Visible = true;
                PartsLineItemGridView.Visible = true;
                PartsLoadOrderLineItems(orderID);
                PartsOrderIdTxtBox.Text = orderID.ToString();
                this.Height = expandedFormHeight;
                this.CenterToScreen();
            }
        }
        private void PartsResetBtn_Click(object sender, EventArgs e)
        {
            PartsInstructionsLbl.Visible = true;
            PartsOrderIdTxtBox.Text = null;
            PartsLineItemGridView.Visible = false;
            PartsOrderLineItemLbl.Visible = false;
            this.Height = originalFormHeight;
            this.CenterToScreen();
        }
        private void PartsDispatchOrderBtn_Click(object sender, EventArgs e)
        {
            if (PartsOrderIdTxtBox.Text == null)
            {
                MessageBox.Show("Select an Order to Dispatch.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", PartsOrderIdTxtBox.Text);
                        command.Parameters.AddWithValue("@OrderStatus", "Dispatched");

                        command.ExecuteNonQuery();
                        MessageBox.Show("Order Dispatched successfully!");
                        PartsResetBtn_Click(sender, e);
                        PartsLoadOrderDetails();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PartsCancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (PartsOrderIdTxtBox.Text == null)
            {
                MessageBox.Show("Select an Order to Dispatch.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //Update Status
                    string UpdateOrderStatus = "update Orders set OrderStatus = 'Cancelled' where OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(UpdateOrderStatus, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@OrderID", PartsOrderIdTxtBox.Text);
                        command.ExecuteNonQuery();
                    };

                    string updateStockQuery = "UPDATE CarParts SET Stock = Stock + @Quantity where PartID = @PartID";

                    foreach (DataGridViewRow row in PartsLineItemGridView.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["OQuantity"].Value);
                        int partId = Convert.ToInt32(row.Cells["PartID"].Value);

                        // Update stock
                        using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@PartID", partId);

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    PartsResetBtn_Click(sender, e);
                    PartsLoadOrderDetails();

                    MessageBox.Show("Order Cancelled successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while cancelling the order: " + ex.Message);
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
        private void PSearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = PSearchTxtBox.Text.Trim();
            DataTable partsTable = (DataTable)PartsOrderDetailsGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                partsTable.DefaultView.RowFilter = string.Empty;
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
                partsTable.DefaultView.RowFilter = rowFilter;
            }
        }

        //Utility Methods
        private void AdminOrderManagement_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = AdminOrderManagement.TabPages[e.Index];
            Rectangle tabRect = AdminOrderManagement.GetTabRect(e.Index);

            Font tabFont = new Font(AdminOrderManagement.Font.FontFamily, 10, FontStyle.Bold);

            if (AdminOrderManagement.SelectedIndex == e.Index)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, tabRect);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabFont, tabRect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Gray, tabRect);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabFont, tabRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            e.Graphics.DrawRectangle(Pens.Black, tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height);
        }
        private void LoadDashboard()
        {
            AdminDashboard adminDashboard = new AdminDashboard();

            DashboardPanel.Controls.Clear();

            adminDashboard.TopLevel = false;
            adminDashboard.FormBorderStyle = FormBorderStyle.None;

            DashboardPanel.Controls.Add(adminDashboard);

            adminDashboard.Show();
        }
    }
}
