using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LİnkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        private bool isHeadNull => Head == null;

        public SinglyLinkedList()
        {
            
        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddFirst(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;

            #region Not
            //T tipinde gelen value değerine node yapısı kazandırdık
            // newnoe'a senin next işaretçin Head'i göstersin dedik.
            //Sonrada Head'i newNoda'a eşitledik.
            #endregion
        }

        public void AddFirst(SinglyLinkedListNode<T> newNode)
        {
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;

            while (current != null)
            {
                if (current == node)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public void AddAfter(SinglyLinkedListNode<T> refnode, SinglyLinkedListNode<T> newNode)
        {
            if (refnode == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(newNode);
                return;
            }

            var current = Head;

            while (current != null)
            {
                if (current == refnode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var current = Head;

            while (current.Next != null)
            {
                if (current.Next == node)
                {
                    current.Next = newNode;
                    newNode.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public void AddBefore(SinglyLinkedListNode<T> refnode, SinglyLinkedListNode<T> newNode)
        {
            if (refnode == null)
            {
                throw new ArgumentNullException();
            }

            if (isHeadNull)
            {
                AddFirst(newNode);
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                if (current.Next == refnode)
                {
                    current.Next = newNode;
                    newNode.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
