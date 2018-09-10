using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            string path = @"C:\Lokhajtasosmokus\week-02\day-2\PrintEachLine\PrintEachLine\my-file.txt";
            string[] content = new string[] { };

            try
            {
                content = File.ReadAllLines(path);
            }

            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            
            foreach (var item in content)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
