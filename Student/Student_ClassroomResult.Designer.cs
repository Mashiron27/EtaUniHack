namespace EasyTestApp.Student
{
    partial class Student_ClassroomResult
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
            this.classResultTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classResultTitleLabel
            // 
            this.classResultTitleLabel.AutoSize = true;
            this.classResultTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.classResultTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.classResultTitleLabel.Location = new System.Drawing.Point(162, 53);
            this.classResultTitleLabel.Name = "classResultTitleLabel";
            this.classResultTitleLabel.Size = new System.Drawing.Size(222, 17);
            this.classResultTitleLabel.TabIndex = 6;
            this.classResultTitleLabel.Text = "Chosen Clasroom\'s colleagues:";
            // 
            // Student_ClassroomResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.classResultTitleLabel);
            this.Name = "Student_ClassroomResult";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classResultTitleLabel;
    }
}
