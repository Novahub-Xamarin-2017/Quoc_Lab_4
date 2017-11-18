using System;

namespace ex_7
{
    public class Triangle : ICompare<Triangle>
    {
        public int EdgeA { get; set; }
        public int EdgeB { get; set; }
        public int EdgeC { get; set; }


        public Triangle()
        {
        }

        public Triangle(int a, int b, int c)
        {
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }

        public double GetPerimeter() => EdgeA + EdgeB + EdgeC;

        public double GetArea()
        {
            var p = GetPerimeter() / 2.0;
            return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
        }

        public bool IsBigger(Triangle another) => this.GetArea() > another.GetArea();

        public override string ToString() => GetArea().ToString();
    }
}