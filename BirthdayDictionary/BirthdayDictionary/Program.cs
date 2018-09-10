using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BirthdayDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that
            // - takes a filename as a parameter,
            // - reads a csv file which rows contains data in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
            // - returns the year when the most births happend.

            // You can find such a csv file in this directory: births.csv
            // If you pass births.csv to your function, the result should be 2006

            string path = @"C:\Lokhajtasosmokus\week-02\day-2\BirthdayDictionary\BirthdayDictionary\Births.csv";

            Console.WriteLine(Birthdays(path));
            Console.ReadLine();

        }
        public static string Birthdays(string path)
        {
            Dictionary<string, int> Diction = new Dictionary<string, int>();

            string[] content = File.ReadAllLines(path);

            List<string> Years = new List<string>();

            for (int i = 0; i < content.Length; i++)
			{
                Years.Add(content[i].Split(';')[1].Split('-')[0]);
			}

            foreach (var year in Years)
            {
                if (!Diction.ContainsKey(year))
                {
                    Diction.Add(year, 1);
                }

                else
                {
                    Diction[year] += 1;
                }
            }

            KeyValuePair<string, int> mostCommonYear = new KeyValuePair<string, int>("", 0);

            foreach (KeyValuePair<string, int> item in Diction)
            {
                if (item.Value >= mostCommonYear.Value)
                {
                    mostCommonYear = item;
                }
            }
            return mostCommonYear.Key;
            
        }
    }
}




