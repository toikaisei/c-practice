using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample103
{
    class Program
    {
        static void Main(string[] args)
        {
            //3×3の二次元配列を作成
            int[,] array = new int[3,3];
            //最大値を保持する変数
            int overnum;
            //最小値を保持する変数
            int undernum;
            int m, n;
            Random rnd = new Random();
            //  二次元配列に値を代入
            for (m = 0; m < array.GetLength(0); m++)
            {
                for (n = 0; n < array.GetLength(1); n++)
                {
                    array[m, n] = rnd.Next(1, 11);
                    Console.Write(array[m, n] + " ");
                }
                Console.WriteLine("");                
            }
            //arrayの最大値を取得
            overnum = array.Cast<int>().Max();
            //arrayの最小値を取得
            undernum = array.Cast<int>().Min();
            Console.Write("\n最大値:" + overnum);
            Console.WriteLine("\n最小値:" + undernum);

        }
    }
}