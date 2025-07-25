using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach(1,2,3,4) 
            //1 -> degisken türü
            //2 -> deisken adi
            //3 -> In
            //4 -> Liste,koleksiyon,dizi

            //string[] cities = { "ankara", "adana" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 3242, 4324, 2, 4, 134, 124, 33 };

            //foreach (int i in numbers) { 
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 123, 21232, 43, 17, 65 };
            //int total = 0;
            //foreach (int i in numbers) { 
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> list = new List<int>()
            //{
            //    1,2,4,5,6,7,8,9
            //};
            //foreach (int i in list) { 
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion

            #region Örnek Sınav Sistemi

            Console.Write("---- Sınav Uygulaması ----");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            Console.Write("Sınıfınızda kaç öğrenci var? ->  ");
            int studentcount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            string[] studentName = new string[studentcount];

            double[] studentValue = new double[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz-> ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                   totalExamResult += value;
                }
                Console.WriteLine();
                studentValue[i] = totalExamResult / 3;
            }
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentValue[i]}");
                if (studentValue[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı.");

                }
                Console.WriteLine();
            }

            #endregion
            Console.Read();
        }
            
    }
}
