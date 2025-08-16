using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02KampKararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if,else,else if kullanımı

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();


            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifreniz doğru. Giriş için yönlendiriliyorsunuz.");
            //}

            //else if (password != "abcd")
            //{
            //    Console.WriteLine("Lütfen şifrenizi giriniz!");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "İstanbul" && country == "Türkiye")
            //{
            //    Console.WriteLine("Girdiğiniz ülke ve şehir bilgisi doğru.");
            //}
            //else if (capital != "İstanbul" && country != "Türkiye")
            //{
            //    Console.WriteLine("Girdiğiniz ülke ve şehir bilgisi yanlış.");

            //}

            //int sayi;
            //Console.Write("Sayıyı giriniz-> ");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış! Lütfen tekrar deneyiniz.");
            //}
            // & -> ve | -> veya


            //Sınav notlarına göre ortalama hesaplama ve sonuç çıkarma

            //int sinav1, sinav2, sinav3;
            //double ortalama;
            //string result;


            //Console.Write("1.sınavı giriniz: ");
            //sinav1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sınavı giriniz: ");
            //sinav2 = int.Parse(Console.ReadLine());
            //Console.Write("3.sınavı giriniz: ");
            //sinav3 = int.Parse(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3) / 3;
            //Console.WriteLine("Ortalama -> " + ortalama);

            //if (ortalama > 0 && ortalama <= 50)
            //{
            //    result = "DD";
            //}
            //else if (ortalama > 50 && ortalama <= 70)
            //{
            //    result = "CC";
            //}
            //else if (ortalama > 70 && ortalama <= 85)
            //{
            //    result = "BB";
            //}
            //else if (ortalama > 85 && ortalama <= 100)
            //{
            //    result = "AA";
            //}
            //else
            //{
            //    result = "Girilen bilgiler hatalı!\n Lütfen kontrol ederek tekrar deneyiniz.";
            //}
            //    Console.WriteLine("Harf Notu -> " + result);

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int sonuc = number % 5;
            ////kalanını yazdıracaktır.
            //Console.WriteLine(sonuc);

            //Console.Write("Lütfen 1.sayıyı giriniz -> ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz -> ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan " + result + "'dır.");


            //Bir sayının tek mi çift mi olduğunu bulan program yazalım.

            //Console.Write("Sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write(number + " sayısı çifttir.");
            //}
            //else
            //{
            //    Console.Write(number + " sayısı tektir.");
            //}
            #endregion

            #region Char değişkenleri ile Karar yapıları kullanımı

            //Klavyeden girilen harfe göre takım belirleme programı yazalım.

            //char team;

            //Console.Write("Harf giriniz -> ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Takım Galatasaraydır.");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Takım Fenerbahçedir.");
            //}
            //else
            //{
            //    Console.Write("Lütfen geçerli bir harf giriniz!");
            //}
            #endregion

            #region Örnek Restoran Uygulaması


            //Console.WriteLine("***** C# Kamp Restoran Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuıtem;
            //Console.Write("Lütfen menü seçiniz -> ");
            //menuıtem = Console.ReadLine();

            //if (menuıtem == "1")
            //{
            //    Console.Write("Restoran Uygulaması ---- Ana Yemekler");
            //    Console.WriteLine();
            //    Console.WriteLine("Kuru Fasulye");
            //    Console.WriteLine("Balık ekmek");
            //    Console.WriteLine("Kavurma");
            //    Console.WriteLine("Karnı yarık");
            //}
            //else if (menuıtem == "2")
            //{
            //    Console.Write("Restoran Uygulaması ---- Çorbalar");
            //    Console.WriteLine();
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Ayran Çorbası");
            //    Console.WriteLine("Kelle Paça Çorbası");
            //    Console.WriteLine("Etli Çorba");
            //}
            //else if (menuıtem == "3")
            //{
            //    Console.Write("Restoran Uygulaması ---- Tatlılar");
            //    Console.WriteLine();
            //    Console.WriteLine("Kazandibi Tatlısı");
            //    Console.WriteLine("Sütlaç Tatlısı");
            //    Console.WriteLine("Kadayıf Tatlısı");
            //    Console.WriteLine("Baklava");
            //    Console.WriteLine("Soğuk Baklava");
            //}
            //else if (menuıtem == "4")
            //{
            //    Console.Write("Restoran Uygulaması ---- İçecekler");
            //    Console.WriteLine();
            //    Console.WriteLine("Cola Turka");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Su");
            //    Console.WriteLine("Limonata");
            //    Console.WriteLine("Frozen");
            //    Console.WriteLine("Kahve");
            //    Console.WriteLine("Çay");

            //}
            //else
            //{
            //    Console.Write(menuıtem + " böyle bir menü bulunmamaktadır.");
            //}
            #endregion

            #region Switch Case kullanımı

            //Console.Write("Lütfen ay numarası giriniz -> ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi!");break;
            //}

            #endregion

            #region Hesap Makinesi (Switch-Case ile)

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapılacak işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+': result = number1 + number2;
            //        Console.Write("Sonuç -> " + result); break;

            //    case '-': result = number1 - number2;
            //        Console.Write("Sonuç -> " + result); break;

            //    case '*': result = number1 * number2;
            //        Console.Write("Sonuç -> " + result); break;

            //    case '/': result = number1 / number2;
            //        Console.Write("Sonuç -> " + result); break;

            //    default: Console.Write("Lütfen geçerli bir işlem giriniz."); break;
            //}
            Console.Read();
            #endregion

        }
    }
}
