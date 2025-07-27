using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine();
            Console.WriteLine("***** C# Ürün Kategori Bilgi Otomasyonu");
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");

            Console.WriteLine("----------------------------------------------");


            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=OMER;initial Catalog=CSharpKamp;Integrated security=true");
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from Category",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable(); //verileri geçici belleğe alıyoruz.
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
