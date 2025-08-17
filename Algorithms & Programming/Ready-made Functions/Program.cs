using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ready_made_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mathematical Functions
            /*
             abs: Mutlak
            Ceilling: Üst tabana yuvarlama
            floor: alt tabana yuvarlama
            sqrt: karekök
            pow: üs alma
            pi: pi sayısı
             */

            double sayi;
            Console.Write("Sayıyı giriniz: ");
            sayi = double.Parse(Console.ReadLine());

            Console.Write("Mutlak değer: " + Math.Abs(sayi));
            Console.Write("Üst tabana yuvarlama: " + Math.Ceiling(sayi));
            Console.Write("Alt tabana yuvarlama: " + Math.Floor(sayi));
            Console.Write("Karekök: " + Math.Sqrt(sayi));
            Console.Write("Üs: " + Math.Pow(sayi,2));
            Console.Write("Pi sayısı: " + Math.PI);


            #endregion

            #region String Functions
            /*
             * Concat: Birleştirme
             * length = uzunluk
             * indexof: metin arama
             * starwith: ilgili parametre ile mi başlıyor?
             * trim: boşlukları kaldırma
             * toupper: büyük harf
             * tolower: küçük harf
             * remover: siler
             * replace: değiştirme
             * substring: istenilen karakterden itibaren işlem yapar.           
             */
            string metin,metin2;
            Console.Write("Metni giriniz: ");
            metin = Console.ReadLine();

            Console.Write("Metni giriniz: ");
            metin2 = Console.ReadLine();

            Console.Write("Birleştirme " + string.Concat(metin,metin2));
            Console.Write("Uzunluk " + metin2.Length);
            Console.Write("Metin arama " + metin.IndexOf("Aydın"));
            Console.Write("İle mi başlıyor? " + metin2.StartsWith("aydın"));
            Console.Write("       Boşluk kaldırma " + metin2.Trim());
            Console.Write("Büyük harf " + metin.ToUpper());
            Console.Write("Küçük harf " + metin.ToLower());
            Console.Write("Silme " + metin.Remove(4));
            Console.Write("Replace ile değiştirme " + metin.Replace("merhaba", "welcome"));
            Console.Write("Substring " + metin.Substring(4));

            #endregion

            #region Date Time Functions

            Console.Write("Bugünün gün bilgisi: " + DateTime.Now.Day);
            Console.Write("Bugünün ay bilgisi: " + DateTime.Now.Month);
            Console.Write("Bugünün yıl bilgisi: " + DateTime.Now.Year);

            Console.Write("Bugünün saat bilgisi: " + DateTime.Now.Hour);
            Console.Write("Bugünün dakika bilgisi: " + DateTime.Now.Minute);
            Console.Write("Bugünün saniye bilgisi: " + DateTime.Now.Second);

            Console.Write("Bugünün kısa (01.01.2025) tarih bilgisi: " + DateTime.Now.ToShortDateString());
            Console.Write("Bugünün uzun (08 Temmuz 2020 çarşamba) tarih bilgisi: " + DateTime.Now.ToLongDateString());

            //Time span iki tarih arasındaki farkı hesaplıyor.

            TimeSpan zaman;
            int gunFarki;
            DateTime tarih1, tarih2;
            tarih1 = DateTime.Parse("01.01.2020");
            tarih2 = DateTime.Parse("15.01.2020");
            zaman = tarih1 - tarih2;

            gunFarki = zaman.Days;
            Console.Write("Fark: " + gunFarki);

            #endregion

            Console.Read();




        }
    }
}
