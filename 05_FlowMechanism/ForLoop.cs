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

            //int bas, bitis, adet=0, toplam=0;

            //Console.WriteLine("Başlangıç giriniz :");
            //bas =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitiş giriniz :");
            //bitis = Convert.ToInt32(Console.ReadLine());

            //for (int sayac = bas; sayac <= bitis; sayac++)
            //{
            //    if (sayac % 5 == 0 && sayac % 7 != 0)
            //    {
            //        toplam+=sayac;
            //        adet++;

            //        Console.WriteLine("Sayı : {0} - Şu anki toplam : {1}", sayac, toplam);
            //    }
            //}

            //Console.WriteLine("\n\n\t5'e bölünen 7'ye bölünemeyen sayıların adedi {0} tanedir...",adet);

            // Konsol ekranına girilen 0 ila 100 (sınırlar dahil) arasındaki 3 notun en büyüğünü, en küçüğünü ve ortalamasını bulan gösteren programcık...Yaniiii....Bubble Sort

            int bnot = 0, knot = 0;
            double toplam=0;

            for (int sayac = 0,not; sayac < 3; sayac++) // satırda 1 değişgen daha tanımlayabiliyoruz.
            {
                Console.WriteLine("Lütfen {0}. notunuzu giriniz : ", sayac + 1); // dinamik olarak mesaj veriyoruz....

                not = Convert.ToInt32(Console.ReadLine()); // notumu okudum

                if (not > 100 || not < 0) // notum 0-100 aralığında olmalı
                {
                    Console.WriteLine("Yanlış not girdiniz..Lütfen tekrar giriniz");
                    sayac--;
                    continue; // continue olunca aşağıya devam etmeden yine for çevrimini bir onceki sayactan devam ediyor
                }

                if (sayac == 0) // yani daha ilk sayıyı okumuşum 
                {
                    bnot = not;
                    knot = not;
                }
                else
                { // duruma göre değişim işlemi yapılıyor
                    if (not > bnot) //not bnot dan büyükse artık bnot'un benim girdiğim not dur.
                        bnot = not;

                    if (not < knot)
                        knot = not;

                }

                toplam += not;

            }

            Console.WriteLine("En büyük not : {0}\nEn küçük not : {1}\nOrtalama : {2}",bnot,knot,toplam/3);


            //ekrandan girilen 10 sayı içinde pozitif olup ve tek olan sayıların ayrı ayrı çarpımını bulan program parçacığı...(zımbırtı...)



        }
    }
}
