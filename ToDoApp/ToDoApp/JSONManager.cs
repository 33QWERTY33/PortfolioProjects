using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

namespace ToDoApp
{
    public class DTOCluster
    {
        public string title { get; set; }
        public string urgency { get; set; }
        public string category { get; set; }
        public string dueDate { get; set; }
        public Dictionary<string, DTOTask> subTasks { get; set; } = new Dictionary<string, DTOTask>();

        public DTOCluster(string title, string urgency, string category, string dueDate)
        {
            this.title = title;
            this.urgency = urgency;
            this.category = category;
            this.dueDate = dueDate;
        }
    }

    public class DTOTask
    {
        public string title { get; set; }
        public string task { get; set; }
        public string notes { get; set; }
        public string urgency { get; set; }
        public string category { get; set; }
        public string dueDate { get; set; }
        public DTOTask(string title, string task, string notes, string urgency, string category, string dueDate)
        {
            this.title = title;
            this.task = task;
            this.notes = notes;
            this.urgency = urgency;
            this.category = category;
            this.dueDate = dueDate;
        }
    }

    internal static class JSONManager
    {
        internal static string toDoListFilePath;

        internal static Dictionary<string, DTOCluster> CreateDTOs()
        {
            Dictionary<string, DTOCluster> ToDoList = new Dictionary<string, DTOCluster>();
            foreach (KeyValuePair<string, ClusterOverviewBox> cluster in ViewManager.clusterView.clusterOverviewBoxes)
            {
                ToDoList.Add(cluster.Key, new DTOCluster(
                    cluster.Value.title,
                    cluster.Value.urgency,
                    cluster.Value.category,
                    cluster.Value.dueDate));

                foreach (KeyValuePair<string, TaskOverviewBox> task in cluster.Value.subTasks)
                {
                    ToDoList[cluster.Key].subTasks.Add(task.Key, new DTOTask(
                        task.Value.title,
                        task.Value.contents,
                        task.Value.notes,
                        task.Value.urgency,
                        task.Value.category,
                        task.Value.dueDate));
                }
            }

            return ToDoList;

        }

        internal static void setAppFilePath()
        {
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ToDoApp");

            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
                File.WriteAllText(Path.Combine(appDataPath, "tasks.json"), "{}");
            }

            toDoListFilePath = Path.Combine(appDataPath, "tasks.json");
            
        }

        internal static void CreateTasks()
        {
            setAppFilePath();

            string jsonTasks = File.ReadAllText(toDoListFilePath);

            Dictionary<string, DTOCluster> clusters = JsonSerializer.Deserialize<Dictionary<string, DTOCluster>>(jsonTasks);

            foreach (KeyValuePair<string, DTOCluster> cluster in clusters)
            {
                ViewManager.clusterView.clusterOverviewBoxes.Add(cluster.Value.title, new ClusterOverviewBox(cluster.Value));

                ViewManager.clusterView.ClusterViewPanel.Controls.Add(ViewManager.clusterView.clusterOverviewBoxes[cluster.Value.title]);
                
                foreach (KeyValuePair<string, DTOTask> task in cluster.Value.subTasks)
                {
                    ViewManager.taskView.taskOverviewBoxes.Add(task.Value.title, new TaskOverviewBox(task.Value));

                    ViewManager.taskView.TaskViewPanel.Controls.Add(ViewManager.taskView.taskOverviewBoxes[task.Value.title]);

                    ViewManager.clusterView.clusterOverviewBoxes[cluster.Value.title].subTasks.Add(task.Value.title, ViewManager.taskView.taskOverviewBoxes[task.Value.title]);
                }
            }
        }

        internal static void serializeTasks(object sender, FormClosingEventArgs e)
        {
            string serializedTasks = JsonSerializer.Serialize(CreateDTOs());

            File.WriteAllText(toDoListFilePath, serializedTasks);
        }
    }
}