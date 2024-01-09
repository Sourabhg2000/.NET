using ConnectedArch.Models;
using ConnectedArchitectureExamples.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedArch
{
    public partial class frmCustomerCrudForm : Form
    {
        public frmCustomerCrudForm()
        {
            InitializeComponent();
        }

        CustomerDal customerDal = new CustomerDal();
        int index = 0;
        List<Customer> customersList;

        private void frmCustomerCrudForm_Load(object sender, EventArgs e)
        {
            customersList = customerDal.GetAllCustomers();
            Navigate(index);

        }

        private void Navigate(int currentIndex)
        {
            if(customersList.Count > 0) 
            {
                textBox1.Text = customersList[currentIndex].customer_id.ToString();
                txtFirstName.Text = customersList[currentIndex].first_name.ToString();
                txtLastName.Text = customersList[currentIndex].last_name.ToString();
                txtEmail.Text = customersList[currentIndex].email.ToString();
                txtPhone.Text = customersList[currentIndex].phone_number.ToString();
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                index--;
                Navigate(index);
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (index < customersList.Count -1)
            {
                index++;
                Navigate(index);
            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            index =customersList.Count - 1;
            Navigate(index);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            txtFirstName.Text =string.Empty;
            txtLastName.Text =string.Empty;
            txtEmail.Text =string.Empty;
            txtPhone.Text =string.Empty;
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customer_id = int.Parse(textBox1.Text),
                first_name = txtFirstName.Text,
                last_name = txtLastName.Text,
                email = txtEmail.Text,
                phone_number = txtPhone.Text
            };
            int result =customerDal.InsertCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllCustomers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customer_id = int.Parse(textBox1.Text),
                first_name = txtFirstName.Text,
                last_name = txtLastName.Text,
                email = txtEmail.Text,
                phone_number = txtPhone.Text
            };
            int result = customerDal.UpdateCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllCustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customer_id = int.Parse(textBox1.Text),
                first_name = txtFirstName.Text,
                last_name = txtLastName.Text,
                email = txtEmail.Text,
                phone_number = txtPhone.Text
            };
            int result = customerDal.DeleteCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllCustomers();
            }
        }
    }
}
