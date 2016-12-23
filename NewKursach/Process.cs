using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class Process
    {
        private string name; // имя
        private int priority; // приоритет
        private int createdTime; // время создания
        private int timeProcessed; // время работы
        private int timeWaited; // время ожидания 
        public Process(string name,int priority, int createdTime)
        {
            this.name = name;
            this.priority = priority;
            this.createdTime = createdTime;
            this.timeProcessed = 0;
            this.timeWaited = 0;
        } 
    }
    
}
