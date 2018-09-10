using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            char[] array = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI".ToCharArray();

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            char[] newArray = new char[array.Length];
            Console.WriteLine(ReversingMethod(array));
            Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

        }
            public static char[] ReversingMethod(char[] newArray)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.Write(newArray[newArray.Length - i - 1]);
                }
                return newArray;
            }
    }
}
