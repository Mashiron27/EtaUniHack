using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EasyTestApp.Student
{
    public partial class Student_GoToExam : UserControl
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

        public Student_GoToExam()
        {
            InitializeComponent();
            goToExamNextButton.Click += OnClick;
            /*
            // Database Connection:
            SqlConnection cnn = new SqlConnection(Program.DB_ConnectionString_EasyTestApp);
            cnn.Open();

            // Select statement: 
            SqlCommand command0 = new SqlCommand("Select Id from Exams where something = @smth", cnn);
            SqlParameter smth = new SqlParameter();
            smth.ParameterName = "@smth";
            command0.Parameters.AddWithValue("@smth", (examListDropdown.Text));

            using (command0)
            {
                SqlDataReader dR = command0.ExecuteReader();
                using (dR)
                {
                    while (dR.Read())
                    {
                        /*st.Add(dR[0].ToString());
                        id.Add(dR[1].ToString());
                    }
                }
            }

            // Disposal:
            command0.Parameters.Clear();
            command0.Dispose();
            cnn.Close();*/
        }

        // Variable used in the next Form:
        public static string ExamId;

        private void goToExamNextButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
