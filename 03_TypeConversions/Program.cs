namespace _03_TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bilinçsiz tür dönüşümü örnekleri

            byte a=10;

            short b = 20;

            sbyte c = 30;

            int d = a + b + c; // bilinçsiz tür dönüşümü otomatik olarak yapıldı

            Console.WriteLine("Toplam = " + d.ToString() + "\n\n\n");

            string e = "Arı Bilgi UCC09 Team";

            char f = 'A';

            object g = e + " " + f + " " + d; // farklı veri türleri tutabilen object tipi

            long h = d;

            float i = h;

            double j = i;

            double k = 21.6;

            float l = (float)h + (float)k;

            Console.WriteLine("1.durum : " + d.ToString() + "\n\n");

            Console.WriteLine("2.durum : " + g.ToString() + "\n\n");

            Console.WriteLine("3.durum : " + l.ToString() + "\n\n");

            // Bilinçsiz Tür dönüşümünde ilginç bir durum - char veri tipi için
            // 


            char m = 'H';

            int n = m;

            Console.WriteLine("4.durum : " + n +"\n\n");

            // Bilinçsiz tür dönüşüm örnekleri

            int r = 15000;

            byte s = (byte)r; // ????????? weekend arastırması

            Console.WriteLine("5.durum : " + s + "\n\n");

            Console.WriteLine("6.durum : " + r.ToString() + "\n\n");

            Console.ReadKey();
        }
    }
}