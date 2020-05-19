using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengesTest
{

    /*----------------------------------QUEUE TESTING
                  [] 1. Can successfully enqueue into a queue
                  [] 2. Can successfully enqueue multiple values into a queue
                  [] 3. Can successfully dequeue out of a queue the expected value
                  [] 4. Can successfully peek into a queue, seeing the expected value
                  [] 5. Can successfully empty a queue after multiple dequeues
                  [] 6. Can successfully instantiate an empty queue
                  [] 7. Calling dequeue or peek on empty queue raises exception x2 DEQUEUE & PEEK


          -----------------------------------------*/
    public class PsuedoQueueTests
    {

        [Fact]
        public void InstantiateEmptyQueue()
        {

            Queue<int> newQueue = new Queue<int>();
            Assert.Empty(newQueue);

        }
        [Fact]
        public void CanEnqueueToQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);

            Assert.Contains(1, newQueue);

        }

        [Fact]
        public void CanEnqueueMultiple()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);

            //Assert
            Assert.Contains(3, newQueue);
        }
        [Fact]
        public void CanDequeueFromQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);



            Assert.Equal(1, newQueue.Dequeue());
        }


        [Fact]
        public void CanEmptyQueueWithMultipleDequeues()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Dequeue();
            newQueue.Dequeue();

            Assert.Contains(3, newQueue);

        }

        [Fact]
        public void DequeueFromEmptyThrows()
        {
            // Arrange
            Queue<int> newQueue = new Queue<int>();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                newQueue.Dequeue();
            });

        }


        /*_________________________PEEK TESTS_____________________*/

        [Fact]
        public void CanPeekIntoQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Peek();

            Assert.Equal(1, newQueue.Peek());

        }

        [Fact]
        public void PeekEmptyQueueThrows()
        {
            // Arrange
            Queue<int> newQueue = new Queue<int>();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                newQueue.Peek();
            });

            // how do we peek and see multiple values, is that possible?

        }




    }
}
