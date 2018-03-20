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
            Console.WriteLine("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine(Area);
        }
    }
}
