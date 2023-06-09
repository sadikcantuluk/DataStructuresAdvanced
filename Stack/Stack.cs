﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> stack;
        public int Count => stack.Count;

        public Stack(StackType type = StackType.Array)
        {
            if (type == StackType.Array)
            {
                stack = new ArrayStack<T>();
            }
            else
            {
                stack = new LinkedListStack<T>();
            }
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public T Peek()
        {
            return stack.Peek();
        }

        public void Push(T item)
        {
            stack.Push(item);
        }
    }

    public interface IStack<T>
    {
        int Count { get; }
        void Push(T item);
        T Pop();
        T Peek();
    }

    public enum StackType
    {
        Array = 0,
        LinkedList = 1
    }
}
