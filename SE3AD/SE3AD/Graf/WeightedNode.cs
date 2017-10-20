using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Graf
{
    class WeightedNode : IComparable
    {
        public string Name;
        public List<WeightedPath> ToNodes;

        public WeightedNode PreviousNode;
        public int PathLength;
        public bool IsDone;

        public WeightedNode(string name)
        {
            Name = name;
            ToNodes = new List<WeightedPath>();
        }

        public int CompareTo(object obj)
        {
            var w = (WeightedNode)obj;
            if (w.PathLength > PathLength)
            {
                return 1;
            }
            if (w.PathLength < PathLength)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            var s = "{" + Name + ": PL" + PathLength + "}";
            return s;
        }
    }
}
