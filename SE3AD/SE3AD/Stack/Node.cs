using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Stack
{
    class Node
    {
        public string Value;
        public Node Next { get; private set; }

        public Node(string v)
        {
            Value = v;
        }

        public Node(string v, Node n)
        {
            Value = v;
            Next = n;
        }
    }
}
