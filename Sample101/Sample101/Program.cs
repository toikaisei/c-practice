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
            //0の個数を保持するための変数
            int zero = 0;
            //0より大きい値を保持する変数
            int overnum = 0;
            //0より小さい値を保持する変数
            int undernum = 0;
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++) {
                //arrayに-10から10までの乱数を代入する
                array[i] = rand.Next(-10, 11);
                //arrayに格納した値を全て出力
                Console.Write(array[i] + " ");
            }
            for (int i = 0; i < array.Length; i++) {
                
                if (array[i] > 0)
                {
                    overnum++;
                }
                else if (array[i] < 0)
                {
                    undernum++;
                }
                else {
                    zero++;
                }      
            }
            Console.Write("\n0よりも大きい数:" + overnum + "個");
            Console.Write("\n0よりも小さい数:" + undernum + "個");
            Console.Write("\n0よりも小さい数:" + zero + "個");
            Console.WriteLine("");


        }
    }
}