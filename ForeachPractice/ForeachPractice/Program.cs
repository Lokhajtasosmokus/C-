using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd = 0;
            int even = 0;

            int[] numbers = new[] { 0, 1, 2, 3, 10, 22, 24, 25};

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine("Found {0} even numbers, and {1} odd numbers", even, odd);
            Console.ReadLine();
        }
    }
}
