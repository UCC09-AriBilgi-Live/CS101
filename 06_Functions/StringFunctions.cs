using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Functions
{
    internal class StringFunctions
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    STRING FUNCTIONS ÖRNEKLERİ       *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");

            #region Length

            //string metin = "Arı Bilgi'de C# öğreniyoruz...";

            //Console.WriteLine("Metnin uzunluğu {0} karakterdir...", metin.Length);

            #endregion

            #region ToLower(),ToUpper()

            //string metin = "Arı Bilgi'de C# öğreniyoruz...";
            //string metin1 = "MCSD KURSu...";

            //Console.WriteLine("Metin {0} -> Sonuç : {1} \n\n",metin,metin.ToUpper());
            //Console.WriteLine("Metin {0} -> Sonuç : {1}", metin1,metin1.ToLower());

            #endregion

            #region Compare()

            string metin1 = "McsD";
            string metin2 = "McSd";

            int sonuc=String.Compare(metin1, metin2);

            switch (sonuc)
            {
                case 0:
                    Console.WriteLine("Her iki metin de aynı");
                    break;
                case 1:
                    Console.WriteLine("1. metin büyüktür...");
                    break;
                case -1:
                    Console.WriteLine("2. metin büyüktür...");
                    break;
                default:
                    break;
            }

            #endregion

            #region Concat
            string y1 = "Bugün günlerden ";
            string y2 = "dünya kedi günü...";
            int age = 4;

            Console.WriteLine("Sonuç : {0} yaş",String.Concat(y1, y2,age));

            #endregion


            // Ekrandan Ad,Soyad,Yaş alacak...
            // bunları birleştirecek
            // cw ile yazacak
            // ama aralarında boşluk verecek ÜmitKaraçivi28 değilde Ümit Karaçivi kendini nedense beyinsel olarak 28 yaşında hissediyor. yazsın


            // ekrandan userid/şifre alınacak. gerekli, string fonksiyonu kullanılarak doğruluğu kontrol edilip mesaj verilecek...




        }
    }
}
