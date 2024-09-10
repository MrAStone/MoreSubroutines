using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreSubroutines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 32 and 82");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (InRange(userInput))
            {
                Console.WriteLine("The number is in range");
            }
            else
            {
                Console.WriteLine("The number is not in range");
            }
        }

        static bool InRange(int input)
        {
            if (input>=32 && input <= 82)
            {
                return true;
            }
            return false;
            Console.WriteLine("This code will never run!");
        }
    }
}
