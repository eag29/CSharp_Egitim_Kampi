using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            /* string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara" };

             foreach (string city in cities)
             {
                 Console.WriteLine(city);
             }*/

            /*int[] numbers = { 45, 23450234, 25, 245, 32, };

            int total = 0;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                Console.WriteLine();
                Console.WriteLine();

                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                total += number;
                Console.WriteLine(total);
            }*/


            #endregion

            #region List Yapısı

            /*List<int> list = new List<int>()
            {
                1,32,4,321,3
            };
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }*/

            /*string word = "Sa";
            foreach (char arg in word)
            {
                Console.WriteLine(arg);
            }*/


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            /*
            Console.Write("***** C# Eğitim Kampı Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Sınıfınızda kaç öğrenci var ? ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            double totalExamResult = 0;

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}. adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentNames[i]}. adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("----------");
            
            }*/

            #endregion

            #region Tekrar Foreach Dongusu

            /*string[] birlikler = { "Barbar", "Okçu", "Dev" };

            foreach (string itemms in birlikler)
            {
                Console.WriteLine(itemms);
            }*/

            /*int[] numbers = { 45, 62, 672, 54 };
            int total = 0;

            foreach (int i in numbers)
            {
                Console.WriteLine("TümSayılar");
                Console.WriteLine(i);
                Console.WriteLine("Sayıların Toplamı");
                total += i;
                Console.WriteLine(total);

                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            #endregion

            #region Tekrar List Yapısı

            /*List<string> list = new List<string>()
            {
                "Ahmet","Hasan"
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<int> im = new List<int>()
            {
               15,25
            };

            foreach (var item2 in im)
            {
                Console.WriteLine(item2);
            }*/

            #endregion

            #region Tekrar Örnek Sınav Sistemi Uygulaması

            /*Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------- ÖĞRENCİ SINAV SİSTEMİ UYGULAMASI ----------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Öğrenci sayısını giriniz. ");
            int studentCount = int.Parse(Console.ReadLine());
            string[] studentName = new string[studentCount];
            double[] examResult = new double[studentCount];
            double total = 0;

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"({i + 1}. öğrencinin ismini giriniz. )");
                studentName[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"({studentName[i]}. öğrencinin {j + 1} sınav notunu giriniz. )");
                    double value = double.Parse(Console.ReadLine());
                    total += value;
                }
                Console.WriteLine();
                examResult[i] = total / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"({studentName[i]}. öğrencinin ortalaması: )" + examResult[i]);

                if (examResult[i] <= 50)
                {
                    Console.WriteLine($"({studentName[i]}. adlı öğrenci sınıfı geçti.)");
                }
                else
                {
                    Console.WriteLine($"({studentName[i]}. adlı öğrenci sınıfta kaldı.)");
                }
            }*/
            #endregion

            Console.Read();
        }
    }
}
