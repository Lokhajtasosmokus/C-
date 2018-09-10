using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordFrequency
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\Lokhajtasosmokus\week-02\day-2\WordFrequency\WordFrequency\input.txt";
            foreach (string item in GetWordsWithFrequency(2, path))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        public static List<string> GetWordsWithFrequency(int thisAmount, string path)
        {
            string[] lines = new string[0];
            try
            {
                lines = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                throw new Exception("File not found");
            }

            List<string> words = new List<string>();
            foreach (string line in lines)
            {
                foreach (string word in line.Split(' '))
                {
                    words.Add(word);
                }
            }

            Dictionary<string, int> wordFeqs = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!wordFeqs.ContainsKey(word))
                {
                    wordFeqs[word] = 1;
                }
                else
                {
                    wordFeqs[word]++;
                }
            }
            List<string> wordsWiththeRightAmountofFrequency = new List<string>();
            foreach (KeyValuePair<string, int> wordFreq in wordFeqs)
            {
                if (wordFreq.Value == thisAmount)
                {
                    wordsWiththeRightAmountofFrequency.Add(wordFreq.Key);
                }
            }
            return wordsWiththeRightAmountofFrequency;
        }
    }
}
