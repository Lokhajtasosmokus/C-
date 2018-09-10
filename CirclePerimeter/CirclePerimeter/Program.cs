using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CirclePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            int r = 0;

            Console.WriteLine("r of circle: ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("perimeter of the circle: " + 2 * r * Math.PI);
            Console.WriteLine("surface: " + r*r* Math.PI);
            Console.WriteLine("");
            Console.WriteLine("same with a method");
            Console.WriteLine("");

            Console.WriteLine(CirclePerimeterAndSurface.CirclePerimeter (r));

            Console.ReadLine();
        }
               
            
    }
}
