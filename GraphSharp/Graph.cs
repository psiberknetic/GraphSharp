using System;
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
        public Graph() { }
    }
}
