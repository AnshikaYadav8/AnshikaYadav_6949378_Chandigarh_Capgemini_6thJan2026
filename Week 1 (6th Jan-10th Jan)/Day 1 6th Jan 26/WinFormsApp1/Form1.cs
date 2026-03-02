using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SSRF91E5\\SQLEXPRESS;Initial Catalog=AnshikaDB;TrustServerCertificate=True;Integrated Security=True";
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }
        }
    }
}
