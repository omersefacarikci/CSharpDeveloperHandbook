using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Change Console Background Color

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear(); // Bu ise formun arka plan rengini yeşil yapar.
            Console.ForegroundColor = ConsoleColor.Blue; // Bu ise yazının rengini mavi yapar.
            Console.WriteLine("Yazının arka planı yeşil olacaktır.");

            #endregion

            #region 2D Arrays
            int[,] sayilar = new int[2, 2]; //2 satır 2 sütun
            sayilar[0, 0] = 10; //0.satır 0.sütundaki değer 10 olsun.
            sayilar[0,1] = 20;
            sayilar[1, 0] = 30;
            sayilar[1, 1] = 40;
            Console.WriteLine(sayilar[0,1]);

            #endregion

            #region Creating Rectangle with Stars
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*****");
            }
            #endregion

            #region Creating a Right Triangle with Stars
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; i++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region Error Management
            /*
            try{
            }
            catch {
            Hata
            }
            finally{
            }
             */

            try
            {
                int sayi1, sayi2, sonuc;

                Console.Write("Sayı 1: ");
                sayi1 = int.Parse(Console.ReadLine());

                Console.Write("Sayı 2: ");
                sayi2 = int.Parse(Console.ReadLine());

                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }



            #endregion

            #region Special Case Formats
            // Invalid cast exception -> Tür dönüştürme işlemlerinde tanımlanan
            // değişkenlere göre farklı bir türde dönüşüm yapılmaya çalışılması durumunda
            // karşımıza çıkan hata mesajıdır.

            // Index out of range exception -> Dizide bulunmayan değerler ile karşılaşınca oluşan hata mesajıdır.

            // Divided by zero -> Sıfıra bölme işlemi yapılmak istendiği zaman oluşan hata mesajıdır.

            // Format exception -> Sayısal bir alana sayısal olmayan bir değer girilmesi durumunda oluşan hata mesajıdır.

            // Over Flow exception -> Bir değişkenin aralıklarının dışına çıkılması durumunda karşılaşılan hata mesajıdır.

            // Argument Null exception -> Aritmetin bir alanın boş bırakılması durumunda karşımıza çıkan hata mesajıdır.

            // Arithmetic exception -> Matematiksel hatalarda oluşan hata mesajıdır.

            try
            {
                int sayi1, sayi2, sonuc;

                Console.Write("Sayı 1: ");
                sayi1 = int.Parse(Console.ReadLine());

                Console.Write("Sayı 2: ");
                sayi2 = int.Parse(Console.ReadLine());

                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sadece sayısal değer giriniz.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lütfen aralığın dışında değer girmeyiniz.");
            }
            finally
            {
                // Catcha da hata olsa bile buradaki kod çalışacak.
                Console.WriteLine("Finally aktif!");
            }

            #endregion
            Console.Read();
        }
    }
}
