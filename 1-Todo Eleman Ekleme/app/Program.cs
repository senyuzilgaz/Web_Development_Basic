using System;
using System.Data.SqlClient;

namespace app
{
    class Program
    {
        private const string Value = "Başarıyla giriş yapıldı";

        static void Main(string[] args)
        {
            GetAllProducts();
        }

        static void GetAllProducts()
        {
            using(var connection = GetConnection())
            {
                try{
                    connection.Open();
                    string sql = "select * from products";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    List<Product>
                    while(reader.Read())
                    {
                        Console.WriteLine($"product name: {reader[0]} product price: {reader[6]}");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Damn");
                    Console.WriteLine(e.Message);
                }
                finally{
                    connection.Close();
                }
                            
        }
        static SqlConnection GetConnection(){
            string connectionString = @"Data Source=FıSTıK\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;";

            return new SqlConnection(connectionString);

        }
    }
    }
}
