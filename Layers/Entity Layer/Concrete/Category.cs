using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } // Değeri istediğimiz formatta kullanmamızı sağlıyor get ve set. Set de kural koyabiliriz.   
        public bool CategoryStatus { get; set; }

    }
}
/*
 Field
 Variable
 Property
 ----------------------------------------------------
 int x; Direkt sınıfın içinde tanımlanırsa -> Field

 int x {get;set} şeklinde tanımlanırsa -> Property

 Bir değer metot içinde tanımlanırsa -> Variable
 
 */