using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    /*
     При невытесняющем SJF - планировании процессор предоставляется избранному процессу на все необходимое ему время, 
     независимо от событий, происходящих в вычислительной системе. 
   
    Рассмотрим пример работы невытесняющего алгоритма SJF. 
    Пусть в состоянии готовность находятся четыре процесса, p0, p1, p2 и p3, для которых известны времена их очередных CPU burst. 
    Эти времена приведены в таблице 3.4. Как и прежде, будем полагать, что вся деятельность процессов ограничивается использованием 
    только одного промежутка CPU burst, что процессы не совершают операций ввода-вывода и что временем переключения контекста можно пренебречь. 
     */
    class SJFQueue : Queue
    {
        List<Process> processes = new List<Process>();

        public void push(Process process)
        { // definition
            processes.Add(process);
            sort();
        }

        private void sort()
        {
            //  sort by process.burstTime 
        }

        public List<Process> list()
        {
            return processes;
        }

        public Process pop()
        {
            if (processes.Count() > 0)
            {
                Process process = processes[0];
                processes.Remove(process);
                return process;

            }

            return null;
        }
    }
}
