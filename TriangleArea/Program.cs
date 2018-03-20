using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 6;
            double c = 7;

            double p = (a + b + c) / 2;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine(Area);
        }
    }
}
