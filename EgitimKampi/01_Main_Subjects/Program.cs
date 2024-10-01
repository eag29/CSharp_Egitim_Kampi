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

            #region Double Degiskenler

            /*double number;
            number = 11.75;
            Console.WriteLine(number);*/

            /*Console.WriteLine(" ********** FİYAT LİSTESİ *********");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı: " + tomatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");


            double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawGram + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Pataes - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");*/


            #endregion

            #region Char Degiskenler

            /*char symbol;
            symbol = 'A';
            Console.WriteLine(symbol);*/

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            /*Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu Telefonu: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Yolcu TC NO : " + passengerIdentityNumber + " Yolcu Ad: " + passengerName + " Yolcu Soyad: " + passengerSurname + " Yolcu İl: " + passengerCity + " Yolcu İlçe: " + passengerDistrict + " Yolcu Yaş: " + passengerAge);*/

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, TVPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 3000;
            //TVPrice = 22500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * TVPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. sınav notunu giriniz");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav notunu giriniz");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav notunu giriniz");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();        
            //Console.WriteLine(" Sınav Ortalamanız: " + result);        
            #endregion

            #region Kılavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen cinsiyet giriniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            //if (gender == 'E')
            //{
            //    Console.WriteLine("Seçtiğiniz cinsiyet: " + " Erkek");
            //}
            //else
            //{
            //    Console.WriteLine("Seçtiğiniz cinsiyet: " + " Kız");
            //}

            #endregion

            #region Tekrar1

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

            #region Tekrar2

            /* Double Değişkenler

            Console.WriteLine(" ././././  FİYAT LİSTESİ ./././././");
            Console.WriteLine();
            Console.WriteLine("--- ÜRÜNLER ----");
            Console.WriteLine();
            Console.WriteLine();

            double applePrice, kiwiPrice, strawberryPrice;

            applePrice = 14.750;
            kiwiPrice = 25.850;
            strawberryPrice = 23.350;

            Console.WriteLine(" - ELMA FİYATI: " + " " + applePrice + " TL");
            Console.WriteLine(" - KİVİ FİYATI: " + " " + kiwiPrice + " TL");
            Console.WriteLine(" - ÇİLEK FİYATI: " + " " + strawberryPrice + " TL");

            double appleCount, kiwiCount, strawCount;
            appleCount = 9.25;
            kiwiCount = 3.75;
            strawCount = 4.5;

            double appleTotalPrice, kiwiTotalPrice, strawberryTotalPrice;
            appleTotalPrice = appleCount * applePrice;
            kiwiTotalPrice = kiwiCount * kiwiPrice;
            strawberryTotalPrice = strawCount * strawberryPrice;

            double totalPrice = appleTotalPrice + kiwiTotalPrice + strawberryTotalPrice;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" --- ELMA GRAMAJI: " + appleCount + " Elma Tutarı: " + appleTotalPrice);
            Console.WriteLine(" --- KİVİ GRAMAJI: " + kiwiCount + " KİVİ Tutarı: " + kiwiTotalPrice);
            Console.WriteLine(" --- ÇİLEK GRAMAJI: " + strawCount + " ÇİLEK Tutarı: " + strawberryTotalPrice);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" -.-.-.-. TOPLAM ÖDENECEK TUTAR -.-.-.-.-.");
            Console.WriteLine(" -------------" + totalPrice + "--------------");*/

            /* Char Değişkenler

            char marka;
            marka = 'İ';
            Console.WriteLine(marka);*/

            /* Klavyeden Veri Girişleri String
             * 
            string name, surname, age, job;

            Console.WriteLine("------ KİŞİ BİLGİLERİ ------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Kişi adını giriniz:" );
            name = Console.ReadLine();

            Console.WriteLine("Kişi soyadını giriniz:");
            surname = Console.ReadLine();

            Console.WriteLine("Kişi yaşını giriniz:");
            age = Console.ReadLine();

            Console.WriteLine("Kişi mesleğini giriniz:");
            job = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Adı: " + name + " Soyadı: " + surname + "Y aşı: " + age + " Mesleği: " + job);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" TEŞEKÜRLER :))");*/

            /* Klavyeden Veri Girişleri Int

            Console.WriteLine("-.-.-..-.- ÜRÜN FİYATLARI -.--.-.-..-.-");          
            Console.WriteLine();          
            Console.WriteLine();          
            Console.WriteLine();

            int computerPrice, tvPrice, phonePrice;
            computerPrice = 32500;
            tvPrice = 22500;
            phonePrice = 17750;

            Console.WriteLine("BİLGİSAYAR FİYATI: " + computerPrice);
            Console.WriteLine("TELEVİZYON FİYATI: " + tvPrice);
            Console.WriteLine("TELEFON FİYATI: " + phonePrice);
            Console.WriteLine();
            Console.WriteLine();

            int computerCount, tvCount, phoneCount;

            Console.WriteLine("ALINAN BİLGİSAYAR SAYISINI GİRİNİZ: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("ALINAN TELEVİZYON SAYISINI GİRİNİZ: ");
            tvCount = int.Parse(Console.ReadLine());

            Console.WriteLine("ALINAN TELEFON SAYISINI GİRİNİZ: ");
            phoneCount = int.Parse(Console.ReadLine());

            int totalPrice = computerCount * computerPrice + tvCount * tvPrice + phoneCount * phonePrice;
            Console.WriteLine("TOPLAM TUTAR: " + totalPrice);*/

            /* Klavyeden Veri Girişleri Double
             * 
            double s1, s2, s3, ort;

            Console.WriteLine("---- SINAV NOTU HESAPLAMA -----");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1.SINAV NOTUNU GİRİNİZ");
            s1 = double.Parse(Console.ReadLine());

            Console.WriteLine("2.SINAV NOTUNU GİRİNİZ");
            s2 = double.Parse(Console.ReadLine());

            Console.WriteLine("3.SINAV NOTUNU GİRİNİZ");
            s3 = double.Parse(Console.ReadLine());

            ort = (s1 + s2 + s3) / 3;

            Console.WriteLine("NOT ORTALAMASI: " + ort);*/

            /* Klavyeden Veri Girişi Char
            char oylama;

            Console.WriteLine("OYUNUZ A' MI B'Mİ");
            Console.WriteLine();
            Console.WriteLine();
            oylama = char.Parse(Console.ReadLine());
            Console.WriteLine("Oyunuz: " + oylama);*/

            #endregion

            Console.Read();

        }
    }
}