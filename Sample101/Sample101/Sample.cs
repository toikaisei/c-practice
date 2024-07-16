using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }
         ~Sample() {
            Console.WriteLine("エンド");
        }
        public void func()
        {
            Console.WriteLine("func");
        }
        
    }
}
