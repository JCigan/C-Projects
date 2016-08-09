using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceThis
{
    struct XYValuePoint
    {
        //struct is value type
        public int x, y;

        public XYValuePoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }

    class ReferencePoint
    {
        public int a, b;

        //class is reference type
        public ReferencePoint(int a = 0, int b = 0)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            XYValuePoint p1 = new XYValuePoint();
            ReferencePoint r1 = new ReferencePoint();

            p1.X = 100;
            r1.A = 50;

            r1 = null;

            Console.WriteLine(p1.X);
        }
    }
}