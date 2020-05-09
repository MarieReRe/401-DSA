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

            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
            }
        }
   
        






     

        public override string ToString()
        {

            // Traverse and build string
            return "";
        }
    }
}
