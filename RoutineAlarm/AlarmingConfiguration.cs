using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutineAlarm
{
    internal class AlarmingConfiguration
    {
        public AlarmingConfiguration(string path) { }

        private string _path;
        public string Path { get; set; }


        public List<AlarmTask> LoadCurrentConfig()
        {
            List<AlarmTask> alarmTaskList = new List<AlarmTask>();

            //List<string> data = File.ReadAllLines("TestCSV.txt").ToList();
            //foreach (string d in data)
            //{
            //    string[] items = d.Split(new char[] { ',' },
            //           StringSplitOptions.RemoveEmptyEntries);
            //    listView.Items.Add(new ListViewItem(items));
            //}






            alarmTaskList.Add(new AlarmTask("Drink water", "17:30", false));
            alarmTaskList.Add(new AlarmTask("Do exercise", "17:32", false));

            return alarmTaskList;

        }

        public bool SaveToCurrentConfig(List<AlarmTask> alarmTasks)
        {
            //private void export2File(ListView lv, string splitter)
            //{
            //    string filename = "";
            //    SaveFileDialog sfd = new SaveFileDialog();

            //    sfd.Title = "SaveFileDialog Export2File";
            //    sfd.Filter = "Text File (.txt) | *.txt";

            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        filename = sfd.FileName.ToString();
            //        if (filename != "")
            //        {
            //            using (StreamWriter sw = new StreamWriter(filename))
            //            {
            //                foreach (ListViewItem item in lv.Items)
            //                {
            //                    sw.WriteLine("{0}{1}{2}", item.SubItems[0].Text, splitter, item.SubItems[1].Text);
            //                }
            //            }
            //        }
            //    }
            //}

            return false;
        }
    }
}