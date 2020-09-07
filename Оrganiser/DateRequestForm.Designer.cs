namespace Оrganiser
{
    partial class DateRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTaskTextBox = new System.Windows.Forms.TextBox();
            this.TaskCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.comboBoxTaskHour = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskMinute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTaskTextBox
            // 
            this.NameTaskTextBox.Location = new System.Drawing.Point(91, 190);
            this.NameTaskTextBox.Name = "NameTaskTextBox";
            this.NameTaskTextBox.Size = new System.Drawing.Size(427, 20);
            this.NameTaskTextBox.TabIndex = 9;
            // 
            // TaskCalendar
            // 
            this.TaskCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.TaskCalendar.Location = new System.Drawing.Point(18, 18);
            this.TaskCalendar.Name = "TaskCalendar";
            this.TaskCalendar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Час:";
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.Location = new System.Drawing.Point(310, 252);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(101, 33);
            this.AddTaskButton.TabIndex = 4;
            this.AddTaskButton.Text = "Добавить";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // comboBoxTaskHour
            // 
            this.comboBoxTaskHour.Enabled = false;
            this.comboBoxTaskHour.FormattingEnabled = true;
            this.comboBoxTaskHour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxTaskHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxTaskHour.Location = new System.Drawing.Point(319, 216);
            this.comboBoxTaskHour.Name = "comboBoxTaskHour";
            this.comboBoxTaskHour.Size = new System.Drawing.Size(58, 21);
            this.comboBoxTaskHour.TabIndex = 5;
            // 
            // comboBoxTaskMinute
            // 
            this.comboBoxTaskMinute.Enabled = false;
            this.comboBoxTaskMinute.FormattingEnabled = true;
            this.comboBoxTaskMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBoxTaskMinute.Location = new System.Drawing.Point(460, 216);
            this.comboBoxTaskMinute.Name = "comboBoxTaskMinute";
            this.comboBoxTaskMinute.Size = new System.Drawing.Size(58, 21);
            this.comboBoxTaskMinute.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(383, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Минуты:";
            // 
            // AddTimeCheckBox
            // 
            this.AddTimeCheckBox.AutoSize = true;
            this.AddTimeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTimeCheckBox.Location = new System.Drawing.Point(91, 216);
            this.AddTimeCheckBox.Name = "AddTimeCheckBox";
            this.AddTimeCheckBox.Size = new System.Drawing.Size(141, 24);
            this.AddTimeCheckBox.TabIndex = 8;
            this.AddTimeCheckBox.Text = "Указать время";
            this.AddTimeCheckBox.UseVisualStyleBackColor = true;
            this.AddTimeCheckBox.CheckedChanged += new System.EventHandler(this.AddTimeCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Задача:";
            // 
            // CancelTaskButton
            // 
            this.CancelTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelTaskButton.Location = new System.Drawing.Point(417, 252);
            this.CancelTaskButton.Name = "CancelTaskButton";
            this.CancelTaskButton.Size = new System.Drawing.Size(101, 33);
            this.CancelTaskButton.TabIndex = 11;
            this.CancelTaskButton.Text = "Отменить";
            this.CancelTaskButton.UseVisualStyleBackColor = true;
            this.CancelTaskButton.Click += new System.EventHandler(this.CancelTaskButton_Click);
            // 
            // DateRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 300);
            this.Controls.Add(this.CancelTaskButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTaskTextBox);
            this.Controls.Add(this.AddTimeCheckBox);
            this.Controls.Add(this.comboBoxTaskMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTaskHour);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskCalendar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateRequestForm_FormClosing);
            this.Load += new System.EventHandler(this.DateRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button AddTaskButton;
        protected System.Windows.Forms.Button CancelTaskButton;
        protected System.Windows.Forms.MonthCalendar TaskCalendar;
        protected System.Windows.Forms.ComboBox comboBoxTaskHour;
        protected System.Windows.Forms.ComboBox comboBoxTaskMinute;
        protected System.Windows.Forms.CheckBox AddTimeCheckBox;
        protected System.Windows.Forms.TextBox NameTaskTextBox;
    }
}