using System;
using Xunit;
using QueueWithStacks.Classes;
using StackAndQueue.Classes;


namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        QueueWithTwoStacks myQueue = new QueueWithTwoStacks();

        /// <summary>
        /// Tests that a node will be added to the queue.
        /// </summary>
        [Fact]
        public void WillEnqueueTest()
        {
            myQueue.Enqueue(new Node(10));

            Assert.Equal(1, myQueue.Size);
        }

        /// <summary>
        /// Tests that a node will be removed from the queue.
        /// </summary>
        [Fact]
        public void WillDequeueTest()
        {
            myQueue.Enqueue(new Node(10));
            myQueue.Dequeue();

            Assert.Equal(0, myQueue.Size);
        }

        /// <summary>
        /// Tests that queue is instantiated with nothing in it.
        /// </summary>
        [Fact]
        public void QueueIsInitiallyEmpty()
        {
            Assert.Equal(0, myQueue.Size);
        }
    }
}
