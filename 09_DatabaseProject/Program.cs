using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ürün - Kategori Bilgi Sistemi *****\n\n");

            string tableNumber;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasınız giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JMANIK7;initial catalog=CSharpDb;integrated security=true");
            connection.Open();
            string query = "select * from categories";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item.ToString()+" ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
