using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ringba_test
{
    class Program
    { 
        static void Main(string[] args)
        {

            // Configurable fileName to save/read as
            string fileName = "output.txt";

            // Downloading Your File
            using (WebClient myWebClient = new WebClient())
            {
                string myRes = "https://ringba-test-html.s3-us-west-1.amazonaws.com/TestQuestions/output.txt";
                myWebClient.DownloadFile(myRes, fileName);
            }

            // Counting the frequencies of letter appearances
            var freqs = File.ReadAllText(fileName)
                    .Where(ch => Char.IsLetter(ch))
                    .GroupBy(ch => Char.ToUpper(ch))
                    .ToDictionary(g => g.Key, g => g.Count());

            foreach (KeyValuePair<Char, int> kvp in freqs)
            {
                Console.WriteLine("Letter: {0}, Frequency: {1}", kvp.Key, kvp.Value);
            }

            var freqsLower = File.ReadAllText(fileName)
                    .Where(ch => Char.IsLetter(ch))
                    .GroupBy(ch => ch)
                    .ToDictionary(g => g.Key, g => g.Count());

            int total = 0;
            foreach (KeyValuePair<Char, int> kvp in freqsLower)
            {
                // Counting the total capitalized letters
                if (char.IsUpper(kvp.Key)) total += kvp.Value;
            }
            Console.WriteLine("Total capitalized letters: " + total);

            // Finding the most common word and prefix
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Dictionary<string, int> dictionaryPref = new Dictionary<string, int>();

            using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                string sInput = sr.ReadLine();
                string[] split = Regex.Split(sInput, @"(?<!^)(?=[A-Z])");
                foreach (string word in split) 
                    {
                        // Checking for words (can be 2 letter words! f.e. In, It, On, At, We, He, Fe)
                        if (word.Length >= 2) 
                        {
                            if (dictionary.ContainsKey(word)) 
                                dictionary[word] = dictionary[word] + 1; 
                            else
                                dictionary[word] = 1; 
                        }
                        // Checking for prefixes - have to be atleast 3letter words
                        if (word.Length >= 3)
                        {
                        string pref = word.Substring(0, 2);
                            if (dictionaryPref.ContainsKey(pref))
                                dictionaryPref[pref] = dictionaryPref[pref] + 1;
                            else
                                dictionaryPref[pref] = 1;
                        }
                    }
            }

            // Most used word and its count
            var keyOfMaxValue = dictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("The word used most in this file was : " + keyOfMaxValue + " - which was used " + dictionary.Values.Max() + " times.");
            // Most used prefix and its count
            var keyOfMaxValuePref = dictionaryPref.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("The prefix used most in this file was : " + keyOfMaxValuePref + " - which was used " + dictionaryPref.Values.Max() + " times.");
        }
    }
}
