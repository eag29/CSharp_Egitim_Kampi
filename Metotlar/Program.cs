using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer ---> List, insert, delete, update
            //Void

            /*void CustomerList()
            {
                Console.WriteLine("Ali Çınar");
                Console.WriteLine("Hakan Öztürk");
            }
            CustomerList();*/

            /*void Sum()
            {
                int x = 1;
                int y = 2;
                int z = x+y;
                Console.WriteLine(z);
            }
            Sum();*/

            #endregion

            #region Geriye Değer Döndürmeyen Parametleri Metotlar

            /*void WriteMethod(string CustomerName)
            {
                Console.WriteLine(CustomerName);
            }

            WriteMethod("Ahmet Ünal");*/

            /*void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri: " + name + surName);
            }
            CustomerCard("Edis", " Nail");
            CustomerCard("Ekin", " Odak");*/

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametleri Metotlar

            /*void Sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            Sum(1, 2, 3);*/

            #endregion

            #region Geriye Değer Döndüren Metotlar

            /*string CustomerName()
            {
                return "Buse Şeker";
            }
            CustomerName();*/

            /*string StudentCart()
            {
                string name = "Ali";
                string surName = "Kaya";

                return name + " " + surName;
            }
            Console.WriteLine(StudentCart());*/

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            /*string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = countryName + " " + capital + " " + flagColor;
                return cardInfo;
            }
            string x, y, z;
            Console.Write("Ülke adını giriniz: ");
            x = Console.ReadLine();
            Console.Write("Başkenti Giriniz: ");
            y = Console.ReadLine();
            Console.Write("Bayrak Rengini Giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));*/

            #endregion

            #region Geriye Değer Dödüren Int Parametreli Metotlar

            /*int Hesapla(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Hesapla(9, 8));*/

            #endregion

            #region Örnek Uygulama

            /*string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavdan geçti." + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı." + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ayhan", 23, 81, 94));*/

            #endregion

            #region Tekrar Metotlar

            /*void Captains()
            {
                Console.WriteLine("Edin Dzeko");
                Console.WriteLine("Dusan Tadic");
                Console.WriteLine("Mert Hakan Yandaş");
            }
            Captains();

            void Numbers()
            {
                int c1 = 9;
                int c2 = 10;
                int c3 = 8;
                int sum = c1 + c2 + c3;
                Console.WriteLine(sum);
            }
            Numbers();*/

            #endregion

            #region Tekrar Geriye Değer Döndürmeyen Parametreli Metotlar

            /*void PresidentName(string name)
            {
                Console.WriteLine(name);
            }
            PresidentName("Ali Koç");

            void PlayerNames(string name, string surnames)
            {
                Console.WriteLine("Name: " + name + "  Surname: " + surnames);
            }
            PlayerNames("İrfan Can", "Kahveci");*/

            #endregion

            #region Tekrar Geriye Değer Döndürmeyen Int Parametreli Metotlar

            /*void Topla(int s1, int s2)
            {
                int s3 = s1 + s2;
                Console.WriteLine(s3);
            }
            Topla(5, 6);*/

            #endregion

            #region Tekrar Geriye Değer Döndüren Metotlar

            /*string Fikstur()
            {
                return "Manu";
            }
            Fikstur();*/

            /*string LigMaclari()
            {
                string ilkMac = "Bodrum";
                string ikinciMac = "Sivasspor";
                return ilkMac + " " + ikinciMac;
            }
            Console.WriteLine(LigMaclari());*/

            #endregion

            #region Tekrar Geriye Değer Döndüren String Parametreli Metotlar

            /*string UlkeBilgileri(string UlkeAdi, string Baskent)
            {
                string UlkeBilgi = UlkeAdi + " " + Baskent;
                return UlkeBilgi;
            }
            string a, b;
            Console.WriteLine("Ülke Adını Giriniz: ");
            a = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Başkent Adını Giriniz: ");
            b = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(UlkeBilgileri(a, b));*/

            #endregion

            #region Tekrar Geriye Değer Döndüren Int Parametreli Metotlar

            /*int CarpmaIslemi(int sayi1, int sayi2)
            {
                int sonuc = sayi1 * sayi2;
                return sonuc;
            }
            Console.WriteLine(CarpmaIslemi(75, 65));*/

            #endregion

            #region Tekrar Ornek Uygulama

            /*string SinavSonuc(string student, int sinav1, int sinav2, int sinav3)
            {
                int result = (sinav1 + sinav2 + sinav3) / 3;

                if (result >= 50)
                {
                    return student + " adlı öğrenci dersten geçmiştir. " + "Ortalaması: " + result;
                }
                else
                {
                    return student + " adlı öğrenci dersten kalmıştır. " + "Ortalaması: " + result;
                }
            }
            Console.WriteLine(SinavSonuc("Kemal", 21, 76, 89));*/

            #endregion

            Console.Read();
        }
    }
}
