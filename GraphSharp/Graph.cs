using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSharp
{
    public class Graph
    {
        public IList<Node> Nodes { get; }
        public IList<Edge> Edges { get; }
        public Graph() {
            Nodes = new List<Node>();
            Edges = new List<Edge>();
        }

        public Node AddNode(string category, string? name = null)
        {
            var newNode = new Node(category, name);
            Nodes.Add(newNode);
            return newNode;
        }
    }
}
