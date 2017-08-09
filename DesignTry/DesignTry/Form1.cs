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
        int speed;
        bool simulate = false;
        CPUSchedulerSimulator cpuSim;

        public Form1()
        {
            InitializeComponent();
            this.txtArrival.KeyPress += new KeyPressEventHandler(txtArrival_KeyPress);
            this.txtBurst.KeyPress += new KeyPressEventHandler(txtBurst_KeyPress);
            //cpuSim = new CPUSchedulerSimulator("sjf", 10);
            AlgorithmBox.DisplayMember = "Text";
            AlgorithmBox.ValueMember = "Value";
            List<ComboItem> items = new List<ComboItem>();
            items.Add(new ComboItem { Text = "First In First Out", Value = "fifo" });
            items.Add(new ComboItem { Text = "Shortest Job First", Value = "sjf" });
            items.Add(new ComboItem { Text = "Highest Priority First", Value = "prio" });
            AlgorithmBox.DataSource = items; 
            AlgorithmBox.SelectedIndex = 1;
            speedBox.SelectedIndex = 0;
            FormTextAnimator.RunWorkerAsync();
        }
        private void autoFillbtn_click(object sender, EventArgs e)
        {
            Process.ResetCounter();
            cpuSim.CreateRandomProcess(out procList);
            dataInitial.Rows.Clear();
            for (int i = 0; i < procList.Capacity; i++)
            {
                var p = procList.ElementAt(i);
                string[] fill = { "PID"+i, p.getArrivalTime().ToString(), p.getRemainingBurst().ToString(), p.getPriorityLevel().ToString() };
                dataInitial.Rows.Add(fill);
            }
        }
        private void btnNext_click(object sender, EventArgs e)
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
                string[] fill = { "PID"+finish.getPID(), finish.getStartTime().ToString(), finish.getFinishedTime().ToString(), finish.getTurnaroundTime().ToString(), finish.getWaitingTime().ToString() };
                dataFinished.Rows.Add(fill);
            }
            updateLableText();
        }
        private void updateLableText()
        {
            float awt = 0;
            float att = 0;
            for (int i = 0; i < finished.Count; i++)
            {
                awt += finished.ElementAt(i).getArrivalTime();
                att += finished.ElementAt(i).getTurnaroundTime();
            }
            awt = awt / finished.Count;
            att = att / finished.Count;

            lblTime.Text = timeUpdate.ToString();
            if (current != null)
            {
                currentLbl.Text = "PID" + current.getPID();
                remTimeCounterLbl.Text = current.getRemainingBurst().ToString();
            }
            else
            {
                currentLbl.Text = "--";
                remTimeCounterLbl.Text = "0";
            }
            wtaveLbl.Text = awt.ToString("00.000");
            ttaLbl.Text = att.ToString("00.000");
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
            if (txtArrival.Text != string.Empty && txtBurst.Text != string.Empty)
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
            else
            {
                MessageBox.Show("No input detected in Arrival Time or Burst Time");
            }
            txtArrival.Focus();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void simulateBtn_Click(object sender, EventArgs e)
        {
            if (SimulateBtn.Text == "Stop")
            {
                simulate = false;
                SimulateBtn.Text = "Auto Simulate";
            }
            else
            {
                simulate = true;
                SimulateBtn.Text = "Stop";
            }
            AutoSimulateTimer_Tick(sender, e);
        }

        private void AlgorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            cpuSim = new CPUSchedulerSimulator(AlgorithmBox.SelectedValue.ToString(), 10);
            Process.ResetCounter();
            dataInitial.Rows.Clear();
            dataReady.Rows.Clear();
            dataFinished.Rows.Clear();
            procList = null;
            queue = null;
            finished = null;
            current = null;
            timeUpdate = 0;
            lblTime.Text = "0";
            currentLbl.Text = "--";
            remTimeCounterLbl.Text = "0";
            wtaveLbl.Text = "0";
            ttaLbl.Text = "0";
        }
        private void AutoSimulateTimer_Tick(object sender, EventArgs e)
        {
            if (simulate)
            {
                if (!AutoSimulateWorker.IsBusy)
                    AutoSimulateWorker.RunWorkerAsync();
            }
        }

        private void AutoSimulateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (simulate)
            {
                this.Invoke((MethodInvoker)delegate {
                    speed = int.Parse(speedBox.SelectedItem.ToString());
                    btnNext_click(sender, e);
                    bool allfinished = true;
                    foreach (Process p in procList)
                    {
                        if (!p.isFinished())
                            allfinished = false;
                    }
                    if (allfinished)
                    {
                        simulateBtn_Click(sender, e);
                        btnNext_click(sender, e);
                    }
                });
                Thread.Sleep(speed);
            }
        }
        //Just for fun
        private void FormTextAnimator_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand = new Random();
            string[] kamo0 = { "=͟͟͞͞( •̀д•́)))", "凸(｀0´)凸", "༼ つ ͠° ͟ ͟ʖ ͡° ༽つ", "(╬⓪益⓪)", "凸ಠ益ಠ)凸" };
            string[] kamo1 = { "(ʘ言ʘ╬)", "(Ò 皿 Ó ╬)", "(@益@ .:;)", "(´･益･｀*)", "٩(ʘ益ʘ╬)۶", "Щ(ಠ益ಠЩ)" };
            while (true)
            {
                this.Invoke((MethodInvoker)delegate { this.Text = "C501 - JAPANESE CORN " + kamo0[rand.Next(kamo0.Length)] + "     " + kamo1[rand.Next(kamo1.Length)]; });
                Thread.Sleep(rand.Next(125, 500));
            }
        }
    }
}
