using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class CreateTaskView : UserControl
    {
        public CreateTaskView()
        {
            InitializeComponent();
        }

        private bool DataValidation()
        {
            string titleInput = this.TitleInput.Text;
            string taskInput = this.TaskInput.Text;
            string notesInput = this.NotesInput.Text;
            string urgencyInput = this.UrgencyInput.Text;
            string categoryInput = this.CategoryInput.Text;
            DateTime dateTimeInput = this.DateTimeInput.Value;

            if (titleInput.Contains("\\") || titleInput == "" || ViewManager.taskView.taskOverviewBoxes.Keys.Contains(titleInput))
            {
                MessageBox.Show("The title must be unique and be between 1 and 50 characters and the title cannot contain the \"\\\" character", "Title Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskInput.Contains("\\") || taskInput == "")
            {
                MessageBox.Show("The task cannot contain the \"\\\" character and must not be empty ", "Task Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskInput.Contains("\\"))
            {
                MessageBox.Show("The task cannot contain the \"\\\" character", "Task Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (urgencyInput != "High" && urgencyInput != "Medium" && urgencyInput != "Low")
            {
                MessageBox.Show("One urgency level must be selected", "Urgency Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (categoryInput != "School" && categoryInput != "Fitness" && categoryInput != "Study" && categoryInput != "Project" && categoryInput != "Other")
            {
                MessageBox.Show("One category must be selected", "Category Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateTimeInput.AddDays(1) < DateTime.Now)
            {
                MessageBox.Show("You have selected a due date that is before the current date", "Due Date Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CreateTaskbtn_Click(object sender, EventArgs e)
        {

            if (!DataValidation()) 
            {
                return;
            }

            ViewManager.changeView(this, ViewManager.taskView);

            ViewManager.taskView.taskOverviewBoxes.Add(this.TitleInput.Text, new TaskOverviewBox(
                this.TitleInput.Text,
                this.TaskInput.Text,
                this.NotesInput.Text,
                this.UrgencyInput.Text,
                this.CategoryInput.Text,
                this.DateTimeInput.Text));

            ViewManager.taskView.TaskViewPanel.Controls.Add(ViewManager.taskView.taskOverviewBoxes[this.TitleInput.Text]);

            ViewManager.taskView.currentCluster.subTasks.Add(this.TitleInput.Text, ViewManager.taskView.taskOverviewBoxes[this.TitleInput.Text]);

            this.TitleInput.Text = "";
            this.TaskInput.Text = "";
            this.NotesInput.Text = "";
            this.UrgencyInput.SelectedIndex = -1;
            this.CategoryInput.SelectedIndex = -1;
            this.DateTimeInput.Text = "";
        }
    }
}
