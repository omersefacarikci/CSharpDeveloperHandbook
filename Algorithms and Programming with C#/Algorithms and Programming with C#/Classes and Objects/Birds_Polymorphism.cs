using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Birds_Polymorphism
    {
        public string tur;
        public int hiz;
        public double agirlik;

        public virtual string sescikar()
        {
            return "Buraya ses yazılacak!";
        }
    }
}
