using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_委托的调用
{
    //声明委托类型
    delegate void MyDel(int x);

    //声明一个类
    class MyInstObj
    {
        public void MyM1(int x)
        {
            Console.WriteLine("实例方法:x="+x);
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
            MyDel delVar, dVar;

            //实例化对象
            MyInstObj myInstObj = new MyInstObj();

            //创建委托并保存引用 - 第一种方法
            delVar = new MyDel(myInstObj.MyM1);//实例方法
            dVar = new MyDel(MyInstObj.OtherM2);//静态方法

            //创建委托引用包保存 - 第二种方法
            delVar = myInstObj.MyM1; //实例方法
            dVar = MyInstObj.OtherM2;//静态方法

            //第二种方法是一种快捷方法，它仅仅由方法说明符组成。和方法一的代码是等价的。这种快捷语法能够工作是因为在方法名称和其相应的委托类型之间存在隐式转换

            //调用
            delVar(1);
            dVar(2);

            Console.ReadLine();

        }
    }
}
