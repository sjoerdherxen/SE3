using SE3AD.Graf;
using SE3AD.Queue;
using SE3AD.SinglyLinkedList;
using SE3AD.Tree.BinarySearchTree;
using SE3AD.Tree.BinaryTree;
using System;
using System.Diagnostics;

namespace SE3AD
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestLinkedList();
            //Sort.Sort.TestSorting2();
            //var b = new BinarySearchTree();
            //b.Test();
            TestDijkstra();
            //TestPrioQueue();

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
            graf.AddConnection("v1", "v2", 2);
            graf.AddConnection("v1", "v4", 1);
            graf.AddConnection("v2", "v4", 3);
            graf.AddConnection("v2", "v5", 10);
            graf.AddConnection("v3", "v1", 4);
            graf.AddConnection("v3", "v6", 5);
            graf.AddConnection("v4", "v3", 2);
            graf.AddConnection("v4", "v6", 8);
            graf.AddConnection("v4", "v7", 4);
            graf.AddConnection("v4", "v5", 2);
            graf.AddConnection("v5", "v7", 6);
            graf.AddConnection("v7", "v6", 1);
            graf.Dijkstra("v1");
            Console.WriteLine(graf.ToString());
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

        public static void TestTreeToString()
        {
            var t = new BinaryTree();
            t.TreeTop = new Tree.BinaryTree.Node
            {
                Value = 4,
                Left = new Tree.BinaryTree.Node
                {
                    Value = 2,
                    Left = new Tree.BinaryTree.Node
                    {
                        Value = 8, 
                    }
                },
                Right = new Tree.BinaryTree.Node
                {
                    Value = 3,
                    Left = new Tree.BinaryTree.Node
                    {
                        Value = 1,
                    }
                }
            };
            Console.Write(t.ToString());
        }
    }
}