using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables - string
            /*
             degisken_türü degisken_adı

            string -> "içinde yazılır"

             */

            string name = "Alp";
            string surname = "Kaya";
            Console.WriteLine(name);
            Console.WriteLine(surname);

            Console.WriteLine(name + " " + surname);



            #endregion

            #region Variables - int
            int sayi;
            sayi = 24;
            Console.WriteLine(sayi);

            int sayi1, sayi2, toplam;
            sayi1 = 15;
            sayi2 = 67;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            Console.WriteLine();
            #endregion

            #region Variables - char
            char chardegisken;
            chardegisken = 'a';
            Console.WriteLine(chardegisken);

            Console.WriteLine();

            char result; ;
            Console.WriteLine("Tek karakter seçimini yapınız: ");
            result = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçiminiz: " + result);
            Console.WriteLine();
            #endregion

            #region Variables - byte

            // Byte = 0 - 255 arası değer alır.
            byte bytedegisken;
            bytedegisken = 123;

            Console.WriteLine(bytedegisken);

            Console.WriteLine();
            #endregion

            #region Variables - sbyte
            sbyte sbytedegisken;
            // -128 ile +127
            sbytedegisken = 127;
            Console.WriteLine(sbytedegisken);

            Console.WriteLine();
            #endregion

            #region Variables - float
            float floatdegisken;
            // ondalıklı sayılar için kullanılır.

            floatdegisken = 127.45f;
            // float türünde değişken için "f" kullanmalıyız -> 342.34f
            Console.WriteLine(floatdegisken);

            Console.WriteLine();
            #endregion

            #region Variables - short
            short shorttdegisken;
            // -32768 - 32767
            shorttdegisken = 32767;
            Console.WriteLine(shorttdegisken);

            short se1, se2, top;
            se1 = 650;
            se2 = 3456;
            top = (short)(se1 + se2);
            Console.WriteLine(top);
            Console.WriteLine();
            #endregion

            #region Variables - ushort
            ushort ushorttdegisken;
            // 0 - 65535
            ushorttdegisken = 65535;
            Console.WriteLine(ushorttdegisken);

            
            Console.WriteLine();
            #endregion

            #region Variables - decimal
            decimal decimaltdegisken;
            decimaltdegisken = 20;
            Console.WriteLine(decimaltdegisken);


            Console.WriteLine();
            #endregion

            #region Variables - boolean
            bool booldegisken;
            booldegisken = true;
            Console.WriteLine(booldegisken);


            Console.WriteLine();
            #endregion

            #region Min-Max Value in Variables

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine();
            #endregion

            #region Arithmetic 4 Operation Application
            int s1, s2, top, carpim, bolum, fark;

            Console.WriteLine("Arithmetic 4 Operation Application");
            Console.WriteLine();
            s1 = 352;
            s2 = 65;

            top = s1 + s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            fark = s1 - s2;
            Console.WriteLine("İki sayının toplamı -> " + top);
            Console.WriteLine("İki sayının farkı -> " + fark);
            Console.WriteLine("İki sayının çarpımı -> " + carpim);
            Console.WriteLine("İki sayının bölümü -> " + bolum);
            Console.WriteLine();

            #endregion

            #region Student Exam Grading Application
            string ad, soyad, bolumum, dersim;
            int so1, so2, so3, avg;

            ad = "Ahmet";
            soyad = "Alpoğlu";
            bolumum = "Bilgisayar Programcılığı";
            dersim = "Algoritma ve Programlama";

            so1 = 56;
            so2 = 78;
            so3 = 90;
            avg = (so1 + so2 + so3) / 3;
            Console.WriteLine("** Student Exam Grading Application * *");
            Console.WriteLine();
            Console.WriteLine("Student: " + ad + " " + soyad);
            Console.WriteLine(bolumum + "/" + dersim);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine();


            #endregion

            #region Variables - double
            double number;

            number = 3.45;
            Console.WriteLine(number);
            #endregion

            #region Data Entry from the Keyboard
            
            //readline -> kullanıcıdan alınan metinsel veriyi hafızada tutar.
            //readkey -> klavyeden basılan tuşun bilgisini verir.
            //read -> girilen parametrenin sadece ilk karakterinin ascii karşılığını verir.

            string city;
            Console.Write("Lütfen yaşadığını şehri giriniz: ");
            city = Console.ReadLine();

            Console.WriteLine(city);


            #endregion

            #region Int Conversions
            int sayii;
            Console.WriteLine("Sayıyı giriniz: ");
            
            sayi = Convert.ToInt32(Console.ReadLine());

            //--------------------- or -----------------------\\

            sayi = int.Parse(Console.ReadLine());

            #endregion

            #region Double Conversions
            double doubledonusum;
            Console.WriteLine("Sayıyı giriniz: ");

            doubledonusum = Convert.ToDouble(Console.ReadLine());

            //--------------------- or -----------------------\\

            doubledonusum = double.Parse(Console.ReadLine());

            #endregion

            Console.Read();
        }
    }
}
