using System;
using Hashtables.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string myStr = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            Console.WriteLine(FindRepeatedWord(myStr));
        }

        /// <summary>
        /// Finds the first repeated word in a string
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>First repeated word</returns>
        public static string FindRepeatedWord(string str)
        {
            Hashtable myTable = new Hashtable();
            string[] strArr = str.ToLower().Split(" ");

            for (int i = 0; i < strArr.Length; i++)
            {
                if (myTable.Contains(strArr[i]))
                {
                    return strArr[i];
                }
                else
                {
                    myTable.Add(strArr[i], "temp");
                }
            }

            return "No repeated words found";
        }
    }
}
