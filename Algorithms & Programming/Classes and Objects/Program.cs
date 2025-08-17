using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction to Classes and Object
            /*
             class -------------- Objects
               |                     |
               |                     |
             Araba           Marka1  Marka2  Marka3


            Nesne Türetme İşlemi
            sinifadi nesneadi = new sinifadi();
             
             */
            #endregion

            #region Car Class 

            Car car = new Car();
            car.marka = "Ford";
            car.model = "Connect";
            car.hiz = 180;
            car.motor = 1.8;
            car.renk = "Siyah";
            Console.WriteLine(car.marka + " " + car.model + " " + car.motor + " " + car.hiz + " " + car.renk);

            #endregion

            #region Customer Class

            Customer customer = new Customer();
            customer.id = 1;
            customer.Name = "Alp"; // Kapsülleme işlemi başarılı.
            customer.surname = "Karahan";
            customer.city = "İstanbul";


            Console.WriteLine(customer.id + " " + customer.Name + " " + customer.surname + " " + customer.city);
            #endregion

            #region Student Class - Entering Values to Attributes in a Class from the Keyboard

            Student student = new Student();
            Console.WriteLine("ID Değeri giriniz: ");
            student.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ad giriniz: ");
            student.name = Console.ReadLine();

            Console.WriteLine("Soyad giriniz: ");
            student.surname = Console.ReadLine();

            Console.WriteLine("Yaş giriniz: ");
            student.age = int.Parse(Console.ReadLine());

            Console.WriteLine(student.id + " " + student.name + " " + student.surname + " " + student.age);

            Console.WriteLine("***********************");
            Console.WriteLine("-----------------------");
            #endregion

            #region Birds and Papagan Class - Inheritance

            Papagan papagan = new Papagan();
            papagan.tur = "Papağan";
            papagan.hiz = 50;
            papagan.isim = "Sultan";
            papagan.renk = "Sarı";
            papagan.agirlik = 1650;

            Console.WriteLine(papagan.tur + " " + papagan.isim + " " + papagan.renk + " " + papagan.agirlik);

            #endregion

            #region Polymorphism

            papagan.sescikar();
            Console.WriteLine(papagan.sescikar());

            Console.WriteLine();
            Console.WriteLine();

            Karga karga = new Karga();
            karga.tur = "Karga";
            karga.hiz = 50;
            karga.isim = "Alaca";
            karga.renk = "Siyah";
            karga.agirlik = 1559;

            karga.sescikar();
            Console.WriteLine(karga.sescikar());

            #endregion


            Console.Read();
        }
    }
}
