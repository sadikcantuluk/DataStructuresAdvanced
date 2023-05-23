using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTree
{
    public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        {

        }

        public BinarySearchTree(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            if (value == null)
                throw new ArgumentNullException();

            var newNode = new Node<T>(value);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            var current = Root;
            Node<T> parent;

            while (true)
            {
                parent = current;
                //SOL
                if (value.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                    if (current is null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                //SAĞ
                else
                {
                    current = current.Right;
                    if (current is null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }
            }
        }
    }
}
