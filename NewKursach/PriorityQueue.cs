using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class BinaryHeap<T> 
    {
        private List<int> list;
        public List<int> list1
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }
        public int heapSize // размер кучи
        {
            get
            {
                return this.list.Count();
            }
        }

        public BinaryHeap() { } // бинарная куча. конструктор

        public void heapify(int i) //основное свойство кучи
        {
            int leftChild;
            int rightChild;
            int largestChild;  //предки для образования кучи

            for (;;)
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < heapSize && list[leftChild] > list[largestChild])
                {
                    largestChild = leftChild;
                }

                if (rightChild < heapSize && list[rightChild] > list[largestChild])
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                int temp = list[i];
                list[i] = list[largestChild];
                list[largestChild] = temp;
                i = largestChild;
            }
        }


        public void buildHeap(List<int> sourceArray) // образование кучи - построение
        {
            list = sourceArray.ToList();
            for (int i = heapSize / 2; i >= 0; i--)
            {
                heapify(i);
            }
        }


        public void add(int value) // метод добавления
        {
            list.Add(value);
            int i = heapSize - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && list[parent] < list[i])
            {
                int temp = list[i];
                list[i] = list[parent];
                list[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }


        public void delete(int index) // метод удаления 
        {
            list.RemoveAt(index);
        }


        public int First() // первый в очереди
        {
            int first = list[0];
            return first;
        }


        public bool empty() // очередь пуста
        {
            if (heapSize == 0)
                return true;
            else
                return false;
        }


        public void clean() // очистка очереди
        {
            list.Clear();
        }
    }
}
