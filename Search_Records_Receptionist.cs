using HMS.DBHelper;
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
using System.Xml.Linq;
namespace HMS
{
    public partial class Search_Records_Receptionist : Form
    {
        public Search_Records_Receptionist()
        {
            InitializeComponent();
        }

        private void Search_Patient_button_Click(object sender, EventArgs e)
        {
            string name = Patient_Search_textBox.Text.Trim();
            if(name == "")
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT PatientID, Name, Gender, Phone, [BloodGroup] FROM Patient WHERE Name = @Name";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.Parameters.AddWithValue("@Name", name);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Patient found.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            string patientId = dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
            //string patientName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            LoadPatientRecords(patientId);
        }
        private void LoadPatientRecords(string patientId)
        {
            string ConnectionString = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            { 
                con.Open();
                string query = "Select p.Name As Patient, p.phone, a.AppointmentID, a.Date, a.Time, a.AppointmentStatus As Status, d.Name As Doctor, d.Specialty As Speciality " +
                    "From Patient p " +
                    "Left Join Appointment a On p.PatientID = a.PatientID " +
                    "Left Join Doctor d On a.DoctorID = d.DoctorID " +
                    "Where p.PatientID = @pid";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@pid", patientId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Record found for the selected patient.");
                }
            }
        }

        private void Search_Records_Receptionist_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT PatientID, Name, Gender, Phone, [BloodGroup] FROM Patient";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Patient found.");
                }
            }
        }

        private void Patient_Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string name = Patient_Search_textBox.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT PatientID, Name, Gender, Phone, [BloodGroup] FROM Patient WHERE Name LIKE @Name";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.Parameters.AddWithValue("@Name", "%" + name + "%");
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
