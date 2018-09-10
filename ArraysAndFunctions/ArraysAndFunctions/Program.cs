using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            Console.WriteLine(appendA(am));
            Console.ReadLine();
        }
        public static string appendA(string am)
        {
            return am + "a";

        }

    }
}
