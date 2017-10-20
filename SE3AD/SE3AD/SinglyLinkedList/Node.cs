using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.SinglyLinkedList
{
    class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T v)
        {
            Value = v;
        }

        public Node(T v, Node<T> next)
        {
            Value = v;
            Next = next;
        }
        
    }
}
