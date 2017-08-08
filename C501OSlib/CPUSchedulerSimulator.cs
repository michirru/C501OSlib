using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C501OSlib
{
    public class CPUSchedulerSimulator
    {
        //----
        private Algorithm algo;
        private int time = 0;
        private List<Process> processList;
        private Queue<Process> readyQueue;
        private List<Process> finishedProcess;
        private Process sp;
        private bool preemptive = false;
        private bool autoSim = false;
        //----
        public CPUSchedulerSimulator(string alg, int length)
        {
            if (alg == "fifo")
            {
                algo = new FIFOalgorithm();
                preemptive = false;
            }
            else if (alg == "sjf")
            {
                algo = new SJFalgorithm();
                preemptive = false;
            }
            else if (alg == "prio")
            {
                algo = new HPRIalgorithm();
                preemptive = false;
            }
            processList = new List<Process>(length);
        }
        //----
        public void CreateRandomProcess(out List<Process> processListOut)
        {
            processList = new List<Process>(10);
            for (int i = 0; i < processList.Capacity; i++)
            {
                sp = new Process();
                processList.Add(sp);
            }
            createQueue();
            processListOut = processList;
        }
        public void CreateProcessList(int length)
        {
            processList = new List<Process>(length);
        }
        public string CreateProcess(int at, int bt)
        {
            var cp = new Process(at, bt);
            if (processList.Count < processList.Capacity)
            {
                processList.Add(cp);
                return "Process Created";
            }
            return "Initial Process Limit Reached";
        }
        private void createQueue()
        {
            readyQueue = new Queue<Process>(processList.Capacity);
            finishedProcess = new List<Process>(processList.Capacity);
        }
        //----
        public void simulate(out List<Process> processListOut, out Queue<Process> readyQueueOut, out List<Process> finishedProcessOut, out Process currentProcessOut, out int timeOut)
        {
            //autoSim = at;
            if (readyQueue.Count != 0 || algo.isProcessing())
            {
                IncreaseTime();
            }
            checkArrival();
            checkCurrentProcess();
            createCurrentProcess();
            processListOut = processList;
            readyQueueOut = readyQueue;
            finishedProcessOut = finishedProcess;
            currentProcessOut = algo.getCurrentProcess();
            timeOut = time;
        }
        private void checkArrival()
        {
            for (int i = 0; i < processList.Capacity; i++)
            {
                sp = processList.ElementAt(i);
                if (time == sp.getArrivalTime() && !sp.isArrived())
                {
                    readyQueue.Enqueue(sp);
                }
            }
            readyQueue = algo.sort(readyQueue);
        }
        private void createCurrentProcess()
        {
            if (!algo.isProcessing() && readyQueue.Count != 0)
            {
                sp = readyQueue.Dequeue();
                algo.addProcess(sp, time);
            }
        }
        private void checkCurrentProcess()
        {
            if (algo.isProcessing())
            {
                sp = algo.getCurrentProcess();
                if (sp.isFinished())
                {
                    finishedProcess.Add(algo.removeProcess());
                }
            }
        }
        private void IncreaseTime()
        {
            if (readyQueue.Count != 0 || algo.isProcessing())
            {
                time++;
                if (algo.isProcessing())
                {
                    sp = algo.getCurrentProcess();
                    sp.processing(time);
                }
            }
        }
    }
}
