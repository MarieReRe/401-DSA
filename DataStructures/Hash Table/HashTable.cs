using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Hash_Table
{

    // Key value look-up
    //we want to store the date in an array
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

        //Set Up the Hash
        public int Hash(string key)
        {
            int index;
            byte[] bytesTotal = Encoding.ASCII.GetBytes(key);
            int letterNumber = 0;
            for (int i = 0; i < bytesTotal.Length; i++)
            {
                letterNumber += bytesTotal[i];
            }
            index = letterNumber * 1024 % 1147 % Buckets;
            return index;
        }
        //Set up how many buckets are in the HT
        public int Buckets { get; set; }

        //This sets upthe Node array that will store multiple key/value pairs. 
        public Node[] HashTableNode { get; set; }

        //Next, we set up the HT Constructor. This will set up the quantity for our buckets and set up the same amount of node arrays to match the buckets!
        public HashTable(int buckets)
        {
            Buckets = buckets;
            HashTableNode = new Node[buckets];
        }

        //Adds an element with the specified key and value into the Hashtable.
        public void Add(string key, string value)
        {
            int index = Hash(key);
            if (HashTableNode[index] == null)
            {
                Node newNode = new Node(key, value);
                HashTableNode[index] = newNode;
            }
            else
            {
                Node newNode = new Node(key, value);
                Node current = HashTableNode[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Get



        //Contains
        public bool Contains(string key)
        {
            int index = Hash(key);
            if (HashTableNode[index] == null)
            {
                return false;
            }
            else
            {
                Node current = HashTableNode[index];
                if (HashTableNode[index].Key == key) return true;
                while (current.Next != null)
                {
                    current = current.Next;
                    if (current.Key == key)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
} 
