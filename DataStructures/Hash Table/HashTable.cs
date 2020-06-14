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
       
    }
} 
