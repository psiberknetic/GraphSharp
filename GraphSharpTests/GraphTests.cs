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

        [TestMethod]
        public void AddNode_WithNoName_IncreasesNodeCountByOne()
        {
            var graph = getPopulatedGraph();
            var initialCount = graph.Nodes.Count();
            graph.AddNode("Test");
            graph.Nodes.Count().ShouldBe(initialCount + 1);
        }

        [TestMethod]
        public void AddNode_WithEmptyCategory_ThrowsAnException()
        {
            var graph = new Graph();
            var addNode = () => { graph.AddNode(String.Empty); };
            addNode.ShouldThrow<ArgumentException>();
        }

        [TestMethod]
        public void AddNode_WithNullCategory_ThrowsAnException()
        {
            var graph = new Graph();
            var addNode = () => { graph.AddNode(null); };
            addNode.ShouldThrow<ArgumentException>();
        }

        private Graph getPopulatedGraph()
        {
            var graph = new Graph();
            graph.AddNode("Test", "A");
            return graph;
        }
    }
}