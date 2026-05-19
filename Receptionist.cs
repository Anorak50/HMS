using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            Cards_flowLayoutPanel3.Visible = false;
            if (this.Main_panel.Controls.Count > 0)
                this.Main_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(f);
            this.Main_panel.Tag = f;
            f.Show();
        }


        private void Logout_button_Click(object sender, EventArgs e)
        {
            Logout_button.BackColor = Color.FromArgb(37, 99, 235);
            Logout_button.ForeColor = Color.White;
            new loginForm().Show();
            this.Hide();
            //this.Close();
        }


        Color Default_BackColor = Color.Transparent;
        Color Default_ForeColor = Color.FromArgb(100, 116, 139);

        Color Active_BackColor = Color.FromArgb(37, 99, 235);
        Color Active_ForeColor = Color.White;


        private void ResetBackGroundColors()
        {
            Register_Patient_button.BackColor = Default_BackColor;
            Register_Patient_button.ForeColor = Default_ForeColor;

            book_Appoint_button.BackColor = Default_BackColor;
            book_Appoint_button.ForeColor = Default_ForeColor;

            Patient_History_button.BackColor = Default_BackColor;
            Patient_History_button.ForeColor = Default_ForeColor;

            Billing_button.BackColor = Default_BackColor;
            Billing_button.ForeColor = Default_ForeColor;

            Search_Records_button.BackColor = Default_BackColor;
            Search_Records_button.ForeColor = Default_ForeColor;

            Dashboard_button.BackColor = Default_BackColor;
            Dashboard_button.ForeColor = Default_ForeColor;
        }

        private void ActivateButton(Button button)
        {
            ResetBackGroundColors();
            button.BackColor = Active_BackColor;
            button.ForeColor = Active_ForeColor;
        }
        private void Register_Patient_button_Click(object sender, EventArgs e)
        {
            ActivateButton(Register_Patient_button);
            loadform(new Register_Patient_Receptionist());
        }

        private void book_Appoint_button_Click(object sender, EventArgs e)
        {
            ActivateButton(book_Appoint_button);
            loadform(new Book_Appointment_Receptionist());
        }

        private void Patient_History_button_Click(object sender, EventArgs e)
        {
            ActivateButton(Patient_History_button);
            loadform(new Patient_History_Receptionist());
        }

        private void Billing_button_Click(object sender, EventArgs e)
        {
            ActivateButton(Billing_button);
            loadform(new Billing_Recep_Receptionist());
        }

        private void Search_Records_button_Click(object sender, EventArgs e)
        {
            ActivateButton(Search_Records_button);
            loadform(new Search_Records_Receptionist());
        }

        private void Dashboard_button_Click(object sender, EventArgs e)
        {

            ActivateButton(Dashboard_button);
            new Receptionist().Show();
            this.Hide();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            new Receptionist().Show();
            this.Hide();
            //if(Main_panel.Controls.Count > 0) { Main_panel.Controls.RemoveAt(0); }
                
            //Cards_flowLayoutPanel3.Visible = true;
        }

        private void Done_Today_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Operations_flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_patient_button_Click(object sender, EventArgs e)
        {
            loadform(new Register_Patient_Receptionist());
        }

        private void Book_App_button_Click(object sender, EventArgs e)
        {
            loadform(new Book_Appointment_Receptionist());
        }

        private void PatientHistory_Quick_button_Click(object sender, EventArgs e)
        {
            loadform(new Patient_History_Receptionist());
        }

        private void Billing_Quick_button_Click(object sender, EventArgs e)
        {
            loadform(new Billing_Recep_Receptionist());
        }

        private void Search_records_Quick_button_Click(object sender, EventArgs e)
        {
            loadform(new Search_Records_Receptionist());
        }

        private void Receptionist_Load(object sender, EventArgs e)                   ///
        {
            string ConnectionString = "Data Source=NAFIS\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True";

            //if ()
            //{
            //    MessageBox.Show("Please enter a name to search.");
            //    return;
            //}
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                //string query = "SELECT p.PatientID, p.Name, FROM Patient p";
                string query = "Select * From Patient"; 
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                Dash_dgv.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No patients found.");
                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Closing Window", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
