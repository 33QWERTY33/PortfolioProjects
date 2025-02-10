using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class ClusterOverviewBox : UserControl
    {
        internal string title;
        internal string urgency;
        internal string category;
        internal string dueDate;

        internal Dictionary<string, TaskOverviewBox> subTasks = new Dictionary<string, TaskOverviewBox>();

        public ClusterOverviewBox(string title, string urgency, string category, string dueDate)
        {
            InitializeComponent();

            this.title = title;
            this.urgency = urgency;
            this.category = category;
            this.dueDate = dueDate;
               
            this.ClusterTitlelbl.Text = this.title;
            this.ClusterUrgencylbl.Text = "Urgency: " + this.urgency;
            this.ClusterCategorylbl.Text = "Category: " + this.category;
            this.ClusterDueDatelbl.Text = "Due: " + this.dueDate;
        }

        public ClusterOverviewBox(DTOCluster clusterData)
        {
            InitializeComponent();

            this.title = clusterData.title;
            this.urgency = clusterData.urgency;
            this.category = clusterData.category;
            this.dueDate = clusterData.dueDate;

            this.ClusterTitlelbl.Text = this.title;
            this.ClusterUrgencylbl.Text = "Urgency: " + this.urgency;
            this.ClusterCategorylbl.Text = "Category: " + this.category;
            this.ClusterDueDatelbl.Text = "Due: " + this.dueDate;
        }

        public ClusterOverviewBox() { }

        private void ViewClusterDetailsbtn_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, TaskOverviewBox> pair in ViewManager.taskView.taskOverviewBoxes)
            {
                pair.Value.Hide();
            }

            foreach (KeyValuePair<string, TaskOverviewBox> pair in this.subTasks)
            {
                pair.Value.Show();
            }

            ViewManager.taskView.currentCluster = ViewManager.clusterView.clusterOverviewBoxes[this.title];

            ViewManager.taskView.Clusterlbl.Text = this.title;

            ViewManager.changeView(ViewManager.clusterView, ViewManager.taskView);
        }
    }
}
