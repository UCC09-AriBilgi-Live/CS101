using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class Sample3
    {
        public static void Main(string[] args)
        {
            // Erkeklerin 25 yıl,kadınların da 20 yıl çalıştıktan sonra emekli olacağı varsayılan bir ortamda klavyeden girilen cinsiyet ve sigorta prim gün sayısına göre kişinin emekliliğine ne kadar süresi kaldığını hesaplayan programcığı yazınız...

            // Hints
            // 1 yıl=360 gün kabul edilecek
            // 1 ay=30 gün kabul edilecek
            // Örnek : 1943 gün--> 5 yıl 4 ay 23 gün vardır diycek

            // Bu örnekteki kullanacağınız metoda cinsiyet parametresini de ekleyerek buna göre sonucu ekrana yazdırınız..

            // Yani cinsiyet Erkek ve 6643 gün girdin --> Emekliliğinize 6 yıl 6 ay 17 gün vardır diycek.....

            // önce initial
            int Year = 360;
            int Month = 30;
            int dayCount; // günsayısı
            char gender; // cinsiyet

            Console.WriteLine("Lütfen cinsiyet giriniz (E,K) : ");
            gender = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Lütfen prim gün sayısını giriniz : ");
            dayCount = Convert.ToInt32(Console.ReadLine());

            int year=retirementCalc(gender, dayCount) / Year;
            dayCount %= year;

            int month = retirementCalc(gender, dayCount) / Month;
            dayCount %= month;

            int day = dayCount;

            Console.WriteLine("\n\nEmekliliğinize {0} yıl {1} ay {2} gün kalmıştır..", year, month, day);



        }

        // Metotlar

        private static int retirementCalc(char prmGender,int prmDay)
        {
            // kabuller
            int dayForWoman = 7200;
            int dayForMan = 9000;

            switch (prmGender)
            {
                case 'E':
                    prmDay= dayForMan - prmDay;
                    break;

                case 'K':
                    prmDay= dayForWoman - prmDay;
                    break;

                default:
                    break;
            }


            return prmDay;
        }
    }
}
