using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03KampDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü



            // for (başlangıç; bitiş; artış/azalış)


            ////Ekrana 5 kere merhaba yazdıran program yapalım.
            //int x;
            //for (x = 1; x <= 5; x++)
            //{
            //    Console.WriteLine("Merhaba");
            //}
            ////Ekrana 0'dan başlayıp 50'ye kadar üçer üçer arttırarak program yapalım.
            //for (int y = 3; y <= 50; y += 3)
            //{
            //    Console.WriteLine(y);
            //}
            //// Çift sayıları yazdıran program yapalım.
            //for (int i = 1; i <= 10; i++)
            //    {
            //        i++;  //-> 2 4 6 8 10 olarak yazdırır.  Eğer olmazsa 1'den 10'a kadar yazdırır.
            //        Console.WriteLine(i);
            //    }
            ////Ekrana kullanıcıdan aldığımız mesajı 10 kere yazdıralım.
            //string mesaj;

            //Console.Write("Mesaj giriniz: ");
            //mesaj = Console.ReadLine();
            //for (int z = 1; z <=10;z++)
            //{
            //    Console.WriteLine(mesaj);
            //}

            ////Kullanıcıdan kaç kere ekrana mesaj yazdırılmasını alalım o sayıya göre ekrana yazdıralım.

            //Console.Write("Kaç kere bu mesaj verilsin -> ");
            //int adet = int.Parse(Console.ReadLine());

            //for (int e = 1; e <= adet; e++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++) 
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;

            //}
            //Console.WriteLine(totalvalue);


            ////1 ile 50 arasında 7'ye tam bölünen sayılarının kaç adet olduğunu bulalım.

            //int number = 0;
            //for (int i = 1; i <= 50; i++) 
            //{
            //    if (i % 7 == 0) 
            //    {
            //        number++;
            //    }
            //}
            //Console.WriteLine(number);

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++) 
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + " .Saat sonunda: " + bakteri);
            //}

            #endregion

            #region While Döngüsü

            //Şartlar sağlandığı sürece çalışır.

            //while(şart){ işlemler }

            //int i = 1;
            //while (i <= 10)
            //{
            //    i++;
            //    Console.WriteLine("Merhaba while döngüsü");
            //}


            //1 ile 10 arasında 3'e tam bölünen sayıları yazdıralım.
            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;

            //}

            #endregion

            #region Örnek Uygulama

            ////Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan program yazalım.

            //Console.Write("Sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int bir, iki, uc,sum;

            //bir = number % 10;
            //iki = (number % 100) / 10;
            //uc = number / 100;
            //Console.WriteLine(uc);
            //Console.WriteLine(iki);
            //Console.WriteLine(bir);

            //sum = bir + iki + uc;
            //Console.WriteLine("Basamakların toplamı -> " + sum);

            #endregion

            Console.Read();
        }
    }
}
