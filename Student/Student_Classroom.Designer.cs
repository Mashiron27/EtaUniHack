namespace EasyTestApp.Student
{
    partial class Student_Classroom
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
            this.goToClassNextButton = new System.Windows.Forms.Button();
            this.examListDropdown = new System.Windows.Forms.ComboBox();
            this.chooseSubjectTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goToClassNextButton
            // 
            this.goToClassNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.goToClassNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goToClassNextButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.goToClassNextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.goToClassNextButton.Location = new System.Drawing.Point(240, 241);
            this.goToClassNextButton.Name = "goToClassNextButton";
            this.goToClassNextButton.Size = new System.Drawing.Size(116, 35);
            this.goToClassNextButton.TabIndex = 9;
            this.goToClassNextButton.Text = "Enter Class!";
            this.goToClassNextButton.UseVisualStyleBackColor = false;
            // 
            // examListDropdown
            // 
            this.examListDropdown.FormattingEnabled = true;
            this.examListDropdown.Location = new System.Drawing.Point(118, 183);
            this.examListDropdown.Name = "examListDropdown";
            this.examListDropdown.Size = new System.Drawing.Size(399, 21);
            this.examListDropdown.TabIndex = 8;
            // 
            // chooseSubjectTitleLabel
            // 
            this.chooseSubjectTitleLabel.AutoSize = true;
            this.chooseSubjectTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.chooseSubjectTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.chooseSubjectTitleLabel.Location = new System.Drawing.Point(216, 121);
            this.chooseSubjectTitleLabel.Name = "chooseSubjectTitleLabel";
            this.chooseSubjectTitleLabel.Size = new System.Drawing.Size(189, 17);
            this.chooseSubjectTitleLabel.TabIndex = 7;
            this.chooseSubjectTitleLabel.Text = "Please choose the subject:";
            // 
            // Student_Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.goToClassNextButton);
            this.Controls.Add(this.examListDropdown);
            this.Controls.Add(this.chooseSubjectTitleLabel);
            this.Name = "Student_Classroom";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToClassNextButton;
        private System.Windows.Forms.ComboBox examListDropdown;
        private System.Windows.Forms.Label chooseSubjectTitleLabel;
    }
}
