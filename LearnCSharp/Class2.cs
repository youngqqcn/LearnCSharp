using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *动态多态: 虚方法 和 抽象方法 
 * 
 * 
 * 
 * 
 * 
 **/

namespace LearnCSharp
{
    abstract class Shape 
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int width = 0;
        private int height = 0;
        public Rectangle(int w = 0,  int h = 0)
        {
            width = w;
            height = h;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle's Area:");

            return width * height;
        }
    }

    class Triangle : Shape
    {
        private int bottom = 0;
        private int height = 0;

        public Triangle(int b, int h)
        {
            bottom = b;
            height = h;
        }

        public override int area()
        {

            Console.WriteLine("Triangle's Area:");

            return (int)(bottom * height * 0.5);
        }

    }

    class Test
    {

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(55, 23);
            Console.WriteLine("rect area:" + rect.area());

            Console.WriteLine("============");

            Triangle trg = new Triangle(43, 33);
            Console.WriteLine("trg area:" + trg.area());

            Console.Read();
        }

    }



}
