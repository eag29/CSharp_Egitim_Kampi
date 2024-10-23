using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            /*Console.Write("Şifreyi giriniz: ");

            string password;
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.Write("Şifre geçerli.");
            }
            else
            {
                Console.Write("Şifre geçersiz.");
            }*/

            /*string capital, country;

            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if (capital == "Ankara" & country == "Türkiye")
            {
                Console.Write("Bilgiler Doğru");
            }
            else
            {
                Console.Write("Bilgiler Yanlış");
            }*/

            /*int number;
            Console.Write("Sayıyı Giriniz: ");
            number = int.Parse(Console.ReadLine());

            if (number == 29)
            {
                Console.Write("Sayı Doğru");
            }
            else
            {
                Console.Write("Sayı hatalı");
            }*/

            /*int exam1, exam2, exam3, average;
            string result = " ";

            Console.Write("Sınav1: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Sınav2: ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Sınav3: ");
            exam3 = int.Parse(Console.ReadLine());

            Console.Write("Ortalama: ");
            average = (exam1 + exam2 + exam3) / 3;
            Console.Write(average);

            if (average > 0 & average <= 50)
            {
                result = " Sonuç vasat";
            }

            if (average > 5 & average <= 70)
            {
                result = " Orta";
            }

            if (average > 70 & average <= 84)
            {
                result = " İyi";
            }

            if (average > 84 & average <= 100)
            {
                result = " Çok iyi";
            }

            Console.WriteLine(result);*/

            /*string city;
            Console.Write("Şehir Girişi Yapınız: ");
            city = Console.ReadLine();

            if (city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon")
            {
                Console.WriteLine("Şehir mevcut.");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil.");
            }*/


            /*Console.Write("Lütfen kullanıcı adını giriniz: ");
            string username = Console.ReadLine();

            if (username != "admin")
            {
                Console.WriteLine("Kuulanıcı adı hatalı");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz :)))");
            }*/

            #endregion

            #region Mod İşlemleri

            /*int number = 26;
            int result = number % 5;
            Console.WriteLine(result);*/

            /*Console.Write("Lütfen 1.sayıyı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;
            Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);*/

            /*Console.Write("Lütfen sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("Sayıyı çifttir.");
            }
            else
            {
                Console.Write("Sayı tektir");
            }*/


            #endregion

            #region Char ile Karar Yapıları

            /*char team;
            Console.Write("Takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'F' | team == 'f')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'G' | team == 'g')
            {
                Console.Write("Galatasaray");
            }
            if (team == 'B' | team == 'b')
            {
                Console.Write("Beşiktaş");
            }


            Console.WriteLine("****** C# Eğitim Kampı Restoranı ******");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------");

            string menuItem;

            Console.WriteLine("Detayını görmek istediğimiz menü seçimi: ");
            Console.WriteLine();
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine(" ------------------------ Ana Yemekler ------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Fasulya Pilav");
                Console.WriteLine("4- Fırında Somon");
                Console.WriteLine("5- FaPatlıcan Musakka");
                Console.WriteLine(" ------------------------ Ana Yemekler ------------------------");
                Console.WriteLine();
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine(" ------------------------ Çorbalar ------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Çorbası");
                Console.WriteLine("2- Ezogelin Çorbası");
                Console.WriteLine();
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine(" ------------------------ Pizzalar ------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Akdeniz Pizza");
                Console.WriteLine("2- Margaritha Pizza");
                Console.WriteLine("3- Tavuklu Pizza");
                Console.WriteLine();
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine(" ------------------------ İçecekler ------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Kola");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3- Su");
                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine(" ------------------------ Tatlılar ------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Triliçe");
                Console.WriteLine("2- Kazandibi");
                Console.WriteLine("3- Sütlaç");
                Console.WriteLine();
            }*/

            #endregion

            #region Switch Case

            /*int monthNumber;

            Console.Write("Lütfen Ay girişi yapınız: ");
            monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.Write("Ocak");
                    break;
                case 2:
                    Console.Write("Şubat");
                    break;
                case 3:
                    Console.Write("Mart");
                    break;
                case 4:
                    Console.Write("Nisan");
                    break;
                case 5:
                    Console.Write("Mayıs");
                    break;
                case 6:
                    Console.Write("Haziran");
                    break;
                case 7:
                    Console.Write("Temmuz");
                    break;
                case 8:
                    Console.Write("Ağustos");
                    break;
                case 9:
                    Console.Write("Eylül");
                    break;
                case 10:
                    Console.Write("Ekim");
                    break;
                case 11:
                    Console.Write("Kasım");
                    break;
                case 12:
                    Console.Write("Aralık");
                    break;
                default:
                    Console.Write("Tanımsız veri girişi yapıldı.");
                    break;
            }*/

            #endregion

            #region Switch Case Hesap Makinesi

            /*int number1, number2, result;
            char symbol;

            Console.WriteLine("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkartma: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpma: " + result);
                    break;
            }*/
            #endregion

            #region Tekrar If Else

            /*string password;

            Console.Write("Şifre giriniz: ");
            password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            if (password == "ABC")
            {
                Console.Write("Şifre doğru ");
            }
            else
            {
                Console.Write("Şifre yanlış ");
            }*/


            /*string team, captain;

            Console.Write("Takımı giriniz: ");
            team = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Takım Kaptanını giriniz: ");
            captain = Console.ReadLine();

            if (team == "Fenerbahçe" & captain == "Edin Dzeko")
            {
                Console.Write("TRUE");
            }
            else
            {
                Console.Write("FALSE");
            }*/

            /*int exam1, exam2, exam3, result;
            string durum = "";

            Console.Write("1.Sınavı Giriniz: ");
            Console.WriteLine();
            exam1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("2.Sınavı Giriniz: ");
            Console.WriteLine();
            exam2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("3.Sınavı Giriniz: ");
            Console.WriteLine();
            exam3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Not ortalaması: ");
            result = (exam1 + exam2 + exam3) / 3;
            Console.Write(result);

            Console.WriteLine();
            Console.WriteLine();

            if (result > 0 & result <= 49)
            {
                durum = (":(");
            }
            if (result > 49 & result <= 59)
            {
                durum = (":():");
            }
            if (result > 60 & result <= 84)
            {
                durum = (":)");
            }
            if (result > 84 & result <= 100)
            {
                durum = (":))");
            }

            Console.Write(durum);*/


            /*string city;

            Console.Write("Şehir Giriniz: ");
            Console.WriteLine();
            Console.WriteLine();
            city = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            if (city == "Gümüşhane" || city == "Artvin")
            {
                Console.WriteLine("+++++++");
            }
            else
            {
                Console.WriteLine("------");
            }*/

            /*int password;

            Console.WriteLine("Şifrenizi Giriniz: ");

            password = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            if (password != 2929)
            {
                Console.WriteLine("HATALI GİRİŞ :((((");
            }
            else
            {
                Console.WriteLine("DOĞRU GİRİŞ :))))");
            }   */

            #endregion

            #region Tekrar Mod İşlemleri

            /*int number, numberr, result;

            Console.WriteLine("İLK SAYIYI GİRİNİZ: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("İKİNCİ SAYIYI GİRİNİZ: ");
            numberr = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            result = number % numberr;
            Console.WriteLine("Kalan: " + result);
            Console.WriteLine();*/

            /*int sayim;
            Console.WriteLine("Sayı Giriniz: ");
            sayim = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (sayim % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }*/

            #endregion

            #region Tekrar Char İle Karar Yapıları

            /*char alfabe;

            Console.WriteLine("Harf Giriniz: ");
            alfabe = char.Parse(Console.ReadLine());

            if (alfabe == 'A' || alfabe == 'a')
            {
                Console.Write("Alfabenin ilk harfi girildi. ");
            }
            if (alfabe == 'B' || alfabe == 'b')
            {
                Console.Write("Alfabenin ikinci harfi girildi. ");
            }
            if (alfabe == 'C' || alfabe == 'c')
            {
                Console.Write("Alfabenin üçüncü harfi girildi. ");
            }*/

            /*Console.WriteLine("------- YEMEKLEEEEERRRRR");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - HAMBURGER");
            Console.WriteLine("2 - DÖNER");
            Console.WriteLine("3 - PİZZA");
            Console.WriteLine();
            Console.WriteLine();

            int menuNo;
            Console.WriteLine("Seçmek istediğimiz menüyü giriniz: ");
            Console.WriteLine();
            Console.WriteLine();
            menuNo = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            if (menuNo == 1)
            {
                Console.WriteLine(" 1 - TAVUK BURGER");
                Console.WriteLine(" 2 -  ET BURGER");
                Console.WriteLine(" 3 - CHESEE BURGER");
                Console.WriteLine();
                Console.WriteLine();
            }
            if (menuNo == 2)
            {
                Console.WriteLine("1 - TAVUK DÖNER");
                Console.WriteLine("2 - ET DÖNER");
                Console.WriteLine();
                Console.WriteLine();
            }
            if (menuNo == 3)
            {
                Console.WriteLine("1 - SOSİSLİ PİZZA");
                Console.WriteLine("2 - SUCUKLU PİZZA");
                Console.WriteLine("3 - MANTAR PİZZA");
                Console.WriteLine();
                Console.WriteLine();
            }*/

            #endregion

            #region Tekrar Switch Case

            /*Console.WriteLine("Choose the character: ");
            Console.WriteLine();

            char character;
            character = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            switch (character)
            {
                case 'A':
                    Console.WriteLine("First Character");
                    break;
                case 'B':
                    Console.WriteLine("Second Character");
                    break;
                case 'C':
                    Console.WriteLine("Third Character");
                    break;
                default:
                    Console.WriteLine("Default Character");
                    break;
            }*/


            #endregion

            #region Tekrar Switch Case Hesap Makinesi

            /*Console.WriteLine("SAYILARI GİRİNİZ: ");
            Console.WriteLine();
            Console.WriteLine();

            int sayi1, sayi2, result;
            char islem;
            Console.WriteLine("SAYI 1 ?");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SAYI 1 ?");
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("İŞLEM ?");
            islem = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            switch (islem)
            {
                case '+':
                    result = sayi1 + sayi2;
                    Console.WriteLine("İŞLEM: " + result);
                    break;
                case '-':
                    result = sayi1 - sayi2;
                    Console.WriteLine("İŞLEM: " + result);
                    break;
                case '*':
                    result = sayi1 * sayi2;
                    Console.WriteLine("İŞLEM: " + result);
                    break;
            }*/

            #endregion

            Console.Read();
        }
    }
}
