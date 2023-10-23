using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Arrays
{
    internal class DiziGenel
    {
        public static void Main(string[] args)
        {
            #region Dizi tanımlama,değer atama,kullanma

            int[] dizi = new int[20]; // 20 elemanlı dizi isminde int türünden bir dizi

            dizi[9] = 10; // 10.elemanına 10 değeri atandı.

            Console.WriteLine("Dizi elemanının içeriği : {0}", dizi[8]);

            // Şöyle de tanımlama yapılabilir...

            string[] dizi1 = { "Bir", "İki", "Üç" }; // string bir dizi daha tanımlanırken ilk değerleri..initial...atanıyor.

            int[] dizi2 = { 2, -5, 12 };

            float[] dizi3 = { 2f, 1.2f, 7f };

            // Not : Ancak bu şekilde bir dizi bildirimi sadece dizi tanımlamalarında kullanılabiliyor. Yani aşağıdaki gibi kullanamayız...

            //int[] dizi4;

            //dizi4 = {1,2,3 };

            int[] dizi5 = new int[] { 0, 1, 2, };

            // dinamik bir dizi yaratımı
            Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı giriniz...");

            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] dizi6 = new int[boyut];

            dizi6[7] = 500;

            Console.WriteLine("Eleman : {0}", dizi6[7]);

            // Bir string dizimiz var..Bu dizi "ters" sırada ekrana yazdırınız

            // rverse kullanmadan da yapabilirsiniz.

            // length kullanın...

            string[] MyUCC09Team = { "Çekdar", "Ahmet", "Nur Sena", "Emre", "Bilge", "Tarık", "Berktan","Alper","Eyüp","Öykü","Hazal","Umut","Berkay","Abdullah","Ayça","Erhan","scrat"};

            int diziIndex = MyUCC09Team.Length - 1; // dizimin boyunca indeximi kaydırmak için.Dizi indexleri 0 dan başladığı için -1

            for (int i = diziIndex; i >=0; --i)
            {
                Console.WriteLine("Elemanın adı : {0}\n\n",MyUCC09Team[i] );
            }










            #endregion


        }
    }
}
