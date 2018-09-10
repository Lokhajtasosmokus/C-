using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsAppropriate
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a function that takes a list as a parameter,
            // and returns a new list with every second element from the orignal list
            // example: [1, 2, 3, 4, 5] should produce [2, 4] - print this result

            List<int> originalNumbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var number in NumberSelection(originalNumbers))
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        public static List<int> NumberSelection(List<int> numbers)
        {
            List<int> selectedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {

                if (i % 2 != 0)
                {
                    selectedNumbers.Add(numbers[i]);

                }
                                
            }
            return numbers;

        }
    }
}
