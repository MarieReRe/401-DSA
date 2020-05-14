using Challenges;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinkedListMerge.Test
{


    /*----------------MERGE LINKED LISTS TESTING
      *         1. Can merge lists of equal length
      *         2. can merge differnt length tests
      *         3. Merging lists returns empty when both lists are empty
      *         4. merge list returns second list if one is empty
      *       
      * 
      * 
      */
    public class LinkedListMergeTest
    {
        [Fact]
        public void MergeListsOfEqualLength()
        {
            LinkedList firstList = new LinkedList();
            firstList.Insert(1);
            firstList.Insert(3);
            firstList.Insert(5);

            LinkedList secondList = new LinkedList();
            secondList.Insert(2);
            secondList.Insert(4);
            secondList.Insert(6);

            LinkedList MergedList = new LinkedList();
            MergedList.Insert(1);
            MergedList.Insert(2);
            MergedList.Insert(3);
            MergedList.Insert(4);
            MergedList.Insert(5);
            MergedList.Insert(6);

            string expectedMergedList = "{6} -> {5} -> {4} -> {3} -> {2} -> {1} -> NULL";

            // Assert
            Assert.Equal(expectedMergedList,MergedList.ToString());
        }
        [Fact]
        public void NullListIsNull()
        {
            LinkedList nullListOne = new LinkedList();
            LinkedList nullListTwo = new LinkedList();

            LinkedList MergeList = Challenges.LLMerge.Merge(nullListOne,nullListTwo);



            Assert.Null(MergeList.Head);

        }
        

    }
}
