using System;
using System.Text;

namespace SE3AD.Queue
{
    class QueueLinkedList
    {
        // uses singlylinkedlist

        private Node head;
        private Node tail;

        public QueueLinkedList()
        {// head, tail = null
        }

        public void Push(string value)
        {
            if(tail == null) // head should be null in this case
            {
                head = new Node(value);
                tail = head;
            }
            else
            {
                var tmp = tail;
                tail = new Node(value);
                tmp.Next = tail;
            }
        }

        public string Pop()
        {
            if(head == null)
            {
                return null;
            }

            var tmpVal = head.Value;
            if (head.Next == null) // lijst is leeg
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
            }

            return tmpVal;
        }

        public string Look()
        {
            return head == null ? null : head.Value;
        }
    }
}
