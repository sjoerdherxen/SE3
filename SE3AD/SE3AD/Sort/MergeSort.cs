using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Sort
{
    partial class Sort
    {
        private int MergeSort(int[] unsorted)
        {
            return MergeSort(unsorted, 0, unsorted.Length);
        }

        private int MergeSort(int[] unsorted, int start, int end)
        {
            if (end - start <= 1)
            {
                return 0;
            }
            var split = (end - start) / 2 + start;

            var swaps = 0;

            swaps += MergeSort(unsorted, start, split);
            swaps += MergeSort(unsorted, split, end);
            swaps += MergeSortMerge(unsorted, start, split, end);

            return swaps;
        }

        private int MergeSortMerge(int[] unsorted, int start, int middle, int end)
        {
            // merge
            var swaps = 0;
            int i = start, j = middle;
            int[] newArr = new int[end - start];
            int x = 0;
            while (i < middle && j < end)
            {
                if (unsorted[i] > unsorted[j])
                {
                    newArr[x] = unsorted[j];
                    x++;
                    j++;
                }
                else
                {
                    newArr[x] = unsorted[i];
                    x++;
                    i++;
                }
                swaps++;
            }
            for (int a = i; a < middle; a++)
            {
                newArr[x] = unsorted[a];
                x++;
            }
            for (int a = j; a < end; a++)
            {
                newArr[x] = unsorted[a];
                x++;
            }

            swaps++;

            for (i = 0, j = start; i < newArr.Length; i++, j++)
            {
                unsorted[j] = newArr[i];
            }
            return swaps;
        }
    }
}
