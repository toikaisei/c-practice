using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Programs
    {
       
        public Programs(int id)
        {
           
        }
        public static void Add(int a, int b)
        {
             Console.WriteLine("{0} + {1} = {2}",a, b,  a + b);
        }
        public static void Sub(int a, int b) {
             Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }
}
