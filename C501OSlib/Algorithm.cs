using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    public abstract class Algorithm
    {
        protected Process currentProcess;
        protected Process tempProc;
        protected Queue<Process> sorted;
        protected bool gotProcess = false;

        public abstract Queue<Process> sort(Queue<Process> q);
        public abstract string getName();

        public bool addProcess(Process proc, int time)
        {
            if (!gotProcess)
            {
                tempProc = null;
                proc.setStartTime(time);
                
                currentProcess = proc;
                gotProcess = true;
                return gotProcess;
            }
            else { return gotProcess; }
        }
        public Process removeProcess()
        {
            currentProcess.stopRunning();
            tempProc = currentProcess;
            currentProcess = null;
            gotProcess = false;
            return tempProc;
        }

        public Process getCurrentProcess() { return currentProcess; }
        public bool isProcessing() { return gotProcess; }
    }
}
