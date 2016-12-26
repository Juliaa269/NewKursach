using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class BinaryHeap : Queue
    {
        private List<Process> values = new List<Process>();
        
        public int heapSize // размер кучи
        {
            get
            {
                return this.values.Count();
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

                if (leftChild < heapSize && values[leftChild].burstTime > values[largestChild].burstTime)
                {
                    largestChild = leftChild;
                }

                if (rightChild < heapSize && values[rightChild].burstTime > values[largestChild].burstTime)
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                Process temp = values[i];
                values[i] = values[largestChild];
                values[largestChild] = temp;
                i = largestChild;
            }
        }

        public void buildHeap(List<Process> sourceArray) // образование кучи - построение
        {
            values = sourceArray.ToList();
            for (int i = heapSize / 2; i >= 0; i--)
            {
                heapify(i);
            }
        }


        public void push(Process value) // метод добавления
        {
            values.Add(value);
            sort(values, values.Count);
        }

        public void heapify(List<Process> values, int pos, int n)
        {
            Process temp;
            while (2 * pos + 1 < n)
            {
                int t = 2 * pos + 1;
                if (2 * pos + 2 < n && values[2 * pos + 2].burstTime >= values[t].burstTime)
                {
                    t = 2 * pos + 2;
                }
                if (values[pos].burstTime < values[t].burstTime)
                {
                    temp = values[pos];
                    values[pos] = values[t];
                    values[t] = temp;
                    pos = t;
                }
                else break;
            }
        }
        public void makeHeap(List<Process> values, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                heapify(values, i, n);
            }
        }
        public void sort(List<Process> values, int n)
        {
            Process temp;
            makeHeap(values, n);
            while (n > 0)
            {
                temp = values[0];
                values[0] = values[n - 1];
                values[n - 1] = temp;
                n--;
                heapify(values, 0, n);
            }
        }

        public void delete(int index) // метод удаления 
        {
            values.RemoveAt(index);
        }

        public Process pop() // первый в очереди
        {
            Process process = values[0];
            delete(0);
            return process;
        }

        public bool isEmpty() // очередь пуста
        {
            if (heapSize == 0)
                return true;
            else
                return false;
        }

        public void clean() // очистка очереди
        {
            values.Clear();
        }

        public List<Process> list()
        {
            return values;
        }
    }
}
