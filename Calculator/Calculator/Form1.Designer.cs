namespace Calculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.cmdClr = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdOne = new System.Windows.Forms.Button();
            this.cmdTwo = new System.Windows.Forms.Button();
            this.cmdThree = new System.Windows.Forms.Button();
            this.cmdSub = new System.Windows.Forms.Button();
            this.cmdMul = new System.Windows.Forms.Button();
            this.cmdSix = new System.Windows.Forms.Button();
            this.cmdFive = new System.Windows.Forms.Button();
            this.cmdFour = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.cmdNine = new System.Windows.Forms.Button();
            this.cmdEight = new System.Windows.Forms.Button();
            this.cmdSeven = new System.Windows.Forms.Button();
            this.cmdZero = new System.Windows.Forms.Button();
            this.cmdEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 25);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDisplay.Size = new System.Drawing.Size(419, 65);
            this.lblDisplay.TabIndex = 0;
            // 
            // cmdClr
            // 
            this.cmdClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClr.Location = new System.Drawing.Point(12, 106);
            this.cmdClr.Name = "cmdClr";
            this.cmdClr.Size = new System.Drawing.Size(314, 62);
            this.cmdClr.TabIndex = 1;
            this.cmdClr.Text = "CLEAR";
            this.cmdClr.UseVisualStyleBackColor = true;
            this.cmdClr.Click += new System.EventHandler(this.cmdClr_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(341, 106);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(90, 62);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Tag = "";
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdOne
            // 
            this.cmdOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOne.Location = new System.Drawing.Point(12, 188);
            this.cmdOne.Name = "cmdOne";
            this.cmdOne.Size = new System.Drawing.Size(90, 62);
            this.cmdOne.TabIndex = 3;
            this.cmdOne.Text = "1";
            this.cmdOne.UseVisualStyleBackColor = true;
            this.cmdOne.Click += new System.EventHandler(this.cmdOne_Click);
            // 
            // cmdTwo
            // 
            this.cmdTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTwo.Location = new System.Drawing.Point(125, 188);
            this.cmdTwo.Name = "cmdTwo";
            this.cmdTwo.Size = new System.Drawing.Size(90, 62);
            this.cmdTwo.TabIndex = 4;
            this.cmdTwo.Text = "2";
            this.cmdTwo.UseVisualStyleBackColor = true;
            this.cmdTwo.Click += new System.EventHandler(this.cmdTwo_Click);
            // 
            // cmdThree
            // 
            this.cmdThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThree.Location = new System.Drawing.Point(236, 188);
            this.cmdThree.Name = "cmdThree";
            this.cmdThree.Size = new System.Drawing.Size(90, 62);
            this.cmdThree.TabIndex = 5;
            this.cmdThree.Text = "3";
            this.cmdThree.UseVisualStyleBackColor = true;
            this.cmdThree.Click += new System.EventHandler(this.cmdThree_Click);
            // 
            // cmdSub
            // 
            this.cmdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSub.Location = new System.Drawing.Point(341, 188);
            this.cmdSub.Name = "cmdSub";
            this.cmdSub.Size = new System.Drawing.Size(90, 62);
            this.cmdSub.TabIndex = 6;
            this.cmdSub.Text = "-";
            this.cmdSub.UseVisualStyleBackColor = true;
            this.cmdSub.Click += new System.EventHandler(this.cmdSub_Click);
            // 
            // cmdMul
            // 
            this.cmdMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMul.Location = new System.Drawing.Point(341, 272);
            this.cmdMul.Name = "cmdMul";
            this.cmdMul.Size = new System.Drawing.Size(90, 62);
            this.cmdMul.TabIndex = 10;
            this.cmdMul.Text = "*";
            this.cmdMul.UseVisualStyleBackColor = true;
            this.cmdMul.Click += new System.EventHandler(this.cmdMul_Click);
            // 
            // cmdSix
            // 
            this.cmdSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSix.Location = new System.Drawing.Point(236, 272);
            this.cmdSix.Name = "cmdSix";
            this.cmdSix.Size = new System.Drawing.Size(90, 62);
            this.cmdSix.TabIndex = 9;
            this.cmdSix.Text = "6";
            this.cmdSix.UseVisualStyleBackColor = true;
            this.cmdSix.Click += new System.EventHandler(this.cmdSix_Click);
            // 
            // cmdFive
            // 
            this.cmdFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFive.Location = new System.Drawing.Point(125, 272);
            this.cmdFive.Name = "cmdFive";
            this.cmdFive.Size = new System.Drawing.Size(90, 62);
            this.cmdFive.TabIndex = 8;
            this.cmdFive.Text = "5";
            this.cmdFive.UseVisualStyleBackColor = true;
            this.cmdFive.Click += new System.EventHandler(this.cmdFive_Click);
            // 
            // cmdFour
            // 
            this.cmdFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFour.Location = new System.Drawing.Point(12, 272);
            this.cmdFour.Name = "cmdFour";
            this.cmdFour.Size = new System.Drawing.Size(90, 62);
            this.cmdFour.TabIndex = 7;
            this.cmdFour.Text = "4";
            this.cmdFour.UseVisualStyleBackColor = true;
            this.cmdFour.Click += new System.EventHandler(this.cmdFour_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiv.Location = new System.Drawing.Point(341, 357);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(90, 62);
            this.cmdDiv.TabIndex = 14;
            this.cmdDiv.Text = "/";
            this.cmdDiv.UseVisualStyleBackColor = true;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // cmdNine
            // 
            this.cmdNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNine.Location = new System.Drawing.Point(236, 357);
            this.cmdNine.Name = "cmdNine";
            this.cmdNine.Size = new System.Drawing.Size(90, 62);
            this.cmdNine.TabIndex = 13;
            this.cmdNine.Text = "9";
            this.cmdNine.UseVisualStyleBackColor = true;
            this.cmdNine.Click += new System.EventHandler(this.cmdNine_Click);
            // 
            // cmdEight
            // 
            this.cmdEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEight.Location = new System.Drawing.Point(125, 357);
            this.cmdEight.Name = "cmdEight";
            this.cmdEight.Size = new System.Drawing.Size(90, 62);
            this.cmdEight.TabIndex = 12;
            this.cmdEight.Text = "8";
            this.cmdEight.UseVisualStyleBackColor = true;
            this.cmdEight.Click += new System.EventHandler(this.cmdEight_Click);
            // 
            // cmdSeven
            // 
            this.cmdSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeven.Location = new System.Drawing.Point(12, 357);
            this.cmdSeven.Name = "cmdSeven";
            this.cmdSeven.Size = new System.Drawing.Size(90, 62);
            this.cmdSeven.TabIndex = 11;
            this.cmdSeven.Text = "7";
            this.cmdSeven.UseVisualStyleBackColor = true;
            this.cmdSeven.Click += new System.EventHandler(this.cmdSeven_Click);
            // 
            // cmdZero
            // 
            this.cmdZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZero.Location = new System.Drawing.Point(12, 438);
            this.cmdZero.Name = "cmdZero";
            this.cmdZero.Size = new System.Drawing.Size(90, 62);
            this.cmdZero.TabIndex = 15;
            this.cmdZero.Text = "0";
            this.cmdZero.UseVisualStyleBackColor = true;
            this.cmdZero.Click += new System.EventHandler(this.cmdZero_Click);
            // 
            // cmdEqual
            // 
            this.cmdEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEqual.Location = new System.Drawing.Point(125, 438);
            this.cmdEqual.Name = "cmdEqual";
            this.cmdEqual.Size = new System.Drawing.Size(306, 62);
            this.cmdEqual.TabIndex = 16;
            this.cmdEqual.Text = "EQUAL";
            this.cmdEqual.UseVisualStyleBackColor = true;
            this.cmdEqual.Click += new System.EventHandler(this.cmdEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(445, 530);
            this.Controls.Add(this.cmdEqual);
            this.Controls.Add(this.cmdZero);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdNine);
            this.Controls.Add(this.cmdEight);
            this.Controls.Add(this.cmdSeven);
            this.Controls.Add(this.cmdMul);
            this.Controls.Add(this.cmdSix);
            this.Controls.Add(this.cmdFive);
            this.Controls.Add(this.cmdFour);
            this.Controls.Add(this.cmdSub);
            this.Controls.Add(this.cmdThree);
            this.Controls.Add(this.cmdTwo);
            this.Controls.Add(this.cmdOne);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdClr);
            this.Controls.Add(this.lblDisplay);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button cmdClr;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdOne;
        private System.Windows.Forms.Button cmdTwo;
        private System.Windows.Forms.Button cmdThree;
        private System.Windows.Forms.Button cmdSub;
        private System.Windows.Forms.Button cmdMul;
        private System.Windows.Forms.Button cmdSix;
        private System.Windows.Forms.Button cmdFive;
        private System.Windows.Forms.Button cmdFour;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdNine;
        private System.Windows.Forms.Button cmdEight;
        private System.Windows.Forms.Button cmdSeven;
        private System.Windows.Forms.Button cmdZero;
        private System.Windows.Forms.Button cmdEqual;
    }
}

