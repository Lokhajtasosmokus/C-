using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
                    
            StringBuilder correctedQuote = new StringBuilder(quote);

            correctedQuote.Insert(20, " always takes longer than");

            quote = correctedQuote.ToString();

            Console.WriteLine(quote);
            Console.ReadLine();


            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)


            Console.WriteLine(quote);
        }
    }
}