using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;

namespace Оrganiser
{
    [Serializable]
    public class DailyTask
    {
        public bool NewTask { get; set; } = false;
        public string name { get; set; } = "";
        public string hour { get; set; } = "00";
        public string minute { get; set; } = "00";
        public int intHour { get; set; } = 0;
        public int intMinute { get; set; } = 0;
        public DateTime date { get; set; } = DateTime.Today;
        public bool checkTime { get; set; } = false;
        public string description { get; set; } = "";

        public DailyTask()
        {

        }

        public DailyTask(DateTime date, string name)
        {
            this.date = date;
            this.name = name;

        }
        
        public DailyTask(DateTime date, string hour, string minute, string name)
        {
            this.date = date;
            this.name = name;
            this.hour = hour;
            this.intHour = Int32.Parse(hour);
            this.minute = minute;
            this.intMinute = Int32.Parse(minute);
            this.checkTime = true;
        }

        public static void SaveTaskList(List<DailyTask> dailyTasks, string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dailyTasks);
            }
        }

        public static List<DailyTask> LoadTaskList(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<DailyTask> dailyTasks = (List<DailyTask>)formatter.Deserialize(fs);
                return dailyTasks;
            }
        }

        public static void TransferTask(List<DailyTask> incoming, List<DailyTask> outgoing, int outIndex )
        {
            incoming.Add(outgoing[outIndex]);
            outgoing.RemoveAt(outIndex);
        }

        public void AddTask(ListView list)
        {
            ListViewItem item = new ListViewItem();
            if (checkTime)
            {
                item.Text = $"{date:d} {hour}:{minute}";
                item.SubItems.Add(name);
                ChangeTaskColor(item);
                
            }
            else
            {
                item.Text = $"{date:d}";
                item.SubItems.Add(name);
                ChangeTaskColor(item);
            }
            list.Items.Add(item);
        }

        private void ChangeTaskColor(ListViewItem item)
        {
            if (this.date < DateTime.Now.Date)
            {
                item.ForeColor = Color.Red;
            }
            else
            {
                if (this.date > DateTime.Now.Date)
                {
                    item.ForeColor = Color.Green;
                }
            }
        }

        public static int SortDailyTask(object x, object y)
        {
            DailyTask task1 = (DailyTask)x;
            DailyTask task2 = (DailyTask)y;
            if (task1.date == null) 
            { 
                if (task2.date == null) { return 0; }
                else { return -1; }
            }
            else
            {
                if(task2.date == null)
                {
                    return 1;
                }
                else
                {
                    if (task1.date == task2.date)
                    {
                        if (task1.intHour == task2.intHour)
                        {
                            if (task1.intMinute == task2.intMinute)
                            {
                                return 0;
                            }
                            else
                            {
                                if (task1.intMinute > task2.intMinute) { return 1; }
                                else { return -1; }
                            }
                        }
                        else
                        {
                            if (task1.intHour > task2.intHour) { return 1; }
                            else { return -1; }
                        }
                    }
                    else
                    {
                        if (task1.date > task2.date) { return 1; }
                        else { return -1; }
                    }
                }
            }
        }

        public static void UpdateList(List<DailyTask> tasks, ListView listView, bool sort)
        {
            listView.Items.Clear();
            if (sort) { tasks.Sort(DailyTask.SortDailyTask); }
            foreach (DailyTask task in tasks)
            {
                task.AddTask(listView);
            }
        }

        public static void LimitList(List<DailyTask> list, int limit)
        {
            if (list.Count > limit)
            {
                list.RemoveAt(0);
                LimitList(list, limit);
            }
        }

        public static int FindNew(List<DailyTask> tasks)
        {
            for (int i = 0; i <tasks.Count; i++ )
            {
                if (tasks[i].NewTask) 
                {
                    tasks[i].NewTask = false;
                    return i; 
                }
            }
            return 0;
        }

        public static DailyTask Clone(DailyTask task)
        {
            DailyTask clone = new DailyTask();
            clone.NewTask = task.NewTask;
            clone.name = task.name;
            clone.hour = task.hour;
            clone.minute = task.minute;
            clone.intHour = task.intHour;
            clone.intMinute = task.intMinute;
            clone.date = task.date;
            clone.checkTime = task.checkTime;
            clone.description = task.description;
            return clone;
        }
    }
}
