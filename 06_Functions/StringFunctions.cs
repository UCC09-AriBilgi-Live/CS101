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
            // Length metodu string ifadelerde kullanıldığında metnin kaç karakterden oluştuğunu bulmak için kullanılmaktadır. İnt türünde değer döndürmektedir.


            //string metin = "Arı Bilgi'de C# öğreniyoruz...";

            //Console.WriteLine("Metnin uzunluğu {0} karakterdir...", metin.Length);

            #endregion

            #region ToLower(),ToUpper()
            // ToLower metodu string değişken içinde bulunan metnin tamamını küçük harfe dönüştürmek için kullanılmaktadır. 

            // ToUpper metodu string değişken içinde bulunan metnin tamamını büyük harfe dönüştürmek için kullanılmaktadır. 

            //string metin = "Arı Bilgi'de C# öğreniyoruz...";
            //string metin1 = "MCSD KURSu...";

            //Console.WriteLine("Metin {0} -> Sonuç : {1} \n\n",metin,metin.ToUpper());
            //Console.WriteLine("Metin {0} -> Sonuç : {1}", metin1,metin1.ToLower());

            #endregion

            #region Compare()
            // Compare metodu türkçe kelime karşılığından da anlaşıldığı üzere karşılaştırma işlemi yapmaktadır. İki string ifadenin karşılaştırılması için kullanılmaktadır. String ifadelerin 1. karakterinden itibaren karakter karakter karşılaştırma işlemi yapar ve buna görede integer(tamsayı) bir değer geri döndürür. Geri dönen değerler:

            /*  0 : Geri dönen değer 0 (sıfır) olduğunda iki metin tamamen eşit demektir. (metin1=metin2)
                1 : Geri dönen değer 1(bir) olduğunda birinci metnin karşılaştırılan karakteri diğer karakterden büyük olduğu anlamına gelmektedir. (metin1 > metin2)
                - 1 : Geri dönen değer - 1(eksi bir) olduğunda birinci metnin karşılaştırılan karakteri diğer karakterden küçük olduğu anlamına gelmektedir..(metin1 < metin2)
            */

            // Compare Metodu Büyük-Küçük Harfe Duyarlı-Duyarsız
            // Compare metodunun büyük küçük harfe duyarlı veya duyarsız olarak yapmak için compare metoduna 3. parametre eklenir ve bu parametre boolean yani true veya false değeridir. Bu değerlerden:

            //string degisken1, degisken2;
            //int sonuc;

            //degisken1 = "MCSD";
            //degisken2 = "Mcsd";

            //sonuc = String.Compare(degisken1, degisken2, true);

            //Console.WriteLine(sonuc);

            //string metin1 = "McsD";
            //string metin2 = "McSd";

            //int sonuc=String.Compare(metin1, metin2);

            //switch (sonuc)
            //{
            //    case 0:
            //        Console.WriteLine("Her iki metin de aynı");
            //        break;
            //    case 1:
            //        Console.WriteLine("1. metin büyüktür...");
            //        break;
            //    case -1:
            //        Console.WriteLine("2. metin büyüktür...");
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            #region Concat
            //Concat metodu string ifadeleri kısaca birleştirmek için kullanılan metod'dur. Verilen ifadeleri ard arda ekler ve geriye string olarak değer döndürmektedir.

            string y1 = "Bugün günlerden";
            string y2 = "dünya kedi günü...";
            int age = 4;

            Console.WriteLine("Sonuç : {0} yaş",String.Concat(y1," ", y2," Hardal'ın yaşı : ",age));

            #endregion


            // Ekrandan Ad,Soyad,Yaş alacak...
            // bunları birleştirecek
            // cw ile yazacak
            // ama aralarında boşluk verecek ÜmitKaraçivi28 değilde Ümit Karaçivi kendini nedense beyinsel olarak 28 yaşında hissediyor. yazsın


            // ekrandan userid/şifre alınacak. gerekli, string fonksiyonu kullanılarak doğruluğu kontrol edilip mesaj verilecek...




        }
    }
}
