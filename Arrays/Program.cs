using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            /*string[] names = new string[3];
            names[0] = "Osman";
            names[1] = "Orhan";
            names[1] = "Murad";

            Console.WriteLine(names[1]);*/

            /*string[] cities = new string[5];

            cities[0] = "Gümüşhane";
            cities[1] = "Artvin";
            cities[2] = "Giresun";
            cities[3] = "Ordu";
            cities[4] = "Bayburt";

            Console.WriteLine(cities[3]);*/

            /*int[] numbers = new int[5];
            numbers[0] = 29;
            numbers[1] = 28;
            numbers[2] = 69;
            numbers[4] = 08;

            Console.WriteLine(numbers[3]);*/

            /*string[] countries = { "Türkiye", "Azerbaycan" };

            Console.WriteLine(countries[1]);*/


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Yellow", "Blue", "Green" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            /*int[] numbers = { 4, 34, 56, 33, 5432, 244, 23 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }*/

            /*char[] symbols = { 'a', 'b', 'c' };
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }*/

            //Dizideki en büyük sayıyı yazdıran kod.

            /*int[] myArray = { 1, 2, 645, 46, 3456, 4334, 23 };
            int maxNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);*/

            /*string[] persons = { "Ahmet", "Ali", "Veli" };
            Console.WriteLine(persons.Length);*/


            /*int[] numbers = { 70, 89, 04, 43 };
            Array.Sort(numbers); // Dizideki elemanları küçükten büyüğe sıralayan kod.
            Array.Reverse(numbers); // Dizideki elemanları tersten sıralayan kod.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/



            #endregion

            #region Dizi Metotlar

            /*string[] customers = { "Ayşegül", "Buse", "Merve" };
            int index = Array.IndexOf(customers, "Merve");
            Console.WriteLine(index);*/

            /*int[] numbers = { 45, 42, 14, 43 };
            Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());*/

            #endregion

            #region Kullanıcıdan Değer Alma

            /*string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
                cities[i] = Console.ReadLine();
            }
            //Dolar  ifadesi değişik karakterler kullanımını sağlar.

            Console.WriteLine();
            Console.WriteLine("-----------");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }*/

            /*int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);*/

            /*int[] numbers = { 21, 32, 43, 54, 65, 76, 87, 98, 19, 0 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }*/

            #endregion

            #region Temel Dizi Örnekleri Tekrar

            /*string[] kaleciler = new string[4];
            kaleciler[0] = "Uğurcan Çakır";
            kaleciler[1] = "Altay Bayındır";
            kaleciler[2] = "Muhammed Şengezer";
            kaleciler[3] = "Berke Özer";

            Console.WriteLine(kaleciler[3]);*/

            /*string[] bekler = new string[4] { "Zeki Çelik", "Mert Müldür", "Ferdi Kadıoğlu", "Eren Elmalı" };
            Console.WriteLine(bekler[3]);*/

            /*int[] plakalar = new int[5];
            plakalar[0] = 29;
            plakalar[1] = 08;
            plakalar[2] = 28;
            plakalar[3] = 52;
            plakalar[4] = 61;
            Console.WriteLine(plakalar[3]);*/

            /*int[] ciftsayilar = new int[6] { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine(ciftsayilar[3]);*/

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            /*string[] padisahlar = { "Osman, Orhan, Murad, Bayezid" };
            for (int i = 0; i < padisahlar.Length; i++)
            {
                Console.WriteLine(padisahlar[i]);
            }*/

            /*int[] sayilar = { 11, 32, 313, 54, 45, 36, 27, 18 };

            //Array.Sort(sayilar);
            //Array.Reverse(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 1)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }*/

            /*char[] chars = { 'a', 'b', 'c', };
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }*/

            //Dizideki en büyük sayıyı yazdıran kod

            /*int[] sayilar = { 70, 80, 90, 2153, 1234, 234 };
            int maxNumber = sayilar[0];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > maxNumber)
                {
                    maxNumber = sayilar[i];
                }
            }
            Console.WriteLine(maxNumber);*/

            #endregion

            #region Tekrar Dizi Metotları

            /*string[] names = { "Veli", "Ahmet", "Hasan" };
            int index = Array.IndexOf(names, "Ahmet");
            Console.WriteLine(index);*/

            /*int[] numbers = { 29, 23, 234 };
            int indexx = Array.IndexOf(numbers, 29);
            Console.WriteLine(indexx);
            Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());*/

            #endregion

            #region Tekrar Kullanıcıdan Değer Alma

            //Toplam değerini dizinin uzunluğuna getir.

            /*string[] ulkeler = new string[7];
            for (int i = 0; i < ulkeler.Length; i++)
            {
                Console.WriteLine($"Lütfen bir değer giriniz {i+1}. Ülke Giriniz: ");
                Console.WriteLine();
                ulkeler[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("------------");
            for (int i = 0; i < ulkeler.Length; i++)
            {
                Console.WriteLine(ulkeler[i]);
            }*/

            /*int[] numbers = { 9, 578, 567, 865 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Çift Sayılar");
                    Console.WriteLine(numbers[i]);
                    Console.WriteLine();
                }
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine("Tek Sayılar");
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Toplam");
            Console.WriteLine(sum);*/

            #endregion
            Console.Read();
        }
    }
}
