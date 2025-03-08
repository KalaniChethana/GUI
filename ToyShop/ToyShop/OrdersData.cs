using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ToyShop
{
    internal class OrdersData
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { get; set; }
        public string CID { get; set; }
        public string PID { get; set; }
        public string PName { get; set; }
        public string Category { get; set; }
        public string OrigPrice { get; set; }
        public string QTY { get; set; }
        public string TotalPrice { get; set; }


        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                int custID = 0;
                string selectCustData = "SELECT MAX(customer_id) FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    custID = (result != DBNull.Value) ? Convert.ToInt32(result) : 1;
                }

                string selectData = "SELECT * FROM orders WHERE customer_id = @cID";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@cID", custID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        OrdersData oData = new OrdersData
                        {
                            ID = (int)reader["id"],
                            CID = reader["customer_id"].ToString(),
                            PID = reader["prod_id"].ToString(),
                            PName = reader["prod_name"].ToString(),
                            Category = reader["category"].ToString(),
                            OrigPrice = reader["orig_price"].ToString(),
                            QTY = reader["qty"].ToString(),
                            TotalPrice = reader["total_price"].ToString(),

                        };
                        listData.Add(oData);
                    }
                }
            }

            return listData;
        }
    }
}

