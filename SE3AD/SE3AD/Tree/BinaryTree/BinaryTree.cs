using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Tree.BinaryTree
{
    class BinaryTree
    {
        public Node TreeTop;

        public int GetMaxDepth()
        {
            if (TreeTop == null)
            {
                return 0;
            }
            return TreeTop.GetMaxDepth() + 1;
        }

        public override string ToString()
        {
            // fancy tostring

            var d = GetMaxDepth();
            var s = "";
            for (int x = 0; x < (d - 1) * 2 - 1; x++)
            {
                for (int y = 0; y < d * 2 - 1; y++)
                {
                    s += " ";
                }
                s += "\n";
            }

            if (TreeTop != null)
            {
                TreeTop.FancyToString(d, s);
            }

            return s;
        }
    }
}
