using System;
using System.Windows.Forms;

namespace EasyTestApp.Student
{
    public partial class Student_JoinACourse : UserControl
    {
        public Student_JoinACourse()
        {
            InitializeComponent();
            validCode.Visible = false;
            invalidCode.Visible = false;
            nullCode.Visible = false;
        }

        private void joinCourseButton_Click(object sender, EventArgs e)
        {
            // send link invitation
            string link = examLinkInput.Text;
            if (link == "correct")
            {
                validCode.Visible = true;
                invalidCode.Visible = false;
                nullCode.Visible = false;
            }
            else if (link == "incorrect")
            {
                invalidCode.Visible = true;
                validCode.Visible = false;
                nullCode.Visible = false;
            }
            else if (link == "")
            {
                nullCode.Visible = true;
                invalidCode.Visible = false;
                validCode.Visible = false;
            }
        }
    }
}
