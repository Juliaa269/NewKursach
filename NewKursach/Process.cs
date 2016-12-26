using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    enum Resource {
        VIDEO_CARD,
        SOUND_CARD,
        HDD,
        NONE
    }

    class Process
    {
        public string name; // имя
        public Resource resource;
        public int burstTime; //
        private int createdTime; // время создания
        private int timeStarted; // время работы

        public Process(string name, int burstTime, int createdTime, Resource resource) {
            this.name = name;
            this.burstTime = burstTime;
            this.createdTime = createdTime;
            this.timeStarted = 0;
            this.resource = resource;
        }

        public Process(string name,int burstTime, int createdTime): this(name, burstTime, createdTime, Resource.NONE)
        {
        }

        public void executionStarted(int time) {
            timeStarted = time;
        }

        public int timeWaited() {
            return timeStarted - createdTime;
        }
       
    }
    
}
