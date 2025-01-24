using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class FixedSizeList<T>
    {
        T[] list;
        int count;
        int Capacity;
        public FixedSizeList(int capacity) 
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Invalid, Capacity must be greater than 0");
                return;
            }

            list = new T[capacity];
            count = 0;
            Capacity = capacity;

        }

        public void Add(T number)
        {
            if (count >= Capacity)
            {
                Console.WriteLine("The list is full");
                return;
            }
            list[count] =number;
            count++;
        }
        public object Get(int index) 
        {
            if (index <0 || index> count)
            {
                Console.WriteLine("Index out of Range");
            }
            return list[index];
        }

        public void PrintArray()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"{list[i]}");
            }
        }
    }
}
