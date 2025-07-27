using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Using ifadeler kütüphaneleri belirtir.
namespace _01Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");

            //Console.Write(" 2.Merhaba Dünya");

            //Console.WriteLine("*********************** Kategoriler *************************");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*********************** Kategoriler *************************");

            #endregion

            #region StringDegiskenler
            // String

            //Tanımlama : degiskenturu degiskenadi;

            //string name,surname;
            //name = "Ömer Sefa";
            //surname = "Çarıkçı";
            //Console.Write(name + " " + surname);

            //string customerName, customerSurname, customerPhone, Email, district, city;
            //customerName = "Kaan";
            //customerSurname = "Çınar";
            //customerPhone = "+90 555 048 1589";
            //Email = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("İletişim Bilgileri");
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + Email);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Adres Bilgileri");
            //Console.WriteLine(district + "/" + city);

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("-----------------------------");

            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "+90 551 564 2597";
            //Email = "ayse233@gmail.com";
            //district = "Refahiye";
            //city = "Erzincan";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("İletişim Bilgileri");
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + Email);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Adres Bilgileri");
            //Console.WriteLine(district + "/" + city);
            #endregion

            #region IntegerDegiskenler
            //Int - Tam sayı için kullanılır.

            //int number = 24;
            //Console.WriteLine(number);


            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("Restoran Menü Fiyatı");
            //Console.WriteLine();
            //Console.WriteLine(">> Hamburger Fiyatı: " + hamburgerPrice + "TL");
            //Console.WriteLine(">> Kola Fiyatı: " + cokePrice + "TL");
            //Console.WriteLine(">> Su Fiyatı: " + waterPrice + "TL");
            //Console.WriteLine(">> Kızartma Fiyatı: " + friesPrice + "TL");
            //Console.WriteLine(">> Pizza Fiyatı: " + pizzaPrice + "TL");
            //Console.WriteLine(">> Limonata Fiyatı: " + lemonadePrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalPrice = 0;
            //hamburgerCount = hamburgerPrice * 3;
            //cokeCount = cokePrice * 3;
            //waterCount = waterPrice * 3;
            //friesCount = friesPrice * 1;
            //pizzaCount = pizzaPrice * 0;
            //lemonadeCount = lemonadePrice * 0;
            //totalPrice = hamburgerCount + cokeCount + waterCount + friesCount + pizzaCount + lemonadeCount ;
            //Console.WriteLine(totalPrice + "TL");

            #endregion

            #region DoubleDegiskenler

            //double number;

            //number = 4.85; 
            //Console.WriteLine(number);


            //Console.WriteLine("Meyve ve Sebze Fiyat Listesi");
            //Console.WriteLine("----------------------------");
            //double applePrice, orangePrice, strawberryPrice;

            //applePrice = 14.85;
            //orangePrice = 20.85;
            //strawberryPrice = 45;

            //Console.WriteLine(">> Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine(">> Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine(">> Çilek Birim Fiyatı: " + strawberryPrice);
            //Console.WriteLine("----------------------------");

            //double appleGram,orangeGram,strawberryGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Elma Fiyatı: " + appleTotalPrice + " TL");
            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Portakal Fiyatı: " + orangeTotalPrice + " TL");
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Çilek Fiyatı: " + strawberryTotalPrice + " TL");

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Toplam Ödenecek Tutar");
            //double total = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice;
            //Console.WriteLine(total + " TL");



            #endregion

            #region CharDegiskenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenStringDegiskenGirisleri
            //Console.WriteLine("Hava Yolları Yolcu Girişi");
            //Console.WriteLine();
            //string customerName, customerSurname, customerdistrict, customercity, customerage;

            //Console.Write("Yolcu Adı: ");
            //customerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //customerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //customerdistrict = Console.ReadLine();

            //Console.Write("İl: ");
            //customercity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //customerage = Console.ReadLine();

            //Console.WriteLine("******************");
            //Console.WriteLine("Kişi Bilgileri");
            //Console.WriteLine(customerName + " " + customerSurname);
            //Console.WriteLine("******************");
            //Console.WriteLine("Adres Bilgileri");
            //Console.WriteLine(customerdistrict +"/"+ customercity);
            //Console.WriteLine("******************");
            //Console.WriteLine("Yaş Bilgisi");
            //Console.WriteLine(customerage);

            #endregion

            #region KlavyedenIntDegiskenGirisleriveDonusumleri

            //int shorPrice, computerPrice, chairPrice, tvPrice;
            //shorPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shorCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz-> ");
            //shorCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz-> ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz-> ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz-> ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shorCount * shorPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar ->> " + totalPrice + " TL");
            #endregion

            #region KlavyedenDoubleDegiskenGirisleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.sınav notunu giriniz -> ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz -> ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz -> ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama -> " + result);

            #endregion

            #region KlavyedenCharDegiskenGirisleri
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());


            Console.WriteLine("Seçtiğiniz cinsiyet-> " + gender);
            #endregion
            Console.Read();
        }
    }
}



/* 1- Yazdırma Komutları 

    Console.Write() ekrana yazdırma komutudur. 
    Console.Read(); Enter tuşuna basana kadar ekranı beklet demek istiyoruz.
    Console.WriteLine(); ekrana yazdırma komutudur ancak imleci alt satıra yazar.
 

 2- Değişkenler
     Tanımlama : degiskenturu degiskenadi
 
*/