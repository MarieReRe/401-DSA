using System;
using DataStructures;
using System.Text;

namespace DataStructures
{

   
    public class Stack<T>
    {
        public Node Top { get; set; }

        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

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
            Node node = new Node(value) { Next = Top };
            Top = node;
        }
        /*______________________________POP OFF STACK_____________________________________________________________ */
        public T Pop()
        {
            Node newNode = Top;
            if (Top == null) 
                throw new InvalidOperationException("Cannot pop from an empty stack!");
           
            Top = Top.Next;
            newNode.Next = null;
            return newNode.Value;


        }

        public T Peek()
        {
            if (Top is null) throw new InvalidOperationException("Cannot peek on an empty stack!"); 
            return Top.Value;
        }

    }
}
