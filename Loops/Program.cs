using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongüsü

            /* For(x;y;z)
             * x:başlangıç
             * y:bitiş
             * z:artış -azalış
             * */

            /*for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# Eğitim Kampı");
            }*/

            /*
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }*/

            /*Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            int finishvalue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishvalue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }*/

            #endregion

            #region For Döngüsü ile Karar Yapıları

            /*for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*int totalValue = 0;

            for (int i = 1; i <= 10; i++)
            {
                totalValue += i;
            }
            Console.WriteLine(totalValue);*/

            /*int value = 0;
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    value += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine(value);*/

            /*int sayi = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    sayi ++;
                }
                Console.WriteLine(sayi);
            }*/

            /*int bacterium = 1;

            for (int i = 1; i < 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            }*/
            #endregion

            #region While Döngüsü

            /*while (şart)
            {
                işlemler
            }*/

            /*int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                i++;
            }*/

            /*int i = 1;

            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            /*int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum += i;
                i++;
            }

            Console.WriteLine(sum);*/

            #endregion

            #region Örnek Soru

            // Klavyeden girilen 3 basamaklı sayının basamakları ve basamaklarının toplamını hesaplayan kod

            /*Console.WriteLine("Sayı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            sum = ones  + tens + hundreds;
            Console.WriteLine("Sayıların toplamı: " + sum);*/


            #endregion

            #region Tekrar For Döngüsü

            /*for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("SARI LACİVERT ŞAMPİYON FENER");
            }*/

            /*for (int i = 1; i < 30; i++)
            {
                Console.WriteLine("NE MUTLU TÜRKÜM DİYENE");
            }*/

            /*for (int i = 0; i < 25; i += 3)
            {
                Console.WriteLine(i);
            }*/

            /*Console.WriteLine("Ürün adedini giriniz: ");

            int adet = int.Parse(Console.ReadLine());

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("adet");
            }*/
            #endregion

            #region Tekrar For Döngüsü ile Karar Yapıları

            //0dan 50ye kadar olan 5e tam bölünen sayıları yazdıran kod

            /*for (int i = 0; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*int baslangicdegeri = 0;

            for (int i = 1; i <= 20; i++)
            {
                baslangicdegeri += i;
            }
            Console.WriteLine(baslangicdegeri);*/

            /*int value = 0;

            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    value += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------");
            Console.WriteLine(value);*/

            //0 ila 63 arasında 4e tam bölünen sayıları ve 4e tam bölünen sayıların toplamını yazdıran kod.

            /*int sayi = 0;

            for (int i = 0; i < 60; i++)
            {
                if (i % 4 == 0)
                {
                    sayi += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------");
            Console.WriteLine(sayi);*/

            //0 ila 63 arasında 9a tam bölünen sayıların adedini yazdıran kod.

            /*int sayi = 0;

            for (int i = 0; i < 63; i++)
            {
                if (i % 9 == 0)
                {
                    sayi ++;
                }
            }
            Console.WriteLine(sayi);*/

            //üs alma

            /*int virus = 1;

            for (int i = 1; i < 24; i++)
            {
                virus *= 2;
                Console.WriteLine(i + ". saat sonunda: " + virus);
            }*/

            #endregion

            #region While Döngüsü

            /*int i = 5;
            while (i <= 10)
            {
                Console.WriteLine("tamam");
                i++;
            }*/

            /*int i = 7;

            while (i <= 21)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("ok");
                }
                i++;
            }*/

            //10a kadar olan sayilarin toplamını yazdıran döngü

            /*int sayi = 1;
            int toplam = 0;

            while (sayi < 10)
            {
                toplam += sayi;
                sayi++;
            }
            Console.WriteLine(toplam);*/

            #endregion

            #region Basamak Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları ve basamaklarının toplamını hesaplayan kod

            /*Console.WriteLine("SAYI GİRİNİZ: ");
            Console.WriteLine();

            int sayi, yuzler, onlar, birler, toplam;

            sayi = int.Parse(Console.ReadLine());
            yuzler = sayi / 100;
            onlar = (sayi % 100) / 10;
            birler = sayi % 10;

            Console.WriteLine("Sayının basamaklar: " + "Yüzler basamağı: " + yuzler + " Onlar basamağı: " + onlar + " Birler basamağı: " + birler);
            Console.WriteLine();
            toplam = yuzler + onlar + birler;
            Console.WriteLine("Basamakların Toplamı: " + toplam);*/


            #endregion

            Console.ReadLine();
        }
    }
}
