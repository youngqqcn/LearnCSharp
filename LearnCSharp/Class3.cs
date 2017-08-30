using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class VirtualShape
    {
        protected int width, height;

        public VirtualShape(int w, int h)
        {
            width = w;
            height = h;
        }

        public virtual int area()
        {
            Console.WriteLine("Shape()");
            return 0;
        }
    }

    class Rect :VirtualShape
    {
        //protected int width, height;

        public Rect(int w, int h):base(w, h)
        {
            width = w;
            height = h;
        }

        public override int area()
        {
            return width * height;
        }

    }

    class Tria : VirtualShape
    {
        public Tria(int w, int d):base(w, d)
        {
        }

        public override int area()
        {
            return width * height;
        }
    }


    class Tester
    {
        static void Main(string []args)
        {
            Rect rect = new Rect(324, 42342);
            Console.WriteLine(rect.area());

            Tria tria = new Tria(22, 43242);
            Console.WriteLine(tria.area());

            Console.Read();

        }

    }




}
