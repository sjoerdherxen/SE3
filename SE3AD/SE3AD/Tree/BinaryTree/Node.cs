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
        public string FancyValue
        {
            get
            {
                return "" + (Value % 10);
            }
        }

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

        public int GetMaxDepth()
        {
            var leftdepth = 0;
            var rightdepth = 0;
            if (Left != null)
            {
                leftdepth = Left.GetMaxDepth();
            }
            if (Right != null)
            {
                rightdepth = Right.GetMaxDepth();
            }
            if (leftdepth > rightdepth)
            {
                return leftdepth + 1;
            }
            return rightdepth + 1;
        }

        public string FancyToString(int depth, int offset, int MaxDepth, string s)
        {
            if (Left != null)
            {
                var newOffset = offset - ((MaxDepth - depth) * 2 - 1);
                Left.FancyToString(depth + 1, newOffset, MaxDepth, s);
            }
            if (Right != null)
            {
                var newOffset = offset + ((MaxDepth - depth) * 2 - 1);
                Right.FancyToString(depth + 1, newOffset, MaxDepth, s);
            }
            var posToChange = depth * ((MaxDepth + 1) * 2) + offset;
            //s[posToChange] = FancyValue;
            return s;

        }


    }
}
