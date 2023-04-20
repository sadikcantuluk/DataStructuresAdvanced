namespace Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> _innerList;
        public ArrayQueue()
        {
            _innerList = new List<T>();
        }
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("List is empt!");
            var temp = _innerList[0];
            _innerList.RemoveAt(0);
            Count--;
            return temp;

        }

        public void EnQueue(T item)
        {
            if (item is null)
                throw new ArgumentException();
            _innerList.Add(item);
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new Exception("List is empt!");
            return _innerList[0];
        }
    }
}