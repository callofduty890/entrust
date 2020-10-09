using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_组合委托
{
    //声明委托类型
    delegate void MyDel(int x);

    //声明一个类
    class MyInstObj
    {
        public void MyM1(int x)
        {
            Console.WriteLine("实例方法:x=" + x);
        }
        public static void OtherM2(int x)
        {
            Console.WriteLine("静态方法:x=" + x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //
            MyDel delA, delB;
            //实例化对象
            MyInstObj myInstObj = new MyInstObj();

            //创建委托引用 - 第二种方法
            delA = myInstObj.MyM1; //实例方法
            delB = MyInstObj.OtherM2;//静态方法

            MyDel delC = delA + delB;

            delC(1);

            Console.ReadKey();
        }
    }
}
