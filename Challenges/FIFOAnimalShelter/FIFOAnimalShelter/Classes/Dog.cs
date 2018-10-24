using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        public override string Habitat { get; set; } = "Anywhere";

        public override string  Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }
        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
