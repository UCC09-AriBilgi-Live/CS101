using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Functions
{
    internal class StringFunctions
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    STRING FUNCTIONS ÖRNEKLERİ       *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");

            #region Length

            //string metin = "Arı Bilgi'de C# öğreniyoruz...";

            //Console.WriteLine("Metnin uzunluğu {0} karakterdir...", metin.Length);

            #endregion

            #region ToLower(),ToUpper()

            string metin = "Arı Bilgi'de C# öğreniyoruz...";
            string metin1 = "MCSD KURSu...";

            Console.WriteLine("Metin {0} -> Sonuç : {1} \n\n",metin,metin.ToUpper());
            Console.WriteLine("Metin {0} -> Sonuç : {1}", metin1,metin1.ToLower());

            #endregion

        }
    }
}
