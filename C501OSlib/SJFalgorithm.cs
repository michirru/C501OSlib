using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C501OSlib
{
    public class SJFalgorithm : Algorithm
    {
        public override Queue<Process> sort(Queue<Process> q)
        {
            sorted = new Queue<Process>(q.OrderBy(Process => Process.getRemainingBurst()).ThenBy(Process => Process.getArrivalTime()));
            return sorted;
        }
        public override string getName()
        {
            return "Shortest Job First Algorithm";
        }
    }
}
