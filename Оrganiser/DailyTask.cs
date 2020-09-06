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

namespace Оrganiser
{
    [Serializable]
    public class DailyTask : IDisposable
    {
        private int intHour;
        private int intMinute;

        public bool NewTask { get; set; } = true;
        public string name { get; }
        public string hour { get; }
        public string minute { get; }
        public DateTime date { get; }
        public bool checkTime { get; }
        public string description { get; set; }


        public DailyTask(DateTime date, string name)
        {
            this.date = date;
            this.name = name;
            this.hour = "";
            this.intHour = 0;
            this.minute = "";
            this.intMinute = 0;
            this.description = "";
            this.checkTime = false;
        }
        
        public DailyTask(DateTime date, string hour, string minute, string name)
        {
            this.date = date;
            this.name = name;
            this.hour = hour;
            this.intHour = Int32.Parse(hour);
            this.minute = minute;
            this.intMinute = Int32.Parse(hour);
            this.description = "";
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

        private void ResetStatus()
        {
            //TODO: По нажатию на X вывести диалоговое окно и обновить время задачи или удалить задачу из списка TaskList.
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

    }
}
