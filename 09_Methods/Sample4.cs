using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class Sample4
    {
        public static void Main(string[] args)
        {
            // Metot yapısı kullanarak 4 işlemi(+  - * /) tamamen değerleri ekrandan alarak sonuçlarını veren programcık.

            // Yönlendirici bölge
            // sayi1,sayi2 diye alcam
            // bunları parametre olarak metota/metodlara göndercem
            // sonuçlarını Main metot içinde yazdırcam...!

            Console.WriteLine("1.sayıyı gir : ");
            int sayi1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı gir : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama işlemi sonucu = {0}\n\n",Topla(sayi1,sayi2));

            Console.WriteLine("Çıkartma işlemi sonucu = {0}\n\n", Cikart(sayi1, sayi2));

            Console.WriteLine("Çarpma işlemi sonucu = {0}\n\n", Carp(sayi1, sayi2));

            Console.WriteLine("Bölme işlemi sonucu = {0}\n\n", Bol(sayi1, sayi2));

        }

        // Metot bölgesi

        private static int Topla(int prmSayi1,int prmSayi2)
        {

            return prmSayi1 + prmSayi2;

        }

        private static int Cikart(int prmSayi1, int prmSayi2)
        {

            return prmSayi1 - prmSayi2;

        }

        private static int Carp(int prmSayi1, int prmSayi2)
        {

            return prmSayi1 * prmSayi2;

        }

        private static double Bol(double prmSayi1, double prmSayi2)
        {
            if (prmSayi2 == 0)
            {
                Console.WriteLine("Tanımsız...");
                return -1;
            }
            else
            {
                return prmSayi1 / prmSayi2;
            }

            //try
            //{
            //    return prmSayi1 / prmSayi2;
            //}
            //catch
            //{
            //    Console.WriteLine("Tanımsız...."  );

            //    return 0;
            //}





        }


    }
}
