using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace app
{

    interface IdProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        List<Product> Find(string productName);
        int Count();
        int Create(Product p);

        int Update(Product s, string find);

        void Delete(Product pid);
    }

    public class SqlProduct : IdProduct
    {
        private SqlConnection GetMsConnection()
        {
            string connectionString = @"Data Source=FıSTıK\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;";
            return new SqlConnection(connectionString);
        }
        public int Create(Product p)
        {
            int result = 0;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "insert into dbo.Products(ProductName,UnitPrice,Discontinued) VALUES(@productname,@unitprice,@disc)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    
                    command.Parameters.AddWithValue("@productname", p.Name);
                    command.Parameters.AddWithValue("@unitprice", p.Price);
                    command.Parameters.AddWithValue("@disc", 1);
                    
                    result = command.ExecuteNonQuery();
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("Damn");
                    Console.WriteLine(e.Message);
                }
                finally{
                    connection.Close();
                }
                return result ;
            } 
            
        }

        public void Delete(Product s)
        {
            int result = 0;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "Delete from dbo.Products Where ProductName = @name";
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@name", s.Name);

                    result = command.ExecuteNonQuery();
                    
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
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = null;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "select * from products";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    products = new List<Product>();
                    while(reader.Read())
                    {
                        products.Add(
                            new Product
                            {
                                ProductId=int.Parse(reader["ProductId"].ToString()),
                                Name = reader[ "ProductName"].ToString(),
                                Price = double.Parse(reader["UnitPrice"]?.ToString()),
                            }
                        );
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
                return products;
            }
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "select * from products where ProductID = @pid";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@pid",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.Read())
                    {
                        product = new Product();
                        product.ProductId=int.Parse(reader["ProductID"].ToString());
                        product.Name = reader["ProductName"].ToString();
                        product.Price = double.Parse(reader["UnitPrice"]?.ToString());

                    }

                    Console.WriteLine($"ID: {product.ProductId}, NAME: {product.Name}, Price: {product.Price}");
                    
                    reader.Close();
                    
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("Damn");
                    Console.WriteLine(e.Message);
                }
                finally{
                    connection.Close();
                }
                return product;
            }
        }

        public int Update(Product s, string find)
        {
            int result = 0;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "UPDATE dbo.Products Set ProductName = @name, UnitPrice=@u Where ProductName = @n";
                    SqlCommand command = new SqlCommand(sql, connection);
                    
                    command.Parameters.AddWithValue("@name", s.Name);
                    command.Parameters.AddWithValue("@u", s.Price);
                    command.Parameters.AddWithValue("@id", s.ProductId);
                    command.Parameters.AddWithValue("@n", find);

                    result = command.ExecuteNonQuery();
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("Damn");
                    Console.WriteLine(e.Message);
                }
                finally{
                    connection.Close();
                }
                return result ;
            } 
        }

        public List<Product> Find(string productName)
        {
            List<Product> products = null;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "select * from dbo.Products Where ProductName LIKE @pid;";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@pid",System.Data.SqlDbType.NVarChar).Value= "%"+productName+"%";

                    SqlDataReader reader = command.ExecuteReader();
                    products = new List<Product>();
                    while(reader.Read())
                    {
                        products.Add(
                            new Product
                            {
                                ProductId=int.Parse(reader["ProductId"].ToString()),
                                Name = reader[ "ProductName"].ToString(),
                                Price = double.Parse(reader["UnitPrice"]?.ToString()),
                            }
                        );
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
                return products;
            }
        }

        public int Count()
        {
            int count = 0;
            using(var connection = GetMsConnection())
            {
                try{
                    connection.Open();
                    string sql = "select count(*) from dbo.Products";

                    SqlCommand command = new SqlCommand(sql, connection);
                    object temp = command.ExecuteScalar();
                    if(temp!=null)
                    {
                        count = int.Parse(temp.ToString());
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
                return count;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Ilgaz = new SqlProduct();
            Product Selen = new Product(){
                ProductId = 921,
                Name = "Emek",
                Price = 2000,
            };
            Ilgaz.Delete(Selen);
        }   
    }
}

