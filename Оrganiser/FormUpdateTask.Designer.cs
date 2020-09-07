namespace Оrganiser
{
    partial class FormUpdateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateTask));
            this.SuspendLayout();
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Text = "Обновить";
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // CancelTaskButton
            // 
            this.CancelTaskButton.Text = "Удалить";
            this.CancelTaskButton.Click += new System.EventHandler(this.FormUpdateCancelTaskButton_Click);
            // 
            // TaskCalendar
            // 
            this.TaskCalendar.MaxSelectionCount = 1;
            // 
            // comboBoxTaskHour
            // 
            this.comboBoxTaskHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // comboBoxTaskMinute
            // 
            this.comboBoxTaskMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // NameTaskTextBox
            // 
            this.NameTaskTextBox.TextChanged += new System.EventHandler(this.NameTaskTextBox_TextChanged);
            // 
            // FormUpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(526, 294);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateTask";
            this.Text = "FormUpdateTask";
            this.Load += new System.EventHandler(this.DateRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}