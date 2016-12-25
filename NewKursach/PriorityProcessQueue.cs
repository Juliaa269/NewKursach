using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKursach
{
    class PriorityProcessQueue : Queue
    {
        List<Process> processes = new List<Process>();

        public void push(Process process) { // definition
            processes.Add(process);
        }

        public List<Process> list() {

            return processes;
        }
    }
}
