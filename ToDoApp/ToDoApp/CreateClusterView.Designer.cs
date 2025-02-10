namespace ToDoApp
{
    partial class CreateClusterView
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
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Urgencylbl = new System.Windows.Forms.Label();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.DueDatelbl = new System.Windows.Forms.Label();
            this.CreateClusterbtn = new System.Windows.Forms.Button();
            this.GeneralFormGroup = new System.Windows.Forms.GroupBox();
            this.DateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.CategoryInput = new System.Windows.Forms.ComboBox();
            this.UrgencyInput = new System.Windows.Forms.ComboBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.GeneralFormGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clusterlbl
            // 
            this.Clusterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clusterlbl.Location = new System.Drawing.Point(300, 27);
            this.Clusterlbl.Name = "Clusterlbl";
            this.Clusterlbl.Size = new System.Drawing.Size(435, 45);
            this.Clusterlbl.TabIndex = 5;
            this.Clusterlbl.Text = "Create Cluster";
            this.Clusterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Urgencylbl
            // 
            this.Urgencylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urgencylbl.Location = new System.Drawing.Point(47, 69);
            this.Urgencylbl.Name = "Urgencylbl";
            this.Urgencylbl.Size = new System.Drawing.Size(188, 39);
            this.Urgencylbl.TabIndex = 9;
            this.Urgencylbl.Text = "Urgency: ";
            // 
            // Categorylbl
            // 
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(47, 131);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(188, 39);
            this.Categorylbl.TabIndex = 10;
            this.Categorylbl.Text = "Category: ";
            // 
            // DueDatelbl
            // 
            this.DueDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDatelbl.Location = new System.Drawing.Point(47, 195);
            this.DueDatelbl.Name = "DueDatelbl";
            this.DueDatelbl.Size = new System.Drawing.Size(188, 39);
            this.DueDatelbl.TabIndex = 11;
            this.DueDatelbl.Text = "Due Date: ";
            // 
            // CreateClusterbtn
            // 
            this.CreateClusterbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateClusterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClusterbtn.Location = new System.Drawing.Point(388, 620);
            this.CreateClusterbtn.Name = "CreateClusterbtn";
            this.CreateClusterbtn.Size = new System.Drawing.Size(205, 45);
            this.CreateClusterbtn.TabIndex = 12;
            this.CreateClusterbtn.Text = "Create Cluster";
            this.CreateClusterbtn.UseVisualStyleBackColor = false;
            this.CreateClusterbtn.Click += new System.EventHandler(this.CreateClusterbtn_Click);
            // 
            // GeneralFormGroup
            // 
            this.GeneralFormGroup.Controls.Add(this.DateTimeInput);
            this.GeneralFormGroup.Controls.Add(this.CategoryInput);
            this.GeneralFormGroup.Controls.Add(this.UrgencyInput);
            this.GeneralFormGroup.Controls.Add(this.TitleInput);
            this.GeneralFormGroup.Controls.Add(this.DueDatelbl);
            this.GeneralFormGroup.Controls.Add(this.Categorylbl);
            this.GeneralFormGroup.Controls.Add(this.Urgencylbl);
            this.GeneralFormGroup.Controls.Add(this.Titlelbl);
            this.GeneralFormGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralFormGroup.Location = new System.Drawing.Point(130, 126);
            this.GeneralFormGroup.Name = "GeneralFormGroup";
            this.GeneralFormGroup.Size = new System.Drawing.Size(760, 271);
            this.GeneralFormGroup.TabIndex = 13;
            this.GeneralFormGroup.TabStop = false;
            // 
            // DateTimeInput
            // 
            this.DateTimeInput.Location = new System.Drawing.Point(258, 208);
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
            this.CategoryInput.Location = new System.Drawing.Point(258, 146);
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
            this.UrgencyInput.Location = new System.Drawing.Point(259, 84);
            this.UrgencyInput.Name = "UrgencyInput";
            this.UrgencyInput.Size = new System.Drawing.Size(377, 24);
            this.UrgencyInput.TabIndex = 15;
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(259, 21);
            this.TitleInput.MaxLength = 40;
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(376, 22);
            this.TitleInput.TabIndex = 12;
            // 
            // CreateClusterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.GeneralFormGroup);
            this.Controls.Add(this.CreateClusterbtn);
            this.Controls.Add(this.Clusterlbl);
            this.Name = "CreateClusterView";
            this.Size = new System.Drawing.Size(1108, 677);
            this.GeneralFormGroup.ResumeLayout(false);
            this.GeneralFormGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Clusterlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Urgencylbl;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.Label DueDatelbl;
        private System.Windows.Forms.Button CreateClusterbtn;
        private System.Windows.Forms.GroupBox GeneralFormGroup;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.DateTimePicker DateTimeInput;
        private System.Windows.Forms.ComboBox CategoryInput;
        private System.Windows.Forms.ComboBox UrgencyInput;
    }
}
