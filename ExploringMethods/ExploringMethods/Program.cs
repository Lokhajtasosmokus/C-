using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser();
            Multiply(5, 10);
            Division(5, 10);
            Console.WriteLine(Division02(5, 10, 15));
            Console.WriteLine(Negation01(50, 10, 5));

            double Result01 = Negation02(20, 10, 5);
            Console.WriteLine("");
            Console.WriteLine("Result01 method (Negation) invoked: " + Result01);

            if (Result01 > 10)
            {
                Console.WriteLine("The result01 is more than 10");
            }

            else
            {
                Console.WriteLine("The result01 is less than 10");
            }

            Console.WriteLine("");

            double Result02 = Multiplication(20, 10, 5);

            Console.WriteLine("Result02 method (Multiplication) invoked: " + Result02);

            if (Result02 > 100)
            {
                Console.WriteLine("The result is more than 100");
            }
            else
            {
                Console.WriteLine("The result is less than 100");
            }

            Console.WriteLine("");
            double Result03 = Add(20, 10, 20);
            Console.WriteLine("Result03 method (Add) invoked: " + Result03);

            if (Result03 > 10)
            {
                Console.WriteLine("Result03 is more than 10");
            }
            else
            {
                Console.WriteLine("Result03 is less than 10");
            }
            Console.WriteLine("");
            double Result04 = Negation02(20, 10, 8);
            Console.WriteLine("Result04 method (Negation02) invoked: " + Result04);
            if (Result04 > 0)
            {
                Console.WriteLine("Result04 is a positive number!");
            }
            else
            {
                Console.WriteLine("Result04 is a negative number!");
            }

            if (Result04 % 2 == 0)
            {
                Console.WriteLine("Result04 is a even number");
            }
            else
            {
                Console.WriteLine("Result04 is an odd number");
            }


            Console.ReadLine();
        }


        public static void GreetUser()
        {
            Console.WriteLine("Hey, how ya doin?");
        }

        public static void Multiply(int num01, int num02)
        {
            Console.WriteLine(num01 * num02);
        }

        public static void Division(double num01, double num02)
        {
            Console.WriteLine(num01 / num02);
        }
        
        public static double Division02(double num01, double num02, double num03)
        {
            return num01 / num02 / num03;
        }

        public static double Negation01(double num01, double num02, double num03)
        {
            return num01 - num02 - num03;
        }
        
        public static double Multiplication(double num01, double num02, double num03)
        {
            return num01 * num02 * num03;
        }

        public static double Add(double num01, double num02, double num03)
        {
            return num01 + num02 + num03;
        }

        public static double Negation02(double num01, double num02, double num03)
        {
            return num01 - num02 - num03;
        }

    }
}
