using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text;

namespace WindowsFormsApp1
{
    abstract class Figure
    {
        public virtual double Perimetr()
        {
            return 0;
        }
        public virtual double Area()
        {
            return 0;
        }
    }
    class Triangle : Figure
    {
        public Triangle(double Side1, double Side2, double Side3)
        {
            a = Side1;
            b = Side2;
            c = Side3;
        }
        public override double Area()
        {
            double p = Perimetr() / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }
        public override double Perimetr()
        {
            return a + b + c;
        }
        double a;
        double b;
        double c;
    }
    class Round : Figure
    {
        public Round(double Radius)
        {
            r = Radius;
        }
        public override double Area()
        {
            return Math.Round(pi * r * r / 2, 2);
        }
        public override double Perimetr()
        {
            return Math.Round(pi * r,2);
        }
        const double pi = Math.PI;
        double r;
    }
    class Romb : Figure
    {
        public Romb(double Diagonal1, double Diagonal2)
        {
            d1 = Diagonal1;
            d2 = Diagonal2;
            a = Math.Sqrt(d1 * d1 + d2 * d2) / 2;
        }
        public override double Area()
        {
            return Math.Round(d1 * d2 / 2, 2);
        }
        public override double Perimetr()
        {
            return Math.Round(4 * a, 2);
        }
        double d1;   //diagonals
        double d2;
        double a;   //side of Romb
    }
    class Square : Figure
    {
        public Square(double Side)
        {
            a = Side;
        }
        public override double Area()
        {
            return Math.Round(a * a, 2);
        }
        public override double Perimetr()
        {
            return Math.Round(4 * a, 2);
        }

        double a;   //side of square
    }
}
