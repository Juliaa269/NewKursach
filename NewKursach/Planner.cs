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

        public List<Process> cpuQueue() {
            return processQueue.list();
        }

        public void tick() {
            processor.tick();
            createProcess();
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
