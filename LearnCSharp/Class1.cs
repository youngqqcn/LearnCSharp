using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 多态: 即"一个接口, 多个功能" 
 * 
 * 静态多态: 在编译时, 函数重载,运算符重载
 * 动态多态: 在运行时, 抽象类
 * 
 *
 */



namespace LearnCSharp
{
    class Class1
    {
        void Print(int i)
        {
            Console.WriteLine("integer:" + i);
        }

        void Print(float f)
        {
            Console.WriteLine("float: " + f);
        }

        void Print(double d)
        {
            Console.WriteLine("double " + d);

        }

        void Print(string s)
        {
            Console.WriteLine("string:" + s);
        }

        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Print(3424);
            c1.Print(43423.2432);
            c1.Print("hello world");

            Console.Read();

        }
        

    }
}
