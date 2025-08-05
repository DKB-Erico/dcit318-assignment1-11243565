using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double side1, side2, side3;

                Console.WriteLine("Enter the value of the first side of the triangle: ");
                string input1 = Console.ReadLine();

                Console.WriteLine("Enter the value of the second side of the triangle: ");
                string input2 = Console.ReadLine();

                Console.WriteLine("Enter the value of the third side of the triangle: ");
                string input3 = Console.ReadLine();

                if (!double.TryParse(input1, out side1) || !double.TryParse(input2, out side2) || !double.TryParse(input3, out side3) || side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter positive numbers only.");
                }
                else if ((side1 + side2 <= side3) || (side1 + side3 <= side2) || (side2 + side3 <= side1))
                {
                    Console.WriteLine("The values do not form a valid triangle.");
                }
                else
                {
                    if (side1 == side2 && side1 == side3 && side2 == side3)
                    {
                        Console.WriteLine("The triangle is an Equilateral.");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("The triangle is an Isoceles.");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is a Scalene.");
                    }
                }

                Console.Write("Press 1 to check another triangle or press Enter to exit: ");
                string choice = Console.ReadLine();

                if (choice != "1")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}

