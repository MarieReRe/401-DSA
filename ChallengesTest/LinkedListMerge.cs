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
      *         5. 
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

            DataStructures.LinkedList secondList = new LinkedList();
            secondList.Insert(2);
            secondList.Insert(3);
            secondList.Insert(4);

            string expected = "{1} -> {2} -> {3} -> {4} -> {5} -> {6} -> NULL";
            //act
            DataStructures.LinkedList mergedList = LLMerge.Merge(firstList,
            secondList);
            string actual = mergedList.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
