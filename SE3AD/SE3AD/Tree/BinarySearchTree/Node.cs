using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Tree.BinarySearchTree
{
    class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;

        public override string ToString()
        {
            var d = Data.ToString() + ":(";
            if (LeftChild != null)
            {
                d += LeftChild.ToString();
            }
            if (RightChild != null)
            {
                d += RightChild.ToString();
            }
            return d + ")";
        }
    }
}
