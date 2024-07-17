using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Calc
    {
        public Calc() {

        }
        //静的メソッドSquare生成、引数に整数の値×2（縦、横の値）
        public static void Square(int lengthNum, int sideNum) {
            Random r = new Random();
            //1から10の、2つの乱数を発生させる
            lengthNum = r.Next(1, 11);
            sideNum = r.Next(1, 11);
            //縦、横の値を出力
            Console.WriteLine("縦:" + lengthNum);
            Console.WriteLine("横:" + sideNum);
            //処理内容(縦、横に指定された数の■マークを表示する。ただし、どちらかの値が0以下の場合は、何も表示しない)
            for (int i = 1; i <= lengthNum; i++) {
                for (int j = 1; j <= sideNum; j++) {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}
