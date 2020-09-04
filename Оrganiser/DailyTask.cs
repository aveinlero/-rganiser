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
        
        public bool status { get; }
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
            this.status = false;
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
            this.status = false;
        }

        public static void SaveTaskList(List<DailyTask> dailyTasks)
        {
            string filename = "tasks.dat";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dailyTasks);
            }
        }

        public static List<DailyTask> LoadTaskList()
        {
            string filename = "tasks.dat";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<DailyTask> dailyTasks = (List<DailyTask>)formatter.Deserialize(fs);
                return dailyTasks;
            }
        }

        public void Dispose()
        {
            //TODO: уничтожение архивной записи из архива задач по достижении лимита архива
            throw new NotImplementedException();
        }

        private void DeleteTask()
        {
            //TODO: По нажатию кнопки V удалить задачу из списка, но сохранить ее в архив задач.
        }

        private void ResetStatus()
        {
            //TODO: По нажатию на X вывести диалоговое окно и обновить время задачи или удалить задачу из списка TaskList.
        }

        public void AddTask(ListView listViewTask)
        {
            ListViewItem item = new ListViewItem();
            if (checkTime)
            {
                item.Text = $"{date.ToString("d")} {hour}:{minute}";
                item.SubItems.Add(name);
                ChangeTaskColor(item);
                
            }
            else
            {
                item.Text = $"{date.ToString("d")}";
                item.SubItems.Add(name);
                ChangeTaskColor(item);
            }
            listViewTask.Items.Add(item);
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

        


    }
}
