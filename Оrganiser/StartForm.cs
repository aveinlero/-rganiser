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
    public partial class StartForm : Form
    {
        public bool statusDateRequest { get; set; }
        public List<DailyTask> dailyTasks { get; set; }

        int taskIndex;

        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusDateRequest = false;

            dailyTasks = new List<DailyTask>();
            //TODO сделать заполнения листа из файла
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (!statusDateRequest) 
            {
                DateRequestForm dateRequest = new DateRequestForm(this);
                dateRequest.Show();
                statusDateRequest = true;
                this.Hide();
            }
        }

        private void StartForm_Activated(object sender, EventArgs e)
        {
            // Создание и сортировка списка задач
            if (!(dailyTasks.Count > 0)) { descriptionTextBox.Enabled = false; }

            dailyTasks.Sort(DailyTask.SortDailyTask);
            listViewTask.Items.Clear();
            foreach (DailyTask task in dailyTasks)
            {
                task.AddTask(listViewTask);
            }
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            // Сохранение описания задачи
            dailyTasks[taskIndex].description = descriptionTextBox.Text;
        }

        private void listViewTask_ItemActivate(object sender, EventArgs e)
        {
            descriptionTextBox.Enabled = true;

            // Загрузка описания выбранной задачи
            taskIndex = listViewTask.SelectedIndices[0];

            descriptionTextBox.Text = dailyTasks[taskIndex].description;

            if (dailyTasks[taskIndex].checkTime)
            { textBoxСurrentTask.Text = $"{dailyTasks[taskIndex].date.ToString("d")} {dailyTasks[taskIndex].hour}:{dailyTasks[taskIndex].minute}\n{dailyTasks[taskIndex].name}"; }
            else
            { textBoxСurrentTask.Text = $"{dailyTasks[taskIndex].date.ToString("d")}\n{dailyTasks[taskIndex].name}"; }
        }
    }
}
