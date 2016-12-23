using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class Processor
    {
        private int currentTick = 0;

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
        
    }
}
