using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            // geriye değer döndürmeyen metotlar - void

            //void customerList()
            //{
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Ömer KAYA");
            //}
            //customerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();



            #endregion

            #region Geriye değer döndürmeyen parametreli metotlar

            //void yazdırmametot(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //yazdırmametot("Ömer YILMAZ");


            //void customercart(string name , string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //customercart("Ömer Sefa", "Çarıkçı");


            //void sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //sum(4,6,2);



            #endregion

            #region Geriye değer döndüren metotlar

            //string custoomername()
            //{
            //    return "Buse YILDIZ";
            //}
            //custoomername();

            //string studentCard()
            //{
            //    string name = "Ömer";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye değer döndüren parametreli metotlar

            //string CountryCard(string name,string capital,string flagcolor)
            //{
            //    string cardInfo = name + " " + capital + " " + flagcolor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}
            //Console.WriteLine(Sum(75,45));



            #endregion

            #region Örnek Uygulama

            string exaResult(string student,int exam1,int exam2,int exam3) 
            { 
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50) 
                {
                    return student + " " + "Öğrenci sınavı geçti" + " Ortalama: " + result;
                }
                else
                {
                    return student + " " + "Öğrenci başarısız oldu" + " Ortalama: " + result;
                }

            }
            Console.WriteLine(exaResult("Ali", 34, 54, 34));
            #endregion

            Console.Read();
        }
    }
}
