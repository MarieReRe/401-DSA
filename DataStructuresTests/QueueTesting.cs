﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
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



    public class QueueTesting
    {
        [Fact]
        public void CanEnqueueToQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);

            Assert.Contains(1, newQueue);

        }
    }
   
}
