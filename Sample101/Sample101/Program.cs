﻿using System;
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
            Data d = new Data();
            d.Number = 100;
            d.Comment = "Programming C#";
            Console.WriteLine("number = " + d.Number);
            Console.WriteLine("comment = " + d.Comment);
        }
    }
}
