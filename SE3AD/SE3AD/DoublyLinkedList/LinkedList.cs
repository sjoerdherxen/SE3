using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.DoublyLinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public LinkedList()
        {

        }

        public void AddFirst(T val)
        {
            Head = new Node<T>(val, Head);
            if(Head.Next != null)
            {
                Head.Next.Prev = Head;
            }
            else
            {
                Tail = Head;
            }
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }
            Head = Head.Next;

            if (Head != null)
            {
                Head.Prev = null;
            }
            else // no next so no elements
            {
                Tail = null;
            }
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

        public void AddTail(T value)
        {
            Tail = new Node<T>(value, null, Tail);
            if (Tail.Prev != null)
            {
                Tail.Prev.Next = Tail;
            }
            else
            {
                Head = Tail;
            }
        }

        public T GetTail()
        {
            return Tail.Value;
        }

        public void RemoveTail()
        {
            if (Tail == null)
            {
                return;
            }
            Tail = Tail.Prev;

            if (Tail != null)
            {
                Tail.Next = null;
            }
            else // no prev so no elements
            {
                Head = null;
            }
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
