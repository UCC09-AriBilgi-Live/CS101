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
        }
    }
}