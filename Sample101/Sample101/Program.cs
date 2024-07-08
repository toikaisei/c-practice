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
            //長さ7のint型の配列を作成する
            int[] array = new int[7];
            //乱数を作る為のrandオブジェクト生成
            Random rand = new Random();

            //配列に格納した値を全て出力させるループ
            for (int i = 0; i < array.Length; i++) {
                //array1から10までの乱数を代入する。
                array[i] = rand.Next(1, 11);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            //arrayに入った数字分＊を出力
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
           


        }
    }
}