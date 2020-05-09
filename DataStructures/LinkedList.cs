using System;
using System.Transactions;
using System.Xml;

namespace DataStructures
{
    public class LinkedList
    {

        public Node Head { get; set; }
        private Node Current { get; set; }

        public class Node
        {

            public int Value { get; set; }
            public Node Next { get; set; }

            //Constructor
            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

       /*                                         TO STRING
         Define a method called toStringwhich takes in no arguments and returns a string representing all the values in the Linked List, formatted as:
"{ a } -> { b } -> { c } -> NULL"

            */

        public override string ToString()
        {
            string linkedListOutput = "";

            if (Head != null)
            {
                linkedListOutput += $"{{{Current.Value}}}";
                while (Current.Next != null)
                {
                    Current = Current.Next;
                    linkedListOutput += $" => {{{Current.Value}}}";
                }


            }
            return linkedListOutput;
        }

        /*                              INSERTION
         - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
         */
        public void Insert(int value)
        {
                    // instantiate new node
                  Node newNode = new Node(value);

            // Set value to the inputted data
                 newNode.Value = value;
            // Set the next to head
                newNode.Next = Head;

            // set new node to the head
                Head = newNode;
            
        }
        /*                              INCLUDES
         - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
         */
         public bool Includes(int value)
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            Node current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;

        }
            
           
       









    }
}
