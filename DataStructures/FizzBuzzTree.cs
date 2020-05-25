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


        public int totalNodes;
        public List<object> FizzBuzzTree(Tree<object> tree)
        {
            List<object> traversal = new List<object>();
            totalNodes = PreOrder(tree.Root, traversal);
            return traversal;
        }

        public int count = 0;
        public int PreOrder(Node<object> node, List<object> traversal)
        {
            try
            {
                if (Convert.ToInt32(node.Value) % 15 == 0)
                {
                    node.Value = "FizzBuzz";
                    traversal.Add(node.Value);
                    count++;
                }
                else if (Convert.ToInt32(node.Value) % 3 == 0)
                {
                    node.Value = "Fizz";
                    traversal.Add(node.Value);
                    count++;
                }
                else if (Convert.ToInt32(node.Value) % 5 == 0)
                {
                    node.Value = "Buzz";
                    traversal.Add(node.Value);
                    count++;
                }
                else
                {
                    traversal.Add(node.Value);
                    count++;
                }

                if (node.Left != null)
                {
                    PreOrder(node.Left, traversal);
                }
                if (node.Right!= null)
                {
                    PreOrder(node.Right, traversal);
                }
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
