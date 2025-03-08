using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class AddProductsData
    {
        public int ID { get; set; } //0

        public string prodID { get; set; }//1

        public string productName { get; set; }//2

        public string Category { get; set; }//3

        public string Price { get; set; }//4

        public string Stock { get; set; }//5

        public string Status { get; set; }//6

        public string Date { get; set; }//7

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.prodID = reader["prod_id"].ToString();
                        apData.productName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.Date = reader["date_insert"].ToString();
                        listData.Add(apData);
                    }
                }



            }

            return listData;
        }

        public List<AddProductsData> allAvailableProducts()
        {
            List<AddProductsData> listData = new List<AddProductsData>();
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products WHERE status = @status";


                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.prodID = reader["prod_id"].ToString();
                        apData.productName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.Date = reader["date_insert"].ToString();
                        listData.Add(apData);
                    }
                }



            }

            return listData;

        }
    }
}
