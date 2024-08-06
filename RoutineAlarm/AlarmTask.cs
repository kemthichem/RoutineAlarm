using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutineAlarm
{
    internal class AlarmTask
    {
        public AlarmTask(string des, string alarmTimStr, bool isPlayed) {
            this.description = des;
            this.alarmStatus = isPlayed ? AlarmStatus.Played : AlarmStatus.NotPlayed;
            int hour = int.Parse(alarmTimStr.Split(':')[0]);
            int min = int.Parse(alarmTimStr.Split(':')[1]);

            this.alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, 0);

        }
        public string description;

        public DateTime alarmTime;
 
        public AlarmStatus alarmStatus;     

    }

    internal enum AlarmStatus
    { 
        NotPlayed,
        Playing,
        Played
    }
}
