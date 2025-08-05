using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                int age;

                if (!int.TryParse(input, out age) || age < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid (non-negative) age.");
                }
                else
                {
                    if (age <= 12 || age >= 65)
                    {
                        Console.WriteLine("Ticket price: GHC7.00 (Discounted)");
                    }
                    else
                    {
                        Console.WriteLine("Ticket price: GHC10.00 (Regular)");
                    }
                }

                Console.Write("Press 1 to calculate another ticket price or press Enter to exit: ");
                string choice = Console.ReadLine();

                if (choice != "1")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
