using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    /* METHODS NEEDED
     * [x] 1. ADD
     * [] 2. Contains
     */
   

    public class BinarySearchTree<T>  where T : IComparable<T>
    {


        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Value { get; set; }

            public Node Root { get; set; }
            
        }


        public Node Root;
        public BinarySearchTree()
        {
            Root = null;
        }


        // ADD METHOD

        public void Add(T valueToBeAdded)
        {

            // Set New Node
            Node newNode = new Node();
            newNode.Value = valueToBeAdded;

            if (Root is null) Root = newNode;
            else
            {
                // Set current node to root
                Node current = Root;
                // Set initial node to parent node
                Node parentNode; 

                while(true)
                {
                    parentNode = current; 
                    if(valueToBeAdded.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                        //check if current is null
                        if(current is null)
                        {
                            parentNode.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right; 
                        if(current is null)
                        {
                            parentNode.Right = newNode;
                            return;
                        }
                    }

                }


                
            }
        }
        public bool Contains(Node node, T value)
        {
            if (node is null)
            {
                return false;
            }
            else
            {
                if (node.Value.Equals(value))
                {
                    return true;
                }
                    
                else if (node.Value.CompareTo(value) > 0)
                {
                    return Contains(node.Left, value);
                }
                else
                    return Contains(node.Right, value);

            }
       

          

        }
    }
}
