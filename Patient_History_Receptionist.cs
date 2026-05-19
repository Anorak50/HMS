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
    public partial class Patient_History_Receptionist : Form
    {
        public Patient_History_Receptionist()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Patient_button_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";
          
            if(Patient_Search_textBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT PatientID, Name FROM Patient WHERE Name = @Name";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.Parameters.AddWithValue("@Name", Patient_Search_textBox.Text.Trim());
                DataTable dt = new DataTable();
                sd.Fill(dt);
                Select_Patient_dataGridView.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No patients found with the given name.");
                }
            }
        }

        private void Select_Patient_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }
                string patientId = Select_Patient_dataGridView.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                string patientName = Select_Patient_dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                Selected_Patient_label.Text = "Selected Patient: " + patientName;

                LoadPatientHistory(patientId);
            
            
        }
        private void LoadPatientHistory(string patientId)
        {
            string ConnectionString = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "Select ph.Date, d.Name As Doctor, ph.Diagnosis, ph.Notes, a.AppointmentStatus As AppointmentStatus " +
                              "From PatientHistory ph " +
                              "Join Doctor d ON ph.DoctorID = d.DoctorID " +
                              "Join Appointment a ON ph.AppointmentID = a.AppointmentID " +
                              "where ph.PatientID = @pid " +
                              "Order By ph.Date DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@pid", patientId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Selected_Pat_dataGridView.DataSource = dt;
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("No history found for the selected patient.");
                }
            }
        }

        private void Patient_History_Receptionist_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT PatientID, Name FROM Patient";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                Select_Patient_dataGridView.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No patients found with the given name.");
                }
            }
        }

        private void Patient_Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";

            if (Patient_Search_textBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT PatientID, Name FROM Patient WHERE Name LIKE @Name";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.Parameters.AddWithValue("@Name", "%" + Patient_Search_textBox.Text + "%");
                DataTable dt = new DataTable();
                sd.Fill(dt);
                Select_Patient_dataGridView.DataSource = dt;
                //if (dt.Rows.Count == 0)
                //{
                //    MessageBox.Show("No patients found with the given name.");
                //}
            }
        }
    }
}
