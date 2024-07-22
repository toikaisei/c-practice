using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomValue;
            int result;
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            Random r = new Random();

            //乱数で出た値が、0になるまで繰り返し出力するループ
            while (true) {
                //0～10の乱数生成
                randomValue = r.Next(0, 11);
                result = randomValue % 2;
                //出力された整数を(偶数)をListに格納
                if (randomValue == 0)
                {
                    Console.WriteLine("0で終了" + randomValue);
                    break;
                }
                //出力された整数を(奇数)をListに格納
                else if (result != 0)
                {
                    oddNumbers.Add(randomValue);
                    Console.WriteLine("奇数0～10の値を出力:" + randomValue);
                }
                //0が出たら終了
                else if (result == 0)
                {
                    evenNumbers.Add(randomValue);
                    Console.WriteLine("偶数0～10の値を出力:" + randomValue);
                }
            }
            Console.WriteLine();
            //Listに格納した偶数を出力
            Console.Write("偶数:");
            foreach (int i in evenNumbers) {
                Console.Write(i + "" + ",");
            }
            Console.WriteLine();

            //Listに格納した奇数を出力
            Console.Write("奇数:");
            foreach (int i in oddNumbers)
            {
                Console.Write(i + "" + ",");
            }
            Console.WriteLine();


        }
       
    }    
}
