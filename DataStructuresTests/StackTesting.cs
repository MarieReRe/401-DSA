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
    }
}
