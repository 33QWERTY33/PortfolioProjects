namespace ToDoApp
{
    partial class TaskDetailsView
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
            this.UpdateTaskbtn = new System.Windows.Forms.Button();
            this.CategoryDisplaylbl = new System.Windows.Forms.Label();
            this.DueDateDisplaylbl = new System.Windows.Forms.Label();
            this.UrgencyDisplaylbl = new System.Windows.Forms.Label();
            this.Detailslbl = new System.Windows.Forms.Label();
            this.CreateClusterbtn = new System.Windows.Forms.Button();
            this.SidebarDatelbl = new System.Windows.Forms.Label();
            this.SidebarUsernamelbl = new System.Windows.Forms.Label();
            this.TaskDetailsTitlelbl = new System.Windows.Forms.Label();
            this.TaskContentslbl = new System.Windows.Forms.Label();
            this.TaskNoteslbl = new System.Windows.Forms.Label();
            this.CompleteTaskbtn = new System.Windows.Forms.Button();
            this.TaskContentsBox = new System.Windows.Forms.TextBox();
            this.TaskNotesBox = new System.Windows.Forms.TextBox();
            this.SidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidebarPanel.Controls.Add(this.UpdateTaskbtn);
            this.SidebarPanel.Controls.Add(this.CategoryDisplaylbl);
            this.SidebarPanel.Controls.Add(this.DueDateDisplaylbl);
            this.SidebarPanel.Controls.Add(this.UrgencyDisplaylbl);
            this.SidebarPanel.Controls.Add(this.Detailslbl);
            this.SidebarPanel.Controls.Add(this.CreateClusterbtn);
            this.SidebarPanel.Controls.Add(this.SidebarDatelbl);
            this.SidebarPanel.Controls.Add(this.SidebarUsernamelbl);
            this.SidebarPanel.Location = new System.Drawing.Point(3, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(238, 676);
            this.SidebarPanel.TabIndex = 1;
            // 
            // UpdateTaskbtn
            // 
            this.UpdateTaskbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UpdateTaskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTaskbtn.Location = new System.Drawing.Point(4, 607);
            this.UpdateTaskbtn.Name = "UpdateTaskbtn";
            this.UpdateTaskbtn.Size = new System.Drawing.Size(122, 48);
            this.UpdateTaskbtn.TabIndex = 9;
            this.UpdateTaskbtn.Text = "Update Task";
            this.UpdateTaskbtn.UseVisualStyleBackColor = false;
            this.UpdateTaskbtn.Click += new System.EventHandler(this.UpdateTaskbtn_Click);
            // 
            // CategoryDisplaylbl
            // 
            this.CategoryDisplaylbl.AutoSize = true;
            this.CategoryDisplaylbl.Location = new System.Drawing.Point(7, 279);
            this.CategoryDisplaylbl.Name = "CategoryDisplaylbl";
            this.CategoryDisplaylbl.Size = new System.Drawing.Size(68, 16);
            this.CategoryDisplaylbl.TabIndex = 8;
            this.CategoryDisplaylbl.Text = "Category: ";
            // 
            // DueDateDisplaylbl
            // 
            this.DueDateDisplaylbl.AutoSize = true;
            this.DueDateDisplaylbl.Location = new System.Drawing.Point(7, 226);
            this.DueDateDisplaylbl.Name = "DueDateDisplaylbl";
            this.DueDateDisplaylbl.Size = new System.Drawing.Size(38, 16);
            this.DueDateDisplaylbl.TabIndex = 7;
            this.DueDateDisplaylbl.Text = "Due: ";
            // 
            // UrgencyDisplaylbl
            // 
            this.UrgencyDisplaylbl.AutoSize = true;
            this.UrgencyDisplaylbl.Location = new System.Drawing.Point(7, 190);
            this.UrgencyDisplaylbl.Name = "UrgencyDisplaylbl";
            this.UrgencyDisplaylbl.Size = new System.Drawing.Size(64, 16);
            this.UrgencyDisplaylbl.TabIndex = 6;
            this.UrgencyDisplaylbl.Text = "Urgency: ";
            // 
            // Detailslbl
            // 
            this.Detailslbl.AutoSize = true;
            this.Detailslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detailslbl.Location = new System.Drawing.Point(3, 122);
            this.Detailslbl.Name = "Detailslbl";
            this.Detailslbl.Size = new System.Drawing.Size(84, 24);
            this.Detailslbl.TabIndex = 5;
            this.Detailslbl.Text = "Details: ";
            // 
            // CreateClusterbtn
            // 
            this.CreateClusterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CreateClusterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClusterbtn.Location = new System.Drawing.Point(142, 607);
            this.CreateClusterbtn.Name = "CreateClusterbtn";
            this.CreateClusterbtn.Size = new System.Drawing.Size(74, 48);
            this.CreateClusterbtn.TabIndex = 3;
            this.CreateClusterbtn.Text = "Back";
            this.CreateClusterbtn.UseVisualStyleBackColor = false;
            this.CreateClusterbtn.Click += new System.EventHandler(this.CreateClusterbtn_Click);
            // 
            // SidebarDatelbl
            // 
            this.SidebarDatelbl.AutoSize = true;
            this.SidebarDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarDatelbl.Location = new System.Drawing.Point(21, 62);
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
            this.SidebarUsernamelbl.Size = new System.Drawing.Size(217, 45);
            this.SidebarUsernamelbl.TabIndex = 0;
            this.SidebarUsernamelbl.Text = "Username";
            this.SidebarUsernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskDetailsTitlelbl
            // 
            this.TaskDetailsTitlelbl.AutoSize = true;
            this.TaskDetailsTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDetailsTitlelbl.Location = new System.Drawing.Point(258, 11);
            this.TaskDetailsTitlelbl.Name = "TaskDetailsTitlelbl";
            this.TaskDetailsTitlelbl.Size = new System.Drawing.Size(200, 39);
            this.TaskDetailsTitlelbl.TabIndex = 2;
            this.TaskDetailsTitlelbl.Text = "Task Name";
            // 
            // TaskContentslbl
            // 
            this.TaskContentslbl.AutoSize = true;
            this.TaskContentslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskContentslbl.Location = new System.Drawing.Point(373, 63);
            this.TaskContentslbl.Name = "TaskContentslbl";
            this.TaskContentslbl.Size = new System.Drawing.Size(142, 36);
            this.TaskContentslbl.TabIndex = 3;
            this.TaskContentslbl.Text = "Contents";
            // 
            // TaskNoteslbl
            // 
            this.TaskNoteslbl.AutoSize = true;
            this.TaskNoteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNoteslbl.Location = new System.Drawing.Point(804, 63);
            this.TaskNoteslbl.Name = "TaskNoteslbl";
            this.TaskNoteslbl.Size = new System.Drawing.Size(98, 36);
            this.TaskNoteslbl.TabIndex = 4;
            this.TaskNoteslbl.Text = "Notes";
            // 
            // CompleteTaskbtn
            // 
            this.CompleteTaskbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompleteTaskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteTaskbtn.Location = new System.Drawing.Point(579, 611);
            this.CompleteTaskbtn.Name = "CompleteTaskbtn";
            this.CompleteTaskbtn.Size = new System.Drawing.Size(205, 45);
            this.CompleteTaskbtn.TabIndex = 13;
            this.CompleteTaskbtn.Text = "Complete Task";
            this.CompleteTaskbtn.UseVisualStyleBackColor = false;
            this.CompleteTaskbtn.Click += new System.EventHandler(this.CompleteTaskbtn_Click);
            // 
            // TaskContentsBox
            // 
            this.TaskContentsBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TaskContentsBox.Enabled = false;
            this.TaskContentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskContentsBox.Location = new System.Drawing.Point(247, 102);
            this.TaskContentsBox.Multiline = true;
            this.TaskContentsBox.Name = "TaskContentsBox";
            this.TaskContentsBox.ReadOnly = true;
            this.TaskContentsBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TaskContentsBox.Size = new System.Drawing.Size(418, 488);
            this.TaskContentsBox.TabIndex = 14;
            // 
            // TaskNotesBox
            // 
            this.TaskNotesBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TaskNotesBox.Enabled = false;
            this.TaskNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNotesBox.Location = new System.Drawing.Point(697, 102);
            this.TaskNotesBox.Multiline = true;
            this.TaskNotesBox.Name = "TaskNotesBox";
            this.TaskNotesBox.ReadOnly = true;
            this.TaskNotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TaskNotesBox.Size = new System.Drawing.Size(374, 488);
            this.TaskNotesBox.TabIndex = 15;
            // 
            // TaskDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.TaskNotesBox);
            this.Controls.Add(this.TaskContentsBox);
            this.Controls.Add(this.CompleteTaskbtn);
            this.Controls.Add(this.TaskNoteslbl);
            this.Controls.Add(this.TaskContentslbl);
            this.Controls.Add(this.TaskDetailsTitlelbl);
            this.Controls.Add(this.SidebarPanel);
            this.Name = "TaskDetailsView";
            this.Size = new System.Drawing.Size(1108, 677);
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Button CreateClusterbtn;
        internal System.Windows.Forms.Label SidebarDatelbl;
        internal System.Windows.Forms.Label SidebarUsernamelbl;
        internal System.Windows.Forms.Label CategoryDisplaylbl;
        internal System.Windows.Forms.Label DueDateDisplaylbl;
        internal System.Windows.Forms.Label UrgencyDisplaylbl;
        private System.Windows.Forms.Label Detailslbl;
        internal System.Windows.Forms.Label TaskDetailsTitlelbl;
        private System.Windows.Forms.Label TaskContentslbl;
        private System.Windows.Forms.Label TaskNoteslbl;
        private System.Windows.Forms.Button UpdateTaskbtn;
        private System.Windows.Forms.Button CompleteTaskbtn;
        internal System.Windows.Forms.TextBox TaskContentsBox;
        internal System.Windows.Forms.TextBox TaskNotesBox;
    }
}
