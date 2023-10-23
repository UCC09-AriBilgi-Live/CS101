namespace _08_ErrorControls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hata oluşturabilecek bir durum örneği

            //int a = 100, b = 0;

            //Console.WriteLine("Sonuç : ", a / b); 

            #endregion

            #region Hata Avcısı
            int c , d ;

            c = Convert.ToInt32(Console.ReadLine());  
            d = Convert.ToInt32(Console.ReadLine());


            try
            {
                Console.WriteLine("Sonuç : ", c / d); // burayı çalıştırmayı bir dene...try
            }
            catch
            {
                if (c != 0 && d == 0)
                {
                    d = c / 10;
                    //Console.WriteLine("Şimdi sonuç : {0} : ", c / d);
                }
                else if (c == 0 && d != 0) 
                {
                    c = d * 10;
                    //Console.WriteLine("Şimdi sonuç : {0} : ", c / d);
                } 
                else if(c == 0 && d == 0)
                {
                    c = 50;
                    d = 5;


                }
               
            }
            finally
            {
                Console.WriteLine("Şimdi sonuç : {0} : ", c / d);
            }

            #endregion

            // derste bahsetmiştik ama örnek yapmamış idik...
            #region Hata Metotları

            byte deger;

            try
            {
                Console.Write("Byte tipinde bir değer girin: ");

                deger = Convert.ToByte(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("-> Message: {0}\n-> Source: {1}\n-> StackTrace: {2}\n-> TargetSite: {3}\n",
                    e.Message, e.Source, e.StackTrace, e.TargetSite);
            }

            #endregion


            #region Başka bir örnek


            int bolunecek, bolen;

            try
            {
                Console.Write("-> Bölünecek Değeri Girin: ");

                bolunecek = Convert.ToInt32(Console.ReadLine());

                Console.Write("-> Bölen Değeri Girin: ");

                bolen = Convert.ToInt32(Console.ReadLine());

                double sonuc = (bolunecek / bolen);

                Console.WriteLine("-> {0} değerinin {1} değerine bölümünün sonucu: {3}", bolunecek, bolen, sonuc);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n-> Hata! Sıfıra bölüm işlemi gerçekleştirilemez.\n-> Hata Mesajı: {0}\n", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n-> Hata! Sadece Int32 türünde veri girişi yapabilirsiniz.\n-> Hata Mesajı: {0}\n", e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\n-> Hata! Değişgen sınırların aştınız.\n-> Hata Mesajı: {0}\n", e.Message);
            }
            catch (Exception e) // Geri kalan tüm hata durumlarını kapsar
            {
                Console.WriteLine("\n-> Beklenmedik Bir Hata!\n-> Hata Mesajı: {0}\n", e.Message);
            }
            finally
            {
                Console.WriteLine("-> Finally Bloğu Çalışıyor.\n");
            }

            #endregion
        }
    }
}