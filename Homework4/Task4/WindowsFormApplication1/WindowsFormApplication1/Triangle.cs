using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WindowsFormApplication1
{
    class Triangle
    {
        public class Side
        {
            double _length;
            public double length
            {
                set
                {
                    _length = value;
                } 
                get
                {
                    return _length;
                }
            }  
        }
        public List<Side> TriangleSide = new List<Side>()
        {
            new Side(),
            new Side(),
            new Side(),
        };
        public double Perimetr
        {
            get
            {
                return Math.Round(TriangleSide[0].length + 
                    TriangleSide[1].length + 
                    TriangleSide[2].length,3);
            }
        }
        double CountSizeOfCorner(double a, double b, double c)
        {
            return Math.Round(Math.Acos((b*b + c*c - a*a) /     //Count angle in radians 
                ( 2 * b * c )),3);                                 
        }
        public double CornerSizeBetween(Side a, Side b) {
            int i = 3;                        //detecting third side of triangle 
            i -= TriangleSide.IndexOf(a);
            i -= TriangleSide.IndexOf(b);  //now in i we hawe third side index
            if (i >= 0)
            {
                return CountSizeOfCorner(TriangleSide[i].length, a.length, b.length);
            } else return 0;
        }

    }
    class EquilateralTriangle : Triangle
    {
        
        public double Area
        {
            get
            {
                return Math.Round(((Math.Sqrt(3) * TriangleSide[0].length * TriangleSide[0].length) / 4),4);
            }
        }
    }
}

