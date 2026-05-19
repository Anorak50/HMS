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
    public partial class Billing_Recep_Receptionist : Form
    {
        public Billing_Recep_Receptionist()
        {
            InitializeComponent();
        }
        decimal ConsultationFee = 0;
        decimal totalAmount = 0;
        decimal subtotal = 0;
        int appointmentId;
        private void Save_Patient_button_Click(object sender, EventArgs e)
        {
            if(Billing_Appointment_ID_value.Text == "" || ConsultationFee <=0)
            {
                MessageBox.Show("Please enter an appointment ID.");
                return;
            }
            if (!int.TryParse(Billing_Appointment_ID_value.Text, out appointmentId))
            {
                MessageBox.Show("Please enter a valid appointment ID.");
                return;
            }
            if (!decimal.TryParse(Billing_Discount_value.Text, out decimal discount))
            {
                MessageBox.Show("Please enter a valid discount.");
                return;
            }
            CalculateTotalAmount("subtotal");
            string paymentStatus = Pay_stat_val.Text == "" ? "Unpaid":"Paid";
            string invoiceNumber = "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
                {
                    con.Open();
                    appointmentId = int.Parse(Billing_Appointment_ID_value.Text);
                    string dupchk = "Select Count(*) From Invoice Where AppointmentID = @AppointmentID";
                    SqlCommand dupChk = new SqlCommand(dupchk, con);
                    dupChk.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    int chk = (int)dupChk.ExecuteScalar();
                    if (chk > 0)
                    {
                        MessageBox.Show("Invoice already exists for this appointment.");
                        return;
                    }
                    string query = "Insert Into Invoice (AppointmentID, InvoiceNumber, InvoiceDate, Subtotal, Discount, Tax, TotalAmount, PaymentStatus, PaymentMethod) " +
                                         "Values (@AppointmentID, @InvoiceNumber, @InvoiceDate, @Subtotal, @Discount, @Tax, @TotalAmmount, @PaymentStatus, @PaymentMethod)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AppointmentID", Billing_Appointment_ID_value.Text);
                    cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
                    cmd.Parameters.AddWithValue("@InvoiceDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Subtotal", ConsultationFee);
                    cmd.Parameters.AddWithValue("@Discount", decimal.Parse(Billing_Discount_value.Text));
                    cmd.Parameters.AddWithValue("@Tax", (ConsultationFee*0.05m)); 
                    cmd.Parameters.AddWithValue("@TotalAmmount", totalAmount);
                    cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    cmd.Parameters.AddWithValue("@PaymentMethod", Pay_method_val.Text);
                    //cmd.Parameters.AddWithValue("@GeneratedBy", 12); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing information saved successfully.");
                    ClearFields();
                    string showInvoicequery = "Select AppointmentID, InvoiceNumber, InvoiceDate, Subtotal, Discount, Tax, TotalAmount, PaymentStatus, PaymentMethod From Invoice Where AppointmentID = @AppointmentID";
                    SqlDataAdapter sd = new SqlDataAdapter(showInvoicequery, con);
                    sd.SelectCommand.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    Invoice_Info_dgv.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error during billing: " + ex.Message);
            }
        }

        private void App_Id_button_Click(object sender, EventArgs e)
        {
            if(Billing_Appointment_ID_value.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an appointment ID.");
                return;
            }
            
            if(!int.TryParse(Billing_Appointment_ID_value.Text, out appointmentId))
            {
                MessageBox.Show("Please enter a valid appointment ID.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
                {
                    con.Open();
                    string query = "Select p.Name As Patient, d.Name As Doctor, d.ConsultationFee, a.Date, a.AppointmentStatus " +
                        "From Appointment a " +
                        "Join Patient p On a.PatientID = p.PatientID " +
                        "Join Doctor d On a.DoctorID = d.DoctorID " +
                        "Where a.AppointmentID = @AppointmentID";
                    SqlDataAdapter sd = new SqlDataAdapter(query, con);
                    sd.SelectCommand.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    Invoice_Info_dgv.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"No Appointment found for the entered appointment ID: {appointmentId}. \nPlease put the correct ID.");
                        Billing_Patient_Name_value.Text = "";
                        ConsultationFee = 0;
                        return;
                    }
                    Billing_Patient_Name_value.Text = dt.Rows[0]["Patient"].ToString();
                    ConsultationFee = Convert.ToDecimal(dt.Rows[0]["ConsultationFee"]);
                    CalculateTotalAmount();
                }
            }
            catch(Exception ex) { MessageBox.Show("Error fetching appointment details: " + ex.Message); }
            
        }

        private void Billing_Discount_value_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
        void CalculateTotalAmount()
        {
            decimal.TryParse(Billing_Discount_value.Text.Trim(), out decimal discount);
            decimal tax = ConsultationFee * 0.05m;
            totalAmount = Math.Max(0, ConsultationFee - discount + tax);
            Billing_total_value.Text = totalAmount.ToString() + "Tk";
        }
        void CalculateTotalAmount(string Subtotal)
        {
            decimal.TryParse(Billing_Discount_value.Text.Trim(), out decimal discount);
            decimal tax = ConsultationFee * 0.05m;
            totalAmount = Math.Max(0, ConsultationFee - discount + tax);
            subtotal = totalAmount - tax;
            Billing_total_value.Text = subtotal.ToString() + "Tk";
            
        }
        void ClearFields()
        {
            ConsultationFee = 0;
            Billing_Appointment_ID_value.Text = "";
            Billing_Patient_Name_value.Text = "";
            Billing_Discount_value.Text = "";
            Billing_total_value.Text = "";
            Pay_stat_val.Text = "";
            Pay_method_val.Text = "";
        }

        private void Clear_Patient_button_Click(object sender, EventArgs e)
        {
           ClearFields();
        }

        private void Billing_Recep_Receptionist_Load(object sender, EventArgs e)
        {
            Pay_stat_val.SelectedIndex = 0;
            Pay_method_val.SelectedIndex = 0;
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True"))
                {
                    con.Open();
                    string query = "Select AppointmentID, InvoiceNumber, InvoiceDate, Subtotal, Discount, Tax, TotalAmount, PaymentStatus, PaymentMethod From Invoice";
                    SqlDataAdapter sd = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    Invoice_Info_dgv.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading billing information: " + ex.Message); }
        }
    }
}
