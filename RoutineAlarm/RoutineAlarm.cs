namespace RoutineAlarm
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;

    public partial class RoutineAlarm : Form
    {

        private AlarmingConfiguration alarmingConfiguration;
        private List<AlarmTask> alarmTasks;
        private Thread myThread;
        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token;
        int currentActiveAlarmTaskIdx = -1;
        private ListViewExtender extender;

        public RoutineAlarm()
        {
            InitializeComponent();

            alarmingConfiguration = new AlarmingConfiguration();
            alarmTasks = alarmingConfiguration.LoadCurrentConfig();



            token = source.Token;

            myThread = new Thread(this.checkAlarmTime);
            extender = new ListViewExtender(listView1);

            linkLabel1.Text = alarmingConfiguration.GetConfigurationPath();

        }


        public void SnoozeAnAlarmTask()
        {
            if (currentActiveAlarmTaskIdx != -1)
            {
                updateAnAlarmTaskTime(currentActiveAlarmTaskIdx);



            }
        }

        public void OKAnAlarmTask()
        {
            if (currentActiveAlarmTaskIdx != -1)
            {
                alarmTasks[currentActiveAlarmTaskIdx].alarmStatus = AlarmStatus.Played;
                listView1.Items[currentActiveAlarmTaskIdx].SubItems[2].Text = alarmTasks[currentActiveAlarmTaskIdx].alarmStatus.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            loadAlarmListView();


            myThread.Start(token);
        }

        private void loadAlarmListView()
        {
            listView1.Items.Clear();
            listView1.Refresh();
            //extender.ListView.Clear();

            listView1.FullRowSelect = true;

            // extend 2nd column
            ListViewButtonColumn lBtnSnooze = new ListViewButtonColumn(3);
            lBtnSnooze.Click += OnListBtnSnoozeClick;
            lBtnSnooze.FixedWidth = true;

            extender.AddColumn(lBtnSnooze);


            foreach (AlarmTask alarmTask in alarmTasks)
            {
                ListViewItem item = listView1.Items.Add(alarmTask.description);
                item.SubItems.Add(alarmTask.GetAlarmTimeStr());
                item.SubItems.Add(alarmTask.alarmStatus.ToString());
                item.SubItems.Add("Snooze for 3h");
            }
        }

        void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void checkAlarmTime(object token)
        {
            DateTime oldDate = DateTime.Now;
            while (!((CancellationToken)token).IsCancellationRequested)
            {
                bool isNewDate = DateTime.Now.DayOfWeek != oldDate.DayOfWeek;


                //set isNewday means 1 mins passed
                //var t = DateTime.Now.Subtract(oldDate).Seconds;
                //isNewDate = DateTime.Now.Subtract(oldDate).TotalSeconds > 60;


                if (isNewDate) // new day
                {
                    Program.globalForm.Invoke((MethodInvoker)delegate ()
                    {

                        foreach (AlarmTask alarmTask in alarmTasks)
                        {
                            if (alarmTask.alarmStatus == AlarmStatus.Played)
                            {
                                alarmTask.updateNewDate();
                            }
                        }

                        loadAlarmListView();
                    });
                }
                Thread.Sleep(5000);

                int i = 0;
                foreach (AlarmTask alarmTask in alarmTasks)
                {

                    if (alarmTask.alarmStatus == AlarmStatus.NotPlayed)
                    {
                        DateTime dt = alarmTask.alarmTime;

                        if (DateTime.Now > dt)
                        {
                            currentActiveAlarmTaskIdx = i;
                            AlarmDetails alarmDetails = new AlarmDetails(Program.globalForm);
                            alarmDetails.Text = alarmTask.description + " - " + alarmTask.GetAlarmTimeStr();
                            Program.globalForm.Invoke((MethodInvoker)delegate ()
                            {
                                //alarmDetails.Show(Program.globalForm);
                                alarmTask.alarmStatus = AlarmStatus.Playing;
                                alarmDetails.ShowDialog();
                            });


                            //reset
                            currentActiveAlarmTaskIdx = -1;
                        }

                    }
                    ++i;
                }

                oldDate = DateTime.Now;

            }
        }

        private void OnListBtnSnoozeClick(object sender, ListViewColumnMouseEventArgs e)
        {
            //MessageBox.Show(this, @"you clicked " + e.Item.Index);

            updateAnAlarmTaskTime(e.Item.Index);


            //loadAlarmListView();
        }


        private void updateAnAlarmTaskTime(int index)
        {
            alarmTasks[index].alarmTime = alarmTasks[index].alarmTime.AddHours(3);
            //if(alarmTasks[index].alarmTime > DateTime.Now)
            {
                alarmTasks[index].alarmStatus = AlarmStatus.NotPlayed;
            }

            //update GUI
            listView1.Items[index].SubItems[1].Text = alarmTasks[index].GetAlarmTimeStr();
            listView1.Items[index].SubItems[2].Text = alarmTasks[index].alarmStatus.ToString();
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            e.Cancel = true;

            this.Hide();

            //// Confirm user wants to close
            //switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            //{
            //    case DialogResult.No:
            //        e.Cancel = true;
            //        break;
            //    default:
            //        break;
            //}
        }

        private void snoozeAllFor3HoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < alarmTasks.Count; i++)
            {
                updateAnAlarmTaskTime(i);
            }
            //MessageBox.Show(this, "All items have been snoozed for 3 hours later");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            source.Cancel();
            this.Dispose();
            ////Application.Exit();
            ///

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnReloadCf_Click(object sender, EventArgs e)
        {
            alarmTasks = alarmingConfiguration.LoadCurrentConfig();

            loadAlarmListView();
        }

        private void btnSaveCf_Click(object sender, EventArgs e)
        {

            alarmingConfiguration.SaveToCurrentConfig(this.alarmTasks);

            MessageBox.Show(this, "Current alarm tasks saved to " + alarmingConfiguration.getPath(), "Save alarm task", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //% SystemRoot %\explorer.exe "folder path"                
            Process.Start("explorer.exe", alarmingConfiguration.GetConfigurationPath());
        }
    }
}
