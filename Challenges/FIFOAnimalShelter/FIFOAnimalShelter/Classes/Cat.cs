using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public override string Habitat { get; set; } = "Cat trees and such";

        public override string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Meow!";
        }
    }
}
