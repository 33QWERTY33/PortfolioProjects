using System.Windows.Forms;

namespace ToDoApp
{
    public partial class TaskOverviewBox : UserControl
    {
        internal string title;
        internal string contents;
        internal string notes;

        internal string urgency;
        internal string category;
        internal string dueDate;

        public TaskOverviewBox(string title, string contents, string notes, string urgency, string category, string dueDate)
        {
            InitializeComponent();

            this.title = title;
            this.contents = contents;
            this.notes = notes;
            this.urgency = urgency;
            this.category = category;
            this.dueDate = dueDate;

            this.TaskTitlelbl.Text = title;
            this.TaskUrgencylbl.Text = "Urgency: " + urgency;
            this.TaskCategorylbl.Text = "Category: " + category;
            this.TaskDueDatelbl.Text = "Due: " + dueDate;
        }

        public TaskOverviewBox(DTOTask taskData)
        {
            InitializeComponent();

            this.title = taskData.title;
            this.contents = taskData.task;
            this.notes = taskData.notes;
            this.urgency = taskData.urgency;
            this.category = taskData.category;
            this.dueDate = taskData.dueDate;

            this.TaskTitlelbl.Text = this.title;
            this.TaskUrgencylbl.Text = "Urgency: " + this.urgency;
            this.TaskCategorylbl.Text = "Category: " + this.category;
            this.TaskDueDatelbl.Text = "Due: " + this.dueDate;
        }

        public TaskOverviewBox() { }

        private void ViewTaskDetailsbtn_Click(object sender, System.EventArgs e)
        {


            ViewManager.taskDetailsView.currentTask = ViewManager.taskView.taskOverviewBoxes[this.title];
            // changing currentTask prop to the acted upon taskOverviewBox

            ViewManager.changeView(ViewManager.taskView, ViewManager.taskDetailsView);

            ViewManager.changeView(ViewManager.createTaskView, ViewManager.taskDetailsView);
            // For some reason the task details view shows up occasionally, this is a bug that has stumped me but it has a 2ms fix...

            ViewManager.taskDetailsView.TaskDetailsTitlelbl.Text = this.title;
            ViewManager.taskDetailsView.DueDateDisplaylbl.Text = "Due: " + this.dueDate;
            ViewManager.taskDetailsView.CategoryDisplaylbl.Text = "Category: " + this.category;
            ViewManager.taskDetailsView.UrgencyDisplaylbl.Text = "Urgency: " + this.urgency;
            ViewManager.taskDetailsView.TaskContentsBox.Text = this.contents;
            ViewManager.taskDetailsView.TaskNotesBox.Text = this.notes;
        }
    }
}
