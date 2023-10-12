namespace _02_VariableWorld
{    

    internal class Program
    {

        static void Main(string[] args) // Console programlarının ilk giriş noktası burasıdır.
        {
            // İlk tanımlamalar yapılıyor...

            #region İlk örnek
            //string name = ""; // ben burada hem değişgeni tanımladım hem de ilk değerini atatım

            //string nameDesc;

            //string Name;

            //string NameDesc;

            //// Değişgenlere değerler atanıyor....

            //name = "Nurgül Karaçivi"; // name isimli değişgene değer atadım.

            //nameDesc = "Benim adım : ";

            //NameDesc = "Kızımın adı : ";

            //Name = "Doğa Bengi KARAÇİVİ";

            //// Şimdi bunları yazdıralım

            //Console.WriteLine(nameDesc + name); // dynamic kullanım
            //Console.WriteLine("Ümit KARAÇİVİ"); // static kullanım


            #endregion

            //#region değişgenlere devam
            //// değişgenlere devam

            //byte a = 100;

            ////byte b = 300; byte sınırları aşan bir değer verildiği için hata verir.

            //byte c = 200;

            //int toplam = a + c;

            //Console.WriteLine("Toplam = " + toplam.ToString()); // CW string yazabildiği için int bir değeri tostring ile karaktere ceviriyorum.

            //#endregion


            #region Ekrandan bilgi alma ve ekrana yazdırma, escape character kullanımı

            //string namesname="";

            //Console.WriteLine("Lütfen sizden rica etsem adınızı soyadınızı girer misiniz? \n\n");

            //Console.WriteLine("\t\t");

            //namesname=Console.ReadLine();

            //Console.WriteLine("\n\n\nHoşgeldiniz...Sizi gördüğüme çok sevindim sayın " + namesname);

            #endregion

            // Sıklıkla yapılan hatalar..
            //
            // - Aynı satırda farklı veri türünden değişgen tanımlamaya çalışma

            // int sayi1, string ad; yanlış kullanım.

            // - Değişgene uygunsuz değer ataması yaparken

            //int n;

            //n = "ali";

            // - değişgeni tanımlamadan ve/veya ilk değer vermeden değişgeni kullanmaya çalıştığımız

            //int b = 5;

            //Console.WriteLine(a);

            // - Değişgen tanımlamasını ve/veya değer atamasını yanlış yerde yapma 

            // - bazı değişgen türlerinde değişgenlere değer atarken bazı özel eklenmesi gereken belirteçleri eklememek (float)

            decimal e = 25.4M;

            Console.WriteLine(e);


            Console.ReadKey();
        }
    }
}