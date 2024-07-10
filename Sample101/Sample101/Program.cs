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
            //長さ5のint型の配列を作成する
            int[] array = new int[5];
            //乱数を作る為のrandオブジェクト生成
            Random rand = new Random();

            //配列に格納した値を全て出力させるループ
            for (int i = 0; i < array.Length; i++) {
                //arrayに、1から100までの乱数を代入する。
                array[i] = rand.Next(1, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            Console.Write("\n0以上60未満:");
            //0以上60未満の,値のみ出力
            for (int i = 0; i < array.Length; i++) {
                if (array[i] >= 0 && array[i] < 60) {
                    Console.Write(array[i] + " ");
                }
            }
            Console.Write("");
            Console.Write("\n60以上80未満:");
            //60以上80未満の,値のみ出力
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 60 && array[i] < 80)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.Write("");
            Console.Write("\n80以上:");
            //80以上の,値のみ出力
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 80)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
            Console.Write("");

        }
    }
}