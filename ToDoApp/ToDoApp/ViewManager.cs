using System;
using System.Windows.Forms;

namespace ToDoApp
{
    internal static class ViewManager    // This class provides universal User Control management throughout the project
    {
        public static string username = Environment.UserName;
        public static DateTime today = DateTime.Now;

        public static ClusterView clusterView = new ClusterView();
        public static TaskView taskView = new TaskView();
        public static CreateClusterView createClusterView = new CreateClusterView();
        public static CreateTaskView createTaskView = new CreateTaskView();
        public static TaskDetailsView taskDetailsView = new TaskDetailsView();
        internal static void changeView(UserControl currentView, UserControl newView)
        {
            currentView.Hide();
            newView.Show();
        }
    }
}