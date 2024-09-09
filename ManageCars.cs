using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders
{
    public partial class ManageCars : Form
    {
        private string connectionString;
        private int CarId = 0;
        Image originalImage = null;

        //Constructor
        public ManageCars()
        {
            InitializeComponent();
            LoadDashboard();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            CarDetailsGridView.AutoGenerateColumns = false;
            CarPictureBox.SizeMode = PictureBoxSizeMode.Normal;
            LoadDataAsync();
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            UpdateCarDetailsBtn.Visible = false;
        }

        //Data Loading
        private async Task LoadDataAsync()
        {
            await LoadCarsData();
        }
        private async Task LoadCarsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Cars";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable carTable = new DataTable();

                    await connection.OpenAsync();  
                    await Task.Run(() => adapter.Fill(carTable));  

                    CarsGridView.DataSource = carTable; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDetailsItems(int CarId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select CD.DetailID, CD.CarID, CONCAT(c.Make,' ',c.Model) as 'Car', " +
                                   "CD.Price, CD.Colour, CD.Stock, CD.CarImage from CarDetails CD " +
                                   "inner join Cars C on C.CarID = CD.CarID " +
                                   "where CD.CarID = @CarID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@CarID", CarId);

                    DataTable DetailsItems = new DataTable();
                    adapter.Fill(DetailsItems);

                    CarDetailsGridView.Columns["CarName"].DataPropertyName = "Car";
                    CarDetailsGridView.Columns["IDCar"].DataPropertyName = "CarID";
                    CarDetailsGridView.Columns["Price"].DataPropertyName = "Price";
                    CarDetailsGridView.Columns["Colour"].DataPropertyName = "Colour";
                    CarDetailsGridView.Columns["Stock"].DataPropertyName = "Stock";
                    CarDetailsGridView.Columns["CarImage"].DataPropertyName = "CarImage";
                    CarDetailsGridView.Columns["DetailID"].DataPropertyName = "DetailID";

                    CarDetailsGridView.DataSource = DetailsItems;
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
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertIntoCarsQuery = "INSERT INTO Cars (Make, Model, Year, Description) " +
                                   "VALUES (@Make, @Model, @Year, @Description); " +
                                   "SELECT SCOPE_IDENTITY();";

                    int CarID = 0;

                    using (SqlCommand command = new SqlCommand(insertIntoCarsQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Make", MakeTxtBox.Text);
                        command.Parameters.AddWithValue("@Model", ModelTxtBox.Text);
                        command.Parameters.AddWithValue("@Year", YearTxtBox.Text);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);

                        CarID = Convert.ToInt32(command.ExecuteScalar());
                    }

                    string insertIntoCarDetailsQuery = "INSERT INTO CarDetails (CarID, Price, Colour, Stock, CarImage) " +
                                                       "Values(@CarID, @Price, @Colour, @Stock, @CarImage);";

                    foreach (DataGridViewRow row in CarDetailsGridView.Rows)
                    {
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        decimal stock = Convert.ToDecimal(row.Cells["Stock"].Value);
                        string colour = row.Cells["Colour"].Value.ToString();
                        byte[] imageData = row.Cells["CarImage"].Value as byte[];

                        using (SqlCommand command = new SqlCommand(insertIntoCarDetailsQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@CarID", CarID);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Colour", colour);
                            command.Parameters.AddWithValue("@Stock", stock);
                            command.Parameters.Add("@CarImage", SqlDbType.VarBinary).Value = (imageData != null) ? (object)imageData : DBNull.Value;

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Car added successfully!");
                    ResetFields();
                    LoadCarsData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateCarsQuery = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, Description = @Description " +
                                   "WHERE CarId = @CarId";

                    using (SqlCommand command = new SqlCommand(updateCarsQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Make", MakeTxtBox.Text);
                        command.Parameters.AddWithValue("@Model", ModelTxtBox.Text);
                        command.Parameters.AddWithValue("@Year", YearTxtBox.Text);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@CarId", CarId);

                        command.ExecuteNonQuery();
                    }

                    string deleteExistingCarDetailsQuery = "delete from CarDetails where CarID = @CarID";

                    using (SqlCommand command = new SqlCommand(deleteExistingCarDetailsQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@CarId", CarId);

                        command.ExecuteNonQuery();
                    }

                    string insertIntoCarDetailsQuery = "INSERT INTO CarDetails (CarID, Price, Colour, Stock, CarImage) " +
                                   "Values(@CarID, @Price, @Colour, @Stock, @CarImage);";

                    foreach (DataGridViewRow row in CarDetailsGridView.Rows)
                    {
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        decimal stock = Convert.ToDecimal(row.Cells["Stock"].Value);
                        string colour = row.Cells["Colour"].Value.ToString();
                        byte[] imageData = row.Cells["CarImage"].Value as byte[];

                        using (SqlCommand command = new SqlCommand(insertIntoCarDetailsQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@CarID", CarId);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Colour", colour);
                            command.Parameters.AddWithValue("@Stock", stock);
                            command.Parameters.Add("@CarImage", SqlDbType.VarBinary).Value = (imageData != null) ? (object)imageData : DBNull.Value;

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Car updated successfully!");
                    ResetFields();
                    LoadCarsData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private void CarsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ResetCarDetailsFields();

                DataGridViewRow selectedRow = CarsGridView.Rows[e.RowIndex];
                CarId = int.Parse(selectedRow.Cells[0].Value?.ToString());
                MakeTxtBox.Text = selectedRow.Cells[1].Value?.ToString();
                ModelTxtBox.Text = selectedRow.Cells[2].Value?.ToString();
                YearTxtBox.Text = selectedRow.Cells[3].Value?.ToString();
                DescripTxtBox.Text = selectedRow.Cells[4].Value?.ToString();

                LoadDetailsItems(CarId);

                UpdateBtn.Visible = true;
                DeleteBtn.Visible = true;
            }
        }
        private void CarDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CarDetailsGridView.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                CarDetailsGridView.Rows.RemoveAt(e.RowIndex);
                return;
            }
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = CarDetailsGridView.Rows[e.RowIndex];
                ColourTxtBox.Text = selectedRow.Cells["Colour"].Value.ToString();
                PriceBox.Text = selectedRow.Cells["Price"].Value.ToString();
                StockBox.Text = selectedRow.Cells["Stock"].Value.ToString();

                if (selectedRow.Cells["CarImage"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])selectedRow.Cells["CarImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image originalImage = Image.FromStream(ms);
                        Image resizedImage = ResizeImage(originalImage, CarPictureBox.Width, CarPictureBox.Height);
                        CarPictureBox.Image = resizedImage; 
                    }
                }
                else
                {
                    CarPictureBox.Image = null; 
                }
                UpdateCarDetailsBtn.Visible = true;
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteCarDetailsQuery = "DELETE FROM CarDetails WHERE CarID = @CarID";

                    using (SqlCommand command = new SqlCommand(deleteCarDetailsQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@CarId", CarId);

                        command.ExecuteNonQuery();
                    }

                    string deleteCarQuery = "DELETE FROM Cars WHERE carID = @CarId";

                    using (SqlCommand command = new SqlCommand(deleteCarQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@CarId", CarId);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Car deleted successfully!");
                    ResetFields();
                    LoadCarsData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = SearchTxtBox.Text.Trim();
            DataTable carTable = (DataTable)CarsGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(CarID, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(Make, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Model, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Year, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }
        private void UploadImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(ofd.FileName);
                    Image resizedImage = ResizeImage(originalImage, CarPictureBox.Width, CarPictureBox.Height);
                    CarPictureBox.Image = resizedImage; 
                }
            }
        }
        private void AddCarDetailsBtn_Click(object sender, EventArgs e)
        {
            if (CarDetailsGridView.DataSource is DataTable dataTable)
            {
                DataRow newRow = dataTable.NewRow();

                newRow["Car"] = MakeTxtBox.Text + ' ' + ModelTxtBox.Text;
                newRow["CarID"] = CarId;
                newRow["Price"] = PriceBox.Value;
                newRow["Colour"] = ColourTxtBox.Text;
                newRow["Stock"] = StockBox.Value;

                if (CarPictureBox.Image != null && originalImage != null)
                {
                    newRow["CarImage"] = ImageToByteArray(originalImage);
                }
                else
                {
                    newRow["CarImage"] = DBNull.Value;
                }

                dataTable.Rows.Add(newRow);
                ResetCarDetailsFields();
            }
            else
            {
                MessageBox.Show("DataSource of the DataGridView is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarDetailsGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (CarDetailsGridView.Columns[e.ColumnIndex].Name == "Remove" && e.RowIndex >= 0)
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
        private void UpdateCarDetailsBtn_Click(object sender, EventArgs e)
        {
            if (CarDetailsGridView.CurrentRow != null)
            {
                int rowIndex = CarDetailsGridView.CurrentRow.Index;

                CarDetailsGridView.Rows[rowIndex].Cells["Price"].Value = PriceBox.Value;
                CarDetailsGridView.Rows[rowIndex].Cells["Colour"].Value = ColourTxtBox.Text;
                CarDetailsGridView.Rows[rowIndex].Cells["Stock"].Value = StockBox.Value;

                if (CarPictureBox.Image != null && originalImage != null)
                {
                    CarDetailsGridView.Rows[rowIndex].Cells["CarImage"].Value = ImageToByteArray(originalImage);
                }

                ResetCarDetailsFields();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Utility Methods
        private void ResetFields()
        {
            MakeTxtBox.Text = string.Empty;
            ModelTxtBox.Text = string.Empty;
            YearTxtBox.Text = string.Empty;
            ColourTxtBox.Text = string.Empty;
            PriceBox.Value = PriceBox.Minimum;
            DescripTxtBox.Text = string.Empty;
            StockBox.Value = StockBox.Minimum;
            CarPictureBox.Image = null;
            originalImage = null;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            UpdateCarDetailsBtn.Visible = false;
            CarDetailsGridView.DataSource = null;
        }
        private void ResetCarDetailsFields()
        {
            ColourTxtBox.Text = string.Empty;
            PriceBox.Value = PriceBox.Minimum;
            StockBox.Value = StockBox.Minimum;
            CarPictureBox.Image = null;
            originalImage = null;
            UpdateCarDetailsBtn.Visible = false;
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ImageFormat format = image.RawFormat;

                if (format == null || format.Guid == ImageFormat.MemoryBmp.Guid)
                {
                    format = ImageFormat.Jpeg;
                }

                image.Save(ms, format);

                return ms.ToArray();
            }
        }
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
        private void LoadDashboard()
        {
            AdminDashboard adminDashboard = new AdminDashboard();

            DashboardPanel.Controls.Clear();

            adminDashboard.TopLevel = false;
            adminDashboard.FormBorderStyle = FormBorderStyle.None;

            DashboardPanel.Controls.Add(adminDashboard);
            adminDashboard.Dock = DockStyle.Fill;
            adminDashboard.Show();
        }
    }
}
