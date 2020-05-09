using System;
using System.Xml;

namespace DataStructures
{
    public class LinkedList
    {

        public Node Head = null;
  
        public class Node
        {

            public int Value { get; set; }
            public Node Next { get; set; }


            //Constructor
            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
            }
        }

        /*                              INSERTION
         - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
         */
         public void Insert(int value)
        {
            
                Node newNode = new Node(value);
                 newNode.Next = Head;
                 Head = newNode;
            
        }










        public override string ToString()
        {

            // Traverse and build string
            return "";
        }
    }
}
