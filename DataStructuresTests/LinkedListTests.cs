using DataStructures;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructuresTests
{
    public class LinkedListTests

    /*                  Tests needed: 
            [x] 1. Can successfully instantiate an empty linked list
            [x] 2. Can properly insert into the linked list
            [] 3. The head property will properly point to the first node in the linked list
            [] 4. Can properly insert multiple nodes into the linked list
            [] 5. Will return true when finding a value within the linked list that exists
            [] 6. Will return false when searching for a value in the linked list that does not exist
            [] 7. Can properly return a collection of all the values that exist in the linked list

     */
    {
        [Fact]
        public void CreationOfEmptyList()
        {
            //Arrange


            // Act
            LinkedList testLinkedList = new LinkedList();

            //Assert
            Assert.NotNull(testLinkedList);
        }

        [Fact]
        public void LinkedListInsert()
        {
            //Arrange
            LinkedList insertToLinkedList = new LinkedList();

            //Act
            insertToLinkedList.Insert(19);

            //Assert
            Assert.Equal(19, insertToLinkedList.Head.Value);


        }


        [Fact]
        public void HeadPropertyIsFirstNode()
        {
            // Arrange

            //Act
            LinkedList LinkedList = new LinkedList();

            //Assert
            Assert.Null(LinkedList.Head);
        }
    }
}
