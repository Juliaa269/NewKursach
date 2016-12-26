using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class Process
    {
        public string name; // имя
        
        public int burstTime; //
        private int createdTime; // время создания
        private int timeProcessed; // время работы
        private int timeWaited; // время ожидания 

        public Process(string name,int burstTime, int createdTime)
        {
            this.name = name;
            this.burstTime = burstTime;
            this.createdTime = createdTime;
            this.timeProcessed = 0;
            this.timeWaited = 0;
        }

       
    }
    
}
