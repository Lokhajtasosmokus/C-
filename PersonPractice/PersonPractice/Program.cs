using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice
{
    class Program
    {
        static void Main(string[] args) 
        {

            Person Person = new Person("Avetis", "Gymkahana");

            Console.WriteLine(Person.GetFullName());
            Console.ReadLine();
        }
    }
}
