using System;

namespace DataStructure.LinearList
{
    public class LinearLinkListNode<T>
    {
        public LinearLinkListNode<T> Next { get; set; }
        public T Data { get; set; }

        public LinearLinkListNode() { }

        public LinearLinkListNode(T data)
        {
            Data = data;
        }
    }

    public class LinearLinkList<T>
    {
        public LinearLinkList()
        {
            Head = new LinearLinkListNode<T>();
        }

        public LinearLinkListNode<T> Head { get; }

        public LinearLinkListNode<T> this[int index]
        {
            get
            {
                if (index < 0)
                    return null;
                var node = Head.Next;
                for (int i = 0; i < index; i++)
                {
                    if (node == null)
                        return null;
                    else
                        node = node.Next;
                }
                return node;
            }
        }

        public void Insert(int index, LinearLinkListNode<T> value)
        {
            if (index < 0)
                throw new ArgumentException();
            var node = Head;
            for (int i = 0; i < index; i++)
            {
                if (node == null)
                    throw new ArgumentException();
                else
                    node = node.Next;
            }
            var temp = node.Next;
            node.Next = value;
            if (value != null)
                value.Next = temp;
        }

        public void DeleteAt(int index)
        {
            if (index < 0)
                throw new ArgumentException();
            var node = Head;
            for (int i = 0; i < index; i++)
            {
                if (node == null)
                    throw new ArgumentException();
                else
                    node = node.Next;
            }
            if (node.Next == null)
                throw new IndexOutOfRangeException();
            else
                node.Next = node.Next.Next;
        }
    }
}
