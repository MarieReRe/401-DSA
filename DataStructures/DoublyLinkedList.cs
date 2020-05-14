namespace DataStructures
{

    public class DoublyLinkedList
    {

        //use inheritence, research this. Is this possible?
        public Node Head { get; set; }
        public Node Tail {get; set; }


        // creat the dbl ll node
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }



            // constructor
            public Node(int value)
            {
                Value = value;
                Next = null;
                Previous = null;

            }
        }

      


        //string
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
            return linkedListOutput;
        }

        //insert
        public void InsertToDblLL(int newNodeValue)
        {
            // 1. Make new node & put in the value
            Node newNode = new Node(newNodeValue);

            // 2. Make new node head and previous null
            newNode.Next = Head;
            newNode.Previous = null;

            //3. change the previous of head to new node
            if(Head != null)
            {
                Head.Previous = newNode;
            }

            //4.move head to point to newNode
            Head = newNode;
        }
    }






}
