using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Inheritance
{
    abstract class Geometry
    {
        abstract public void Rect(int h, int w);
        abstract public void Circle(int r);
    }
        class Shape : Geometry
        {
            int area;
            public override void Rect(int h, int w)
            {
                int area = h * w;
                Console.WriteLine(area);
            }
            public override void Circle(int r)
            {
                double area = 3.14 * r * r;
                Console.WriteLine(area);
            }


        }
        class Test1
        {
            static void Main(string[] args)
            {
                Shape s1 = new Shape();
                s1.Circle(5);
                s1.Rect(10, 5);

            }
        }
    
}
