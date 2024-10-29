namespace ToDoApp
{
    partial class TaskView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clusterlbl = new System.Windows.Forms.Label();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.BackToClusterViewbtn = new System.Windows.Forms.Button();
            this.CreateTaskbtn = new System.Windows.Forms.Button();
            this.SidebarFilterGroup = new System.Windows.Forms.GroupBox();
            this.ShowAllTasksbtn = new System.Windows.Forms.Button();
            this.UrgencyChecklist = new System.Windows.Forms.GroupBox();
            this.Low = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.High = new System.Windows.Forms.RadioButton();
            this.CategoryChecklist = new System.Windows.Forms.GroupBox();
            this.Other = new System.Windows.Forms.RadioButton();
            this.Project = new System.Windows.Forms.RadioButton();
            this.Study = new System.Windows.Forms.RadioButton();
            this.Fitness = new System.Windows.Forms.RadioButton();
            this.School = new System.Windows.Forms.RadioButton();
            this.Dayslbl = new System.Windows.Forms.Label();
            this.TaskFilterbtn = new System.Windows.Forms.Button();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.FilterDayInput = new System.Windows.Forms.TextBox();
            this.DueDatelbl = new System.Windows.Forms.Label();
            this.Urgencylbl = new System.Windows.Forms.Label();
            this.SidebarDatelbl = new System.Windows.Forms.Label();
            this.SidebarUsernamelbl = new System.Windows.Forms.Label();
            this.TaskViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteClusterbtn = new System.Windows.Forms.Button();
            this.SidebarPanel.SuspendLayout();
            this.SidebarFilterGroup.SuspendLayout();
            this.UrgencyChecklist.SuspendLayout();
            this.CategoryChecklist.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clusterlbl
            // 
            this.Clusterlbl.AutoSize = true;
            this.Clusterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clusterlbl.Location = new System.Drawing.Point(558, 14);
            this.Clusterlbl.Name = "Clusterlbl";
            this.Clusterlbl.Size = new System.Drawing.Size(213, 46);
            this.Clusterlbl.TabIndex = 5;
            this.Clusterlbl.Text = "Task View";
            this.Clusterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidebarPanel.Controls.Add(this.BackToClusterViewbtn);
            this.SidebarPanel.Controls.Add(this.CreateTaskbtn);
            this.SidebarPanel.Controls.Add(this.SidebarFilterGroup);
            this.SidebarPanel.Controls.Add(this.SidebarDatelbl);
            this.SidebarPanel.Controls.Add(this.SidebarUsernamelbl);
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(278, 677);
            this.SidebarPanel.TabIndex = 6;
            // 
            // BackToClusterViewbtn
            // 
            this.BackToClusterViewbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackToClusterViewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToClusterViewbtn.Location = new System.Drawing.Point(142, 615);
            this.BackToClusterViewbtn.Name = "BackToClusterViewbtn";
            this.BackToClusterViewbtn.Size = new System.Drawing.Size(113, 48);
            this.BackToClusterViewbtn.TabIndex = 4;
            this.BackToClusterViewbtn.Text = "Back";
            this.BackToClusterViewbtn.UseVisualStyleBackColor = false;
            this.BackToClusterViewbtn.Click += new System.EventHandler(this.BackToClusterViewbtn_Click);
            // 
            // CreateTaskbtn
            // 
            this.CreateTaskbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CreateTaskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskbtn.Location = new System.Drawing.Point(7, 615);
            this.CreateTaskbtn.Name = "CreateTaskbtn";
            this.CreateTaskbtn.Size = new System.Drawing.Size(113, 48);
            this.CreateTaskbtn.TabIndex = 3;
            this.CreateTaskbtn.Text = "Create New Task";
            this.CreateTaskbtn.UseVisualStyleBackColor = false;
            this.CreateTaskbtn.Click += new System.EventHandler(this.CreateTaskbtn_Click);
            // 
            // SidebarFilterGroup
            // 
            this.SidebarFilterGroup.Controls.Add(this.ShowAllTasksbtn);
            this.SidebarFilterGroup.Controls.Add(this.UrgencyChecklist);
            this.SidebarFilterGroup.Controls.Add(this.CategoryChecklist);
            this.SidebarFilterGroup.Controls.Add(this.Dayslbl);
            this.SidebarFilterGroup.Controls.Add(this.TaskFilterbtn);
            this.SidebarFilterGroup.Controls.Add(this.Categorylbl);
            this.SidebarFilterGroup.Controls.Add(this.FilterDayInput);
            this.SidebarFilterGroup.Controls.Add(this.DueDatelbl);
            this.SidebarFilterGroup.Controls.Add(this.Urgencylbl);
            this.SidebarFilterGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SidebarFilterGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarFilterGroup.Location = new System.Drawing.Point(2, 83);
            this.SidebarFilterGroup.Name = "SidebarFilterGroup";
            this.SidebarFilterGroup.Size = new System.Drawing.Size(272, 517);
            this.SidebarFilterGroup.TabIndex = 2;
            this.SidebarFilterGroup.TabStop = false;
            this.SidebarFilterGroup.Text = "Filter";
            // 
            // ShowAllTasksbtn
            // 
            this.ShowAllTasksbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ShowAllTasksbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllTasksbtn.Location = new System.Drawing.Point(161, 463);
            this.ShowAllTasksbtn.Name = "ShowAllTasksbtn";
            this.ShowAllTasksbtn.Size = new System.Drawing.Size(105, 48);
            this.ShowAllTasksbtn.TabIndex = 19;
            this.ShowAllTasksbtn.Text = "Show All";
            this.ShowAllTasksbtn.UseVisualStyleBackColor = false;
            this.ShowAllTasksbtn.Click += new System.EventHandler(this.ShowAllTasksbtn_Click);
            // 
            // UrgencyChecklist
            // 
            this.UrgencyChecklist.Controls.Add(this.Low);
            this.UrgencyChecklist.Controls.Add(this.Medium);
            this.UrgencyChecklist.Controls.Add(this.High);
            this.UrgencyChecklist.Location = new System.Drawing.Point(41, 70);
            this.UrgencyChecklist.Name = "UrgencyChecklist";
            this.UrgencyChecklist.Size = new System.Drawing.Size(146, 117);
            this.UrgencyChecklist.TabIndex = 16;
            this.UrgencyChecklist.TabStop = false;
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.Location = new System.Drawing.Point(15, 76);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(61, 24);
            this.Low.TabIndex = 13;
            this.Low.TabStop = true;
            this.Low.Text = "Low";
            this.Low.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(15, 46);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(89, 24);
            this.Medium.TabIndex = 12;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.High.Location = new System.Drawing.Point(15, 16);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(65, 24);
            this.High.TabIndex = 11;
            this.High.TabStop = true;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            // 
            // CategoryChecklist
            // 
            this.CategoryChecklist.Controls.Add(this.Other);
            this.CategoryChecklist.Controls.Add(this.Project);
            this.CategoryChecklist.Controls.Add(this.Study);
            this.CategoryChecklist.Controls.Add(this.Fitness);
            this.CategoryChecklist.Controls.Add(this.School);
            this.CategoryChecklist.Location = new System.Drawing.Point(41, 289);
            this.CategoryChecklist.Name = "CategoryChecklist";
            this.CategoryChecklist.Size = new System.Drawing.Size(146, 168);
            this.CategoryChecklist.TabIndex = 12;
            this.CategoryChecklist.TabStop = false;
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(15, 132);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(72, 24);
            this.Other.TabIndex = 15;
            this.Other.TabStop = true;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Location = new System.Drawing.Point(15, 102);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(83, 24);
            this.Project.TabIndex = 14;
            this.Project.TabStop = true;
            this.Project.Text = "Project";
            this.Project.UseVisualStyleBackColor = true;
            // 
            // Study
            // 
            this.Study.AutoSize = true;
            this.Study.Location = new System.Drawing.Point(15, 76);
            this.Study.Name = "Study";
            this.Study.Size = new System.Drawing.Size(72, 24);
            this.Study.TabIndex = 13;
            this.Study.TabStop = true;
            this.Study.Text = "Study";
            this.Study.UseVisualStyleBackColor = true;
            // 
            // Fitness
            // 
            this.Fitness.AutoSize = true;
            this.Fitness.Location = new System.Drawing.Point(15, 46);
            this.Fitness.Name = "Fitness";
            this.Fitness.Size = new System.Drawing.Size(85, 24);
            this.Fitness.TabIndex = 12;
            this.Fitness.TabStop = true;
            this.Fitness.Text = "Fitness";
            this.Fitness.UseVisualStyleBackColor = true;
            // 
            // School
            // 
            this.School.AutoSize = true;
            this.School.Location = new System.Drawing.Point(15, 16);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(81, 24);
            this.School.TabIndex = 11;
            this.School.TabStop = true;
            this.School.Text = "School";
            this.School.UseVisualStyleBackColor = true;
            // 
            // Dayslbl
            // 
            this.Dayslbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dayslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dayslbl.Location = new System.Drawing.Point(181, 203);
            this.Dayslbl.Name = "Dayslbl";
            this.Dayslbl.Size = new System.Drawing.Size(85, 45);
            this.Dayslbl.TabIndex = 9;
            this.Dayslbl.Text = "days";
            this.Dayslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskFilterbtn
            // 
            this.TaskFilterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TaskFilterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskFilterbtn.Location = new System.Drawing.Point(4, 463);
            this.TaskFilterbtn.Name = "TaskFilterbtn";
            this.TaskFilterbtn.Size = new System.Drawing.Size(146, 48);
            this.TaskFilterbtn.TabIndex = 4;
            this.TaskFilterbtn.Text = "Filter Tasks";
            this.TaskFilterbtn.UseVisualStyleBackColor = false;
            this.TaskFilterbtn.Click += new System.EventHandler(this.TaskFilterbtn_Click);
            // 
            // Categorylbl
            // 
            this.Categorylbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(-1, 248);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(243, 45);
            this.Categorylbl.TabIndex = 7;
            this.Categorylbl.Text = "Category: ";
            this.Categorylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterDayInput
            // 
            this.FilterDayInput.Location = new System.Drawing.Point(124, 217);
            this.FilterDayInput.Name = "FilterDayInput";
            this.FilterDayInput.Size = new System.Drawing.Size(48, 26);
            this.FilterDayInput.TabIndex = 6;
            // 
            // DueDatelbl
            // 
            this.DueDatelbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.DueDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDatelbl.Location = new System.Drawing.Point(6, 203);
            this.DueDatelbl.Name = "DueDatelbl";
            this.DueDatelbl.Size = new System.Drawing.Size(112, 45);
            this.DueDatelbl.TabIndex = 5;
            this.DueDatelbl.Text = "Due <";
            this.DueDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Urgencylbl
            // 
            this.Urgencylbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Urgencylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urgencylbl.Location = new System.Drawing.Point(-2, 22);
            this.Urgencylbl.Name = "Urgencylbl";
            this.Urgencylbl.Size = new System.Drawing.Size(243, 45);
            this.Urgencylbl.TabIndex = 3;
            this.Urgencylbl.Text = "Urgency: ";
            this.Urgencylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidebarDatelbl
            // 
            this.SidebarDatelbl.AutoSize = true;
            this.SidebarDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarDatelbl.Location = new System.Drawing.Point(11, 62);
            this.SidebarDatelbl.Name = "SidebarDatelbl";
            this.SidebarDatelbl.Size = new System.Drawing.Size(114, 18);
            this.SidebarDatelbl.TabIndex = 1;
            this.SidebarDatelbl.Text = "Current Date: ";
            // 
            // SidebarUsernamelbl
            // 
            this.SidebarUsernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarUsernamelbl.Location = new System.Drawing.Point(-1, 17);
            this.SidebarUsernamelbl.Name = "SidebarUsernamelbl";
            this.SidebarUsernamelbl.Size = new System.Drawing.Size(243, 45);
            this.SidebarUsernamelbl.TabIndex = 0;
            this.SidebarUsernamelbl.Text = "Username";
            this.SidebarUsernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskViewPanel
            // 
            this.TaskViewPanel.AutoScroll = true;
            this.TaskViewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TaskViewPanel.Location = new System.Drawing.Point(284, 63);
            this.TaskViewPanel.Name = "TaskViewPanel";
            this.TaskViewPanel.Size = new System.Drawing.Size(775, 538);
            this.TaskViewPanel.TabIndex = 7;
            // 
            // DeleteClusterbtn
            // 
            this.DeleteClusterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteClusterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClusterbtn.Location = new System.Drawing.Point(589, 616);
            this.DeleteClusterbtn.Name = "DeleteClusterbtn";
            this.DeleteClusterbtn.Size = new System.Drawing.Size(139, 48);
            this.DeleteClusterbtn.TabIndex = 5;
            this.DeleteClusterbtn.Text = "Delete Cluster";
            this.DeleteClusterbtn.UseVisualStyleBackColor = false;
            this.DeleteClusterbtn.Click += new System.EventHandler(this.DeleteClusterbtn_Click);
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.DeleteClusterbtn);
            this.Controls.Add(this.TaskViewPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Controls.Add(this.Clusterlbl);
            this.Name = "TaskView";
            this.Size = new System.Drawing.Size(1076, 678);
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.SidebarFilterGroup.ResumeLayout(false);
            this.SidebarFilterGroup.PerformLayout();
            this.UrgencyChecklist.ResumeLayout(false);
            this.UrgencyChecklist.PerformLayout();
            this.CategoryChecklist.ResumeLayout(false);
            this.CategoryChecklist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Clusterlbl;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Button CreateTaskbtn;
        private System.Windows.Forms.GroupBox SidebarFilterGroup;
        private System.Windows.Forms.Label Dayslbl;
        private System.Windows.Forms.Button TaskFilterbtn;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.TextBox FilterDayInput;
        private System.Windows.Forms.Label DueDatelbl;
        private System.Windows.Forms.Label Urgencylbl;
        private System.Windows.Forms.Label SidebarDatelbl;
        private System.Windows.Forms.Label SidebarUsernamelbl;
        internal System.Windows.Forms.FlowLayoutPanel TaskViewPanel;
        private System.Windows.Forms.Button BackToClusterViewbtn;
        private System.Windows.Forms.Button DeleteClusterbtn;
        private System.Windows.Forms.RadioButton School;
        private System.Windows.Forms.GroupBox CategoryChecklist;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.RadioButton Project;
        private System.Windows.Forms.RadioButton Study;
        private System.Windows.Forms.RadioButton Fitness;
        private System.Windows.Forms.GroupBox UrgencyChecklist;
        private System.Windows.Forms.RadioButton Low;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton High;
        private System.Windows.Forms.Button ShowAllTasksbtn;
    }
}
