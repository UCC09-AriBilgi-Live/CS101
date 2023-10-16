using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    internal class Matematiksel
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    MATEMATİKSEL OPERATÖR ÖRNEKLERİ  *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");

            // Mod alma operatörü (%)

            int a = 5 % 2; // 5 sayısının 2 ye bölümünden kalan değer a değişgenine atanıyor.

            Console.WriteLine("Mod işleminin sonucu = "+ a + "\n");

            // İlginç bir durum
            // Eğer işlem yapılan her iki operand farklı türdeyse sonuç daha üst kapasiteli veri türüne dönüştürülür.

            float b = 5 / 2f;

            Console.WriteLine("İlginç durumun sonucu = " + b + "\n"); // sonucu yaz bir satır atla.


            // Ancak....durumu

            float c = 2 / 5f / 0.4f;

            Console.WriteLine("Ancak durumu sonucu = " + c);

            // Daha ilginç  bir durum

            float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3;

            Console.WriteLine("Daha ilginç durum: " + e);














            //Console.ReadKey();

        }

    }
}
