using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Graf
{
    class UnweightedNode
    {
        public string Name;
        public List<UnweightedNode> ToNodes;

        public UnweightedNode(string name)
        {
            Name = name;
            ToNodes = new List<UnweightedNode>();
        }


    }
}
