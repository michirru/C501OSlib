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
        List<Button> buttons;
        Button ganttButtons;
        ToolTip tip;
        private static int loc = 0;
        private static int size = 5;
        private static int btnIndex = 0;
        private Process _current;
        Process current;
        int timeUpdate;
        int speed;
        bool simulate = false;
        bool loop = true;
        CPUSchedulerSimulator cpuSim;

        Process currentIn
        {
            get
            {
                return _current;
            }
            set
            {
                if (_current == null || value == null || _current.getPID() != value.getPID())
                {
                    if (value == null)
                    {
                        _current = value;
                        foreach (DataGridViewRow data in dataInitial.Rows)
                        {
                            if (data.DefaultCellStyle.BackColor != SystemColors.Control)
                            {
                                data.DefaultCellStyle.BackColor = SystemColors.Control;
                            }
                        }
                    }
                    else
                    {
                        _current = value;
                        onCurrentChanged();
                        foreach (DataGridViewRow data in dataInitial.Rows)
                        {
                            if ("P" + current.getPID() == data.Cells[0].Value.ToString())
                            {
                                data.DefaultCellStyle.BackColor = Color.Coral;
                            }
                            if ("P" + current.getPID() != data.Cells[0].Value.ToString() && data.DefaultCellStyle.BackColor != SystemColors.Control)
                            {
                                data.DefaultCellStyle.BackColor = SystemColors.Control;
                            }
                        }
                    }
                }
                else
                {
                    _current = value;
                }
            }
        }
        private void onCurrentChanged()
        {
            loc += size;
            size = 20;
            ganttButtons = new Button();
            ganttButtons.Enabled = true;
            ganttButtons.Location = new System.Drawing.Point(loc, 0);
            ganttButtons.Name = "P" + (buttons.Count + 1).ToString();
            ganttButtons.Text = "P" + currentIn.getPID();
            ganttButtons.Size = new System.Drawing.Size(size, 50);
            ganttButtons.Tag = currentIn;
            ganttButtons.FlatStyle = FlatStyle.Flat;
            ganttButtons.TabIndex = 0;
            ganttButtons.TabStop = false;
            ganttButtons.ForeColor = Color.White;
            ganttButtons.Font = new Font("Tahoma", 10, FontStyle.Bold);
            ganttButtons.BackColor = SystemColors.HotTrack;
            ganttButtons.UseVisualStyleBackColor = true;
            ganttButtons.MouseHover += new System.EventHandler(this.ganttButtons_MouseHover);
            buttons.Add(ganttButtons);
            ganttChartPanel.Controls.Add(buttons.ElementAt(btnIndex));
            btnIndex += 1;
        }

        private void ganttButtons_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int visibleTime = 5000;
            var tag = btn.Tag as Process;
            tip.Show("P" + tag.getPID() +
                "\n Start time: " + tag.getStartTime() +
                "\n Finish time: " + tag.getFinishedTime(), btn, visibleTime);
        }
        //-----
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            tip = new ToolTip();
            this.txtArrival.KeyPress += new KeyPressEventHandler(numOnly_KeyPress);
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
                string[] fill = { "P" + i, p.getArrivalTime().ToString(), p.getRemainingBurst().ToString(), p.getPriorityLevel().ToString() };
                dataInitial.Rows.Add(fill);
            }
        }
        private void btnNext_click(object sender, EventArgs e)
        {
            dataReady.Rows.Clear();
            dataFinished.Rows.Clear();
            cpuSim.simulate(out procList, out queue, out finished, out current, out timeUpdate);
            currentIn = current;
            for (int i = 0; i < queue.Count; i++)
            {
                var ready = queue.ElementAt(i);
                string[] fill = { "P" + ready.getPID(), ready.getArrivalTime().ToString(), ready.getRemainingBurst().ToString() };
                dataReady.Rows.Add(fill);
            }
            for (int i = 0; i < finished.Count; i++)
            {
                var finish = finished.ElementAt(i);
                string[] fill = { "P" + finish.getPID(), finish.getStartTime().ToString(), finish.getFinishedTime().ToString(), finish.getTurnaroundTime().ToString(), finish.getWaitingTime().ToString() };
                dataFinished.Rows.Add(fill);
            }
            updateLableText();
            size += 5;
            if (currentIn != null)
                buttons.ElementAt(btnIndex - 1).Size = new Size(size, 50);
        }
        private void updateLableText()
        {
            float awt = 0;
            float att = 0;
            for (int i = 0; i < finished.Count; i++)
            {
                awt += finished.ElementAt(i).getWaitingTime();
                att += finished.ElementAt(i).getTurnaroundTime();
            }
            awt = awt / finished.Count;
            att = att / finished.Count;

            lblTime.Text = timeUpdate.ToString();
            if (currentIn != null)
            {
                currentLbl.Text = "P" + currentIn.getPID();
                remTimeCounterLbl.Text = currentIn.getRemainingBurst().ToString();
            }
            else
            {
                currentLbl.Text = "--";
                remTimeCounterLbl.Text = "0";
            }
            wtaveLbl.Text = awt.ToString("00.000");
            ttaLbl.Text = att.ToString("00.000");
        }
        private void numOnly_KeyPress(object sender, KeyPressEventArgs e)
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
                    string[] fill = { "P" + i, p.getArrivalTime().ToString(), p.getRemainingBurst().ToString(), p.getPriorityLevel().ToString() };
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
                AutoSimulateWorker.CancelAsync();
            }
            else
            {
                simulate = true;
                SimulateBtn.Text = "Stop";
                AutoSimulateWorker.RunWorkerAsync();
            }
        }

        private void AlgorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int limit;
            bool num = int.TryParse(tbProcLimit.Text, out limit);
            if (num && limit > 0)
            {
                reset();
            }
            else
            {
                tbProcLimit.Text = "10";
                reset();
            }
        }
        private void reset()
        {
            buttons = new List<Button>();
            Process.ResetCounter();
            dataInitial.Rows.Clear();
            dataReady.Rows.Clear();
            dataFinished.Rows.Clear();
            procList = null;
            queue = null;
            finished = null;
            currentIn = null;
            timeUpdate = 0;
            lblTime.Text = "0";
            currentLbl.Text = "--";
            remTimeCounterLbl.Text = "0";
            wtaveLbl.Text = "0";
            ttaLbl.Text = "0";
            loc = 0;
            size = 5;
            btnIndex = 0;
            ganttChartPanel.Controls.Clear();
            cpuSim = new CPUSchedulerSimulator(AlgorithmBox.SelectedValue.ToString(), int.Parse(tbProcLimit.Text));
            groupBox1.Text = "Enter a process: (Max = " + tbProcLimit.Text + ")";
        }
        private void AutoSimulateTimer_Tick(object sender, EventArgs e)
        {
        }

        private void AutoSimulateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (simulate)
            {
                try
                {
                    if (AutoSimulateWorker.CancellationPending)
                        e.Cancel = true;
                    this.Invoke((MethodInvoker)delegate
                    {
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
                catch (ObjectDisposedException)
                {
                }
            }
        }
        //Just for fun
        private void FormTextAnimator_DoWork(object sender, DoWorkEventArgs e)
        {
            while (loop)
            {
                try
                {
                    Random rand = new Random();
                    string[] kamo0 = { "Ogawa, Kevin L.", "Potente, Loue A.", "Redor, Michael I.", "Sy, Mabeeson V." };
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Text = "C501 - JAPANESE CORN  " + kamo0[rand.Next(kamo0.Length)];
                    });
                    Thread.Sleep(rand.Next(125, 500));
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }
    }
}
