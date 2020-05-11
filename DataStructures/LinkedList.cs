﻿using System;
using System.Transactions;
using System.Xml;

namespace DataStructures
{
    public class LinkedList
    {

        public Node Head { get; set; }
       

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
            // set a current node in each method to how you will want to use it
            //This is a traversal: start with very plain
            string linkedListOutput = "";
            Node current = Head;
            if (Head != null)
            {
                linkedListOutput += $"{{{current.Value}}}";
                while (current.Next != null)
                {
                    current = current.Next;
                    linkedListOutput += $" -> {{{current.Value}}}";
                }


            }
            return linkedListOutput + " -> NULL";
        }

        /*                              INSERTION
         - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
         */
        public void Insert(int newNodeValue)
        {
            Node current = Head;
            //Point newNode to old list
            Node newNode = new Node(newNodeValue);
            if (Head != null)
            {
                newNode.Next = Head;
            }
         
            Head = newNode;
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

        /*                                             APPENDS
                     .append(value) which adds a new node with the given value to the end of the list
        */
        public void Append(int value)
        {
         
            Node current = Head;

            while (current != null)
            {
                if (current.Next != null)
                {
                    current = current.Next;
                }
                else
                {
                    Node newNode = new Node(value);
                    current.Next = newNode;
                    break;
                }
               
            }
        }






        /*                                             INSERT BEFORE
                    .insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node
        */








        /*                                             INSERT AFTER
                   .insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node
        */











    }
}
