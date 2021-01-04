namespace EasyTestApp.Student
{
    partial class Student_ExamResults
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
            this.examResultsTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // examResultsTitleLabel
            // 
            this.examResultsTitleLabel.AutoSize = true;
            this.examResultsTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.examResultsTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.examResultsTitleLabel.Location = new System.Drawing.Point(237, 45);
            this.examResultsTitleLabel.Name = "examResultsTitleLabel";
            this.examResultsTitleLabel.Size = new System.Drawing.Size(99, 17);
            this.examResultsTitleLabel.TabIndex = 4;
            this.examResultsTitleLabel.Text = "Exam Results:";
            // 
            // Student_ExamResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.examResultsTitleLabel);
            this.Name = "Student_ExamResults";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label examResultsTitleLabel;
    }
}
