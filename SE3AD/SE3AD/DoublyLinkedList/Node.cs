using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.DoublyLinkedList
{
    class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node<T> Prev;

        public Node(T v)
        {
            Value = v;
        }

        public Node(T v, Node<T> next)
        {
            Value = v;
            Next = next;
        }
        
        public Node(T v, Node<T> next, Node<T> prev)
        {
            Value = v;
            Next = next;
            Prev = prev;
        }
    }
}
