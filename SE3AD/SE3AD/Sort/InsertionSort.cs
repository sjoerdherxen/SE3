using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Sort
{
    partial class Sort
    {
        public int InsertionSort(int[] unsorted)
        {
            return InsertionSort(unsorted, 0, unsorted.Length - 1);
        }

        private int InsertionSort(int[] unsorted, int start, int end)
        {
            var swaps = 0;
            for (int i = start + 1; i <= end; i++)
            {
                int x = i;
                while (x > 0 && unsorted[x] < unsorted[x - 1])
                {
                    //swap
                    Swap(unsorted, x, x - 1);
                    x--;
                    swaps++;
                }
            }
            return swaps;
        }
    }
}
