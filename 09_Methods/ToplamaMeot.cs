using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class ToplamaMeot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.sayıyı giriniz...:");
            int sayi1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayıyı giriniz...:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int buyuk = KucukBuyuk(sayi1, sayi2); // ben KucukBuyuk a parametre ile gidiom. geri dönüş değerini buyuk postalıyo

            Console.WriteLine("Girilen büyük sayı {0} "+ buyuk);

        }

        static int KucukBuyuk(int a, int b)
        {
            // bu metot param alıyo bide değer postalıyo
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }


        }


    }
}
