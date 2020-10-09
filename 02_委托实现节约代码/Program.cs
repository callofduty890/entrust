using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02_委托实现节约代码
{

    delegate int algorithm(int a, int b);

    class Program
    {
        public static int TEST(int a, int b, algorithm function)
        {
            //调用委托
            return function(a, b);
        }
        //加法
        public static int addition(int a, int b)
        {
            return a + b;
        }
        //减法
        public static int sub(int a, int b)
        {
            return a - b;
        }
        //乘法
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        //除法
        public static int division(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            int Number1 = 2;
            int Number2 = 3;
            //调用加法
            Console.WriteLine(Number1 + "+" + Number2 + "=" + TEST(Number1, Number2, addition));
            //调用减法
            Console.WriteLine(Number1 + "-" + Number2 + "=" + TEST(Number1, Number2, sub));
            //调用乘法
            Console.WriteLine(Number1 + "*" + Number2 + "=" + TEST(Number1, Number2, Multiplication));
            //调用除法
            Console.WriteLine(Number1 + "/" + Number2 + "=" + TEST(Number1, Number2, division));

            //
            Console.ReadKey();

        }
    }
}
