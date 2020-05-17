using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        //initial constructor that adds a link that points to null
        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        // constructor that points to a value that isn't null
        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }



    }
    public class Stack
    {
        public Node top;
        public int count;


        //start off the stack with top set to null and count of zero (empty stack)
        public Stack()
        {
            top = null;
            count = 0;
        }

        // getting the value of the stack count 
        public int Count
        {
            get => count;
        }

        /*______________________________CREATE AN EMPTY STACK________________________________________
        ______________________________________________________________________________________ */

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }

            return false;
        }







        /*______________________________PUSH TO STACK________________________________________
        ______________________________________________________________________________________ */
        public int Push(int value)
        {
            //first check if there is a top, if not set it to a new nodes value
            if (top == null)
            {
                top = new Node(value);
            }
            else
            {
                Node newNode = new Node(value, top);
            }
            //add to the stack
            count++;

            //return how many in the stack
            return count;
        }

        /*______________________________POP OFF STACK_____________________________________________________________ */
        public int Pop()
        {
            // First we want to check if the top is Null, if it is we should throw an exception this wont show since it is not a console app
            if (top == null)
            {
                throw new InvalidOperationException("This is an empty stack");
            }
            else
            {
                int poppedValue = top.Value;
                top = top.Next;
                // decrease stack count value since we pop off a value
                count--;
                return poppedValue;
            }

        }

    }
}
