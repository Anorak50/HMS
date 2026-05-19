using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.Main_panel.Controls.Count > 0)
            {
                //Main_panel.Controls[0].Dispose();
                this.Main_panel.Controls.RemoveAt(0);
            }
                
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(f);
            this.Main_panel.Tag = f;
            f.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            loadform(new DoctorsForm());
        }

        private void Left_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dash_side_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doc_left_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void patient_left_label_Click(object sender, EventArgs e)
        {
            loadform(new PatientForm());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new Admin());
        }
    }
}
