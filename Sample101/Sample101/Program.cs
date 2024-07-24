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
            int[] a = { 0, 1, 2 };
            try {
                //  配列の内容を表示
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine("インデックスが配列の境界外です。");
            }
           
        }
    }
}
