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
            Console.WriteLine(myTable.List[275].Head.Key);
            Console.WriteLine(myTable.List[275].Head.Value);
            Console.WriteLine(myTable.List[275].Head.Next.Key);
            Console.WriteLine(myTable.List[275].Head.Next.Value);
        }
    }
}
