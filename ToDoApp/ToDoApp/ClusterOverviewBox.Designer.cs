namespace ToDoApp
{
    partial class ClusterOverviewBox
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
            this.ClusterTitlelbl = new System.Windows.Forms.Label();
            this.ClusterUrgencylbl = new System.Windows.Forms.Label();
            this.ClusterDueDatelbl = new System.Windows.Forms.Label();
            this.ClusterCategorylbl = new System.Windows.Forms.Label();
            this.ViewClusterDetailsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClusterTitlelbl
            // 
            this.ClusterTitlelbl.AutoSize = true;
            this.ClusterTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClusterTitlelbl.Location = new System.Drawing.Point(7, 4);
            this.ClusterTitlelbl.Name = "ClusterTitlelbl";
            this.ClusterTitlelbl.Size = new System.Drawing.Size(50, 24);
            this.ClusterTitlelbl.TabIndex = 0;
            this.ClusterTitlelbl.Text = "Title";
            // 
            // ClusterUrgencylbl
            // 
            this.ClusterUrgencylbl.AutoSize = true;
            this.ClusterUrgencylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClusterUrgencylbl.Location = new System.Drawing.Point(8, 41);
            this.ClusterUrgencylbl.Name = "ClusterUrgencylbl";
            this.ClusterUrgencylbl.Size = new System.Drawing.Size(81, 20);
            this.ClusterUrgencylbl.TabIndex = 1;
            this.ClusterUrgencylbl.Text = "Urgency: ";
            // 
            // ClusterDueDatelbl
            // 
            this.ClusterDueDatelbl.AutoSize = true;
            this.ClusterDueDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClusterDueDatelbl.Location = new System.Drawing.Point(499, 4);
            this.ClusterDueDatelbl.Name = "ClusterDueDatelbl";
            this.ClusterDueDatelbl.Size = new System.Drawing.Size(76, 17);
            this.ClusterDueDatelbl.TabIndex = 2;
            this.ClusterDueDatelbl.Text = "Due Date: ";
            // 
            // ClusterCategorylbl
            // 
            this.ClusterCategorylbl.AutoSize = true;
            this.ClusterCategorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClusterCategorylbl.Location = new System.Drawing.Point(317, 41);
            this.ClusterCategorylbl.Name = "ClusterCategorylbl";
            this.ClusterCategorylbl.Size = new System.Drawing.Size(86, 20);
            this.ClusterCategorylbl.TabIndex = 3;
            this.ClusterCategorylbl.Text = "Category: ";
            // 
            // ViewClusterDetailsbtn
            // 
            this.ViewClusterDetailsbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ViewClusterDetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewClusterDetailsbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ViewClusterDetailsbtn.Location = new System.Drawing.Point(620, 26);
            this.ViewClusterDetailsbtn.Name = "ViewClusterDetailsbtn";
            this.ViewClusterDetailsbtn.Size = new System.Drawing.Size(98, 42);
            this.ViewClusterDetailsbtn.TabIndex = 4;
            this.ViewClusterDetailsbtn.Text = "View";
            this.ViewClusterDetailsbtn.UseVisualStyleBackColor = false;
            this.ViewClusterDetailsbtn.Click += new System.EventHandler(this.ViewClusterDetailsbtn_Click);
            // 
            // ClusterOverviewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ViewClusterDetailsbtn);
            this.Controls.Add(this.ClusterCategorylbl);
            this.Controls.Add(this.ClusterDueDatelbl);
            this.Controls.Add(this.ClusterUrgencylbl);
            this.Controls.Add(this.ClusterTitlelbl);
            this.Name = "ClusterOverviewBox";
            this.Size = new System.Drawing.Size(734, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClusterTitlelbl;
        private System.Windows.Forms.Label ClusterUrgencylbl;
        private System.Windows.Forms.Label ClusterDueDatelbl;
        private System.Windows.Forms.Label ClusterCategorylbl;
        private System.Windows.Forms.Button ViewClusterDetailsbtn;
    }
}
