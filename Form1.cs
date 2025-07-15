using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        private List<string> toDoList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                toDoList.Add(task);
                listTasks.Items.Add(task);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex >= 0)
            {
                int index = listTasks.SelectedIndex;
                toDoList.RemoveAt(index);
                listTasks.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Select a task to delete.");
            }
        }
    }
}
