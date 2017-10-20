using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.SinglyLinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head;

        public LinkedList()
        {

        }

        public void AddFirst(T val)
        {
            Head = new Node<T>(val, Head);
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }
            Head = Head.Next;
        }

        public T GetFirst()
        {
            if (Head == null)
            {
                throw new Exception("No elements");
            }
            return Head.Value;
        }

        public T Get(int index)
        {
            var tmpNode = Head;
            for (var i = 0; i < index; i++)
            {
                if (tmpNode == null)
                {
                    throw new Exception("Out of bounds");
                }
                tmpNode = tmpNode.Next;
            }
            return tmpNode.Value;
        }

        public void AddAfter(int index, T value)
        {
            var tmpNode = Head;
            for (var i = 0; i < index; i++)
            {
                if (tmpNode == null)
                {
                    throw new Exception("Out of bounds");
                }
                tmpNode = tmpNode.Next;
            }
            tmpNode.Next = new Node<T>(value, tmpNode.Next);
        }

        public override string ToString()
        {
            var tmpNode = Head;
            var output = "[";
            while(tmpNode != null) {
                output += tmpNode.Value + ", ";
                tmpNode = tmpNode.Next;
            }
            return output + "]";
        }
    }
}
