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
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.CompleteTaskButton = new System.Windows.Forms.Button();
            this.ResetTaskButton = new System.Windows.Forms.Button();
            this.listViewTask = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxСurrentTask = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 53);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(444, 222);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.Location = new System.Drawing.Point(702, 12);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(64, 35);
            this.AddTaskButton.TabIndex = 1;
            this.AddTaskButton.Text = "+";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // CompleteTaskButton
            // 
            this.CompleteTaskButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompleteTaskButton.Location = new System.Drawing.Point(462, 12);
            this.CompleteTaskButton.Name = "CompleteTaskButton";
            this.CompleteTaskButton.Size = new System.Drawing.Size(64, 35);
            this.CompleteTaskButton.TabIndex = 3;
            this.CompleteTaskButton.Text = "V";
            this.CompleteTaskButton.UseVisualStyleBackColor = true;
            // 
            // ResetTaskButton
            // 
            this.ResetTaskButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetTaskButton.Location = new System.Drawing.Point(532, 12);
            this.ResetTaskButton.Name = "ResetTaskButton";
            this.ResetTaskButton.Size = new System.Drawing.Size(64, 35);
            this.ResetTaskButton.TabIndex = 4;
            this.ResetTaskButton.Text = "X";
            this.ResetTaskButton.UseVisualStyleBackColor = true;
            // 
            // listViewTask
            // 
            this.listViewTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.DayTask});
            this.listViewTask.HideSelection = false;
            this.listViewTask.Location = new System.Drawing.Point(462, 53);
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
            this.DayTask.Width = 200;
            // 
            // textBoxСurrentTask
            // 
            this.textBoxСurrentTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxСurrentTask.Enabled = false;
            this.textBoxСurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxСurrentTask.Location = new System.Drawing.Point(13, 12);
            this.textBoxСurrentTask.Name = "textBoxСurrentTask";
            this.textBoxСurrentTask.Size = new System.Drawing.Size(443, 35);
            this.textBoxСurrentTask.TabIndex = 6;
            this.textBoxСurrentTask.Text = "Задача не указана";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxСurrentTask);
            this.Controls.Add(this.listViewTask);
            this.Controls.Add(this.ResetTaskButton);
            this.Controls.Add(this.CompleteTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.Activated += new System.EventHandler(this.StartForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button CompleteTaskButton;
        private System.Windows.Forms.Button ResetTaskButton;
        private System.Windows.Forms.ListView listViewTask;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader DayTask;
        private System.Windows.Forms.RichTextBox textBoxСurrentTask;
        private System.Windows.Forms.Button button1;
    }
}

