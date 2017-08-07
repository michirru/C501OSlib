using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    public class Process
    {
        private int PID;
        private static int nextPID = 0;
        private int arrivalTime;
        private int burstTime;
        private int priorityLevel;
        private int currentArrival = 0;
        private int remainingBurst = 0;
        private int startTime = 0;
        private int finishedTime = 0;
        private int waitingTime = 0;
        private int turnaroundTime = 0;
        private bool arrived = false;
        private bool running = false;
        private bool finished = false;


        private static Random random = new Random();
        private static int min = 0;

        public Process()
        {
            PID = nextPID;
            try
            {
                arrivalTime = random.Next(min, min+5) * PID / PID;
                min = arrivalTime + 1;
            }
            catch (DivideByZeroException e)
            {
                arrivalTime = 0;
            }
            currentArrival = arrivalTime;
            burstTime = random.Next(5, 15);
            remainingBurst = burstTime;
            priorityLevel = random.Next(1, 10);
            nextPID++;
        }
        public Process(int at, int bt)
        {
            PID = nextPID;
            arrivalTime = at;
            currentArrival = arrivalTime;
            burstTime = bt;
            remainingBurst = burstTime;
            priorityLevel = random.Next(1, 10);
            nextPID++;
        }
        public Process(int at, int bt, int pl)
        {
            PID = nextPID;
            arrivalTime = at;
            currentArrival = arrivalTime;
            burstTime = bt;
            remainingBurst = burstTime;
            priorityLevel = pl;
            nextPID++;
        }

        public int processing(int time)
        {
            remainingBurst--;
            if (remainingBurst == 0)
            {
                finishedTime = time;
                turnaroundTime = time - arrivalTime;
                finished = true;
            }
            return remainingBurst;
        }
        internal void setStartTime(int time)
        {
            startTime = time;
            waitingTime += startTime - currentArrival;
            running = true;
        }
        internal void stopRunning()
        {
            running = false;
        }
        public int getPID() { return PID; }
        public int getArrivalTime() { return arrivalTime; }
        public int getRemainingBurst() { return remainingBurst; }
        public int getPriorityLevel() { return priorityLevel; }
        public int getStartTime() { return startTime; }
        public int getFinishedTime() { return finishedTime; }
        public int getWaitingTime() { return waitingTime; }
        public int getTurnaroundTime() { return turnaroundTime; }
        public bool isArrived() { return arrived; }
        public bool isRunning() { return running; }
        public bool isFinished() { return finished; }
    }
}
