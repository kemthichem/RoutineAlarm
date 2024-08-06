namespace RoutineAlarm
{
    using System;
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;
    public partial class RoutineAlarm : Form
    {



        public RoutineAlarm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(Icon))
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
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
            MessageBox.Show(this, "All items have been snoozed for 3 hours later");
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
    }
}
