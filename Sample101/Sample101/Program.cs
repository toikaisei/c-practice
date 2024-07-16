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
            Random r = new Random();
            int a = r.Next(1, 11);  //  aに1から10の乱数を代入
            int b = r.Next(1, 11);  //  bに1から10の乱数を代入
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine()); //コンソールから値を入門
            int result = Programs.Mul(a, b, c);  //  3つの数の積を求める
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a * b * c = {0}", result);
        }
    }
}
