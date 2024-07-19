using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Triangle : PlaneFigure
    {
       
        public Triangle(){ }
        //  コンストラクタ（引数あり）
        public Triangle(double width, double height) : base(width, height){ }

        //  幅のプロパティ
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        //  高さのプロパティ
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        //  面積の取得
        public override double Area
        {
            get { return width * height; }
        }
    }
}
