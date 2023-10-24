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
            //Hesapla();
            #endregion

            #region 2.Geriye değer döndürmeyen ve parametre alan metot
            // Kullanıcıdan giriş alarak.

            //Console.WriteLine("Kısa kenar : ");
            //int kk = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uzun kenar : ");
            //int uk = Convert.ToInt32(Console.ReadLine());

            //Hesapla(kk, uk);


            #endregion

            #region 3.Geriye değer döndüren ve parametre almayan metot

            int sonuc = HesaplaPrmsiz();

            Console.WriteLine("Alan : {0}",sonuc);

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

        private static void Hesapla(int kisa,int uzun)
        {
            int alan = kisa * uzun;

            Console.WriteLine("Dikdörtgen alanı (metot-geri dönüş yok-parametre var..direkt buradan basıyor) {0}dır", alan);
        }

        private static int HesaplaPrmsiz()
        {
            // Geriye bir değer döndürecek metotlarda mutlaka ve mutlaka bir return keyword ü olmalıdır ki değeri çağrılan yere postalayabilsin.

            Console.WriteLine("Kısa kenar : ");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenar : ");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            return alan;
        }
    }
}
