using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Arrays
{
    internal class CokBoyutluDizi
    {
        public static void Main(string[] args)
        {
            #region Çok boyutlu diziler

            int[,] dizi9 = new int[3, 2]; // 2 boyutlu dizi

            int[,] dizi10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            int[,,] dizi11 = new int[3, 2, 2]; // 3 boyutlu dizi

            int[,,] dizi12 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };

            // Dizi elemanlarını for döngüsü ile değiştirmek

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        dizi12[i, j, k] = 20;

            // Düzensiz diziler
            int[][] dizi13 = new int[3][];
            dizi13[0] = new int[3];
            dizi13[1] = new int[4];
            dizi13[2] = new int[2];


            #endregion
        }

    }
}
