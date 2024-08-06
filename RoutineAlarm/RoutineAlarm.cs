namespace RoutineAlarm
{
    using System;
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;

    public partial class RoutineAlarm : Form
    {

        private AlarmingConfiguration alarmingConfiguration;
        private List<AlarmTask> alarmTasks;

        public RoutineAlarm()
        {
            InitializeComponent();

            alarmingConfiguration = new AlarmingConfiguration(Application.StartupPath + "\\alarm_tasks.txt");
            alarmTasks = alarmingConfiguration.LoadCurrentConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            loadAlarmListView();

            Thread myThread = new Thread(new ThreadStart(checkAlarmTime));
            myThread.Start();
        }

        private void loadAlarmListView()
        {
            listView1.Items.Clear();

            listView1.FullRowSelect = true;
            ListViewExtender extender = new ListViewExtender(listView1);
            // extend 2nd column
            ListViewButtonColumn lBtnSnooze = new ListViewButtonColumn(2);
            lBtnSnooze.Click += OnListBtnSnoozeClick;
            lBtnSnooze.FixedWidth = true;

            extender.AddColumn(lBtnSnooze);


            foreach (AlarmTask alarmTask in alarmTasks)
            {
                ListViewItem item = listView1.Items.Add(alarmTask.description);
                item.SubItems.Add(alarmTask.alarmTime.ToShortTimeString());
                item.SubItems.Add("Snooze for 3h");
            }
        }

        private void checkAlarmTime()
        {
            while (true)
            {
                Thread.Sleep(5000);



                DateTime dt = alarmTasks[0].alarmTime;

                if (DateTime.Now.TimeOfDay > dt.TimeOfDay)
                {

                    AlarmDetails alarmDetails = new AlarmDetails();
                    Program.globalForm.Invoke((MethodInvoker)delegate ()
                    {
                        alarmDetails.Show();
                    });

                }
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
            listView1.Items[index].SubItems[1].Text = alarmTasks[index].alarmTime.ToShortTimeString();
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
            this.Dispose();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnSnoozeDW_Click(object sender, EventArgs e)
        {
            AlarmDetails alarmDetails = new AlarmDetails();
            alarmDetails.Show();
        }

        private void btnSnoozeDE_Click(object sender, EventArgs e)
        {
            playSimpleSound();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "sound_file\\mixkit-interface-hint-notification-911.wav");
            simpleSound.Play();
        }

        private void btnReloadCf_Click(object sender, EventArgs e)
        {
            loadAlarmListView();
        }

        private void btnSaveCf_Click(object sender, EventArgs e)
        {

            //alarmingConfiguration.SaveToCurrentConfig();
        }

        private void notifyIcon1_MouseClick(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(Icon))
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }

        }
    }
}
