using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_9_代码
{
    delegate void MyDel(int value);//声明委托

    class Program
    {

        static void Main(string[] args)
        {
           void printLow(int value)
        {
            Console.WriteLine("{0}-Low Value", value);
        }
        void PrintHight(int value)
        {
            Console.WriteLine("{0}-Hight Value",value);
        }         

            void PrintNumber(double value)
            {
                Console.WriteLine("{0}-Value", value);
            }
            //创建一个随机数
            Random rand = new Random();
            int randValue = rand.Next(99);

            //声明委托
            MyDel del;
            //使用委托

            del = randValue < 50 ? new MyDel(printLow) : new MyDel(PrintHight);
            
            //执行委托
            del(randValue);

            Console.ReadKey();
        }
    }
}
