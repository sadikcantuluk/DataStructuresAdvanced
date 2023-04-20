namespace Stack
{
    internal class ArrayStack<T> : IStack<T>
    {
        private readonly List<T> _ınnerLıst;

        public ArrayStack()
        {
            _ınnerLıst = new List<T>();
        }

        public int Count { get; private set; }

        public T Peek()
        {
            if (Count == 0)
                throw new Exception("List is empty!");
            return _ınnerLıst[_ınnerLıst.Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
                throw new Exception("List is empty!");

            var removeItem = _ınnerLıst[_ınnerLıst.Count - 1];
            _ınnerLıst.RemoveAt(0);
            Count--;
            return removeItem;
        }

        public void Push(T item)
        {
            if (item is null)
                throw new ArgumentNullException();
            _ınnerLıst.Add(item);
            Count++;
        }
    }
}