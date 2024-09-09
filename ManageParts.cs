using System;
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
    public partial class ManageParts : Form
    {
        private string connectionString;
        private int PartID = 0;
        Image originalImage = null;
        byte[] imageData = null;

        //Constructor
        public ManageParts()
        {
            InitializeComponent();
            LoadDashboard();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            LoadDataAsync();
            CarTypeComboBox.SelectedIndex = -1;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
        }
        //Data Loading
        private async Task LoadDataAsync()
        {
            await LoadCarTypes();   
            await LoadPartsData(); 
        }
        private async Task LoadPartsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT cp.*, c.Make + ' ' + c.Model AS CarType FROM CarParts cp " +
                                   "INNER JOIN Cars c ON cp.CarID = c.CarID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable carTable = new DataTable();

                    await connection.OpenAsync(); 
                    await Task.Run(() => adapter.Fill(carTable)); 

                    PartsGridView.DataSource = carTable;

                    PartsGridView.Columns["CarID"].Visible = false;
                    PartsGridView.Columns["PartImage"].Visible = false;

                    PartsGridView.Columns["CarType"].Visible = true;
                    PartsGridView.Columns["CarType"].HeaderText = "Car Type";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading car parts data: " + ex.Message);
                }
            }
        }
        private async Task LoadCarTypes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();  
                    string query = "SELECT CarID, Make, Model FROM Cars";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = await command.ExecuteReaderAsync();  
                        DataTable carTable = new DataTable();
                        carTable.Load(reader); 

                        carTable.Columns.Add("CarDetails", typeof(string), "Make + ' ' + Model");
                        CarTypeComboBox.DisplayMember = "CarDetails";
                        CarTypeComboBox.ValueMember = "CarID";
                        CarTypeComboBox.DataSource = carTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        //UI Event Handlers
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StockBox.Value == 0) 
            {
                MessageBox.Show("Parts Quantity Cannot Be 0!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO CarParts (PartName, carID, Price, Description, Stock, PartImage) VALUES (@PartName, @carID, @Price, @Description, @Stock, @PartImage)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", PartNameTxtBox.Text);
                        command.Parameters.AddWithValue("@carID", CarTypeComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@Price", PriceBox.Value);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@Stock", StockBox.Value);

                        if (PartPictureBox.Image != null && originalImage != null)
                        {
                            command.Parameters.AddWithValue("@PartImage", ImageToByteArray(originalImage));
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@PartImage", DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show("Part added successfully!");
                        ResetFields();
                        LoadPartsData(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE CarParts SET PartName = @PartName, CarID = @CarID, Price = @Price, Description = @Description, Stock = @Stock, PartImage = @PartImage WHERE PartID = @PartID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", PartNameTxtBox.Text);
                        command.Parameters.AddWithValue("@CarID", CarTypeComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@Price", PriceBox.Value);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@Stock", StockBox.Value);
                        command.Parameters.AddWithValue("@PartID", PartID);

                        // Convert the image to a byte array and add as a parameter
                        if (PartPictureBox.Image != null && originalImage != null)
                        {
                            command.Parameters.Add("@PartImage", SqlDbType.VarBinary).Value = ImageToByteArray(originalImage);

                        }
                        else
                        {
                            command.Parameters.Add("@PartImage", SqlDbType.VarBinary).Value = (imageData != null) ? (object)imageData : DBNull.Value;
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show("Part updated successfully!");
                        ResetFields();
                        LoadPartsData(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private void PartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PartsGridView.Rows[e.RowIndex];
                PartID = int.Parse(selectedRow.Cells[0].Value?.ToString());
                PartNameTxtBox.Text = selectedRow.Cells[1].Value?.ToString();
                CarTypeComboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells[2].Value);
                PriceBox.Value = Convert.ToDecimal(selectedRow.Cells[3].Value);
                DescripTxtBox.Text = selectedRow.Cells[4].Value?.ToString();
                StockBox.Value = Convert.ToInt32(selectedRow.Cells[5].Value);

                if (selectedRow.Cells["PartImage"].Value != DBNull.Value)
                {
                    imageData = (byte[])selectedRow.Cells["PartImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image originalImage = Image.FromStream(ms);
                        Image resizedImage = ResizeImage(originalImage, PartPictureBox.Width, PartPictureBox.Height);
                        PartPictureBox.Image = resizedImage; 
                    }
                }
                else
                {
                    PartPictureBox.Image = null;
                    imageData = null;
                }

                UpdateBtn.Visible = true;
                DeleteBtn.Visible = true;
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM CarParts WHERE PartID = @PartID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartID", PartID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Part deleted successfully!");
                        ResetFields();
                        LoadPartsData(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    connection.Close();
                }
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = SearchTxtBox.Text.Trim();
            DataTable carTable = (DataTable)PartsGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(PartID, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(PartName, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Price, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(CarType, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }
        private void UploadImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        originalImage = new Bitmap(ofd.FileName);
                        Image resizedImage = ResizeImage(originalImage, PartPictureBox.Width, PartPictureBox.Height);
                        PartPictureBox.Image = resizedImage; 
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message   ); }
        }

        //Utility Methods
        private void ResetFields()
        {
            PartNameTxtBox.Text = string.Empty;
            CarTypeComboBox.SelectedIndex = -1;
            PriceBox.Value = PriceBox.Minimum;
            DescripTxtBox.Text = string.Empty;
            StockBox.Value = StockBox.Minimum;
            PartPictureBox.Image = null;
            originalImage = null;
            imageData = null;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
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

            adminDashboard.Show();
        }
    }
}
