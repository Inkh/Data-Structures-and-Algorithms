using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Queue Cat { get; set; }
        public Queue Dog { get; set; }


        public AnimalShelter()
        {
            Cat = new Queue(null);
            Dog = new Queue(null);
        }

        /// <summary>
        /// Cats go in cats queue, dogs go in dogs queue.
        /// </summary>
        /// <param name="animal">Cat or dog object</param>
        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                if (Cat.Front == null)
                {
                    Node anim = new Node(animal);
                    Cat.Front = anim;
                    Cat.Rear = anim;
                }
                else
                {
                    Cat.Enqueue(new Node(animal));
                }
            }
            else
            {
                if (Dog.Front == null)
                {
                    Node anim = new Node(animal);
                    Dog.Front = anim;
                    Dog.Rear = anim;
                }
                else
                {
                    Dog.Enqueue(new Node(animal));
                }
            }
        }

        /// <summary>
        /// Dequeues appropriate animal according to input.
        /// </summary>
        /// <param name="pref">Cat or Dog to be removed</param>
        /// <returns>Removed Cat or Dog node. Returns null if animal is not available</returns>
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
