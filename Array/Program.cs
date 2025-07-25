using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Diziler ile Çalışma
            //degisken türü [] diziadi = new degiskenturu[elemansayisi]

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Orange";
            //colors[2] = "Blue";
            //colors[3] = "Black";

            //Console.WriteLine(colors[0]);
            //Console.WriteLine(colors[1]);  
            //Console.WriteLine(colors[2]);   
            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Ankara";
            //cities[2] = "Lyon";
            //cities[3] = "Üsküp";
            //cities[4] = "Kahire";

            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities[3]);
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2934;
            //numbers[2] = 35;
            //numbers[3] = 64;
            //numbers[4] = 52342;

            //Console.WriteLine(numbers[0]);

            //string[] cities = { "Prag", "Roma", "İstanbul" };
            //Console.WriteLine(cities[0]);
            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] name = { "Ömer", "Kaan", "Yusuf" };

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //int[] bolme = { 3, 34, 66, 699, 32, 18, 12, 6, 2, 1120 };
            //for (int i = 0; i < bolme.Length; i++)
            //{
            //    if (bolme[i] % 3 == 0)
            //    {
            //        Console.WriteLine(bolme[i]);
            //    }
            //}

            //int[] dizi = { 43, 665, 34, 6454, 346, 23, 675 };

            //int maximum = dizi[0];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] > maximum)
            //    {
            //        maximum = dizi[i];
            //    }
            //}
            //Console.WriteLine(maximum);

            // metotlar ile diziler 
            //string[] person = { "ali", "ahmet", "burak" };
            //Console.WriteLine(person.Length); -> dizinin uzunluğunu çıktı olarak verecektir.

            #endregion

            #region Dizi Metotları



            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz-> ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{ 
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 12, 13, 43, 531, 34 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            int[] numbers = {1,2,3,4,5,6,7,8,9};
            Console.WriteLine("Çift sayılar ->");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tek sayılar ->");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion
            Console.Read();
        }
    }

   
}
