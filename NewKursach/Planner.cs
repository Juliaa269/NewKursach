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

        private Random rnd = new Random();

        public Planner()
        {
            Process p0 = new Process("P000", 0, 0);
            Process p1 = new Process("P001", 0, 0);
            Process p2 = new Process("P002", 0, 0);
            Process p3 = new Process("P003", 0, 0);
            processQueue.push(p0);
            processQueue.push(p1);
            processQueue.push(p2);
            processQueue.push(p3);
        }

        public List<Process> cpuQueue() {
            return processQueue.list();
        }

        public void tick() {
            if (processor.isFree())
            {
                processor.execute(getLowestBurstTimeProcess());
            }
            processor.tick();
            // createProcess();
        }

        private Process getLowestBurstTimeProcess() {
            return processQueue.pop();
        }

        public int getCurrentTick() {
            return processor.getCurrentTick();
        }

        public void clear() {
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


    }
}
