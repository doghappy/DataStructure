using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public class MyLinkQueueNode<T>
    {
        public T Data { get; set; }
        public MyLinkQueueNode<T> Next { get; set; }
    }

    public class MyLinkQueue<T>
    {
        public MyLinkQueue()
        {
            Front = new MyLinkQueueNode<T>();
            Rear = Front;
        }

        public MyLinkQueueNode<T> Front { get; set; }
        public MyLinkQueueNode<T> Rear { get; set; }

        public void Enqueue(T element)
        {
            var node = new MyLinkQueueNode<T>
            {
                Data = element
            };
            Rear.Next = node;
            Rear = node;
        }

        public T Dequeue()
        {
            if (Front == Rear)
            {
                throw new InvalidOperationException("队列为空，出队失败。");
            }
            var p = Front.Next;
            var data = p.Data;
            Front.Next = p.Next;
            if (Rear == p)
            {
                Rear = Front;
            }
            return data;
        }
    }
}
