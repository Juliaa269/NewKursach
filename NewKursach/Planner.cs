using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class Planner
    {
        // BackGround
        
        private Queue processQueue = new BinaryHeap();
        private Processor processor = new Processor();
        public const float intensivity = 0.5f;

        private Queue stat = new SJFQueue();


        private Random rnd = new Random();

        public Planner()
        {
           /* Process p0 = new Process("P000", 5 * 15, 0);
            Process p1 = new Process("P001", 5 * 9, 0);
            Process p2 = new Process("P002", 5 * 21, 0);
            Process p3 = new Process("P003", 5*3, 0);
            processQueue.push(p0);
            processQueue.push(p1);
            processQueue.push(p2);
            processQueue.push(p3);*/
        }

        public List<Process> cpuQueue() // очередь к ЦП
        {
            return processQueue.list();
        }

        public Process current_CPU() // текущий ЦП
        {
            return processor.processInExecution;
        }

        public List<Process> staticusss() // статистика
        {
            return processor.finishedProcesses();
        }

        // [0]current process = null
        // [0]isFree = true
        // [0]current process = Process("P003", 1, 0);
        // [1]isFree = true
        // [1]currentProcess = Process("P001", 3, 0)
        // [2]isFree = false
        // [3]isFree = false
        // [4]isFree = true
        public void tick() // тик
        {
            createProcess();
            if (processor.isFree() && !processQueue.isEmpty())
            { 
                Process currentProcess = getLowestBurstTimeProcess();
                processor.execute(currentProcess);
            }
            processor.tick();
           
        }

        private Process getLowestBurstTimeProcess() // получаем наименьшее интервал обслуживания
        {
            return processQueue.pop();
        }

        public int getCurrentTick() // получаем текущий такт
        {
            return processor.getCurrentTick();
        }

        public void clear() // очищаем
        {
            processor.clear();
        }

        private void createProcess() // создание процесса (если он меньше интенсивности)
        {
            double generate = rnd.NextDouble();

            if (generate <= intensivity)
            {
                string name = "P" + processor.getCurrentTick();
                int createdTime = processor.getCurrentTick();
                int burstTime = rnd.Next(20);
                Process regularProcess = new Process(name, burstTime, createdTime);
                processQueue.push(regularProcess);
            }
        }

        public List<Process> currentCPU() // текущий ЦП
        {
            return stat.list();
        }
        
    }
}
