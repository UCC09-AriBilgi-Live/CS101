using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlowMechanism
{
    internal class ForLoop
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    FOR-LOOP ÖRNEKLERİ               *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");

            // 
            // 1 den 100 e kadar olan sayıların toplamı

            //int toplam = 0;

            //for (int sayac = 1; sayac <= 100; sayac++)
            //{
            //    toplam = toplam + sayac; // <-- toplam+=sayac;

            //    Console.Write("Sayac : {0} - Toplam : {1} \n", sayac,toplam);
            //}

            // 1'den 1000'e kadar(sınırlar dahil) olan sayılar içinde 5'e tam bölünen sayıları alt alta listeleyen, bu sayılardan kaç tane olduğu bulan , bi de bu sayıları toplaycak zımbırtıyı geliştiriniz. kopiş...mod kullanılacak

            //int toplam = 0;
            //int adet = 0;

            //for (int sayi = 1; sayi <= 1000; sayi++)
            //{
            //    if (sayi % 5 == 0) // sayı 5 e tam bölünüyomu
            //    {
            //        // bir sayı buldum
            //        adet++;

            //        toplam += sayi;

            //        Console.WriteLine("Sayı : {0} - Şu anki toplam : {1}",sayi,toplam  );
            //    }
            //}

            //Console.WriteLine("\n\n\t5'e bölünen sayıların adedi {0} tanedir...",adet);


            // ekrandan baslangıç ve bitiş değerleri alınacak
            // bu sınırlar içersinde 5 e tam bölünebilen ama 7 ye tam bölünemeyen sayıları alt alta listeleyen, bu sayılardan kaç tane olduğu bulan , bi de bu sayıları toplaycak zımbırtıyı geliştiriniz. kopiş...mod kullanılacak...

            int bas, bitis, adet=0, toplam=0;

            Console.WriteLine("Başlangıç giriniz :");
            bas =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş giriniz :");
            bitis = Convert.ToInt32(Console.ReadLine());

            for (int sayac = bas; sayac <= bitis; sayac++)
            {
                if (sayac % 5 == 0 && sayac % 7 != 0)
                {
                    toplam+=sayac;
                    adet++;

                    Console.WriteLine("Sayı : {0} - Şu anki toplam : {1}", sayac, toplam);
                }
            }

            Console.WriteLine("\n\n\t5'e bölünen 7'ye bölünemeyen sayıların adedi {0} tanedir...",adet);

        }
    }
}
