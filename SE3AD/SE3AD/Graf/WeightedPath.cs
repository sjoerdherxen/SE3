using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Graf
{
    class WeightedPath
    {
        public int Weight;
        public WeightedNode ToNode;
        public int NodeFromWeight;

        public WeightedPath(WeightedNode tonode, int weight)
        {
            ToNode = tonode;
            Weight = weight;
        }

   
    }
}
