using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queues<T>
    {
        Node Front = null;
        Node Rear = null;


        public class Node
        {
            public Node Front { get; set; }
            public Node Rear { get; set; }
            public T Value { get; set; }
            public Node Next { get; set; }

            //initial constructor that adds a link that points to null
            public Node(T value)
            {
                Value = value;
            }

        }


        /*--------------------------------------------- QUEUE START---------
        -------------------------------------------------------------------*/


        public bool IsEmpty()
        {
            return false;
        }
        public void Enqueue(T value)
        {
            Node newNode = new Node(value);
            if (Rear != null)
            {
                newNode.Value = value;
                Rear.Next = newNode;
                newNode = Rear;
            }
            else
            {
                Rear = newNode;
            }
        }


        public T Dequeue()
        {
            
            if(Front == null) throw new InvalidOperationException("This Queue is empty");
            Node node = Front;
            if (Front == Rear) Rear = Rear.Next;
            Front = Front.Next;

            return Front.Value;

        }

        public T Peek()
        {
            if (Front == null) throw new InvalidOperationException("This Queue is empty");
            return Front.Value;
        }



    }
}
