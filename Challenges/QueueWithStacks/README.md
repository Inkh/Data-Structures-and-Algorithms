# Queue With Stacks

On paper, this is a normal Queue, but under the hood it is two Stacks working with each other to create the Queue.

## Challenge

Create a new Queue class that uses two Stack class instances to simulate a Queue with basic Enqueue and Dequeue functionalities.​

## Approach and Efficiency

Enqueue:

Time Complexity: O(1)
> Time complexity is O(1) due to only needing to push one node onto the stack.

Space Complexity: O(1)
> Space complexity is constant as we're not using any additional memory.

Dequeue:

Time Complexity: O(n)
> Time Complexity is O(n) due to the first stack having to move everything to and from the second stack.

Space Complexity: O(1)
> Space complexity is constant as we're not using any additional memory.

## Solution
![queuewithstack](../../assets/queuewithstacks.jpg)