using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ABC_Car_Traders
{
    public partial class Login : Form
    {
        private string connectionString;

        //Constructor
        public Login()
        {
            InitializeComponent();
            LoginPanel.BackColor = Color.FromArgb(50, 128, 128, 128);
            LoginPanel.BorderStyle = BorderStyle.None;

            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        }

        //UI Event Handlers
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string hashedPassword = PasswordHasher.HashPassword(password);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (username == "Master" && password == "ConfigDb")
            {
                this.Hide();
                ConfigForm configForm = new ConfigForm();
                configForm.ShowDialog();
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        MessageBox.Show("Database may have not been configured please contact the administrator!");
                        return;
                    }

                    string query = "SELECT UserID, Role, FirstName, LastName FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                            string fullName = reader["FirstName"].ToString() +' '+ reader["LastName"].ToString();
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            UserSession.FullName = fullName;
                            UserSession.UserId = userId;
                            UserSession.Role = role;

                            if (role == "Admin")
                            {
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                            }
                            else if (role == "Customer")
                            {
                                CustomerDashboard customerDashboard = new CustomerDashboard();
                                customerDashboard.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            UsernameTxtBox.Text = string.Empty;
            PasswordTxtBox.Text = string.Empty;
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Hide();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            formClose();
        }

        //Utility Methods
        private void formClose()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form openForm in Application.OpenForms)
            {
                formsToClose.Add(openForm);
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
    }
}
