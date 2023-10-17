using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlowMechanism
{
    internal class IfElse
    {

        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    IF-ELSE ÖRNEKLERİ                *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");

            //int a, b;

            //a = Convert.ToInt32(Console.ReadLine()); // Console.Readline ekrandan sadece karakter okuması yapabildiği için bunu sayısal değere çevirmek için Convert kullanmak gerekiyor.

            //b = Convert.ToInt32(Console.ReadLine());

            //if (a > b)
            //{
            //    Console.WriteLine("A sayısı : " + a);
            //    Console.WriteLine("B sayısı : " + b);
            //    Console.WriteLine("a sayısı b sayısından büyüktür....");
            //}
                
                
            //else 
            //{ 
            //    Console.WriteLine("a sayısı b sayısından küçüktür...."); 
            //}

            // Ekrandan alınan bir sayının negatif/pozitif/0 olup olmadığını ekranda "Girdiğiniz sayı Negatifdir/pozitifdir/Sıfırdır " şeklinde çıkış veren program parçası

            int sayi;

            Console.WriteLine("Lütfen sayınızı giriniz : ");
            sayi=Convert.ToInt32(Console.ReadLine());

            if (sayi > 0) // Önce sayının 0 dan büyüklüğü kontrol ediliyor..
            {
                Console.WriteLine("Girmiş olduğunuz sayı POZİTİFdir..");
            }
            else // Demek ki sayımız 0 dan küçük veya eşit dir
            {
                if (sayi < 0) // Hemen küçüklüğünü kontrol ediyorum.
                {
                    Console.WriteLine("Girmiş olduğunuz sayı NEGATİFdir..");

                }
                else
                {
                    Console.WriteLine("Girmiş olduğunuz sayı NÖTR dür..");
                }
            }
   

        }
    }
}
