using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Sort
{
    partial class Sort
    {
        public int QuickSort(int[] unsorted)
        {
            return QuickSortPart(unsorted, 0, unsorted.Length - 1);
        }

        private int QuickSortPart(int[] unsorted, int start, int end)
        {

            // do insertion sort for last few steps
            if (end - start < 5) return InsertionSort(unsorted, start, end);

            // get pivot
            var pivotIndex = QuickSortGetPivot(unsorted, start, end);

            // move pivot to end;
            Swap(unsorted, pivotIndex, end);

            // counter for complexity
            var counter = 3;

            //sort around pivot values;
            int i = start, j = end - 1;
            while (i < j)
            {
                if (unsorted[i] < unsorted[end])
                {
                    i++;
                    continue;
                }
                if (unsorted[j] > unsorted[end])
                {
                    j--;
                    continue;
                }
                // found match for swap, so swap
                counter++;
                Swap(unsorted, i, j);
                i++;
                j--;
            }
            Swap(unsorted, i, end);
            counter += QuickSortPart(unsorted, start, i - 1);
            counter += QuickSortPart(unsorted, i + 1, end);
            return counter;
        }

        private int QuickSortGetPivot(int[] unsorted, int start, int end)
        {
            int indexCenter = (end - start) / 2 + start;
            var s = new int[3];
            s[0] = unsorted[start];
            s[1] = unsorted[indexCenter];
            s[2] = unsorted[end];

            if (s[0] > s[1] && s[0] > s[2])
            {
                return s[1] > s[2] ? indexCenter : end;
            }
            if (s[1] > s[0] && s[1] > s[2])
            {
                return s[0] > s[2] ? start : end;
            }
            return s[0] > s[1] ? start : indexCenter;
        }
    }
}
