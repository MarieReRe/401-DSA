using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queues<T>
    {
        Node<T> Front = null;
        Node<T> Rear = null;


        public class Node<T>
        {
            public Node<T> Front { get; set; }
            public Node<T> Rear { get; set; }
            public T Value { get; set; }
            public Node<T> Next { get; set; }

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
            Node<T> newNode = new Node<T>(value);
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


        public void Dequeue()
        {
            
            if(Front == null) throw new InvalidOperationException("This Queue is empty");
            Node<T> node = Front;
            if (Front == Rear) Rear = Rear.Next;
            Front = Front.Next;

        }

        public T Peek()
        {
            if (Front == null) throw new InvalidOperationException("This Queue is empty");
            return Front.Value;
        }



    }
}
