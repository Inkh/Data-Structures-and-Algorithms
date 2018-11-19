using System;
using Hashtables.Classes;

namespace MostCommonWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string another = "in a galaxy far away away";
            Console.WriteLine(MostCommon(another));
        }

        public static string MostCommon(string inputStr)
        {
            if (inputStr == "" || inputStr == " ")
            {
                return "";
            }
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

                    if (temp > maxCount)
                    {
                        maxCount = temp;
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
