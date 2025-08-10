using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hello World

            Console.Write("Hello World");
            Console.WriteLine();
            #endregion

            #region Application
            Console.WriteLine("----- Kimlik Uygulaması -----");
            Console.WriteLine();
            Console.WriteLine("Kaan");
            Console.WriteLine("Karahan");
            Console.WriteLine("İstanbul Teknik Üniversitesi");
            Console.WriteLine("İstanbul");
            Console.WriteLine();
            Console.WriteLine("------------------------------");

            #endregion 

            Console.Read();
        }
    }
}
