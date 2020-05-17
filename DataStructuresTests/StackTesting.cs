using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
using Xunit;

namespace DataStructuresTests
{
    public class StackTesting
    {

        /*----------------------------------STACK TESTING-----------------------------------------*/
        [Fact]
        public void WeCanMakeAnEmptyStack()
        {
            Stack newStack = new Stack();
            Assert.True(newStack.IsEmpty());
        }


        /* -----------------------------PUSH TESTING----------------------------------------- */
        [Fact]
        public void PushToStack()
        {
            Stack newStack = new Stack();

            Assert.Equal(1, newStack.Push(1));
        }

        [Fact]
        public void WeCanPushManyItemsToStack()
        {
            Stack newStack = new Stack();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);


            Assert.Equal(6, newStack.Push(6));

        }
        /* ----------------------------- POP TESTING ----------------------------------------- */
        [Fact]
        public void CanWePopFromStack()
        {
            Stack newStack = new Stack();
            newStack.Push(3);

            Assert.Equal(3, newStack.Pop());

        }


    }
}
