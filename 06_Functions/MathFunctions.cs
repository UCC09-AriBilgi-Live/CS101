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
            /*
             Abs metodu verilen sayının mutlak değerini almak için kullanılmaktadır. Abs metodu parametre olarak farklı veri türlerinde değer alabilmekte ve aldığı veri türünde değer geri döndürmektedir. Yani int alıyorsa int , double alıyorsa double geri döndürür.

              Syntax;

                int sonuc=Math.Abs(int sayi);

                double sonuc=Math.Abs(double sayi);

                float sonuc=Math.Abs(float sayi);

                long sonuc=Math.Abs(long sayi);

                decimal sonuc=Math.Abs(decimal sayi);

                short sonuc=Math.Abs(short sayi);

                sbyte sonuc=Math.Abs(sbyte sayi);

            */





            //int sayi1 = -1000;
            //int sayi2 = 5;

            //int abs1=Math.Abs(sayi1);
            //int abs2=Math.Abs(sayi2);

            //Console.WriteLine("Sayım : {0} - ABSsi {1}\n\n", sayi1, abs1);
            //Console.WriteLine("Sayım : {0} - ABSsi {1}\n\n", sayi2, abs2);


            #endregion

            #region Max,Min
            // Min metodu, parametre olarak verilen iki sayıdan küçük olanı döndüren metod'dur. Bu metot bütün sayı türleri tarafından kullanılabilmektedir.

            /*
             int sonuc=Math.Min(int sayi1,int sayi2);

            float sonuc=Math.Min(float sayi1,float sayi2);

            double sonuc=Math.Min(double sayi1,double sayi2);

            decimal sonuc=Math.Min(decimal sayi1,decimal sayi2);
            
            byte sonuc=Math.Min(byte sayi1,byte sayi2);

            long sonuc=Math.Min(long sayi1,long sayi2);

            short sonuc=Math.Min(short sayi1,short sayi2);

            unit sonuc=Math.Min(unit sayi1,unit sayi2);

            sbyte sonuc=Math.Min(sbyte sayi1,sbyte sayi2);

            ulong sonuc=Math.Min(ulong sayi1,ulong sayi2);

            ushort sonuc=Math.Min(ushort sayi1,ushort sayi2);

             */

            //Max metodu, parametre olarak verilen iki sayıdan büyük olanı döndüren metod'dur. Bu metot bütün sayı türleri tarafından kullanılabilmektedir. 

            //int sonuc = Math.Max(int sayi1, int sayi2);

            //float sonuc = Math.Max(float sayi1, float sayi2);

            //double sonuc = Math.Max(double sayi1, double sayi2);

            //decimal sonuc = Math.Max(decimal sayi1, decimal sayi2);

            //byte sonuc = Math.Max(byte sayi1, byte sayi2);

            //long sonuc = Math.Max(long sayi1, long sayi2);

            //short sonuc = Math.Max(short sayi1, short sayi2);

            //unit sonuc = Math.Max(unit sayi1, unit sayi2);

            //sbyte sonuc = Math.Max(sbyte sayi1, sbyte sayi2);

            //ulong sonuc = Math.Max(ulong sayi1, ulong sayi2);

            //ushort sonuc = Math.Max(ushort sayi1, ushort sayi2);


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
            // Round metodu, parametre olarak verilen ondalıklı sayıyı en yakın tam sayıya yuvarlama işlemi yapmaktadır. Örneğin : 3.01 ise 3'e yuvarlar, 3.49 ise 3'e yuvarlar, 3.51 ise 4'e yuvarlar.

            //Console.WriteLine("Sonuc = {0}",Math.Round(1.5));

            #endregion

            #region Sqrt Metodu
            // Sqrt metodu, karakök bulmak için kullanılmaktdır. Double türünde verilen sayının karekökünü double türünde geri döndüren metot'tur.

            //Console.WriteLine("Karekökünü bulmak istediğiniz sayıyı giriniz");

            //double sayi = double.Parse(Console.ReadLine());

            //double sonuc = Math.Sqrt(sayi);

            //Console.WriteLine(sonuc);

            #endregion

            #region BigMul Metodu
            //BigMul metodu parametre olarak verilen 2 adet int tamsayının çarpımını,  long türünde geri döndüren metod'dur.

            //int sayi1 = 37;

            //int sayi2 = 28;

            //long sonuc = Math.BigMul(sayi1, sayi2);

            //Console.WriteLine(sonuc);


            #endregion

            #region Ceiling
            //Ceiling metodu, parametre olarak verilen ondalıklı sayıyı yukarıya veya tamsayının aynısına yuvarlama işlemi yapmak için kullanılmaktadır. Bu metodda virgülden sonra 0'dan başka herhangi bir sayı olduğunda yukarı yuvarlama işlemi yapmaktadır.


            //Console.WriteLine("Sonuc : {0} ", Math.Ceiling(3.01));
            //Console.WriteLine("Sonuc : {0} ", Math.Ceiling(3.00));

            #endregion

            #region Floor
            // Math.Floor(x) metodu, x olarak verilen ondalıklı sayıyı bir alt tamsayıya yuvarlar.

            double sayi = Math.Floor(8.99);


            Console.WriteLine("Sonuc : {0} \n\n", Math.Floor(3.01));

            Console.WriteLine("Sonuc : {0} ", sayi);

            #endregion

            #region DivRem Metodu
            // Divrem metodu, bölme işleminde bölümü bulmak için kullanılan metod'dur. Bölünen ve bölen girildiğinde geriye bölme işleminin sonucunu veren ve 3. parametre olarakta kalanı veren parametredir. Sayısal veri türlerinin tümünde kullanılabilir.

            //int kalan;

            //Console.WriteLine("Lütfen bölünen sayıyı giriniz.");
            //int bolunen = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen bölen sayıyı giriniz.");
            //int bolen = Int32.Parse(Console.ReadLine());


            //int bolum = Math.DivRem(bolunen, bolen, out kalan);

            //Console.WriteLine("Bölme işleminde Bölüm={0}, Kalan={1}", bolum, kalan);

            #endregion

            #region Sign Metodu
            //Sign metodu, parametre olarak verilen sayının negatif mi, pozitif mi, sıfıra eşit mi olduğunu bulmak için kullanılmaktadır. Geriye döndürdüğü değerler:

            // 0 : Geriye 0(sıfır) döndürdüğünde Sıfıra eşit demektir.
            // 1 : Geriye 1(bir) döndürdüğünde Pozitif demektir.
            //- 1 : Geriye - 1(eksi bir) döndürdüğünde Negatif demektir.

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Int32.Parse(Console.ReadLine());

            //int sonuc = Math.Sign(sayi);

            //switch (sonuc)
            //{
            //    case 0: Console.WriteLine("Sayı Sıfıra Eşit"); break;
            //    case 1: Console.WriteLine("Sayı Pozitif"); break;
            //    case -1: Console.WriteLine("Sayı Negatif"); break;

            //    default: Console.WriteLine("Yanlış Değer Girildi"); break;
            //}

            #endregion
        }
    }
}
