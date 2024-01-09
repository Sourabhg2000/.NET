using ConnectedArch.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace ConnectedArchitectureExamples.Dal
{
    public class CustomerDal
    {
        public List<Customer> GetAllCustomers()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["Sourabh"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomers";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Customer> customers = new List<Customer>();
                    while (DR.Read())
                    {
                        customers.Add(new Customer()
                        {
                            
                            customer_id = Convert.ToInt32(DR["customer_id"]),
                            first_name = Convert.ToString(DR["first_name"]),
                            last_name = Convert.ToString(DR["last_name"]),
                            email = Convert.ToString(DR["email"]),
                            phone_number = Convert.ToString(DR["phone_number"])
                        });
                    }
                    DR.Close();
                    CN.Close();
                    return customers;
                }
            }
        }
        public int InsertCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["Sourabh"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.customer_id);
                    CMD.Parameters.AddWithValue("p_FirstName", customer.first_name);
                    CMD.Parameters.AddWithValue("p_LastName", customer.last_name);
                    CMD.Parameters.AddWithValue("p_email", customer.email);
                    CMD.Parameters.AddWithValue("p_PhoneNumber", customer.phone_number);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int UpdateCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["Sourabh"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.customer_id);
                    CMD.Parameters.AddWithValue("p_FirstName", customer.first_name);
                    CMD.Parameters.AddWithValue("p_LastName", customer.last_name);
                    CMD.Parameters.AddWithValue("p_email", customer.email);
                    CMD.Parameters.AddWithValue("p_PhoneNumber", customer.phone_number);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int DeleteCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["Sourabh"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.customer_id);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}

