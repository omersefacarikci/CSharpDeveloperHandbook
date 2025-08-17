using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat=0;
            string secim;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-- Türkçe Kitaplar        --  Yabancı Kitaplar --");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-- 1-Çalıkuşu: Reşat Nuri  --  2-Tuna Kılavuzu:  Jules Verne --");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("İşlemler Menüsü");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlem numarasını giriniz: ");

            char islem;
            islem = Char.Parse(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen kitap numarası giriniz: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1":Console.Write("Çalıkuşu -> 12TL");break;
                    case "2": Console.Write("Tuna Kılavuzu -> 20TL");break;
                    default: Console.Write("Bu numaraya ait kitap bulunmamaktadır.");break;
                }

            }
            if (islem == '2')
            {
                Console.WriteLine("------------ Kayıt Ol -----------");
                string ad, soyad, universite;
                Console.Write("Adınızı giriniz: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınızı giriniz: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversite bilgisini giriniz: ");
                universite = Console.ReadLine();

                string dosya = ("C:\\adres\\kullanici.txt");
                StreamWriter streamWriter = new StreamWriter(dosya);
                streamWriter.WriteLine(ad + " " + soyad);
                streamWriter.WriteLine(universite);
                streamWriter.Close();

            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("Bugünün kitabı: Tuna Kılavuzu");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                FileStream fs = new FileStream("adres",FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            if (islem == '5')
            {
                for(int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası: ");
                    secim = Console.ReadLine();
                    if(secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else if (secim == "2")
                    {
                        toplamfiyat = toplamfiyat + 14;
                    }
                    Console.WriteLine("Toplam tutar: " + toplamfiyat);

                }
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin=0;
                Random rnd = new Random();
                int sayi = rnd.Next(1,100);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if(tahmin > sayi)
                    {
                        Console.Write("Daha küçük");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha büyük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Sayıyı doğru tahmin ettiniz.");
                    }

                }
            }
            Console.Read();

        }
    }
}
