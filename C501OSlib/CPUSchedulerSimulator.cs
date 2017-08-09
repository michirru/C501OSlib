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
            CreateProcessList(length);
        }
        //----
        public void CreateRandomProcess(out List<Process> processListOut)
        {
            for (int i = 0; i < processList.Capacity && processList.Count != processList.Capacity; i++)
            {
                sp = new Process();
                processList.Add(sp);
            }
            processListOut = processList;
        }
        public void CreateProcessList(int length)
        {
            processList = new List<Process>(length);
            createQueue();
        }
        public string CreateProcess(int at, int bt, out List<Process> processListOut)
        {
            string msgOut;
            if (processList.Count < processList.Capacity)
            {
                var cp = new Process(at, bt);
                processList.Add(cp);
                msgOut = "Process Created";
            }
            else
            {
                msgOut = "Initial Process Limit Reached";
            }
            processListOut = processList;
            return msgOut;
        }
        private void createQueue()
        {
            readyQueue = new Queue<Process>(processList.Capacity);
            finishedProcess = new List<Process>(processList.Capacity);
        }
        //----
        public void simulate(out List<Process> processListOut, out Queue<Process> readyQueueOut, out List<Process> finishedProcessOut, out Process currentProcessOut, out int timeOut)
        {
            checkArrival();
            checkCurrentProcess();
            createCurrentProcess();
            IncreaseTime();
            processListOut = processList;
            readyQueueOut = readyQueue;
            finishedProcessOut = finishedProcess;
            currentProcessOut = algo.getCurrentProcess();
            timeOut = time;
        }
        private void checkArrival()
        {
            for (int i = 0; i < processList.Count; i++)
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
            bool allfinished = true;
            foreach (Process proc in processList)
            {
                if (!proc.isFinished())
                {
                    allfinished = false;
                }
            }
            if (!allfinished)
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
