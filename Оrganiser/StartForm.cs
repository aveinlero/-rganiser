using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Оrganiser.Properties;

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
            
            CreateToolTip(ButtonCompleteTask, "Отправить событие в архив с отметкой \"завершено\"");
            CreateToolTip(ButtonResetTask, "Обновить/удалить событие");
            CreateToolTip(ButtonOpenArchive, "Архив событий");
            CreateToolTip(AddTaskButton, "Добавить новое событие");

            this.UpdateStartForm();
            this.DeactivateControlButtons();

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
            dailyTasks[index].status = true;
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
                ButtonCompleteTask.BackgroundImage = new Bitmap(Resources.ButtonOK_64x35_v2_inactive);
                ButtonResetTask.BackgroundImage = new Bitmap(Resources.ButtonCancel_64x35_v2_inactive);
            }
            else
            {
                ButtonCompleteTask.Enabled = true;
                ButtonResetTask.Enabled = true;
                listViewTask.Items[0].Selected = true;
                ButtonCompleteTask.BackgroundImage = new Bitmap(Resources.ButtonOK_64x35_v2);
                ButtonResetTask.BackgroundImage = new Bitmap(Resources.ButtonCancel_64x35_v2);
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
            textBoxСurrentTask.Text = "Событие не выбрано";
        }

        private void LoadDescription(int index)
        {
            if (!(dailyTasks.Count == 0))
            {
                descriptionTextBox.Enabled = true;
                descriptionTextBox.Text = dailyTasks[index].description;
                if (dailyTasks[index].checkTime)
                { textBoxСurrentTask.Text = $"{dailyTasks[index].date:d} {dailyTasks[index].hour}:{dailyTasks[index].minute}\n{dailyTasks[index].name}"; }
                else
                { textBoxСurrentTask.Text = $"{dailyTasks[index].date:d}\n{dailyTasks[index].name}"; }
            }
            else
            {
                LockDescription();
            }
        }

        public void SaveDescription()
        {
            if (!(dailyTasks.Count == 0)) { dailyTasks[index].description = descriptionTextBox.Text; }
        }

        public void UpdateStartForm()
        {
            if (dailyTasks.Count == 0)
            {
                LockDescription();
                DailyTask.UpdateList(dailyTasks, listViewTask, true);
            }
            else
            {
                DailyTask.UpdateList(dailyTasks, listViewTask, true);
                index = DailyTask.FindNew(dailyTasks);
                listViewTask.Items[index].Selected = true;
                LoadDescription(index);
            }
            
            DeactivateControlButtons();
        }

        private void CreateToolTip(Button button, string text) 
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button, text);
        }
    }
}
