using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue Cat { get; set; }
        public Queue Dog { get; set; }


        public AnimalShelter()
        {
            Cat = new Queue(null);
            Dog = new Queue(null);
        }


        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                Cat.Enqueue(new Node(animal));
            }
            else
            {
                Dog.Enqueue(new Node(animal));
            }
        }

        public Node Dequeue(string pref)
        {
            if (pref.ToLower() == "cat")
            {
                return Cat.Dequeue();
            } 
            else if (pref.ToLower() == "dog")
            {
                return Dog.Dequeue();
            }
            else
            {
                return null;
            }
        }
    }
}
