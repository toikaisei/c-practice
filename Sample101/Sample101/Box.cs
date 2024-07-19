using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Box : PlaneFigure
    {
        
        //  コンストラクタ（引数なし）
        public Box(){ }
        //  コンストラクタ（引数あり）
        public Box(double width, double height) : base(width, height){ }
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
