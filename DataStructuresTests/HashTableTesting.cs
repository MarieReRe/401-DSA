
using DataStructures.HashTable;

using Xunit;

namespace DataStructuresTests
{
    public class HashTableTesting
    {
        [Fact]
        public void AddOneValue()
        {
            HashTable testHT = new HashTable(15);
           testHT.Add("Ice Cream","Vanilla Bean");
            Assert.True(testHT.Contains("Ice Cream"));
        }


        [Fact]
        public void CollisionHandling()
        {
            HashTable testHT = new HashTable(1);

            testHT.Add("Ice Cream", "chocolate");
            testHT.Add("Ice Cream", "sprinkles");
            Assert.True(testHT.Contains("Ice Cream"));
            Assert.True(testHT.Contains("Ice Cream"));
        }
        [Fact]
        public void ContainsNoKeys()
        {
            HashTable testHT = new HashTable(5);
            Assert.False(testHT.Contains("Marie"));
        }

        [Fact]
        public void CanAddMultipleKeyValues()
        {
            string[] productID = { "1001", "2001", "1002", "2002", "3001", "4002", "5009" };
            string[] product = { "t-shirt", "dad cap", "cooler", "Ice Cream Cookbook", "pencil set", "note pad", "scooper" };

            HashTable hashtable = new HashTable(productID.Length);
            for (int i = 0; i < productID.Length; i++)
            {
                hashtable.Add(productID[i], product[i]);
                Assert.True(hashtable.Contains(productID[i]));
            }
        }
        [Fact]
        public void ContainsMultiple()
        {
            HashTable testHT = new HashTable(5);
            testHT.Add("Spaghetti", "1");
            testHT.Add("Ravioli", "3");
            testHT.Add("strozzapreti", "11");
            Assert.True(testHT.Contains("Spaghetti"));
            Assert.True(testHT.Contains("Ravioli"));
            Assert.True(testHT.Contains("strozzapreti"));

        }

        [Fact]
        public void GetOneValue()
        {
            HashTable testHT = new HashTable(5);
            testHT.Add("C#", "1");
            Assert.Equal("1", testHT.Get("C#"));
        }

// NEW TESTY TESTS
        

    }


}
