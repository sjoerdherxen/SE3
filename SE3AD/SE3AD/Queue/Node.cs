using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Queue
{
    class Node
    {
        public string Value;
        public Node Next;

        public Node(string v)
        {
            Value = v;
        }

        public Node(string v, Node next)
        {
            Value = v;
            Next = next;
        }
    }
}
