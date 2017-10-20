using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Sort
{
    partial class Sort
    {

        public int ShellSort(int[] unsorted)
        {
            // todo check for small array size
            if (unsorted.Length < 6)
            {
                Console.WriteLine("performing insertionSort");
                return InsertionSort(unsorted);
            }

            var swaps = 0;

            // determine step sizes;
            var steps = new List<int>();
            var currentStepSize = unsorted.Length;
            while (currentStepSize > 3)
            {
                int newStep = (int)(currentStepSize / 2.2d);
                if ((newStep & 1) == 0)
                {
                    newStep--;
                }
                steps.Add(newStep);
                currentStepSize = newStep;
            }

            foreach (var step in steps)
            {
                for (int stepOffset = 1; stepOffset <= step; stepOffset++)
                {
                    for (int i = stepOffset + step; i < unsorted.Length; i += step)
                    {
                        int x = i;
                        while ((x - step) >= 0 && unsorted[x] < unsorted[x - step])
                        {
                            //swap
                            Swap(unsorted, x, x - step);
                            x--;
                            swaps++;
                        }
                    }
                }
            }

            swaps += InsertionSort(unsorted);

            return swaps;
        }
    }
}
