using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Ekleme İşlemi
            // crud --> create read update delete
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.Write("Eklemek istediğiniz kategori adi: ");
            //string categoryname = Console.ReadLine();

            //SqlConnection conn = new SqlConnection("Data Source = OMER; initial Catalog = CSharpKamp; Integrated security = true");
            //conn.Open();

            //SqlCommand sqlCommand = new SqlCommand("insert into Category (categoryName) values (@p1)", conn);
            //sqlCommand.Parameters.AddWithValue("@p1", categoryname);
            //sqlCommand.ExecuteNonQuery();
            //conn.Close();
            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=OMER;initial Catalog=CSharpKamp;Integrated security=true");
            //connection.Open();

            //SqlCommand komut = new SqlCommand("insert into Product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);

            //komut.Parameters.AddWithValue("@p1",productName);
            //komut.Parameters.AddWithValue("@p2",productPrice);
            //komut.Parameters.AddWithValue("@p3", true);

            //komut.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün başarıyla eklendi!");



            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=OMER;initial Catalog=CSharpKamp;Integrated security=true");
            //connection.Open();

            //SqlCommand sqlCommand = new SqlCommand("select * from Product",connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}




            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silmek istediğiniz ürünün Id numarasını giriniz -> ");
            //int productid = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=OMER;initial Catalog=CSharpKamp;Integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("delete from Product Where Productid=@productid",connection);
            //cmd.Parameters.AddWithValue("@productid",productid);
            //cmd.ExecuteNonQuery();

            //Console.WriteLine("Ürün başarıyla silindi!");
            //connection.Close();

            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Ürün ID: ");
            int productid = int.Parse(Console.ReadLine());
            Console.Write("Ürün Ad: ");
            string productName = Console.ReadLine();
            Console.Write("Ürün Fiyat: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=OMER;initial Catalog=CSharpKamp;Integrated security=true");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("update Product Set ProductName=@productName,ProductPrice=@productPrice where Productid=@productid", connection);
            sqlCommand.Parameters.AddWithValue("@productName",productName);
            sqlCommand.Parameters.AddWithValue("@productPrice", productName);
            sqlCommand.Parameters.AddWithValue("@productid", productid);
            sqlCommand.ExecuteNonQuery();
            connection.Close();





            #endregion
            Console.Read();

        }
    }
}
