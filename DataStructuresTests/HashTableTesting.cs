using DataStructures.Hash_Table;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{
    public class HashTableTesting
    {
        [Fact]
        public void AddOneValue()
        {
            HashTable testHT = new HashTable(15);
           testHT.Add("Vanilla Bean", "Lemon Frozen Yogurt");
            Assert.True(testHT.Contains("Vanilla Bean"));
        }
    }


}
