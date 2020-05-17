using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;


namespace DataStructuresTests
{
    public class StackTesting
    {

        /*----------------------------------STACK TESTING
                    [x] 1. Can successfully push onto a stack
                    [x] 2. Can successfully push multiple values onto a stack
                    [x] 3. Can successfully pop off the stack
                    [x] 4. Can successfully empty a stack after multiple pops
                    [x] 5. Can successfully peek the next item on the stack
                    [x] 6. Can successfully instantiate an empty stack
                    [] 7. Calling pop or peek on empty stack raises exception
            
            
            -----------------------------------------*/
        [Fact]
        public void WeCanMakeAnEmptyStack()
        {
            Stack newStack = new Stack();
            Assert.Empty(newStack);
        }

        [Fact]
        public void CanEmptyTheStack()
        {
            Stack<int> newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Pop();
            newStack.Pop();

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

            Stack<int> newStack = new Stack<int>();
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
        public void PopFromEmptyStackThrows()
        {
            // Arrange
            Stack<object> newStack = new Stack<object>();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                newStack.Pop();
            });
        }






        /* ----------------------------- PEEK TESTING ----------------------------------------- */
        [Fact]
        public void CanPeekIntoStack()
        {
            Stack newStack = new Stack();
            newStack.Push(3);
            newStack.Peek();

            Assert.Equal(3, newStack.Peek());
        }



        [Fact]
        public void Peek_empty_stack_throws()
        {
            // Arrange
            Stack<object> newStack = new Stack<object>();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                newStack.Peek();
            });

            // how do we peek and see multiple values, is that possible?

        }
    }
}
