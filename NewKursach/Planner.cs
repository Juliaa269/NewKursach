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

        private Device processor = new Device();
        private Device videoCard = new Device();
        private Device soundCard = new Device();
        private Device hdd = new Device();

        public const float intensivity = 0.5f;

        private LinkedList<Process> videoCardResourceQueue = new LinkedList<Process>();
        private LinkedList<Process> soundCardResourceQueue = new LinkedList<Process>();
        private LinkedList<Process> hddResourceQueue = new LinkedList<Process>();
        private LinkedList<Process> finishedProcesses = new LinkedList<Process>();

        private Random rnd = new Random();

        private Statistic statistic = new Statistic();

        public Planner()
        {
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

            update(videoCard, videoCardResourceQueue);
            update(soundCard, soundCardResourceQueue);
            update(hdd, hddResourceQueue);

            if (processor.isFree() && !processQueue.isEmpty())
            {
                manageFinishedProcess();

                Process currentProcess = getLowestBurstTimeProcess();
                processor.execute(currentProcess);
                currentProcess.executionStarted(processor.getCurrentTick());
            }

            if (processor.isFree()) {
                statistic.procIdleTick();
            }

            processor.tick();
            videoCard.tick();
            soundCard.tick();
            hdd.tick();
        }

        private void update(Device device, LinkedList<Process> queue)
        {
            if (device.isFree())
            {
                manageFinishedResourceProcess(device);

                if (queue.Count() > 0)
                {
                    Process waitingProcess = queue.Last();
                    device.execute(waitingProcess);
                    queue.RemoveLast();
                }
            }
        }

        private void manageFinishedResourceProcess(Device device)
        {
            Process finishedProcess = device.lastFinished();
            if (finishedProcess != null)
                onProcessFinished(finishedProcess);
        }

        private void manageFinishedProcess()
        {
            Process finishedProcess = processor.lastFinished();
            if (finishedProcess != null)
            {
                switch (finishedProcess.resource)
                {
                    case Resource.VIDEO_CARD: videoCardResourceQueue.AddFirst(finishedProcess); break;
                    case Resource.SOUND_CARD: soundCardResourceQueue.AddFirst(finishedProcess); break;
                    case Resource.HDD: hddResourceQueue.AddFirst(finishedProcess); break;
                    case Resource.NONE: onProcessFinished(finishedProcess); break;
                }
            }
        }

        private void onProcessFinished(Process finishedProcess) {
            statistic.processFinished();
            statistic.addTimeWaited(finishedProcess.timeWaited());
            finishedProcesses.AddFirst(finishedProcess);
        }

        private void updateProcessQueue()
        {
            double generate = rnd.NextDouble();

            if (generate <= intensivity)
            {
                Process generatredProcess = generateProcess();
                processQueue.push(generatredProcess);
                statistic.proceesAdded();
                statistic.maxQueueLength(processQueue.list().Count());
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
            statistic = new Statistic();

            processor.clear();
            videoCard.clear();
            hdd.clear();
            soundCard.clear();

            videoCardResourceQueue = new LinkedList<Process>();
            soundCardResourceQueue = new LinkedList<Process>();
            hddResourceQueue = new LinkedList<Process>();
            finishedProcesses = new LinkedList<Process>();

        }

        private Process generateProcess() // создание процесса (если он меньше интенсивности)
        {
            string name = "P" + processor.getCurrentTick();
            int createdTime = processor.getCurrentTick();
            int burstTime = rnd.Next(100) + 10;
            return new Process(name, burstTime, createdTime, randResource());
        }

        private Resource randResource()
        {
            int rand = rnd.Next(5);
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


        public LinkedList<Process> videoCardWaitingQueue()
        {
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

        public Process currentVideoCardProcess()
        {
            return videoCard.processInExecution;
        }

        public Process currentSoundCardProcess()
        {
            return soundCard.processInExecution;
        }

        public Process currentHddProcess()
        {
            return hdd.processInExecution;
        }

        public Statistic summary()
        {
            return statistic;
        }
    }
}
