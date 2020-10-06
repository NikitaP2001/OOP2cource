using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    abstract class Triangle
    {
        public virtual double Area()
        {
            return (a * b * Math.Sin(q) / 2);
        }
        public virtual double Perimetr()
        {
            double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(q));
            return Math.Round(a + b + c, 2);
        }
        double q;   //Corner between a and b in radians
        double a;    //Two sides of triangle
        double b;
    }
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double Side, double Angle)
        {
            a = Side;
            q = Angle;
        }
        public override double Area()
        {
            return Math.Round((a * a * Math.Sin(q) / 2), 2 );
        }
        public override double Perimetr()
        {
            double c = Math.Sqrt(2 * a * a * (1 - Math.Cos(q)));
            return Math.Round(2 * a + c, 2);
        }
        double q;   //Angle between two sides in radians
        double a;    //Side of triangle
    }
    class RightTriangle : Triangle
    {
        public RightTriangle(double Side1, double Side2)
        {
            a = Side1;
            b = Side2;
        }
        public override double Area()
        {
            return Math.Round((a * b / 2));
        }
        public override double Perimetr()
        {
            double c = Math.Sqrt(a * a + b * b);
            return Math.Round(a + b + c, 2);
        }
        double a;    //Sides of triangle
        double b;
    }
}
