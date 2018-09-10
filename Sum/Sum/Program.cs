using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer

            Console.WriteLine(Sum());
            Console.ReadLine();
        }

         public static int Sum()
        {
            int sum = 0;
            int numberOfSummedElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSummedElements; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            return sum;
        }
    }
}
