using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 1, 2, 3, 4, 5, 6 };

            foreach (int grade in grades)
            {
                Console.WriteLine("The grade is {0}" , grade);
            }

            Console.WriteLine("Numbers of a different array:");

            int odd = 0, even = 0;

            int[] numbers = new int [] { 0, 1, 2, 5, 7, 9, 11 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numbers)
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

            Console.WriteLine("Found {0} odd numbers and {1} even numbers in the array.", odd, even);
            Console.WriteLine("");

            int odd01 = 0; 
            int even01 = 0;

            int[] numbers01 = new int[] { 1162, 2142, 1141, 1142, 2305, 6581, 6580 };

            Console.Write("These are the zip codes:");
            Console.WriteLine("");
            foreach (int num01 in numbers01)
            {
                Console.WriteLine(num01);
            }

            foreach (int num01 in numbers01)
            {
                if (num01 % 2 == 0)
                {
                    even01++;
                }
                else
                {
                    odd01++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Found {0} odd zip code, and {1} even zip code in the array", odd01, even01);
            Console.ReadLine();
        }


    }
}
