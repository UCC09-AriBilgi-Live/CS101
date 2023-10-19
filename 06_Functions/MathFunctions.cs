using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Functions
{
    internal class MathFunctions
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    MATH FUNCTIONS ÖRNEKLERİ         *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");

            #region Abs - Mutlak değer
            //int sayi1 = -1000;
            //int sayi2 = 5;

            //int abs1=Math.Abs(sayi1);
            //int abs2=Math.Abs(sayi2);

            //Console.WriteLine("Sayım : {0} - ABSsi {1}\n\n", sayi1, abs1);
            //Console.WriteLine("Sayım : {0} - ABSsi {1}\n\n", sayi2, abs2);


            #endregion

            #region Max,Min

            //int sayi1 = 37;
            //int sayi2 = 100;

            //int sonucmin= Math.Min(sayi1, sayi2);

            //int sonucmax = Math.Max(sayi1, sayi2);

            //Console.WriteLine("Küçük sayı : {0} - Büyük sayı {1}",sonucmin,sonucmax  );

            #endregion

            #region Pow
            //double sayi1 = 4;

            //double sayi2 = 5;

            //double sonuc = Math.Pow(sayi1, sayi2);

            //Console.WriteLine("Sonuc : {0}",sonuc);

            #endregion

            #region Round


            //Console.WriteLine("Sonuc = {0}",Math.Round(1.5));

            #endregion

            #region Ceiling

            //Console.WriteLine("Sonuc : {0} ", Math.Ceiling(3.01));
            //Console.WriteLine("Sonuc : {0} ", Math.Ceiling(3.00));
            #endregion

            #region Floor

            double sayi = Math.Floor(8.99);


            Console.WriteLine("Sonuc : {0} \n\n", Math.Floor(3.01));

            Console.WriteLine("Sonuc : {0} ", sayi);
            
            #endregion
        }
    }
}
