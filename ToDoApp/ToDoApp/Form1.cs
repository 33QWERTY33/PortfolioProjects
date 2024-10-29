using System;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Load += InitializeViews;
            this.FormClosing += JSONManager.serializeTasks;
        }
        internal void InitializeViews(object sender, EventArgs e)
        {
            this.Controls.Add(ViewManager.clusterView);
            this.Controls.Add(ViewManager.taskView);
            this.Controls.Add(ViewManager.createClusterView);
            this.Controls.Add(ViewManager.createTaskView);
            this.Controls.Add(ViewManager.taskDetailsView);

            ViewManager.taskView.Hide();
            ViewManager.createClusterView.Hide();

            JSONManager.CreateTasks();
        }
    }
}
