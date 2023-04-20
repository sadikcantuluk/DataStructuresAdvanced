using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LİnkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        private int _count;
        public SinglyLinkedListNode<T> Head { get; set; }

        private bool isHeadNull => Head == null;

        public int Count => _count;

        public SinglyLinkedList()
        {

        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddFirst(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
            _count++;

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
            _count++;
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
            _count++;
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
                    _count++;
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
                    _count++;
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
                    _count++;
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
                    _count++;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothing to remove.");

            var firstValue = Head.Value;
            Head = Head.Next;
            _count--;
            return firstValue;
        }

        public T RemoveLast()
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothing to remove.");
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastValue = prev.Next.Value;
            prev.Next = null;
            _count--;
            return lastValue;
        }

        public void Remove(T value)
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothing to remove.");
            if (value == null)
                throw new ArgumentNullException();
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    //Listenin son elemanı mı?
                    if (current.Next == null)
                    {
                        //Listenin tek (Head) elemanı mı var?
                        if (prev == null)
                        {
                            Head = null;
                            _count--;
                            return;
                        }
                        else
                        {
                            RemoveLast();
                            return;
                        }
                    }
                    else
                    {
                        if (prev == null)
                        {
                            Head = Head.Next;
                            _count--;
                            return;
                        }
                        else
                        {
                            prev.Next = current.Next;
                            _count--;
                            return;
                        }
                    }
                }
                prev = current;
                current = current.Next;
            }
            throw new ArgumentException("The value could not be found in the list.");
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
