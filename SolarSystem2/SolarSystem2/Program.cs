using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList = PutSaturn(planetList);

            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            // Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"

            for (int i = 0; i < planetList.Count; i++)
            {
                Console.WriteLine(planetList[i]);
            }
            
            Console.ReadLine();
        }

        public static List<string> PutSaturn(List<string> planetOrder)
        {
            planetOrder.Insert(7, "Saturn");
            return planetOrder;        
        }
    }
}
