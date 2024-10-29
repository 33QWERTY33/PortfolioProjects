using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class TaskView : UserControl
    {

        public ClusterOverviewBox currentCluster;
        public Dictionary<string, TaskOverviewBox> taskOverviewBoxes = new Dictionary<string, TaskOverviewBox>();

        public TaskView()
        {
            InitializeComponent();

            this.SidebarUsernamelbl.Text = ViewManager.username + "'s To Do";
            this.SidebarDatelbl.Text = DateTime.Now.ToString();
        }

        private void CreateTaskbtn_Click(object sender, EventArgs e)
        {
            ViewManager.changeView(this, ViewManager.createTaskView);
        }

        private void BackToClusterViewbtn_Click(object sender, EventArgs e)
        {
            ViewManager.changeView(this, ViewManager.clusterView);
        }

        private void DeleteClusterbtn_Click(object sender, EventArgs e)
        {
            ViewManager.changeView(this, ViewManager.clusterView);

            ViewManager.clusterView.clusterOverviewBoxes[ViewManager.taskView.currentCluster.title].Hide();
            ViewManager.clusterView.clusterOverviewBoxes.Remove(ViewManager.taskView.currentCluster.title);
        }

        internal string specifyCategory()
        {
            foreach (RadioButton option in this.CategoryChecklist.Controls)
            {
                if (option.Checked)
                {
                    option.Checked = false;
                    return option.Name;
                }
            }
            return "";
        }

        internal string specifyUrgency()
        {
            foreach (RadioButton option in this.UrgencyChecklist.Controls)
            {
                if (option.Checked)
                {
                    option.Checked = false;
                    return option.Name;
                }
            }
            return "";
        }

        private void TaskFilterbtn_Click(object sender, EventArgs e)
        {
            string category = specifyCategory();
            string urgency = specifyUrgency();

            foreach (KeyValuePair<string, TaskOverviewBox> pair in taskOverviewBoxes)
            {
                pair.Value.Show();

                if (category != "" && category != pair.Value.category)
                {
                    pair.Value.Hide();
                    continue;
                }
                if (urgency != "" && urgency != pair.Value.urgency)
                {
                    pair.Value.Hide();
                    continue;
                }
                if (this.FilterDayInput.Text != "" && ViewManager.today.AddDays(double.Parse(this.FilterDayInput.Text)) < DateTime.Parse(pair.Value.dueDate))
                {
                    pair.Value.Hide();
                    continue;
                }
            }
        }

        private void ShowAllTasksbtn_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, TaskOverviewBox> pair in taskOverviewBoxes)
            {
                if (ViewManager.taskView.currentCluster.subTasks.ContainsKey(pair.Key))
                {
                    pair.Value.Show();
                }
            }
        }
    }
}
