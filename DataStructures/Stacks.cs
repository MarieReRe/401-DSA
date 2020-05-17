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
    }
}
