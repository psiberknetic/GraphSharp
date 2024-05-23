using GraphSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;

namespace GraphSharpTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void AddNode_IncreasesNodeCountByOne()
        {
            var graph = getPopulatedGraph();
            var initialCount = graph.Nodes.Count();
            graph.AddNode("Test", "ATestNode");
            graph.Nodes.Count().ShouldBe(initialCount + 1);
        }

        private Graph getPopulatedGraph()
        {
            var graph = new Graph();
            graph.AddNode("Test", "A");
            return graph;
        }
    }
}