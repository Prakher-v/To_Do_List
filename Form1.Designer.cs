namespace ToDoListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listTasks;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtTask
            this.txtTask.Location = new System.Drawing.Point(12, 12);
            this.txtTask.Size = new System.Drawing.Size(250, 20);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(270, 10);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Text = "Add Task";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // listTasks
            this.listTasks.FormattingEnabled = true;
            this.listTasks.Location = new System.Drawing.Point(12, 45);
            this.listTasks.Size = new System.Drawing.Size(333, 150);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(12, 205);
            this.btnDelete.Size = new System.Drawing.Size(120, 25);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
