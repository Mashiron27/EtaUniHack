using System;
using System.Windows.Forms;

namespace EasyTestApp.Student
{
    public partial class Student_Classroom : UserControl
    {
        [NonSerialized]
        private EventHandler fClick;
        public event EventHandler Click
        {
            add { fClick += value; }
            remove { fClick -= value; }
        }
        protected void OnClick(object sender, EventArgs e)
        {
            EventHandler handler = fClick;
            if (fClick != null)
                handler(sender, e);
        }

        public Student_Classroom()
        {
            InitializeComponent();
            goToClassNextButton.Click += OnClick;
        }
    }
}
