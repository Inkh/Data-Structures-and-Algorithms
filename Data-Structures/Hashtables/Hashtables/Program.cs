using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable created");
            Hashtable myTable = new Hashtable();
            Console.WriteLine("Adding key value pairs...");

            Console.WriteLine("Adding 'seal' and 'lion'");
            myTable.Add("seal", "lion");

            Console.WriteLine("Adding 'eals' and 'wop'. Expecting collision");
            myTable.Add("eals", "wop");

            Console.WriteLine("Calling .Find on 'seal'. Expecting 'lion':");
            Console.WriteLine(myTable.Find("seal"));

            Console.WriteLine("Calling .Find on 'eals'. Expecting 'wop':");
            Console.WriteLine(myTable.Find("eals"));

            Console.WriteLine("Calling .Contains on 'seal'. Expecting 'true':");
            Console.WriteLine(myTable.Contains("seal"));

            Console.WriteLine("Calling .Contains on 'eals'. Expecting 'true':");
            Console.WriteLine(myTable.Contains("eals"));

            Console.WriteLine("Calling .Contains on 'kimchi'. Expecting 'false':");
            Console.WriteLine(myTable.Contains("kimchi"));
        }
    }
}
