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
        private Queue<Process> finishedQueue;
        private Process sp;
        private bool autoSim = false;
        //----
        public CPUSchedulerSimulator(string alg)
        {
            if (alg == "fifo")
            {
                algo = new FIFOalgorithm();
            }
            else if (alg == "sjf")
            {
                algo = new SJFalgorithm();
            }
            else if (alg == "prio")
            {
                algo = new HPRIalgorithm();
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
            finishedQueue = new Queue<Process>(process.Length);
        }
        //----
        public void simulate(bool at)
        {
            autoSim = at;
            
            checkArrival();
            checkReadyQueue();
            checkCurrentProcess();

        }
        public void checkArrival()
        {
            for (int i = 0; i < process.Length; i++)
            {
                sp = process[i];
                if (time == sp.getArrivalTime())
                {
                    readyQueue.Enqueue(sp);
                    algo.sort(readyQueue);
                }
            }
        }
        public void checkReadyQueue()
        {
            if (!algo.isProcessing())
            {
                sp = readyQueue.Dequeue();
                algo.addProcess(sp);
            }
        }
        public void checkCurrentProcess()
        {

        }
    }
}
