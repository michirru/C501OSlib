namespace DesignTry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.AddProcess = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtBurst = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataInitial = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFinished = new System.Windows.Forms.GroupBox();
            this.dataFinished = new System.Windows.Forms.DataGridView();
            this.FinishedPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataReady = new System.Windows.Forms.DataGridView();
            this.ReadyPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingBurst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttaLbl = new System.Windows.Forms.Label();
            this.wtaveLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.currentLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.remTimeCounterLbl = new System.Windows.Forms.Label();
            this.remLbl = new System.Windows.Forms.Label();
            this.FormTextAnimator = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInitial)).BeginInit();
            this.lblFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinished)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReady)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.AddProcess);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.txtBurst);
            this.groupBox1.Controls.Add(this.txtArrival);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter a process: (Max = 10)";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(6, 103);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(62, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AddProcess
            // 
            this.AddProcess.Location = new System.Drawing.Point(153, 103);
            this.AddProcess.Name = "AddProcess";
            this.AddProcess.Size = new System.Drawing.Size(60, 23);
            this.AddProcess.TabIndex = 2;
            this.AddProcess.Text = "Insert";
            this.AddProcess.UseVisualStyleBackColor = true;
            this.AddProcess.Click += new System.EventHandler(this.AddProcess_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(79, 103);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(62, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Auto Fill";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.autoFillbtn_click);
            // 
            // txtBurst
            // 
            this.txtBurst.Location = new System.Drawing.Point(114, 68);
            this.txtBurst.Name = "txtBurst";
            this.txtBurst.Size = new System.Drawing.Size(69, 20);
            this.txtBurst.TabIndex = 1;
            this.txtBurst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBurst_KeyPress);
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(114, 28);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(69, 20);
            this.txtArrival.TabIndex = 0;
            this.txtArrival.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArrival_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burst Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrival Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataInitial);
            this.groupBox2.Location = new System.Drawing.Point(267, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initial Queue";
            // 
            // dataInitial
            // 
            this.dataInitial.AllowUserToAddRows = false;
            this.dataInitial.AllowUserToDeleteRows = false;
            this.dataInitial.AllowUserToResizeColumns = false;
            this.dataInitial.AllowUserToResizeRows = false;
            this.dataInitial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInitial.ColumnHeadersHeight = 34;
            this.dataInitial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataInitial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.ArriveTime,
            this.BurstTime});
            this.dataInitial.Enabled = false;
            this.dataInitial.Location = new System.Drawing.Point(6, 19);
            this.dataInitial.MultiSelect = false;
            this.dataInitial.Name = "dataInitial";
            this.dataInitial.RowHeadersVisible = false;
            this.dataInitial.Size = new System.Drawing.Size(192, 286);
            this.dataInitial.TabIndex = 0;
            this.dataInitial.TabStop = false;
            // 
            // PId
            // 
            this.PId.HeaderText = "Process ID";
            this.PId.Name = "PId";
            // 
            // ArriveTime
            // 
            this.ArriveTime.HeaderText = "Arrival Time";
            this.ArriveTime.Name = "ArriveTime";
            // 
            // BurstTime
            // 
            this.BurstTime.HeaderText = "Burst Time";
            this.BurstTime.Name = "BurstTime";
            // 
            // lblFinished
            // 
            this.lblFinished.Controls.Add(this.dataFinished);
            this.lblFinished.Location = new System.Drawing.Point(753, 147);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(410, 311);
            this.lblFinished.TabIndex = 2;
            this.lblFinished.TabStop = false;
            this.lblFinished.Text = "Finished Processes";
            // 
            // dataFinished
            // 
            this.dataFinished.AllowUserToAddRows = false;
            this.dataFinished.AllowUserToDeleteRows = false;
            this.dataFinished.AllowUserToResizeColumns = false;
            this.dataFinished.AllowUserToResizeRows = false;
            this.dataFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFinished.ColumnHeadersHeight = 34;
            this.dataFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinishedPId,
            this.TimeFin,
            this.TurnaroundTime,
            this.WaitingTime});
            this.dataFinished.Enabled = false;
            this.dataFinished.Location = new System.Drawing.Point(6, 19);
            this.dataFinished.MultiSelect = false;
            this.dataFinished.Name = "dataFinished";
            this.dataFinished.RowHeadersVisible = false;
            this.dataFinished.Size = new System.Drawing.Size(398, 283);
            this.dataFinished.TabIndex = 1;
            this.dataFinished.TabStop = false;
            // 
            // FinishedPId
            // 
            this.FinishedPId.HeaderText = "Process ID";
            this.FinishedPId.Name = "FinishedPId";
            // 
            // TimeFin
            // 
            this.TimeFin.HeaderText = "Time Finished";
            this.TimeFin.Name = "TimeFin";
            // 
            // TurnaroundTime
            // 
            this.TurnaroundTime.HeaderText = "Turnaround Time";
            this.TurnaroundTime.Name = "TurnaroundTime";
            // 
            // WaitingTime
            // 
            this.WaitingTime.HeaderText = "Waiting Time";
            this.WaitingTime.Name = "WaitingTime";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataReady);
            this.groupBox4.Location = new System.Drawing.Point(477, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 311);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ready Queue";
            // 
            // dataReady
            // 
            this.dataReady.AllowUserToAddRows = false;
            this.dataReady.AllowUserToDeleteRows = false;
            this.dataReady.AllowUserToResizeColumns = false;
            this.dataReady.AllowUserToResizeRows = false;
            this.dataReady.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataReady.ColumnHeadersHeight = 34;
            this.dataReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataReady.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReadyPId,
            this.ArrivalTime,
            this.RemainingBurst});
            this.dataReady.Enabled = false;
            this.dataReady.Location = new System.Drawing.Point(6, 19);
            this.dataReady.MultiSelect = false;
            this.dataReady.Name = "dataReady";
            this.dataReady.RowHeadersVisible = false;
            this.dataReady.Size = new System.Drawing.Size(258, 286);
            this.dataReady.TabIndex = 0;
            this.dataReady.TabStop = false;
            // 
            // ReadyPId
            // 
            this.ReadyPId.HeaderText = "Process ID";
            this.ReadyPId.Name = "ReadyPId";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // RemainingBurst
            // 
            this.RemainingBurst.HeaderText = "Remaining Burst";
            this.RemainingBurst.Name = "RemainingBurst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shortest Job First";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(92, 207);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 31);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Turnaround Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Average Waiting Time:";
            // 
            // ttaLbl
            // 
            this.ttaLbl.AutoSize = true;
            this.ttaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttaLbl.Location = new System.Drawing.Point(182, 340);
            this.ttaLbl.Name = "ttaLbl";
            this.ttaLbl.Size = new System.Drawing.Size(15, 16);
            this.ttaLbl.TabIndex = 8;
            this.ttaLbl.Text = "0";
            // 
            // wtaveLbl
            // 
            this.wtaveLbl.AutoSize = true;
            this.wtaveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtaveLbl.Location = new System.Drawing.Point(158, 311);
            this.wtaveLbl.Name = "wtaveLbl";
            this.wtaveLbl.Size = new System.Drawing.Size(15, 16);
            this.wtaveLbl.TabIndex = 9;
            this.wtaveLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gantt Chart";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(255, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(918, 29);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(71, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 14;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(139, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 23);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(208, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 12;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(273, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 12;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(343, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 23);
            this.button6.TabIndex = 15;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(406, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 23);
            this.button7.TabIndex = 16;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(467, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 23);
            this.button8.TabIndex = 17;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(529, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 23);
            this.button9.TabIndex = 18;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(590, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 23);
            this.button10.TabIndex = 19;
            this.button10.TabStop = false;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.Location = new System.Drawing.Point(125, 253);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(16, 16);
            this.currentLbl.TabIndex = 13;
            this.currentLbl.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Current Process:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(20, 412);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(109, 412);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 6;
            this.btnFinished.Text = "Finish";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // remTimeCounterLbl
            // 
            this.remTimeCounterLbl.AutoSize = true;
            this.remTimeCounterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remTimeCounterLbl.Location = new System.Drawing.Point(125, 282);
            this.remTimeCounterLbl.Name = "remTimeCounterLbl";
            this.remTimeCounterLbl.Size = new System.Drawing.Size(15, 16);
            this.remTimeCounterLbl.TabIndex = 17;
            this.remTimeCounterLbl.Text = "0";
            // 
            // remLbl
            // 
            this.remLbl.AutoSize = true;
            this.remLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remLbl.Location = new System.Drawing.Point(17, 282);
            this.remLbl.Name = "remLbl";
            this.remLbl.Size = new System.Drawing.Size(109, 16);
            this.remLbl.TabIndex = 16;
            this.remLbl.Text = "Remaining Burst:";
            // 
            // FormTextAnimator
            // 
            this.FormTextAnimator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FormTextAnimator_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 468);
            this.Controls.Add(this.remTimeCounterLbl);
            this.Controls.Add(this.remLbl);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wtaveLbl);
            this.Controls.Add(this.ttaLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C501 - JAPANESE CORN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInitial)).EndInit();
            this.lblFinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFinished)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReady)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtBurst;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox lblFinished;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ttaLbl;
        private System.Windows.Forms.Label wtaveLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.DataGridView dataInitial;
        private System.Windows.Forms.DataGridView dataReady;
        private System.Windows.Forms.DataGridView dataFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
        private System.Windows.Forms.Button AddProcess;
        private System.Windows.Forms.Label remTimeCounterLbl;
        private System.Windows.Forms.Label remLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadyPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingBurst;
        private System.ComponentModel.BackgroundWorker FormTextAnimator;
    }
}

