using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Point
    {
        //class members
        private double x;
        private double y;

        //properties
        public double X
        {
            set { x = value; }
            get { return x; }
        }
        public double Y
        {
            set { y = value; }
            get { return y; }
        }

        //constructors
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double Xx, double Yy)
        {
            X = Xx;
            Y = Yy;
        }


        public double calcDistance()
        {
            return Math.Sqrt(X * X + Y * Y);

        }


    }
}
