using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    // Current Process
    // Processor.BurstTime
    // tick
    class Device
    {
        private int currentTick = 0;
        public Process processInExecution = null;
        private int remainingProcessTime = 0;
        private Process finished;

        public void tick()
        {
            if (processInExecution != null)
            {
                remainingProcessTime--;
            }
            if (remainingProcessTime == 0)
            {
                if (processInExecution != null)
                {
                    finished = processInExecution;
                    processInExecution = null;
                }
            }
            currentTick++;
        }
        public int getCurrentTick()
        {
            return currentTick;
        }
        public void clear()
        {
            remainingProcessTime = 0;
            currentTick = 0;
        }

        // check if current Process is still executed
        // burstTime - execution time
        public void execute(Process process)
        {
            remainingProcessTime = process.burstTime;
            processInExecution = process;
        }
        public bool isFree()
        {
            return processInExecution == null;
        }

        public Process lastFinished() {
            Process process = finished;
            finished = null;
            return process;
        }
    }
}
