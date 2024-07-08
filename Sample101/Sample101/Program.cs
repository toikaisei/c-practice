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
            //長さ10のint型の配列を作成する
            int[] array = new int[10];
            //0の個数を保持するための変数
            int zero = 0;
            //乱数を作る為のrandオブジェクト生成
            Random rand = new Random();

            //配列に格納した値を全て出力させるループ
            for (int i = 0; i < array.Length; i++) {
                //array0から100までの乱数を代入する。
                array[i] = rand.Next(0, 101);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n50以上の数:");
            for (int i = 0; i < array.Length; i++) {
                //arrayに格納された値が50以上のみ出力
                if (array[i] > 50)
                {
                    Console.Write(array[i] + " ");
                }
                //arrayに格納された値が0と等しければzeroをインクリメント
                else if (array[i] == 0) {
                    zero++;
                }          
            }
            Console.Write("\n50以下の数:");
            //50以下の値を出力するループ
            for (int i = 0; i < array.Length; i++) {
                //arrayに格納された値が50以下のみ出力
                if (array[i] < 50) {
                    Console.Write(array[i] + " ");
                }
            }
            //arrayに0が格納されいる0の個数を出力
            Console.Write("\n0の個数:" + zero);
            Console.WriteLine("");


        }
    }
}