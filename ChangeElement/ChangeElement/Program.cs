using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element

            int[] s = new int[] { 1, 2, 3, 8, 5, 6 };
            Console.WriteLine(ChangeElement(s));
            Console.ReadLine();
                        
        }

        public static int ChangeElement(int[] array)
        {
            array[3] = 4;
            return array[3];
        }
    }
}


