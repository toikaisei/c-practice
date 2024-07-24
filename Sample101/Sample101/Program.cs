using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Program
    {
        //  デリゲート
        delegate void Delfunc();
        static void Func1()
        {
            Console.WriteLine("Func1");
        }
        static void Func2()
        {
            Console.WriteLine("Func2");
        }
        static void Main(string[] args)
        {
            Delfunc df = new Delfunc(Func1);
            Delfunc df2 = new Delfunc(Func2);
            df2();
        }

    }    
}
