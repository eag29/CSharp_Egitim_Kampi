using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.Write("Selamunaleyküm");
            //Console.WriteLine("Aleykümselam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //Console.Read();
            #endregion

            #region String Değişkenler

            // string
            // Değişken_türü değişkenadi;

            /*string name;
            name = "Mustafa";
            Console.Write(name);*/

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Emir Ali";
            //customerSurname = "Girgin";
            //customerPhone = "05512677429";
            //customerEmail = "emirali19078@gmail.com";
            //district = "Kartal";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("İl: " + city);
            //Console.WriteLine("İlçe: " + district);


            //customerName = "Emre";
            //customerSurname = "Girgin";
            //customerPhone = "05547869229";
            //customerEmail = "emrerre29@gmail.com";
            //district = "Kartal";
            //city = "İstanbul";

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("İl: " + city);
            //Console.WriteLine("İlçe: " + district);

            //Console.Read();

            #endregion

            #region Int Degiskenler

            /*int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int friesPrice = 50;
            int cokePrice = 35;
            int lemonadePrice = 30;
            int fantaPrice = 35;
            int waterPrice = 10;

            Console.WriteLine("*** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("----Kola Fiyatı: " + cokePrice + " TL");


            Console.WriteLine();
            int hamburgerCount;
            int pizzaCount;
            int friesCount;
            int cokeCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalfriesPrice = 0;
            int totalcokePrice = 0;
            int totalLemaonadeCount = 0;

            hamburgerCount = 4;
            friesCount = 4;
            cokeCount = 1;
            lemonadeCount = 1;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalLemaonadeCount = lemonadeCount * lemonadePrice;

            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalfriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalcokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemaonadeCount + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalfriesPrice + totalcokePrice + totalLemaonadeCount;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);*/

            #endregion

            #region Tekrar

            // --- Yazdırma Komutları ---


            /*Console.WriteLine("GEL DENEYELİM DİYORSUN OLUR MU YENİDEN");
            Console.WriteLine();
            Console.WriteLine("1-LİVAKOVİC");
            Console.WriteLine("2-OSAYİ");
            Console.WriteLine("3-CAGLAR");
            Console.WriteLine("4-BECAO");
            Console.WriteLine("5-JAYDEN");*/


            // --- STRING ---

            /*string player;
            string pozitision;

            player = "Amrabat";
            pozitision = "Orta Saha";

            Console.WriteLine("----- TRANSFERLER -----");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Oyuncu: " + player + " + Pozisyon: " + pozitision);*/


            // --- INT---

            /*int etdonerPrice = 90;
            int tavukdonerPrice = 45;
            int ayranPrice = 15;
            int kolaPrice = 25;

            Console.WriteLine("--------- YEMEK FİYATLARI -------- (:");
            Console.WriteLine(":)");
            Console.WriteLine(":)");
            Console.WriteLine("ET DÖNER FİYATI: " + etdonerPrice);
            Console.WriteLine("TAVUK DÖNER FİYATI: " + tavukdonerPrice);
            Console.WriteLine("AYRAN FİYATI: " + ayranPrice);
            Console.WriteLine("KOLA FİYATI: " + kolaPrice);

            int etdonerCount = 3;
            int tavukDonerCount = 1;
            int kolaCount = 2;
            int ayranCount = 2;

            int etdonerToplamUcret = etdonerCount * etdonerPrice;
            int tavukdonerToplamUcret = tavukDonerCount * tavukdonerPrice;
            int kolaToplamUcret = kolaCount * kolaPrice;
            int ayranToplamUcret = ayranCount * ayranPrice;

            Console.WriteLine(":)");
            Console.WriteLine(":)");
            Console.WriteLine(" :)))) ÖDENECEK TUTAR :)))))");
            Console.WriteLine(" ET DÖNER ÜCRETİ: " + etdonerToplamUcret);
            Console.WriteLine(" TAVUK DÖNER ÜCRETİ: " + tavukdonerToplamUcret);
            Console.WriteLine(" KOLA ÜCRETİ: " + kolaToplamUcret);
            Console.WriteLine(" AYRAN ÜCRETİ: " + ayranToplamUcret);
            Console.WriteLine(" TEŞEKKÜRLER ");*/

            #endregion

            Console.Read();

        }
    }
}