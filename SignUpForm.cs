using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void CreateAcc_Login_label_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }
        
        private void SignUp_button_Click(object sender, EventArgs e)
        {
            string username = SignUp_UserName_textBox.Text;
            string password = SignUp_Pass_textBox.Text;
            string fullname = full_Name_value.Text;
            DateTime Date_Of_birth = Date_Of_Birth_val.Value;        
            string gender = "";
            if (GenderVal.SelectedItem.ToString() != "")
            {
                gender = GenderVal.SelectedItem.ToString();
            }
            string phone = Phone_val.Text;
            string email = Email_val.Text;
            string address = Address_val.Text;
            string bloodGroup = "";
            if (Blood_Grp_val.SelectedItem != null)
            {
                bloodGroup = Blood_Grp_val.SelectedItem.ToString();
            }
            string medicalHistory = Medical_History_val.Text;  

            if (string.IsNullOrWhiteSpace(SignUp_UserName_textBox.Text) || string.IsNullOrWhiteSpace(SignUp_Pass_textBox.Text) 
                || string.IsNullOrWhiteSpace(Confirm_SignUpPass_textBox.Text)
                || string.IsNullOrWhiteSpace(full_Name_value.Text) || string.IsNullOrWhiteSpace(Phone_val.Text)
                || string.IsNullOrWhiteSpace(Email_val.Text)|| string.IsNullOrWhiteSpace(Address_val.Text) 
                || string.IsNullOrWhiteSpace(bloodGroup)
                || string.IsNullOrWhiteSpace(Medical_History_val.Text) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all the fields to register");
                return;
            }
            if(SignUp_UserName_textBox.Text.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.");
                return;
            }
            if(SignUp_Pass_textBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }
            if (SignUp_Pass_textBox.Text != Confirm_SignUpPass_textBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if(Date_Of_birth >= DateTime.Today)
            {
                MessageBox.Show("Date of birth cannot be today or in the future.");
                return;
            }
            if(!Phone_val.MaskCompleted)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            //if (Phone_val.Text.StartsWith("01"))
            //{
            //    MessageBox.Show("Phone number cannot start with 01.");
            //    return;
            //}
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
                {
                    con.Open();
                    string query = "Select Count(*) from [Users] where Username = @Username";
                    SqlCommand chkcmd = new SqlCommand(query, con);
                    chkcmd.Parameters.AddWithValue("@Username", username);
                    if((int)chkcmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }
                    string insertQuery = "INSERT INTO [Users] (Username, Password, Role, Status, CreatedAt) VALUES (@Username, @Password, @Role, @Status, @CreatedAt)";
                    SqlCommand insertcmd = new SqlCommand(insertQuery, con);
                    insertcmd.Parameters.AddWithValue("@Username", username);
                    insertcmd.Parameters.AddWithValue("@Password", password);
                    insertcmd.Parameters.AddWithValue("@Role", "Patient");
                    insertcmd.Parameters.AddWithValue("@Status", 0);
                    insertcmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    insertcmd.ExecuteNonQuery();
                    SqlCommand getUserIDCmd = new SqlCommand("SELECT UserID FROM [Users] WHERE Username = @Username", con);
                    getUserIDCmd.Parameters.AddWithValue("@Username", username);
                    int userID = (int)getUserIDCmd.ExecuteScalar();
                    string Patinsertquery = "INSERT INTO Patient (UserID, Name, DateOfBirth, Gender, Phone, Address, [MedicalHistory], Email, [BloodGroup], RegisteredAt) " +
                                            "VALUES (@UserID, @Name, @DateOfBirth, @Gender, @Phone, @Address, @MedicalHistory, @Email, @BloodGroup, @RegisteredAt)";
                    SqlCommand patcmd = new SqlCommand(Patinsertquery, con);
                    patcmd.Parameters.AddWithValue("@UserID", userID);
                    patcmd.Parameters.AddWithValue("@Name", fullname);
                    patcmd.Parameters.AddWithValue("@DateOfBirth", Date_Of_birth);
                    patcmd.Parameters.AddWithValue("@Gender", gender);
                    patcmd.Parameters.AddWithValue("@Phone", phone);
                    patcmd.Parameters.AddWithValue("@Address", address);
                    patcmd.Parameters.AddWithValue("@MedicalHistory", medicalHistory);
                    patcmd.Parameters.AddWithValue("@Email", email);
                    patcmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                    patcmd.Parameters.AddWithValue("@RegisteredAt", DateTime.Now);
                    patcmd.ExecuteNonQuery();
                    MessageBox.Show("Sign-Up Successful!\nYour account is pending activation.\nPlease wait for the Admin to activate your account before logging in.");
                    new loginForm().Show();
                    this.Hide();
                    ClearFields();
                }
            }catch (Exception ex)
            {
               MessageBox.Show("Error During Signup: " + ex.Message);
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Closing Window", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void SignUp_Pass_pictureBox_Click(object sender, EventArgs e)
        {
            if (SignUp_Pass_textBox.UseSystemPasswordChar == true)
            {
                SignUp_Pass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                SignUp_Pass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void SignUp_confirmPass_pictureBox_Click(object sender, EventArgs e)
        {
            if (Confirm_SignUpPass_textBox.UseSystemPasswordChar == true)
            {
                Confirm_SignUpPass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                Confirm_SignUpPass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            ClearFields();

        }
        private void ClearFields()
        {
            GenderVal.SelectedIndex = 0;
            Blood_Grp_val.SelectedIndex = 0;
            SignUp_UserName_textBox.Text = "";
            SignUp_Pass_textBox.Text = "";
            Confirm_SignUpPass_textBox.Text = "";
            full_Name_value.Text = "";
            Date_Of_Birth_val.Value = DateTime.Now;
            Email_val.Text = "";
            Address_val.Text = "";
            Phone_val.Text = "";
            Medical_History_val.Text = "";
            UsersE usersE = new UsersE();
            usersE.Username = "";
            usersE.Password = "";
            usersE.Role = "Patient";
            usersE.Status = 0;
            usersE.CreatedAt = DateTime.Now;

            PatientE patientE = new PatientE();
            patientE.Name = "";
            patientE.PatientID = 0;
            patientE.Gender = "";
            patientE.Phone = "";
            patientE.Email = "";
            patientE.Address = "";
            patientE.BloodGroup = "";
            patientE.MedicalHistory = "";
            patientE.CreatedAt = DateTime.Now;
        }
    }
}
