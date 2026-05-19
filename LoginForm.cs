using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Admin_Dashboard_all;
namespace HMS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pass_pictureBox_Click(object sender, EventArgs e)
        {
            
            if (Pass_textBox.UseSystemPasswordChar == true)
            {
                Pass_textBox.UseSystemPasswordChar = false; 
            }
            else
            {
                Pass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Closing Window", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = UserName_textBox.Text;
            string password = Pass_textBox.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Please fill in all the fields to login");
                return;
            }
            if(UserName_textBox.Text.Length < 3 || password.Length < 6)
            {
                MessageBox.Show("Username must be at least 3 characters long and password must be at least 6 characters long");
                return;
            }
            try 
            {
                string cs = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Role, Status FROM [Users] WHERE Username=@username AND Password=@password";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.Parameters.AddWithValue("@username", username);
                    sda.SelectCommand.Parameters.AddWithValue("@password", password);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if(dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid username or password");
                        return;
                    }
                    string role = dt.Rows[0]["Role"].ToString();
                    int status = Convert.ToInt32(dt.Rows[0]["Status"]);
                    if(status != 1)
                    {
                        MessageBox.Show("Your account isn't active Or\nhas been deactivated \nKindly contact the administrator");
                        return;
                    }
                    if(role == "Patient")
                    {
                        MessageBox.Show("Login Successful" + "\nYou'll be Redirected to the Patient Window");
                        new PatientForm().Show();
                        this.Hide();
                    }
                    else if(role == "Admin")
                    {
                        MessageBox.Show("Login Successful" + "\nYou'll be Redirected to the Admin Window");
                        //new AdminDashboard().Show();
                        //this.Hide();
                    }
                    else if(role == "Receptionist")
                    {
                        MessageBox.Show("Login Successful" + "\nYou'll be Redirected to the Receptionist Window");
                        new Receptionist().Show();
                        this.Hide();
                    }
                    else if(role == "HR")
                    {
                        //MessageBox.Show("Login Successful" + "\nYou'll be Redirected to the HR Window");
                        //new HR().Show();
                        //this.Hide();
                    }
                    else if(role == "Doctor") 
                    {
                        //MessageBox.Show("Login Successful" + "\nYou'll be Redirected to the Doctor Window");
                       // new Doctor().Show();
                        //this.Hide();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message);
            }
        }

        private void SignUp_label_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
