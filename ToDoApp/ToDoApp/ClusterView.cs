using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class ClusterView : UserControl
    {

        public Dictionary<string, ClusterOverviewBox> clusterOverviewBoxes = new Dictionary<string, ClusterOverviewBox>();

        public ClusterView()
        {
            InitializeComponent();

            this.SidebarUsernamelbl.Text = ViewManager.username + "'s To Do";
            this.SidebarDatelbl.Text = DateTime.Now.ToString();

            SidebarDatelbl.Text = DateTime.Today.ToString("MM-dd-yyyy");

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

        private void Filterbtn_Click(object sender, EventArgs e)
        {

            string category = specifyCategory();
            string urgency = specifyUrgency();

            foreach(KeyValuePair<string, ClusterOverviewBox> pair in clusterOverviewBoxes)
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

        private void CreateClusterbtn_Click(object sender, EventArgs e)
        {
            ViewManager.changeView(this, ViewManager.createClusterView);
        }

        private void ShowAllClustersbtn_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, ClusterOverviewBox> pair in clusterOverviewBoxes)
            {
                pair.Value.Show();
            }
        }
    }
}
