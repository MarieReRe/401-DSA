﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.GraphImplementation
{
   public class Graph<T>
    {
        readonly Dictionary<T, Dictionary<T, int>> Nodes;
        // First we need to create an empty graph 
        public Graph()
        {
            Nodes = new Dictionary<T, Dictionary<T, int>>();
        }
        //Add Node
        public bool AddNode(T value)
        {
            if (Nodes.ContainsKey(value)) return false;

            Nodes.Add(value, new Dictionary<T, int>());
            return true;
        }
        //Add Edge
        //GetNodes
        public List<T> GetNodes()
        {
            if (Nodes.Keys.Count < 1) return null;
            return Nodes.Keys.ToList();
        }
        //GetNeighbors
        //Size
    }
}
