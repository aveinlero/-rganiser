using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Оrganiser
{
    public partial class StartForm : Form
    {
        //public bool statusDateRequest { get; set; } = false;
        public List<DailyTask> dailyTasks { get; set; }
        public List<DailyTask> archiveTasks { get; set; }
        public string fileTasks { get; set; } = "tasks.dat";
        public string fileArchive { get; set; } = "archive.dat";

        public int index { get; private set; } = 0;
        public int limitArchive { get; } = 20;

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            ButtonResetTask.Enabled = false;
            ButtonCompleteTask.Enabled = false;

            dailyTasks = new List<DailyTask>();
            archiveTasks = new List<DailyTask>();

            // Загрузка списка задач из файла
            if (File.Exists(fileTasks))
            {
                dailyTasks = DailyTask.LoadTaskList(fileTasks);
            }

            if (File.Exists(fileArchive))
            {
                archiveTasks = DailyTask.LoadTaskList(fileArchive);
            }

            this.UpdateStartForm();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDescription();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            DateRequestForm dateRequest = new DateRequestForm(this);
            dateRequest.Show();
            this.Hide();
        }

        //private void StartForm_Activated(object sender, EventArgs e)
        //{
        //    // Создание и сортировка списка задач
        //    if (!(dailyTasks.Count > 0))
        //    {
        //        LockDescription();
        //    }
        //    else
        //    {
        //        DailyTask.UpdateList(dailyTasks, listViewTask, true);
        //        index = DailyTask.FindNew(dailyTasks);
        //        listViewTask.Items[index].Selected = true;
        //        LoadDescription(index);
        //    }
        //}

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            // Сохранение описания задачи
            SaveDescription();
        }

        private void listViewTask_ItemActivate(object sender, EventArgs e)
        {
            ButtonResetTask.Enabled = true;
            ButtonCompleteTask.Enabled = true;

            // Загрузка описания выбранной задачи
            index = listViewTask.SelectedIndices[0];
            LoadDescription(index);
        }

        private void ButtonOpenArchive_Click(object sender, EventArgs e)
        {
            Archive archive = new Archive(this);
            archive.Show();
            this.Hide();
        }

        private void ButtonCompleteTask_Click(object sender, EventArgs e)
        {
            DailyTask.TransferTask(archiveTasks, dailyTasks, index);
            DailyTask.UpdateList(dailyTasks, listViewTask, true);
            DailyTask.LimitList(archiveTasks, limitArchive);

            DeactivateControlButtons();
            LoadDescription(0);
        }

        private void DeactivateControlButtons()
        {
            if (dailyTasks.Count == 0)
            {
                ButtonCompleteTask.Enabled = false;
                ButtonResetTask.Enabled = false;
            }
            else
            {
                listViewTask.Items[0].Selected = true;
            }
        }

        private void ButtonResetTask_Click(object sender, EventArgs e)
        {
            FormUpdateTask formUpdateTask = new FormUpdateTask(this);
            formUpdateTask.Show();
            this.Hide();
        }

        private void LockDescription()
        {
            descriptionTextBox.Enabled = false;
            descriptionTextBox.Text = "";
            textBoxСurrentTask.Text = "Задача не выбрана";
        }

        private void LoadDescription(int index)
        {
            descriptionTextBox.Enabled = true;
            descriptionTextBox.Text = dailyTasks[index].description;

            if (dailyTasks[index].checkTime)
            { textBoxСurrentTask.Text = $"{dailyTasks[index].date:d} {dailyTasks[index].hour}:{dailyTasks[index].minute}\n{dailyTasks[index].name}"; }
            else
            { textBoxСurrentTask.Text = $"{dailyTasks[index].date:d}\n{dailyTasks[index].name}"; }
        }

        public void SaveDescription()
        {
            dailyTasks[index].description = descriptionTextBox.Text;
        }

        public void UpdateStartForm()
        {
            if (!(dailyTasks.Count > 0))
            {
                LockDescription();
            }
            else
            {
                DailyTask.UpdateList(dailyTasks, listViewTask, true);
                index = DailyTask.FindNew(dailyTasks);
                listViewTask.Items[index].Selected = true;
                LoadDescription(index);
            }
        }

    }
}
