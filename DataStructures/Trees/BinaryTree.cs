using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;


namespace DataStructures.Trees
{
    /* METHODS NEEDED:
     * [x] 1. PreOrder
     * [x] 2. InOrder
     * [x] 3. PostOrder
     */

    /* For AddRange
     * 
     * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.addrange?view=netcore-3.1
     */

  
    public class BinaryTree<T> where T : IComparable<T>
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Value { get; set; }

            public Node Root { get; set; }

        }



        public Node Root;
        public BinaryTree()
        {
            Root = null;
        }
        public Node ReturnRoot()
        {
            return Root;
        }

        //root, left, right
        public IEnumerable<T> PreOrder(Node Root)
        {
            if (Root is null) yield break;

           yield return Root.Value;

                foreach(T item in PreOrder(Root.Left))
                {
                    yield return item;
                }
                foreach (T item in PreOrder(Root.Right))
                {
                    yield return item;
                }
 
        }


        //left, root, right
        public IEnumerable<T> InOrder(Node Root)
        {
            if (Root is null) yield break;
            if (Root != null)
            {
                foreach(T item in InOrder(Root.Left))
                {
                    yield return item;
                }
                yield return Root.Value;

                foreach (T item in InOrder(Root.Right))
                {
                    yield return item;
                }



            }
        }

        //left, right, root
        public IEnumerable<T> PostOrder(Node Root)
        {
            if (Root is null) yield break;
            if (Root != null)
            {
                foreach (T item in InOrder(Root.Left))
                {
                    yield return item;
                }
                foreach (T item in InOrder(Root.Right))
                {
                    yield return item;
                }
                yield return Root.Value;

            }
        }

        public IEnumerable<T> BreadthFirstSearch()
        {
            if (Root is null) return null;
            else
            {
                //Create queue
                Queues<Node> breadthTraversal = new Queues<Node>();
                breadthTraversal.Enqueue(Root);
               List<T> result = new List<T>();

                while(!breadthTraversal.IsEmpty())
                {
                    var node = breadthTraversal.Dequeue();
                    
                    
                }

            }

        }




       
    }
}
