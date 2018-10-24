using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace AnimalShelterTest
{
    public class UnitTest1
    {

        AnimalShelter myShelter = new AnimalShelter();

        /// <summary>
        /// Tests that cat object will go in the right queue in shelter.
        /// </summary>
        [Fact]
        public void CatWillEnqueueTest()
        {
            myShelter.Enqueue(new Cat("Kimchi"));
            Assert.True(myShelter.Cat.Peek().Value is Cat);
        }

        /// <summary>
        /// Tests that dog object will go in the right queue in shelter.
        /// </summary>
        [Fact]
        public void DogWillEnqueueTest()
        {
            myShelter.Enqueue(new Dog("Pepper"));
            Assert.True(myShelter.Dog.Peek().Value is Dog);
        }

        [Fact]
        public void CatWillDequeueTest()
        {
            myShelter.Enqueue(new Cat("Kimchi"));
            myShelter.Enqueue(new Dog("Pepper"));

            myShelter.Dequeue("cat");

            Assert.True(myShelter.Cat.Front == null);
        }

        [Fact]
        public void DogWillDequeueTest()
        {
            myShelter.Enqueue(new Cat("Kimchi"));
            myShelter.Enqueue(new Dog("Pepper"));

            myShelter.Dequeue("dog");

            Assert.True(myShelter.Dog.Front == null);
        }

    }
}
