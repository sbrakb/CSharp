using System;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menu *****\n");
            Console.WriteLine("-----------------------------");

            #region Kategori Ekleme
            /*
            Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JMANIK7;initial catalog=CSharpDb;integrated security=true");
            string query = "insert into categories(name) values(@p1)";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Kategori Eklendi");
            */
            #endregion

            #region Ürün Ekleme
            /*
            string productName;
            decimal productPrice;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JMANIK7;initial catalog=CSharpDb;integrated security=true");
            string query = "insert into products(name,price,status) values(@p1,@p2,@p3)";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1",productName);
            command.Parameters.AddWithValue("@p2",productPrice);
            command.Parameters.AddWithValue("@p3",true);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("Ürün Eklendi");
            */
            #endregion

            #region Ürün Listeleme
            /*
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JMANIK7;initial catalog=CSharpDb;integrated security=true");
            connection.Open();
            string query = "select * from products";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            connection.Close();
            */
            #endregion

            #region Ürün Güncelleme
            string productName;
            decimal productPrice;

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JMANIK7;initial catalog=CSharpDb;integrated security=true");
            string query = "update products set name=@p1 ,price=@p2 where Id=@p3";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", productName);
            command.Parameters.AddWithValue("@p2", productPrice);
            command.Parameters.AddWithValue("@p3", productId);
            command.ExecuteNonQuery();
            Console.Write("Ürün Güncellendi");
            connection.Close();

            #endregion

            #region Ürün Silme
            /*
            Console.Write("Silinecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JMANIK7;initial catalog=CSharpDb;integrated security=true");
            connection.Open();
            string query = "delete from products where Id = @p1";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün Silindi");
            */
            #endregion

            Console.Read();
        }
    }
}
