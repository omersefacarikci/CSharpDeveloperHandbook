using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //Dosya işlemleri için kullanılacak kütüphanedir.
using System.Threading.Tasks;

namespace Text_Document_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creating a New Text Document
            StreamWriter sw = new StreamWriter("C:\\Users\\Ömer Sefa\\Desktop\\CreateTextFolder.txt");
            #endregion

            #region Writing Text into a New Text Document
            StreamWriter swr = new StreamWriter("C:\\Users\\Ömer Sefa\\Desktop\\CreateTextFolder2.txt");
            swr.Write("Writing Text into a New Text Document");
            sw.Close(); // Yazma tamamlandı kayıt edebilirsin demek istiyoruz.
            #endregion

            #region Data Entry into a Text Document from the Keyboard
            StreamWriter stream = new StreamWriter("C:\\Users\\Ömer Sefa\\Desktop\\CreateTextFolder3.txt");
            string metin;
            Console.Write("Metni giriniz: ");
            metin = Console.ReadLine();
            stream.Write(metin);
            stream.Close();

            #endregion

            #region Reading a Text Document
            FileStream fs = new FileStream("adres",FileMode.Open,FileAccess.Read);
            StreamReader streamReader = new StreamReader(fs);
            string metin2 = streamReader.ReadLine();
            while (metin2 != null)
            {
                Console.WriteLine(metin2);
                metin2 = streamReader.ReadLine();
            }
            fs.Close();
            streamReader.Close();
            #endregion
            Console.Read();

        }
    }
}
