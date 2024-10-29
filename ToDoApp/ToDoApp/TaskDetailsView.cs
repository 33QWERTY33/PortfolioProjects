using System;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class TaskDetailsView : UserControl
    {

        public TaskOverviewBox currentTask;

        public TaskDetailsView()
        {
            InitializeComponent();

            this.SidebarUsernamelbl.Text = ViewManager.username + "'s To Do";
            this.SidebarDatelbl.Text = DateTime.Now.ToString();
        }

        private void CreateClusterbtn_Click(object sender, EventArgs e)
        {
            ViewManager.changeView(this, ViewManager.taskView);
        }

        private void CompleteTaskbtn_Click(object sender, EventArgs e)
        {
            ViewManager.taskView.taskOverviewBoxes[this.currentTask.title].Hide();
            ViewManager.taskView.taskOverviewBoxes.Remove(this.currentTask.title);

            ViewManager.taskView.currentCluster.subTasks.Remove(this.currentTask.title);

            ViewManager.changeView(this, ViewManager.taskView);
        }

        private void UpdateTaskbtn_Click(object sender, EventArgs e)
        {

            ViewManager.createTaskView.DateTimeInput.Text = ViewManager.taskDetailsView.currentTask.dueDate;
            ViewManager.createTaskView.NotesInput.Text = ViewManager.taskDetailsView.currentTask.notes;
            ViewManager.createTaskView.TaskInput.Text = ViewManager.taskDetailsView.currentTask.contents;
            ViewManager.createTaskView.TitleInput.Text = ViewManager.taskDetailsView.currentTask.title;

            ViewManager.createTaskView.CategoryInput.SelectedIndex = -1;
            ViewManager.createTaskView.UrgencyInput.SelectedIndex = -1;

            ViewManager.taskView.taskOverviewBoxes[this.currentTask.title].Hide();
            ViewManager.taskView.taskOverviewBoxes.Remove(this.currentTask.title);

            ViewManager.taskView.currentCluster.subTasks.Remove(this.currentTask.title);

            ViewManager.changeView(this, ViewManager.createTaskView);
        }
    }
}