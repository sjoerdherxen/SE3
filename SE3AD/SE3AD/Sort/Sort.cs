using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace SE3AD.Sort
{
    partial class Sort
    {
        private void Swap(int[] arr, int x, int y)
        {
            var tmp = arr[x];
            arr[x] = arr[y];
            arr[y] = tmp;
        }
        
        public static void TestSorting2()
        {
            var s = new Sort();
            s.TestSort("MergeSort        ", 2000000, 1, x => s.MergeSort(x));
            s.TestSort("QuickSort        ", 2000000, 1, x => s.QuickSort(x));
            s.TestSort("InsertionSort    ", 20000, 1, x => s.InsertionSort(x));
            s.TestSort("ShellSort        ", 100000, 1, x => s.ShellSort(x));
        }

        private void TestSort(string name, int length, int randomSeed, Expression<Func<int[], int>> func)
        {
            var r = new Random(randomSeed);

            var arr = new int[length];
            for(int i = 0; i < length; i++)
            {
                arr[i] = r.Next();
            }

            Console.Write(name + ": ");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var swaps = func.Compile().Invoke(arr);
            stopwatch.Stop();

            Console.WriteLine("sort count: " + length + "\t" + swaps + "\tin " + stopwatch.ElapsedMilliseconds + "ms");
        }

        // print a array
        private static string PA(int[] a)
        {
            var value = "[";
            foreach (var item in a)
            {
                value += item + ", ";
            }

            return value + "]";
        }
    }
}
