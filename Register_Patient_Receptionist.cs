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

namespace HMS
{
    public partial class Register_Patient_Receptionist : Form
    {
        public Register_Patient_Receptionist()
        {
            InitializeComponent();
        }
       
        private void Register_Patient_Receptionist_Load(object sender, EventArgs e)
        {
            LoadRecentPatients();
        }
        void LoadRecentPatients()
        {
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT TOP 10 PatientID, Name, DateOfBirth FROM Patient ORDER BY PatientID DESC";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                Recently_Reg_Pat_dgv.DataSource = dt;
            }
        }
        private void Save_Patient_button_Click(object sender, EventArgs e)
        {
            string name = Rg_Pat_Name_val.Text;
            string gender = Gender_Val.Text;
            string phone = Phone_val.Text;
            string address = Address_val.Text;
            string email = Email_val.Text;
            string bloodGroup = P_BG_val.Text;
            string medicalHistory = Medical_History_val.Text;
            DateTime dob = Date_Of_Birth_val.Value;
            DateTime RegisteredAt = DateTime.Now;
            if (name == "" || gender == "" || phone == "" || address == "" || email == "" || bloodGroup == "" || medicalHistory == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            if(dob >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be Today or in the future.");
                return;
            }
            if (!Phone_val.MaskFull)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Invalid email.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
                {
                    con.Open();
                    string username = name + RegisteredAt;
                    string password = name + dob;
                    string setUserQuery = "INSERT INTO [Users] (Username, Password, Role, Status, CreatedAt) VALUES (@Username, @Password, @Role, @Status, @CreatedAt)";
                    SqlCommand userCmd = new SqlCommand(setUserQuery, con);
                    userCmd.Parameters.AddWithValue("@Username", username);
                    userCmd.Parameters.AddWithValue("@Password", password);
                    userCmd.Parameters.AddWithValue("@Role", "Patient");
                    userCmd.Parameters.AddWithValue("@Status", 1);
                    userCmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    userCmd.ExecuteNonQuery();
                    string getUserIdQuery = "SELECT UserID FROM [Users] WHERE Username = @Username";
                    SqlCommand getUserIdCmd = new SqlCommand(getUserIdQuery, con);
                    getUserIdCmd.Parameters.AddWithValue("@Username", username);
                    int userID = (int)getUserIdCmd.ExecuteScalar();
                    string query= "Insert Into Patient (UserID, Name, DateOfBirth, Gender, Phone, Email, Address, [BloodGroup], [MedicalHistory], RegisteredAt) Values (@UserID, @Name, @DateOfBirth, @Gender, @Phone, @Email, @Address, @BloodGroup, @MedicalHistory, @RegisteredAt)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@MedicalHistory", medicalHistory);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                    cmd.Parameters.AddWithValue("@RegisteredAt", RegisteredAt);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Patient registered successfully.");
                    ClearFields();
                    LoadRecentPatients();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Medical_History_val_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Patient_button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            Rg_Pat_Name_val.Text = "";
            Date_Of_Birth_val.Value = DateTime.Today;
            Gender_Val.Text = "";
            Phone_val.Text = "";
            Address_val.Text = "";
            Email_val.Text = "";
            P_BG_val.Text = "";
            Medical_History_val.Text = "";
        }
    }
}
