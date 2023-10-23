using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class Sample1
    {
        public static void Main(string[] args)
        {
            // Dikdörtgenin alanını hesaplayan bir metodun 4 farklı şekilde kullanılması

            #region 1.Geriye değer döndürmeyen ve parametre almayan metot
            Hesapla();
            #endregion

            #region 2.Geriye değer döndürmeyen ve parametre alan metot

            #endregion

            #region 3.Geriye değer döndüren ve parametre almayan metot

            #endregion

            #region 4.Geriye değer döndüren ve parametre alan metot

            #endregion

        }

        // Metot bölgesi

        private static void Hesapla() // 1.region
        {
            Console.WriteLine("Kısa kenar : ");
            int kk=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenar : ");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            Console.WriteLine("Alan : {0} dır", alan );
        }
    }
}
