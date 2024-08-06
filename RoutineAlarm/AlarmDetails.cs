using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutineAlarm
{
    public partial class AlarmDetails : Form
    {

        SoundPlayer simpleSound;
        RoutineAlarm routineAlarmFrm;

        public AlarmDetails(Form mainForm)
        {
            InitializeComponent();
            simpleSound = new SoundPlayer(Application.StartupPath + "sound_file\\mixkit-interface-hint-notification-911.wav");

            routineAlarmFrm = mainForm as RoutineAlarm;
        }

        


        private void playSimpleSound()
        {
            simpleSound.PlayLooping();
        }

        private void AlarmDetails_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            routineAlarmFrm.OKAnAlarmTask();
            this.Close();
        }

        private void btnSnooze_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            routineAlarmFrm.SnoozeAnAlarmTask();
            this.Close();
        }
    }
}
