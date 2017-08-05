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
            queueToArray = q.ToArray();
            l1Sort(queueToArray);
            return sorted;
        }
        public void l1Sort(Process[] p)
        {

        }
    }
}
