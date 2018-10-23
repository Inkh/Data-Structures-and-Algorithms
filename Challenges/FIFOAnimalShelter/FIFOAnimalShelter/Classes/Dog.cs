using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Dog : Animal
    {
        public override string Habitat { get; set; } = "Anywhere";

        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
