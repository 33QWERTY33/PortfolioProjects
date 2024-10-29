namespace ToDoApp
{
    partial class TaskOverviewBox
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
            this.ViewTaskDetailsbtn = new System.Windows.Forms.Button();
            this.TaskCategorylbl = new System.Windows.Forms.Label();
            this.TaskDueDatelbl = new System.Windows.Forms.Label();
            this.TaskUrgencylbl = new System.Windows.Forms.Label();
            this.TaskTitlelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewTaskDetailsbtn
            // 
            this.ViewTaskDetailsbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ViewTaskDetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTaskDetailsbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ViewTaskDetailsbtn.Location = new System.Drawing.Point(638, 26);
            this.ViewTaskDetailsbtn.Name = "ViewTaskDetailsbtn";
            this.ViewTaskDetailsbtn.Size = new System.Drawing.Size(98, 42);
            this.ViewTaskDetailsbtn.TabIndex = 9;
            this.ViewTaskDetailsbtn.Text = "View";
            this.ViewTaskDetailsbtn.UseVisualStyleBackColor = false;
            this.ViewTaskDetailsbtn.Click += new System.EventHandler(this.ViewTaskDetailsbtn_Click);
            // 
            // TaskCategorylbl
            // 
            this.TaskCategorylbl.AutoSize = true;
            this.TaskCategorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskCategorylbl.Location = new System.Drawing.Point(275, 40);
            this.TaskCategorylbl.Name = "TaskCategorylbl";
            this.TaskCategorylbl.Size = new System.Drawing.Size(86, 20);
            this.TaskCategorylbl.TabIndex = 8;
            this.TaskCategorylbl.Text = "Category: ";
            // 
            // TaskDueDatelbl
            // 
            this.TaskDueDatelbl.AutoSize = true;
            this.TaskDueDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDueDatelbl.Location = new System.Drawing.Point(507, 3);
            this.TaskDueDatelbl.Name = "TaskDueDatelbl";
            this.TaskDueDatelbl.Size = new System.Drawing.Size(76, 17);
            this.TaskDueDatelbl.TabIndex = 7;
            this.TaskDueDatelbl.Text = "Due Date: ";
            // 
            // TaskUrgencylbl
            // 
            this.TaskUrgencylbl.AutoSize = true;
            this.TaskUrgencylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskUrgencylbl.Location = new System.Drawing.Point(14, 40);
            this.TaskUrgencylbl.Name = "TaskUrgencylbl";
            this.TaskUrgencylbl.Size = new System.Drawing.Size(81, 20);
            this.TaskUrgencylbl.TabIndex = 6;
            this.TaskUrgencylbl.Text = "Urgency: ";
            // 
            // TaskTitlelbl
            // 
            this.TaskTitlelbl.AutoSize = true;
            this.TaskTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTitlelbl.Location = new System.Drawing.Point(13, 3);
            this.TaskTitlelbl.Name = "TaskTitlelbl";
            this.TaskTitlelbl.Size = new System.Drawing.Size(50, 24);
            this.TaskTitlelbl.TabIndex = 5;
            this.TaskTitlelbl.Text = "Title";
            // 
            // TaskOverviewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ViewTaskDetailsbtn);
            this.Controls.Add(this.TaskCategorylbl);
            this.Controls.Add(this.TaskDueDatelbl);
            this.Controls.Add(this.TaskUrgencylbl);
            this.Controls.Add(this.TaskTitlelbl);
            this.Name = "TaskOverviewBox";
            this.Size = new System.Drawing.Size(744, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewTaskDetailsbtn;
        private System.Windows.Forms.Label TaskCategorylbl;
        private System.Windows.Forms.Label TaskDueDatelbl;
        private System.Windows.Forms.Label TaskUrgencylbl;
        private System.Windows.Forms.Label TaskTitlelbl;
    }
}
