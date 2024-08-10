using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutineAlarm
{
    class AlarmTask
    {
        public AlarmTask(string des, string alarmTimeStr, string alarmDate, bool isPlayed) {
            this.description = des;
            this.alarmStatus = isPlayed ? AlarmStatus.Played : AlarmStatus.NotPlayed;
            DayOfWeek alarmDow = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), alarmDate);

            int hour = int.Parse(alarmTimeStr.Split(':')[0]);
            int min = int.Parse(alarmTimeStr.Split(':')[1]);


            DateTime now = DateTime.Now.Date;
            DateTime nextDate = now;
            if (alarmDow != now.DayOfWeek)
            { 
                int offset = CalculateOffset(now.DayOfWeek, alarmDow);
                nextDate = now.AddDays(offset);
                this.alarmStatus = AlarmStatus.NotPlayed;
            }

            this.alarmTime = new DateTime(nextDate.Year, nextDate.Month, nextDate.Day, hour, min, 0);

        }
        public string description;

        public DateTime alarmTime;

        public AlarmStatus alarmStatus;

        public string GetAlarmTimeStr()
        {
            return this.alarmTime.ToString("ddd, MMM d yyyy H:mm");
        }

        public int CalculateOffset(DayOfWeek current, DayOfWeek desired)
        {
            // f( c, d ) = [7 - (c - d)] mod 7
            // f( c, d ) = [7 - c + d] mod 7
            // c is current day of week and 0 <= c < 7
            // d is desired day of the week and 0 <= d < 7
            int c = (int)current;
            int d = (int)desired;
            int offset = (7 - c + d) % 7;
            return offset == 0 ? 7 : offset;
        }

        internal void updateNewDate()
        {
            int offset = CalculateOffset(this.alarmTime.DayOfWeek, this.alarmTime.DayOfWeek);
            this.alarmTime = this.alarmTime.AddDays(offset);

            this.alarmStatus = AlarmStatus.NotPlayed;
        }
    }


    enum AlarmStatus
    { 
        NotPlayed,
        Playing,
        Played
    }
}
