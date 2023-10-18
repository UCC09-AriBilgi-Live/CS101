using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlowMechanism
{
    internal class SwitchCase
    {
        public static void Main(string[] args)
        {
            Console.Clear();  // ekranı temizler

            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*    SWITCH-CASE ÖRNEKLERİ            *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\n\n");


            // Ekrandan sadece 1 ve 7 arası değer girilmesi durumunda haftanın hangi günü olduğunu ekrana yazan program.

            //int gun;

            //Console.WriteLine("Lütfen gün numarasını giriniz : ");
            //gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1: // case
            //        Console.WriteLine("{0}.gün Pazartesi'dir", gun);
            //        break;
            //    case 2:
            //        Console.WriteLine("{0}.gün Salı'dır", gun);
            //        break;
            //    case 3:
            //        Console.WriteLine("{0}.gün Çarşamba'dır", gun);
            //        break;
            //    case 4:
            //        Console.WriteLine("{0}.gün Perşembe'dir", gun);
            //        break;
            //    case 5:
            //        Console.WriteLine("{0}.gün Cuma'dır", gun);
            //        break;
            //    case 6:
            //        Console.WriteLine("{0}.gün Cumartesi'dir", gun);
            //        break;
            //    case 7:
            //        Console.WriteLine("{0}.gün Pazar'dır", gun);
            //        break;


            //    default:
            //        Console.WriteLine("Lütfen 1 ila 7 arasında bir değer giriniz...."); 

            //        break;
            //}


            // Bir (switch - case) aka.(yani) SC ..bir SC bloğunda birden fazla aynı case tanımı olamaz...
            // 

            //int g = 4;

            //switch (g)
            //{
            //    case 4:
            //        Console.WriteLine("sayınız {0}",g);
            //        break;

            //    case 4:

            //    default:
            //        break;
            //}

            // Olura eğer bir case içersinken gerektiğinde o SC bloğunun içindeki başka bir case seçeneğine gitmek gerekiyorsa "goto" anahtar kelimesi kullanılır...

            //int j = 5;

            //switch (j)
            //{
            //    case 4:
            //        string k1=Console.ReadLine();
            //        string k2 = Console.ReadLine();
            //        Console.WriteLine("Değer1 = {0}, Değer2 = {1}",k1,k2  );
            //        break;
            //    case 5:
            //        Console.WriteLine("Şimdi farklı bir yere yönlendiriliyorsunuz..."  );
            //        goto case 4;



            //    default:
            //        Console.WriteLine("deneme");
            //        break;
            //}

            string komut;

            Console.Write("Komutunuzu giriniz : ");

            komut=Console.ReadLine();

            switch (komut) 
            {
                case "AÇ":
                case "aç":
                    Console.WriteLine(  "Bilgisayar açılıyor...");
                    break;

                case "uyu":
                    Console.WriteLine("Bilgisayar uyuma moduna geçiyor...");
                    break;

                case "kapat":
                    Console.WriteLine("Bilgisayar kapanıyor...");
                    break;

                default:
                    Console.WriteLine("Komutunuzu anlayamadım...");
                    break;
            }




        }
    }
}
