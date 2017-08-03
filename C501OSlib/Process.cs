using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    class Process
    {
        private int PID;
        private int nextPID = 0;
        private int arrivalTime;
        private int burstTime;
        private int priorityLevel;
        private int currentArrival = 0;
        private int remainingBurst = 0;
        private int waitingTime = 0;
        private int turnaroundTime = 0;
        private bool arrived = false;
        private bool running = false;
        private bool finished = false;


        private static Random random = new Random();

        public Process()
        {
            PID = nextPID;
            arrivalTime = random.Next(1, 5) * PID;
            currentArrival = arrivalTime;
            burstTime = random.Next(5, 50);
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

        public int processing()
        {
            remainingBurst--;
            return remainingBurst;
        }

        public int getArrivalTime() { return arrivalTime; }
        public int getRemainingBurst() { return remainingBurst; }
        public bool isArrived() { return arrived; }
    }
}
