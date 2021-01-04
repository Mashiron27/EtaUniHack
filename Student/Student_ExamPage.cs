using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyTestApp.Student
{
    public partial class Student_ExamPage : UserControl
    {
        public Student_ExamPage()
        {
            InitializeComponent();
        }

        private void question1_uploadButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                question1_uploadedImage.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
