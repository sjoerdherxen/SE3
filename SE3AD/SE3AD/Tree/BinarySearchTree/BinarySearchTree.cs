using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Tree.BinarySearchTree
{
    class BinarySearchTree
    {
        public Node TreeTop;

        public BinarySearchTree()
        {
        }

        public void Test()
        {
            var a = new int[] { 8, 7, 9, 6, 10, 5, 11, 4, 12 };
            foreach (var q in a)
            {
                Add(q);
            }
            RemoveNode(6);
            Console.WriteLine(this);
        }

        public Node Find(int value)
        {
            var node = TreeTop;
            while (node != null)
            {
                if (value > node.Data)
                {
                    node = node.RightChild;
                }
                else if (value < node.Data)
                {
                    node = node.LeftChild;
                }
                else
                {
                    return node;
                }
            }

            return null;
        }

        public void RemoveNode(int value)
        {
            var node = TreeTop;
            Node prevNode = null;
            while (node != null)
            {
                if (value == node.Data)
                {
                    if (prevNode != null)
                    {
                        if (prevNode.LeftChild != null && prevNode.LeftChild.Data == value)
                        {
                            prevNode.LeftChild = node.RightChild;
                            var left = node.LeftChild;
                            var tmp = node.RightChild;

                            while (tmp.LeftChild != null)
                            {
                                tmp = tmp.LeftChild;
                            }
                            node.LeftChild = tmp;

                            return;
                        }
                        if (prevNode.RightChild != null && prevNode.RightChild.Data == value)
                        {
                            prevNode.RightChild = node.LeftChild;
                            var right = node.RightChild;
                            var tmp = node.LeftChild;
                            while (tmp.RightChild != null)
                            {
                                tmp = tmp.RightChild;
                            }
                            node.RightChild = right;

                            return;
                        }
                    }
                }
                else if (value > node.Data)
                {
                    prevNode = node;
                    node = node.RightChild;
                }
                else if (value < node.Data)
                {
                    prevNode = node;
                    node = node.LeftChild;
                }
            }
        }

        public void Add(int value)
        {
            if (TreeTop == null)
            {
                TreeTop = new Node
                {
                    Data = value,
                };
                return;
            }

            var node = TreeTop;
            while (true)
            {
                if (node.Data > value)
                {
                    if (node.LeftChild == null)
                    {
                        node.LeftChild = new Node { Data = value };
                        return;
                    }
                    node = node.LeftChild;
                }
                else if (node.Data < value)
                {
                    if (node.RightChild == null)
                    {
                        node.RightChild = new Node { Data = value };
                        return;
                    }
                    node = node.RightChild;
                }
                else
                {
                    throw new Exception("cant add value twice");
                }

            }
        }

        public override string ToString()
        {
            if (TreeTop != null)
            {
                return TreeTop.ToString();
            }
            return "[]";
        }
    }
}
