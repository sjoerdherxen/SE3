using SE3AD.Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Graf
{
    class WeightedGraf
    {
        public Dictionary<string ,WeightedNode> Nodes;

        public WeightedGraf()
        {
            Nodes = new Dictionary<string, WeightedNode>();
        }

        public void AddConnection(string from, string to, int weight)
        {
            if (!Nodes.ContainsKey(from))
            {
                Nodes.Add(from, new WeightedNode(from));
            }
            if (!Nodes.ContainsKey(to))
            {
                Nodes.Add(to, new WeightedNode(to));
            }

            Nodes[from].ToNodes.Add(new WeightedPath(Nodes[to], weight));
        }

        public void Dijkstra(string from)
        {
            if(!Nodes.ContainsKey(from))
            {
                throw new Exception("No node named " + from);
            }
            // reset node paths
            foreach(var node in Nodes)
            {
                node.Value.PathLength = int.MaxValue;
                node.Value.PreviousNode = null;
                node.Value.IsDone = false;
            }
            Nodes[from].PathLength = 0;

            var todo = new PriorityQueue<WeightedNode>();
            todo.Add(Nodes[from]);

            while (!todo.IsEmpty)
            {
                var node = todo.Get();
                if (node.IsDone)
                {
                    continue;
                }
                node.IsDone = true;
                foreach (var item in node.ToNodes)
                {
                    if (item.ToNode.PathLength > item.Weight + node.PathLength)
                    {
                        item.ToNode.PathLength = item.Weight + node.PathLength;
                        item.ToNode.PreviousNode = node;
                        todo.Add(item.ToNode);
                    }
                }
            }
        }

        public override string ToString()
        {
            var s = "";
            foreach(var node in Nodes)
            {
                s += node + "\n";
            }
            return s;
        }
    }
}
