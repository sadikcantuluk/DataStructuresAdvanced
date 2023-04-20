using LİnkedList.DoublyLinkedList;

namespace Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> _ınnerList;

        public LinkedListQueue()
        {
            _ınnerList = new DoublyLinkedList<T>();
        }
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("List is empt!");
            var temp = _ınnerList.Head.Value;
            _ınnerList.RemoveFirst();
            Count--;
            return temp;
        }

        public void EnQueue(T item)
        {
            if (item is null)
                throw new ArgumentException();
            _ınnerList.AddLast(item);
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new Exception("List is empt!");
            return _ınnerList.Head.Value;
        }
    }
}