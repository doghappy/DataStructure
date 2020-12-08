using System;

namespace DataStructure.LinearList
{
    public class StaticLinkListNode<T>
    {
        public T Data { get; set; }
        public int Cursor { get; set; }
    }

    public class StaticLinkList<T>
    {
        public StaticLinkList(int length)
        {
            Data = new StaticLinkListNode<T>[length + 2];
            for (int i = 0; i < Data.Length - 1; i++)
            {
                Data[i] = new StaticLinkListNode<T>
                {
                    Cursor = i + 1
                };
            }
            Data[^1].Cursor = 0;
        }

        private StaticLinkListNode<T>[] Data { get; }

        public void Insert(int index, T data)
        {
            if (index < 0 || index > Data.Length - 2)
            {
                throw new IndexOutOfRangeException();
            }
            // 最后一个元素 cur 用来存储第一个有数值的元素下标
            int k = Data.Length - 1;
            int newIndex = GetNextIndex();
            Data[newIndex].Data = data;
            for (int i = 0; i < index; i++)
            {
                // 寻找 index 的前一个元素
                k = Data[k].Cursor;
            }
            Data[newIndex].Cursor = Data[k].Cursor;
            Data[k].Cursor = newIndex;
        }

        private int GetNextIndex()
        {
            // 数组第一个元素用来存储备用链的第一个元素
            int i = Data[0].Cursor;
            // 把备用链元素改成要取出的下一个Cursor
            Data[0].Cursor = Data[i].Cursor;
            return i;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > Data.Length - 2)
            {
                throw new IndexOutOfRangeException();
            }
            // 最后一个元素 cur 用来存储第一个有数值的元素下标
            int k = Data.Length - 1;
            for (int i = 0; i < index; i++)
            {
                // 寻找 index 的前一个元素
                k = Data[k].Cursor;
            }
            // 要删除的元素的真实索引
            int j = Data[k].Cursor;
            Data[k].Cursor = Data[j].Cursor;
            // 把删除的元素的 Cursor 指向 Data[0].Cursor
            Data[j].Cursor = Data[0].Cursor;
            // Data[0].Cursor 指向删除的索引
            Data[0].Cursor = j;
        }
    }
}
