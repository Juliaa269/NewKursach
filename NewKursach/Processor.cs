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
    class Processor
    {
       
        
        Process currentProcess;
        private int currentTick = 0;
        public Process processInExecution = null;

        public void tick()
        {
            currentTick++;
        }
        public int getCurrentTick()
        {
            return currentTick;
        }
        public void clear()
        {
            currentTick = 0;
        }

        // check if current Process is still executed
        // burstTime - execution time
        public bool isFree()
        {
            if(currentProcess.burstTime <= 0)
            //Processor.getCurrentTick() = n;
            {
                return currentProcess.burstTime == 0;;
            }
        }
        // 
        public void execute(Process process)
        {
            int remainingTime = process.burstTime;
           
        }
        
    }
}
