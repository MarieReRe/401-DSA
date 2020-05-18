using System;
using System.Collections;
using System.Text;
using Xunit;

namespace DataStructuresTests
{


    /*----------------------------------QUEUE TESTING
                   [x] 1. Can successfully enqueue into a queue
                   [x] 2. Can successfully enqueue multiple values into a queue
                   [x] 3. Can successfully dequeue out of a queue the expected value
                   [x] 4. Can successfully peek into a queue, seeing the expected value
                   [x] 5. Can successfully empty a queue after multiple dequeues
                   [x] 6. Can successfully instantiate an empty queue
                   [x] 7. Calling dequeue or peek on empty queue raises exception x2 DEQUEUE & PEEK


           -----------------------------------------*/



    public class QueueTesting
    {

        [Fact]
        public void InstantiateEmptyQueue()
        {

            Queue<int> newQueue = new Queue<int>();
            Assert.Empty(newQueue);
          
        }

        /*_________________________ENQUEUE TESTS_____________________*/
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


        /*_________________________DEQUEUE TESTS_____________________*/

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
