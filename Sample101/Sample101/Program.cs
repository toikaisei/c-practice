using System;
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
            Animal[] animals = new Animal[2];
            animals[0] = new Dog();     //  犬クラスのインスタンス生成
            animals[1] = new Monkey();  // 猿クラスのインスタンスの生成
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Move();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
        }
    }
}
