using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders
{
    public partial class OrderForm : Form
    {
        private string connectionString;
        decimal netTotal = 0;
        decimal CarNetTotal = 0;
        private int originalFormHeight;
        private int expandedFormHeight;
        private bool isBinding = false;
        private bool isCarFillFieldsBinding = false;

        //Constructor
        public OrderForm()
        {
            InitializeComponent();
            LoadDashboard();
            OrderTabControl.SizeMode = TabSizeMode.Fixed;

            int tabWidth = (OrderTabControl.Width - 5) / OrderTabControl.TabCount; 

            OrderTabControl.ItemSize = new Size(tabWidth, OrderTabControl.ItemSize.Height);
            OrderTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;

            CarsCartGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            PartsCartGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

            expandedFormHeight = this.Height;
            originalFormHeight = expandedFormHeight - PartsCartGridView.Height - 30;

            PartsCartGridView.Visible = false;
            CarsCartGridView.Visible = false ;

            CarsCloseCartBtn.Visible = false;
            PartsCloseCartBtn.Visible = false;

            this.Height = originalFormHeight;

            CarPictureBox.SizeMode = PictureBoxSizeMode.Normal;
            PartsPictureBox.SizeMode = PictureBoxSizeMode.Normal;

            LoadCarData();

            ClearInputFields();
            CarClearInputFields();
            InitializeCartButton();
        }

        //Data Loading
        private void LoadCarData()
        {
            isBinding = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Car Page
                    string CarsQuery = "select Distinct(C.CarID), CONCAT(C.Make,' ',C.Model) as 'Car' from Cars C " +
                                       "inner join CarDetails CD on CD.CarID = c.CarID " +
                                       "where CD.Stock > 0";

                    using (SqlCommand command = new SqlCommand(CarsQuery, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carTable = new DataTable();
                        carTable.Load(reader);

                        CarComboBox.DisplayMember = "Car";
                        CarComboBox.ValueMember = "CarID";
                        CarComboBox.DataSource = carTable;
                    }

                    //CarPart Page
                    string partsQuery = "select Distinct(C.CarID), CONCAT(C.Make,' ',C.Model) as 'Car' from Cars C " +
                                        "inner join CarParts CP on CP.CarID = c.CarID " +
                                        "where CP.Stock > 0";

                    using (SqlCommand command = new SqlCommand(partsQuery, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable partsCarTable = new DataTable();
                        partsCarTable.Load(reader);

                        CarPartCarComboBox.DisplayMember = "Car";
                        CarPartCarComboBox.ValueMember = "CarID";
                        CarPartCarComboBox.DataSource = partsCarTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally 
                { 
                    isBinding = false; 
                }
            }
        }
        private void LoadPartsData(int carId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PartID, PartName FROM CarParts " +
                                   "WHERE Stock > 0 and CarID = " + carId + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carPartTable = new DataTable();
                        carPartTable.Load(reader);

                        PartNameComboBox.DisplayMember = "PartName";
                        PartNameComboBox.ValueMember = "PartID";
                        PartNameComboBox.DataSource = carPartTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        //Field Population
        private void FillFields(int PartId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Price, Description, Stock, PartImage FROM CarParts WHERE PartID = " + PartId + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PartsPriceTxtBox.Text = reader["Price"].ToString();
                                PartsDescriptionTxtBox.Text = reader["Description"].ToString();
                                PartsStockTxtBox.Text = reader["Stock"].ToString();

                                if (reader["PartImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["PartImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        Image originalImage = Image.FromStream(ms);
                                        Image resizedImage = ResizeImage(originalImage, PartsPictureBox.Width, CarPictureBox.Height);
                                        PartsPictureBox.Image = resizedImage; // Use the resized image here
                                    }
                                }
                                else
                                {
                                    PartsPictureBox.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified PartID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void CarFillFields(int CarId)
        {
            isCarFillFieldsBinding = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string carDetailsQuery = "SELECT DetailID, Colour FROM CarDetails " +
                                             "where Stock > 0 and CarID = " + CarId + "";

                    using (SqlCommand command = new SqlCommand(carDetailsQuery, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carDetailsTable = new DataTable();
                        carDetailsTable.Load(reader);

                        if (carDetailsTable.Rows.Count == 0)
                        {
                            ColourComboBox.DataSource = null;
                            ColourComboBox.Items.Clear();
                        }
                        else
                        {
                            ColourComboBox.DisplayMember = "Colour";
                            ColourComboBox.ValueMember = "DetailID";
                            ColourComboBox.DataSource = carDetailsTable;
                        }
                    }

                    string carQuery = "SELECT Year, Description FROM Cars WHERE CarID = " + CarId + "";
                    using (SqlCommand command = new SqlCommand(carQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                YearTxtBox.Text = reader["Year"].ToString();
                                DescriptionTxtBox.Text = reader["Description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified CarId.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally { isCarFillFieldsBinding = false; }
            }
        }
        private void CarDetailsFillFields(int DetailId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string carDetailsQuery = "SELECT Price, Stock, CarImage FROM CarDetails where DetailID = " + DetailId + "";

                    using (SqlCommand command = new SqlCommand(carDetailsQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PriceTxtBox.Text = reader["Price"].ToString();
                                CarStockTxtBox.Text = reader["Stock"].ToString();

                                if (reader["CarImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["CarImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        Image originalImage = Image.FromStream(ms);
                                        Image resizedImage = ResizeImage(originalImage, CarPictureBox.Width, CarPictureBox.Height);
                                        CarPictureBox.Image = resizedImage; // Use the resized image here
                                    }
                                }
                                else
                                {
                                    CarPictureBox.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified CarId.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        //UI Event Handlers
        private void CarPartCarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isBinding) return;

            if (CarPartCarComboBox.SelectedValue != null)
            {
                int PartsselectedCarId = (int)CarPartCarComboBox.SelectedValue;
                LoadPartsData(PartsselectedCarId);
            }
        }
        private void PartNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PartNameComboBox.SelectedValue != null)
            {
                int selectedPartId = (int)PartNameComboBox.SelectedValue;
                FillFields(selectedPartId);
            }
        }
        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            RemoveNetTotalRow();

            int availableQuantity = int.Parse(PartsStockTxtBox.Text);
            decimal price = decimal.Parse(PartsPriceTxtBox.Text);
            decimal subTotal = price * OrderQtyBox.Value;

            if (OrderQtyBox.Value == 0) 
            {
                MessageBox.Show("Order Quantity cannot be 0!");
                return;
            }

            if (OrderQtyBox.Value > availableQuantity)
            {
                MessageBox.Show("Order Quantity cannot exceed Available Quantity!");
                return;
            } 

            int rowIndex = PartsCartGridView.Rows.Add();

            PartsCartGridView.Rows[rowIndex].Cells["CarTypeColumn"].Value = CarPartCarComboBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["PartNameColumn"].Value = PartNameComboBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["PriceColumn"].Value = PartsPriceTxtBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["DescriptionColumn"].Value = PartsDescriptionTxtBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["AvailableQuantityColumn"].Value = PartsStockTxtBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["OrderQuantityColumn"].Value = OrderQtyBox.Value.ToString();
            PartsCartGridView.Rows[rowIndex].Cells["SubTotal"].Value = subTotal.ToString();
            PartsCartGridView.Rows[rowIndex].Cells["PartId"].Value = PartNameComboBox.SelectedValue;


            ClearInputFields();
            AddNetTotal();
            UpdateCartButton();
        }
        private void ClearInputFields()
        {
            CarPartCarComboBox.SelectedIndex = -1;
            PartNameComboBox.SelectedIndex = -1;
            PartsPriceTxtBox.Clear();
            PartsDescriptionTxtBox.Clear();
            PartsStockTxtBox.Clear();
            PartsPictureBox.Image = null;
            OrderQtyBox.Value = 0;
        }
        private void PartsResetBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void ClearCartItemsBtn_Click(object sender, EventArgs e)
        {
            PartsCartGridView.Rows.Clear();
            UpdateCartButton();

            MessageBox.Show("Cart items have been cleared.");
        }
        private void PartsCartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == PartsCartGridView.Columns["PartRemove"].Index && e.RowIndex >= 0)
            {
                int partID = Convert.ToInt32(PartsCartGridView.Rows[e.RowIndex].Cells["PartId"].Value);

                PartsCartGridView.Rows.RemoveAt(e.RowIndex);

                RemoveNetTotalRow();
                AddNetTotal();
                UpdateCartButton();
            }
        }
        private void PartsCartGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = PartsCartGridView.Rows[e.RowIndex];
            if (row.Cells["CarTypeColumn"].Value != null && row.Cells["CarTypeColumn"].Value.ToString() == "Net Total : ")
            {
                return;
            }

            if (PartsCartGridView.Columns[e.ColumnIndex].Name == "PartRemove" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                using (Brush backColorBrush = new SolidBrush(Color.LightCoral))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                e.Graphics.DrawString("Remove", e.CellStyle.Font, Brushes.White, e.CellBounds.X + (e.CellBounds.Width - e.Graphics.MeasureString("Remove", e.CellStyle.Font).Width) / 2, e.CellBounds.Y + (e.CellBounds.Height - e.Graphics.MeasureString("Remove", e.CellStyle.Font).Height) / 2);

                e.Handled = true;
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            CarClearInputFields();
        }
        private void CarClearInputFields()
        {
            CarComboBox.SelectedIndex = -1;
            ColourComboBox.SelectedIndex = -1;
            YearTxtBox.Clear();
            PriceTxtBox.Clear();
            DescriptionTxtBox.Clear();
            CarStockTxtBox.Clear();
            CarOrderQtyBox.Value = 0;
            CarPictureBox.Image = null;
        }
        private void CarClearInputFieldsWOComboBox()
        {
            YearTxtBox.Clear();
            PriceTxtBox.Clear();
            DescriptionTxtBox.Clear();
            CarStockTxtBox.Clear();
            CarOrderQtyBox.Value = 0;
            CarPictureBox.Image = null;
        }
        private void CarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isBinding) return;

            if (CarComboBox.SelectedValue != null)
            {
                CarClearInputFieldsWOComboBox();
                int selectedCarId = (int)CarComboBox.SelectedValue;
                CarFillFields(selectedCarId);
            }
        }
        private void ColourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCarFillFieldsBinding) { ColourComboBox.SelectedIndex = -1; return; } 

            if (ColourComboBox.SelectedValue != null)
            {
                int selectedDetailId = (int)ColourComboBox.SelectedValue;
                CarDetailsFillFields(selectedDetailId);
            }
        }
        private void AddToCartCarBtn_Click(object sender, EventArgs e)
        {
            if (ColourComboBox.SelectedValue == null)
            {
                MessageBox.Show("Select a colour and quantity before adding to cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CarRemoveNetTotalRow();

            int availableQuantity = int.Parse(CarStockTxtBox.Text);
            decimal price = decimal.Parse(PriceTxtBox.Text);
            decimal subTotal = price * CarOrderQtyBox.Value;

            if (CarOrderQtyBox.Value == 0)
            {
                MessageBox.Show("Order Quantity cannot be 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CarOrderQtyBox.Value > availableQuantity)
            {
                MessageBox.Show("Order Quantity cannot exceed Available Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = CarsCartGridView.Rows.Add();

            CarsCartGridView.Rows[rowIndex].Cells["CarName"].Value = CarComboBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["YOM"].Value = YearTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["Price"].Value = PriceTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["Description"].Value = DescriptionTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["AvailableStock"].Value = CarStockTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["OrderQty"].Value = CarOrderQtyBox.Value.ToString();
            CarsCartGridView.Rows[rowIndex].Cells["SubTot"].Value = subTotal.ToString();
            CarsCartGridView.Rows[rowIndex].Cells["Colour"].Value = ColourComboBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["CarID"].Value = CarComboBox.SelectedValue;
            CarsCartGridView.Rows[rowIndex].Cells["DetailID"].Value = ColourComboBox.SelectedValue;


            CarClearInputFields();
            CarAddNetTotal();
            CarUpdateCartButton();
        }
        private void CarClearCartItemsBtn_Click(object sender, EventArgs e)
        {
            CarsCartGridView.Rows.Clear();
            CarUpdateCartButton();

            MessageBox.Show("Cart items have been cleared.");
        }
        private void CarsCartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CarsCartGridView.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                CarsCartGridView.Rows.RemoveAt(e.RowIndex);

                CarRemoveNetTotalRow();
                CarAddNetTotal();
                CarUpdateCartButton();
            }
        }
        private void CarsCartGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = CarsCartGridView.Rows[e.RowIndex];
            if (row.Cells["CarName"].Value != null && row.Cells["CarName"].Value.ToString() == "Net Total : ")
            {
                return;
            }

            if (CarsCartGridView.Columns[e.ColumnIndex].Name == "Remove" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                using (Brush backColorBrush = new SolidBrush(Color.LightCoral))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                e.Graphics.DrawString("Remove", e.CellStyle.Font, Brushes.White, e.CellBounds.X + (e.CellBounds.Width - e.Graphics.MeasureString("Remove", e.CellStyle.Font).Width) / 2, e.CellBounds.Y + (e.CellBounds.Height - e.Graphics.MeasureString("Remove", e.CellStyle.Font).Height) / 2);

                e.Handled = true;
            }
        }
        private void CartBtn_Click(object sender, EventArgs e)
        {
            this.Height = expandedFormHeight;
            this.CenterToScreen();
            PartsCheckOutBtn.Visible = false;
            PartsCartGridView.Visible = true;
            PartsCloseCartBtn.Visible = true;
        }
        private void CarCartBtn_Click(object sender, EventArgs e)
        {
            this.Height = expandedFormHeight;
            this.CenterToScreen();
            CheckOutBtn.Visible = false;
            CarsCartGridView.Visible = true;
            CarsCloseCartBtn.Visible = true;
        }
        private void CarsCloseCartBtn_Click(object sender, EventArgs e)
        {
            this.Height = originalFormHeight;
            this.CenterToScreen();
            CheckOutBtn.Visible = true;
            CarsCartGridView.Visible = false;
            CarsCloseCartBtn.Visible = false;
        }
        private void PartsCloseCartBtn_Click(object sender, EventArgs e)
        {
            this.Height = originalFormHeight;
            this.CenterToScreen();
            PartsCheckOutBtn.Visible = true;
            PartsCartGridView.Visible = false;
            PartsCloseCartBtn.Visible = false;
        }
        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            this.Height = expandedFormHeight;
            this.CenterToScreen();
            CheckOutBtn.Visible = false;
            CarsCartGridView.Visible = true;
            CarsCloseCartBtn.Visible = true;
        }
        private void PartsCheckOutBtn_Click(object sender, EventArgs e)
        {
            this.Height = expandedFormHeight;
            this.CenterToScreen();
            PartsCheckOutBtn.Visible = false;
            PartsCartGridView.Visible = true;
            PartsCloseCartBtn.Visible = true;
        }

        //Cart Management
        private void AddNetTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in PartsCartGridView.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    total += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                }
            }

            if (total == 0)
            {
                netTotal = total;
                return;
            }

            int rowIndex = PartsCartGridView.Rows.Add();
            DataGridViewRow netTotalRow = PartsCartGridView.Rows[rowIndex];
            netTotalRow.Cells["CarTypeColumn"].Value = "Net Total : ";
            netTotalRow.Cells["SubTotal"].Value = total.ToString();

            DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
            netTotalRow.Cells["PartRemove"] = textCell;
            netTotalRow.Cells["PartRemove"].Value = "";

            netTotalRow.DefaultCellStyle.Font = new Font(PartsCartGridView.Font, FontStyle.Bold);
            netTotalRow.DefaultCellStyle.BackColor = Color.LightGray;

            netTotal = total;
        }
        private void CarAddNetTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in CarsCartGridView.Rows)
            {
                // Check if the SubTotal cell in the row has a value
                if (row.Cells["SubTot"].Value != null)
                {
                    total += decimal.Parse(row.Cells["SubTot"].Value.ToString());
                }
            }

            if (total == 0)
            {
                CarNetTotal = total;
                return;
            }

            int rowIndex = CarsCartGridView.Rows.Add();
            DataGridViewRow netTotalRow = CarsCartGridView.Rows[rowIndex];
            netTotalRow.Cells["CarName"].Value = "Net Total : ";
            netTotalRow.Cells["SubTot"].Value = total.ToString();

            DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
            netTotalRow.Cells["Remove"] = textCell;
            netTotalRow.Cells["Remove"].Value = "";

            netTotalRow.DefaultCellStyle.Font = new Font(CarsCartGridView.Font, FontStyle.Bold);
            netTotalRow.DefaultCellStyle.BackColor = Color.LightGray;

            CarNetTotal = total;
        }
        private void RemoveNetTotalRow()
        {
            DataGridViewRow netTotalRow = null;

            foreach (DataGridViewRow row in PartsCartGridView.Rows)
            {
                if (row.Cells["CarTypeColumn"].Value != null && row.Cells["CarTypeColumn"].Value.ToString().Contains("Net Total"))
                {
                    netTotalRow = row;
                    break;
                }
            }

            if (netTotalRow != null)
            {
                PartsCartGridView.Rows.Remove(netTotalRow);
                netTotal = 0;
            }
        }
        private void CarRemoveNetTotalRow()
        {
            DataGridViewRow netTotalRow = null;

            foreach (DataGridViewRow row in CarsCartGridView.Rows)
            {
                if (row.Cells["CarName"].Value != null && row.Cells["CarName"].Value.ToString().Contains("Net Total"))
                {
                    netTotalRow = row;
                    break;
                }
            }

            if (netTotalRow != null)
            {
                CarsCartGridView.Rows.Remove(netTotalRow);
                CarNetTotal = 0;
            }
        }
        private void UpdateCartButton()
        {
            int itemCount = 0;

            foreach (DataGridViewRow row in PartsCartGridView.Rows)
            {
                if (row.Cells["CarTypeColumn"].Value?.ToString() != "Net Total : ")
                {
                    itemCount++;
                }
            }

            CartBtn.Text = $"View Cart ({itemCount})";
            PartsCloseCartBtn.Text = $"Close Cart ({itemCount})";
        }
        private void CarUpdateCartButton()
        {
            int itemCount = 0;

            foreach (DataGridViewRow row in CarsCartGridView.Rows)
            {
                if (row.Cells["CarName"].Value?.ToString() != "Net Total : ")
                {
                    itemCount++;
                }
            }

            CarCartBtn.Text = $"View Cart ({itemCount})";
            CarsCloseCartBtn.Text = $"Close Cart ({itemCount})";
        }
        private void InitializeCartButton()
        {
            try
            {
                Image CartoriginalImage = Properties.Resources.cart_icon;

                int CartbuttonHeight = CartBtn.Height - 10;
                int CartresizedWidth = (int)(CartoriginalImage.Width * ((float)CartbuttonHeight / CartoriginalImage.Height));

                Image CartresizedImage = new Bitmap(CartoriginalImage, new Size(CartresizedWidth, CartbuttonHeight));

                CartBtn.Image = CartresizedImage;
                CarCartBtn.Image = CartresizedImage;
                CarsCloseCartBtn.Image = CartresizedImage;
                PartsCloseCartBtn.Image = CartresizedImage;

                // Parts Cart Button
                CartBtn.ImageAlign = ContentAlignment.MiddleLeft;
                CartBtn.TextAlign = ContentAlignment.MiddleRight;
                CartBtn.Text = "View Cart (0)";
                CartBtn.Padding = new Padding(10, 0, 10, 0);

                PartsCloseCartBtn.ImageAlign = ContentAlignment.MiddleLeft;
                PartsCloseCartBtn.TextAlign = ContentAlignment.MiddleRight;
                PartsCloseCartBtn.Text = "Close Cart (0)";
                PartsCloseCartBtn.Padding = new Padding(10, 0, 10, 0);

                // Cars Cart Button
                CarCartBtn.ImageAlign = ContentAlignment.MiddleLeft;
                CarCartBtn.TextAlign = ContentAlignment.MiddleRight;
                CarCartBtn.Text = "View Cart (0)";
                CarCartBtn.Padding = new Padding(10, 0, 10, 0);

                CarsCloseCartBtn.ImageAlign = ContentAlignment.MiddleLeft;
                CarsCloseCartBtn.TextAlign = ContentAlignment.MiddleRight;
                CarsCloseCartBtn.Text = "Close Cart (0)";
                CarsCloseCartBtn.Padding = new Padding(10, 0, 10, 0);

                ToolTip cartToolTip = new ToolTip();
                cartToolTip.SetToolTip(CartBtn, "Click here to view your cart");
                cartToolTip.SetToolTip(CarCartBtn, "Click here to view your cart");
                ToolTip XToolTip = new ToolTip();
                cartToolTip.SetToolTip(PartsCloseCartBtn, "Click here to close your cart");
                cartToolTip.SetToolTip(CarsCloseCartBtn, "Click here to close your cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Order Processing
        private void OrderCartItemsBtn_Click(object sender, EventArgs e)
        {
            if (PartsCartGridView.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty. Add items before placing an order.");
                return;
            }

            int userId = UserSession.UserId;
            DateTime orderDate = DateTime.Now;
            string itemType = "CarParts";
            decimal totalAmount = netTotal;
            string orderStatus = "Processing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertOrderQuery = "INSERT INTO Orders (UserID, OrderDate, ItemType, TotalAmount, OrderStatus) " +
                                              "VALUES (@UserID, @OrderDate, @ItemType, @TotalAmount, @OrderStatus); " +
                                              "SELECT SCOPE_IDENTITY();";

                    int orderId;

                    using (SqlCommand command = new SqlCommand(insertOrderQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@ItemType", itemType);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@OrderStatus", orderStatus);

                        orderId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    string insertOrderItemQuery = "INSERT INTO OrderItems (OrderID, ItemID, Quantity, UnitPrice, TotalPrice) " +
                                                  "VALUES (@OrderID, @ItemID, @Quantity, @UnitPrice, @TotalPrice)";

                    string updateStockQuery = "UPDATE CarParts SET Stock = Stock - @Quantity WHERE PartID = @PartID";

                    foreach (DataGridViewRow row in PartsCartGridView.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["OrderQuantityColumn"].Value);
                        int partId = Convert.ToInt32(row.Cells["PartId"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["PriceColumn"].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        string partName = row.Cells["CarTypeColumn"].Value.ToString();

                        if (partName != "Net Total : ")
                        {
                            using (SqlCommand command = new SqlCommand(insertOrderItemQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OrderID", orderId);
                                command.Parameters.AddWithValue("@ItemID", partId);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                                command.ExecuteNonQuery();
                            }

                            using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@PartID", partId);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();

                    ClearCartItemsBtn_Click(sender, e);
                    PartsCloseCartBtn_Click(sender, e);
                    MessageBox.Show("Order placed successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message);
                }
            }
        }
        private void CarOrderCartItemsBtn_Click(object sender, EventArgs e)
        {
            if (CarsCartGridView.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty. Add items before placing an order.");
                return;
            }

            int userId = UserSession.UserId;
            DateTime orderDate = DateTime.Now;
            string itemType = "Cars";
            decimal totalAmount = CarNetTotal;
            string orderStatus = "Processing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Begin a transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert the order into the Orders table
                    string insertOrderQuery = "INSERT INTO Orders (UserID, OrderDate, ItemType, TotalAmount, OrderStatus) " +
                                              "VALUES (@UserID, @OrderDate, @ItemType, @TotalAmount, @OrderStatus); " +
                                              "SELECT SCOPE_IDENTITY();"; // Get the newly inserted OrderID

                    int orderId;

                    using (SqlCommand command = new SqlCommand(insertOrderQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@ItemType", itemType);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@OrderStatus", orderStatus);

                        // Execute the command and get the newly inserted OrderID
                        orderId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    // Insert each item into the OrderItems table
                    string insertOrderItemQuery = "INSERT INTO OrderItems (OrderID, ItemID, Quantity, UnitPrice, TotalPrice) " +
                                                  "VALUES (@OrderID, @ItemID, @Quantity, @UnitPrice, @TotalPrice)";

                    string updateStockQuery = "UPDATE CarDetails SET Stock = Stock - @Quantity WHERE DetailID = @DetailID";

                    foreach (DataGridViewRow row in CarsCartGridView.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["OrderQty"].Value);
                        int carId = Convert.ToInt32(row.Cells["CarID"].Value);
                        int detailId = Convert.ToInt32(row.Cells["DetailID"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells["SubTot"].Value);
                        string carName = row.Cells["CarName"].Value.ToString();

                        if (carName != "Net Total : ")
                        {
                            // Insert order item
                            using (SqlCommand command = new SqlCommand(insertOrderItemQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OrderID", orderId);
                                command.Parameters.AddWithValue("@ItemID", detailId);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                                command.ExecuteNonQuery();
                            }

                            // Update stock
                            using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@DetailID", detailId);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    // Commit the transaction
                    transaction.Commit();

                    // Clear the cart and reset total
                    CarClearCartItemsBtn_Click(sender, e);
                    CarsCloseCartBtn_Click(sender, e);

                    MessageBox.Show("Order placed successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message);
                }
            }
        }

        //Utility Methods
        private Image ResizeImage(Image image, int width, int height)
        {
            var ratioX = (double)width / image.Width;
            var ratioY = (double)height / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }
        private void OrderTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = OrderTabControl.TabPages[e.Index];
            Rectangle tabRect = OrderTabControl.GetTabRect(e.Index);

            if (OrderTabControl.SelectedIndex == e.Index)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, tabRect);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, OrderTabControl.Font, tabRect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Gray, tabRect);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, OrderTabControl.Font, tabRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            e.Graphics.DrawRectangle(Pens.Black, tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height);
        }
        private void LoadDashboard()
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();

            DashboardPanel.Controls.Clear();

            customerDashboard.TopLevel = false;
            customerDashboard.FormBorderStyle = FormBorderStyle.None;

            DashboardPanel.Controls.Add(customerDashboard);

            customerDashboard.Show();
        }
    }
}
