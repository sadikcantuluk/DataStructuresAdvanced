using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T>
    {
        private readonly IQueue<T> _queue;
        public int Count => _queue.Count;
        public Queue(QueueType type = QueueType.Array)
        {
            if (type == QueueType.Array)
            {
                _queue = new ArrayQueue<T>();
            }
            else
            {
                _queue = new LinkedListQueue<T>();
            }

        }

        public void EnQueue(T item)
        {
            _queue.EnQueue(item);
        }

        public T DeQueue()
        {
            return _queue.DeQueue();
        }

        public T Peek()
        {
            return _queue.Peek();
        }

    }

    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T item);
        T DeQueue();
        T Peek();
    }

    public enum QueueType
    {
        Array = 0,
        LinkedList = 1
    }
}
