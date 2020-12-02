using System;

namespace DataStructure.LinearList
{
    public class LinearArrayList<T>
    {
        public LinearArrayList(int maxLength)
        {
            MaxLength = maxLength;
            Data = new T[MaxLength];
        }

        public T this[int index]
        {
            get
            {
                if (index > Length - 1)
                    throw new IndexOutOfRangeException();
                else
                    return Data[index];
            }
            //set => Data[index] = value;
        }

        private T[] Data { get; }

        public int Length { get; private set; }
        public int MaxLength { get; }


        public void Insert(int index, T element)
        {
            if (Length == MaxLength || index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = Length - 1; i >= index; i--)
            {
                Data[i + 1] = Data[i];
            }
            Data[index] = element;
            Length++;
        }

        public void Remove(int index)
        {
            if (Length == 0 || index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index < Length - 1)
            {
                for (int i = index + 1; i < Length; i++)
                {
                    Data[i - 1] = Data[i];
                }
            }
            Length--;
        }
    }
}
