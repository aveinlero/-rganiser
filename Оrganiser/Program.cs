using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Оrganiser
{
    static class Program
    {
        static StartForm startForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                startForm = new StartForm();
                Application.Run(startForm);
            }
            finally
            {
                DailyTask.SaveTaskList(startForm.dailyTasks, startForm.fileTasks);
                DailyTask.SaveTaskList(startForm.archiveTasks, startForm.fileArchive);
                Properties.Settings.Default.Save();
            }
        }
    }
}
