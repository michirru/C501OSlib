using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    public class CPUSchedulerSimulator
    {
        //----
        private Algorithm algo;
        private int time = 0;
        private Process[] process;
        private Queue<Process> readyQueue;
        private List<Process> finishedProcess;
        private Process sp;
        private bool preemptive = false;
        private bool autoSim = false;
        //----
        public CPUSchedulerSimulator(string alg)
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
        }
        //----
        public void CreateRandomProcess()
        {
            process = new Process[10];
            for (int i = 0; i < process.Length; i++)
            {
                process[i] = new Process();
            }
            createQueue();
        }
        public void createBatchProcess()
        {

        }
        private void createQueue()
        {
            readyQueue = new Queue<Process>(process.Length);
            finishedProcess = new List<Process>(process.Length);
        }
        //----
        public void simulate(bool at)
        {
            autoSim = at;

            checkArrival();
            checkCurrentProcess();
            createCurrentProcess();
            //increment time and decrement burst time method should be input here
        }
        public void checkArrival()
        {
            for (int i = 0; i < process.Length; i++)
            {
                sp = process[i];
                if (time == sp.getArrivalTime() && !sp.isArrived())
                {
                    readyQueue.Enqueue(sp);
                }
            }
            readyQueue = algo.sort(readyQueue);
        }
        public void createCurrentProcess()
        {
            if (!algo.isProcessing())
            {
                sp = readyQueue.Dequeue();
                algo.addProcess(sp);
            }
        }
        public void checkCurrentProcess()
        {
            if (algo.isProcessing())
            {
                sp = algo.getCurrentProcess();
                if (sp.getRemainingBurst() == 0)
                {
                    finishedProcess.Add(algo.removeProcess());
                }

                //int difference = algo.compare(sp, readyQueue.Peek());
                //if (difference >= 0)
                //{

                //}
            }
        }
    }
}
