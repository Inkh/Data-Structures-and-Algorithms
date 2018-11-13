using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable myTable = new Hashtable();
            myTable.Add("seal", "lion");
            myTable.Add("eals", "wop");
            Console.WriteLine(myTable.List[246].Head.Key);
            Console.WriteLine(myTable.List[246].Head.Value);
            Console.WriteLine(myTable.List[246].Head.Next.Key);
            Console.WriteLine(myTable.List[246].Head.Next.Value);
            Console.WriteLine(myTable.Contains("eals"));
            Console.WriteLine(myTable.Contains("kimchi"));
            Console.WriteLine(myTable.Contains("seal"));
            Console.WriteLine(myTable.Find("seal"));

            myTable.Add("seal", "doggo");
            Console.WriteLine(myTable.Find("seal"));
        }
    }
}
