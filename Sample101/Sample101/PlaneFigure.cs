using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    abstract class PlaneFigure
    {
        //  面積
        protected double area = 0;
        //  幅
        protected double width = 0;
        //  高さ
        protected double height = 0;

        public PlaneFigure() { }
        public PlaneFigure(double width, double height) {
            this.width = width;
            this.height = height;
        }
        public abstract double Area { get; }



    }
}
