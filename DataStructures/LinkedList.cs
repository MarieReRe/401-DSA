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
                    linkedListOutput += $" -> {{{Current.Value}}}";
                }


            }
            return linkedListOutput + " -> NULL";
        }

        /*                              INSERTION
         - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
         */
        public void Insert(int newNodeValue)
        {
            Node newNode = new Node(newNodeValue);
            if (Head != null)
            {
                newNode.Next = Head;
            }
         
            Head = newNode;
            Current = newNode;

        }







        /*                              INCLUDES
         - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
         */
         public bool Includes(int value)
        {
            try
            {
                if (Head == null)
                {
                    return false;
                }
                else
                {
                    Node current = Head;
                    while (current.Next != null)
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
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The argument format is not valid.");
                return false;
            }

        }
            
           
       









    }
}
