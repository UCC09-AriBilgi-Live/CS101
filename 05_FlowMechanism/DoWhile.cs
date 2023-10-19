using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlowMechanism
{
    internal class DoWhile
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    DO-WHILE ÖRNEKLERİ               *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");


            // 1 den 100 e kadar olan sayıların toplamını do..while yöntemiyle hesaplayalım

            //int toplam = 0;
            //int sayac = 0;

            //do
            //{
            //    sayac++; // sayacı 1 arttırıyorum..

            //    toplam += sayac; // toplam=toplam+sayac;

            //    Console.WriteLine("Toplam : {0} Sayac : {1}", toplam, sayac);

            //} while (sayac < 100);


            // Şu sayıdan şu sayıya kadar baş ve bitiş değerleri alınacak
            // yine toplam olsun??--WW(Weekend Workout)


            // sayac kadar ekrana belirli miktarda aynı bilgiyi yazmak..

            //int sayac1 = 0;

            //do
            //{
            //    sayac1++;

            //    for (int i = 1; i < 3; i++)
            //    {
            //        Console.WriteLine("Sayac : {0} - Benim adım Hıdır. Yaptığım budur....",sayac1  );
            //    }

            //    Console.WriteLine("\n\n"); // yukardaki döngü bitince 2 satır boşluk koyuyor daha okunaklı oluyo


            //} while (sayac1<10); // Konbtrol olmazsa sonsuz döngü dediğimiz olay oluyor.

            // sabit olan Kullanıcı adı ve şifreyi...
            // ekrandan girmiş olduğum userid ve passw değerlerine göre kontrolünü yapan eğer herşey doğruysa sisteme girdiniz eğer yanlışsa bilgiler hatalı tekrar deneyiniz diyerek bilgileri tekrardan alma işi yapan do-while yapısını kurunuz...

            const string vs_kAdi = "admin"; // sabit
            const string vs_kSifre = "12345";

            string vs_EkranKulAd = ""; // ekrandan aldığımız kulad
            string vs_EkranKulSifre = "";

            int vi_Dogrumu = 0; //initial

            //bool vb_EsitMi=false; // ekrandan aldığım değerlerle eğer const olarak tanımladığım değer eşitse doğru(true) değeri alacak


            do
            {
                //Console.Clear();

                Console.WriteLine("Lütfen kullanıcı adını giriniz : ");
                vs_EkranKulAd= Console.ReadLine();

                Console.WriteLine("Lütfen şifrenizi giriniz : ");
                vs_EkranKulSifre= Console.ReadLine();

                if (vs_kAdi==vs_EkranKulAd && vs_kSifre==vs_EkranKulSifre)
                {
                    // yani herşey doğru hoşgeldin durumu

                    Console.WriteLine("\n\nSisteme giriş yaptınız....."  );

                    vi_Dogrumu = 1; // eğer herşey doğru kontağı aç lamba yansın

                    break; // do-while dan direkt olarak çıkmamızı , tekrar döngüye gitmemesini sağlıyoruz.
                }
                else
                {
                    Console.WriteLine("\n\nGirdiğiniz bilgiler yanlış ...tekrar deneyiniz...");
                }
            } while (vi_Dogrumu == 0);
        }
    }
}
