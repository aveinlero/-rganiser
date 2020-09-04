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
        StartForm startForm;
        
        public DateRequestForm()
        {
            InitializeComponent();
        }

        public DateRequestForm(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            TaskCalendar.MaxSelectionCount = 1;

            comboBoxTaskHour.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskMinute.DropDownStyle = ComboBoxStyle.DropDownList;
            AddHours();
            AddMinutes();
            comboBoxTaskHour.Text = "00";
            comboBoxTaskMinute.Text = "00";
        }

        private void AddHours()
        {
            for (int i = 0; i <= 23; i++)
            {
                string text;
                if (i < 10)
                {
                    text = "0" + i.ToString();
                }
                else
                {
                    text = i.ToString();
                }
                comboBoxTaskHour.Items.Add((object)text);
            }
        }

        private void AddMinutes()
        {
            for (int i = 0; i <= 55; i+=5)
            {
                string text;
                if (i < 10)
                {
                    text = "0" + i.ToString();
                }
                else
                {
                    text = i.ToString();
                }
                comboBoxTaskMinute.Items.Add((object)text);
            }
        }

        private void ShowStartForm()
        {
            this.Close();
            startForm.Show();
            startForm.statusDateRequest = false;
        }

        private void CancelTaskButton_Click(object sender, EventArgs e)
        {
            ShowStartForm();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
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

            ShowStartForm();
        }

        private void AddTimeCheckBox_CheckedChanged(object sender, EventArgs e)
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

    }
}
