using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ConnectedArch
{
    public partial class dgvCustomer : Form
    {
        public dgvCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["Sourabh"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand()) 
                { 
                   CN.Open();
                   cmd.Connection = CN;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetCustomerDetail";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable cus = new DataTable("customer");
                    cus.Load(dr);
                    dataGridView1.DataSource = cus;
                    CN.Close();
                }
            }
        }
    }
}
