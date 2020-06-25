using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        public object Value { get; set; }
        public Node<object> Left { get; set; }
        public Node<object> Right { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
    public class Tree<T> 
    {
        public Node<object> Root { get; set; }

        public Tree(object value)
        {
            Root = new Node<object>(value);
        }

        public Tree()
        {

        }

        // We need create an empty list to store the tree nodes. 
        public int totalNodes;
        public List<object> FizzBuzzTree(Tree<object> tree)
        {
            List<object> traversal = new List<object>();

            //we use the PreOrder Method to traverse through the nodes. 
            totalNodes = PreOrder(tree.Root, traversal);
            return traversal;
        }

        public IEnumerable<int> BreadthFirst()
        {
            throw new NotImplementedException();
        }

        // we will count the nodes on the tree
        public int count = 0;
        public int PreOrder(Node<object> node, List<object> traversal)
        {
            try
            {
                // check if child nodes are not null
                if (node.Left != null)
                {
                    PreOrder(node.Left, traversal);
                }
                if (node.Right != null)
                {
                    PreOrder(node.Right, traversal);
                }




                if (Convert.ToInt32(node.Value) % 3 == 0 && Convert.ToInt32(node.Value) % 5 == 0)
                {
                    //If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
                    node.Value = "FizzBuzz";
                    traversal.Add(node.Value);
                    count++;
                }
                else if (Convert.ToInt32(node.Value) % 3 == 0)
                {
                    //If the value is divisible by 3, replace the value with “Fizz”
                    node.Value = "Fizz";
                    traversal.Add(node.Value);
                    count++;
                }
                else if (Convert.ToInt32(node.Value) % 5 == 0)
                {
                    //If the value is divisible by 5, replace the value with “Buzz”
                    node.Value = "Buzz";
                    traversal.Add(node.Value);
                    count++;
                }
                else
                {
                    traversal.Add(node.Value);
                    count++;
                }
                
            //return the count
                return count;
            }
            catch (NullReferenceException ex)
            {
               
                Console.WriteLine(ex.Message);
                return count;
            }
        }






    }
}
