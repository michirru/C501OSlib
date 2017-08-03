using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    class SJFalgorithm : Algorithm
    {
        public Queue<Process> sort(Queue<Process> q)
        {
            sorted = new Queue<Process>(q.OrderBy(Process => Process.getRemainingBurst()).ThenBy(Process => Process.getArrivalTime()));
            return sorted;
        }
        public string getName()
        {
            return "Shortest Job First Algorithm";
        }
    }
}
