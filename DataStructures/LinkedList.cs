using System;
using System.Threading;
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


                    //break from loop once appending is done
                    break;
                }
               
            }
        }






        /*                                             INSERT BEFORE
                    .insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node
        */
        public void InsertBefore(int value, int newValue)
        {
            if(Head.Value == value)
            {
                Insert(newValue);
                return;
            }

            // if head isnt the value we need to create a node and find the search value
            Node newNode = new Node(newValue);

            // Next we need to traverse the list until it reaches the first node beforea  node with the search value
            Node current = Head;
            while(current != null)
            {
                if(current.Next.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }







        /*                                             INSERT AFTER
                   .insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node
        */

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);

            //traverses the list until it reaches the first node with the searched value
            Node current = Head;
            while (current != null)
            {
                //if the current node's value is the searched value, place the new node between current node and next
                if (current.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }
        public void DeleteANode(int nodeStart, int nodeEnd )
        {
            Node current = Head;
            Node previousNode = null;
            while (current != null)
            {
                if(current.Value >= nodeStart && current.Value <= nodeEnd)
                {
                    if(previousNode == null)
                    {
                        Head = current.Next;
                    }
                    else
                    {
                        previousNode.Next = current.Next;
                    }
                }
                else
                {
                    previousNode = current;
                }
                current = current.Next;

            }
          
               
        }
        public int KthFromEnd(int k)
        {

            int linkedListLength = 0;
            Node current = Head;
            //gets length of linked list
            while (current != null)
            {

                linkedListLength++;
                current = current.Next;

            }
          
            //For out of bounds
            if (k < 0)
            {
                throw new IndexOutOfRangeException("k cannot be negative");
            }
            if (k > linkedListLength)
            {
                throw new IndexOutOfRangeException("k cannot be longer than linked list");
            }

            //loops through again 
            current = Head;
            int counter = 0;
            while(current != null && counter < linkedListLength - k -1)
            {
                counter++;
                current = current.Next; 

            }
            return current.Value;



        }

    }
}

