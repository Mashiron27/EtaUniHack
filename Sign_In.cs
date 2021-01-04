using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EasyTestApp
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMiniMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Sign_Up signup = new Sign_Up(); // open a new sign up window
            signup.Show();

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
			// Database Connection:
			SqlConnection cnn = new SqlConnection(Program.DB_ConnectionString_EasyTestApp);
			cnn.Open();

			// Select statement: 
			SqlCommand command0 = new SqlCommand("Select priviledges from Users where username=@use and password=@pas", cnn);
			SqlParameter use = new SqlParameter();
			SqlParameter pas = new SqlParameter();
			use.ParameterName = "@use";
			pas.ParameterName = "@pas";
			command0.Parameters.AddWithValue("@use", (txtUsername.Text));
			command0.Parameters.AddWithValue("@pas", (txtPassword.Text));

			var myString = "";
			using (command0)
			{
				SqlDataReader dR = command0.ExecuteReader();
				using (dR)
				{
					while (dR.Read())
					{
						myString = dR.GetInt32(0).ToString();

						if ((txtUsername.Text == "") && (txtPassword.Text == ""))
						{
							MessageBox.Show("Username & password fields cannot be empty.");
						}
						else if (txtUsername.Text == "")
						{
							MessageBox.Show("Please enter your username.");
						}
						else if (txtPassword.Text == "")
						{
							MessageBox.Show("Please enter your password.");
						}
						//============================================
						else if ((myString == "0") || (myString == "1") || (myString == "2"))
						{
							if (myString == "0")
							{
								MessageBox.Show("Admin");
							}
							else if (myString == "1")
							{
								MessageBox.Show("Teacher");

							}
							else if (myString == "2")
							{
								MessageBox.Show("Student");
								Student.Student y = new Student.Student();
								y.Show();
								this.Hide();
							}
						}
						//============================================
						else
						{
							MessageBox.Show("Wrong credentials.");
						}
					}
				}
			}

			// Disposal:
			command0.Parameters.Clear();
			command0.Dispose();
			cnn.Close();
		}
    }
}
