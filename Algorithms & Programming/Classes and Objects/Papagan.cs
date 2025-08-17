using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    // : Miras alacağımız sınıfı yazıyoruz.
    class Papagan : Birds_Polymorphism // poly
    {
        public string isim;
        public string renk;

        // Polymorphism
        public override string sescikar()
        {
            return "cikk cik";
        }   
        

    }
}
