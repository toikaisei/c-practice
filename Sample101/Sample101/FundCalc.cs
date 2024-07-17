﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class FundCalc
    {
        private double number1 = 0.0;   //  一つ目の数
        private double number2 = 0.0;   //  二つ目の数
        //  number1のプロパティ
        public double Number1
        {
            set { number1 = value; }
            get { return number1; }
        }
        //  number2のプロパティ
        public double Number2
        {
            set { number2 = value; }
            get { return number2; }
        }
        //  二つの数の和を出力
        public double Add()
        {
            return number1 + number2;
        }
        //  二つの数の差を出力
        public double Sub()
        {
            return number1 - number2;
        }
    }
}
