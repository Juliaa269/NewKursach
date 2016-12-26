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

        private Queue processQueue = new BinaryHeap();
        private Processor processor = new Processor();
        public const float intensivity = 0.5f;

        private LinkedList<Process> videoCardResourceQueue = new LinkedList<Process>();
        private LinkedList<Process> soundCardResourceQueue = new LinkedList<Process>();
        private LinkedList<Process> hddResourceQueue = new LinkedList<Process>();
        private LinkedList<Process> finishedProcesses = new LinkedList<Process>();

        private Queue stat = new SJFQueue();

        private Random rnd = new Random();

        public Planner()
        {
            videoCardResourceQueue.AddFirst(generateProcess());
            soundCardResourceQueue.AddFirst(generateProcess());
            hddResourceQueue.AddFirst(generateProcess());
        }

        public List<Process> cpuQueue() // очередь к ЦП
        {
            return processQueue.list();
        }

        public Process current_CPU() // текущий ЦП
        {
            return processor.processInExecution;
        }

        public LinkedList<Process> staticusss() // статистика
        {
            return finishedProcesses;
        }

        // [0]current process = null
        // [0]isFree = true
        // [0]current process = Process("P003", 1, 0);
        // [1]isFree = true
        // [1]currentProcess = Process("P001", 3, 0)
        // [2]isFree = false
        // [3]isFree = false
        // [4]isFree = true
        public void tick() // тик
        {
            updateProcessQueue();

            if (processor.isFree() && !processQueue.isEmpty())
            {
                manageFinishedProcess();

                Process currentProcess = getLowestBurstTimeProcess();
                processor.execute(currentProcess);
            }

            processor.tick();
        }

        private void manageFinishedProcess() {
            Process finishedProcess = processor.lastFinished();
            if (finishedProcess != null)
            {
                switch (finishedProcess.resource)
                {
                    case Resource.VIDEO_CARD: videoCardResourceQueue.AddFirst(finishedProcess); break;
                    case Resource.SOUND_CARD: soundCardResourceQueue.AddFirst(finishedProcess); break;
                    case Resource.HDD: hddResourceQueue.AddFirst(finishedProcess); break;
                    case Resource.NONE: finishedProcesses.AddFirst(finishedProcess); break;
                }
            }
        }
        private void updateProcessQueue() {
            double generate = rnd.NextDouble();

            if (generate <= intensivity)
            {
                Process generatredProcess = generateProcess();
                processQueue.push(generatredProcess);
            }
        }

        private Process getLowestBurstTimeProcess() // получаем наименьшее интервал обслуживания
        {
            return processQueue.pop();
        }

        public int getCurrentTick() // получаем текущий такт
        {
            return processor.getCurrentTick();
        }

        public void clear() // очищаем
        {
            processor.clear();
        }

        private Process generateProcess() // создание процесса (если он меньше интенсивности)
        {
            string name = "P" + processor.getCurrentTick();
            int createdTime = processor.getCurrentTick();
            int burstTime = rnd.Next(20);
            return new Process(name, burstTime, createdTime, randResource());
        }

        private Resource randResource()
        {
            int rand = rnd.Next(10);
            Resource generatedResource;

            switch (rand)
            {
                case 0: generatedResource = Resource.VIDEO_CARD; break;
                case 1: generatedResource = Resource.SOUND_CARD; break;
                case 2: generatedResource = Resource.HDD; break;

                default: generatedResource = Resource.NONE; break;
            }

            return generatedResource;
        }

        public List<Process> currentCPU() // текущий ЦП
        {
            return stat.list();
        }

        public LinkedList<Process> videoCardWaitingQueue() {
            return videoCardResourceQueue;
        }

        public LinkedList<Process> hddWaitingQueue()
        {
            return hddResourceQueue;
        }

        public LinkedList<Process> soundCardWaitingQueue()
        {
            return soundCardResourceQueue;
        }

    }
}
