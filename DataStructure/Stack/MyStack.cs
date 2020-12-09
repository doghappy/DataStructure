using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class MyStack<T>
    {
        public MyStack(int maxSize)
        {
            Data = new T[maxSize];
            Top = -1;
        }

        private T[] Data { get; }
        public int Top { get; private set; }

        public void Push(T element)
        {
            if (Top >= Data.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            Top++;
            Data[Top] = element;
        }

        public T Pop()
        {
            if (Top == -1)
            {
                throw new IndexOutOfRangeException();
            }
            var e = Data[Top];
            Top--;
            return e;
        }
    }
}
