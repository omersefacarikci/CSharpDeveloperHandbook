using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * TR
            Dizilerde her eleman data, her elemanın konumu ise index olarak adlandırılır.
            Dizilerde sayma işlemi 0'dan başlar.
            Diziler tam bellekte tutulurlar.
            Dizi tanımlama işlemleri [] sembolü ile yapılır.
            Dizi tanımlamalarında elemanlar {} içinde yazılır.
            Dizi tanımlamalarında ilgili dizinin mutlaka bir değişken türü bulunur.

             * EN
            In arrays, each element is called data, and the position of each element is called the index.
            Counting in arrays starts from 0.
            Arrays are stored entirely in memory.
            Array declarations are made using the [] symbol.
            In array declarations, the elements are written inside {}.
            In array declarations, the array must always have a data type.
             */

            #region String Type Array Examples

            string[] sehirler = { "Adana", "Ankara", "Ardahan", "Amasya" };
            Console.WriteLine("Dizinin 0.İndexi -> " + sehirler[0]);
            Console.WriteLine("Dizinin 1.İndexi -> " + sehirler[1]);
            Console.WriteLine("Dizinin 2.İndexi -> " + sehirler[2]);
            Console.WriteLine("Dizinin 3.İndexi -> " + sehirler[3]);
            #endregion

            #region Int Type Array Examples
            int[] numbers = { 1, 2, 234, 242, 342, 634, };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++");
            #endregion

            #region Using Decision Structure with Arrays

            int[] tam = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            for (int i = 0; i < tam.Length; i++) 
            {
                if (tam[i] % 20 == 0)
                {
                    Console.WriteLine(tam[i]);
                }
                
            }
            Console.WriteLine("----------------------");

            #endregion

            #region Length Command
            string[] kisiler = { "Ali", "Mehmet" };
            Console.WriteLine(kisiler.Length);
            Console.WriteLine("----------------------");

            #endregion

            #region Array Methods - Sort

            int[] sayi = { 10, 20, 30, 40,65,12,8 };
            Array.Sort(sayi); // ---> Küçükten büyüğe doğru sıralama yapılır.
            
            for(int i = 0;i< sayi.Length;i++)
            {
                Console.WriteLine(sayi[i]);
            }
            Console.WriteLine("----------------------");

            #endregion

            #region Array Methods - Reverse
            string[] sh = { "Ankara","İstanbul","Zonguldak"};
            Array.Reverse(sh); // ---> Diziye tersine çevirir.
            for (int j = 0; j < sh.Length; j++)
            {
                Console.WriteLine(sh[j]);
            }
            Console.WriteLine("----------------------");
            #endregion

            #region Array Methods - Index Of
            string[] io = { "Ankara", "İstanbul", "Zonguldak" };
            int indexNo = Array.IndexOf(io,"Zonguldak"); // ---> Diziye tersine çevirir.
            Console.WriteLine(indexNo);
            
            Console.WriteLine("----------------------");
            #endregion

            #region Array Methods - Min/Max 
            int[] no = { 56,123,52,754,12};
            Console.WriteLine(no.Min());
            Console.WriteLine(no.Max());

            Console.WriteLine("----------------------");
            #endregion

            #region Foreach Loop

            string[] city = { "Ankara", "Adana", "Bursa", "Erzincan" };
            foreach(string i in city)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");

            #endregion

            #region Foreach Loop and Arithmetic Operations

            int[] num = {56,13,42,63,732,832,334,76};
            int toplam = 0;
            foreach (int i in num)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
            Console.WriteLine("-----------------------");

            #endregion

            #region Entering Values into an Array from the Keyboard

            string[] citys = new string[5];
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine("Şehir ismi giriniz: ");
                citys[i] = Console.ReadLine();

                Console.WriteLine("-------------");

                
            }
            for (int j = 0;j < 5; j++)
            {
                Console.WriteLine(sehirler[j]);
            }
            
            #endregion
            Console.Read();
        }
    }
}
