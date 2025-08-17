using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Customer
    {
        public int id;
        private string name; // --> Kapsülleme için Aynı anda CTRL + R + E basıyoruz.
        public string surname;
        public string city;

        //Property 
        public string Name { get => name; set => name = value.ToLower(); } // Ad her zaman küçük harfle gelsin.
    }
}
