using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Person
    {
        //  フィールドname(名前）
        private string name = "";
        //  フィールドage(年齢)
        private int age = 0;
       
        //  コンストラクタ（引数あり）
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name:{0} age:{1}", name, age);
        }
       
      
    }
}
