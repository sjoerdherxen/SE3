using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Queue
{
    class PriorityQueue<T> where T : IComparable
    {
        private List<T> queue;
        public bool IsEmpty
        {
            get
            {
                return queue.Count == 1;
            }
        }

        public PriorityQueue()
        {
            queue = new List<T>();
            queue.Add(default(T));
        }

        public void Add(T value)
        {
            var position = queue.Count;
            queue.Add(value);
            while (position > 0)
            {
                if (queue[position].CompareTo(queue[position / 2]) < 0)
                {
                    var tmp = queue[position];
                    queue[position] = queue[position / 2];
                    queue[position / 2] = tmp;
                    position = position / 2;
                }
                else
                {
                    return;
                }
            }
        }

        public T Get()
        {
            if (IsEmpty)
            {
                return default(T);
            }

            var top = queue[1];
            var index = 2;
            while (index < queue.Count)
            {
                if (index + 1 < queue.Count)
                {
                    if (queue[index].CompareTo(queue[index + 1]) < 0)
                    {
                        queue[index / 2] = queue[index];
                    }
                    else
                    {
                        queue[index / 2] = queue[index + 1];
                        index++;
                    }
                }
                else
                {
                    queue[index / 2] = queue[index];
                }
                index *= 2;
            }
            index /= 2;
            while(index < queue.Count-1)
            {
                var tmp = queue[index];
                queue[index] = queue[index + 1];
                queue[index + 1] = tmp;
                index++;
            }
            queue.RemoveAt(queue.Count - 1);
            return top;
        }

        public override string ToString()
        {
            var s = "";
            foreach(var item in queue)
            {
                s += item + ", ";
            }
            return s;
        }
    }
}
