using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

   
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            //initial constructor that adds a link that points to null
            public Node(T value)
            {
                Value = value;
            }

        }
        





        /*______________________________CREATE AN EMPTY STACK________________________________________
        ______________________________________________________________________________________ */

        public bool IsEmpty()
        {
            return false;
        }







        /*______________________________PUSH TO STACK________________________________________
        ______________________________________________________________________________________ */
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value) { Next = Top };
            Top = node;
        }
        /*______________________________POP OFF STACK_____________________________________________________________ */
        public T Pop()
        {
            if (Top == null) 
                throw new InvalidOperationException("Cannot pop from an empty stack!");
            Node<T> node = Top;
            Top = Top.Next;
            return node.Value;

        }


    }
}
