namespace EasyTestApp.Student
{
    partial class Student_CheckResults
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
            this.seeResultsNextButton = new System.Windows.Forms.Button();
            this.examListDropdown = new System.Windows.Forms.ComboBox();
            this.chooseExamTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seeResultsNextButton
            // 
            this.seeResultsNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.seeResultsNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seeResultsNextButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.seeResultsNextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.seeResultsNextButton.Location = new System.Drawing.Point(246, 256);
            this.seeResultsNextButton.Name = "seeResultsNextButton";
            this.seeResultsNextButton.Size = new System.Drawing.Size(116, 35);
            this.seeResultsNextButton.TabIndex = 9;
            this.seeResultsNextButton.Text = "See Results";
            this.seeResultsNextButton.UseVisualStyleBackColor = false;
            // 
            // examListDropdown
            // 
            this.examListDropdown.FormattingEnabled = true;
            this.examListDropdown.Location = new System.Drawing.Point(124, 198);
            this.examListDropdown.Name = "examListDropdown";
            this.examListDropdown.Size = new System.Drawing.Size(399, 21);
            this.examListDropdown.TabIndex = 8;
            // 
            // chooseExamTitleLabel
            // 
            this.chooseExamTitleLabel.AutoSize = true;
            this.chooseExamTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.chooseExamTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.chooseExamTitleLabel.Location = new System.Drawing.Point(222, 136);
            this.chooseExamTitleLabel.Name = "chooseExamTitleLabel";
            this.chooseExamTitleLabel.Size = new System.Drawing.Size(180, 17);
            this.chooseExamTitleLabel.TabIndex = 7;
            this.chooseExamTitleLabel.Text = "Please choose the exam:";
            // 
            // Student_CheckResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.seeResultsNextButton);
            this.Controls.Add(this.examListDropdown);
            this.Controls.Add(this.chooseExamTitleLabel);
            this.Name = "Student_CheckResults";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seeResultsNextButton;
        private System.Windows.Forms.ComboBox examListDropdown;
        private System.Windows.Forms.Label chooseExamTitleLabel;
    }
}
