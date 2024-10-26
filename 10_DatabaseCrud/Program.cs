using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud--> Crate, Read, Update, Delete

            #region Kategori Ekleme İşlemi

            /*Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", bgl);
            komut.Parameters.AddWithValue("@p1", categoryName);
            komut.ExecuteNonQuery();
            bgl.Close();

            Console.Write("Kategori Başarıyla Eklendi! ");*/

            #endregion

            #region Ürün Ekleme İşlemi

            /*string productName;
            decimal productPrice;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", bgl);
            cmd.Parameters.AddWithValue("@p1", productName);
            cmd.Parameters.AddWithValue("@p2", productPrice);
            cmd.Parameters.AddWithValue("@p3", true);
            cmd.ExecuteNonQuery();
            bgl.Close();*/

            #endregion

            #region Ürün Listeleme İşlemi

            /*SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TblProduct", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            bgl.Close();*/

            #endregion

            #region Ürün Silme İşlemi

            /*Console.Write("Silinecek Ürün id: ");
            int urunid = int.Parse(Console.ReadLine());

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Delete From TblProduct Where Productid=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", urunid);
            komut.ExecuteNonQuery();
            bgl.Close();

            Console.WriteLine("Silme İşlemi Gerçekleştirildi ");*/

            #endregion

            #region Ürün Güncelleme İşlemi

            /*Console.Write("Güncellenecek Ürün Id: ");
            int productid = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            int productPrice = int.Parse(Console.ReadLine());

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Update TblProduct set ProductName=@p1,ProductPrice=@p2 where Productid=@p3", bgl);
            komut.Parameters.AddWithValue("@p1", productName);
            komut.Parameters.AddWithValue("@p2", productPrice);
            komut.Parameters.AddWithValue("@p3", productid);
            komut.ExecuteNonQuery();
            bgl.Close();

            Console.WriteLine("Güncelleme Başarılı");*/

            #endregion

            #region Tekrar Kategori Ekleme İşlemi

            /*Console.WriteLine("Eklenmek istenen kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", bgl);
            komut.Parameters.AddWithValue("@p1", categoryName);
            komut.ExecuteNonQuery();
            bgl.Close();

            Console.WriteLine("Kategori Eklenmiştir!!! ");*/

            #endregion

            #region Tekrar Ürün Ekleme İşlemi

            /*Console.WriteLine("Eklenmek istenen ürün adı: ");
            string productName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Eklenmek istenen ürünün fiyatı: ");
            int productPrice = int.Parse(Console.ReadLine());

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TblProduct (ProductName,ProductPrice, ProductStatus) values (@p1,@p2,@p3)", bgl);
            komut.Parameters.AddWithValue("@p1", productName);
            komut.Parameters.AddWithValue("@p2", productPrice);
            komut.Parameters.AddWithValue("@p3", true);
            komut.ExecuteNonQuery();
            bgl.Close();

            Console.WriteLine("Ürün Eklenmiştir. ");*/
            #endregion

            #region Tekrar Ürün Listeleme İşlemi

            /*SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TblProduct", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            bgl.Close();

            Console.WriteLine("Ürünler Listelenmiştir. ");*/
            #endregion

            #region Tekrar Ürün Silme İşlemi

            /*Console.WriteLine("Silinmesi istenen ürünün id: ");
            int productid = int.Parse(Console.ReadLine());

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Delete From TblProduct where Productid=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", productid);
            komut.ExecuteNonQuery();
            bgl.Close();
            Console.WriteLine("Ürün silinmiştir!!!");*/

            #endregion

            #region Tekrar Ürün Güncelleme İşlemi

            /*Console.WriteLine("Güncellenmesi istenen ürünün id: ");
            int productid = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenmek İstenen Ad: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Güncelllenmek İstenen Fiyat: ");
            int productPrice = int.Parse(Console.ReadLine());   

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Update TblProduct set ProductName=@p1, ProductPrice=@p2 where Productid=@p3", bgl);
            komut.Parameters.AddWithValue("@p1",productName);
            komut.Parameters.AddWithValue("@p2",productPrice);
            komut.Parameters.AddWithValue("@p3",productid);
            bgl.Close();
            Console.WriteLine("Ürün Güncellenmiştir");*/

            #endregion

            Console.Read();
        }
    }
}
