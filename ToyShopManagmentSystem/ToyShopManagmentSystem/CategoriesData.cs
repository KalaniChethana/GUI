using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ToyShopManagmentSystem
{
    internal class CategoriesData
    {
        public int ID { get; set; }

        public string Category { get; set; }

        public string Date { get; set; }

        

        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GUI\ToyShopManagmentSystem\ToyShopManagmentSystem\toyshop.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Date = reader["date"].ToString();

                        listData.Add(cData);
                    }
                }



            }

            return listData;
        }
    }
}

