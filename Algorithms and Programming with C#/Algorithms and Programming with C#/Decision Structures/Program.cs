using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operators
            /*
            TR
            = : atama
            == : eşit mi?
            > : büyük
            < : küçük
            >= : büyük veya eşit
            <= : küçük veya eşit
            != : eşit değilse
            & : ve
            | : veya
            % : mod

            EN
            =  : assignment  
            == : equal to?  
            >  : greater than  
            <  : less than  
            >= : greater than or equal to  
            <= : less than or equal to  
            != : not equal to  
            &  : and  
            |  : or  
            %  : modulus  
             */
            #endregion

            #region Using If Else
            Console.WriteLine("Şehir giriniz: ");
            string city = Console.ReadLine();

            if (city == "İstanbul" & city == "istanbul")
            {
                Console.WriteLine("Welcome to İstanbul");
            }
            else
            {
                Console.WriteLine("Good Bye!");
            }
            Console.WriteLine();
            #endregion

            #region Student Exam-Grade Application
            int s1, s2, ort;
            Console.WriteLine("1.sınav notunu giriniz: ");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.sınav notunu giriniz: ");
            s2 = int.Parse(Console.ReadLine());

            ort = (s1 + s2) / 2;

            if (ort >= 80 & ort <= 100)
            {
                Console.WriteLine("AA");
            }
            else if (ort < 80 & ort >= 50)
            {
                Console.WriteLine("BB");
            }
            else
            {
                Console.WriteLine("CC");
            }
            Console.WriteLine();


            #endregion

            #region Decision Structures with the "If Not Equal" Operator

            char character;
            Console.WriteLine("Karakter giriniz: ");
            character = char.Parse(Console.ReadLine());

            if (character != 'a')
            {
                Console.WriteLine("A harfi girmediniz.");
            }
            else
            {
                Console.WriteLine("A harfi girdiniz.");

            }
            Console.WriteLine();
            #endregion

            #region Quiz Project 

            Console.WriteLine("Welcome to the Quiz Project");
            Console.WriteLine();
            Console.WriteLine("Country: Turkıye");


            int soru1 = 1;
            string cevap;
            if (soru1 == 1)
            {
                Console.WriteLine("1-) Başkent hangi ildir?");
                Console.WriteLine();
                Console.WriteLine("A- İstanbul");
                Console.WriteLine("B- Ankara");
                Console.WriteLine("C- İzmir");
                Console.WriteLine("D- Bursa");
                Console.WriteLine("E- Adana");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "B" || cevap == "b")
                {
                    Console.WriteLine("Tebrikler birinci soruyu doğru bildiniz, Toplam puan 1!");
                    soru1++;
                }
                else
                {
                    Console.WriteLine("Cevap yanlış! Lütfen tekrar deneyiniz.");
                }
            }
            if (soru1 == 2)
            {
                Console.WriteLine("2-) Cumhuriyet kaç yılında ilan edildi?");
                Console.WriteLine();
                Console.WriteLine("A- 1920");
                Console.WriteLine("B- 1921");
                Console.WriteLine("C- 1922");
                Console.WriteLine("D- 1923");
                Console.WriteLine("E- 1924");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("Tebrikler iki soruyu da doğru bildiniz, Toplam puan 2!");
                    
                }
                else
                {
                    Console.WriteLine("Cevap yanlış! Lütfen tekrar deneyiniz.");
                }

            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine();



            #endregion

            #region Switch Case Usage
            // TR - Dallanmanın fazla olduğu durumlarda kullanılan karar yapısı alt başlığıdır.
            // EN - The subheading of the decision structure used in cases where branching is excessive.
            /*
            switch (deger)
            {
                case 1: Console.Write("Welcome Adana");break;
            }


            */
            #endregion

            #region License Plate-City Application with Switch Case
            byte plaka;
            Console.WriteLine("Plakayı giriniz: ");
            plaka = byte.Parse(Console.ReadLine());

            switch (plaka)
            {
                case 1: Console.Write("Merhaba Adana");break;
                case 2: Console.Write("Merhaba Adıyaman"); break;
                case 3: Console.Write("Merhaba Afyonkarahisar"); break;
                case 4: Console.Write("Merhaba Ağrı"); break;
                case 5: Console.Write("Merhaba Amasya"); break;
                case 6: Console.Write("Merhaba Ankara"); break;
                case 7: Console.Write("Merhaba Antalya"); break;
                case 8: Console.Write("Merhaba Artvin"); break;
                case 9: Console.Write("Merhaba Aydın"); break;
                case 10: Console.Write("Merhaba Balıkesir"); break;
                case 11: Console.Write("Merhaba Bilecik"); break;
                case 12: Console.Write("Merhaba Bingöl"); break;
                case 13: Console.Write("Merhaba Bitlis"); break;
                case 14: Console.Write("Merhaba Bolu"); break;
                case 15: Console.Write("Merhaba Burdur"); break;
                case 16: Console.Write("Merhaba Bursa"); break;
                case 17: Console.Write("Merhaba Çanakkale"); break;
                case 18: Console.Write("Merhaba Çankırı"); break;
                case 19: Console.Write("Merhaba Çorum"); break;
                case 20: Console.Write("Merhaba Denizli"); break;
                case 21: Console.Write("Merhaba Diyarbakır"); break;
                case 22: Console.Write("Merhaba Edirne"); break;
                case 23: Console.Write("Merhaba Elazığ"); break;
                case 24: Console.Write("Merhaba Erzincan"); break;
                case 25: Console.Write("Merhaba Erzurum"); break;
                case 26: Console.Write("Merhaba Eskişehir"); break;
                case 27: Console.Write("Merhaba Gaziantep"); break;
                case 28: Console.Write("Merhaba Giresun"); break;
                case 29: Console.Write("Merhaba Gümüşhane"); break;
                case 30: Console.Write("Merhaba Hakkari"); break;
                case 31: Console.Write("Merhaba Hatay"); break;
                case 32: Console.Write("Merhaba Isparta"); break;
                case 33: Console.Write("Merhaba Mersin"); break;
                case 34: Console.Write("Merhaba İstanbul"); break;
                case 35: Console.Write("Merhaba İzmir"); break;
                case 36: Console.Write("Merhaba Kars"); break;
                case 37: Console.Write("Merhaba Kastamonu"); break;
                case 38: Console.Write("Merhaba Kayseri"); break;
                case 39: Console.Write("Merhaba Kırklareli"); break;
                case 40: Console.Write("Merhaba Kırşehir"); break;
                case 41: Console.Write("Merhaba Kocaeli"); break;
                case 42: Console.Write("Merhaba Konya"); break;
                case 43: Console.Write("Merhaba Kütahya"); break;
                case 44: Console.Write("Merhaba Malatya"); break;
                case 45: Console.Write("Merhaba Manisa"); break;
                case 46: Console.Write("Merhaba Kahramanmaraş"); break;
                case 47: Console.Write("Merhaba Mardin"); break;
                case 48: Console.Write("Merhaba Muğla"); break;
                case 49: Console.Write("Merhaba Muş"); break;
                case 50: Console.Write("Merhaba Nevşehir"); break;
                case 51: Console.Write("Merhaba Niğde"); break;
                case 52: Console.Write("Merhaba Ordu"); break;
                case 53: Console.Write("Merhaba Rize"); break;
                case 54: Console.Write("Merhaba Sakarya"); break;
                case 55: Console.Write("Merhaba Samsun"); break;
                case 56: Console.Write("Merhaba Siirt"); break;
                case 57: Console.Write("Merhaba Sinop"); break;
                case 58: Console.Write("Merhaba Sivas"); break;
                case 59: Console.Write("Merhaba Tekirdağ"); break;
                case 60: Console.Write("Merhaba Tokat"); break;
                case 61: Console.Write("Merhaba Trabzon"); break;
                case 62: Console.Write("Merhaba Tunceli"); break;
                case 63: Console.Write("Merhaba Şanlıurfa"); break;
                case 64: Console.Write("Merhaba Uşak"); break;
                case 65: Console.Write("Merhaba Van"); break;
                case 66: Console.Write("Merhaba Yozgat"); break;
                case 67: Console.Write("Merhaba Zonguldak"); break;
                case 68: Console.Write("Merhaba Aksaray"); break;
                case 69: Console.Write("Merhaba Bayburt"); break;
                case 70: Console.Write("Merhaba Karaman"); break;
                case 71: Console.Write("Merhaba Kırıkkale"); break;
                case 72: Console.Write("Merhaba Batman"); break;
                case 73: Console.Write("Merhaba Şırnak"); break;
                case 74: Console.Write("Merhaba Bartın"); break;
                case 75: Console.Write("Merhaba Ardahan"); break;
                case 76: Console.Write("Merhaba Iğdır"); break;
                case 77: Console.Write("Merhaba Yalova"); break;
                case 78: Console.Write("Merhaba Karabük"); break;
                case 79: Console.Write("Merhaba Kilis"); break;
                case 80: Console.Write("Merhaba Osmaniye"); break;
                case 81: Console.Write("Merhaba Düzce"); break;
                default: Console.Write("Geçersiz seçim"); break;
            }




            #endregion
            Console.Read();
        }
    }
}
