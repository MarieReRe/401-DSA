using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
using Xunit;

namespace DataStructuresTests
{
    public class StackTesting
    {
        [Fact]
        public void PushToStack()
        {
            Stack newStack = new Stack();

            Assert.Equal(1, newStack.Push(1));
        }
    }
}
