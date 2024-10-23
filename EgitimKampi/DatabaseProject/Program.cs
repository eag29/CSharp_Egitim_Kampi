using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ürün Bilgi Sistemi

            //Ado.net: C# programlama dilinde Sql yapılarının kullanabilmesine olanak sağlayan çerçevedir.

            /*Console.WriteLine("***** C# Veri Tabanlı Ürün_Kategorisi Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TblCategory", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.Close();
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine() ;
            }*/

            #endregion

            #region Tekrar Ürün Bilgi Sistemi

           /*Console.WriteLine("********** C# LOKANTASI **********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------");
            int islemNo;
            Console.WriteLine("1- *** KATEGORİLER ***");
            Console.WriteLine("2- *** ÜRÜNLER ***");
            Console.WriteLine("3- *** SİPARİŞLER ***");
            Console.WriteLine("4- *** ÇIKIŞ YAP ***");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine();
            islemNo = int.Parse(Console.ReadLine());

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TMVO8N4\SQLEXPRESS;Initial Catalog=EgitimKampi;Integrated Security=True");

            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TblCategory", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.Close();

            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }*/

            #endregion

            Console.Read();
        }
    }
}
