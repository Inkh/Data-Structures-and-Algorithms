using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public abstract class Animal
    {
        public abstract string Habitat { get; set; }

        public abstract string Name { get; set; }

        public abstract string MakeSound();
    }
}
