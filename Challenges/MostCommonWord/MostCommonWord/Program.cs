using System;
using Hashtables.Classes;

namespace MostCommonWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string tempStr = "In a galaxy far far far far away and away";
            Console.WriteLine(MostCommon(tempStr));
        }

        public static string MostCommon(string inputStr)
        {
            string[] wordList = inputStr.Split(" ");
            string max = wordList[0];
            Hashtable table = new Hashtable();
            int maxCount = 1;

            for(int i = 0; i < wordList.Length; i++)
            {
                if (table.Contains(wordList[i]))
                {
                    int temp = Convert.ToInt32(table.Find(wordList[i])) + 1;
                    table.Add(wordList[i], temp);

                    if (Convert.ToInt32(table.Find(wordList[i])) > maxCount)
                    {
                        maxCount = Convert.ToInt32(table.Find(wordList[i]));
                        max = wordList[i];
                    }
                }
                else
                {
                    table.Add(wordList[i], 1);
                }
            }
            return max;       
        }
    }
}
