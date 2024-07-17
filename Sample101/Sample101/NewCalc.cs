using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class NewCalc : FundCalc
    {
        private double number1;
        private double number2;
        public double Mul(double number1, double number2) {
            return number1 * number2;
        }
        public double Div(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
