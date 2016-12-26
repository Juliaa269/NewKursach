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
        
        private Queue processQueue = new SJFQueue();
        private Processor processor = new Processor();
        public const float intensivity = 0.5f;

        private Queue stat = new SJFQueue();

        private Queue staticus = new SJFQueue();

        private Random rnd = new Random();

        public Planner()
        {
            Process p0 = new Process("P000", 15, 0);
            Process p1 = new Process("P001", 9, 0);
            Process p2 = new Process("P002", 21, 0);
            Process p3 = new Process("P003", 3, 0);
            processQueue.push(p0);
            processQueue.push(p1);
            processQueue.push(p2);
            processQueue.push(p3);
        }

        public List<Process> cpuQueue() // очередь к ЦП
        {
            return processQueue.list();
        }

        public Process current_CPU()
        {
            return processor.processInExecution;
        }

        public List<Process> staticusss()
        {
            return staticus.list();
        }

        // [0]current process = null
        // [0]isFree = true
        // [0]current process = Process("P003", 1, 0);
        // [1]isFree = true
        // [1]currentProcess = Process("P001", 3, 0)
        // [2]isFree = false
        // [3]isFree = false
        // [4]isFree = true
        public void tick() // ?
        {
            if (processor.isFree())
            {
                Process currentProcess = getLowestBurstTimeProcess();
                processor.execute(currentProcess);
            }
            processor.tick();
            // createProcess();
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
                int priority = rnd.Next(100);
                Process regularProcess = new Process(name, priority, createdTime);
                processQueue.push(regularProcess);
            }
        }

        public List<Process> currentCPU()
        {
            return stat.list();
        }
        
        //    private void generateProcesses() // создание процесса (если он меньше интенсивности)
        //    {
        //       double generate = rnd.NextDouble();
        //
        //           string name = "P" + processor.getCurrentTick();
        //                int createdTime = processor.getCurrentTick();
        //          int priority = rnd.Next(100);
        //         Process regularProcess = new Process(name, priority, createdTime);
        //         processQueue.push(regularProcess);
        //    
        //}
    }
}
