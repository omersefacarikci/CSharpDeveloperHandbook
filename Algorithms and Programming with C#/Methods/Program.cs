using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Methods
{
    internal class Program
    {
        #region Introduction to Methods

        // Belli bir işlemi gerçekleştiren ve geliştiriciyi kod tekrarından kurtaran yapılardır.
        // They are structures that perform a specific operation and save the developer from code repetition.
        // ()
        /* 
        TR
            Erişim belirleyiciler, kodun güvenliğini ve düzenini sağlamak için kullanılır. Hangi kod parçalarının hangi sınıflardan erişilebileceğini kontrol eder.
            C#’daki temel erişim belirleyiciler:
            public → Her yerden erişilebilir.
            private → Sadece tanımlandığı sınıf içinde erişilebilir.
            protected → Sadece tanımlandığı sınıf ve ondan türeyen alt sınıflar tarafından erişilebilir.
            internal → Sadece aynı proje (assembly) içinde erişilebilir
            protected internal → Aynı proje içindeki tüm kod ve başka projelerden türeyen sınıflar erişebilir.
            private protected → Sadece aynı proje içinde ve tanımlandığı sınıftan türeyen sınıflar erişebilir.

        EN
            Access modifiers are keywords in C# that determine where and how a class, method, variable, or other member can be accessed.
            They are used to enforce encapsulation, protect data, and maintain a clean code structure.
            Main access modifiers in C#:
            public → Accessible from anywhere.
            private → Accessible only within the same class.
            protected → Accessible within the same class and derived classes.
            internal → Accessible only within the same assembly.
            protected internal → Accessible within the same assembly and from derived classes in other assemblies.
            private protected → Accessible only within the same assembly and by derived classes of the containing class.

         C#’da static anahtar kelimesi, bir üyenin veya sınıfın nesne oluşturmadan doğrudan erişilebilmesini sağlar.
         Yani, static olan üyeler bellekte tek bir kopya olarak tutulur ve tüm program boyunca paylaşılır.

         In C#, the static keyword makes a member or class accessible without creating an instance.
         Static members are stored as a single copy in memory and are shared across the entire program.
         */
        #endregion

        #region Examples of Methods That Do Not Return Values

        public static void yazdir()
        {
            Console.WriteLine("Bu bir metottur.");
        }     

        public static void toplama()
        {
            int sayi1 = 24;
            int sayi2 = 50;
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        public static void space()
        {
            Console.WriteLine("*********************");
        }
        #endregion

        #region Using Parameters in Methods That Do Not Return a Value
        public static void metinYaz(string p)
        {
            Console.Write("************************");
            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();
        }
        #endregion

        #region Getting Parameters from the Keyboard in Methods That Do Not Return a Value
        public static void para(string name)
        {

            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine();
        }


        #endregion

        #region Methods That Return Values

        public static int toplamam()
        {
            int x, y, toplam;

            x = 23;
            y = 3534;
            toplam = x + y;
            return toplam;
        }


        #endregion

        #region Parameterized Method Returning a Value

        public static int islem(int a, int b)
        {
            int sonuc;
            sonuc = a + b;
            return sonuc;
        }

        #endregion

        #region Method Overloading

        public static int average(int sinav1, int sinav2)
        {
            int hesap = (sinav1 + sinav2) / 2;
            return hesap;
        }

        public static int average(int sinav1, int sinav2, int sinav3)
        {
            int hesap = (sinav1 + sinav2 + sinav3) / 3;
            return hesap;
        }

        #endregion
        static void Main(string[] args)
        {
           

            yazdir();

            space();

            toplama();

            metinYaz("Hello Camp");

            Console.WriteLine("Adınızı giriniz: ");
            string ad = Console.ReadLine();
            para(ad);

            Console.Write(toplamam());

            //Console.WriteLine("Toplam: " + islem(10,56));
            int sayi1, sayi2;
            Console.WriteLine("1.sayıyı giriniz: ") ;
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sonuç: " + islem(sayi1, sayi2));

            //1. public
            //Console.WriteLine("ortalama: " + average(3243,353));

            //2. public
            Console.WriteLine(average(435,353,33)); // --> Bu overloading anlamına geliyor.
            //Aynı isimde 2 tane metot var. İlk başta hata veriyor. Hata da "senin 2 tane aynı
            //isimde metodun var sıralamanı ona göre yap" diyor. 3 tane parametre girersek 2.metodu çalıştırır. 2 tane girersek 1.metodu çalıştırır."


            Console.Read();
        }
       
    }
}
