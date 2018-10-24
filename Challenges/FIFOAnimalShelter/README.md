# FIFO Animal Shelter

## Challenge 

Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.

# Approch and Efficiency

Enqueue

> Time: O(1)

> Time is constant since we're only doing constant operations on Enqueue.

> Space: O(1)

> Space is O(1) due to constant additional space used.

Dequeue

> Time: O(1)

> Since we have multiple queues, we're only dequeueing a certain queue according to preference, therefore operation is constant.

> Space: O(1)

> Using multiple queues, so similar to a standard Queue dequeue method.

## Solution

![animalshelter](../../assets/animalshelter.jpg)