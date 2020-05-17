using System.Collections;
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
            Assert.Empty(newStack);
        }


     


        /* -----------------------------PUSH TESTING----------------------------------------- */
        [Fact]
        public void PushToStack()
        {
            System.Collections.Generic.Stack<int> newStack = new System.Collections.Generic.Stack<int>();
            newStack.Push(1);
            Assert.NotNull(newStack);

        }

        [Fact]
        public void WeCanPushManyItemsToStack()
        {
            
            System.Collections.Generic.Stack<int> newStack = new System.Collections.Generic.Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
           Assert.NotNull(newStack);
        }

    

        /* ----------------------------- POP TESTING ----------------------------------------- */
        [Fact]
        public void CanWePopFromStack()
        {
            Stack newStack = new Stack();
            newStack.Push(3);

            Assert.Equal(3, newStack.Pop());

        }


        [Fact]
        public void CanPopManyOffStack()
        {
            Stack newStack = new Stack();
            newStack.Push(3);
            newStack.Push(6);
            newStack.Push(9);
            newStack.Push(12);

            newStack.Pop();
            newStack.Pop();
            string expected = newStack.ToString();

            Assert.Equal(expected, newStack.Equals(6));

        }

        /* ----------------------------- PEEK TESTING ----------------------------------------- */


    }
}
