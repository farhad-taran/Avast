using Core;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Input a valid number (type EXIT to terminate): ");
                input = Console.ReadLine();

                if (int.TryParse(input, out var value))
                {
                    var table = PrimesHelper.GetPrimesTable(value);
                    Console.WriteLine();
                    Console.WriteLine(PrimesTableParser.ParseToString(table));
                    Console.WriteLine();
                }

            } while (input.ToUpper() != "EXIT");
        }
    }
}
