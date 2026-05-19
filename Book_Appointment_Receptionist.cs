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
    public partial class Book_Appointment_Receptionist : Form
    {
        public Book_Appointment_Receptionist()
        {
            InitializeComponent();
        }
        int doctorId = 0;
        int patientId = 0;
        //DateTime selectedDate = (DateTime)Date_val_maskedTextBox2;
        private void Book_Appointment_button_Click(object sender, EventArgs e)
        {
            if (doctorId == 0)
            {
                MessageBox.Show("Please select a doctor first.");
                return;
            }
            //if(Patie)
            if (!DateTime.TryParse(Date_val.Text, out DateTime apptDate))
            {
                MessageBox.Show("Please enter a valid date.(MM/DD/YYYY)");
                return;
            }
            if (!TimeSpan.TryParse(Time_val.Text.Trim(), out TimeSpan apptTime))
            {
                MessageBox.Show("Please enter a valid time.(HH:MM)");
                return;
            }
            if(apptDate.Date <= DateTime.Today)
            {
                MessageBox.Show("Appointment date cannot be today or in the past.");
                return;
            }
            
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT Count(*) FROM Appointment WHERE DoctorID = @DoctorID And Date = @Date And Time = @Time";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@Date", apptDate);
                cmd.Parameters.AddWithValue("@Time", apptTime);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("This slot is already booked. Please select a different slot.");
                    return;
                }
                else
                {
                    try
                    {
                        string status = "Approved";
                        string Note = "";
                        patientId = Convert.ToInt32(Selected_Patient_val.Text);
                        DateTime CreatedAt = DateTime.Now;
                        string insertQuery = "INSERT INTO Appointment (PatientID, DoctorID, Date, Time, AppointmentStatus, Notes, CreatedAt) VALUES (@PatientID, @DoctorID, @Date, @Time, @Status, @Note, @CreatedAt)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@PatientID", patientId);
                        insertCmd.Parameters.AddWithValue("@DoctorID", doctorId);
                        insertCmd.Parameters.AddWithValue("@Date", apptDate);
                        insertCmd.Parameters.AddWithValue("@Time", apptTime);
                        insertCmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        insertCmd.Parameters.AddWithValue("@Status", status);       //pending or Booked check needed
                        insertCmd.Parameters.AddWithValue("@Note", Note);
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment booked successfully.");
                        ClearBookingForm();
                    }
                    catch (Exception ex) { MessageBox.Show("Patient Id does not exist\nPlease, Register the desired Patient First."); return; }

                    
                }

            }
        }

        private void Book_Appointment_Receptionist_Load(object sender, EventArgs e)
        {
            LoadAllDoctors();
            using(SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT PatientID, Name, MedicalHistory FROM Patient";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dt1 = new DataTable();
                sd.Fill(dt1);
                dataGridView2.DataSource = dt1;
            }
        }
        
        private void Search_Doc_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT DoctorID, Name, Specialty, Qualification FROM Doctor WHERE Name LIKE @Name";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.Parameters.AddWithValue("@Name", "%" + Search_Doc_maskedTextBox.Text + "%");
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView_Left.DataSource = dt;
            }
        }

        private void dataGridView_Left_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }
            doctorId = Convert.ToInt32(dataGridView_Left.Rows[e.RowIndex].Cells["DoctorID"].Value);
            //patientId = Convert.ToInt32(dataGridView_Left.Rows[e.RowIndex].Cells["PatientID"].Value);
            Selected_Doc_val.Text = dataGridView_Left.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        }

        private void Chk_avail_button_Click(object sender, EventArgs e)
        {
            if(doctorId == 0)
            {
                MessageBox.Show("Please select a doctor first.");
                return;
            }
            if(!DateTime.TryParse(Date_val.Text, out DateTime apptDate))
            {
                MessageBox.Show("Please enter a valid date.(MM/DD/YYYY)");
                return;
            }
            if(!TimeSpan.TryParse(Time_val.Text.Trim(), out TimeSpan apptTime))
            {
                MessageBox.Show("Please enter a valid time.(HH:MM)");
                return;
            }
            if (apptDate.Date < DateTime.Today)
            {
                MessageBox.Show("Appointment date cannot be in the past.");
                return;
            }
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT Count(*) FROM Appointment WHERE DoctorID = @DoctorID And Date = @Date And Time = @Time";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@Date", apptDate);
                cmd.Parameters.AddWithValue("@Time", apptTime);
                int count = (int)cmd.ExecuteScalar();
                if(count > 0)
                {
                    MessageBox.Show("The selected doctor is not available at the chosen date and time. Please select a different slot.");

                }
                else
                {
                    MessageBox.Show("The selected doctor is available at the chosen date and time. You can proceed to book the appointment.");
                }

            }
        }
        private void ClearBookingForm()
        {
            doctorId = 0;
            patientId = 0;
            Search_Doc_maskedTextBox.Text = "";
            Selected_Doc_val.Text = "";
            Selected_Patient_val.Text = "";
            Date_val.Text = "";
            Time_val.Text = "";
        }
        private void LoadAllDoctors() 
        {
            using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT DoctorID, Name, Specialty, Qualification, ConsultationFee FROM Doctor";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView_Left.DataSource = dt;
            }
        }

        private void dataGridView2_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            patientId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["PatientID"].Value);
            Selected_Patient_val.Text = patientId.ToString();
        }
    }
}
