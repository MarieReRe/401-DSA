using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queues<T>
    {
        private Node<T> Front = null;
        private Node<T> Rear = null;
       

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
    }
}
