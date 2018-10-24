using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public AnimalShelter(Node node)
        {
            Front = node;
            Rear = node;
        }

        public Node Peek()
        {
            return Front;
        }

        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {

        }
    }
}
