using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class SignUpPage : Form
    {
        string connectionString;

        //Constructor
        public SignUpPage()
        {
            InitializeComponent();
            SignUpPanel.BackColor = Color.FromArgb(50, 128, 128, 128); // Semi-transparent grey
            SignUpPanel.BorderStyle = BorderStyle.None;

            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        }

        //UI Event Handlers
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string FirstName = FirstNameTxtBox.Text;
            string LastName = LastNameTxtBox.Text;
            string Email = EmailTxtBox.Text;
            string PhNum = PhNumTxtBox.Text;
            string Address = AddressTxtBox.Text;
            string Username = UsernameTxtBox.Text;
            string Password = PasswordTxtBox.Text;
            string HashedPassword = PasswordHasher.HashPassword(Password);
            
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(PhNum) || string.IsNullOrWhiteSpace(Address) || string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string usernameSearchQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    bool usernameExists;

                    using (SqlCommand command = new SqlCommand(usernameSearchQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        int count = (int)command.ExecuteScalar();
                        usernameExists = (count > 0);
                    }

                    if (usernameExists)
                    {
                        MessageBox.Show("Username " + Username + " already exists. Please choose a different username.");
                        return;
                    }

                    string insertQuery = "INSERT INTO Users (Username, Password, Role, FirstName, LastName, Email, Phone, Address) " +
                                   "VALUES (@Username, @Password, @Role, @FirstName, @LastName, @Email, @PhNum, @Address)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", HashedPassword);
                        command.Parameters.AddWithValue("@Role", "Customer");
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@PhNum", PhNum);
                        command.Parameters.AddWithValue("@Address", Address);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("User added successfully! Please Login to continue.");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.Text = string.Empty;
            LastNameTxtBox.Text = string.Empty;
            EmailTxtBox.Text = string.Empty;
            PhNumTxtBox.Text = string.Empty;
            AddressTxtBox.Text = string.Empty;
            UsernameTxtBox.Text = string.Empty;
            PasswordTxtBox.Text = string.Empty;
        }
    }
}
