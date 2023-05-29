using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTree;

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

        public Node<T> FindMin(Node<T> root)
        {
            var current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public Node<T> FindMax(Node<T> root)
        {
            var current = root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current;
        }

        public Node<T> Find(Node<T> root, T key)
        {
            var current = root;
            while (key.CompareTo(current.Value) != 0)
            {
                if (key.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    throw new Exception("Değer bulunamadı!");
                }
            }
            return current;
        }

        public Node<T> Remove(Node<T> root, T key)
        {
            if (root == null)
                throw new ArgumentNullException("root");

            // rekürsif ilerle 
            if (key.CompareTo(root.Value) < 0)
            {
                root.Left = Remove(root.Left, key);
            }
            else if (key.CompareTo(root.Value) > 0)
            {
                root.Right = Remove(root.Right, key);
            }
            else
            {
                // silme işlevini uygulayabiliriz. 
                // tek cocuk ya da cocuksuz
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                // iki cocuk 
                root.Value = FindMin(root.Right).Value;
                root.Right = Remove(root.Right, root.Value);
            }
            return root;
        }

       


    }
}
