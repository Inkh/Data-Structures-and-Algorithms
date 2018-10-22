using System;
using Xunit;
using StackAndQueue.Classes;

namespace StackAndQueueTest
{
    public class UnitTest1
    {
        Stack myStack = new Stack(new Node(10));
        Queue myQueue = new Queue(new Node(10));

        /// <summary>
        /// Tests that Peek method returns correct value
        /// </summary>
        [Fact]
        public void StackWillPeekTest()
        {
            myStack.Push(new Node(20));
            myStack.Push(new Node(30));

            Assert.Equal(30, myStack.Peek().Value);
        }

        /// <summary>
        /// Tests that new node will be pushed to top of stack
        /// </summary>
        [Fact]
        public void StackWillPushTest()
        {
            myStack.Push(new Node(40));

            Assert.Equal(40, myStack.Peek().Value);
        }

        /// <summary>
        /// Tests that first node will be removed from stack
        /// </summary>
        [Fact]
        public void StackWillPopTest()
        {
            myStack.Push(new Node(20));
            myStack.Push(new Node(30));
            myStack.Pop();

            Assert.Equal(20, myStack.Peek().Value);
        }

        /// <summary>
        /// Test if correct value will be returned from front of queue
        /// </summary>
        [Fact]
        public void QueueWillPeekTest()
        {
            Assert.Equal(10, myQueue.Peek().Value);
        }

        /// <summary>
        /// Tests if node will be inserted to the end.
        /// </summary>
        [Fact]
        public void QueueWillEnqueueTest()
        {
            myQueue.Enqueue(new Node(20));
            Assert.Equal(20, myQueue.Rear.Value);
        }

        /// <summary>
        /// Tests if first node will be removed from queue.
        /// </summary>
        [Fact]
        public void QueueWillDequeueTest()
        {
            myQueue.Enqueue(new Node(20));
            myQueue.Dequeue();

            Assert.Equal(20, myQueue.Front.Value);
        }
    }
}
