namespace EasyTestApp.Student
{
    partial class Student
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendarButton = new System.Windows.Forms.Button();
            this.classroomButton = new System.Windows.Forms.Button();
            this.checkResultsButton = new System.Windows.Forms.Button();
            this.joinCourseButton = new System.Windows.Forms.Button();
            this.goToExamButton = new System.Windows.Forms.Button();
            this.smallLogo = new System.Windows.Forms.PictureBox();
            this.student_CheckResults1 = new EasyTestApp.Student.Student_CheckResults();
            this.student_Classroom1 = new EasyTestApp.Student.Student_Classroom();
            this.student_ClassroomResult1 = new EasyTestApp.Student.Student_ClassroomResult();
            this.student_ExamPage1 = new EasyTestApp.Student.Student_ExamPage();
            this.student_ExamResults1 = new EasyTestApp.Student.Student_ExamResults();
            this.student_GoToExam1 = new EasyTestApp.Student.Student_GoToExam();
            this.student_JoinACourse1 = new EasyTestApp.Student.Student_JoinACourse();
            this.student_Calendar1 = new EasyTestApp.Student_Calendar();
            this.student_Homepage1 = new EasyTestApp.Student.Student_Homepage();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.student_Homepage1);
            this.panel2.Controls.Add(this.student_Calendar1);
            this.panel2.Controls.Add(this.student_JoinACourse1);
            this.panel2.Controls.Add(this.student_GoToExam1);
            this.panel2.Controls.Add(this.student_ExamResults1);
            this.panel2.Controls.Add(this.student_ExamPage1);
            this.panel2.Controls.Add(this.student_ClassroomResult1);
            this.panel2.Controls.Add(this.student_Classroom1);
            this.panel2.Controls.Add(this.student_CheckResults1);
            this.panel2.Location = new System.Drawing.Point(295, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 463);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.calendarButton);
            this.panel1.Controls.Add(this.classroomButton);
            this.panel1.Controls.Add(this.checkResultsButton);
            this.panel1.Controls.Add(this.joinCourseButton);
            this.panel1.Controls.Add(this.goToExamButton);
            this.panel1.Controls.Add(this.smallLogo);
            this.panel1.Location = new System.Drawing.Point(10, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 650);
            this.panel1.TabIndex = 2;
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calendarButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.calendarButton.Location = new System.Drawing.Point(0, 432);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(250, 74);
            this.calendarButton.TabIndex = 5;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = false;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // classroomButton
            // 
            this.classroomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.classroomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classroomButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.classroomButton.Location = new System.Drawing.Point(0, 353);
            this.classroomButton.Name = "classroomButton";
            this.classroomButton.Size = new System.Drawing.Size(250, 74);
            this.classroomButton.TabIndex = 4;
            this.classroomButton.Text = "Classroom";
            this.classroomButton.UseVisualStyleBackColor = false;
            this.classroomButton.Click += new System.EventHandler(this.classroomButton_Click);
            // 
            // checkResultsButton
            // 
            this.checkResultsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.checkResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkResultsButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.checkResultsButton.Location = new System.Drawing.Point(0, 274);
            this.checkResultsButton.Name = "checkResultsButton";
            this.checkResultsButton.Size = new System.Drawing.Size(250, 74);
            this.checkResultsButton.TabIndex = 3;
            this.checkResultsButton.Text = "Check Exam Results";
            this.checkResultsButton.UseVisualStyleBackColor = false;
            this.checkResultsButton.Click += new System.EventHandler(this.checkResultsButton_Click);
            // 
            // joinCourseButton
            // 
            this.joinCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.joinCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.joinCourseButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinCourseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.joinCourseButton.Location = new System.Drawing.Point(0, 194);
            this.joinCourseButton.Name = "joinCourseButton";
            this.joinCourseButton.Size = new System.Drawing.Size(250, 74);
            this.joinCourseButton.TabIndex = 2;
            this.joinCourseButton.Text = "Join a Course";
            this.joinCourseButton.UseVisualStyleBackColor = false;
            this.joinCourseButton.Click += new System.EventHandler(this.joinCourseButton_Click);
            // 
            // goToExamButton
            // 
            this.goToExamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.goToExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goToExamButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToExamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.goToExamButton.Location = new System.Drawing.Point(0, 115);
            this.goToExamButton.Name = "goToExamButton";
            this.goToExamButton.Size = new System.Drawing.Size(250, 74);
            this.goToExamButton.TabIndex = 1;
            this.goToExamButton.Text = "Go to Exam";
            this.goToExamButton.UseVisualStyleBackColor = false;
            this.goToExamButton.Click += new System.EventHandler(this.goToExamButton_Click);
            // 
            // smallLogo
            // 
            this.smallLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.smallLogo.Location = new System.Drawing.Point(0, 0);
            this.smallLogo.Name = "smallLogo";
            this.smallLogo.Size = new System.Drawing.Size(250, 74);
            this.smallLogo.TabIndex = 1;
            this.smallLogo.TabStop = false;
            this.smallLogo.Click += new System.EventHandler(this.smallLogo_Click);
            // 
            // student_CheckResults1
            // 
            this.student_CheckResults1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_CheckResults1.Location = new System.Drawing.Point(0, 3);
            this.student_CheckResults1.Name = "student_CheckResults1";
            this.student_CheckResults1.Size = new System.Drawing.Size(679, 463);
            this.student_CheckResults1.TabIndex = 0;
            this.student_CheckResults1.Click += new System.EventHandler(this.OnClick);
            // 
            // student_Classroom1
            // 
            this.student_Classroom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_Classroom1.Location = new System.Drawing.Point(0, 0);
            this.student_Classroom1.Name = "student_Classroom1";
            this.student_Classroom1.Size = new System.Drawing.Size(679, 463);
            this.student_Classroom1.TabIndex = 1;
            this.student_Classroom1.Click += new System.EventHandler(this.OnClick);
            // 
            // student_ClassroomResult1
            // 
            this.student_ClassroomResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_ClassroomResult1.Location = new System.Drawing.Point(0, 3);
            this.student_ClassroomResult1.Name = "student_ClassroomResult1";
            this.student_ClassroomResult1.Size = new System.Drawing.Size(679, 463);
            this.student_ClassroomResult1.TabIndex = 2;
            // 
            // student_ExamPage1
            // 
            this.student_ExamPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_ExamPage1.Location = new System.Drawing.Point(0, 0);
            this.student_ExamPage1.Name = "student_ExamPage1";
            this.student_ExamPage1.Size = new System.Drawing.Size(679, 463);
            this.student_ExamPage1.TabIndex = 3;
            // 
            // student_ExamResults1
            // 
            this.student_ExamResults1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_ExamResults1.Location = new System.Drawing.Point(0, 0);
            this.student_ExamResults1.Name = "student_ExamResults1";
            this.student_ExamResults1.Size = new System.Drawing.Size(679, 463);
            this.student_ExamResults1.TabIndex = 4;
            // 
            // student_GoToExam1
            // 
            this.student_GoToExam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_GoToExam1.Location = new System.Drawing.Point(0, 0);
            this.student_GoToExam1.Name = "student_GoToExam1";
            this.student_GoToExam1.Size = new System.Drawing.Size(679, 463);
            this.student_GoToExam1.TabIndex = 5;
            this.student_GoToExam1.Click += new System.EventHandler(this.OnClick);
            // 
            // student_JoinACourse1
            // 
            this.student_JoinACourse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_JoinACourse1.Location = new System.Drawing.Point(0, 0);
            this.student_JoinACourse1.Name = "student_JoinACourse1";
            this.student_JoinACourse1.Size = new System.Drawing.Size(679, 463);
            this.student_JoinACourse1.TabIndex = 6;
            this.student_JoinACourse1.Click += new System.EventHandler(this.OnClick);
            // 
            // student_Calendar1
            // 
            this.student_Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_Calendar1.Location = new System.Drawing.Point(0, 0);
            this.student_Calendar1.Name = "student_Calendar1";
            this.student_Calendar1.Size = new System.Drawing.Size(679, 463);
            this.student_Calendar1.TabIndex = 7;
            this.student_Calendar1.Click += new System.EventHandler(this.OnClick);
            // 
            // student_Homepage1
            // 
            this.student_Homepage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.student_Homepage1.Location = new System.Drawing.Point(0, 0);
            this.student_Homepage1.Name = "student_Homepage1";
            this.student_Homepage1.Size = new System.Drawing.Size(679, 463);
            this.student_Homepage1.TabIndex = 8;
            this.student_Homepage1.Click += new System.EventHandler(this.OnClick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smallLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button classroomButton;
        private System.Windows.Forms.Button checkResultsButton;
        private System.Windows.Forms.Button joinCourseButton;
        private System.Windows.Forms.Button goToExamButton;
        private System.Windows.Forms.PictureBox smallLogo;
        private Student_Homepage student_Homepage1;
        private Student_Calendar student_Calendar1;
        private Student_JoinACourse student_JoinACourse1;
        private Student_GoToExam student_GoToExam1;
        private Student_ExamResults student_ExamResults1;
        private Student_ExamPage student_ExamPage1;
        private Student_ClassroomResult student_ClassroomResult1;
        private Student_Classroom student_Classroom1;
        private Student_CheckResults student_CheckResults1;
    }
}