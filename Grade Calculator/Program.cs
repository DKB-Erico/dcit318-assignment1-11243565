using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your score (0 - 100): ");
                int score;

                if (!int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    continue;
                }
                else
                {
                    if (score >= 90)
                    {
                        Console.WriteLine("Your grade is A.");
                    }
                    else if (score >= 80)
                    {
                        Console.WriteLine("Your grade is B.");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine("Your grade is C.");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine("Your grade is D.");
                    }
                    else
                    {
                        Console.WriteLine("Your grade is F.");
                    }
                }

                Console.Write("Press 1 to enter another score or just press Enter to exit: ");
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
