using LİnkedList.SinglyLinkedList;
namespace Stack
{
    internal class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> _ınnerList;
        public LinkedListStack()
        {
            _ınnerList = new SinglyLinkedList<T>();
        }
        public int Count => _ınnerList.Count;

        public T Peek()
        {
            return _ınnerList.Head is null ? default(T) : _ınnerList.Head.Value;
        }

        public T Pop()
        {
            return _ınnerList.RemoveFirst();
        }

        public void Push(T item)
        {
            _ınnerList.AddFirst(item);
        }
    }
}