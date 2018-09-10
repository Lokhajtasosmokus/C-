using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Give me a number");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
            Console.WriteLine("Even number");
            }

            else 
            { Console.WriteLine("Odd number");
            }

            Console.ReadKey();
        }
    }
}
