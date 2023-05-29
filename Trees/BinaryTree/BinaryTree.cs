using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public List<Node<T>> nodeList { get; private set; }
        public BinaryTree()
        {
            nodeList = new List<Node<T>>();
        }
        public List<Node<T>> InOrderRecursion(Node<T> root)
        {
            if (!(root == null))
            {
                InOrderRecursion(root.Left);
                //Console.WriteLine(root);
                nodeList.Add(root);
                InOrderRecursion(root.Right);
            }
            return nodeList;
        }

        public List<Node<T>> InOrderIteratif(Node<T> root)
        {
            var stack = new Stack<Node<T>>();
            bool done = false;
            Node<T> currentNode = root;

            while (!done)
            {
                if (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stack.Pop();
                        nodeList.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }
            return nodeList;
        }

        public List<Node<T>> PreOrderRecursion(Node<T> root)
        {
            if (!(root == null))
            {
                //Console.WriteLine(root);
                nodeList.Add(root);
                PreOrderRecursion(root.Left);
                PreOrderRecursion(root.Right);
            }
            return nodeList;
        }

        public List<Node<T>> PreOrderIteratif(Node<T> root)
        {
            var stack = new Stack<Node<T>>();

            if (root == null)
                throw new Exception("The tree is empty.");

            stack.Push(root);

            while (!(stack.Count == 0))
            {
                var temp = stack.Pop();
                nodeList.Add(temp);
                if (temp.Right != null)
                {
                    stack.Push(temp.Right);
                }
                if (temp.Left != null)
                {
                    stack.Push(temp.Left);
                }
            }
            return nodeList;
        }

        public List<Node<T>> PostOrderRecursion(Node<T> root)
        {
            if (!(root == null))
            {
                PostOrderRecursion(root.Left);
                PostOrderRecursion(root.Right);
                //Console.WriteLine(root);
                nodeList.Add(root);
            }
            return nodeList;
        }

        public List<Node<T>> PostOrderIteratif(Node<T> root)
        {
            var stack = new Stack<Node<T>>();
            bool done = false;
            Node<T> currentNode = root;

            while (!done)
            {
                if (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stack.Pop();
                        nodeList.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }
            return nodeList;
        }

        //public List<Node<T>> LevelOrderTraversal(Node<T> root)
        //{
        //    var queue = new Queue<Node<T>>();
        //    Node<T> leftNode = root.Left;
        //    Node<T> rightNode = root.Right;

        //    queue.Enqueue(root);

        //    while (queue.Count > 0)
        //    {
        //        var temp = queue.Dequeue();
        //        nodeList.Add(temp);

        //        if (leftNode != null)
        //        {
        //            queue.Enqueue(leftNode);
        //            if (leftNode.Left != null)
        //            {
        //                leftNode = leftNode.Left;
        //            }
        //        }

        //        if (rightNode != null)
        //        {
        //            queue.Enqueue(rightNode);
        //            if (rightNode.Right != null)
        //            {
        //                rightNode = rightNode.Right;
        //            }
        //        }
        //    }

        //    return nodeList;
        //}

        public List<Node<T>> LevelOrderTraversal(Node<T> root)
        {
            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                nodeList.Add(temp);
                if (temp.Left != null)
                    queue.Enqueue(temp.Left);
                if (temp.Right != null)
                    queue.Enqueue(temp.Right);
            }
            return nodeList;
        }

        public static int MaxDepth(Node<T> root)
        {
            if (root == null)
                return 0;

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return leftDepth > rightDepth ? leftDepth + 1 : rightDepth + 1;
        }

        public Node<T> DeepestNode(Node<T> root)
        {
            if (root == null)
                throw new Exception();

            Node<T> temp = null;
            var q = new Queue<Node<T>>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                temp = q.Dequeue();
                if (temp.Left != null)
                {
                    q.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }
            }
            return temp;
        }

        public static int NumberOfLeafs(Node<T> root)
        {
            //var count = 0;

            //if (root == null)
            //    throw new Exception();

            //var q = new Queue<Node<T>>();

            //q.Enqueue(root);

            //while (q.Count > 0)
            //{
            //    var temp = q.Dequeue();

            //    if (temp.Left == null && temp.Right == null)
            //    {
            //        count++;
            //    }

            //    if (temp.Left != null)
            //    {
            //        q.Enqueue(temp.Left);
            //    }
            //    if (temp.Right != null)
            //    {
            //        q.Enqueue(temp.Right);
            //    }
            //}
            //return count;

            //ALTERNATİF
            return new BinaryTree<T>().LevelOrderTraversal(root).Where(x => x.Left == null && x.Right == null).ToList().Count;
        }



    }
}
