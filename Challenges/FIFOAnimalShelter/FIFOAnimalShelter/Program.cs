using System;
using FIFOAnimalShelter.Classes;
using LinkedList.Classes;

namespace FIFOAnimalShelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Cat("Kimchi"));
            Console.WriteLine((myShelter.Cat.Peek().Value is Cat));
        }
    }
}
