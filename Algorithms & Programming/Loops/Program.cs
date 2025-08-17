using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example of For Loop Usage
            /*
             for (başlangıç;bitiş;artış/azalış)
            {

            }           
             */

            int i;
            for (i = 1; i<= 10; i++)
            {
                Console.WriteLine(i + " " + "Hello World");
            }

            Console.WriteLine("--------------------------");

            for (int j = 1; j<=20;j+=2)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("--------------------------");

            for (int k = 1; k <= 100; k++)
            {
                Console.WriteLine(k+ " Merhaba İstanbul");
            }

            Console.WriteLine("--------------------------");

            #endregion

            #region Use of Decision Structure in the Cycle

            int sayim;
            Console.WriteLine("Sayıyı giriniz: ");
            sayim = int.Parse(Console.ReadLine());

            if (sayim % 2 == 0)
            {
                Console.WriteLine("Sayı çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine("Sayı tek bir sayıdır.");
            }

            Console.WriteLine("---------------------------");

            for (int c = 1; c <= 20; c++)
            {
                if (c % 2 != 0)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("Sayı çift sayıdır.");
                }
            }
            Console.WriteLine("---------------------------");

            #endregion

            #region Algorithmic Question: Finding Positive Integer Divisors of the Entered Number
            
            int sayimim;

            Console.Write("Sayı giriniz: ");

            sayimim = int.Parse(Console.ReadLine());

            for (int h = 1; h <= sayimim; h++)
            {
                if (sayimim % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-----------------------------");


            #endregion

            #region Algorithmic Interview Question

            int bakteri = 1;

            for (int l = 1; l <= 24;l++)
            {
                bakteri = bakteri * 2;
            }
            Console.WriteLine(bakteri);

            #endregion

            #region Operations with Consecutive Numbers

            int faktoriyel = 1;
            for ( int o = 5; o>=1;o--)
            {
                faktoriyel = faktoriyel * o;
                
            }
            Console.WriteLine(faktoriyel);
            #endregion

            #region While Loop

            /*
             * while(şart)
             {
                işlemler
             }
             */

            int sayac = 1;

            while (sayac<=10) // sayac değişkeni 10dan küçük veya 10a eşit olduğu süreçte bu işlemler çalışsın.
            {
                Console.WriteLine("Merhaba Dünya");
                sayac++;
            }

            #endregion

            #region Do While Loop
            /*
             
            Do 
            {
            işlemler
            }
            while(şart);
             */
            int sayi2;
            sayi2 = 1;
            do
            {
                Console.WriteLine(sayi2);
                sayi2++;
                
            }
            while (sayi2 <= 10); //sayı 10 olduğu sürece çalışsın bu işlem

            #endregion
            Console.Read();

        }
    }
}
