using System;
using System.Windows.Forms;

namespace EasyTestApp.Student
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            student_Homepage1.Visible = true;
            student_GoToExam1.Visible = false;
            student_JoinACourse1.Visible = false;
            student_CheckResults1.Visible = false;
            student_Classroom1.Visible = false;
            student_Calendar1.Visible = false;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void goToExamButton_Click(object sender, EventArgs e)
        {
            student_Homepage1.Visible = false;
            student_GoToExam1.Visible = true;
            student_JoinACourse1.Visible = false;
            student_CheckResults1.Visible = false;
            student_Classroom1.Visible = false;
            student_Calendar1.Visible = false;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void joinCourseButton_Click(object sender, EventArgs e)
        {
            student_Homepage1.Visible = false;
            student_GoToExam1.Visible = false;
            student_JoinACourse1.Visible = true;
            student_CheckResults1.Visible = false;
            student_Classroom1.Visible = false;
            student_Calendar1.Visible = false;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void checkResultsButton_Click(object sender, EventArgs e)
        {
            student_Homepage1.Visible = false;
            student_GoToExam1.Visible = false;
            student_JoinACourse1.Visible = false;
            student_CheckResults1.Visible = true;
            student_Classroom1.Visible = false;
            student_Calendar1.Visible = false;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void classroomButton_Click(object sender, EventArgs e)
        {
            student_Homepage1.Visible = false;
            student_GoToExam1.Visible = false;
            student_JoinACourse1.Visible = false;
            student_CheckResults1.Visible = false;
            student_Classroom1.Visible = true;
            student_Calendar1.Visible = false;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            student_Homepage1.Visible = false;
            student_GoToExam1.Visible = false;
            student_JoinACourse1.Visible = false;
            student_CheckResults1.Visible = false;
            student_Classroom1.Visible = false;
            student_Calendar1.Visible = true;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void smallLogo_Click(object sender, EventArgs e)
        {
            student_Homepage1.Visible = true;
            student_GoToExam1.Visible = false;
            student_JoinACourse1.Visible = false;
            student_CheckResults1.Visible = false;
            student_Classroom1.Visible = false;
            student_Calendar1.Visible = false;
            student_ExamPage1.Visible = false;
            student_ExamResults1.Visible = false;
            student_ClassroomResult1.Visible = false;
        }

        private void OnClick(object sender, EventArgs e)
        {
            // Display userControls logic:
            if (sender is Button)
            {
                Button btn = sender as Button;
                if (btn.Parent == student_GoToExam1)
                {
                    student_ExamPage1.Visible = true;

                    student_Homepage1.Visible = false;
                    student_GoToExam1.Visible = false;
                    student_JoinACourse1.Visible = false;
                    student_CheckResults1.Visible = false;
                    student_Classroom1.Visible = false;
                    student_Calendar1.Visible = false;
                }
                else if (btn.Parent == student_CheckResults1)
                {
                    student_ExamResults1.Visible = true;

                    student_Homepage1.Visible = false;
                    student_GoToExam1.Visible = false;
                    student_JoinACourse1.Visible = false;
                    student_CheckResults1.Visible = false;
                    student_Classroom1.Visible = false;
                    student_Calendar1.Visible = false;
                }
                else if (btn.Parent == student_Classroom1)
                {
                    student_ClassroomResult1.Visible = true;

                    student_Homepage1.Visible = false;
                    student_GoToExam1.Visible = false;
                    student_JoinACourse1.Visible = false;
                    student_CheckResults1.Visible = false;
                    student_Classroom1.Visible = false;
                    student_Calendar1.Visible = false;
                }
                else if (btn.Parent == student_GoToExam1)
                {
                    student_ExamPage1.Visible = true;

                    student_Homepage1.Visible = false;
                    student_GoToExam1.Visible = false;
                    student_JoinACourse1.Visible = false;
                    student_CheckResults1.Visible = false;
                    student_Classroom1.Visible = false;
                    student_Calendar1.Visible = false;
                }
                else if (btn.Parent == student_GoToExam1)
                {
                    student_ExamPage1.Visible = true;

                    student_Homepage1.Visible = false;
                    student_GoToExam1.Visible = false;
                    student_JoinACourse1.Visible = false;
                    student_CheckResults1.Visible = false;
                    student_Classroom1.Visible = false;
                    student_Calendar1.Visible = false;

                }
            }
        }
    }
}
