using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C501OSlib;
using System.Threading;

namespace DesignTry
{
    public partial class Form1 : Form
    {
        List<Process> procList;
        Queue<Process> queue;
        List<Process> finished;
        Process current;
        int timeUpdate;
        CPUSchedulerSimulator cpuSim = new CPUSchedulerSimulator("sjf", 10);

        public Form1()
        {
            InitializeComponent();
            this.txtArrival.KeyPress += new KeyPressEventHandler(txtArrival_KeyPress);
            this.txtBurst.KeyPress += new KeyPressEventHandler(txtBurst_KeyPress);
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Process.ResetCounter();
            cpuSim.CreateRandomProcess(out procList);
            dataInitial.Rows.Clear();
            for (int i = 0; i < procList.Capacity; i++)
            {
                var p = procList.ElementAt(i);
                string[] fill = { "PID"+i, p.getArrivalTime().ToString(), p.getRemainingBurst().ToString() };
                dataInitial.Rows.Add(fill);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            dataReady.Rows.Clear();
            dataFinished.Rows.Clear();
            cpuSim.simulate(out procList, out queue, out finished, out current, out timeUpdate);
            for (int i = 0; i < queue.Count; i++)
            {
                var ready = queue.ElementAt(i);
                string[] fill = {"PID"+ready.getPID(), ready.getArrivalTime().ToString(), ready.getRemainingBurst().ToString()};
                dataReady.Rows.Add(fill);
            }
            for (int i = 0; i < finished.Count; i++)
            {
                var finish = finished.ElementAt(i);
                string[] fill = { "PID"+finish.getPID(), finish.getFinishedTime().ToString(), finish.getTurnaroundTime().ToString(), finish.getWaitingTime().ToString() };
                dataFinished.Rows.Add(fill);
            }
            lblTime.Text = timeUpdate.ToString();
        }

        private void txtArrival_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtBurst_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void AddProcess_Click(object sender, EventArgs e)
        {
            cpuSim.CreateProcess(int.Parse(txtArrival.Text), int.Parse(txtBurst.Text), out procList);
            txtArrival.Text = "";
            txtBurst.Text = "";
            dataInitial.Rows.Clear();
            for (int i = 0; i < procList.Count; i++)
            {
                var p = procList.ElementAt(i);
                string[] fill = { "PID" + i, p.getArrivalTime().ToString(), p.getRemainingBurst().ToString() };
                dataInitial.Rows.Add(fill);
            }
        }
    }
}
