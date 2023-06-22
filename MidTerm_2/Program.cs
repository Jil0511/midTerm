using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Select one option: ");
                string input = Console.ReadLine();
                PixelCalc pixelCalc = new PixelCalc();
                if (input == "1" || input == "2")
                {
                    switch (input)
                    {
                        case "1":
                            pixelCalc.calculator();
                            break;

                        case "2":
                            System.Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}

