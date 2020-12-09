using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class MyLinkStackNode<T>
    {
        public T Data { get; set; }
        public MyLinkStackNode<T> Next { get; set; }
    }

    public class MyLinkStack<T>
    {
        public MyLinkStackNode<T> Top { get; private set; }
        public int Count { get; private set; }

        public void Push(T e)
        {
            var node = new MyLinkStackNode<T>
            {
                Data = e
            };
            node.Next = Top;
            Top = node;
            Count++;
        }

        public T Pop()
        {
            if (Top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var e = Top.Data;
            Top = Top.Next;
            return e;
        }
    }
}
