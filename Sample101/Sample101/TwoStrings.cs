using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class TwoStrings
    {
        private string string1;
        //  二つ目の文字列
        private string string2;
        //  一つ目の文字列を設定
        public string GetConnectedString() {
            return string1 + string2;
//            Console.Write(string1 + string2);
        }
        public string String1
        {
            set { string1 = value; }
            get { return string1; }
        }
        //  一つ目の文字列を設定
        public string String2
        {
            set { string2 = value; }
            get { return string2; }
        }
    }
}
