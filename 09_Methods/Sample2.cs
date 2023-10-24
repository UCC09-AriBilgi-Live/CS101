using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class Sample2
    {
        public static void Main(string[] args)
        {
            // Bazen yazdığımız metotlar aynı isimde olabilip birden fazla şekilde kullanılabilir. Bu duruma literatürde "method overloading - metot aşırı yükleme - adı verilir

            Console.WriteLine("2'li toplama işlemi sonucu = {0}\n\n",toplamaIslemi(5,15));

            Console.WriteLine("3'li toplama işlemi sonucu = {0}\n\n", toplamaIslemi(5, 15,25));

            Console.WriteLine("4'li toplama işlemi sonucu = {0}\n\n", toplamaIslemi(5, 15,25,35));

        }

        // Metotlarımız

        private static int toplamaIslemi(int sayi1,int sayi2)
        {
            // sadece 2 sayıyı toplayan metot

            return sayi1 + sayi2;
        }

        private static int toplamaIslemi(int sayi1, int sayi2,int sayi3)
        {
            // sadece 3 sayıyı toplayan metot

            return sayi1 + sayi2 + sayi3;
        }

        private static int toplamaIslemi(int sayi1, int sayi2, int sayi3,int sayi4)
        {
            // sadece 4 sayıyı toplayan metot

            return sayi1 + sayi2 + sayi3 + sayi4;
        }
    }
}
