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
using Оrganiser.Properties;

namespace Оrganiser
{
    public partial class Archive : Form
    {
        private StartForm startForm;

        public Archive()
        {
            InitializeComponent();
        }

        public Archive(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            DailyTask.UpdateList(startForm.archiveTasks, listArchive, false);
        }

        private void Archive_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.UpdateStartForm();
            startForm.Show();
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listArchive.Items)
            {
                if (item.Checked == true)
                {
                    DailyTask.TransferTask(startForm.dailyTasks, startForm.archiveTasks, item.Index);
                    item.Remove();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listArchive.Items)
            {
                if (item.Checked == true)
                {
                    startForm.archiveTasks.RemoveAt(item.Index);
                    item.Remove();
                }
            }
        }
    }
}
