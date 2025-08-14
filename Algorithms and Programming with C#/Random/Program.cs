using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Introduction to Random
            /*
             random nesneAdi = new Random();
                değer aralığı = next
             */

            int sayi;
            Random random = new Random();
            sayi = random.Next(0,51); // --> 0dan 51 değer aralığında (51 hariç) sayı oluştur.
            #endregion

            #region Using Arrays with the Random Class
            //int sayi1,sayi2;
            //Random r = new Random();
            //sayi1 = r.Next(0, 51);
            //sayi2 = r.Next(0, 51);

            //Console.WriteLine(sayi1 + " " + sayi2);

            Random rn = new Random();
            int sehir;
            string[] sehirler = { "Adana", "Ankara", "Bursa" };
            
            sehir = rn.Next(0,sehirler.Length);
            Console.WriteLine(sehirler[sehir]);


            #endregion

            #region Creating Captcha
            int d1, d2,d3,d4;
            Random random1 = new Random();
            d1 = random1.Next(0, 10); //0 ile 9 arası alacak.
            d2 = random1.Next(0, 10);
            d3 = random1.Next(0, 10);
            d4 = random1.Next(0, 10);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            string[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D" ,"e","E"};
            Console.Write(d1 + karakterler[2] + d3 + karakterler[d4]);

            #endregion

            Console.Read();
        }
    }
}
