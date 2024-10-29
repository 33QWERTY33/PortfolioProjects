using System;
using System.Linq;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class CreateClusterView : UserControl
    {
        public CreateClusterView()
        {
            InitializeComponent();
        }

        private bool DataValidation()
        {
            string titleInput = this.TitleInput.Text;
            string urgencyInput = this.UrgencyInput.Text;
            string categoryInput = this.CategoryInput.Text;
            DateTime dateTimeInput = this.DateTimeInput.Value;

            if (titleInput.Contains("\\") || titleInput == "" || ViewManager.clusterView.clusterOverviewBoxes.Keys.Contains(titleInput))
            {
                MessageBox.Show("The title must be unique and be between 1 and 50 characters and the title cannot contain the \"\\\" character", "Title Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CreateClusterbtn_Click(object sender, EventArgs e)
        {
            if (!DataValidation())
            {
                return;
            }

            ViewManager.changeView(this, ViewManager.clusterView);

            ViewManager.clusterView.clusterOverviewBoxes.Add(this.TitleInput.Text, new ClusterOverviewBox(
                this.TitleInput.Text,
                this.UrgencyInput.Text,
                this.CategoryInput.Text,
                this.DateTimeInput.Text));

            ViewManager.clusterView.ClusterViewPanel.Controls.Add(ViewManager.clusterView.clusterOverviewBoxes[this.TitleInput.Text]);

            this.DateTimeInput.Text = "";
            this.CategoryInput.SelectedIndex = -1;
            this.TitleInput.Text = "";
            this.UrgencyInput.SelectedIndex = -1;
        }
    }
}
