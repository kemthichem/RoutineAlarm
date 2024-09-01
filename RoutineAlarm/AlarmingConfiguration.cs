using Microsoft.VisualBasic.Logging;

namespace RoutineAlarm
{
    using Serilog; 
    internal class AlarmingConfiguration
    {
        private string path = Application.StartupPath + "..\\..\\..\\..\\config\\alarm_tasks.txt";
        public AlarmingConfiguration() { }

        public List<AlarmTask> LoadCurrentConfig()
        {
            

            List<AlarmTask> alarmTaskList = new List<AlarmTask>();

            List<string> data = File.ReadAllLines(path).ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' });
                //,StringSplitOptions.RemoveEmptyEntries
                if (items.Length >= 3)
                {
                    bool almStatus = items.Length == 3 ? false : bool.Parse(items[3]);
                    var alarmTask = new AlarmTask(items[0], items[1], items[2], almStatus);

                    alarmTaskList.Add(alarmTask);
                }
            }

            //alarmTaskList.Add(new AlarmTask("Drink water", "17:30", false));
            //alarmTaskList.Add(new AlarmTask("Do exercise", "17:32", false));

            Log.Information($"LoadCurrentConfig - Done - size: {alarmTaskList.Count}");
            var index = 0;
            foreach (AlarmTask alarmTask in alarmTaskList)
            {
                Log.Information($"[{index}] {alarmTask.ToString()}");
                index++;
            }


            return alarmTaskList;

        }

        public bool SaveToCurrentConfig(List<AlarmTask> alarmTasks)
        {

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (AlarmTask alarmTask in alarmTasks)
                {
                    bool status = alarmTask.alarmStatus == AlarmStatus.Played;
                    sw.WriteLine("{0}, {1}, {2}, {3}", alarmTask.description, alarmTask.alarmTime.ToString("H:mm"), alarmTask.alarmTime.DayOfWeek.ToString(), status);
                }
            }
                

            return false;
        }

        internal string GetConfigurationPath()
        {
            return Path.GetDirectoryName(Path.GetFullPath(this.path));
        }

        internal string getPath()
        {
            return Path.GetFullPath(this.path);
        }
    }
}