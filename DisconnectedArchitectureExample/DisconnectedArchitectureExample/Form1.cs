using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedArchitectureExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Forml_Load(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection("Data Source=127.0.0.1; port =3306;Database=Sourabhdb;User Id=root;Password=root"))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM customer", cn);
                DataSet ds = new DataSet();
                da.Fill(ds,"customer");
                dataGridView1.DataSource = ds.Tables[0];
            }

            using (MySqlConnection cn = new MySqlConnection("Data Source=127.0.0.1; port =3306;Database=Sourabhdb;User Id=root;Password=root"))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM employee", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "employee");
                dataGridView1.DataSource = ds.Tables[0];
            }

            using (MySqlConnection cn = new MySqlConnection("Data Source=127.0.0.1; port =3306;Database=Sourabhdb;User Id=root;Password=root"))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM product", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "product");
                dataGridView1.DataSource = ds.Tables[0];
            }

        }
    }
}
