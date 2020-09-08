namespace Оrganiser
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.listViewTask = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxСurrentTask = new System.Windows.Forms.RichTextBox();
            this.ButtonOpenArchive = new System.Windows.Forms.Button();
            this.ButtonResetTask = new System.Windows.Forms.Button();
            this.ButtonCompleteTask = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.menuStripService = new System.Windows.Forms.MenuStrip();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripService.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(322, 68);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(444, 222);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
            // 
            // listViewTask
            // 
            this.listViewTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.DayTask});
            this.listViewTask.HideSelection = false;
            this.listViewTask.Location = new System.Drawing.Point(12, 68);
            this.listViewTask.MultiSelect = false;
            this.listViewTask.Name = "listViewTask";
            this.listViewTask.Size = new System.Drawing.Size(304, 222);
            this.listViewTask.TabIndex = 5;
            this.listViewTask.UseCompatibleStateImageBehavior = false;
            this.listViewTask.View = System.Windows.Forms.View.Details;
            this.listViewTask.ItemActivate += new System.EventHandler(this.listViewTask_ItemActivate);
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 100;
            // 
            // DayTask
            // 
            this.DayTask.Text = "Задача";
            this.DayTask.Width = 180;
            // 
            // textBoxСurrentTask
            // 
            this.textBoxСurrentTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxСurrentTask.Enabled = false;
            this.textBoxСurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxСurrentTask.Location = new System.Drawing.Point(323, 27);
            this.textBoxСurrentTask.Name = "textBoxСurrentTask";
            this.textBoxСurrentTask.Size = new System.Drawing.Size(443, 35);
            this.textBoxСurrentTask.TabIndex = 6;
            this.textBoxСurrentTask.Text = "Задача не указана";
            // 
            // ButtonOpenArchive
            // 
            this.ButtonOpenArchive.BackgroundImage = global::Оrganiser.Properties.Resources.checklist_64x35;
            this.ButtonOpenArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonOpenArchive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOpenArchive.Location = new System.Drawing.Point(167, 27);
            this.ButtonOpenArchive.Name = "ButtonOpenArchive";
            this.ButtonOpenArchive.Size = new System.Drawing.Size(64, 35);
            this.ButtonOpenArchive.TabIndex = 7;
            this.ButtonOpenArchive.UseVisualStyleBackColor = true;
            this.ButtonOpenArchive.Click += new System.EventHandler(this.ButtonOpenArchive_Click);
            // 
            // ButtonResetTask
            // 
            this.ButtonResetTask.BackgroundImage = global::Оrganiser.Properties.Resources.ButtonCancel_64x35_v2;
            this.ButtonResetTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonResetTask.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonResetTask.Location = new System.Drawing.Point(82, 27);
            this.ButtonResetTask.Name = "ButtonResetTask";
            this.ButtonResetTask.Size = new System.Drawing.Size(64, 35);
            this.ButtonResetTask.TabIndex = 4;
            this.ButtonResetTask.UseVisualStyleBackColor = true;
            this.ButtonResetTask.Click += new System.EventHandler(this.ButtonResetTask_Click);
            // 
            // ButtonCompleteTask
            // 
            this.ButtonCompleteTask.BackgroundImage = global::Оrganiser.Properties.Resources.ButtonOK_64x35_v2;
            this.ButtonCompleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonCompleteTask.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCompleteTask.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonCompleteTask.Location = new System.Drawing.Point(12, 27);
            this.ButtonCompleteTask.Name = "ButtonCompleteTask";
            this.ButtonCompleteTask.Size = new System.Drawing.Size(64, 35);
            this.ButtonCompleteTask.TabIndex = 3;
            this.ButtonCompleteTask.UseVisualStyleBackColor = true;
            this.ButtonCompleteTask.Click += new System.EventHandler(this.ButtonCompleteTask_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackgroundImage = global::Оrganiser.Properties.Resources.ButtonAdd_64x35_origin;
            this.AddTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddTaskButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.Location = new System.Drawing.Point(252, 27);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(64, 35);
            this.AddTaskButton.TabIndex = 1;
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // menuStripService
            // 
            this.menuStripService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripService.Location = new System.Drawing.Point(0, 0);
            this.menuStripService.Name = "menuStripService";
            this.menuStripService.Size = new System.Drawing.Size(778, 24);
            this.menuStripService.TabIndex = 8;
            this.menuStripService.Text = "menuStripService";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWindowsToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // changeWindowsToolStripMenuItem
            // 
            this.changeWindowsToolStripMenuItem.Name = "changeWindowsToolStripMenuItem";
            this.changeWindowsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.changeWindowsToolStripMenuItem.Text = "Обменять окна";
            this.changeWindowsToolStripMenuItem.Click += new System.EventHandler(this.ChangeWindowsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 301);
            this.Controls.Add(this.ButtonOpenArchive);
            this.Controls.Add(this.textBoxСurrentTask);
            this.Controls.Add(this.listViewTask);
            this.Controls.Add(this.ButtonResetTask);
            this.Controls.Add(this.ButtonCompleteTask);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.menuStripService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripService;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 340);
            this.MinimumSize = new System.Drawing.Size(794, 340);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.menuStripService.ResumeLayout(false);
            this.menuStripService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button ButtonCompleteTask;
        private System.Windows.Forms.Button ButtonResetTask;
        private System.Windows.Forms.ListView listViewTask;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader DayTask;
        private System.Windows.Forms.RichTextBox textBoxСurrentTask;
        private System.Windows.Forms.Button ButtonOpenArchive;
        private System.Windows.Forms.MenuStrip menuStripService;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

