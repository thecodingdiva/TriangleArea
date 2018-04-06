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
            Console.WriteLine("Calculate the Area of a Triangle: \n");
            try
            {
                Console.WriteLine("Enter side a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a <= 0)
                {
                    throw new FormatException("Number not in range.");
                }
                else
                {
                    Console.WriteLine("Enter side b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    if (b <= 0)
                    {
                        throw new FormatException("Number not in range.");
                    }
                    else
                    {
                        Console.WriteLine("Enter side c: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        if (a <= 0 || b <= 0 || c <= 0)
                        {
                            throw new FormatException("Number not in range.");
                        }
                        else
                        {
                            double p = (a + b + c) / 2;
                            double Area = checked(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

                            if (Area == 0)
                            {
                                throw new Exception("Not a Triangle");
                            }
                            else
                            {
                                Console.WriteLine("The area for the triangle is: " + Area);
                            }
                        }
                    }
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("Your input is invalid.");
            }
            catch (Exception e1)
            {
                Console.WriteLine("Your input will not be a triangle.");
            }
            finally
            {
                Console.WriteLine("Your program has terminated");
            }
        }
    }
}
