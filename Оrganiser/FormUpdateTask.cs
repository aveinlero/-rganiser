using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Оrganiser
{
    public partial class FormUpdateTask : DateRequestForm
    {
        private DailyTask task;

        public FormUpdateTask() : base()
        {
            InitializeComponent();
        }

        public FormUpdateTask(StartForm startForm) : base(startForm)
        {
            InitializeComponent();
            //this.dailyTask = startForm.dailyTasks[startForm.index];
        }

        public void FormUpdateCancelTaskButton_Click(object sender, EventArgs e)
        {
            startForm.dailyTasks[startForm.index].status = false;
            DailyTask.TransferTask(startForm.archiveTasks, startForm.dailyTasks, startForm.index);
            startForm.UpdateStartForm();
            ShowStartForm();
        }

        public override void AddTaskButton_Click(object sender, EventArgs e)
        {
            UpdateTask(startForm.dailyTasks[startForm.index]);
            startForm.UpdateStartForm();
            ShowStartForm();
        }

        private new void DateRequestForm_Load(object sender, EventArgs e)
        {
            task = startForm.dailyTasks[startForm.index];
            LoadTask(task);
        }

        private void LoadTask(DailyTask task)
        {
            TaskCalendar.SetDate(task.date);
            NameTaskTextBox.Text = task.name;
            NameTaskTextBox.SelectAll();
            AddTimeCheckBox.Checked = task.checkTime;
            comboBoxTaskHour.Text = task.hour;
            comboBoxTaskMinute.Text = task.minute;
        }

        private void UpdateTask(DailyTask dailyTask)
        {
            dailyTask.date = TaskCalendar.SelectionStart;
            dailyTask.checkTime = AddTimeCheckBox.Checked;
            dailyTask.hour = (string)comboBoxTaskHour.SelectedItem;
            dailyTask.intHour = Int32.Parse(dailyTask.hour);
            dailyTask.minute = (string)comboBoxTaskMinute.SelectedItem;
            dailyTask.intMinute = Int32.Parse(dailyTask.minute);
            dailyTask.NewTask = true;
        }

        private void NameTaskTextBox_TextChanged(object sender, EventArgs e)
        {
            task.name = NameTaskTextBox.Text;
        }
    }
}
