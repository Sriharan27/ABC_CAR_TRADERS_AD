using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders
{
    public partial class ManageUsers : Form
    {
        private string connectionString;
        private int UserID = 0;

        //Constructor
        public ManageUsers()
        {
            InitializeComponent();
            LoadDashboard();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            LoadUsersData();
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
        }

        //Data Loading
        private void LoadUsersData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserID,Username,Role,FirstName,LastName,Email,Phone,Address FROM Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable carTable = new DataTable();
                    adapter.Fill(carTable);
                    UsersGridView.DataSource = carTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UI Event Handlers
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string FirstName = FirstNameTxtBox.Text;
            string LastName = LastNameTxtBox.Text;
            string Email = EmailTxtBox.Text;
            string PhNum = PhNumTxtBox.Text;
            string Address = AddressTxtBox.Text;
            string Role = RoleComboBox.Text;
            string Username = UsernameTxtBox.Text;
            string Password = PasswordHasher.HashPassword(PasswordTxtBox.Text);

            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(PhNum) || string.IsNullOrWhiteSpace(Address) || string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Role, FirstName, LastName, Email, Phone, Address) " +
                               "VALUES (@Username, @Password, @Role, @FirstName, @LastName, @Email, @PhNum, @Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Role", Role);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@PhNum", PhNum);
                command.Parameters.AddWithValue("@Address", Address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully!");
                        ResetFields();
                        LoadUsersData();
                    }
                    else
                    {
                        MessageBox.Show("No rows inserted.");
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

                    if (PasswordTxtBox.Text == "Leave Empty If No Change")
                    {
                        string query = "UPDATE Users SET Username = @Username, Role = @Role, FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", UsernameTxtBox.Text);
                            command.Parameters.AddWithValue("@Role", RoleComboBox.Text);
                            command.Parameters.AddWithValue("@FirstName", FirstNameTxtBox.Text);
                            command.Parameters.AddWithValue("@LastName", LastNameTxtBox.Text);
                            command.Parameters.AddWithValue("@Email", EmailTxtBox.Text);
                            command.Parameters.AddWithValue("@Phone", PhNumTxtBox.Text);
                            command.Parameters.AddWithValue("@Address", AddressTxtBox.Text);
                            command.Parameters.AddWithValue("@UserID", UserID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("User updated successfully!");
                            ResetFields();
                            LoadUsersData();
                        }
                    }
                    else
                    {
                        string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role, FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", UsernameTxtBox.Text);
                            command.Parameters.AddWithValue("@Password", PasswordHasher.HashPassword(PasswordTxtBox.Text));
                            command.Parameters.AddWithValue("@Role", RoleComboBox.Text);
                            command.Parameters.AddWithValue("@FirstName", FirstNameTxtBox.Text);
                            command.Parameters.AddWithValue("@LastName", LastNameTxtBox.Text);
                            command.Parameters.AddWithValue("@Email", EmailTxtBox.Text);
                            command.Parameters.AddWithValue("@Phone", PhNumTxtBox.Text);
                            command.Parameters.AddWithValue("@Address", AddressTxtBox.Text);
                            command.Parameters.AddWithValue("@UserID", UserID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("User updated successfully!");
                            ResetFields();
                            LoadUsersData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void UsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = UsersGridView.Rows[e.RowIndex];
                UserID = int.Parse(selectedRow.Cells[0].Value?.ToString());
                UsernameTxtBox.Text = selectedRow.Cells[1].Value?.ToString();
                PasswordTxtBox.Text = "Leave Empty If No Change";
                RoleComboBox.Text = selectedRow.Cells[2].Value?.ToString();
                FirstNameTxtBox.Text = selectedRow.Cells[3].Value?.ToString();
                LastNameTxtBox.Text = selectedRow.Cells[4].Value?.ToString();
                EmailTxtBox.Text = selectedRow.Cells[5].Value?.ToString();
                PhNumTxtBox.Text = selectedRow.Cells[6].Value.ToString();
                AddressTxtBox.Text = selectedRow.Cells[7].Value?.ToString();
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
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully!");
                        ResetFields();
                        LoadUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    connection.Close();
                }
            }
        }
        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = SearchTxtBox.Text.Trim();
            DataTable carTable = (DataTable)UsersGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(UserID, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(Username, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(FirstName, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(LastName, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Email, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Phone, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Role, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Address, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }

        //Utility Methods
        private void ResetFields()
        {
            FirstNameTxtBox.Text = string.Empty;
            LastNameTxtBox.Text = string.Empty;
            EmailTxtBox.Text = string.Empty;
            PhNumTxtBox.Text = string.Empty;
            AddressTxtBox.Text = string.Empty;
            RoleComboBox.Text = string.Empty;
            UsernameTxtBox.Text = string.Empty;
            PasswordTxtBox.Text = string.Empty;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
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
