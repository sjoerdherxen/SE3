using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Tree.BinaryTree
{
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public string NodeFirst()
        {
            var v = Value.ToString();
            if (Left != null)
            {
                v += "\n" + Left.NodeFirst();
            }
            if (Right != null)
            {
                v += "\n" + Right.NodeFirst();
            }
            return v;
        }

        public string NodeMiddle()
        {
            var v = "";
            if (Left != null)
            {
                v += Left.NodeFirst() + "\n";
            }
            v += Value;
            if (Right != null)
            {
                v += "\n" + Right.NodeFirst();
            }
            return v;
        }

        public string NodeLast()
        {
            var v = "";
            if (Left != null)
            {
                v += Left.NodeFirst() + "\n";
            }
            if (Right != null)
            {
                v += Right.NodeFirst() + "\n";
            }
            v += Value;
            return v;
        }
    }
}
