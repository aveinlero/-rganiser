namespace Оrganiser
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            this.listArchive = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tasks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonRestore = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listArchive
            // 
            this.listArchive.CheckBoxes = true;
            this.listArchive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Tasks});
            this.listArchive.HideSelection = false;
            this.listArchive.Location = new System.Drawing.Point(12, 56);
            this.listArchive.MultiSelect = false;
            this.listArchive.Name = "listArchive";
            this.listArchive.Size = new System.Drawing.Size(604, 284);
            this.listArchive.TabIndex = 0;
            this.listArchive.UseCompatibleStateImageBehavior = false;
            this.listArchive.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 100;
            // 
            // Tasks
            // 
            this.Tasks.Text = "Задача";
            this.Tasks.Width = 480;
            // 
            // ButtonRestore
            // 
            this.ButtonRestore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRestore.Location = new System.Drawing.Point(366, 12);
            this.ButtonRestore.Name = "ButtonRestore";
            this.ButtonRestore.Size = new System.Drawing.Size(122, 35);
            this.ButtonRestore.TabIndex = 8;
            this.ButtonRestore.Text = "Восстановить";
            this.ButtonRestore.UseVisualStyleBackColor = true;
            this.ButtonRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.Location = new System.Drawing.Point(494, 12);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(122, 35);
            this.ButtonDelete.TabIndex = 10;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 352);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonRestore);
            this.Controls.Add(this.listArchive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Archive_FormClosed);
            this.Load += new System.EventHandler(this.Archive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listArchive;
        private System.Windows.Forms.Button ButtonRestore;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Tasks;
    }
}