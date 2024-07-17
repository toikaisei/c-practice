using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Counter
    {
        //  カウント
        public static int totalCount = 0;
        private int count = 0;

        //  コンストラクタ
        public void Reset()
        {
            count = 0;
        }
        //  カウントのインクリメント
        public void Increment()
        {
            count++;
            totalCount++;
        }
        //  回数のプロパティ
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int totalCounter
        {
            get { return totalCount; }
        }
    }
}
