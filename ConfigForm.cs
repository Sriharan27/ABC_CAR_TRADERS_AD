using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string dataSource = DataSourceTxtBox.Text;
            string databaseName = DbNameTxtBox.Text;

            UpdateConnectionString(dataSource, databaseName);

            MessageBox.Show("Database Configured successfully");

            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void UpdateConnectionString(string dataSource, string databaseName)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            connectionStringsSection.ConnectionStrings["MyDBConnectionString"].ConnectionString =
                $"Data Source={dataSource};Initial Catalog={databaseName};Integrated Security=True;";

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DataSourceTxtBox.Text = string.Empty;
            DbNameTxtBox.Text = string.Empty;
        }
    }
}
