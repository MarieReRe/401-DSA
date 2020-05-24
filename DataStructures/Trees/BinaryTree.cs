using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace DataStructures.Trees
{
    /* METHODS NEEDED:
     * [] 1. PreOrder
     * [] 2. InOrder
     * [] 3. PostOrder
     */

    /* For AddRange
     * 
     * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.addrange?view=netcore-3.1
     */

   
    public class BinaryTree<T> : BinarySearchTree<T> where T : IComparable<T>
    {
      
        public List<T> PreOrder(Node Root)
        {
            if (Root != null)
            {
                yield return Root.Value;
                PreOrder(Root.Left);
                PreOrder(Root.Right);
            }
            else
            {
              
            }
        }


    }
}
