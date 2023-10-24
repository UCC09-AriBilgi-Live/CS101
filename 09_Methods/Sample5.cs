using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class Sample5
    {
        public static void Main(string[] args)
        {
            // yine ekrandan 1. not 2. not alınacak...60 notu kontroluna göre geçti kaldı yazcek...

            Console.WriteLine("Sayı : {0}\n\n",SayiTut(true));

            Console.WriteLine("Sayı : {0}\n\n", SayiTut(false));

            Console.WriteLine("Sayı : {0}\n\n", SayiTut(true));

            Console.WriteLine("Sayı : {0}\n\n", SayiTut(false));



        }

        // Metot 
        // Ortalama metot adı

        //* Klavyeden birim fiyatı ve indirim oranı girilen bir malın fiyatını hesaplayacak ve yazcak..Metot kullanarak


        //* Üç kenar uzunluğu girilen üçgenin çeşidini bulan ve yazan


        //* Metot adı - SayiTut olsun
        // Eğer bu metoda true değeri gönderilirse 1-100 arasında rastgele(random) ama bu sayı tek olacak
        // eğer bu metoda false değeri gönderilirse 1-100 arasında rastgele(random) ama bu sayı çift olacak
        // ve bu tuttuğu sayıyı ekranda gösterecek gerekirse gerekli mesajlarla

        private static int SayiTut(bool prmYD)
        {
            int sayi;

            if (prmYD != true)
            {
                do
                {
                    Random random = new Random();

                    sayi = random.Next(1,100);
                } 
                while (sayi % 2 == 0);


            }
            else
            {
                do
                {
                    Random random = new Random();

                    sayi = random.Next(1, 100);
                }
                while (sayi % 2 == 1);
            }

            return sayi;
        }

    }
}
