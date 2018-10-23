using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Cat : Animal
    {
        public override string Habitat { get; set; } = "Cat trees and such";

        public override string MakeSound()
        {
            return "Meow!";
        }
    }
}
