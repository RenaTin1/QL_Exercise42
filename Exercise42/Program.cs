using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> AllPoints = new List<Point>();

            Console.WriteLine("Please enter an X Coordinate:");
            double Xx = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an Y Coordinate:");
            double Yy = double.Parse(Console.ReadLine());

            Point MyPoints = new Point(Xx, Yy);

            Console.WriteLine($"You have created a point object({Xx},{Yy})");
            Console.WriteLine(MyPoints.calcDistance());

        }

    }
}

