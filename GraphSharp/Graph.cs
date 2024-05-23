﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSharp
{
    public class Graph
    {
        public IEnumerable<Node> Nodes { get; }
        public IEnumerable<Edge> Edges { get; }
        public Graph() {}

        public Node AddNode(string category, string? name = null)
        {
            if (category is null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            return new Node();
        }
    }
}
