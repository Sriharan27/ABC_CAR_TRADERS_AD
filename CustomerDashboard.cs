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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
            GreetingLbl.Text = "Hi " + UserSession.FullName;
        }

        private void OrderPageBtn_Click(object sender, EventArgs e)
        {
            formClose();
            OrderForm frm = new OrderForm();
            frm.Show();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            formClose();
            OrderReport frm = new OrderReport();
            frm.Show();
        }
        private void formClose()
        {
            this.Close();

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
