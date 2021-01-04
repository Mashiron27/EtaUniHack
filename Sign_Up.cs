using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EasyTestApp
{
    public partial class Sign_Up : Form
    {
        string connectionstring = "Data Source=(LocalDB);Initial Catalog=EasyTestDB";//copy from db properties
        public Sign_Up()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtCPassword.Text = txtPassword.Text = txtPrivileges.Text = txtUsername.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Sign_In signin = new Sign_In();
            signin.Show();

            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in mandatory fields!");
            }
            else if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    string query = "Select * from Users Where Username = '" + txtUsername.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                    DataTable dtb1 = new DataTable();
                    sda.Fill(dtb1);
                    if (dtb1.Rows.Count == 1)
                    {
                        MessageBox.Show("The username has been registered!");
                        Clear();
                    }
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    //User add is the process of adding in set by the db, requires name changing
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("priviledges", txtPrivileges.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("password", txtPassword.Text.Trim());

                    //change the @.... according to the db
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Sign Up!");
                    Clear();
                }
            }
        }
    }
}
