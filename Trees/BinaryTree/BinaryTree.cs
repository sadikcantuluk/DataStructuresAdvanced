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
        public List<Node<T>> InOrder(Node<T> root)
        {
            if (!(root == null))
            {
                InOrder(root.Left);
                //Console.WriteLine(root);
                nodeList.Add(root);
                InOrder(root.Right);
            }
            return nodeList;
        }

        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (!(root == null))
            {
                //Console.WriteLine(root);
                nodeList.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return nodeList;
        }

        public List<Node<T>> PostOrder(Node<T> root)
        {
            if (!(root == null))
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                //Console.WriteLine(root);
                nodeList.Add(root);
            }
            return nodeList;
        }



    }
}
