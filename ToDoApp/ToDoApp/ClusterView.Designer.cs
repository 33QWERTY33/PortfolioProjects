namespace ToDoApp
{
    partial class ClusterView
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
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.CreateClusterbtn = new System.Windows.Forms.Button();
            this.SidebarFilterGroup = new System.Windows.Forms.GroupBox();
            this.ShowAllClustersbtn = new System.Windows.Forms.Button();
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
            this.ClusterFilterbtn = new System.Windows.Forms.Button();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.FilterDayInput = new System.Windows.Forms.TextBox();
            this.DueDatelbl = new System.Windows.Forms.Label();
            this.Urgencylbl = new System.Windows.Forms.Label();
            this.SidebarDatelbl = new System.Windows.Forms.Label();
            this.SidebarUsernamelbl = new System.Windows.Forms.Label();
            this.ClusterViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Clusterlbl = new System.Windows.Forms.Label();
            this.SidebarPanel.SuspendLayout();
            this.SidebarFilterGroup.SuspendLayout();
            this.UrgencyChecklist.SuspendLayout();
            this.CategoryChecklist.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidebarPanel.Controls.Add(this.CreateClusterbtn);
            this.SidebarPanel.Controls.Add(this.SidebarFilterGroup);
            this.SidebarPanel.Controls.Add(this.SidebarDatelbl);
            this.SidebarPanel.Controls.Add(this.SidebarUsernamelbl);
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(279, 676);
            this.SidebarPanel.TabIndex = 0;
            // 
            // CreateClusterbtn
            // 
            this.CreateClusterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CreateClusterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClusterbtn.Location = new System.Drawing.Point(32, 606);
            this.CreateClusterbtn.Name = "CreateClusterbtn";
            this.CreateClusterbtn.Size = new System.Drawing.Size(165, 48);
            this.CreateClusterbtn.TabIndex = 3;
            this.CreateClusterbtn.Text = "Create New Cluster";
            this.CreateClusterbtn.UseVisualStyleBackColor = false;
            this.CreateClusterbtn.Click += new System.EventHandler(this.CreateClusterbtn_Click);
            // 
            // SidebarFilterGroup
            // 
            this.SidebarFilterGroup.Controls.Add(this.ShowAllClustersbtn);
            this.SidebarFilterGroup.Controls.Add(this.UrgencyChecklist);
            this.SidebarFilterGroup.Controls.Add(this.CategoryChecklist);
            this.SidebarFilterGroup.Controls.Add(this.Dayslbl);
            this.SidebarFilterGroup.Controls.Add(this.ClusterFilterbtn);
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
            // ShowAllClustersbtn
            // 
            this.ShowAllClustersbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ShowAllClustersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllClustersbtn.Location = new System.Drawing.Point(148, 463);
            this.ShowAllClustersbtn.Name = "ShowAllClustersbtn";
            this.ShowAllClustersbtn.Size = new System.Drawing.Size(105, 48);
            this.ShowAllClustersbtn.TabIndex = 18;
            this.ShowAllClustersbtn.Text = "Show All";
            this.ShowAllClustersbtn.UseVisualStyleBackColor = false;
            this.ShowAllClustersbtn.Click += new System.EventHandler(this.ShowAllClustersbtn_Click);
            // 
            // UrgencyChecklist
            // 
            this.UrgencyChecklist.Controls.Add(this.Low);
            this.UrgencyChecklist.Controls.Add(this.Medium);
            this.UrgencyChecklist.Controls.Add(this.High);
            this.UrgencyChecklist.Location = new System.Drawing.Point(49, 62);
            this.UrgencyChecklist.Name = "UrgencyChecklist";
            this.UrgencyChecklist.Size = new System.Drawing.Size(146, 117);
            this.UrgencyChecklist.TabIndex = 17;
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
            this.CategoryChecklist.Location = new System.Drawing.Point(49, 273);
            this.CategoryChecklist.Name = "CategoryChecklist";
            this.CategoryChecklist.Size = new System.Drawing.Size(146, 168);
            this.CategoryChecklist.TabIndex = 13;
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
            this.Dayslbl.Location = new System.Drawing.Point(181, 182);
            this.Dayslbl.Name = "Dayslbl";
            this.Dayslbl.Size = new System.Drawing.Size(85, 45);
            this.Dayslbl.TabIndex = 9;
            this.Dayslbl.Text = "days";
            this.Dayslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClusterFilterbtn
            // 
            this.ClusterFilterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClusterFilterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClusterFilterbtn.Location = new System.Drawing.Point(6, 463);
            this.ClusterFilterbtn.Name = "ClusterFilterbtn";
            this.ClusterFilterbtn.Size = new System.Drawing.Size(123, 48);
            this.ClusterFilterbtn.TabIndex = 4;
            this.ClusterFilterbtn.Text = "Filter Clusters";
            this.ClusterFilterbtn.UseVisualStyleBackColor = false;
            this.ClusterFilterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            // 
            // Categorylbl
            // 
            this.Categorylbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(6, 225);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(243, 45);
            this.Categorylbl.TabIndex = 7;
            this.Categorylbl.Text = "Category: ";
            this.Categorylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterDayInput
            // 
            this.FilterDayInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDayInput.Location = new System.Drawing.Point(126, 196);
            this.FilterDayInput.Name = "FilterDayInput";
            this.FilterDayInput.Size = new System.Drawing.Size(40, 38);
            this.FilterDayInput.TabIndex = 6;
            // 
            // DueDatelbl
            // 
            this.DueDatelbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.DueDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDatelbl.Location = new System.Drawing.Point(10, 182);
            this.DueDatelbl.Name = "DueDatelbl";
            this.DueDatelbl.Size = new System.Drawing.Size(119, 45);
            this.DueDatelbl.TabIndex = 5;
            this.DueDatelbl.Text = "Due <";
            this.DueDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Urgencylbl
            // 
            this.Urgencylbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Urgencylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urgencylbl.Location = new System.Drawing.Point(6, 22);
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
            this.SidebarDatelbl.Location = new System.Drawing.Point(29, 62);
            this.SidebarDatelbl.Name = "SidebarDatelbl";
            this.SidebarDatelbl.Size = new System.Drawing.Size(114, 18);
            this.SidebarDatelbl.TabIndex = 1;
            this.SidebarDatelbl.Text = "Current Date: ";
            // 
            // SidebarUsernamelbl
            // 
            this.SidebarUsernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarUsernamelbl.Location = new System.Drawing.Point(-1, 17);
            this.SidebarUsernamelbl.Name = "SidebarUsernamelbl";
            this.SidebarUsernamelbl.Size = new System.Drawing.Size(269, 45);
            this.SidebarUsernamelbl.TabIndex = 0;
            this.SidebarUsernamelbl.Text = "Username";
            this.SidebarUsernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClusterViewPanel
            // 
            this.ClusterViewPanel.AutoScroll = true;
            this.ClusterViewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClusterViewPanel.Location = new System.Drawing.Point(293, 85);
            this.ClusterViewPanel.Name = "ClusterViewPanel";
            this.ClusterViewPanel.Size = new System.Drawing.Size(743, 570);
            this.ClusterViewPanel.TabIndex = 1;
            // 
            // Clusterlbl
            // 
            this.Clusterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clusterlbl.Location = new System.Drawing.Point(514, 18);
            this.Clusterlbl.Name = "Clusterlbl";
            this.Clusterlbl.Size = new System.Drawing.Size(290, 45);
            this.Clusterlbl.TabIndex = 4;
            this.Clusterlbl.Text = "Cluster View";
            this.Clusterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClusterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Clusterlbl);
            this.Controls.Add(this.ClusterViewPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Name = "ClusterView";
            this.Size = new System.Drawing.Size(1050, 677);
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.SidebarFilterGroup.ResumeLayout(false);
            this.SidebarFilterGroup.PerformLayout();
            this.UrgencyChecklist.ResumeLayout(false);
            this.UrgencyChecklist.PerformLayout();
            this.CategoryChecklist.ResumeLayout(false);
            this.CategoryChecklist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Label SidebarUsernamelbl;
        private System.Windows.Forms.Label SidebarDatelbl;
        private System.Windows.Forms.GroupBox SidebarFilterGroup;
        private System.Windows.Forms.Label Urgencylbl;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.TextBox FilterDayInput;
        private System.Windows.Forms.Label DueDatelbl;
        private System.Windows.Forms.Button CreateClusterbtn;
        private System.Windows.Forms.Button ClusterFilterbtn;
        private System.Windows.Forms.Label Dayslbl;
        internal System.Windows.Forms.FlowLayoutPanel ClusterViewPanel;
        private System.Windows.Forms.Label Clusterlbl;
        private System.Windows.Forms.GroupBox CategoryChecklist;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.RadioButton Project;
        private System.Windows.Forms.RadioButton Study;
        private System.Windows.Forms.RadioButton Fitness;
        private System.Windows.Forms.RadioButton School;
        private System.Windows.Forms.GroupBox UrgencyChecklist;
        private System.Windows.Forms.RadioButton Low;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton High;
        private System.Windows.Forms.Button ShowAllClustersbtn;
    }
}
