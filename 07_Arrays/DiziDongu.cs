using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Arrays
{
    internal class DiziDongu
    {
        public static void Main(string[] args)
        {
            #region for/foreach döngüleri

            // Daily WorkOut_1 - Sınıf içi çalışma

            // Verilen bir tamsayı dizisinin elemanlarının toplamını for ve foreach döngülerini kullanarak yazınız...


            //for
            //int[] sayilar1 = { 5, 6, 7, 8, 78, 45, 0, 99, 20, 30 };

            //int toplam = 0;

            //for (int index = 0; index < sayilar1.Length; index++)
            //{
            //    toplam += sayilar1[index];
            //}

            //Console.WriteLine("Dizi elemanlarının toplamı = {0}",toplam);

            //// foreach

            //int toplam1 = 0;

            //foreach (int elemandeger in sayilar1) 
            //{ 
            //toplam1+= elemandeger;

            //}

            //Console.WriteLine("foreach ile : {0}",toplam1);


            // Daily WO2

            // Tanımlanan sayısal bir dizi içindeki elemanların negatif/pozitif/işaretsiz olma durumlarını elemanın yanına yazan programcığı yazınız... Negatif/pozitif/nötr sayıların adedini de yazdırınız. 

            //int pozitifAdet=0, negatifAdet=0, notrAdet = 0;

            //int[] sayilar2 = { 5, 6, -15, 22, -34, 3, 0, -7, 8, 100, -100 };

            //foreach (int sayi in sayilar2)
            //{
            //    switch (sayi)
            //    {
            //        case >0 :
            //            pozitifAdet++;

            //            Console.WriteLine("Sayı : {0} - Pozitifdir..",sayi);
            //            break;
            //        case < 0:
            //            negatifAdet++;
            //            Console.WriteLine("Sayı : {0} - Negatifdir..",sayi);
            //            break;

            //        default:
            //            notrAdet++;
            //            Console.WriteLine("Sayı : {0} - Nötrdür..", sayi);
            //            break;
            //    }
            //}

            //Console.WriteLine("Pozitiflerin adedi : {0}\n\n",pozitifAdet);
            //Console.WriteLine("Negatiflerin adedi : {0}\n\n", negatifAdet);
            //Console.WriteLine("Nötrlerin adedi : {0}\n\n", notrAdet);

            // DWO 3
            // Kullanıcıdan istenen ekran alınan bir metin içindeki sesli harf sayısı bulma / ekrana yazma/ farklı bir diziye yerleştirme

            // öncelikle sesli harflerin tutulduğu bir dizi yaratıyorum.

            //char[] sesliler = { 'a', 'e', 'ı', 'i', 'ö', 'o', 'u', 'ü' };

            //char[] hangileri = new char[30]; // içini dolduracağım bulduklarımla-ekrandan girilen

            //int hindex = 0; // hangileri dizisinin indexi

            //string metin = ""; // ekrandan alınan metin bilgisinin tutulacak

            //int adet = 0; // bulacağım seslilerin adedi tutuyor

            //Console.Write(  "Lütfen metni giriniz : ");
            //metin = Console.ReadLine().ToLower(); // öncelikle küçültüyorum benim dizime uysun diye

            //// Bir for döngüsü benim tanımlamış olduğum sesliler dizisi üzerinde dolaşacak(kontrol etcem ya )

            //for (int i = 0; i < sesliler.Length; i++)
            //{
            //    // ikinci for çevrimi de ekrandan aldığım metin için
            //    for (int j = 0; j < metin.Length; j++)
            //    {
            //        if (metin[j] == sesliler[i]) // girilen metni diziymiş gibi dolaşıyorum
            //        {
            //            hangileri[hindex] = metin[j]; // bulduğun karakteri hangileri dizisine göm
            //            hindex++;
            //            adet++;

            //        }

            //    }
            //}

            //// artık herşey bitmiştir

            //Console.WriteLine(  "Girmiş olduğunuz metinde {0} adet sesli harf vardır...",adet);

            //Console.WriteLine(hangileri);

            // DWO 4
            // 10 elemanlı sayısal bir dizim var.
            // bu dizideki neg/poz/sıfır değerlerin kacar adet olduğunu bulunuz...

            int sifirSay = 0, pozSay = 0, negSay = 0;

            int[] sayilar5 = { 1, 7, -8, 9, -100, 1001, -10, -20, 0, 0, 0, 0, 0, 0, 5 };

            for (int i = 0; i < sayilar5.Count(); i++)
            {
                switch (sayilar5[i])
                {
                    case > 0:
                        pozSay++;

                        break;
                    case < 0:
                        negSay++;
                        break;
                    default:
                        sifirSay++;

                        break;
                }
            }

            Console.WriteLine("Sıfırların sayısı : {0} \n\n",sifirSay);
            Console.WriteLine("Negatiflerin sayısı : {0} \n\n", negSay);
            Console.WriteLine("Pozitiflerin sayısı : {0} \n\n", pozSay);




            #endregion
        }
    }
}
