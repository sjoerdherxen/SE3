using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.HashTables
{
    class HashTableInline
    {
        private int[] data;
        private int filled;

        public HashTableInline(int size)
        {
            data = new int[size];
            filled = 0;
        }

        public void Add(int value)
        {
            if (filled >= Math.Floor(data.Length * 0.8))
            {
                // rescale data
                var tmp = new int[data.Length * 2 + 1];
                foreach(var item in data)
                {

                }
            }
        }

    }
}
