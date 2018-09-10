using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CirclePerimeter
{
    class CirclePerimeterAndSurface
    {
        
        public static double CirclePerimeter(int r)
        {
            Console.WriteLine("r of circle: ");
            return 2 * r * Math.PI;
        }

        public static double CircleSurface(int r)
        {
            Console.WriteLine("r of circle: ");
            return r * r * Math.PI;
        }
    
    }
}
