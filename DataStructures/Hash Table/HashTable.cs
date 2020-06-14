using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Hash_Table
{
    public class HashTable
    {
        // First We need to set up our Hash Table. Our Hash table will use a node
        public class Node
        {

            public string Key { get; set; }
            public string Value { get; set; }
            public Node Next { get; set; }
            public Node(string key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }

        }
        //Set up how many buckets are in the HT
        public int Buckets { get; set; }

        //This sets upthe Node array that will store multiple key/value pairs. 
        public Node[] HashNode { get; set; }

        //Next, we set up the HT Constructor. This will set up the quantity for our buckets and set up the same amount of node arrays to match the buckets!
        public HashTable(int buckets)
        {
            Buckets = buckets;
            HashNode = new Node[buckets];
        }
    }
} 
