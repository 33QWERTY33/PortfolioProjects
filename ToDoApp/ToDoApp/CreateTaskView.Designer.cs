namespace ToDoApp
{
    partial class CreateTaskView
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
            this.GeneralFormGroup = new System.Windows.Forms.GroupBox();
            this.DateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.CategoryInput = new System.Windows.Forms.ComboBox();
            this.UrgencyInput = new System.Windows.Forms.ComboBox();
            this.NotesInput = new System.Windows.Forms.TextBox();
            this.TaskInput = new System.Windows.Forms.TextBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.DueDatelbl = new System.Windows.Forms.Label();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.Urgencylbl = new System.Windows.Forms.Label();
            this.Noteslbl = new System.Windows.Forms.Label();
            this.Tasklbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.CreateTaskbtn = new System.Windows.Forms.Button();
            this.GeneralFormGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clusterlbl
            // 
            this.Clusterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clusterlbl.Location = new System.Drawing.Point(285, 24);
            this.Clusterlbl.Name = "Clusterlbl";
            this.Clusterlbl.Size = new System.Drawing.Size(435, 45);
            this.Clusterlbl.TabIndex = 6;
            this.Clusterlbl.Text = "Create Task";
            this.Clusterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralFormGroup
            // 
            this.GeneralFormGroup.Controls.Add(this.DateTimeInput);
            this.GeneralFormGroup.Controls.Add(this.CategoryInput);
            this.GeneralFormGroup.Controls.Add(this.UrgencyInput);
            this.GeneralFormGroup.Controls.Add(this.NotesInput);
            this.GeneralFormGroup.Controls.Add(this.TaskInput);
            this.GeneralFormGroup.Controls.Add(this.TitleInput);
            this.GeneralFormGroup.Controls.Add(this.DueDatelbl);
            this.GeneralFormGroup.Controls.Add(this.Categorylbl);
            this.GeneralFormGroup.Controls.Add(this.Urgencylbl);
            this.GeneralFormGroup.Controls.Add(this.Noteslbl);
            this.GeneralFormGroup.Controls.Add(this.Tasklbl);
            this.GeneralFormGroup.Controls.Add(this.Titlelbl);
            this.GeneralFormGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralFormGroup.Location = new System.Drawing.Point(123, 101);
            this.GeneralFormGroup.Name = "GeneralFormGroup";
            this.GeneralFormGroup.Size = new System.Drawing.Size(760, 470);
            this.GeneralFormGroup.TabIndex = 14;
            this.GeneralFormGroup.TabStop = false;
            // 
            // DateTimeInput
            // 
            this.DateTimeInput.Location = new System.Drawing.Point(258, 432);
            this.DateTimeInput.Name = "DateTimeInput";
            this.DateTimeInput.Size = new System.Drawing.Size(375, 22);
            this.DateTimeInput.TabIndex = 17;
            // 
            // CategoryInput
            // 
            this.CategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryInput.FormattingEnabled = true;
            this.CategoryInput.Items.AddRange(new object[] {
            "School",
            "Fitness",
            "Study",
            "Project",
            "Other"});
            this.CategoryInput.Location = new System.Drawing.Point(258, 370);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(377, 24);
            this.CategoryInput.TabIndex = 16;
            // 
            // UrgencyInput
            // 
            this.UrgencyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrgencyInput.FormattingEnabled = true;
            this.UrgencyInput.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.UrgencyInput.Location = new System.Drawing.Point(259, 308);
            this.UrgencyInput.Name = "UrgencyInput";
            this.UrgencyInput.Size = new System.Drawing.Size(377, 24);
            this.UrgencyInput.TabIndex = 15;
            // 
            // NotesInput
            // 
            this.NotesInput.Location = new System.Drawing.Point(259, 203);
            this.NotesInput.Multiline = true;
            this.NotesInput.Name = "NotesInput";
            this.NotesInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.NotesInput.Size = new System.Drawing.Size(376, 87);
            this.NotesInput.TabIndex = 14;
            // 
            // TaskInput
            // 
            this.TaskInput.Location = new System.Drawing.Point(259, 93);
            this.TaskInput.Multiline = true;
            this.TaskInput.Name = "TaskInput";
            this.TaskInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TaskInput.Size = new System.Drawing.Size(376, 87);
            this.TaskInput.TabIndex = 13;
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(259, 21);
            this.TitleInput.MaxLength = 40;
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(376, 22);
            this.TitleInput.TabIndex = 12;
            // 
            // DueDatelbl
            // 
            this.DueDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDatelbl.Location = new System.Drawing.Point(47, 419);
            this.DueDatelbl.Name = "DueDatelbl";
            this.DueDatelbl.Size = new System.Drawing.Size(188, 39);
            this.DueDatelbl.TabIndex = 11;
            this.DueDatelbl.Text = "Due Date: ";
            // 
            // Categorylbl
            // 
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(47, 355);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(188, 39);
            this.Categorylbl.TabIndex = 10;
            this.Categorylbl.Text = "Category: ";
            // 
            // Urgencylbl
            // 
            this.Urgencylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urgencylbl.Location = new System.Drawing.Point(47, 293);
            this.Urgencylbl.Name = "Urgencylbl";
            this.Urgencylbl.Size = new System.Drawing.Size(188, 39);
            this.Urgencylbl.TabIndex = 9;
            this.Urgencylbl.Text = "Urgency: ";
            // 
            // Noteslbl
            // 
            this.Noteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noteslbl.Location = new System.Drawing.Point(47, 188);
            this.Noteslbl.Name = "Noteslbl";
            this.Noteslbl.Size = new System.Drawing.Size(188, 39);
            this.Noteslbl.TabIndex = 8;
            this.Noteslbl.Text = "Notes: ";
            // 
            // Tasklbl
            // 
            this.Tasklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasklbl.Location = new System.Drawing.Point(47, 78);
            this.Tasklbl.Name = "Tasklbl";
            this.Tasklbl.Size = new System.Drawing.Size(188, 39);
            this.Tasklbl.TabIndex = 7;
            this.Tasklbl.Text = "Task: ";
            // 
            // Titlelbl
            // 
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(47, 6);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(188, 34);
            this.Titlelbl.TabIndex = 6;
            this.Titlelbl.Text = "Title: ";
            // 
            // CreateTaskbtn
            // 
            this.CreateTaskbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateTaskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskbtn.Location = new System.Drawing.Point(381, 611);
            this.CreateTaskbtn.Name = "CreateTaskbtn";
            this.CreateTaskbtn.Size = new System.Drawing.Size(205, 45);
            this.CreateTaskbtn.TabIndex = 15;
            this.CreateTaskbtn.Text = "Create Task";
            this.CreateTaskbtn.UseVisualStyleBackColor = false;
            this.CreateTaskbtn.Click += new System.EventHandler(this.CreateTaskbtn_Click);
            // 
            // CreateTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.CreateTaskbtn);
            this.Controls.Add(this.GeneralFormGroup);
            this.Controls.Add(this.Clusterlbl);
            this.Name = "CreateTaskView";
            this.Size = new System.Drawing.Size(1108, 677);
            this.GeneralFormGroup.ResumeLayout(false);
            this.GeneralFormGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Clusterlbl;
        private System.Windows.Forms.GroupBox GeneralFormGroup;
        internal System.Windows.Forms.DateTimePicker DateTimeInput;
        internal System.Windows.Forms.ComboBox CategoryInput;
        internal System.Windows.Forms.ComboBox UrgencyInput;
        internal System.Windows.Forms.TextBox NotesInput;
        internal System.Windows.Forms.TextBox TaskInput;
        internal System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Label DueDatelbl;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.Label Urgencylbl;
        private System.Windows.Forms.Label Noteslbl;
        private System.Windows.Forms.Label Tasklbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button CreateTaskbtn;
    }
}
