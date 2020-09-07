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
    public partial class DateRequestForm : Form
    {
        protected StartForm startForm;
        
        public DateRequestForm()
        {
            InitializeComponent();
        }

        public DateRequestForm(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        protected void ShowStartForm()
        {
            this.Close();
            this.startForm.Show();
        }

        public virtual void CancelTaskButton_Click(object sender, EventArgs e)
        {
            ShowStartForm();
        }

        public virtual void AddTaskButton_Click(object sender, EventArgs e)
        {
            DateTime date = TaskCalendar.SelectionStart;
            string name = NameTaskTextBox.Text;

            DailyTask dailyTask;

            if (AddTimeCheckBox.Checked)
            {
                string hour = comboBoxTaskHour.Text;
                string minute = comboBoxTaskMinute.Text;
                dailyTask = new DailyTask(date, hour, minute, name);
            }
            else { dailyTask = new DailyTask(date, name); }
                
            startForm.dailyTasks.Add(dailyTask);
            dailyTask.NewTask = true;

            startForm.UpdateStartForm();
            ShowStartForm();
        }

        protected void AddTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddTimeCheckBox.Checked)
            {
                comboBoxTaskHour.Enabled = true;
                comboBoxTaskMinute.Enabled = true;
            }
            else
            {
                comboBoxTaskHour.Enabled = false;
                comboBoxTaskMinute.Enabled = false;
            }
        }

        protected void DateRequestForm_Load(object sender, EventArgs e)
        {
            TaskCalendar.MaxSelectionCount = 1;
            comboBoxTaskHour.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskMinute.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskHour.Text = "00";
            comboBoxTaskMinute.Text = "00";
        }

        private void DateRequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.startForm.Show();
        }
    }
}
