using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİnkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        private int _count = 0;
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        public bool isHeadNull => Head == null;

        public int Count => _count;

        public DoublyLinkedList()
        {

        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            Head = newNode;

            if (Tail == null)
            {
                Tail = Head;
            }
            _count++;
        }
        public void AddLast(T value)
        {
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new DoublyLinkedListNode<T>(value);

            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
            _count++;
        }

        public void AddAfter(DoublyLinkedListNode<T> refNode, T value)
        {
            if (refNode == null || value == null)
                throw new ArgumentNullException();

            var newNode = new DoublyLinkedListNode<T>(value);

            if (refNode == Head && refNode == Tail)
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next = newNode;
                refNode.Prev = null;

                Head = refNode;
                Tail = newNode;
                _count++;

                return;
            }

            if (Tail != refNode)
            {
                newNode.Next = refNode.Next;
                newNode.Prev = refNode;

                refNode.Next = newNode;
                refNode.Next.Prev = newNode;
                _count++;

                return;
            }

            else
            {
                AddLast(value);
                return;
            }


        }

        public void AddBefore(DoublyLinkedListNode<T> refNode, T value)
        {
            if (refNode == null || value == null)
                throw new ArgumentNullException();

            var newNode = new DoublyLinkedListNode<T>(value);

            if (refNode == Head && refNode == Tail)
            {
                AddFirst(value);
                return;
            }

            if (Head != refNode)
            {
                newNode.Next = refNode;
                newNode.Prev = refNode.Prev;

                refNode.Prev = newNode;
                refNode.Prev.Next = newNode;
                _count++;

                return;
            }

            else
            {
                //newNode.Next = refNode;
                //newNode.Prev = null;

                //refNode.Prev = newNode;

                //Head = newNode;

                //return;

                AddFirst(value);
                return;
            }
        }

        private List<DoublyLinkedListNode<T>> GetAllNode()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new Exception("Collection has not item.");
            }

            var temp = Head.Value;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
                _count--;
                return temp;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            _count--;
            return temp;
        }

        public T RemoveLast()
        {
            if (isHeadNull)
            {
                throw new Exception("Collection has not item.");
            }

            var temp = Head.Value;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
                _count--;
                return temp;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            _count--;
            return temp;
        }

        public void Remove(T value)
        {
            //if (value == null)
            //    throw new ArgumentNullException();

            //var current = Head;
            //while (current != null)
            //{
            //    if (current.Value.Equals(value))
            //    {
            //        if (current.Prev == null)
            //        {
            //            RemoveFirst();
            //            return;
            //        }
            //        else if (current.Next == null)
            //        {
            //            RemoveLast();
            //            return;
            //        }
            //        else
            //        {
            //            current.Prev.Next = current.Next;
            //            current.Next.Prev = current.Prev;
            //            return;
            //        }
            //    }
            //    current = current.Next;
            //}

            if (isHeadNull)
                throw new Exception("Empty list.");
            if (Head == Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current.Prev == null)
                    {
                        current.Next.Prev = null;
                        Head = current.Next;
                    }
                    else if (current.Next == null)
                    {
                        current.Prev.Next = null;
                        Tail = current.Prev;
                    }
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                    _count--;
                    break;
                }
                current = current.Next;
            }

        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNode().GetEnumerator();
        }
    }
}
