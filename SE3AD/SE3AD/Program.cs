using SE3AD.Graf;
using SE3AD.Queue;
using SE3AD.SinglyLinkedList;
using SE3AD.Tree.BinarySearchTree;
using System;
using System.Diagnostics;

namespace SE3AD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //TestLinkedList();
            //Sort.Sort.TestSorting2();
            //var b = new BinarySearchTree();
            //b.Test();

            TestPrioQueue();

            Console.ReadKey();
        }

        static void TestLinkedList()
        {
            var l = new LinkedList<int>();
            l.AddFirst(3);
            l.AddFirst(4);
            l.AddFirst(5);
            l.AddAfter(0, 10);

            Console.WriteLine(l);

        }

        static void TestDijkstra()
        {
            var graf = new WeightedGraf();
            graf.AddConnection("", "", 1);
        }

        static void TestPrioQueue()
        {
            var q = new Queue.PriorityQueue<int>();
            q.Add(3);
            q.Add(2);
            q.Add(1);
            q.Add(8);
            Console.WriteLine(q);
            q.Get();
            Console.WriteLine(q);
            q.Get();
            Console.WriteLine(q);
        }

        static void TestPower()
        {

            Console.WriteLine(Pow.Power(1.01f, 50));
            Console.WriteLine(Pow.PowerR(1.01f, 50));
            Console.WriteLine(Pow.PowerBad(1.01f, 50));
            Pow.PowerBad(1.01f, 50);
            Pow.PowerR(1.01f, 50);
            Console.WriteLine("start");

            var s = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                //reinier
                s.Start();
                Pow.PowerR(1.00001f, 20_000_000);
                s.Stop();
                Console.WriteLine("R" + s.ElapsedTicks);
                s.Reset();

                // my
                s.Start();
                Pow.Power(1.00001f, 20_000_000);
                s.Stop();
                Console.WriteLine("S" + s.ElapsedTicks);
                s.Reset();

                // bad
                s.Start();
                Pow.PowerBad(1.00001f, 20_000_000);
                s.Stop();
                Console.WriteLine("B" + s.ElapsedTicks);
                s.Reset();
            }
        }
    }
}