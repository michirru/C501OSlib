using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    class Algorithm
    {
        protected Process currentProcess;
        protected Process tempProc;
        protected Process[] queueToArray;
        protected Queue<Process> sorted;
        protected bool gotProcess = false;

        public abstract Queue<Process> sort(Queue<Process> q);
        public abstract void l1Sort(Process[] p);
        public abstract Process[] l2Sort(Process p1, Process p2);
        public bool addProcess(Process proc)
        {
            if (!gotProcess)
            {
                tempProc = null;
                currentProcess = proc;
                gotProcess = true;
                return gotProcess;
            }
            else { return gotProcess; }
        }
        public Process removeProcess()
        {
            tempProc = null;
            tempProc = currentProcess;
            currentProcess = null;
            return tempProc;
        }

        public Process getCurrentProcess() { return currentProcess; }
        public bool isProcessing() { return gotProcess; }
    }
}
