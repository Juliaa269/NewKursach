using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class Statistic
    {
        private int totalProcesses = 0;
        private int finishedProcesses = 0;
        private int processorIdle = 0;
        private int currentQueueLength = 0;
        private List<int> timeWaited = new List<int>();
        public Statistic()
        {
            //processName = 0;

        }
        public void Clear()
        {
            //processName = 0;
        }

        public void proceesAdded() {
            totalProcesses++;
        }
        public void processFinished() {
            finishedProcesses++;
        }

        public void addTimeWaited(int time) {
            timeWaited.Add(time);
        }

        public void procIdleTick() {
            processorIdle++;
        }

        public void maxQueueLength(int currentQueueLength) {
            this.currentQueueLength = Math.Max(currentQueueLength, this.currentQueueLength);
        }

        public int totalCreated() {
            return totalProcesses;
        }
        public int totalFinished()
        {
            return finishedProcesses;
        }
        public int avgWaitTime()
        {
            if (timeWaited.Count() == 0)
                return 0;

            int sum = 0;
            foreach(int time in timeWaited)
            {
                sum += time;
            }
            return sum / timeWaited.Count(); ;
        }
        public int maxQueueLength()
        {
            return currentQueueLength;
        }
        public int procIdle()
        {
            return processorIdle;
        }
    }
}
