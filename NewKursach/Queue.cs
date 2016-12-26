using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    /*
     * С помощью интерфейсов можно включить
     в класс поведение из нескольких источников.
     создаем интерфейс очереди
     и делаем две разные очереди
     процесс использует их компоновку
     */
    interface Queue // интерфейс очереди
    {
        void push(Process process); // declaration: добавить
        List<Process> list(); // список процессов
        Process pop(); // первый в очереди процесс
        bool isEmpty(); // очередь пуста
    }
}
