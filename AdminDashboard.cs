using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            GreetingLbl.Text = "Hi " + UserSession.FullName;
        }

        private void MngCarsBtn_Click(object sender, EventArgs e)
        {
            formClose();
            ManageCars manageCars = new ManageCars();
            manageCars.Show();
        }

        private void MngPartsBtn_Click(object sender, EventArgs e)
        {
            formClose();
            ManageParts manageParts = new ManageParts();
            manageParts.Show();
        }

        private void MngUserCustBtn_Click(object sender, EventArgs e)
        {
            formClose();
            ManageUsers users = new ManageUsers();
            users.Show();
        }

        private void ManageOrdersBtn_Click(object sender, EventArgs e)
        {
            formClose();
            ManageOrders orders = new ManageOrders();
            orders.Show();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            formClose();
            OrderReport report = new OrderReport();
            report.Show();
        }
        private void formClose()
        {
            this.SuspendLayout();

            List<Form> formsToClose = new List<Form>();

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() != typeof(Login))
                {
                    formsToClose.Add(openForm);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            this.ResumeLayout(false);
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            UserSession.UserId = 0;
            UserSession.Role = null;
            UserSession.FullName = null;
            formClose();
            Login login = new Login();
            login.Show();
        }
    }
}
